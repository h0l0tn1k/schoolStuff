using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV178.HW5
{
    class Program
    {
        static void Main(string[] args)
        {/*
            TextFileLogStorage stor = new TextFileLogStorage(
                    @"C:\Users\stefan\Desktop\stefanmatta-\PB173UvodDoC#\Homeworks\HW05\PV178.HW5\Data\data.txt.gz");
            CsvLogImporter<BookListRecord> rec = new CsvLogImporter<BookListRecord>
                (stor, new string[] { "CourseCode","Teacher","Area","Course","Book",
                    "Edition","Author","Ibsn","New","Used","Rent"},true,';',';');


            BookListLoader bloader = new BookListLoader();


            IEnumerable<BookListRecord> lst = bloader.LoadList();
            foreach (var item in lst)
            {
                Console.WriteLine(item.CourseCode + " " + item.Teacher + " " + item.Area + " " + item.Course);
            }*/

            BookListLoader bl= new BookListLoader();

            LinqBookListService service = new LinqBookListService(bl);
            //IList<string> list = service.ListCoursesByFirstLetterOfCode("AC");
            /*
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> areas = service.ListAreas();
            foreach (string item in areas)
            {
                Console.WriteLine(item);
            }
            */
            IEnumerable<Tuple<string, int>> res = service.ListTeachers();
            /*
            foreach (Tuple<string,int> item in res)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2);
            }*/

            /*
            string[] bezknihy = service.CoursesWithoutBook();
            foreach (string item in bezknihy)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(service.AreAllBooksBuyable("art"));*/

            IEnumerable<Tuple<string, IEnumerable< string>>> rs = service.ListTeachersAndCoursesWithoutBook();
            /*foreach (var item in rs)
            {
                Console.WriteLine(item.Item1 + ": ");
                foreach (var it in item.Item2)
                {
                    Console.WriteLine(it);
                }
                Console.WriteLine();
            }*/
            /*
            IEnumerable<string> areas = new List<string>{"art","Business Administration","Natural Sciences"};
            IEnumerable<string> najdrahsieKnihy = service.ListThreeMostExpensiveBooks(areas);

            Console.WriteLine("\n\nNajdrahsie Knihy");
            foreach (var item in najdrahsieKnihy)
            {
                Console.WriteLine(item);
            }*/

            foreach (var item in service.ListTeachersAndCoursesWithoutBook())
            {
                Console.WriteLine(item.Item1);
                foreach (var it in item.Item2)
                {
                    Console.Write(" " + it);
                }
                Console.WriteLine();
            }
        }
    }
}
