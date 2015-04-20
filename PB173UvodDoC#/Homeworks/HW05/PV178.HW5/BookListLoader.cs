using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Security.AccessControl;

namespace PV178.HW5
{
    class BookListLoader : IBookListLoader
    {
        public IEnumerable<BookListRecord> LoadList()
        {
            Console.WriteLine("Enter path+filename of file to decompress :");
            string path = @"C:\Users\stefan\Desktop\stefanmatta-\PB173UvodDoC#\Homeworks\HW05\PV178.HW5\Data\data.txt.gz";//Console.ReadLine();
            try
            {
                FileStream fStream = new FileStream(@path, FileMode.Open);
                FileInfo fi = new FileInfo(@path);
                string curFile = fi.FullName;
                string origName = curFile.Remove(curFile.Length - fi.Extension.Length);

                using(FileStream outFile = File.Create(origName))
                { 
                    using (GZipStream Decompress = new GZipStream(fStream,
                            CompressionMode.Decompress))
                    {
                        Decompress.CopyTo(outFile);
                        Decompress.Close();
                    }
                    outFile.Close();
                }
                TextFileLogStorage log = new TextFileLogStorage(origName);
                CsvLogImporter<BookListRecord> reader = 
                    new CsvLogImporter<BookListRecord>(log,
                    new string[] { "CourseCode","Teacher","Area","Course","Book",
                    "Edition","Author","Ibsn","New","Used","Rent"},
                    true, ';', ';');

                IEnumerable<BookListRecord> list = reader.Import();
                return list;
            }
            catch (IOException file)
            {
                Console.WriteLine("Error with file handling : " + file.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
