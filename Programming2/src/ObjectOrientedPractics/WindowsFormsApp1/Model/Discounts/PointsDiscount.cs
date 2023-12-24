using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// 
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Количество баллов лояльности.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает и задает количество баллов лояльности, ограниченное нулем.
        /// </summary>
        public int Points
        {
            get => _points;
            private set => _points = value > 0 ? value : 0;
        }

        /// <summary>
        /// Информация о скидке на основе баллов лояльности.
        /// </summary>
        public string Info => $"Накопительные - {Points} баллов.";

        /// <summary>
        /// Рассчитывает сумму скидки на основе баллов лояльности и общей стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров для расчета скидки.</param>
        /// <returns>Сумма скидки.</returns>
        public double Calculate(List<Item> items)
        {
            var totalCost = items.Sum(item => item.Cost);
            var discountPercentage = Math.Min(0.3, Points / totalCost);

            return totalCost * discountPercentage;
        }

        /// <summary>
        /// Применяет скидку на общую стоимость товаров и вычитает использованные баллы.
        /// </summary>
        /// <param name="items">Список товаров, к которому применяется скидка.</param>
        /// <returns>Сумма примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            var discount = Calculate(items);

            Points -= (int)Math.Ceiling(discount);

            return discount;
        }

        /// <summary>
        /// Обновляет количество баллов лояльности на основе общей стоимости купленных товаров.
        /// </summary>
        /// <param name="items">Список товаров для обновления баллов лояльности.</param>
        public void Update(List<Item> items)
        {
            var totalCost = items.Sum(item => item.Cost);
            var earnedPoints = (int)Math.Ceiling(totalCost * 0.1);

            Points += earnedPoints;
        }

        public int CompareTo(PointsDiscount other)
        {
            if (other == null) return 1;

            return this.Points.CompareTo(other.Points);
        }

        /// <summary>
        /// Конструктор класса PointsDiscount.
        /// </summary>
        /// <param name="points">Начальное количество баллов.</param>
        public PointsDiscount(int points)
        {
            Points = points;
        }
    }
}
