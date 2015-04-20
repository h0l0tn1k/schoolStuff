namespace Garage
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGarageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carListBox = new System.Windows.Forms.ListBox();
            this.newCarButton = new System.Windows.Forms.Button();
            this.sellCarButton = new System.Windows.Forms.Button();
            this.editCarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colourButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.carToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1004, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGarageToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGarageToolStripMenuItem
            // 
            this.newGarageToolStripMenuItem.Name = "newGarageToolStripMenuItem";
            this.newGarageToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.newGarageToolStripMenuItem.Text = "New Garage";
            this.newGarageToolStripMenuItem.Click += new System.EventHandler(this.newGarage);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyNewToolStripMenuItem,
            this.sellToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // buyNewToolStripMenuItem
            // 
            this.buyNewToolStripMenuItem.Name = "buyNewToolStripMenuItem";
            this.buyNewToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.buyNewToolStripMenuItem.Text = "Buy New";
            this.buyNewToolStripMenuItem.Click += new System.EventHandler(this.newCar);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Enabled = false;
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.sellToolStripMenuItem.Text = "Sell";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Enabled = false;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // carListBox
            // 
            this.carListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carListBox.FormattingEnabled = true;
            this.carListBox.ItemHeight = 25;
            this.carListBox.Location = new System.Drawing.Point(12, 52);
            this.carListBox.Name = "carListBox";
            this.carListBox.Size = new System.Drawing.Size(702, 429);
            this.carListBox.TabIndex = 1;
            // 
            // newCarButton
            // 
            this.newCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCarButton.Location = new System.Drawing.Point(12, 487);
            this.newCarButton.Name = "newCarButton";
            this.newCarButton.Size = new System.Drawing.Size(231, 52);
            this.newCarButton.TabIndex = 2;
            this.newCarButton.Text = "Buy New Car";
            this.newCarButton.UseVisualStyleBackColor = true;
            this.newCarButton.Click += new System.EventHandler(this.newCar);
            // 
            // sellCarButton
            // 
            this.sellCarButton.Enabled = false;
            this.sellCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellCarButton.Location = new System.Drawing.Point(249, 487);
            this.sellCarButton.Name = "sellCarButton";
            this.sellCarButton.Size = new System.Drawing.Size(231, 52);
            this.sellCarButton.TabIndex = 3;
            this.sellCarButton.Text = "Sell Car";
            this.sellCarButton.UseVisualStyleBackColor = true;
            // 
            // editCarButton
            // 
            this.editCarButton.Enabled = false;
            this.editCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCarButton.Location = new System.Drawing.Point(483, 487);
            this.editCarButton.Name = "editCarButton";
            this.editCarButton.Size = new System.Drawing.Size(231, 52);
            this.editCarButton.TabIndex = 4;
            this.editCarButton.Text = "Modify Car";
            this.editCarButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colourButton);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.manufacturerLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(720, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 315);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // colourButton
            // 
            this.colourButton.BackColor = System.Drawing.Color.Black;
            this.colourButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colourButton.Enabled = false;
            this.colourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourButton.Location = new System.Drawing.Point(20, 206);
            this.colourButton.Name = "colourButton";
            this.colourButton.Size = new System.Drawing.Size(228, 33);
            this.colourButton.TabIndex = 10;
            this.colourButton.UseVisualStyleBackColor = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(15, 163);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(103, 25);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "<Price> €";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLabel.Location = new System.Drawing.Point(15, 126);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(163, 25);
            this.manufacturerLabel.TabIndex = 8;
            this.manufacturerLabel.Text = "<Manufacturer>";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(14, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(246, 31);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "\"<Pet Name>\"";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editCarButton);
            this.Controls.Add(this.sellCarButton);
            this.Controls.Add(this.newCarButton);
            this.Controls.Add(this.carListBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "My Garage";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGarageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ListBox carListBox;
        private System.Windows.Forms.Button newCarButton;
        private System.Windows.Forms.Button sellCarButton;
        private System.Windows.Forms.Button editCarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button colourButton;
    }
}

