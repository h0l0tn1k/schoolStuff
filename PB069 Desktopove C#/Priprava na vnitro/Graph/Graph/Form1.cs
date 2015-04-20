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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudent studentDialog = new AddStudent();
            if (studentDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Add(studentDialog.Student);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
