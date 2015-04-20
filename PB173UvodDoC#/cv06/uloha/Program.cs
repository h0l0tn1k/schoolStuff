using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace uloha
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown cd = new CountDown( () => Console.WriteLine("Start"), //func at start
                                          () => Console.WriteLine("End"), // func at end
                                          10, //duration
                                          2); //gap
            Thread thread1 = new Thread(new ThreadStart(cd.Start));
            thread1.Start();


            Console.WriteLine("Skuska");
        }


        class CountDown
        {
            private Action function1;
            private Action function2;
            private int ticks;
            private int gap;

            public CountDown(Action func1,Action func2,int ticks, int gap)
            {
                function1 = func1;
                function2 = func2;
                this.ticks = ticks;
                this.gap = gap;
            }

            public void Start()
            {
                Console.WriteLine("CountDown Launched");
                DateTime end = DateTime.Now.AddSeconds(ticks);

                while (DateTime.Now <= end)
                {
                    function1();
                    Thread.Sleep(gap*1000);
                    function2();
                }
            }
        }
    }
}
