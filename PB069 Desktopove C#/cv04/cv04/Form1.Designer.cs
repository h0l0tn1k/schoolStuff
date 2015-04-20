namespace cv04
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.btnIDK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.borderWidthUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(106, 300);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(163, 20);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.btnDrawName_Click);
            // 
            // btnIDK
            // 
            this.btnIDK.Location = new System.Drawing.Point(492, 300);
            this.btnIDK.Name = "btnIDK";
            this.btnIDK.Size = new System.Drawing.Size(80, 50);
            this.btnIDK.TabIndex = 1;
            this.btnIDK.Text = "Background";
            this.btnIDK.UseVisualStyleBackColor = true;
            this.btnIDK.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Frame";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // borderWidthUpDown
            // 
            this.borderWidthUpDown.Location = new System.Drawing.Point(13, 299);
            this.borderWidthUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.borderWidthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.borderWidthUpDown.Name = "borderWidthUpDown";
            this.borderWidthUpDown.Size = new System.Drawing.Size(87, 20);
            this.borderWidthUpDown.TabIndex = 4;
            this.borderWidthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.borderWidthUpDown.ValueChanged += new System.EventHandler(this.btnBorderWidth);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.borderWidthUpDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIDK);
            this.Controls.Add(this.textBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Name Tag";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Kresli);
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button btnIDK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown borderWidthUpDown;

    }
}

