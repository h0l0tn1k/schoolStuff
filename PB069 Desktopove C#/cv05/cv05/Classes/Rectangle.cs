using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace cv05
{
    class Rectangle : DrawObject
    {
        public override string Name 
        {
            get { return "Rectangle"; }
        }
        public override void Paint(Graphics g,int xOffset)
        {
            if (Fill)
            {
                g.FillRectangle(new SolidBrush(Colour), X - xOffset, Y, Width, Height);
            }
            else
            {
                g.DrawRectangle(new Pen(Colour), X - xOffset, Y, Width, Height);
            }
        }
    }
}
