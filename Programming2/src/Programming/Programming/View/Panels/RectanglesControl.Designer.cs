namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(182, 219);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 15);
            this.IDLabel.TabIndex = 25;
            this.IDLabel.Text = "ID:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(186, 234);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(119, 23);
            this.IDTextBox.TabIndex = 24;
            this.IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTextBox_KeyPress);
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(186, 179);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 15);
            this.YLabel.TabIndex = 23;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(186, 140);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 15);
            this.XLabel.TabIndex = 22;
            this.XLabel.Text = "X:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(186, 194);
            this.YTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(119, 23);
            this.YTextBox.TabIndex = 15;
            this.YTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YTextBox_KeyPress);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(186, 154);
            this.XTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(119, 23);
            this.XTextBox.TabIndex = 17;
            this.XTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XTextBox_KeyPress);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(186, 261);
            this.FindButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(119, 46);
            this.FindButton.TabIndex = 21;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(186, 115);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(119, 23);
            this.ColorTextBox.TabIndex = 20;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(186, 35);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(119, 23);
            this.LengthTextBox.TabIndex = 19;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(186, 75);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(119, 23);
            this.WidthTextBox.TabIndex = 18;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(186, 100);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(39, 15);
            this.ColorLabel.TabIndex = 16;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(186, 60);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthLabel.TabIndex = 14;
            this.WidthLabel.Text = "Width:";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(186, 18);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(47, 15);
            this.LenghtLabel.TabIndex = 13;
            this.LenghtLabel.Text = "Lenght:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(12, 18);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(165, 289);
            this.RectanglesListBox.TabIndex = 12;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.LenghtLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(322, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IDLabel;
        private TextBox IDTextBox;
        private Label YLabel;
        private Label XLabel;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private Button FindButton;
        private TextBox ColorTextBox;
        private TextBox LengthTextBox;
        private TextBox WidthTextBox;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LenghtLabel;
        private ListBox RectanglesListBox;
    }
}
