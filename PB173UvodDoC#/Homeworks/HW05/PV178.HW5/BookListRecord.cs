using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV178.HW5
{
    internal class BookListRecord
    {
        public string CourseCode { get; set; }
        public string Teacher { get; set; }
        public string Area { get; set; }
        public string Course { get; set; }
        public string Book { get; set; }
        public string Edition { get; set; }
        public string Author { get; set; }
        public string Ibsn { get; set; }
        public int New { get; set; }
        public int Used { get; set; }
        public int Rent { get; set; }
    }
}
