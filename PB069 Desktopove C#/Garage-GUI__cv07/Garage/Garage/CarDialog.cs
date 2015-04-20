using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Garage
{
    public partial class CarDialog : Form
    {
        public Car Car { get; private set; }
        private string manufacturer;
        private Color color;
        private string licensePlate;
        private decimal price;
        private string petName;
        private decimal fuel;

        public CarDialog()
        {
            InitializeComponent();
            color = Color.Black;
            price = 0;
            Car = null;
            petName = null;
            fuel = 0;
        }

        private void setManufacturer(object sender, EventArgs e)
        {
            manufacturer = manufacturerComboBox.SelectedItem.ToString();
        }

        private void validateManufacturer(object sender, CancelEventArgs e)
        {
            if(!manufacturerComboBox.Items.Contains(manufacturerComboBox.Text))
            {
                errorProvider1.SetError(manufacturerComboBox,"Only use values in list!");
                e.Cancel = true;
            }
            else
            {
                manufacturer = manufacturerComboBox.Text;
                errorProvider1.SetError(manufacturerComboBox,null);
                e.Cancel = false;
            }
        }

        private void validatePetName(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                errorProvider1.SetError(nameTextBox, "Pet name can not be empty or white space!");
                e.Cancel = true;
            }
            else
            {
                petName = nameTextBox.Text;
                errorProvider1.SetError(nameTextBox, null);
                e.Cancel = false;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^[a-zA-Z0-9][A-Z][a-zA-Z0-9] \d{4}$");
            string plate = textBox1.Text;
            Match match = r.Match(plate);
            if (match.Success)
            {
                licensePlate = match.Value;
                errorProvider1.SetError(textBox1, null);
                e.Cancel = false;
            }
            else 
            {
                errorProvider1.SetError(textBox1, "Not correct License plate format!");
                e.Cancel = true;
            }
        }

        private void validatingPrice(object sender, CancelEventArgs e)
        {
            if (priceNumericUpDown.Value >= ((decimal)0) && priceNumericUpDown.Value <= ((decimal)25000000))
            {
                price = priceNumericUpDown.Value;
                errorProvider1.SetError(priceNumericUpDown, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(priceNumericUpDown, "Price range is 0-25,000,000!");
                e.Cancel = true;
            }
        }

        private void validatingFuel(object sender, CancelEventArgs e)
        {
            if (fuelNumericUpDown.Value >= ((decimal)0.0) && fuelNumericUpDown.Value <= ((decimal)100.0))
            {
                fuel = fuelNumericUpDown.Value;
                errorProvider1.SetError(fuelNumericUpDown, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(fuelNumericUpDown, "Fuel is in range [0.0,100.0]!");
                e.Cancel = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void colourButton_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            DialogResult res =  col.ShowDialog();

            if (DialogResult.OK == res)
            {
                color = col.Color;
                colourButton.BackColor = color;
                Invalidate();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (summerTiresRadioButton.Checked || winterTiresRadioButton.Checked) 
                {

                    Car = new Car(this.manufacturer, this.licensePlate, this.price);
                    Car.Name = this.petName;
                    Car.Tyres = (summerTiresRadioButton.Checked) ? TyreType.Summer : TyreType.Winter;
                    Car.Fuel = this.fuel;
                    Car.Colour = this.color;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
