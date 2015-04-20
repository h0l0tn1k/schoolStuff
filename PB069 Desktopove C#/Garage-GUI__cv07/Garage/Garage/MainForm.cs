using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
    public partial class MainForm : Form
    {
        private List<Car> cars;

        public MainForm()
        {
            InitializeComponent();
            cars = new List<Car>();
        }

        private void newCar(object sender, EventArgs e)
        {
            CarDialog dialog = new CarDialog();
            DialogResult res = dialog.ShowDialog();
            if (DialogResult.OK == res && dialog.Car != null)
            {
                carListBox.Items.Add(dialog.Car);
                Invalidate();
            }
        }

        private void newGarage(object sender, EventArgs e)
        {
            foreach (Car item in cars)
            {
                cars.Remove(item);
            }

            Invalidate();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
