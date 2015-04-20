using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Timers;

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Command line printer
            IPrintingMachine printer = new CommandLinePrinter();

            ///Basic usage of FolderDeamon
            FolderDeamon deamon = new FolderDeamon(printer, args);

            ///Starting Folder Deamon runs on different thread
            deamon.Start();
        }
    }
}
