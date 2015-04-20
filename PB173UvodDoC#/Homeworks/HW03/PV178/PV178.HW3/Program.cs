using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PV178.HW3.Storage;
using PV178.HW3.Import;
using PV178.HW3.Export;
using PV178.HW3.Entities;

namespace PV178.HW3
{
    class Program
    {
        private static List<SQLServerLogEvent> logs;
        static void Main(string[] args)
        {
            while (menu())
            { }
        }

        /// <summary>
        /// Shows menu for selecting operations
        /// </summary>
        /// <returns>true show again</returns>
        private static bool menu()
        {
            Console.WriteLine("SQL log Converter\n");
            Console.WriteLine("1) Load Log");
            Console.WriteLine("2) Export Log");
            Console.WriteLine("3) Exit");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                logs.Clear();
                return load();
            }
            else if (choice == "2")
            {
                return export();
            }
            else if (choice == "3")
            {
                return false;
            }
            else {
                Console.WriteLine("Bad Choice![1-3]\n\n");
                menu();
            }
            return false;
        }

        /// <summary>
        /// Provides export functionality
        /// </summary>
        /// <returns>true if continue</returns>
        private static bool export()
        {
            if (logs.Count == 0)
            {
                Console.WriteLine("Nothing loded!");
                return true;
            }
            Console.WriteLine("Path to file + filename: ");
            string path = Console.ReadLine();
            Console.WriteLine("Type of file to export [csv,json]: ");
            string type = Console.ReadLine();
            TextFileLogStorage storage = new TextFileLogStorage(@path);

            switch (type)
            {
                case "csv" :
                    exportFile(storage, LogType.Csv);
                    break;
                case "json":
                    exportFile(storage, LogType.Json);  
                    break;
                default:
                    break;
            }

            return true;
        }

        /// <summary>
        /// Provides load functionality
        /// </summary>
        /// <returns>true if continue</returns>
        private static bool load()
        {
            Console.WriteLine("Path to file: ");
            string path = Console.ReadLine();
            Console.WriteLine("Type of file to import [csv,json,txt]: ");
            string type = Console.ReadLine();
            TextFileLogStorage storage = new TextFileLogStorage(@path);

            switch (type)
            {
                case "csv": logs = loadFile(storage,LogType.Csv);
                                break;
                case "json" : logs = loadFile(storage,LogType.Json);
                                break;
                case "sql": logs = loadFile(storage,LogType.Sql);
                                break;         
                default:
                    break;
            }

            return true;
        }

        /// <summary>
        /// Helper function for export()
        /// </summary>
        /// <param name="storage">Output file</param>
        /// <param name="t">type fo file</param>
        private static void exportFile(ILogStorage storage,LogType t)
        {
            switch (t)
            {
                case LogType.Csv:
                    Console.WriteLine("Has header? t/f");
                    string ret = Console.ReadLine();
                    Console.WriteLine("Column delimiter sign: ");
                    char columnDelimiter = Console.ReadLine()[0];
                    Console.WriteLine("Text qualifier sign: ");
                    char qualifier = Console.ReadLine()[0];
                    bool header = (ret == "t") ? true: false;
                    CsvLogExporter<SQLServerLogEvent> csv = new CsvLogExporter<SQLServerLogEvent>(storage, 
                            new string[] { "EventTime", "ServerName","ErrorNumber","ErrorSeverity",
                                           "DatabaseName","ErrorMessage" }, header, columnDelimiter, qualifier);
                    csv.Export(logs);
                    break;
                case LogType.Json:
                    JsonLogExporter<SQLServerLogEvent> json = new JsonLogExporter<SQLServerLogEvent>(storage);
                    json.Export(logs);
                    break;
            }
        }

        /// <summary>
        /// Helper function for laod() function
        /// </summary>
        /// <param name="storage">Input file</param>
        /// <param name="t">type fo file</param>
        /// <returns>true if continue</returns>
        private static List<SQLServerLogEvent> loadFile(ILogStorage storage, LogType t)
        {
            switch (t)
            {
                case LogType.Csv:
                    Console.WriteLine("Has header? t/f");
                    string ret = Console.ReadLine();
                    Console.WriteLine("Column delimiter sign: ");
                    char columnDelimiter = Console.ReadLine()[0];
                    Console.WriteLine("Text qualifier sign: ");
                    char qualifier = Console.ReadLine()[0];
                    bool header = (ret == "t") ? true: false;
                    CsvLogImporter<SQLServerLogEvent> csvImp = new CsvLogImporter<SQLServerLogEvent>
                        (storage, new string[] { "EventTime", "ServerName","ErrorNumber","ErrorSeverity","DatabaseName","ErrorMessage" }, header, columnDelimiter, qualifier);
                    return csvImp.Import();
                case LogType.Json:
                    JsonLogImporter<SQLServerLogEvent> jsonImp = new  JsonLogImporter<SQLServerLogEvent>(storage);
                    return jsonImp.Import();
                case LogType.Sql:
                    SQLServerFormatLogImporter sqlImp = new SQLServerFormatLogImporter(storage);
                    return sqlImp.Import();
                default:
                    break;
            }
            return null;
        }

        /// <summary>
        /// Type of file
        /// </summary>
        enum LogType
        {
            Csv,
            Json,
            Sql
        }
    }
}
