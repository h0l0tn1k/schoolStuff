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

namespace VectorPaint
{
    public partial class MainForm : Form
    {
        private SystemRectangle canvas = new SystemRectangle(50, 50, 400, 300);

        private List<DrawObject> objects;
        private DrawObject currentObject;
        private bool isDrawing;

        public MainForm()
        {
            InitializeComponent();

            objects = new List<DrawObject>();
            currentObject = null;
            isDrawing = false;

            rectangleToolStripMenuItem.Click += InitialiseTool;
            ellipseToolStripMenuItem.Click += InitialiseTool;
            lineToolStripMenuItem.Click += InitialiseTool;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(Brushes.White, canvas);

            foreach (DrawObject obj in objects)
            {
                if ((hScrollBar.Value + canvas.X) < Math.Min(obj.X1, obj.X2) &&
                    (hScrollBar.Value + canvas.X + canvas.Width) > Math.Max(obj.X1, obj.X2))
                {
                    obj.Paint(e.Graphics, -hScrollBar.Value);
                }
            }

            if (currentObject != null)
            {
                if ((hScrollBar.Value + canvas.X) < Math.Min(currentObject.X1, currentObject.X2) &&
                    (hScrollBar.Value + canvas.X + canvas.Width) > Math.Max(currentObject.X1, currentObject.X2))
                {
                    currentObject.Paint(e.Graphics, -hScrollBar.Value);
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentObject = new Rectangle();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                isDrawing = false;
                return;
            }

            if (currentObject != null && canvas.Contains(e.Location))
            {
                if (isDrawing)
                {
                    isDrawing = false;

                    objects.Add(currentObject);
                    currentObject = null;

                    drawObjectListBox.DataSource = null;
                    drawObjectListBox.DataSource = objects;

                    Invalidate();
                }
                else
                {
                    currentObject.X1 = (e.X + hScrollBar.Value);
                    currentObject.Y1 = e.Y;

                    isDrawing = true;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objects.Clear();

            drawObjectListBox.DataSource = null;
            drawObjectListBox.DataSource = objects;

            Invalidate();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog diag = new ColorDialog();
            diag.Color = colourToolStripMenuItem.BackColor;

            if(diag.ShowDialog() == DialogResult.OK)
            {
                colourToolStripMenuItem.BackColor = diag.Color;

                if (currentObject != null)
                {
                    currentObject.Colour = diag.Color;
                }
            }
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentObject = new Ellipse();
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentObject = new Line();
        }

        private void InitialiseTool(object sender, EventArgs e)
        {
            isDrawing = false;
            currentObject.Colour = colourToolStripMenuItem.BackColor;
            currentObject.Fill = fillToolStripMenuItem.Checked;
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentObject != null)
            {
                currentObject.Fill = fillToolStripMenuItem.Checked;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentObject != null && canvas.Contains(e.Location) && isDrawing)
            {
                currentObject.X2 = (e.X + hScrollBar.Value);
                currentObject.Y2 = e.Y;

                Invalidate();
            }
        }
    }
}
