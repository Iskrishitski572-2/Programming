using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Класс, представляющий процентную скидку на товары в определенной категории.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        private double _currentDiscountPercentage;

        private double _totalSpentInCategory;

        /// <summary>
        /// Текущий процент скидки.
        /// </summary>
        public double CurrentDiscountPercentage
        {
            get => _currentDiscountPercentage;
            set => _currentDiscountPercentage = value;
        }

        /// <summary>
        /// Категория товаров, на которую распространяется скидка.
        /// </summary>
        public Category Category { get; }

        /// <summary>
        /// Информация о процентной скидке для отображения.
        /// </summary>
        public string Info => $"Процентная «{Category}» - {_currentDiscountPercentage}%";

        /// <summary>
        /// Рассчитывает сумму скидки на основе текущего процента и общей стоимости товаров в категории.
        /// </summary>
        /// <param name="items">Список товаров для расчета скидки.</param>
        /// <returns>Сумма скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double totalCostInCategory = items
                .Where(item => item.Category == Category)
                .Sum(item => item.Cost);

            return totalCostInCategory * (_currentDiscountPercentage / 100);
        }

        /// <summary>
        /// Применяет скидку к общей стоимости товаров в категории и обновляет текущий процент скидки.
        /// </summary>
        /// <param name="items">Список товаров, к которому применяется скидка.</param>
        /// <returns>Сумма примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            var discount = Calculate(items);

            _totalSpentInCategory += discount;

            if (!(_totalSpentInCategory >= 1000) || !(_currentDiscountPercentage < 10)) return discount;
            var additionalDiscount = (int)(_totalSpentInCategory / 1000);
            _currentDiscountPercentage = Math.Min(10, _currentDiscountPercentage + additionalDiscount);
            _totalSpentInCategory %= 1000;

            return discount;
        }

        /// <summary>
        /// Обновляет общую стоимость товаров в категории для дальнейшего расчета скидки.
        /// </summary>
        /// <param name="items">Список товаров для обновления стоимости.</param>
        public void Update(List<Item> items)
        {
            _totalSpentInCategory += items
                .Where(item => item.Category == Category)
                .Sum(item => item.Cost);
        }

        public int CompareTo(PercentDiscount other)
        {
            if (other == null) return 1;

            return this.CurrentDiscountPercentage.CompareTo(other.CurrentDiscountPercentage);
        }

        /// <summary>
        /// Конструктор класса PercentDiscount, устанавливающий начальные значения.
        /// </summary>
        /// <param name="category">Категория товаров для скидки.</param>
        /// <param name="currentDiscountPercentage">Начальный процент скидки.</param>
        public PercentDiscount(Category category, double currentDiscountPercentage = 1)
        {
            Category = category;
            _totalSpentInCategory = 0;
            CurrentDiscountPercentage = currentDiscountPercentage;
        }
    }
}
