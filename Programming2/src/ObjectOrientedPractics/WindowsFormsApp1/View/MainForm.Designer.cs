namespace WindowsFormsApp1
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ordersTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.priorityOrdersTab1 = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.ordersTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersTabControl
            // 
            this.ordersTabControl.Controls.Add(this.tabPage1);
            this.ordersTabControl.Controls.Add(this.tabPage2);
            this.ordersTabControl.Controls.Add(this.tabPage3);
            this.ordersTabControl.Controls.Add(this.tabPage4);
            this.ordersTabControl.Controls.Add(this.tabPage5);
            this.ordersTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTabControl.Location = new System.Drawing.Point(0, 0);
            this.ordersTabControl.Name = "ordersTabControl";
            this.ordersTabControl.SelectedIndex = 0;
            this.ordersTabControl.Size = new System.Drawing.Size(746, 681);
            this.ordersTabControl.TabIndex = 0;
            this.ordersTabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.itemsTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            // 
            // itemsTab1
            // 
            this.itemsTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsTab1.Location = new System.Drawing.Point(21, 32);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(680, 580);
            this.itemsTab1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.customersTab1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            // 
            // customersTab1
            // 
            this.customersTab1.Customers = null;
            this.customersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab1.Location = new System.Drawing.Point(3, 3);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(732, 649);
            this.customersTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.Controls.Add(this.cartsTab1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(738, 655);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Carts";
            // 
            // cartsTab1
            // 
            this.cartsTab1.Customers = null;
            this.cartsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab1.Items = null;
            this.cartsTab1.Location = new System.Drawing.Point(3, 3);
            this.cartsTab1.Name = "cartsTab1";
            this.cartsTab1.Size = new System.Drawing.Size(732, 649);
            this.cartsTab1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage4.Controls.Add(this.ordersTab1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(738, 655);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Orders";
            // 
            // ordersTab1
            // 
            this.ordersTab1.Customer = null;
            this.ordersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab1.Location = new System.Drawing.Point(0, 0);
            this.ordersTab1.Name = "ordersTab1";
            this.ordersTab1.Size = new System.Drawing.Size(738, 655);
            this.ordersTab1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.priorityOrdersTab1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(738, 655);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            this.priorityOrdersTab1.Customers = null;
            this.priorityOrdersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityOrdersTab1.Items = null;
            this.priorityOrdersTab1.Location = new System.Drawing.Point(3, 3);
            this.priorityOrdersTab1.Name = "priorityOrdersTab1";
            this.priorityOrdersTab1.Size = new System.Drawing.Size(732, 649);
            this.priorityOrdersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(746, 681);
            this.Controls.Add(this.ordersTabControl);
            this.Name = "MainForm";
            this.ordersTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl ordersTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ObjectOrientedPractics.View.Tabs.ItemsTab itemsTab1;
        private ObjectOrientedPractics.View.Tabs.CustomersTab customersTab1;
        private System.Windows.Forms.TabPage tabPage3;
        private ObjectOrientedPractics.View.Tabs.CartsTab cartsTab1;
        private System.Windows.Forms.TabPage tabPage4;
        private ObjectOrientedPractics.View.Tabs.OrdersTab ordersTab1;
        private System.Windows.Forms.TabPage tabPage5;
        private ObjectOrientedPractics.View.Tabs.PriorityOrdersTab priorityOrdersTab1;
    }
}

