namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time() { }
    
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertValueInRange(value, nameof(Hours), 0, 23);
                _hours = value;
            }
        }

        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertValueInRange(value, nameof(Minutes), 0, 59);
                _minutes = value;
            }
        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(value, nameof(Seconds), 0, 59);
                _seconds = value;
            }
        }
    }   
}