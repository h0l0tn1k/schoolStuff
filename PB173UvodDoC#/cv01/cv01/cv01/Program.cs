using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine(Factorial(10));

            /// Beeping sound from console
            Console.Beep();

            ///Color Settings
            Console.BackgroundColor = ConsoleColor.Blue;

            
            Console.WriteLine("Cauko" + "!");
            string s = Console.ReadLine();

            ///Converting string (PARSING)          THROWS EXCEPTION
            //i = Convert.ToInt32(s);
            //Console.WriteLine("Number + 1 = {0}", (++i).ToString());

            ///Another way of parsing               Without an Exeption
            Console.WriteLine((Int32.TryParse(s, out i) ? "parsed" : "failed"));
            Console.WriteLine("Number + 1 = {0}",(++i).ToString());


            /// Formating string
            //s = string.Format("[{0}]{1}", s, s);
            //Console.WriteLine(s);



            /// NULLABLE DATA TYPES
            int? j = null;
            j = 10;
            Console.WriteLine(++j);


            /// VAR DATA TYPE
            var x = 6;
            var y = "string";
            var z = .7;
            var list = new List<List<string>>();

            Console.WriteLine(x.ToString() + " " + y + " " + z.ToString());

        }

        /// <summary>
        /// Computes factorial of given number
        /// </summary>
        /// <param name="x">number to be factorialized</param>
        /// <returns>factorial of number x</returns>
        public static int Factorial(int x)
        {
            if (x < 0)
                throw new ArgumentOutOfRangeException();
            
            if (x == 0)
                return 1;

            int l = 1;
            for (int i = 1; i <= x; i++)
            {
                l *= i;
            }

            return l;
        }
    }
}
