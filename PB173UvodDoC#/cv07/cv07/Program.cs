using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass clas = new MyClass();
            clas.Obsluha += eventMethod;
            clas.Obsluha += eventMethod2;
            clas.MyMethod();

            Console.ReadKey(true);
        }

        static void eventMethod(object sender, EventArgs e)
        {
            Console.WriteLine("Udalost osetrena.1");
        }

        static void eventMethod2(object sender, EventArgs e)
        {
            Console.WriteLine("Udalost osetrena.2");
        }
    }

    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructor");
        }

        public void MyMethod()
        {
            Console.WriteLine("MyMethod");
            onMethodCall(EventArgs.Empty);
        }

        private void onMethodCall(EventArgs e)
        {
            if (Obsluha != null)
            {
                Obsluha(this, e);
            }
        }

        public event MyHandlerEventHandler Obsluha;
    }

    public delegate void MyHandlerEventHandler(object sender,EventArgs e);
}
