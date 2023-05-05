namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTimeMinutes;

        public Flight(string departurePoint, string destination, int flightTimeMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }

        public Flight() { }
    
        public string DeparturePoint { get; set; }

        public string Destination { get; set; }

        public int FlightTimeMinutes
        {
            get => _flightTimeMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeMinutes));
                _flightTimeMinutes = value;
            }
        }
    }
}