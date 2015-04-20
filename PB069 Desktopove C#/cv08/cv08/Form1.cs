using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void listViewLiveStockMarket_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewLiveStockMarket.DoDragDrop(listViewLiveStockMarket.SelectedItems, DragDropEffects.Copy);
        }

        private void listViewLiveStockPen_DragDrop(object sender, DragEventArgs e)
        {
            ListView.SelectedListViewItemCollection data = 
                (e.Data.GetData(typeof(ListView.SelectedListViewItemCollection))) as ListView.SelectedListViewItemCollection;

            foreach (ListViewItem item in data)
            {
                listViewLiveStockPen.Items.Add(item.Clone() as ListViewItem);
            }
        }

        private void listViewLiveStockPen_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void listViewLiveStockMarket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C) && listViewLiveStockMarket.SelectedItems.Count > 0)
            {
                Clipboard.SetData("Sheep", listViewLiveStockMarket.SelectedItems[0]);
            }
        }

        private void listViewLiveStockPen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.V) && Clipboard.ContainsData("Sheep"))
            {
                listViewLiveStockPen.Items.Add(Clipboard.GetData("Sheep") as ListViewItem);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListViewItem ovecka = new ListViewItem( new string[]{"Penisok","Male","55"},-1);
            listViewLiveStockMarket.Items.Add(ovecka);
           
        }
    }
}
