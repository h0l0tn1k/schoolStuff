﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorPaint
{
    class Rectangle : DrawObject
    {
        public override void Paint(Graphics g, int xOffset)
        {
            if (Fill)
            {
                g.FillRectangle(new SolidBrush(Colour), Math.Min(X1, X2) + xOffset, Math.Min(Y1, Y2),
                    Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));
            }
            else
            {
                g.DrawRectangle(new Pen(Colour), Math.Min(X1, X2) + xOffset, Math.Min(Y1, Y2),
                    Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));
            }
        }
    }
}