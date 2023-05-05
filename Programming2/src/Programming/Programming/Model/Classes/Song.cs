namespace Programming.Model.Classes
{ 
    public class Song
    {
        private int _durationSeconds;

        public Song(string author, string nameSong, int durationSeconds)
        {
            Author = author;
            NameSong = nameSong;
            DurationSeconds = durationSeconds;
        }

        public Song() { }
    
        public string Author { get; set; }

        public string NameSong { get; set; }

        public int DurationSeconds
        {
            get => _durationSeconds;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationSeconds));
                _durationSeconds = value;
            }
        }
    }
}