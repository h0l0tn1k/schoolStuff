namespace Garage
{
    partial class CarDialog
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colourLabel = new System.Windows.Forms.Label();
            this.colourButton = new System.Windows.Forms.Button();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.fuelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tyresLabel = new System.Windows.Forms.Label();
            this.summerTiresRadioButton = new System.Windows.Forms.RadioButton();
            this.winterTiresRadioButton = new System.Windows.Forms.RadioButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fuelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(12, 297);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(276, 52);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(294, 297);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(276, 52);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.manufacturerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.manufacturerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "Bugatti",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Ferrari",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lada",
            "Lamborghini",
            "Lexus",
            "Mazda",
            "Mercedes",
            "Mitsubishi",
            "Mustang",
            "Nissan",
            "Opel",
            "Peugeot",
            "Porsche",
            "Renault",
            "Rolls Royce",
            "Seat",
            "Subaru",
            "Suzuki",
            "Škoda",
            "Tata",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.manufacturerComboBox.Location = new System.Drawing.Point(158, 24);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(415, 33);
            this.manufacturerComboBox.TabIndex = 5;
            this.manufacturerComboBox.ValueMemberChanged += new System.EventHandler(this.setManufacturer);
            this.manufacturerComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateManufacturer);
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLabel.Location = new System.Drawing.Point(7, 27);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(145, 25);
            this.manufacturerLabel.TabIndex = 6;
            this.manufacturerLabel.Text = "Manufacturer:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(7, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 25);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Pet Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(158, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(415, 31);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.validatePetName);
            // 
            // licensePlateLabel
            // 
            this.licensePlateLabel.AutoSize = true;
            this.licensePlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensePlateLabel.Location = new System.Drawing.Point(7, 103);
            this.licensePlateLabel.Name = "licensePlateLabel";
            this.licensePlateLabel.Size = new System.Drawing.Size(148, 25);
            this.licensePlateLabel.TabIndex = 9;
            this.licensePlateLabel.Text = "License Plate:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(214, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 31);
            this.textBox1.TabIndex = 10;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourLabel.Location = new System.Drawing.Point(7, 175);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(81, 25);
            this.colourLabel.TabIndex = 11;
            this.colourLabel.Text = "Colour:";
            // 
            // colourButton
            // 
            this.colourButton.BackColor = System.Drawing.Color.Black;
            this.colourButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourButton.Location = new System.Drawing.Point(214, 175);
            this.colourButton.Name = "colourButton";
            this.colourButton.Size = new System.Drawing.Size(359, 31);
            this.colourButton.TabIndex = 12;
            this.colourButton.UseVisualStyleBackColor = false;
            this.colourButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLabel.Location = new System.Drawing.Point(7, 214);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(97, 25);
            this.fuelLabel.TabIndex = 13;
            this.fuelLabel.Text = "Fuel [%]:";
            // 
            // fuelNumericUpDown
            // 
            this.fuelNumericUpDown.DecimalPlaces = 1;
            this.fuelNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fuelNumericUpDown.Location = new System.Drawing.Point(214, 212);
            this.fuelNumericUpDown.Name = "fuelNumericUpDown";
            this.fuelNumericUpDown.Size = new System.Drawing.Size(140, 31);
            this.fuelNumericUpDown.TabIndex = 14;
            this.fuelNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fuelNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.validatingFuel);
            // 
            // tyresLabel
            // 
            this.tyresLabel.AutoSize = true;
            this.tyresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyresLabel.Location = new System.Drawing.Point(7, 251);
            this.tyresLabel.Name = "tyresLabel";
            this.tyresLabel.Size = new System.Drawing.Size(72, 25);
            this.tyresLabel.TabIndex = 15;
            this.tyresLabel.Text = "Tyres:";
            // 
            // summerTiresRadioButton
            // 
            this.summerTiresRadioButton.AutoSize = true;
            this.summerTiresRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summerTiresRadioButton.Location = new System.Drawing.Point(214, 249);
            this.summerTiresRadioButton.Name = "summerTiresRadioButton";
            this.summerTiresRadioButton.Size = new System.Drawing.Size(109, 29);
            this.summerTiresRadioButton.TabIndex = 16;
            this.summerTiresRadioButton.TabStop = true;
            this.summerTiresRadioButton.Text = "Summer";
            this.summerTiresRadioButton.UseVisualStyleBackColor = true;
            // 
            // winterTiresRadioButton
            // 
            this.winterTiresRadioButton.AutoSize = true;
            this.winterTiresRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winterTiresRadioButton.Location = new System.Drawing.Point(401, 249);
            this.winterTiresRadioButton.Name = "winterTiresRadioButton";
            this.winterTiresRadioButton.Size = new System.Drawing.Size(92, 29);
            this.winterTiresRadioButton.TabIndex = 17;
            this.winterTiresRadioButton.TabStop = true;
            this.winterTiresRadioButton.Text = "Winter";
            this.winterTiresRadioButton.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(7, 139);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(97, 25);
            this.priceLabel.TabIndex = 18;
            this.priceLabel.Text = "Price [€]:";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.priceNumericUpDown.Location = new System.Drawing.Point(214, 137);
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(359, 31);
            this.priceNumericUpDown.TabIndex = 19;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.validatingPrice);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 361);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.winterTiresRadioButton);
            this.Controls.Add(this.summerTiresRadioButton);
            this.Controls.Add(this.tyresLabel);
            this.Controls.Add(this.fuelNumericUpDown);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.colourButton);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.licensePlateLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.manufacturerComboBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarDialog";
            this.Text = "CarDialog";
            ((System.ComponentModel.ISupportInitialize)(this.fuelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label licensePlateLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.Button colourButton;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.NumericUpDown fuelNumericUpDown;
        private System.Windows.Forms.Label tyresLabel;
        private System.Windows.Forms.RadioButton summerTiresRadioButton;
        private System.Windows.Forms.RadioButton winterTiresRadioButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}