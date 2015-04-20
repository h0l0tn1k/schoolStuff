using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace blockBuster
{
    class Rectangle : PaintObject
    {
        public override string  Name { get{ return "Rectangle"; }}
        public Rectangle(int x,int y,int width,int height,Color color,Color border,bool fill = true)
        {
            X = x;
            Y = y;
            this.Width = width;
            Height = height;
            Colour = color;
            Border = border;
            Fill = fill;
        }
        public override void Paint(System.Drawing.Graphics g, int xOffset)
        {
            if (Fill)
            {
                g.FillRectangle(new SolidBrush(Colour), X, Y, Width, Height);
            }
            else
            {
                g.DrawRectangle(new Pen(Colour), X, Y, Width, Height);
            }
        }
    }
}
