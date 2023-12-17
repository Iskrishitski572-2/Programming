namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.customersLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.customersLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.itemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectCustomerLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.cartLabel = new System.Windows.Forms.Label();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountCounterLabel = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.customersLayoutPanelMain.SuspendLayout();
            this.customersLayoutPanelLeft.SuspendLayout();
            this.itemsTableLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.customersLayoutPanelMain.TabIndex = 2;
            // 
            // customersLayoutPanelLeft
            // 
            this.customersLayoutPanelLeft.ColumnCount = 1;
            this.customersLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customersLayoutPanelLeft.Controls.Add(this.itemsTableLayoutPanel, 0, 2);
            this.customersLayoutPanelLeft.Controls.Add(this.itemsListBox, 0, 1);
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
            // itemsTableLayoutPanel
            // 
            this.itemsTableLayoutPanel.ColumnCount = 1;
            this.itemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.itemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.itemsTableLayoutPanel.Controls.Add(this.addToCartButton, 0, 0);
            this.itemsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTableLayoutPanel.Location = new System.Drawing.Point(3, 530);
            this.itemsTableLayoutPanel.Name = "itemsTableLayoutPanel";
            this.itemsTableLayoutPanel.RowCount = 1;
            this.itemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemsTableLayoutPanel.Size = new System.Drawing.Size(268, 41);
            this.itemsTableLayoutPanel.TabIndex = 0;
            // 
            // itemsListBox
            // 
            this.itemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(3, 25);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(268, 499);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBoxSelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.itemsLabel);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 16);
            this.panel2.TabIndex = 2;
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(-3, -3);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.itemsLabel.Size = new System.Drawing.Size(47, 22);
            this.itemsLabel.TabIndex = 2;
            this.itemsLabel.Text = "Items";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearCartButton);
            this.panel1.Controls.Add(this.removeItemButton);
            this.panel1.Controls.Add(this.createOrderButton);
            this.panel1.Controls.Add(this.amountCounterLabel);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.cartListBox);
            this.panel1.Controls.Add(this.cartLabel);
            this.panel1.Controls.Add(this.customerLabel);
            this.panel1.Controls.Add(this.customersComboBox);
            this.panel1.Controls.Add(this.selectCustomerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(283, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 574);
            this.panel1.TabIndex = 1;
            // 
            // selectCustomerLabel
            // 
            this.selectCustomerLabel.AutoSize = true;
            this.selectCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectCustomerLabel.Location = new System.Drawing.Point(3, 0);
            this.selectCustomerLabel.Name = "selectCustomerLabel";
            this.selectCustomerLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.selectCustomerLabel.Size = new System.Drawing.Size(139, 22);
            this.selectCustomerLabel.TabIndex = 3;
            this.selectCustomerLabel.Text = "Selected customer";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addToCartButton.Location = new System.Drawing.Point(3, 3);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(262, 35);
            this.addToCartButton.TabIndex = 1;
            this.addToCartButton.Text = "ADD";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButtonClick);
            // 
            // customersComboBox
            // 
            this.customersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(83, 30);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(299, 21);
            this.customersComboBox.TabIndex = 11;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBoxSelectedIndexChanged);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(3, 35);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(76, 16);
            this.customerLabel.TabIndex = 12;
            this.customerLabel.Text = "Customer:";
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(3, 64);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cartLabel.Size = new System.Drawing.Size(29, 13);
            this.cartLabel.TabIndex = 14;
            this.cartLabel.Text = "Cart:";
            // 
            // cartListBox
            // 
            this.cartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(6, 80);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(376, 160);
            this.cartListBox.TabIndex = 15;
            this.cartListBox.SelectedIndexChanged += new System.EventHandler(this.CartListBoxSelectedIndexChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(3, 258);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amountLabel.Size = new System.Drawing.Size(53, 13);
            this.amountLabel.TabIndex = 16;
            this.amountLabel.Text = "Amount:";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountCounterLabel
            // 
            this.amountCounterLabel.AutoSize = true;
            this.amountCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountCounterLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.amountCounterLabel.Location = new System.Drawing.Point(62, 253);
            this.amountCounterLabel.Name = "amountCounterLabel";
            this.amountCounterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amountCounterLabel.Size = new System.Drawing.Size(19, 20);
            this.amountCounterLabel.TabIndex = 17;
            this.amountCounterLabel.Text = "0";
            this.amountCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Enabled = false;
            this.createOrderButton.Location = new System.Drawing.Point(6, 531);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(86, 38);
            this.createOrderButton.TabIndex = 18;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButtonClick);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemButton.Enabled = false;
            this.removeItemButton.Location = new System.Drawing.Point(232, 533);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(81, 38);
            this.removeItemButton.TabIndex = 19;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButtonClick);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCartButton.Enabled = false;
            this.clearCartButton.Location = new System.Drawing.Point(319, 533);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(72, 38);
            this.clearCartButton.TabIndex = 20;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.ClearCartButtonClick);
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customersLayoutPanelMain);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(680, 580);
            this.customersLayoutPanelMain.ResumeLayout(false);
            this.customersLayoutPanelLeft.ResumeLayout(false);
            this.itemsTableLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customersLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel customersLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel itemsTableLayoutPanel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label selectCustomerLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Label amountCounterLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customersComboBox;
    }
}
