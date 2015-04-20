using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv03
{
    public partial class Form1 : Form
    {
        private double num1 { get; set; }
        private bool isOperator;

        /// <summary>
        /// DELEGATE takes 2 double's and return one 
        /// </summary>
        ///private Func<double, double, double> operation();

        public Form1()
        {
            InitializeComponent();
            textBoxNumbers.BackColor = Color.WhiteSmoke;
            isOperator = false;
        }

        private void addSelfValue(object sender, EventArgs e)
        {
            textBoxNumbers.BackColor = Color.WhiteSmoke;
            Button btn = ((Button)sender);
            ///erase number 0
            if (textBoxNumbers.Text == "0")
                textBoxNumbers.Text = "";
            textBoxNumbers.Text += btn.Text;
        }

        private void addOperator(object sender, EventArgs e)
        {
            if (isOperator)
            {
                DialogResult result =  MessageBox.Show(
                    "Operator is already entered!\nDo you want to continue?",
                    "Warning",MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                
                ///Handle DialogResult

            }
            else
            {
                isOperator = true;
                try
                {
                    num1 = Convert.ToDouble(textBoxNumbers.Text);
                    textBoxNumbers.Text = ((Button)sender).Text;
                }
                catch (Exception)
                {
                    textBoxNumbers.BackColor = Color.Red;
                }
            }
        }

        private void btnClickEvaulate(object sender, EventArgs e)
        {
            double res = 0, num2 = 0;
            char oper = textBoxNumbers.Text[0];
            string number2 = textBoxNumbers.Text.Substring(1);
            textBoxNumbers.Text = "";
            isOperator = false;

            try
            {
                num2 = Convert.ToDouble(number2);
            }
            catch (Exception)
            {
                textBoxNumbers.BackColor = Color.Red;
                num1 = 0;
                textBoxNumbers.Text = "";
                return;
            }

            switch (oper) {
                case '+': res = num1 + num2;
                    break;
                case '-': res = num1 - num2;
                    break;
                case '/':
                    if(num2 != 0)
                        res = num1 / num2;
                    break;
                case '*': res = num1 * num2;
                    break;
                default:
                    textBoxNumbers.Text = "0";
                    break;
            }

            textBoxNumbers.Text = res.ToString();
            num1 = res;
        }

        private void removeDisplay(object sender, EventArgs e)
        {
            num1 = 0;
            textBoxNumbers.Text = "0";
            textBoxNumbers.BackColor = Color.WhiteSmoke;
        }
    }
}
