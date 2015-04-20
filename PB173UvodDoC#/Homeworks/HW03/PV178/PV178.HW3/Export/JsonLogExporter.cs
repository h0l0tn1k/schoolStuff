using PV178.HW3.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PV178.HW3.Export
{
    /// <summary>
    /// JsonLogExporter exports List<T> into json file 
    /// </summary>
    /// <typeparam name="T">Type of class</typeparam>
    public class JsonLogExporter<T> : ILogExporter<T> where T : class, new()
    {
        /// <summary>
        /// Output File
        /// </summary>
        ILogStorage storage;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logStorage">Output File</param>
        /// <exception cref="ArgumentNullException">logStorage is null</exception>
        public JsonLogExporter(ILogStorage logStorage)
        {
            if (logStorage == null)
                throw new ArgumentNullException("logStorage is null!");
            storage = logStorage;
        }
        public void Export(List<T> data)
        {
            if (data == null)
            {
                Console.WriteLine("No data to export!");
                return;
            }
            try
            {
                string res = JsonConvert.SerializeObject(data);
                storage.Save(res);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to export Json data: " + e.Message);
            }
        }
    }
}
