namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Хранит значение количества часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Хранит значение количества минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Хранит значение количества секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Создает экземпляр класса Time.
        /// </summary>
        /// <param name="hours">Часы. Должны быть в диапазоне от 0 до 23.</param>
        /// <param name="minutes">Минуты. Должны быть в диапазоне от 0 до 59.</param>
        /// <param name="seconds">Секунды. Должны быть в диапазоне от 0 до 59.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Создает экземпляр класса Time.
        /// </summary>
        public Time() { }

        /// <summary>
        /// Возвращает и задает количество часов. Должны быть в диапазоне от 0 до 23.
        /// </summary>
        public int Hours
        {
            get { return _hours; }

            set 
            {
                Validator.AssertValueInRange(value, nameof(Hours), 0, 23);

                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество минут. Должны быть в диапазоне от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }

            set 
            {
                Validator.AssertValueInRange(value, nameof(Minutes), 0, 59);

                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество секунд. Должны быть в диапазоне от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }

            set 
            {
                Validator.AssertValueInRange(value, nameof(Seconds), 0, 59);

                _seconds = value;
            }
        }
    }
}
