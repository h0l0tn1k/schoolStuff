using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Timers;

namespace HW04
{
    /// <summary>
    /// Main Folder Deamon Class, Watches given folder and prints changed files specified by filter 
    /// </summary>
    class FolderDeamon
    {

        #region Variables
        /// <summary>
        /// filter for files
        /// </summary>
        private string filter;
        /// <summary>
        /// folder to be watched
        /// </summary>
        private string folder;
        /// <summary>
        /// printer for printing
        /// </summary>
        private IPrintingMachine printer;
        /// <summary>
        /// watcher of file
        /// </summary>
        private FileSystemWatcher watcher;
        /// <summary>
        /// arguments for filter and folder
        /// </summary>
        private string[] arguments;
        #endregion


        /// <summary>
        /// Constructor for Folder Deamon Class
        /// </summary>
        /// <param name="machine">Printer</param>
        /// <param name="args">Arguments, Flags</param>
        public FolderDeamon(IPrintingMachine machine, string[] args)
        {
            if (machine == null)
                throw new ArgumentNullException("PrintingMachine is null.");
            if (args == null)
                throw new ArgumentNullException("Args is null.");
            filter = "";
            folder = "";
            printer = machine;
            watcher = null;
            arguments = args;
        }

        /// <summary>
        /// Starts folder watching on new thread
        /// </summary>
        public void Start()
        {
            ArgumentParser commands = new ArgumentParser(new string[] { "folder", "filter" }, arguments,'-','=');
            Dictionary<Flags, string> list = commands.GetFlags();
            
            ///if number of arguments > 0 that were given to this program
            if (list.Count > 0)
            {
                ///if was set custom folder for watching
                if (list.ContainsKey(Flags.folder))
                {
                    folder = list[Flags.folder];
                }
                else
                {
                    ///If wasnt set any folder set default
                    folder = Environment.CurrentDirectory;
                }
                /// Print info on console
                Console.Write("Folder \"" + folder + "\" is being watched");

                ///IF any filters are set
                if (list.ContainsKey(Flags.filter))
                {
                    filter = list[Flags.filter];
                    Console.WriteLine(" for \"" + filter + "\" files.");
                }
                else
                {
                    ///if none filters were selected
                    Console.WriteLine(" but no filter was selected.");
                    Console.WriteLine("Error!");
                    return;
                }
                ///Start watching folder for files on different thread
                SetPrinter(printer);
                Thread deamon = new Thread(fileWatcher);
                deamon.Start();
                deamon.Join();
            }
            else
            {
                Console.WriteLine("No given arguments.");
            }
        }

        /// <summary>
        /// Launches watcher and waits till esc key pressed
        /// </summary>
        private void fileWatcher()
        {
            try
            {
                watcher = new FileSystemWatcher(folder);
                watcher.WaitForChanged(WatcherChangeTypes.Created | WatcherChangeTypes.Changed, 100);
                watcher.Changed += new FileSystemEventHandler(print);
                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Press \'esc\' to quit the sample.");
                while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: " + e.Message);
                throw;
            }
        }

        /// <summary>
        /// Sets printer
        /// </summary>
        /// <param name="machine">Printer machine</param>
        public void SetPrinter(IPrintingMachine machine)
        {
            if (machine == null)
                throw new ArgumentNullException("Printer is null!");
            printer = machine;
            Console.WriteLine("Name of printer : " + printer.ToString());
        }

        /// <summary>
        /// Delegate for printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print(object sender, FileSystemEventArgs e)
        {
            try
            {
                byte[] buffer;
                FileStream fileStream = new FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                try
                {
                    int length = (int)fileStream.Length;  // get file length
                    buffer = new byte[length];            // create buffer
                    int count;                            // actual number of bytes read
                    int sum = 0;                          // total number of bytes read

                    // read until Read method returns 0 (end of the stream has been reached)
                    while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                        sum += count;  // sum is a buffer offset for next reading
                }
                finally
                {
                    fileStream.Close();
                }
                printer.Print(Encoding.UTF8.GetString(buffer,0,buffer.Length));

                System.Timers.Timer t = new System.Timers.Timer();
                ((FileSystemWatcher)sender).Changed -= new FileSystemEventHandler(print);
                t.Interval = 10;
                t.Elapsed += new ElapsedEventHandler(t_Elapsed);
                t.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            ((System.Timers.Timer)sender).Stop();
            watcher.Changed += new FileSystemEventHandler(print);
        }
    }
}
