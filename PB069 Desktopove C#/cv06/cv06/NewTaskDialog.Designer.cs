namespace cv06
{
    partial class NewTaskDialog
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
            this.textBoxNameTask = new System.Windows.Forms.TextBox();
            this.radioButtonLow = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnTaskCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNameTask
            // 
            this.textBoxNameTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNameTask.Location = new System.Drawing.Point(12, 37);
            this.textBoxNameTask.Name = "textBoxNameTask";
            this.textBoxNameTask.Size = new System.Drawing.Size(259, 29);
            this.textBoxNameTask.TabIndex = 1;
            this.textBoxNameTask.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNameTask_Validating);
            // 
            // radioButtonLow
            // 
            this.radioButtonLow.AutoSize = true;
            this.radioButtonLow.Location = new System.Drawing.Point(14, 105);
            this.radioButtonLow.Name = "radioButtonLow";
            this.radioButtonLow.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLow.TabIndex = 0;
            this.radioButtonLow.TabStop = true;
            this.radioButtonLow.Text = "Low";
            this.radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(14, 128);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMedium.TabIndex = 2;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(14, 151);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(47, 17);
            this.radioButtonHigh.TabIndex = 3;
            this.radioButtonHigh.TabStop = true;
            this.radioButtonHigh.Text = "High";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name of Task";
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(65, 240);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTask.TabIndex = 6;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // btnTaskCancel
            // 
            this.btnTaskCancel.Location = new System.Drawing.Point(147, 240);
            this.btnTaskCancel.Name = "btnTaskCancel";
            this.btnTaskCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTaskCancel.TabIndex = 7;
            this.btnTaskCancel.Text = "Cancel";
            this.btnTaskCancel.UseVisualStyleBackColor = true;
            this.btnTaskCancel.Click += new System.EventHandler(this.btnTaskCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(14, 205);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Deadline";
            // 
            // NewTaskDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(294, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnTaskCancel);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonHigh);
            this.Controls.Add(this.radioButtonMedium);
            this.Controls.Add(this.radioButtonLow);
            this.Controls.Add(this.textBoxNameTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewTaskDialog";
            this.Text = "NewTaskDialog";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameTask;
        private System.Windows.Forms.RadioButton radioButtonLow;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnTaskCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}