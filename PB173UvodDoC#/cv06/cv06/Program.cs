using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace cv06
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate int LambdaDelegate(int a);

        static void Main(string[] args)
        {
            /*  
            MyDelegate del = method1;
            del();

            del = method2;
            del();

            //anonymous method
            del = delegate() 
            { 
                Console.WriteLine("Serus Anonymus");
            };
            del();

            delegateList();

            myMethod(delegate() { Console.WriteLine("===Delegat==="); });

            ///LAMBDA
            myMethod(() => { Console.WriteLine("Lambda"); });

            LambdaDelegate lamb = (x) => x * x;
            Console.WriteLine(lamb(5));
            */

            Thread thread1 = new Thread(new ThreadStart(method1));
            thread1.Start();
            Console.WriteLine("Vypis");

            Console.ReadKey(true);
        }

        static void method1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("method1");
        }

        static void method2()
        {
            Console.WriteLine("method2");
        }

        static void myMethod(Action function)
        {
            Console.WriteLine("Calling function in delegate parameter:");
            function();
        }


        static void delegateList()
        {
            List<MyDelegate> list = new List<MyDelegate>();

            for (int i = 0; i < 7; i++)
            {
                int tmp = i * 10;
                list.Add(
                    delegate() 
                    {
                        Console.WriteLine("Function " + tmp.ToString());
                        tmp++;
                    }
                    );
            }

            foreach (MyDelegate item in list)
            {
                item();
            }
            Console.WriteLine("------------");

            list[0]();
            list[0]();
            list[0]();
            list[0]();
            list[4]();
            list[4]();
            list[4]();
            list[4]();
        }
    }
}
