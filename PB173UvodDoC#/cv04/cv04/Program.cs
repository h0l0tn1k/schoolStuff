using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Months mnt;

            Console.WriteLine("\n\n\n");

            ///SWITCH

            Console.WriteLine((mnt = (Months)rnd.Next(0, 11)).ToString());
            switch (mnt)
            {
                case Months.March: Console.WriteLine("YES!");
                    break;
                default: Console.WriteLine("Netrafil si!");
                    break;
            }



            /// TRY CATCH


            try
            {
                int x = 5, y = 0, z;

                if (y == 0)
                    throw new MyException("Dividing by zero!");
                else
                    z = x / y;
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                ///Vykona sa pri vyhodeni vynimky aj bez nej
                Console.WriteLine("#################");
            }


            string martin = "___:-)___";

            Console.WriteLine(ExtensionClass.Quotes(martin,"!"));
            ///Extension methods
            Console.WriteLine(  martin.Quotes("!")                 );



            ///ARRAY
            int[] pole = new int[5];
            int[] pole2 = new int[] {1,2,3,4,5};

            Console.WriteLine(pole[0].ToString() + pole2[0].ToString());



            /// MULTIDIM ARRAY

            string[,] people = new string[3, 2];

            people[0, 0] = "Martinus";
            people[0, 1] = "Sevcikus";

            Console.WriteLine((people[0,0] + " " + people[0,1]).Quotes(" KOKOT "));


            string[][] poleP = new string[5][];
            for (int i = 0; i < poleP.Length; i++)
            {
                poleP[i] = new string[i + 1];
            }

        }
    }



    /// <summary>
    /// Extension methods 
    /// </summary>

    static class ExtensionClass 
    { 
    
        public static string Quotes(this string str,string border)
        {
            return string.Format(border + str + border);
        }
    }





    /// <summary>
    /// New exception class
    /// </summary>

    class MyException : Exception
    { 
        public MyException (string message)
	        :base(message)
        {

	    }
    }





    /// <summary>
    /// Enum Months
    /// </summary>

    enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
