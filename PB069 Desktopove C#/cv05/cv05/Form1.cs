using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


///custom renaming (Rectangle in Rectangle.cs versus System.drtawng.rectangle
using SystemRectangle = System.Drawing.Rectangle;

namespace cv05
{
    public partial class Form1 : Form
    {
        private SystemRectangle canvas = new SystemRectangle(50, 50, 500, 360);

        private List<DrawObject> objects;

        private DrawObject currentTool;

        private bool isDrawing;

        private bool fill;

        public Form1()
        {
            InitializeComponent();
            objects = new List<DrawObject>();
            isDrawing = false;
            currentTool = null;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.White,canvas);

            foreach (var item in objects)
            {
                if((item.X > (hScrollCanvasBar.Value * 4)) && 
                   (item.X + item.Width < ((hScrollCanvasBar.Value*4) + 400)))
                { 
                    item.Paint(e.Graphics,hScrollCanvasBar.Value*4);
                }
            }
        }

        #region ToolStrips


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objects.Clear();
            Invalidate();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTool = new Rectangle()
            {
                Colour = colorToolStripMenuItem.BackColor,
                Fill = fill
            };
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog diag = new ColorDialog();
            diag.Color = colorToolStripMenuItem.BackColor;

            if (diag.ShowDialog() == DialogResult.OK)
            {
                colorToolStripMenuItem.BackColor = diag.Color;
            }
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTool = new Ellipse()
            {
                Colour = colorToolStripMenuItem.BackColor,
                Fill = fill
            };
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTool = new Line()
            {
                Colour = colorToolStripMenuItem.BackColor
            };
        }
        #endregion

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentTool == null)
            { 
                return;
            }

            if (canvas.Contains(e.Location))
            {
                if (isDrawing)
                {
                    if (currentTool is Line) 
                    {
                        currentTool.Width = e.Location.X;
                        currentTool.Height = e.Location.Y;
                    }
                    else
                    {
                        ///kreslenie dolava
                        if (e.Location.X - currentTool.X < 0)
                        {
                            currentTool.Width = -1 * (e.Location.X + hScrollCanvasBar.Value * 4 - currentTool.X);
                            currentTool.X = e.Location.X;
                        }
                        else
                        {   ///rkeslenie doprava
                            currentTool.Width = e.Location.X + hScrollCanvasBar.Value * 4 - currentTool.X;
                        }

                        ///kreslenie dohora 
                        if (e.Location.Y - currentTool.Y < 0)
                        {
                            currentTool.Height = -1 * (e.Location.Y - currentTool.Y);
                            currentTool.Y = e.Location.Y;
                        }
                        else
                        {
                            ///kreslenie dole
                            currentTool.Height = e.Location.Y - currentTool.Y;
                        }
                    }


                    objects.Add(currentTool);
                    drawObjectListBox.Items.Add(currentTool);
                    currentTool = null;
                    isDrawing = false;
                    Invalidate();
                }
                else
                { 
                    currentTool.X = e.Location.X + (hScrollCanvasBar.Value)*4;
                    currentTool.Y = e.Location.Y;
                
                    isDrawing = true;
                }
            }
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fillToolStripMenuItem.Checked)
            {
                fillToolStripMenuItem.Checked = fill = false;
            }
            else
                fillToolStripMenuItem.Checked = fill = true;
        }

        private void scrollbarchanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        

    }
}
