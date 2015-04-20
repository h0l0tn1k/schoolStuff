using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace cv05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bit operator
            /*
            int a = 13 | 1;
            Console.WriteLine(a.ToString("x"));

            int b = 14 & 1;
            Console.WriteLine(b.ToString("x"));

            int c = 2 ^ 1; // XOR
            int d = ~a;
            Console.WriteLine(c);
            Console.WriteLine(d);
        
        
            ///FLAGS

            Dni pracovneDni,vikend;
            ///nastavit dni

            pracovneDni = Dni.Po |  Dni.Ut | Dni.Str | Dni.Stv | Dni.Pia;
            vikend = ~pracovneDni;

            Console.WriteLine(pracovneDni.HasFlag(Dni.Pia));
            Console.WriteLine(vikend.HasFlag(Dni.Ne));
            */
#endregion

            #region StringBuilder
            ///STRING BUILDER
            /*
            StringBuilder sb = new StringBuilder();
            sb.Append("anus");
            sb.Append(" cock");
            sb.Append(" bit of ballsack");
            Console.WriteLine(sb.ToString());
            */
            #endregion

            #region Regular Expresions

            ///rodne cislo
            Regex regEx = new Regex("[0-9]{2}(0[1-9]|1[0-2]|5[1-9]|6[0-2])(0[1-9]|[1-2][0-9]|3[0-1])[/][0-9]{3,4}");
            Console.WriteLine(regEx.IsMatch("940427/9841"));


            Regex reg = new Regex("Pat");

            Match match = reg.Match("Pat a Mat");

            Console.WriteLine(match.Success);
            Console.WriteLine("At index : " + match.Index);

            #endregion

            #region Generic Classes
            MyGenericClass<string> lst = new MyGenericClass<string>("Cauko");
            Console.WriteLine(lst[1]);

            #endregion
        }
    }

    class MyGenericClass<T>
        where T : class /*,IEnumerable<T>*/
    {
        private List<T> _list;


        public T this[int i]
        {
            get { 
                return _list[i];
            }
        }
        
        public MyGenericClass(T item)
        {
            _list = new List<T>();
            _list.Add(item);
        }

        
    }



    [Flags]
    enum Dni
    {
        Po = 1,
        Ut = 2,
        Str = 4,
        Stv = 8,
        Pia = 16,
        So = 32,
        Ne = 64
    }
}
