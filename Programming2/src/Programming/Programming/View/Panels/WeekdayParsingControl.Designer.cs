namespace Programming.View.Panels
{
    partial class WeekdayParsingControl
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
            this.ResultParsing = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.TypeValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultParsing
            // 
            this.ResultParsing.AutoSize = true;
            this.ResultParsing.CausesValidation = false;
            this.ResultParsing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultParsing.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ResultParsing.Location = new System.Drawing.Point(11, 71);
            this.ResultParsing.Name = "ResultParsing";
            this.ResultParsing.Size = new System.Drawing.Size(133, 15);
            this.ResultParsing.TabIndex = 7;
            this.ResultParsing.Text = "Введите день недели";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(226, 38);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(82, 22);
            this.ParseButton.TabIndex = 6;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(11, 38);
            this.WeekdayTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(210, 23);
            this.WeekdayTextBox.TabIndex = 5;
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.AutoSize = true;
            this.TypeValueLabel.Location = new System.Drawing.Point(11, 20);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(125, 15);
            this.TypeValueLabel.TabIndex = 4;
            this.TypeValueLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.ResultParsing);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.WeekdayTextBox);
            this.Controls.Add(this.TypeValueLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(332, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ResultParsing;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label TypeValueLabel;
    }
}
