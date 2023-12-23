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
            System.Windows.Forms.Label totalLabel;
            this.amountCounterLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.discountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.discountsLabel = new System.Windows.Forms.Label();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.discountCounterLabel = new System.Windows.Forms.Label();
            this.totalCounterLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            totalLabel.Location = new System.Drawing.Point(623, 462);
            totalLabel.Name = "totalLabel";
            totalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            totalLabel.Size = new System.Drawing.Size(54, 20);
            totalLabel.TabIndex = 27;
            totalLabel.Text = "Total:";
            totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // amountCounterLabel
            // 
            this.amountCounterLabel.AutoSize = true;
            this.amountCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountCounterLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.amountCounterLabel.Location = new System.Drawing.Point(240, 268);
            this.amountCounterLabel.Name = "amountCounterLabel";
            this.amountCounterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amountCounterLabel.Size = new System.Drawing.Size(19, 20);
            this.amountCounterLabel.TabIndex = 22;
            this.amountCounterLabel.Text = "0";
            this.amountCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(240, 245);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amountLabel.Size = new System.Drawing.Size(53, 13);
            this.amountLabel.TabIndex = 21;
            this.amountLabel.Text = "Amount:";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(240, 18);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(76, 16);
            this.customerLabel.TabIndex = 20;
            this.customerLabel.Text = "Customer:";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.itemsLabel.Location = new System.Drawing.Point(0, 0);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(46, 17);
            this.itemsLabel.TabIndex = 19;
            this.itemsLabel.Text = "Items";
            // 
            // customersComboBox
            // 
            this.customersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(244, 37);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(433, 21);
            this.customersComboBox.TabIndex = 18;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBoxSelectedIndexChanged);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCartButton.Enabled = false;
            this.clearCartButton.Location = new System.Drawing.Point(605, 308);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(72, 38);
            this.clearCartButton.TabIndex = 17;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.ClearCartButtonClick);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemButton.Enabled = false;
            this.removeItemButton.Location = new System.Drawing.Point(518, 308);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(81, 38);
            this.removeItemButton.TabIndex = 16;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButtonClick);
            // 
            // createOrderButton
            // 
            this.createOrderButton.Enabled = false;
            this.createOrderButton.Location = new System.Drawing.Point(243, 308);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(86, 38);
            this.createOrderButton.TabIndex = 15;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButtonClick);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToCartButton.Enabled = false;
            this.addToCartButton.Location = new System.Drawing.Point(3, 525);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(86, 38);
            this.addToCartButton.TabIndex = 14;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButtonClick);
            // 
            // cartListBox
            // 
            this.cartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(243, 72);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(434, 160);
            this.cartListBox.TabIndex = 13;
            this.cartListBox.SelectedIndexChanged += new System.EventHandler(this.CartListBoxSelectedIndexChanged);
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(3, 19);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(231, 485);
            this.itemsListBox.TabIndex = 12;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBoxSelectedIndexChanged);
            // 
            // discountsCheckedListBox
            // 
            this.discountsCheckedListBox.FormattingEnabled = true;
            this.discountsCheckedListBox.Location = new System.Drawing.Point(244, 410);
            this.discountsCheckedListBox.Name = "discountsCheckedListBox";
            this.discountsCheckedListBox.Size = new System.Drawing.Size(276, 94);
            this.discountsCheckedListBox.TabIndex = 23;
            this.discountsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DiscountsCheckedListBoxItemCheck);
            this.discountsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxSelectedIndexChanged);
            // 
            // discountsLabel
            // 
            this.discountsLabel.AutoSize = true;
            this.discountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountsLabel.Location = new System.Drawing.Point(241, 391);
            this.discountsLabel.Name = "discountsLabel";
            this.discountsLabel.Size = new System.Drawing.Size(79, 16);
            this.discountsLabel.TabIndex = 24;
            this.discountsLabel.Text = "Discounts:";
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountAmountLabel.Location = new System.Drawing.Point(520, 391);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(126, 16);
            this.discountAmountLabel.TabIndex = 25;
            this.discountAmountLabel.Text = "Discount Amount:";
            // 
            // discountCounterLabel
            // 
            this.discountCounterLabel.AutoSize = true;
            this.discountCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountCounterLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discountCounterLabel.Location = new System.Drawing.Point(658, 410);
            this.discountCounterLabel.Name = "discountCounterLabel";
            this.discountCounterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.discountCounterLabel.Size = new System.Drawing.Size(19, 20);
            this.discountCounterLabel.TabIndex = 26;
            this.discountCounterLabel.Text = "0";
            this.discountCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCounterLabel
            // 
            this.totalCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCounterLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalCounterLabel.Location = new System.Drawing.Point(530, 484);
            this.totalCounterLabel.Name = "totalCounterLabel";
            this.totalCounterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalCounterLabel.Size = new System.Drawing.Size(147, 20);
            this.totalCounterLabel.TabIndex = 28;
            this.totalCounterLabel.Text = "0";
            this.totalCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalCounterLabel);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.discountCounterLabel);
            this.Controls.Add(this.discountAmountLabel);
            this.Controls.Add(this.discountsLabel);
            this.Controls.Add(this.discountsCheckedListBox);
            this.Controls.Add(this.amountCounterLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.customersComboBox);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.itemsListBox);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(680, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountCounterLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.CheckedListBox discountsCheckedListBox;
        private System.Windows.Forms.Label discountsLabel;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.Label discountCounterLabel;
        private System.Windows.Forms.Label totalCounterLabel;
    }
}
