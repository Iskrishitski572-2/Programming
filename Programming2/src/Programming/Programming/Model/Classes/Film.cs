namespace Programming.Model
{
    public class Film
    {
        private int _durationInMinutes;
        private int _yearOfRelease;
        private double _rating;

        public Film(string moviesName, int durationInMinutes, int yearOfRelease, string genre, double rating)
        {
            MoviesName = moviesName;
            DurationInMinutes = durationInMinutes;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }

        public Film() { }

        public string MoviesName { get; set; }

        public string Genre { get; set; }

        public int DurationInMinutes
        {
            get { return _durationInMinutes; } 
            
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));

                _durationInMinutes = value;
            } 
        }

        public int YearOfRelease
        {
            get { return _yearOfRelease; }
            
            set
            {
                Validator.AssertValueInRange(value, nameof(YearOfRelease), 1900, DateTime.Now.Year);

                _yearOfRelease = value;
            } 
        }

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
