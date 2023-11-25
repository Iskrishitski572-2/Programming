namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customersLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customersLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.customersLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.customersLayoutPanelLeft.SuspendLayout();
            this.customersLayoutPanelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(6, 309);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(83, 35);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "ACCEPT";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(296, 309);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 35);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedCustomerLabel.Location = new System.Drawing.Point(3, 0);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.selectedCustomerLabel.Size = new System.Drawing.Size(139, 22);
            this.selectedCustomerLabel.TabIndex = 3;
            this.selectedCustomerLabel.Text = "Selected customer";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(3, 160);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(3, 38, 3, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(6, 175);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 38, 3, 3);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(373, 128);
            this.addressTextBox.TabIndex = 4;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(6, 99);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 38, 3, 3);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(373, 20);
            this.fullNameTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(6, 38);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 38, 3, 3);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(223, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(3, 85);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(3, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // customersListBox
            // 
            this.customersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(3, 25);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(268, 499);
            this.customersListBox.TabIndex = 1;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBoxSelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customersLabel);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 16);
            this.panel2.TabIndex = 2;
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersLabel.Location = new System.Drawing.Point(-3, -3);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.customersLabel.Size = new System.Drawing.Size(83, 22);
            this.customersLabel.TabIndex = 2;
            this.customersLabel.Text = "Customers";
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // editButton
            // 
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.Location = new System.Drawing.Point(92, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(83, 35);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(181, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(84, 35);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 530);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // customersLayoutPanelLeft
            // 
            this.customersLayoutPanelLeft.ColumnCount = 1;
            this.customersLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customersLayoutPanelLeft.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.customersLayoutPanelLeft.Controls.Add(this.customersListBox, 0, 1);
            this.customersLayoutPanelLeft.Controls.Add(this.panel2, 0, 0);
            this.customersLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLayoutPanelLeft.Location = new System.Drawing.Point(3, 3);
            this.customersLayoutPanelLeft.Name = "customersLayoutPanelLeft";
            this.customersLayoutPanelLeft.RowCount = 3;
            this.customersLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.921538F));
            this.customersLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.0505F));
            this.customersLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.027967F));
            this.customersLayoutPanelLeft.Size = new System.Drawing.Size(274, 574);
            this.customersLayoutPanelLeft.TabIndex = 0;
            // 
            // customersLayoutPanelMain
            // 
            this.customersLayoutPanelMain.ColumnCount = 2;
            this.customersLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.customersLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.customersLayoutPanelMain.Controls.Add(this.customersLayoutPanelLeft, 0, 0);
            this.customersLayoutPanelMain.Controls.Add(this.panel1, 1, 0);
            this.customersLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.customersLayoutPanelMain.Name = "customersLayoutPanelMain";
            this.customersLayoutPanelMain.RowCount = 1;
            this.customersLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customersLayoutPanelMain.Size = new System.Drawing.Size(680, 580);
            this.customersLayoutPanelMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.acceptButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.selectedCustomerLabel);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.fullNameTextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.fullNameLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(283, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 574);
            this.panel1.TabIndex = 1;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customersLayoutPanelMain);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(680, 580);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.customersLayoutPanelLeft.ResumeLayout(false);
            this.customersLayoutPanelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label selectedCustomerLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.MaskedTextBox fullNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel customersLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel customersLayoutPanelMain;
        private System.Windows.Forms.Panel panel1;
    }
}
