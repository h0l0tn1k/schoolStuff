using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//// ctrl + .  na doplnenie namaespace napriklad


namespace cv04
{
    public partial class Form1 : Form
    {
        private static readonly Rectangle _rectangle = new Rectangle(100, 80, 400, 200);

        private static readonly StringFormat _format = new StringFormat()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        private Color _backRectangleColor;
        private Color _frameRectangleColor;
        private Color _textColor;

        public Form1()
        {
            InitializeComponent();

            _backRectangleColor = new Color();
            _textColor = new Color();
            _frameRectangleColor = new Color();

            _backRectangleColor = Color.PowderBlue;
            _textColor = Color.Gray;
            _frameRectangleColor = Color.Goldenrod;
            textBoxInput.Text = "Your name here";
        }

        private void Kresli(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(_backRectangleColor),_rectangle);
            e.Graphics.DrawRectangle(new Pen(_frameRectangleColor,(float)borderWidthUpDown.Value), _rectangle);

            e.Graphics.DrawString(  textBoxInput.Text, 
                                    new Font("Calibri", 22.0f, FontStyle.Regular), 
                                    new SolidBrush(_textColor),
                                    _rectangle,
                                    _format);
        }

        private void btnDrawName_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            DialogResult res = dialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                if (((Button)sender).Text == "Background")
                    _backRectangleColor = dialog.Color;
                else if (((Button)sender).Text == "Text")
                    _textColor = dialog.Color;
                else
                    _frameRectangleColor = dialog.Color;
                Invalidate();
            }
        }

        private void btnBorderWidth(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
