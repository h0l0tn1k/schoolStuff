using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV178.HW5
{
    internal class LinqBookListService: IBookListService
    {
        private IList<BookListRecord> _data;
        public LinqBookListService(IBookListLoader data)
        {
            if (data == null)
                throw new ArgumentNullException("Data is null!");
            _data = data.LoadList().ToList<BookListRecord>();
        }

        public IList<string> ListCoursesByFirstLetterOfCode(string startsWith)
        {
            if (startsWith == null)
                throw new ArgumentNullException("Řetězec startsWith nesmí být null.");

            var results = from record in _data
                          where record.CourseCode.StartsWith(startsWith, StringComparison.CurrentCultureIgnoreCase)
                          select (record.CourseCode + " " + record.Course);

            return results.ToList<string>();
        }

        public IEnumerable<string> ListAreas()
        {
            /// prve pismeno Uppercase ostatne lowercase aby Art a ART boli rovnake atd...
            return _data.Select(book => (book.Area[0].ToString().ToUpper() + book.Area.ToLower().Substring(1))).Distinct();
        }

        public IEnumerable<Tuple<string, int>> ListTeachers()
        {
            IList<BookListRecord> ss = _data.GroupBy(s => s.CourseCode.ToLowerInvariant()).Select(x => x.First()).ToList();
           
            var results = (from record in ss
                           group record by record.Teacher into teachers
                           select Tuple.Create(teachers.Key, teachers.Count())).OrderBy(s => s.Item1);
            return results;
        }

        public string[] CoursesWithoutBook()
        {
            return (from rec in _data
                                 where String.IsNullOrWhiteSpace(rec.Book)
                                 select rec.CourseCode).Distinct().ToArray<string>();
        }

        public bool AreAllBooksBuyable(string area)
        {
            if (area == null)
                throw new ArgumentNullException("area is null");
            return _data.Where(x => x.Area.ToLowerInvariant() == area.ToLowerInvariant()).All(x => (x.New > 0 || x.Used >0));
        }

        public bool IsAnyBookOfBookRentable(string area)
        {
            if(area == null)
                throw new ArgumentNullException("area is null");
            return _data.Where(x => x.Area.ToLowerInvariant() == area.ToLowerInvariant()).Any(x => x.Rent > 0); 
        }

        public int CountRentableBooks()
        {
            return _data.Where(x => x.Rent > 0).Count();
        }

        public int GetRoundedAveragePriceOfNewBook()
        {
            return (int) Math.Round(_data.Where(x => x.New > 0).Average(x => x.New));
        }

        public string GetFirstBookForCourse(string courseCode)
        {
            if (courseCode == null)
                throw new ArgumentNullException("Řetězec courseCode nesmí být null");
            if (String.IsNullOrWhiteSpace(courseCode))
                throw new ArgumentException("Řetězec courseCode nesmí být prázdný řetězec nebo obsahovat prázdné znaky.");

            return _data.Where(x => x.CourseCode.ToLowerInvariant() == courseCode.ToLowerInvariant()).First().Book;
        }

        public IEnumerable<Tuple<string, string>> ListAllCoursesWithArea()
        {
            List<BookListRecord> zoznam = _data.GroupBy(x => x.CourseCode.ToLowerInvariant()).Select(x => x.First()).ToList();

            return zoznam.Select(x => Tuple.Create<string, string>(x.CourseCode, x.Area));
        }

        public IDictionary<string, string> ListAllCoursesWithAreaAsDictionary()
        {
            IList<BookListRecord> zoznam = _data.GroupBy(x => x.CourseCode.ToLowerInvariant()).Select(x => x.First()).ToList();

            return zoznam.ToDictionary(x => x.CourseCode, y => y.Area);
        }

        public IEnumerable<Tuple<string, IEnumerable<string>>> ListTeachersAndCoursesWithoutBook()
        {
            IEnumerable<List<BookListRecord>> groups = _data.Where(x => String.IsNullOrWhiteSpace(x.Book)).GroupBy(x => x.Teacher).Select(group => group.ToList());
            
            return groups.Select(x => Tuple.Create<string, IEnumerable<string>>(x.First().Teacher, x.Select(y => y.CourseCode)));        
        }

        public IEnumerable<Tuple<string, int>> ListBookCountPerCourseUsingJoin(params string[] codes)
        {
            //IEnumerable<IGrouping<string,BookListRecord>> groups = _data.Join()

            throw new NotImplementedException();
        }

        public IEnumerable<string> ListCoursesWithMostExpensiveBook()
        {
            int max = _data.Where(price => price.New > 0).Max().New;
            return _data.Where(x => x.New > 0 && x.New == max).Select(x => x.CourseCode);
        }

        public IEnumerable<string> ListThreeMostExpensiveBooks(IEnumerable<string> areas)
        {
            if (areas == null)
                throw new ArgumentNullException("Parameter areas cannot be null.");
            List<string> _areas = new List<string>(areas.ToList().Select(x => x.ToLowerInvariant()));
            return  _data.Where(x => _areas.Contains(x.Area.ToLowerInvariant())).OrderByDescending(x => Math.Max(x.New, x.Used))
                .Take(3).Select(x => x.CourseCode);
        }
    }
}
