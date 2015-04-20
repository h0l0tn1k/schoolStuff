using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    class Program
    {
        static void Main(string[] args)
        {
            ///LIST
            List<Point> list = new List<Point>();

            
            ///Adding to list
            list.Add(new Point(10,10));
            list.Add(new Point(10, 20));

            ///Foreach is slower than for loop
            foreach (Point item in list)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }


    }
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}
