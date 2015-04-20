using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV178.HW2
{
    class Coordinates : ICoordinates
    {
        private int _left;
        private int _top;

        public int Left
        {
            get{ return _left; }
            set{ _left = value; }
        }

        public int Top
        {
            get { return _top;}
            set { _top = value;}
        }

        public Coordinates(int left,int top)
        {
            _left = left;
            _top = top;
        }

        public Coordinates()
        {

        }

        public bool IsInRectangle(int left, int top, int width, int height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentOutOfRangeException("Výška nebo šířka obdélníku je nulová nebo záporná.");

            if (_left >= left && _left <= left + width && _top >= top && _top <= top + height)
                return true;

            return false;
        }
    }
}
