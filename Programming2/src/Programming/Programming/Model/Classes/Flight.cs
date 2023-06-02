namespace Programming.Model
{
    public class Flight
    {
        private int _flightTimeInMinutes;

        public Flight(string departurePoint, string destination, int fligthTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeInMinutes = fligthTimeInMinutes;
        }

        public Flight() { }

        public string DeparturePoint { get; set; }

        public string Destination { get; set; }

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
