namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.enumerationsControl1 = new Programming.View.Panels.EnumerationsControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.seasonHandleControl1 = new Programming.View.Panels.SeasonHandleControl();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.weekdayParsingControl1 = new Programming.View.Panels.WeekdayParsingControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.FilmGroupBox = new System.Windows.Forms.GroupBox();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.rectanglesControl1 = new Programming.View.Panels.RectanglesControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl = new Programming.View.Panels.RectanglesCollisionControl();
            this.EnumsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.FilmGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.tabPage1);
            this.EnumsTabControl.Controls.Add(this.ClassesTabPage);
            this.EnumsTabControl.Controls.Add(this.RectanglesTabPage);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(1074, 635);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1066, 607);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Enums";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.EnumGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.24876F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.75124F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 603);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EnumGroupBox.Controls.Add(this.enumerationsControl1);
            this.EnumGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumGroupBox.Location = new System.Drawing.Point(3, 2);
            this.EnumGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumGroupBox.Size = new System.Drawing.Size(1054, 299);
            this.EnumGroupBox.TabIndex = 0;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            this.EnumGroupBox.Enter += new System.EventHandler(this.EnumGroupBox_Enter);
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.AutoSize = true;
            this.enumerationsControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enumerationsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsControl1.Location = new System.Drawing.Point(3, 18);
            this.enumerationsControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(1048, 279);
            this.enumerationsControl1.TabIndex = 0;
            this.enumerationsControl1.Load += new System.EventHandler(this.enumerationsControl1_Load);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.SeasonGroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.WeekdayGroupBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 306);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1054, 294);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SeasonGroupBox.Controls.Add(this.seasonHandleControl1);
            this.SeasonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonGroupBox.Location = new System.Drawing.Point(530, 2);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Size = new System.Drawing.Size(521, 290);
            this.SeasonGroupBox.TabIndex = 7;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.seasonHandleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonHandleControl1.Location = new System.Drawing.Point(3, 18);
            this.seasonHandleControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(515, 270);
            this.seasonHandleControl1.TabIndex = 0;
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WeekdayGroupBox.Controls.Add(this.weekdayParsingControl1);
            this.WeekdayGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayGroupBox.Location = new System.Drawing.Point(3, 2);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(521, 290);
            this.WeekdayGroupBox.TabIndex = 6;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.weekdayParsingControl1.Location = new System.Drawing.Point(6, 20);
            this.weekdayParsingControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(347, 86);
            this.weekdayParsingControl1.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClassesTabPage.Controls.Add(this.tableLayoutPanel3);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Size = new System.Drawing.Size(1066, 607);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.FilmGroupBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.RectanglesGroupBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1060, 603);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // FilmGroupBox
            // 
            this.FilmGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FilmGroupBox.Controls.Add(this.moviesControl1);
            this.FilmGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmGroupBox.Location = new System.Drawing.Point(533, 2);
            this.FilmGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmGroupBox.Name = "FilmGroupBox";
            this.FilmGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmGroupBox.Size = new System.Drawing.Size(524, 599);
            this.FilmGroupBox.TabIndex = 2;
            this.FilmGroupBox.TabStop = false;
            this.FilmGroupBox.Text = "Movies";
            // 
            // moviesControl1
            // 
            this.moviesControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moviesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesControl1.Location = new System.Drawing.Point(3, 18);
            this.moviesControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(518, 579);
            this.moviesControl1.TabIndex = 0;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RectanglesGroupBox.Controls.Add(this.rectanglesControl1);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 2);
            this.RectanglesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesGroupBox.Size = new System.Drawing.Size(524, 599);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rectanglesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesControl1.Location = new System.Drawing.Point(3, 18);
            this.rectanglesControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(518, 579);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 24);
            this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesTabPage.Size = new System.Drawing.Size(1066, 607);
            this.RectanglesTabPage.TabIndex = 3;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl
            // 
            this.rectanglesCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl.Location = new System.Drawing.Point(3, 2);
            this.rectanglesCollisionControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectanglesCollisionControl.Name = "rectanglesCollisionControl";
            this.rectanglesCollisionControl.Size = new System.Drawing.Size(1060, 603);
            this.rectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 635);
            this.Controls.Add(this.EnumsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Programming";
            this.EnumsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesTabPage.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.FilmGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage tabPage1;
        private GroupBox EnumGroupBox;
        private GroupBox SeasonGroupBox;
        private GroupBox WeekdayGroupBox;
        private TabPage ClassesTabPage;
        private GroupBox FilmGroupBox;
        private TabPage RectanglesTabPage;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl;
        private GroupBox RectanglesGroupBox;
        private View.Panels.RectanglesControl rectanglesControl1;
        private View.Panels.MoviesControl moviesControl1;
        private View.Panels.EnumerationsControl enumerationsControl1;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonHandleControl seasonHandleControl1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}