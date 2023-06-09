namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полете.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Хранит значение времени полета в минутах.
        /// </summary>
        private int _flightTimeInMinutes;

        /// <summary>
        /// Создает экземпляр класса Flight.
        /// </summary>
        /// <param name="departurePoint">Место отправления.</param>
        /// <param name="destination">Место назначения.</param>
        /// <param name="flightTimeInMinutes">Время полета в минутах. Должно быть больше нуля.</param>
        public Flight(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        /// <summary>
        /// Создает экземпляр класса Flight.
        /// </summary>
        public Flight() { }

        /// <summary>
        /// Возвращает и задает место отправления.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задает место назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает время полета в минутах. Должно быть больше нуля.
        /// </summary>
        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));

                _flightTimeInMinutes = value;
            }   
        }
    }
}
