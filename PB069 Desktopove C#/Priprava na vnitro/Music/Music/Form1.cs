using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMusicForm dialog = new NewMusicForm();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (dialog.Music != null)
                {
                    listBox1.Items.Add(dialog.Music);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".mml";
            fileDialog.Filter = "Music Library Files (*.mml)|";
            fileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName != null)
                {
                    listBox1.Items.Clear();
                    StreamReader sr = new StreamReader(fileDialog.FileName);
                    string contain = sr.ReadToEnd();
                    string[] lines = contain.Split(new char[] { '\n' });

                    foreach (string item in lines)
                    {
                        if (string.IsNullOrWhiteSpace(item))
                            break;
                        string[] it = item.Split(new char[] { ';' });
                        if(it != null)
                        {
                            Rating r = Rating.Awful;
                            if(it[2] == "Awesome")
                            {
                                r = Rating.Awesome;
                            }
                            else if(it[2] == "Awful")
                            {
                                r = Rating.Awful;
                            }
                            else
	                        {
                                r = Rating.Alright;
	                        }
                            listBox1.Items.Add(new Music(it[0],it[1],r));
                        }
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            saveDialog.OverwritePrompt = true;
            saveDialog.Title = "Save Music Library";
            saveDialog.Filter = "Music Library File (*.mml)|";
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string nameOfFile = saveDialog.FileName + ".mml";
                StreamWriter sw = new StreamWriter(nameOfFile);
                string outPut = "";

                foreach (Music item in listBox1.Items)
                {
                    outPut += item.ToPrint();
                    outPut += Environment.NewLine;
                }
                MessageBox.Show(outPut);
                sw.Write(outPut);
                sw.Close();
            }
        }
    }
}
