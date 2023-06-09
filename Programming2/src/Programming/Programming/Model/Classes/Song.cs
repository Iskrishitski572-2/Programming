namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песнях.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Хранит значение продолжительности фильма в минутах.
        /// </summary>
        private int _songLengthInMinutes;

        /// <summary>
        /// Создает экземпляр класса Song.
        /// </summary>
        /// <param name="artistsName">Автор.</param>
        /// <param name="songsName">Название песни.</param>
        /// <param name="songLengthInMinutes">Продолжительность песни в минутах. Должна быть больше нуля.</param>
        public Song(string artistsName, string songsName, int songLengthInMinutes)
        {
            ArtistsName = artistsName;
            SongsName = songsName;
            SongLengthInMinutes = songLengthInMinutes;
        }

        /// <summary>
        /// Создает экземпляр класса Song.
        /// </summary>
        public Song() { }

        /// <summary>
        /// Возвращает и задает имя автора.
        /// </summary>
        public string ArtistsName { get; set; }

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string SongsName { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность песни в минутах. Должна быть больше нуля.
        /// </summary>
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
