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
    public partial class NewTaskDialog : Form
    {
        public Task Task { get; private set; }
        public NewTaskDialog()
        {
            InitializeComponent();
            radioButtonLow.Checked = true;
            dateTimePicker.Value = DateTime.Now;

            //not recommended
            //dateTimePicker.MinDate = DateTime.Now;
        }

        private void btnTaskCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Task = new Task(textBoxNameTask.Text);
                Task.Deadline = dateTimePicker.Value;

                if (radioButtonHigh.Checked)
                    Task.Priority = TaskPriority.High;
                else if (radioButtonLow.Checked)
                    Task.Priority = TaskPriority.Low;
                else if(radioButtonMedium.Checked)
                    Task.Priority = TaskPriority.Medium;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void textBoxNameTask_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxNameTask.Text))
            {
                errorProvider1.SetError(textBoxNameTask, "Task name can not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBoxNameTask, null);
                e.Cancel = false;
            }
        }

        private void dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePicker.Value < DateTime.Today)
            {
                errorProvider1.SetError(dateTimePicker, "Deadline has to be in the future!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dateTimePicker, null);
                e.Cancel = false;
            }
        }
    }
}
