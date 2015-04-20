using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorPaint
{
    abstract class DrawObject
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }

        public int X2 { get; set; }
        public int Y2 { get; set; }

        public Color Colour { protected get; set; }

        public bool Fill { protected get; set; }

        public abstract void Paint(Graphics g, int xOffset);

        public override string ToString()
        {
            return String.Format("{0} {1} ({2},{3})", Colour, GetType().Name, Math.Min(X1, X2), Math.Min(Y1, Y2));
        }
    }
}
