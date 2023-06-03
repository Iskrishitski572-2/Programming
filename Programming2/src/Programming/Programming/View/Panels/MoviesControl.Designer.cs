namespace Programming.View.Panels
{
    partial class MoviesControl
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
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearOfReleaseTextBox = new System.Windows.Forms.TextBox();
            this.DuractionTextBox = new System.Windows.Forms.TextBox();
            this.MoviesNameTextBox = new System.Windows.Forms.TextBox();
            this.YearOfReleaseLabel = new System.Windows.Forms.Label();
            this.DuractionLabel = new System.Windows.Forms.Label();
            this.MoviesNameLabel = new System.Windows.Forms.Label();
            this.FilmListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(186, 261);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(127, 46);
            this.FindMovieButton.TabIndex = 23;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(186, 196);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(127, 23);
            this.RatingTextBox.TabIndex = 22;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(186, 179);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(44, 15);
            this.RatingLabel.TabIndex = 21;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(186, 157);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(127, 23);
            this.GenreTextBox.TabIndex = 20;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(186, 140);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(41, 15);
            this.GenreLabel.TabIndex = 19;
            this.GenreLabel.Text = "Genre:";
            // 
            // YearOfReleaseTextBox
            // 
            this.YearOfReleaseTextBox.Location = new System.Drawing.Point(186, 117);
            this.YearOfReleaseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YearOfReleaseTextBox.Name = "YearOfReleaseTextBox";
            this.YearOfReleaseTextBox.Size = new System.Drawing.Size(127, 23);
            this.YearOfReleaseTextBox.TabIndex = 18;
            this.YearOfReleaseTextBox.TextChanged += new System.EventHandler(this.YearOfReleaseTextBox_TextChanged);
            // 
            // DuractionTextBox
            // 
            this.DuractionTextBox.Location = new System.Drawing.Point(186, 77);
            this.DuractionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DuractionTextBox.Name = "DuractionTextBox";
            this.DuractionTextBox.Size = new System.Drawing.Size(127, 23);
            this.DuractionTextBox.TabIndex = 17;
            this.DuractionTextBox.TextChanged += new System.EventHandler(this.DuractionTextBox_TextChanged);
            // 
            // MoviesNameTextBox
            // 
            this.MoviesNameTextBox.Location = new System.Drawing.Point(186, 35);
            this.MoviesNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesNameTextBox.Name = "MoviesNameTextBox";
            this.MoviesNameTextBox.Size = new System.Drawing.Size(127, 23);
            this.MoviesNameTextBox.TabIndex = 16;
            this.MoviesNameTextBox.TextChanged += new System.EventHandler(this.MoviesNameTextBox_TextChanged);
            // 
            // YearOfReleaseLabel
            // 
            this.YearOfReleaseLabel.AutoSize = true;
            this.YearOfReleaseLabel.Location = new System.Drawing.Point(186, 100);
            this.YearOfReleaseLabel.Name = "YearOfReleaseLabel";
            this.YearOfReleaseLabel.Size = new System.Drawing.Size(85, 15);
            this.YearOfReleaseLabel.TabIndex = 15;
            this.YearOfReleaseLabel.Text = "Year of release:";
            // 
            // DuractionLabel
            // 
            this.DuractionLabel.AutoSize = true;
            this.DuractionLabel.Location = new System.Drawing.Point(186, 60);
            this.DuractionLabel.Name = "DuractionLabel";
            this.DuractionLabel.Size = new System.Drawing.Size(62, 15);
            this.DuractionLabel.TabIndex = 14;
            this.DuractionLabel.Text = "Duraction:";
            // 
            // MoviesNameLabel
            // 
            this.MoviesNameLabel.AutoSize = true;
            this.MoviesNameLabel.Location = new System.Drawing.Point(186, 18);
            this.MoviesNameLabel.Name = "MoviesNameLabel";
            this.MoviesNameLabel.Size = new System.Drawing.Size(81, 15);
            this.MoviesNameLabel.TabIndex = 13;
            this.MoviesNameLabel.Text = "Movies name:";
            // 
            // FilmListBox
            // 
            this.FilmListBox.FormattingEnabled = true;
            this.FilmListBox.ItemHeight = 15;
            this.FilmListBox.Location = new System.Drawing.Point(11, 18);
            this.FilmListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmListBox.Name = "FilmListBox";
            this.FilmListBox.Size = new System.Drawing.Size(165, 289);
            this.FilmListBox.TabIndex = 12;
            this.FilmListBox.SelectedIndexChanged += new System.EventHandler(this.FilmListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.FindMovieButton);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.YearOfReleaseTextBox);
            this.Controls.Add(this.DuractionTextBox);
            this.Controls.Add(this.MoviesNameTextBox);
            this.Controls.Add(this.YearOfReleaseLabel);
            this.Controls.Add(this.DuractionLabel);
            this.Controls.Add(this.MoviesNameLabel);
            this.Controls.Add(this.FilmListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(352, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FindMovieButton;
        private TextBox RatingTextBox;
        private Label RatingLabel;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private TextBox YearOfReleaseTextBox;
        private TextBox DuractionTextBox;
        private TextBox MoviesNameTextBox;
        private Label YearOfReleaseLabel;
        private Label DuractionLabel;
        private Label MoviesNameLabel;
        private ListBox FilmListBox;
    }
}
