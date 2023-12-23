using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Приоритетный заказ с дополнительной информацией о времени доставки.
    /// </summary>
    internal class PriorityOrder : Order
    {
        /// <summary>
        /// Возвращает или задает время доставки приоритетного заказа.
        /// </summary>
        public string DeliveryTime { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес доставки заказа.</param>
        /// <param name="fullName">Полное имя покупателя.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="amount">Стоимость заказа.</param>
        /// <param name="deliveryTime">Время доставки заказа.</param>
        public PriorityOrder(Address address, string fullName, List<Item> items, double amount, string deliveryTime) :
            base(address, fullName, items, amount)
        {
            DeliveryTime = deliveryTime;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="id">Идентификатор заказа.</param>
        /// <param name="createdDate">Дата создания заказа.</param>
        public PriorityOrder(int id, DateTime createdDate) : base(id, createdDate) { }
    }
}