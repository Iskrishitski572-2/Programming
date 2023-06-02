namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.HeightRectangleTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.IdRectangleLabel = new System.Windows.Forms.Label();
            this.XRectangleLabel = new System.Windows.Forms.Label();
            this.YRectangleLabel = new System.Windows.Forms.Label();
            this.WidthRectangleLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RectanglesParametersListBox = new System.Windows.Forms.ListBox();
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.groupBoxRectangles = new System.Windows.Forms.GroupBox();
            this.groupBoxRectanglesPaint = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxRectangles.SuspendLayout();
            this.groupBoxRectanglesPaint.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Location = new System.Drawing.Point(62, 213);
            this.IdRectangleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.Size = new System.Drawing.Size(110, 23);
            this.IdRectangleTextBox.TabIndex = 31;
            this.IdRectangleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTextBox_KeyPress);
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Location = new System.Drawing.Point(62, 240);
            this.XRectangleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.Size = new System.Drawing.Size(110, 23);
            this.XRectangleTextBox.TabIndex = 30;
            this.XRectangleTextBox.TextChanged += new System.EventHandler(this.XRectangleTextBox_TextChanged);
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Location = new System.Drawing.Point(62, 267);
            this.YRectangleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.Size = new System.Drawing.Size(110, 23);
            this.YRectangleTextBox.TabIndex = 29;
            this.YRectangleTextBox.TextChanged += new System.EventHandler(this.YRectangleTextBox_TextChanged);
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(62, 294);
            this.WidthRectangleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(110, 23);
            this.WidthRectangleTextBox.TabIndex = 28;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // HeightRectangleTextBox
            // 
            this.HeightRectangleTextBox.Location = new System.Drawing.Point(62, 321);
            this.HeightRectangleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightRectangleTextBox.Name = "HeightRectangleTextBox";
            this.HeightRectangleTextBox.Size = new System.Drawing.Size(110, 23);
            this.HeightRectangleTextBox.TabIndex = 27;
            this.HeightRectangleTextBox.TextChanged += new System.EventHandler(this.HeightRectangleTextBox_TextChanged);
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(6, 196);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(109, 15);
            this.SelectedRectangleLabel.TabIndex = 26;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // IdRectangleLabel
            // 
            this.IdRectangleLabel.AutoSize = true;
            this.IdRectangleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IdRectangleLabel.Location = new System.Drawing.Point(6, 221);
            this.IdRectangleLabel.Name = "IdRectangleLabel";
            this.IdRectangleLabel.Size = new System.Drawing.Size(20, 15);
            this.IdRectangleLabel.TabIndex = 25;
            this.IdRectangleLabel.Text = "Id:";
            this.IdRectangleLabel.Click += new System.EventHandler(this.IdRectangleLabel_Click);
            // 
            // XRectangleLabel
            // 
            this.XRectangleLabel.AutoSize = true;
            this.XRectangleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.XRectangleLabel.Location = new System.Drawing.Point(6, 248);
            this.XRectangleLabel.Name = "XRectangleLabel";
            this.XRectangleLabel.Size = new System.Drawing.Size(17, 15);
            this.XRectangleLabel.TabIndex = 24;
            this.XRectangleLabel.Text = "X:";
            // 
            // YRectangleLabel
            // 
            this.YRectangleLabel.AutoSize = true;
            this.YRectangleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.YRectangleLabel.Location = new System.Drawing.Point(6, 275);
            this.YRectangleLabel.Name = "YRectangleLabel";
            this.YRectangleLabel.Size = new System.Drawing.Size(17, 15);
            this.YRectangleLabel.TabIndex = 23;
            this.YRectangleLabel.Text = "Y:";
            // 
            // WidthRectangleLabel
            // 
            this.WidthRectangleLabel.AutoSize = true;
            this.WidthRectangleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WidthRectangleLabel.Location = new System.Drawing.Point(6, 302);
            this.WidthRectangleLabel.Name = "WidthRectangleLabel";
            this.WidthRectangleLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthRectangleLabel.TabIndex = 22;
            this.WidthRectangleLabel.Text = "Width:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeightLabel.Location = new System.Drawing.Point(6, 329);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(46, 15);
            this.HeightLabel.TabIndex = 21;
            this.HeightLabel.Text = "Height:";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(6, 150);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(46, 33);
            this.AddButton.TabIndex = 20;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(62, 150);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(45, 33);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RectanglesParametersListBox
            // 
            this.RectanglesParametersListBox.BackColor = System.Drawing.Color.White;
            this.RectanglesParametersListBox.FormattingEnabled = true;
            this.RectanglesParametersListBox.ItemHeight = 15;
            this.RectanglesParametersListBox.Location = new System.Drawing.Point(6, 19);
            this.RectanglesParametersListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesParametersListBox.Name = "RectanglesParametersListBox";
            this.RectanglesParametersListBox.Size = new System.Drawing.Size(245, 124);
            this.RectanglesParametersListBox.TabIndex = 17;
            this.RectanglesParametersListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesParametersListBox_SelectedIndexChanged);
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesPanel.Location = new System.Drawing.Point(3, 19);
            this.RectanglesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(400, 402);
            this.RectanglesPanel.TabIndex = 32;
            // 
            // groupBoxRectangles
            // 
            this.groupBoxRectangles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxRectangles.Controls.Add(this.RectanglesParametersListBox);
            this.groupBoxRectangles.Controls.Add(this.IdRectangleTextBox);
            this.groupBoxRectangles.Controls.Add(this.DeleteButton);
            this.groupBoxRectangles.Controls.Add(this.IdRectangleLabel);
            this.groupBoxRectangles.Controls.Add(this.AddButton);
            this.groupBoxRectangles.Controls.Add(this.XRectangleTextBox);
            this.groupBoxRectangles.Controls.Add(this.HeightLabel);
            this.groupBoxRectangles.Controls.Add(this.YRectangleTextBox);
            this.groupBoxRectangles.Controls.Add(this.WidthRectangleLabel);
            this.groupBoxRectangles.Controls.Add(this.WidthRectangleTextBox);
            this.groupBoxRectangles.Controls.Add(this.YRectangleLabel);
            this.groupBoxRectangles.Controls.Add(this.HeightRectangleTextBox);
            this.groupBoxRectangles.Controls.Add(this.XRectangleLabel);
            this.groupBoxRectangles.Controls.Add(this.SelectedRectangleLabel);
            this.groupBoxRectangles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRectangles.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRectangles.Name = "groupBoxRectangles";
            this.groupBoxRectangles.Size = new System.Drawing.Size(282, 424);
            this.groupBoxRectangles.TabIndex = 33;
            this.groupBoxRectangles.TabStop = false;
            this.groupBoxRectangles.Text = "Rectangles:";
            // 
            // groupBoxRectanglesPaint
            // 
            this.groupBoxRectanglesPaint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxRectanglesPaint.Controls.Add(this.RectanglesPanel);
            this.groupBoxRectanglesPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRectanglesPaint.Location = new System.Drawing.Point(291, 3);
            this.groupBoxRectanglesPaint.Name = "groupBoxRectanglesPaint";
            this.groupBoxRectanglesPaint.Size = new System.Drawing.Size(406, 424);
            this.groupBoxRectanglesPaint.TabIndex = 32;
            this.groupBoxRectanglesPaint.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.71429F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxRectanglesPaint, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxRectangles, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 430);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(700, 430);
            this.groupBoxRectangles.ResumeLayout(false);
            this.groupBoxRectangles.PerformLayout();
            this.groupBoxRectanglesPaint.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox IdRectangleTextBox;
        private TextBox XRectangleTextBox;
        private TextBox YRectangleTextBox;
        private TextBox WidthRectangleTextBox;
        private TextBox HeightRectangleTextBox;
        private Label SelectedRectangleLabel;
        private Label IdRectangleLabel;
        private Label XRectangleLabel;
        private Label YRectangleLabel;
        private Label WidthRectangleLabel;
        private Label HeightLabel;
        private Button AddButton;
        private Button DeleteButton;
        private ListBox RectanglesParametersListBox;
        private Panel RectanglesPanel;
        private GroupBox groupBoxRectangles;
        private GroupBox groupBoxRectanglesPaint;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
