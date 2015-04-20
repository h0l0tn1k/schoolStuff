using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTaskDialog diag = new NewTaskDialog();

            if(diag.ShowDialog() == DialogResult.OK)
            {
                checkedListBox1.Items.Add(diag.Task);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedItem != null 
                && !(checkedListBox1.SelectedItem as Task).Complete)
            {
                btnCheck.Enabled = true;
                labelTimeLeft.Visible = true;
                labelTimeLeft.Text = ((checkedListBox1.SelectedItem as Task).Deadline - DateTime.Now ).Days.ToString() + " days left.";
            }
            else
            {
                btnCheck.Enabled = false;
                labelTimeLeft.Visible = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Task selectedTask = (checkedListBox1.SelectedItem as Task);
            int selectedIndex = checkedListBox1.SelectedIndex;

            selectedTask.Complete = true;

            checkedListBox1.Items.RemoveAt(selectedIndex);
            checkedListBox1.Items.Insert(selectedIndex, selectedTask);
            checkedListBox1.SetItemChecked(selectedIndex, true);
        }
    }
}
