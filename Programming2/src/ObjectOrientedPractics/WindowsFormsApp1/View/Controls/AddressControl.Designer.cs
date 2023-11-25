namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.deliveryAddressLabel = new System.Windows.Forms.Label();
            this.postIndexLabel = new System.Windows.Forms.Label();
            this.postIndexTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.apartmentTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.apartamentLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deliveryAddressLabel
            // 
            this.deliveryAddressLabel.AutoSize = true;
            this.deliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliveryAddressLabel.Location = new System.Drawing.Point(-1, 18);
            this.deliveryAddressLabel.Name = "deliveryAddressLabel";
            this.deliveryAddressLabel.Size = new System.Drawing.Size(143, 20);
            this.deliveryAddressLabel.TabIndex = 0;
            this.deliveryAddressLabel.Text = "Delivery Address";
            // 
            // postIndexLabel
            // 
            this.postIndexLabel.AutoSize = true;
            this.postIndexLabel.Location = new System.Drawing.Point(0, 60);
            this.postIndexLabel.Name = "postIndexLabel";
            this.postIndexLabel.Size = new System.Drawing.Size(59, 13);
            this.postIndexLabel.TabIndex = 1;
            this.postIndexLabel.Text = "Post index:";
            // 
            // postIndexTextBox
            // 
            this.postIndexTextBox.Location = new System.Drawing.Point(59, 57);
            this.postIndexTextBox.Name = "postIndexTextBox";
            this.postIndexTextBox.Size = new System.Drawing.Size(77, 20);
            this.postIndexTextBox.TabIndex = 2;
            this.postIndexTextBox.TextChanged += new System.EventHandler(this.IndexTextBoxTextChanged);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(59, 90);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(133, 20);
            this.countryTextBox.TabIndex = 3;
            this.countryTextBox.TextChanged += new System.EventHandler(this.CountryTextBoxTextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextBox.Location = new System.Drawing.Point(231, 90);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(148, 20);
            this.cityTextBox.TabIndex = 4;
            this.cityTextBox.TextChanged += new System.EventHandler(this.CityTextBoxTextChanged);
            // 
            // streetTextBox
            // 
            this.streetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streetTextBox.Location = new System.Drawing.Point(59, 123);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(320, 20);
            this.streetTextBox.TabIndex = 5;
            this.streetTextBox.TextChanged += new System.EventHandler(this.StreetTextBoxTextChanged);
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(59, 156);
            this.buildingTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(132, 20);
            this.buildingTextBox.TabIndex = 6;
            this.buildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBoxTextChanged);
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apartmentTextBox.Location = new System.Drawing.Point(232, 156);
            this.apartmentTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(147, 20);
            this.apartmentTextBox.TabIndex = 7;
            this.apartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBoxTextChanged);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(0, 93);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 13);
            this.countryLabel.TabIndex = 8;
            this.countryLabel.Text = "Country:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(0, 126);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 9;
            this.streetLabel.Text = "Street:";
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Location = new System.Drawing.Point(0, 159);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(47, 13);
            this.buildingLabel.TabIndex = 10;
            this.buildingLabel.Text = "Building:";
            // 
            // apartamentLabel
            // 
            this.apartamentLabel.AutoSize = true;
            this.apartamentLabel.Location = new System.Drawing.Point(198, 159);
            this.apartamentLabel.Name = "apartamentLabel";
            this.apartamentLabel.Size = new System.Drawing.Size(28, 13);
            this.apartamentLabel.TabIndex = 11;
            this.apartamentLabel.Text = "Aps:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(198, 93);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "City:";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.apartamentLabel);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.apartmentTextBox);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.postIndexTextBox);
            this.Controls.Add(this.postIndexLabel);
            this.Controls.Add(this.deliveryAddressLabel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(382, 186);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deliveryAddressLabel;
        private System.Windows.Forms.Label postIndexLabel;
        private System.Windows.Forms.TextBox postIndexTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox apartmentTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.Label apartamentLabel;
        private System.Windows.Forms.Label cityLabel;
    }
}
