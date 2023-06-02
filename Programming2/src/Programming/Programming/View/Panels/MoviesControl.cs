using Programming.Model;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса MoviesControl.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Film[] _movies = new Film[5];

        /// <summary>
        /// Текущий выбранный фильм.
        /// </summary>
        private Film _currentFilm;

        /// <summary>
        /// Экземпляр класса Random.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Создает экземпляр класса MoviesControl.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            FillMovies(_movies);

            // Заполнение FilmListBox.
            var movies = new List<string>() { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" };
            foreach (var movie in movies)
            {
                FilmListBox.Items.Add(movie);
            }

            FilmListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Заполнение массива фильмов со случайными значениями.
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
        private void FillMovies(Film[] movies)
        {
            var genreValues = Enum.GetValues(typeof(Genre));

            for (int i = 0; i < 5; i++)
            {
                int year = _random.Next(1900, DateTime.Now.Year);
                int durationInMinutes = _random.Next(1, 181);
                int rating = _random.Next(0, 11);
                string genre = genreValues.GetValue(_random.Next(0, 6)).ToString();
                movies[i] = new Film($"Movie {i + 1}", durationInMinutes, year, genre, rating);
            }
        }

        /// <summary>
        /// Выбор элемента в FilmListBox с последующим обновлением информации в TextBox.
        /// </summary>
        private void FilmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _movies[FilmListBox.SelectedIndex];

            MoviesNameTextBox.Text = _movies[FilmListBox.SelectedIndex].MoviesName;
            YearOfReleaseTextBox.Text = _movies[FilmListBox.SelectedIndex].YearOfRelease.ToString();
            DuractionTextBox.Text = _movies[FilmListBox.SelectedIndex].DurationInMinutes.ToString();
            GenreTextBox.Text = _movies[FilmListBox.SelectedIndex].Genre;
            RatingTextBox.Text = _movies[FilmListBox.SelectedIndex].Rating.ToString();
        }

        /// <summary>
        /// Изменение данных в MoviesNameTextBox.
        /// </summary>
        private void MoviesNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.MoviesName = MoviesNameTextBox.Text;
        }

        /// <summary>
        /// Изменение данных в DuractionTextBox.
        /// </summary>
        private void DuractionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DuractionTextBox.BackColor = AppColors.NormalColor;
                _currentFilm.DurationInMinutes = Convert.ToInt32(DuractionTextBox.Text);
            }
            catch
            {
                DuractionTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменение данных в YearOfReleaseTextBox.
        /// </summary>
        private void YearOfReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearOfReleaseTextBox.BackColor = AppColors.NormalColor;
                _currentFilm.YearOfRelease = Convert.ToInt32(YearOfReleaseTextBox.Text);
            }
            catch
            {
                YearOfReleaseTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменение данных в GenreTextBox.
        /// </summary>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreTextBox.Text;
        }

        /// <summary>
        /// Изменение данных в RatingTextBox.
        /// </summary>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingTextBox.BackColor = AppColors.NormalColor;
                _currentFilm.Rating = Convert.ToInt32(RatingTextBox.Text);
            }
            catch
            {
                RatingTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Возвращает индекс фильма с самым большим рейтингом. 
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
        /// <returns>Индекс.</returns>
        private int FindMoviesWithMaxRating(Film[] movies)
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

        /// <summary>
        /// Обработчик, который выбирает элемент с максимальным рейтингом.
        /// </summary>
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int index = FindMoviesWithMaxRating(_movies);
            FilmListBox.SelectedIndex = index;
        }
    }
}
