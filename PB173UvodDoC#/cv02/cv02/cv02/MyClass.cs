using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class MyClass
    {

        #region Variables

        public static double PI = Math.PI;

        private int _x;
        private Random _rnd;

        public Random RndNumber
        {
            get { return _rnd; }
            private set { _rnd = value; }
        }
        
        public int XCoord
        {
            get { return _x; }
            set {   
                    if(value >=0)
                        _x = value;
                }
        }
        
        #endregion


        #region Constructors
        ///Privatny konstruktor
        ///private MyClass()
        ///{
        ///
        ///}
        ///zakazuje vytvorenie instancie triedy, napr. na pouzitie iba statickych metod




        //// RETAZENIE KONSTRUKTOROV
        public MyClass()
        {
            this.RndNumber = new Random();
            Console.WriteLine("Random " + RndNumber.Next(0,100));
        }

        public MyClass(string s) :this()
        {
            Console.WriteLine(s);
        }

        public MyClass(int a, string b) :this(b)
        {
            Console.WriteLine(a.ToString());
        }
        
        #endregion


        #region Methods
        public void MyMethod()
        {
            Console.WriteLine("Cauky ja som metoda.");
        }

        public void MyMethod(string s)
        {
            Console.WriteLine("Cauky ja som metoda." + s);
        }


        /// Default parameter s
        public void OptMethod(string s = "Opt")
        {
            Console.WriteLine(s);
        }


        public static int Number(string s)
        {
            return s.Length;
        }
        #endregion



    }
}
