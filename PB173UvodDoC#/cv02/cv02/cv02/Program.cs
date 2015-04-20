using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class Program
    {
    //    static void Main(string[] args)
    //    {
    //        ///Nullable types
    //        int? i = null;
    //        int? j = 15;


    //        /// POMOCOU HAS VALUE
    //        if(i.HasValue)
    //            Console.WriteLine("{0},{1}", j.Value.ToString(),i.ToString());
    //        else
    //            Console.WriteLine("{0}",j.Value.ToString());


    //        /// POMOCOU     ??
    //        i = i ?? 15;
    //        Console.WriteLine("Serus {0}",i);


    //        /// RANDOM
    //        Random rnd = new Random();
    //        int l = rnd.Next(0, 100);
    //        Console.WriteLine("{0}",l.ToString());


    //        /// MyClass 
    //        MyClass mcl = new MyClass();
    //        mcl.MyMethod();
    //        mcl.MyMethod("Nasrac.");
    //        mcl.OptMethod();
    //        mcl.OptMethod("Serus");
    //        mcl.XCoord = 10;
    //        Console.WriteLine(mcl.XCoord.ToString());


    //        ///Pouzitie STATIC metody
    //        Console.WriteLine(MyClass.Number("ahoj").ToString());
    //    }

        static void Main(string[] args)
        {
            Complex c = new Complex(1, 1);
            Complex a = new Complex(0, 1);

            ///Adding
            Console.WriteLine(Complex.AddComplex(c,a).ToString());
            ///Substract
            Console.WriteLine(Complex.SubtractComplex(c,a).ToString());
            ///Multiplying
            Console.WriteLine(Complex.MultiplyComplex(c,a).ToString());

            Console.WriteLine(Complex.Parse("-1 -1i") );
        }
    }
}
