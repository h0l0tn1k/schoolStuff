using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class Complex
    {

        #region Variables
        private double _realPart;

        private double _imagPart;

        public double ImagPart
        {
            get { return _imagPart; }
            private set { _imagPart = value; }
        }
        
        public double Realpart
        {
            get { return _realPart; }
            private set { _realPart = value; }
        }

        #endregion


        #region Constructors
        public Complex(double realPart,double imagPart)
        {
            this.ImagPart = imagPart;
            this.Realpart = realPart;
        }
        #endregion


        #region Methods

        
        public override string ToString()
        {
            return String.Format("{0} {1}i",Realpart,ImagPart);
        }

        public static Complex Parse(string number) 
        {
            char[] znaky = new char[] { ' ', 'i' };
	        string[] nums = number.Split(znaky);

            //Console.WriteLine("\'{0}\' | \'{1}\'", nums[0],nums[1]);
            double real = double.Parse(nums[0]);
            double imag = double.Parse(nums[1]);

            return new Complex(real, imag);
        }

        public static Complex AddComplex(Complex a, Complex b)
        {
            return (new Complex(a.Realpart + b.Realpart, a.ImagPart + b.ImagPart));
        }

        public static Complex SubtractComplex(Complex a, Complex b)
        {
            return (new Complex(a.Realpart - b.Realpart, a.ImagPart - b.ImagPart));
        }

        public static Complex MultiplyComplex(Complex a, Complex b)
        {
            double realPart = a.Realpart*b.Realpart - a.ImagPart*b.ImagPart;
            double imagPart = a.ImagPart * b.Realpart + a.Realpart * b.ImagPart;
            return new Complex(realPart,imagPart);
        }

        public static Complex DivideComples(Complex a, Complex b)
        {
            double realPart = a.Realpart * b.Realpart + a.ImagPart * b.ImagPart;
            double imagPart = a.ImagPart * b.Realpart - a.Realpart * b.ImagPart;
            double val = b.ImagPart*b.ImagPart + b.Realpart*b.Realpart;

            return new Complex(realPart / val, imagPart/ val);
        }

        public static double AbsComplex(Complex a)
        {
            return Math.Sqrt( a.Realpart*a.Realpart + a.ImagPart*a.ImagPart);
        }
        
        #endregion
    }

}
