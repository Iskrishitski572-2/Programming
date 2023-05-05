namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.enumsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.weekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.resultParsingLabel = new System.Windows.Forms.Label();
            this.typeValueForParsingLabel = new System.Windows.Forms.Label();
            this.parseButton = new System.Windows.Forms.Button();
            this.weekdayTextBox = new System.Windows.Forms.TextBox();
            this.seasonGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseSeasonLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.enumerationGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseValueLabel = new System.Windows.Forms.Label();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.intValueLabel = new System.Windows.Forms.Label();
            this.chooseEnumerationLabel = new System.Windows.Forms.Label();
            this.intValueTextBox = new System.Windows.Forms.TextBox();
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.classesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.findRectangleButton = new System.Windows.Forms.Button();
            this.moviesGroupBox = new System.Windows.Forms.GroupBox();
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.findMovieButton = new System.Windows.Forms.Button();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.enumsTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.weekdayGroupBox.SuspendLayout();
            this.seasonGroupBox.SuspendLayout();
            this.enumerationGroupBox.SuspendLayout();
            this.classesTabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.rectanglesGroupBox.SuspendLayout();
            this.moviesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.enumsTabPage);
            this.tabControl.Controls.Add(this.classesTabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(796, 458);
            this.tabControl.TabIndex = 0;
            // 
            // enumsTabPage
            // 
            this.enumsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.enumsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enumsTabPage.Controls.Add(this.tableLayoutPanel1);
            this.enumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.enumsTabPage.Name = "enumsTabPage";
            this.enumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.enumsTabPage.Size = new System.Drawing.Size(788, 432);
            this.enumsTabPage.TabIndex = 0;
            this.enumsTabPage.Text = "Enums";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.enumerationGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.weekdayGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.seasonGroupBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 212);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 212);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // weekdayGroupBox
            // 
            this.weekdayGroupBox.Controls.Add(this.resultParsingLabel);
            this.weekdayGroupBox.Controls.Add(this.typeValueForParsingLabel);
            this.weekdayGroupBox.Controls.Add(this.parseButton);
            this.weekdayGroupBox.Controls.Add(this.weekdayTextBox);
            this.weekdayGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayGroupBox.Location = new System.Drawing.Point(3, 3);
            this.weekdayGroupBox.Name = "weekdayGroupBox";
            this.weekdayGroupBox.Size = new System.Drawing.Size(384, 206);
            this.weekdayGroupBox.TabIndex = 0;
            this.weekdayGroupBox.TabStop = false;
            this.weekdayGroupBox.Text = "Weekday Parsing";
            // 
            // resultParsingLabel
            // 
            this.resultParsingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultParsingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.resultParsingLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resultParsingLabel.Location = new System.Drawing.Point(12, 95);
            this.resultParsingLabel.Name = "resultParsingLabel";
            this.resultParsingLabel.Size = new System.Drawing.Size(342, 58);
            this.resultParsingLabel.TabIndex = 7;
            this.resultParsingLabel.Text = "Введите день недели";
            // 
            // typeValueForParsingLabel
            // 
            this.typeValueForParsingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeValueForParsingLabel.Location = new System.Drawing.Point(15, 52);
            this.typeValueForParsingLabel.Name = "typeValueForParsingLabel";
            this.typeValueForParsingLabel.Size = new System.Drawing.Size(199, 16);
            this.typeValueForParsingLabel.TabIndex = 6;
            this.typeValueForParsingLabel.Text = "Type value for parsing:";
            // 
            // parseButton
            // 
            this.parseButton.BackColor = System.Drawing.Color.Silver;
            this.parseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.parseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parseButton.Location = new System.Drawing.Point(229, 71);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(99, 21);
            this.parseButton.TabIndex = 4;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = false;
            this.parseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // weekdayTextBox
            // 
            this.weekdayTextBox.Location = new System.Drawing.Point(15, 71);
            this.weekdayTextBox.Name = "weekdayTextBox";
            this.weekdayTextBox.Size = new System.Drawing.Size(199, 20);
            this.weekdayTextBox.TabIndex = 3;
            // 
            // seasonGroupBox
            // 
            this.seasonGroupBox.Controls.Add(this.chooseSeasonLabel);
            this.seasonGroupBox.Controls.Add(this.goButton);
            this.seasonGroupBox.Controls.Add(this.seasonComboBox);
            this.seasonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonGroupBox.Location = new System.Drawing.Point(393, 3);
            this.seasonGroupBox.Name = "seasonGroupBox";
            this.seasonGroupBox.Size = new System.Drawing.Size(384, 206);
            this.seasonGroupBox.TabIndex = 1;
            this.seasonGroupBox.TabStop = false;
            this.seasonGroupBox.Text = "Season Handle";
            // 
            // chooseSeasonLabel
            // 
            this.chooseSeasonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseSeasonLabel.Location = new System.Drawing.Point(16, 52);
            this.chooseSeasonLabel.Name = "chooseSeasonLabel";
            this.chooseSeasonLabel.Size = new System.Drawing.Size(155, 15);
            this.chooseSeasonLabel.TabIndex = 8;
            this.chooseSeasonLabel.Text = "Choose season:\r\n";
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Silver;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Location = new System.Drawing.Point(177, 70);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(103, 22);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(16, 70);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(155, 21);
            this.seasonComboBox.TabIndex = 0;
            // 
            // enumerationGroupBox
            // 
            this.enumerationGroupBox.Controls.Add(this.chooseValueLabel);
            this.enumerationGroupBox.Controls.Add(this.valuesListBox);
            this.enumerationGroupBox.Controls.Add(this.intValueLabel);
            this.enumerationGroupBox.Controls.Add(this.chooseEnumerationLabel);
            this.enumerationGroupBox.Controls.Add(this.intValueTextBox);
            this.enumerationGroupBox.Controls.Add(this.enumsListBox);
            this.enumerationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.enumerationGroupBox.Name = "enumerationGroupBox";
            this.enumerationGroupBox.Size = new System.Drawing.Size(774, 206);
            this.enumerationGroupBox.TabIndex = 1;
            this.enumerationGroupBox.TabStop = false;
            this.enumerationGroupBox.Text = "Enumerations";
            // 
            // chooseValueLabel
            // 
            this.chooseValueLabel.Location = new System.Drawing.Point(141, 16);
            this.chooseValueLabel.Name = "chooseValueLabel";
            this.chooseValueLabel.Size = new System.Drawing.Size(112, 16);
            this.chooseValueLabel.TabIndex = 7;
            this.chooseValueLabel.Text = "Choose value:\r\n";
            // 
            // valuesListBox
            // 
            this.valuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.valuesListBox.Location = new System.Drawing.Point(141, 36);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.ScrollAlwaysVisible = true;
            this.valuesListBox.Size = new System.Drawing.Size(112, 121);
            this.valuesListBox.TabIndex = 6;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // intValueLabel
            // 
            this.intValueLabel.Location = new System.Drawing.Point(292, 17);
            this.intValueLabel.Name = "intValueLabel";
            this.intValueLabel.Size = new System.Drawing.Size(85, 16);
            this.intValueLabel.TabIndex = 5;
            this.intValueLabel.Text = "Int value:";
            // 
            // chooseEnumerationLabel
            // 
            this.chooseEnumerationLabel.Location = new System.Drawing.Point(6, 17);
            this.chooseEnumerationLabel.Name = "chooseEnumerationLabel";
            this.chooseEnumerationLabel.Size = new System.Drawing.Size(112, 16);
            this.chooseEnumerationLabel.TabIndex = 3;
            this.chooseEnumerationLabel.Text = "Choose enumerations:\r\n";
            // 
            // intValueTextBox
            // 
            this.intValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.intValueTextBox.Location = new System.Drawing.Point(292, 36);
            this.intValueTextBox.Name = "intValueTextBox";
            this.intValueTextBox.Size = new System.Drawing.Size(104, 20);
            this.intValueTextBox.TabIndex = 2;
            // 
            // enumsListBox
            // 
            this.enumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.enumsListBox.FormattingEnabled = true;
            this.enumsListBox.Location = new System.Drawing.Point(6, 36);
            this.enumsListBox.Name = "enumsListBox";
            this.enumsListBox.ScrollAlwaysVisible = true;
            this.enumsListBox.Size = new System.Drawing.Size(112, 121);
            this.enumsListBox.TabIndex = 0;
            this.enumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // classesTabPage
            // 
            this.classesTabPage.BackColor = System.Drawing.Color.Transparent;
            this.classesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classesTabPage.Controls.Add(this.tableLayoutPanel3);
            this.classesTabPage.Location = new System.Drawing.Point(4, 22);
            this.classesTabPage.Name = "classesTabPage";
            this.classesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classesTabPage.Size = new System.Drawing.Size(788, 432);
            this.classesTabPage.TabIndex = 1;
            this.classesTabPage.Text = "Classes";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rectanglesGroupBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.moviesGroupBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(780, 424);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // rectanglesGroupBox
            // 
            this.rectanglesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectanglesGroupBox.Controls.Add(this.idLabel);
            this.rectanglesGroupBox.Controls.Add(this.yLabel);
            this.rectanglesGroupBox.Controls.Add(this.xLabel);
            this.rectanglesGroupBox.Controls.Add(this.idTextBox);
            this.rectanglesGroupBox.Controls.Add(this.yTextBox);
            this.rectanglesGroupBox.Controls.Add(this.xTextBox);
            this.rectanglesGroupBox.Controls.Add(this.rectanglesListBox);
            this.rectanglesGroupBox.Controls.Add(this.lengthLabel);
            this.rectanglesGroupBox.Controls.Add(this.widthLabel);
            this.rectanglesGroupBox.Controls.Add(this.colorLabel);
            this.rectanglesGroupBox.Controls.Add(this.colorTextBox);
            this.rectanglesGroupBox.Controls.Add(this.widthTextBox);
            this.rectanglesGroupBox.Controls.Add(this.lengthTextBox);
            this.rectanglesGroupBox.Controls.Add(this.findRectangleButton);
            this.rectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.rectanglesGroupBox.Name = "rectanglesGroupBox";
            this.rectanglesGroupBox.Size = new System.Drawing.Size(384, 418);
            this.rectanglesGroupBox.TabIndex = 0;
            this.rectanglesGroupBox.TabStop = false;
            this.rectanglesGroupBox.Text = "Rectangles";
            // 
            // idLabel
            // 
            this.idLabel.Location = new System.Drawing.Point(148, 251);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(92, 16);
            this.idLabel.TabIndex = 14;
            this.idLabel.Text = "Id:";
            // 
            // yLabel
            // 
            this.yLabel.Location = new System.Drawing.Point(148, 207);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(92, 16);
            this.yLabel.TabIndex = 13;
            this.yLabel.Text = "Coordinate y:";
            // 
            // xLabel
            // 
            this.xLabel.Location = new System.Drawing.Point(148, 161);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(92, 16);
            this.xLabel.TabIndex = 12;
            this.xLabel.Text = "Coordinate x:";
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Location = new System.Drawing.Point(148, 270);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(92, 20);
            this.idTextBox.TabIndex = 11;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            // 
            // yTextBox
            // 
            this.yTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yTextBox.Location = new System.Drawing.Point(148, 225);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(92, 20);
            this.yTextBox.TabIndex = 10;
            this.yTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YTextBox_KeyPress);
            // 
            // xTextBox
            // 
            this.xTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xTextBox.Location = new System.Drawing.Point(148, 179);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(92, 20);
            this.xTextBox.TabIndex = 9;
            this.xTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XTextBox_KeyPress);
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.Location = new System.Drawing.Point(15, 19);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(112, 368);
            this.rectanglesListBox.TabIndex = 8;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // lengthLabel
            // 
            this.lengthLabel.Location = new System.Drawing.Point(148, 65);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(58, 20);
            this.lengthLabel.TabIndex = 7;
            this.lengthLabel.Text = "Length:";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(148, 19);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(58, 20);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width:";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorLabel
            // 
            this.colorLabel.Location = new System.Drawing.Point(148, 111);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(58, 20);
            this.colorLabel.TabIndex = 5;
            this.colorLabel.Text = "Color:";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorTextBox
            // 
            this.colorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox.Location = new System.Drawing.Point(148, 134);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(92, 20);
            this.colorTextBox.TabIndex = 4;
            this.colorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthTextBox.Location = new System.Drawing.Point(148, 88);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(92, 20);
            this.widthTextBox.TabIndex = 3;
            this.widthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthTextBox.Location = new System.Drawing.Point(148, 42);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(92, 20);
            this.lengthTextBox.TabIndex = 2;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // findRectangleButton
            // 
            this.findRectangleButton.BackColor = System.Drawing.Color.Silver;
            this.findRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findRectangleButton.Location = new System.Drawing.Point(148, 314);
            this.findRectangleButton.Name = "findRectangleButton";
            this.findRectangleButton.Size = new System.Drawing.Size(55, 19);
            this.findRectangleButton.TabIndex = 1;
            this.findRectangleButton.Text = "Find";
            this.findRectangleButton.UseVisualStyleBackColor = false;
            this.findRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // moviesGroupBox
            // 
            this.moviesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moviesGroupBox.Controls.Add(this.moviesListBox);
            this.moviesGroupBox.Controls.Add(this.ratingLabel);
            this.moviesGroupBox.Controls.Add(this.genreLabel);
            this.moviesGroupBox.Controls.Add(this.yearLabel);
            this.moviesGroupBox.Controls.Add(this.timeLabel);
            this.moviesGroupBox.Controls.Add(this.titleLabel);
            this.moviesGroupBox.Controls.Add(this.findMovieButton);
            this.moviesGroupBox.Controls.Add(this.ratingTextBox);
            this.moviesGroupBox.Controls.Add(this.genreTextBox);
            this.moviesGroupBox.Controls.Add(this.yearTextBox);
            this.moviesGroupBox.Controls.Add(this.timeTextBox);
            this.moviesGroupBox.Controls.Add(this.titleTextBox);
            this.moviesGroupBox.Location = new System.Drawing.Point(393, 3);
            this.moviesGroupBox.Name = "moviesGroupBox";
            this.moviesGroupBox.Size = new System.Drawing.Size(384, 418);
            this.moviesGroupBox.TabIndex = 1;
            this.moviesGroupBox.TabStop = false;
            this.moviesGroupBox.Text = "Movies";
            // 
            // moviesListBox
            // 
            this.moviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Location = new System.Drawing.Point(14, 19);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(112, 368);
            this.moviesListBox.TabIndex = 9;
            this.moviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // ratingLabel
            // 
            this.ratingLabel.Location = new System.Drawing.Point(138, 203);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(58, 20);
            this.ratingLabel.TabIndex = 16;
            this.ratingLabel.Text = "Rating:";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genreLabel
            // 
            this.genreLabel.Location = new System.Drawing.Point(138, 157);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(58, 20);
            this.genreLabel.TabIndex = 15;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(137, 111);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(58, 20);
            this.yearLabel.TabIndex = 14;
            this.yearLabel.Text = "Year:";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(138, 65);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(58, 20);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "Time:";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(138, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 20);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // findMovieButton
            // 
            this.findMovieButton.BackColor = System.Drawing.Color.Silver;
            this.findMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findMovieButton.Location = new System.Drawing.Point(137, 270);
            this.findMovieButton.Name = "findMovieButton";
            this.findMovieButton.Size = new System.Drawing.Size(55, 19);
            this.findMovieButton.TabIndex = 8;
            this.findMovieButton.Text = "Find";
            this.findMovieButton.UseVisualStyleBackColor = false;
            this.findMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratingTextBox.Location = new System.Drawing.Point(137, 226);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(92, 20);
            this.ratingTextBox.TabIndex = 12;
            this.ratingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // genreTextBox
            // 
            this.genreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreTextBox.Location = new System.Drawing.Point(137, 180);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(92, 20);
            this.genreTextBox.TabIndex = 11;
            this.genreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearTextBox.Location = new System.Drawing.Point(137, 134);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(92, 20);
            this.yearTextBox.TabIndex = 10;
            this.yearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // timeTextBox
            // 
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeTextBox.Location = new System.Drawing.Point(137, 88);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(92, 20);
            this.timeTextBox.TabIndex = 9;
            this.timeTextBox.TextChanged += new System.EventHandler(this.TimeTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextBox.Location = new System.Drawing.Point(137, 42);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(92, 20);
            this.titleTextBox.TabIndex = 8;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(796, 458);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(812, 497);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl.ResumeLayout(false);
            this.enumsTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.weekdayGroupBox.ResumeLayout(false);
            this.weekdayGroupBox.PerformLayout();
            this.seasonGroupBox.ResumeLayout(false);
            this.enumerationGroupBox.ResumeLayout(false);
            this.enumerationGroupBox.PerformLayout();
            this.classesTabPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.rectanglesGroupBox.ResumeLayout(false);
            this.rectanglesGroupBox.PerformLayout();
            this.moviesGroupBox.ResumeLayout(false);
            this.moviesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label idLabel;

        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label xLabel;

        private System.Windows.Forms.ListBox rectanglesListBox;
        private System.Windows.Forms.ListBox moviesListBox;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

        private System.Windows.Forms.Label chooseValueLabel;

        private System.Windows.Forms.Label intValueLabel;
        private System.Windows.Forms.Label typeValueForParsingLabel;
        private System.Windows.Forms.Label resultParsingLabel;
        private System.Windows.Forms.Label chooseSeasonLabel;

        private System.Windows.Forms.Label chooseEnumerationLabel;

        private System.Windows.Forms.Button goButton;

        private System.Windows.Forms.ComboBox seasonComboBox;

        private System.Windows.Forms.Button parseButton;

        private System.Windows.Forms.TextBox intValueTextBox;
        private System.Windows.Forms.TextBox weekdayTextBox;

        private System.Windows.Forms.ListBox enumsListBox;
        private System.Windows.Forms.ListBox valuesListBox;

        private System.Windows.Forms.GroupBox seasonGroupBox;

        private System.Windows.Forms.GroupBox weekdayGroupBox;

        private System.Windows.Forms.GroupBox enumerationGroupBox;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label ratingLabel;

        private System.Windows.Forms.Button findMovieButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;

        private System.Windows.Forms.GroupBox moviesGroupBox;

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;

        private System.Windows.Forms.Label colorLabel;

        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox colorTextBox;

        private System.Windows.Forms.Button findRectangleButton;

        private System.Windows.Forms.GroupBox rectanglesGroupBox;

        private System.Windows.Forms.TabPage classesTabPage;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage enumsTabPage;

        #endregion
    }
}