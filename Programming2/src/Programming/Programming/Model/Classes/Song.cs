namespace Programming.Model
{
    public class Song
    {
        private int _songLengthInMinutes;

        public Song(string artistsName, string songsName, int songLengthInMinutes)
        {
            ArtistsName = artistsName;
            SongsName = songsName;
            SongLengthInMinutes = songLengthInMinutes;
        }

        public Song() { }

        public string ArtistsName { get; set; }
        public string SongsName { get; set; }

        public int SongLengthInMinutes
        {
            get { return _songLengthInMinutes; }

            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(SongLengthInMinutes));

                _songLengthInMinutes = value;
            }
        }
    }
}
