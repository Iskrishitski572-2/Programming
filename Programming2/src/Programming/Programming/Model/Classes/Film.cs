namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Film
    {
        /// <summary>
        /// Хранит значение продолжительности фильма в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Хранит значение года выпуска фильма.
        /// </summary>
        private int _yearOfRelease;

        /// <summary>
        /// Хранит значение рейтинга фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Создает экземпляр класса Film.
        /// </summary>
        /// <param name="moviesName">Название фильма.</param>
        /// <param name="durationInMinutes">Продолжительность фильма в минутах. Должна быть больше нуля.</param>
        /// <param name="yearOfRelease">Год выхода. Должен быть в диапазоне от 1900 до текущего года.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в диапазоне от 0 до 10.</param>
        public Film(string moviesName, int durationInMinutes, int yearOfRelease, string genre, double rating)
        {
            MoviesName = moviesName;
            DurationInMinutes = durationInMinutes;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Создает экземпляр класса Film.
        /// </summary>
        public Film() { }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string MoviesName { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма в минутах. Должна быть больше нуля.
        /// </summary>
        public int DurationInMinutes
        {
            get { return _durationInMinutes; } 
            
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));

                _durationInMinutes = value;
            } 
        }

        /// <summary>
        /// Возвращает и задает год выхода. Должен быть в диапазоне от 1900 до текущего года.
        /// </summary>
        public int YearOfRelease
        {
            get { return _yearOfRelease; }
            
            set
            {
                Validator.AssertValueInRange(value, nameof(YearOfRelease), 1900, DateTime.Now.Year);

                _yearOfRelease = value;
            } 
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен быть в диапазоне от 0 до 10.
        /// </summary>
        public double Rating
        {
            get { return _rating; } 

            set
            {
                Validator.AssertValueInRange(value, nameof(Rating), 0, 10);

                _rating = value;
            }    
        }
    }
}
