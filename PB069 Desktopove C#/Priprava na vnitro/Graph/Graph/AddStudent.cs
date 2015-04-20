using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class AddStudent : Form
    {
        public Student Student { get; private set; }
        public AddStudent()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student = new Student(textBoxStudnet.Text, dateTimePicker1.Value, ((Grade)comboBox1.SelectedIndex));
            DialogResult = DialogResult.OK;
        }

        private void textBoxStudnet_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxStudnet.Text))
            {
                errorProvider1.SetError(textBoxStudnet, "Student's name cannot be empty.");
                button1.Enabled = false;
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBoxStudnet, null);
                button1.Enabled = true;
                e.Cancel = false;
            }
        }
    }
}
