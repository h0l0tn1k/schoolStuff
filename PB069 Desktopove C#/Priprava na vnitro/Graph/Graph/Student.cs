using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Student
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Grade Grade { get; set; }
        public Student(string studentName,DateTime birthday,Grade grade )
        {
            if (studentName == null || birthday == null)
                throw new ArgumentNullException("arguments can not be null.");
            Name = studentName;
            BirthDay = birthday;
            Grade = grade;
        }
        public override string ToString()
        {
            return String.Format("{0},{1},{2}", Name, BirthDay, Grade); 
        }
    }
}
