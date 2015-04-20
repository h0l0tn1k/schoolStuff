using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SystemRectangle = System.Drawing.Rectangle;


namespace blockBuster
{
    public partial class Form1 : Form
    {
        private List<PaintObject> objects = new List<PaintObject>();
        private SystemRectangle canvas = new SystemRectangle(0, 0, 800, 500);
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.White, canvas);

            foreach (var item in objects)
            {
                 item.Paint(e.Graphics,0);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(canvas.Contains(e.Location))
            {
            }
        }
    }
}
