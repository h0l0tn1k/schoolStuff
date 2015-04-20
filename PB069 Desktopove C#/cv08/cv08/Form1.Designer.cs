namespace cv08
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ševčuk",
            "Female",
            "-3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Matta",
            "MAN",
            "MAXIMUM"}, -1);
            this.listViewLiveStockMarket = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewLiveStockPen = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listViewLiveStockMarket
            // 
            this.listViewLiveStockMarket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewLiveStockMarket.FullRowSelect = true;
            this.listViewLiveStockMarket.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8});
            this.listViewLiveStockMarket.Location = new System.Drawing.Point(12, 13);
            this.listViewLiveStockMarket.Name = "listViewLiveStockMarket";
            this.listViewLiveStockMarket.Size = new System.Drawing.Size(364, 517);
            this.listViewLiveStockMarket.TabIndex = 0;
            this.listViewLiveStockMarket.UseCompatibleStateImageBehavior = false;
            this.listViewLiveStockMarket.View = System.Windows.Forms.View.Details;
            this.listViewLiveStockMarket.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewLiveStockMarket_ItemDrag);
            this.listViewLiveStockMarket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewLiveStockMarket_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gender";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IQ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 120;
            // 
            // listViewLiveStockPen
            // 
            this.listViewLiveStockPen.AllowDrop = true;
            this.listViewLiveStockPen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewLiveStockPen.FullRowSelect = true;
            this.listViewLiveStockPen.Location = new System.Drawing.Point(395, 12);
            this.listViewLiveStockPen.Name = "listViewLiveStockPen";
            this.listViewLiveStockPen.Size = new System.Drawing.Size(364, 517);
            this.listViewLiveStockPen.TabIndex = 1;
            this.listViewLiveStockPen.UseCompatibleStateImageBehavior = false;
            this.listViewLiveStockPen.View = System.Windows.Forms.View.Details;
            this.listViewLiveStockPen.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewLiveStockPen_DragDrop);
            this.listViewLiveStockPen.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewLiveStockPen_DragEnter);
            this.listViewLiveStockPen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewLiveStockPen_KeyDown);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gender";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "IQ";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 120;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 542);
            this.Controls.Add(this.listViewLiveStockPen);
            this.Controls.Add(this.listViewLiveStockMarket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLiveStockMarket;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewLiveStockPen;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Timer timer1;
    }
}

