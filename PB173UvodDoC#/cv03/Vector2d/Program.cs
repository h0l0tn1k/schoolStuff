using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2d
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2d vec2d = new Vector2d(8, 2);
            Vector3d vec3d = new Vector3d(1, 5, 3);

            Console.WriteLine(vec2d.Length().ToString());
            Console.WriteLine(vec3d.Length().ToString());

        }
    }

    class Vector2d : Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
          
        public Vector2d(double x,double y)
            :base()
        {
            X = x;
            Y = y;
            Console.WriteLine(rand.Next());
            Console.WriteLine(Magic());
        }

        public override double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        
        //int IVector.MagicNumber()
        //{
        //    throw new NotImplementedException();
        //}

        //void IVector.Magic()
        //{
        //    throw new NotImplementedException();
        //}
    
    }


    /// SEALED neda sa z triedy dedit
    
    class Vector3d : Vector2d 
    {
        public double Z { get; set; }

        public Vector3d(double x,double y, double z)
            :base(x,y)
        {
            Z = z;
        }

        public override double Length()
        {
            return base.Length() + 4;
        }
    }

    interface IVector
    {
        int MagicNumber();

        void Magic();
    }


    abstract class Vector 
    {
        protected Random rand;


        public abstract double Length();

        protected int Magic()
        {
            return 42;
        }

        protected Vector()
        {
            rand = new Random();
        }
    }
}
