namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label orderItemsLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label createdLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label selectedOrderLabel;
            System.Windows.Forms.Label ordersLabel;
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.amountCounterLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            amountLabel = new System.Windows.Forms.Label();
            orderItemsLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            selectedOrderLabel = new System.Windows.Forms.Label();
            ordersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            amountLabel.Location = new System.Drawing.Point(280, 491);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(67, 17);
            amountLabel.TabIndex = 23;
            amountLabel.Text = "Amount:";
            // 
            // orderItemsLabel
            // 
            orderItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            orderItemsLabel.AutoSize = true;
            orderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            orderItemsLabel.Location = new System.Drawing.Point(280, 338);
            orderItemsLabel.Name = "orderItemsLabel";
            orderItemsLabel.Size = new System.Drawing.Size(93, 17);
            orderItemsLabel.TabIndex = 22;
            orderItemsLabel.Text = "Order Items";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(283, 119);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 21;
            statusLabel.Text = "Status:";
            // 
            // createdLabel
            // 
            createdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            createdLabel.AutoSize = true;
            createdLabel.Location = new System.Drawing.Point(283, 87);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(47, 13);
            createdLabel.TabIndex = 20;
            createdLabel.Text = "Created:";
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(283, 58);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 19;
            idLabel.Text = "ID:";
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            selectedOrderLabel.Location = new System.Drawing.Point(280, 27);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new System.Drawing.Size(118, 17);
            selectedOrderLabel.TabIndex = 18;
            selectedOrderLabel.Text = "Selected Order";
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ordersLabel.Location = new System.Drawing.Point(3, 7);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new System.Drawing.Size(58, 17);
            ordersLabel.TabIndex = 16;
            ordersLabel.Text = "Orders";
            // 
            // createdTextBox
            // 
            this.createdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createdTextBox.Location = new System.Drawing.Point(344, 84);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(333, 20);
            this.createdTextBox.TabIndex = 26;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(344, 58);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(336, 20);
            this.idTextBox.TabIndex = 25;
            // 
            // amountCounterLabel
            // 
            this.amountCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountCounterLabel.AutoSize = true;
            this.amountCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountCounterLabel.Location = new System.Drawing.Point(354, 491);
            this.amountCounterLabel.Name = "amountCounterLabel";
            this.amountCounterLabel.Size = new System.Drawing.Size(19, 20);
            this.amountCounterLabel.TabIndex = 24;
            this.amountCounterLabel.Text = "0";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(280, 358);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(397, 121);
            this.itemsListBox.TabIndex = 17;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Address
            // 
            this.Address.HeaderText = "Delivery Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.Width = 250;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Customer Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FullName.Width = 200;
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "Order Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            this.OrderStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Created
            // 
            this.Created.HeaderText = "Created";
            this.Created.Name = "Created";
            this.Created.ReadOnly = true;
            this.Created.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Created.Width = 150;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 40;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(344, 116);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(333, 21);
            this.statusComboBox.TabIndex = 27;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Created,
            this.OrderStatus,
            this.FullName,
            this.Address,
            this.Amount});
            this.ordersDataGridView.Location = new System.Drawing.Point(6, 27);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersVisible = false;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(268, 550);
            this.ordersDataGridView.TabIndex = 15;
            this.ordersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridViewCellContentClick);
            // 
            // addressControl1
            // 
            this.addressControl1.Address = null;
            this.addressControl1.Location = new System.Drawing.Point(280, 151);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(397, 184);
            this.addressControl1.TabIndex = 28;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addressControl1);
            this.Controls.Add(this.createdTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.amountCounterLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(orderItemsLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(createdLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(selectedOrderLabel);
            this.Controls.Add(ordersLabel);
            this.Controls.Add(this.ordersDataGridView);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(680, 580);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label amountCounterLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private Controls.AddressControl addressControl1;
    }
}
