namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            System.Windows.Forms.Label deliveryTimeLabel;
            System.Windows.Forms.Label priorityOptionsLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label orderItemsLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label createdLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label selectedOrderLabel;
            this.deliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.amountCounterLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            deliveryTimeLabel = new System.Windows.Forms.Label();
            priorityOptionsLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            orderItemsLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            selectedOrderLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deliveryTimeLabel
            // 
            deliveryTimeLabel.AutoSize = true;
            deliveryTimeLabel.Location = new System.Drawing.Point(3, 51);
            deliveryTimeLabel.Name = "deliveryTimeLabel";
            deliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            deliveryTimeLabel.TabIndex = 48;
            deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // priorityOptionsLabel
            // 
            priorityOptionsLabel.AutoSize = true;
            priorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priorityOptionsLabel.Location = new System.Drawing.Point(3, 0);
            priorityOptionsLabel.Name = "priorityOptionsLabel";
            priorityOptionsLabel.Size = new System.Drawing.Size(121, 17);
            priorityOptionsLabel.TabIndex = 47;
            priorityOptionsLabel.Text = "Priority Options";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            amountLabel.Location = new System.Drawing.Point(9, 455);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(67, 17);
            amountLabel.TabIndex = 39;
            amountLabel.Text = "Amount:";
            // 
            // orderItemsLabel
            // 
            orderItemsLabel.AutoSize = true;
            orderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            orderItemsLabel.Location = new System.Drawing.Point(5, 311);
            orderItemsLabel.Name = "orderItemsLabel";
            orderItemsLabel.Size = new System.Drawing.Size(93, 17);
            orderItemsLabel.TabIndex = 38;
            orderItemsLabel.Text = "Order Items";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(8, 95);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 37;
            statusLabel.Text = "Status:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new System.Drawing.Point(8, 63);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(47, 13);
            createdLabel.TabIndex = 36;
            createdLabel.Text = "Created:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(8, 34);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 35;
            idLabel.Text = "ID:";
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            selectedOrderLabel.Location = new System.Drawing.Point(5, 3);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new System.Drawing.Size(118, 17);
            selectedOrderLabel.TabIndex = 34;
            selectedOrderLabel.Text = "Selected Order";
            // 
            // deliveryTimeComboBox
            // 
            this.deliveryTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryTimeComboBox.FormattingEnabled = true;
            this.deliveryTimeComboBox.Location = new System.Drawing.Point(101, 47);
            this.deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            this.deliveryTimeComboBox.Size = new System.Drawing.Size(96, 21);
            this.deliveryTimeComboBox.TabIndex = 49;
            this.deliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeComboBoxSelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(543, 533);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 33);
            this.clearButton.TabIndex = 46;
            this.clearButton.Text = "Clear Order";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.СlearButtonClick);
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(102, 533);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(92, 33);
            this.removeButton.TabIndex = 45;
            this.removeButton.Text = "Remove Item";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(8, 533);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 33);
            this.addButton.TabIndex = 44;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(66, 92);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 43;
            // 
            // createdTextBox
            // 
            this.createdTextBox.Location = new System.Drawing.Point(66, 60);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(121, 20);
            this.createdTextBox.TabIndex = 42;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(66, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 41;
            // 
            // amountCounterLabel
            // 
            this.amountCounterLabel.AutoSize = true;
            this.amountCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountCounterLabel.Location = new System.Drawing.Point(10, 486);
            this.amountCounterLabel.Name = "amountCounterLabel";
            this.amountCounterLabel.Size = new System.Drawing.Size(19, 20);
            this.amountCounterLabel.TabIndex = 40;
            this.amountCounterLabel.Text = "0";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(8, 331);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(627, 121);
            this.itemsListBox.TabIndex = 33;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBoxSelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(deliveryTimeLabel);
            this.panel1.Controls.Add(priorityOptionsLabel);
            this.panel1.Controls.Add(this.deliveryTimeComboBox);
            this.panel1.Location = new System.Drawing.Point(435, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 110);
            this.panel1.TabIndex = 51;
            // 
            // addressControl1
            // 
            this.addressControl1.Address = null;
            this.addressControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControl1.Location = new System.Drawing.Point(8, 119);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(627, 186);
            this.addressControl1.TabIndex = 50;
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addressControl1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.createdTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.amountCounterLabel);
            this.Controls.Add(amountLabel);
            this.Controls.Add(orderItemsLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(createdLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(selectedOrderLabel);
            this.Controls.Add(this.itemsListBox);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(638, 567);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label amountCounterLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.Panel panel1;
    }
}
