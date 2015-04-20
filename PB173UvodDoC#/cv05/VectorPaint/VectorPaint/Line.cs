using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorPaint
{
    class Line : DrawObject
    {
        public override void Paint(Graphics g, int xOffset)
        {
            g.DrawLine(new Pen(Colour), X1 + xOffset, Y1, X2 + xOffset, Y2);
        }
    }
}
