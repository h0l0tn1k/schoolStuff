using PV178.HW3.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace PV178.HW3.Import
{
    /// <summary>
    /// JsonLogImporter parses json from file into class objects T 
    /// </summary>
    /// <typeparam name="T">Type of class to store data into</typeparam>
    public class JsonLogImporter<T> : ILogImporter<T> where T : class, new()
    {
        /// <summary>
        /// Storage to read from
        /// </summary>
        private ILogStorage storage;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="logStorage">storage from which we will import data</param>
        /// <exception cref="ArgumentNullException">logStorage can not be null</exception>
        public JsonLogImporter(ILogStorage logStorage)
        {
            if (storage == null)
            {
                throw new ArgumentNullException("logStorage is null");
            }
            storage = logStorage;
        }
        public List<T> Import()
        {
            string containOfLog = storage.Load();
            if (String.IsNullOrWhiteSpace(containOfLog))
            {
                return null;
            }
            List<T> obj = null;
            try
            {
                obj = JsonConvert.DeserializeObject<List<T>>(containOfLog);
            }
            catch (Exception e)
            {
                Console.WriteLine("JsonParsing didn't go very well to be honest:" + e.Message);
            }
            return obj;
        }
    }
}
