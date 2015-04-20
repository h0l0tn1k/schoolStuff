using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace blockBuster
{
    abstract public class PaintObject
    {
        public abstract string Name { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public Color Colour { get; set; }
        public Color Border { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Fill { get; set; }
        public abstract void Paint(Graphics g, int xOffset);

        public override string ToString()
        {
            return String.Format("{0} {1} ({2}x{3})", Colour, Name, Width, Height);
        }
    }
}
