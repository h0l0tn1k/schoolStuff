using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class NewMusicForm : Form
    {
        public Music Music { get;private  set; }
        public NewMusicForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Rating r = Rating.Alright;

            if(radioButton1.Checked)
            {
                r = Rating.Awful;
            }
            else if (radioButton2.Checked)
	        {
		        r = Rating.Awful;
	        }
            else
	        {
                r = Rating.Awesome;
	        }

            Music = new Music(textBox1.Text,textBox2.Text, r);
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrWhiteSpace( textBox1.Text) )
            {
                errorProvider1.SetError(textBox1, "Song name must not be empty or white space.");
                button1.Enabled = false;
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
                button1.Enabled = true;
                e.Cancel = false;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Author name must not be empty or white space.");
                button1.Enabled = false;
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox2, null);
                button1.Enabled = true;
                e.Cancel = false;
            }
        }
    }
}
