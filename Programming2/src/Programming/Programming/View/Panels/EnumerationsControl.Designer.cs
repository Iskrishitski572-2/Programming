namespace Programming.View.Panels
{
    partial class EnumerationsControl
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
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumLabel = new System.Windows.Forms.Label();
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(355, 9);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 11;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(186, 9);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(81, 15);
            this.ChooseValueLabel.TabIndex = 10;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumLabel
            // 
            this.ChooseEnumLabel.AutoSize = true;
            this.ChooseEnumLabel.Location = new System.Drawing.Point(12, 9);
            this.ChooseEnumLabel.Name = "ChooseEnumLabel";
            this.ChooseEnumLabel.Size = new System.Drawing.Size(121, 15);
            this.ChooseEnumLabel.TabIndex = 9;
            this.ChooseEnumLabel.Text = "Choose enumeration:";
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Location = new System.Drawing.Point(355, 26);
            this.ValuesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(110, 23);
            this.ValuesTextBox.TabIndex = 8;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(186, 26);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(149, 229);
            this.ValuesListBox.TabIndex = 7;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Location = new System.Drawing.Point(12, 26);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(151, 229);
            this.EnumsListBox.TabIndex = 6;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.IntValueLabel);
            this.Controls.Add(this.ChooseValueLabel);
            this.Controls.Add(this.ChooseEnumLabel);
            this.Controls.Add(this.ValuesTextBox);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.EnumsListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(686, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IntValueLabel;
        private Label ChooseValueLabel;
        private Label ChooseEnumLabel;
        private TextBox ValuesTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
    }
}
