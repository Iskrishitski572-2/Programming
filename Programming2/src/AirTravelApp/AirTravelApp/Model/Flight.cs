using System;

namespace AirTravelApp.Model
{
    /// <summary>
    /// Хранит данные о полете.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Создает экземпляр класса Flight.
        /// </summary>
        /// <param name="departurePoint">Место отправления.</param>
        /// <param name="destination">Место назначения.</param>
        /// <param name="flightTimeMinutes">Время полета в минутах.</param>
        /// <param name="date">Дата отправки.</param>
        /// <param name="type">Тип рейса.</param>
        public Flight(string departurePoint, string destination, int flightTimeMinutes, DateTime date, string type)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
            Date = date;
            Type = type;
        }
        
    
        /// <summary>
        /// Возвращает и задает место отправления.
        /// </summary>
        public string DeparturePoint { get; set; }
        
        /// <summary>
        /// Возвращает и задает место назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает дату отправки.
        /// </summary>
        public DateTime Date { get; set; }
        
        /// <summary>
        /// Возвращает и задает время полета в минутах. Должно быть больше нуля.
        /// </summary>
        public int FlightTimeMinutes { get; set; }
        
        /// <summary>
        /// Возвращает и задает тип рейса.
        /// </summary>
        public string Type { get; set; }
    }
}