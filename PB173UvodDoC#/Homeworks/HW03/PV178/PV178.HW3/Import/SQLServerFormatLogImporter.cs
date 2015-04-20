using PV178.HW3.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PV178.HW3.Entities;
using System.Text.RegularExpressions;
using System.Reflection;

namespace PV178.HW3.Import
{
    /// <summary>
    /// SQLServerFormatLogImporter class
    /// </summary>
    public class SQLServerFormatLogImporter : ILogImporter<SQLServerLogEvent>
    {
        /// <summary>
        /// Input file
        /// </summary>
        ILogStorage storage;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logStorage">Input file</param>
        /// <exception cref="ArgumentNullException">logStorage can not be null</exception>
        public SQLServerFormatLogImporter(ILogStorage logStorage)
        {
            if (logStorage == null)
                throw new ArgumentNullException("logStorage is null");

            storage = logStorage;
        }

        public List<SQLServerLogEvent> Import()
        {
            string[] SQLExp ={ @"^((\d{4}-(0\d|1[012])-([012]\d|3[01])) ((2[0123]|1[0-9]|0[0-9]):([0-59]\d):([0-59]\d))): "
                               ,@"'((?:http(?:s)?:\/\/)?(?:www\.)?([\w-.]*)\.\w{2,})': "
                               ,@"Error (\d{4}) " 
                               ,@"\(severity (0|[01][0-9]|2[0-4])\) at SQL Server "
                               ,@" database '(.*)'"
                               ,@"': (.*)$"};
            string[] lines = Regex.Split(storage.Load(), "\r\n");
            SQLServerLogEvent obj = new SQLServerLogEvent();
            PropertyInfo[] props = obj.GetType().GetProperties();
            List<SQLServerLogEvent> list = new List<SQLServerLogEvent>();

            foreach (string item in lines)
            {
                if (String.IsNullOrWhiteSpace(item))
                    continue;
                obj = new SQLServerLogEvent();

                Match[] matches = {Regex.Match(item, SQLExp[0]),Regex.Match(item, SQLExp[1]),
                                   Regex.Match(item, SQLExp[2]),Regex.Match(item, SQLExp[3]),
                                   Regex.Match(item, SQLExp[4]),Regex.Match(item, SQLExp[5])};
                try
                {
                    for (int i = 0; i < 6; i++)
                    {
                        foreach (Capture capture in matches[i].Groups[1].Captures)
                        {
                            props[i].SetValue(obj, Convert.ChangeType(capture.Value, props[i].PropertyType), null);
                        }  
                    }
                    list.Add(obj);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occured during values set up, further info : " + ex.Message.ToString());
                }
            }
            return list;
        }
    }
}
