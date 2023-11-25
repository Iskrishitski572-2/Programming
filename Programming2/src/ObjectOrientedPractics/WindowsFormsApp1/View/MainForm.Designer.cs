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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.customersTab1 = new System.Windows.Forms.TabPage();
            this.customersTab2 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.customersTab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.customersTab1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 736);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.itemsTab1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(665, 710);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Location = new System.Drawing.Point(0, 0);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(665, 710);
            this.itemsTab1.TabIndex = 0;
            // 
            // customersTab1
            // 
            this.customersTab1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.customersTab1.Controls.Add(this.customersTab2);
            this.customersTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customersTab1.Location = new System.Drawing.Point(4, 22);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab1.Size = new System.Drawing.Size(665, 710);
            this.customersTab1.TabIndex = 1;
            this.customersTab1.Text = "Customers";
            // 
            // customersTab2
            // 
            this.customersTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab2.Location = new System.Drawing.Point(3, 3);
            this.customersTab2.Name = "customersTab2";
            this.customersTab2.Size = new System.Drawing.Size(659, 704);
            this.customersTab2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 736);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(689, 775);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.customersTab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage customersTab1;
        private ObjectOrientedPractics.View.Tabs.ItemsTab itemsTab1;
        private ObjectOrientedPractics.View.Tabs.CustomersTab customersTab2;
    }
}

