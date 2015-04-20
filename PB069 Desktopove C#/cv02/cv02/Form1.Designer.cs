namespace cv02
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
            this.labelAnimal = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnFeedGrass = new System.Windows.Forms.Button();
            this.btnFeedMeat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAnimal
            // 
            this.labelAnimal.AutoSize = true;
            this.labelAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAnimal.Location = new System.Drawing.Point(89, 100);
            this.labelAnimal.Name = "labelAnimal";
            this.labelAnimal.Size = new System.Drawing.Size(60, 24);
            this.labelAnimal.TabIndex = 0;
            this.labelAnimal.Text = "label1";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.Location = new System.Drawing.Point(89, 282);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(60, 24);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "label2";
            // 
            // btnFeedGrass
            // 
            this.btnFeedGrass.Location = new System.Drawing.Point(93, 177);
            this.btnFeedGrass.Name = "btnFeedGrass";
            this.btnFeedGrass.Size = new System.Drawing.Size(75, 50);
            this.btnFeedGrass.TabIndex = 2;
            this.btnFeedGrass.Text = "Grass";
            this.btnFeedGrass.UseVisualStyleBackColor = true;
            this.btnFeedGrass.Click += new System.EventHandler(this.btnClickFeedGrass);
            // 
            // btnFeedMeat
            // 
            this.btnFeedMeat.Location = new System.Drawing.Point(299, 177);
            this.btnFeedMeat.Name = "btnFeedMeat";
            this.btnFeedMeat.Size = new System.Drawing.Size(75, 50);
            this.btnFeedMeat.TabIndex = 3;
            this.btnFeedMeat.Text = "Meat";
            this.btnFeedMeat.UseVisualStyleBackColor = true;
            this.btnFeedMeat.Click += new System.EventHandler(this.btnClickFeedMeat);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnFeedMeat);
            this.Controls.Add(this.btnFeedGrass);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelAnimal);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnimal;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button btnFeedGrass;
        private System.Windows.Forms.Button btnFeedMeat;
    }
}

