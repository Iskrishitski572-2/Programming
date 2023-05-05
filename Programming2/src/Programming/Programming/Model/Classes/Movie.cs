namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _durationMinutes;
        private int _year;
        private double _rating;


        public Movie(string title, int durationMinutes, int year, string genre, double rating)
        {
            Title = title;
            DurationMinutes = durationMinutes;
            Year = year;
            Genre = genre;
            Rating = rating;
        }

        public Movie() { }
    
        public string Title { get; set; }

        public int DurationMinutes
        {
            get => _durationMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationMinutes));
                _durationMinutes = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                Validator.AssertValueInRange(value, nameof(Year), 1900, 2023);
                _year = value;
            }
        }

        public string Genre { get; set; }

        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(value, nameof(Rating), 0, 10);
                _rating = value;
            }
        }
    }
}