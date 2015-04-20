using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cv05
{
    class Ellipse : DrawObject
    {
        public override string Name
        {
            get { return "Ellipse"; }
        }
        public override void Paint(Graphics g,int xOffset)
        {
            if (Fill)
            {
                g.FillEllipse(new SolidBrush(Colour), X - xOffset, Y, Width, Height);
            }
            else
            {
                g.DrawEllipse(new Pen(Colour), X - xOffset, Y, Width, Height);
            }
            
        }
    }
}
