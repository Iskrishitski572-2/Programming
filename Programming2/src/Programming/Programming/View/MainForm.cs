using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Classes;
using Programming.Model.Enums;
using Programming.Model.Geometry;

using Color = Programming.Model.Enums.Color;
using Point2D = Programming.Model.Geometry.Point2D;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private object[] _enums = new object[]
        {
            typeof(Color),
            typeof(Genre),
            typeof(EducationForm),
            typeof(Manufactures),
            typeof(Season),
            typeof(Weekday)
        };
        
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;
 
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;
        
        private Random _random = new Random();

        private List<Rectangle> _rectanglesList = new List<Rectangle>();
        private Rectangle _currentRectangleList;
        private List<Panel> _rectanglePanel = new List<Panel>();

        public MainForm()
        {
            InitializeComponent();
            
            FillRectangles(_rectangles);
            FillMovies(_movies);

            enumsListBox.Items.AddRange(_enums);
            enumsListBox.DisplayMember = nameof(FileInfo.Name);
            
            var rectangles = new List<string>() {"Rectangle 1","Rectangle 2","Rectangle 3",
                "Rectangle 4","Rectangle 5"};
            foreach (var rectangle in rectangles)
            {
                classRectanglesListBox.Items.Add(rectangle);
            }
            
            var movies = new List<string>() {"Movie 1","Movie 2","Movie 3","Movie 4","Movie 5"};
            foreach (var movie in movies)
            {
                moviesListBox.Items.Add(movie);
            }
            
            seasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));
            
            enumsListBox.SelectedIndex = 0;
            seasonComboBox.SelectedIndex = 0;
            classRectanglesListBox.SelectedIndex = 0;
            moviesListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enumsListBox.SelectedItem == null)
            {
                return;
            }
    
            var selectedEnum = (Type)enumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            valuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                valuesListBox.Items.Add(enumValue);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var number = ((int)Enum.Parse(Type.GetType(enumsListBox.Text), valuesListBox.Text)).ToString();
            intValueTextBox.Text = number.ToString();

        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues(typeof(Weekday));
            var flag = false;
            foreach (var enumValue in enumValues)
            {
                var stringValue = enumValue.ToString();
                if (weekdayTextBox.Text == stringValue)
                {
                    flag = !flag;
                    resultParsingLabel.Text = $"Это день недели ({stringValue} = " +
                                         $"{(int)Enum.Parse(typeof(Weekday), stringValue)})";
                }
            }
            if (!flag)
                resultParsingLabel.Text = "Нет такого дня недели";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (seasonComboBox.Text)
            {
                case "Spring":
                {
                    seasonGroupBox.BackColor = System.Drawing.Color.Green;
                    break;
                }
                case "Summer":
                {
                    MessageBox.Show("Ура! Солнце!");
                    break;
                }
                case "Fall":
                {
                    seasonGroupBox.BackColor = System.Drawing.Color.Orange;
                    break;
                }
                case "Winter":
                {
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                }
            }
        }
        /*
        private void FillRectangles(Rectangle[] rectangles)
        {
            var colorValues = Enum.GetValues((Type)_enums[0]);
            for (int i = 0; i < 5; i++)
            {
                int length = _random.Next(1, 30);
                int width = _random.Next(1, 30);
                string color = colorValues.GetValue(_random.Next(0, 6)).ToString();
                int x = _random.Next(1, 30);
                int y = _random.Next(1, 30);
                Point2D coordinate = new Point2D(x, y);
                rectangles[i] = new Rectangle(length, width, color, coordinate); 
            }
        }   
        */

        private void FillRectangles(Rectangle[] rectangles)
        {
            for (int i = 0; i < 5; i++)
            {
                rectangles[i] = RectangleFactory.Randomize();
            }
        }
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[classRectanglesListBox.SelectedIndex];
            lengthTextBox.Text = _rectangles[classRectanglesListBox.SelectedIndex].Length.ToString();
            widthTextBox.Text = _rectangles[classRectanglesListBox.SelectedIndex].Width.ToString();
            colorTextBox.Text = _rectangles[classRectanglesListBox.SelectedIndex].Color;
            xTextBox.Text = _currentRectangle.Center.X.ToString();
            yTextBox.Text = _currentRectangle.Center.Y.ToString();
            idTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void ClassRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[classRectanglesListBox.SelectedIndex];
            lengthTextBox.Text = _rectangles[classRectanglesListBox.SelectedIndex].Length.ToString();
            widthTextBox.Text = _rectangles[classRectanglesListBox.SelectedIndex].Width.ToString();
            colorTextBox.Text = _rectangles[classRectanglesListBox.SelectedIndex].Color;
            xTextBox.Text = _currentRectangle.Center.X.ToString();
            yTextBox.Text = _currentRectangle.Center.Y.ToString();
            idTextBox.Text = _currentRectangle.Id.ToString();

        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lengthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Length = Convert.ToDouble(lengthTextBox.Text);
            }
            catch
            {
                lengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                widthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Width = Convert.ToDouble(widthTextBox.Text);
            }
            catch
            {
                widthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = colorTextBox.Text;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int index = 0;
            double maxWidth = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    index = i;
                }
            }

            return index;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            var index = FindRectangleWithMaxWidth(_rectangles);
            classRectanglesListBox.SelectedIndex = index;
        }
        
        private void FillMovies(Movie[] movies)
        {
            var genreValues = Enum.GetValues((Type)_enums[1]);
            for (int i = 0; i < 5; i++)
            {
                int year = _random.Next(1900, 2024);
                int durationMinutes = _random.Next(1, 181);
                int rating = _random.Next(0, 11);
                string genre = genreValues.GetValue(_random.Next(0, 6)).ToString();
                movies[i] = new Movie($"Movie {i + 1}", durationMinutes, year, genre, rating); 
            }
        }
        
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[moviesListBox.SelectedIndex];

            titleTextBox.Text = _movies[moviesListBox.SelectedIndex].Title;
            yearTextBox.Text = _movies[moviesListBox.SelectedIndex].Year.ToString();
            timeTextBox.Text = _movies[moviesListBox.SelectedIndex].DurationMinutes.ToString();
            genreTextBox.Text = _movies[moviesListBox.SelectedIndex].Genre;
            ratingTextBox.Text = _movies[moviesListBox.SelectedIndex].Rating.ToString();
        }
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = titleTextBox.Text;
        }
        
        private void TimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                timeTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.DurationMinutes = Convert.ToInt32(timeTextBox.Text);
            }
            catch
            {
                timeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                yearTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Year = Convert.ToInt32(yearTextBox.Text);
            }
            catch
            {
                yearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = genreTextBox.Text;
        }
        
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ratingTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Rating = Convert.ToDouble(ratingTextBox.Text);
            }
            catch
            {
                ratingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        
        private int FindMoviesWithMaxRating(Movie[] movies)
        {
            int index = 0;
            double maxRating = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    index = i;
                }
            }
            return index;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            var index = FindMoviesWithMaxRating(_movies);
            moviesListBox.SelectedIndex = index;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>





        private static string TakeInfoFromRectangle(Rectangle rectangle)
        {
            var info = $"{rectangle.Id}. " +
                       $"(X={rectangle.Center.X}; " +
                       $"Y={rectangle.Center.Y};" +
                       $" W={rectangle.Width}; " +
                       $"L={rectangle.Length})";

            return info;
        }
        private void UpdateRectangleInfo(ref Rectangle rectangle)
        {
            rectangle = _rectanglesList[rectanglesListBox.SelectedIndex];

            rectanglesIdTextBox.Text = rectangle.Id.ToString();
            rectanglesXTextBox.Text = rectangle.Center.X.ToString();
            rectanglesYTextBox.Text = rectangle.Center.Y.ToString();
            rectanglesWidthTextBox.Text = rectangle.Width.ToString();
            rectanglesLengthTextBox.Text = rectangle.Length.ToString();
        }

        private void ClearRectangleInfo()
        {
            rectanglesIdTextBox.Text = "";
            rectanglesXTextBox.Text = "";
            rectanglesYTextBox.Text = "";
            rectanglesWidthTextBox.Text = "";
            rectanglesLengthTextBox.Text = "";

            rectanglesXTextBox.BackColor = System.Drawing.Color.White;
            rectanglesYTextBox.BackColor = System.Drawing.Color.White;
            rectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
            rectanglesLengthTextBox.BackColor = System.Drawing.Color.White;
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize();
            var panel = new Panel();

            var info = TakeInfoFromRectangle(rectangle);

            _rectanglesList.Add(rectangle);
            rectanglesListBox.Items.Add(info);

            panel.Height = Convert.ToInt32(rectangle.Length);
            panel.Width = Convert.ToInt32(rectangle.Width);
            var x = Convert.ToInt32(rectangle.Center.X);
            var y = Convert.ToInt32(rectangle.Center.Y);
            panel.Location = new Point(x, y);
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

            _rectanglePanel.Add(panel);
            rectanglesPanel.Controls.Add(panel);
            FindCollision();
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            try
            {
                _rectanglesList.RemoveAt(rectanglesListBox.SelectedIndex);
                _rectanglePanel.RemoveAt(rectanglesListBox.SelectedIndex);
                rectanglesPanel.Controls.RemoveAt(rectanglesListBox.SelectedIndex);
                rectanglesListBox.Items.RemoveAt(rectanglesListBox.SelectedIndex);
                FindCollision();
            }
            catch
            {
                // ignored
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateRectangleInfo(ref _currentRectangleList);
            }
            catch
            {
                ClearRectangleInfo();
            }
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rectanglesXTextBox.BackColor = System.Drawing.Color.White;

                var x = Convert.ToDouble(rectanglesXTextBox.Text);
                var y = _currentRectangleList.Center.Y;
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Center = coordinatePoint2D;
                _rectanglePanel[rectanglesListBox.SelectedIndex].Location = coordinatePoint;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                rectanglesXTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rectanglesYTextBox.BackColor = System.Drawing.Color.White;

                var x = _currentRectangleList.Center.X;
                var y = Convert.ToDouble(rectanglesYTextBox.Text);
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Center = coordinatePoint2D;
                _rectanglePanel[rectanglesListBox.SelectedIndex].Location = coordinatePoint;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                rectanglesYTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged2(object sender, EventArgs e)
        {
            try
            {
                rectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
                var widthDouble = Convert.ToDouble(rectanglesWidthTextBox.Text);
                var widthInt = Convert.ToInt32(rectanglesWidthTextBox.Text);
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Width = widthDouble;
                _rectanglePanel[rectanglesListBox.SelectedIndex].Width = widthInt;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                rectanglesWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void LengthTextBox_TextChanged2(object sender, EventArgs e)
        {
            try
            {
                rectanglesLengthTextBox.BackColor = System.Drawing.Color.White;
                var lengthDouble = Convert.ToDouble(rectanglesLengthTextBox.Text);
                var lengthInt = Convert.ToInt32(rectanglesLengthTextBox.Text);
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Length = lengthDouble;
                _rectanglePanel[rectanglesListBox.SelectedIndex].Height = lengthInt;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                rectanglesLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindCollision()
        {
            var colorRed = System.Drawing.Color.FromArgb(127, 255, 127, 127);
            var colorGreen = System.Drawing.Color.FromArgb(127, 127, 255, 127);

            foreach (Panel rectangle in rectanglesPanel.Controls)
            {
                rectangle.BackColor = colorGreen;
            }

            for (int i = 0; i < _rectanglesList.Count; i++)
            {
                for (int j = 0; j < _rectanglesList.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]) && i != j)
                    {
                        _rectanglePanel[i].BackColor = colorRed;
                        _rectanglePanel[j].BackColor = colorRed;
                    }
                }
            }
        }
    }
}