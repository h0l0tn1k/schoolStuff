using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cv05
{
    class Line : DrawObject
    {
        public override string Name
        {
            get { return "Line"; }
        }
        public override void Paint(Graphics g,int xOffset)
        {
            g.DrawLine(new Pen(Colour), X - xOffset, Y, Width, Height);
        }
    }
}
