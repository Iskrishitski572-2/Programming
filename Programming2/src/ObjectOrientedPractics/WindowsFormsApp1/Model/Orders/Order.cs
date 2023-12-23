using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Возвращает Id товара.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime CreatedDate { get; private set; }

        /// <summary>
        /// Возвращает и задает состояния заказа.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Возвращает и задает адрес заказа.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задает стоимость заказа.
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Возвращает и задает сумму скидки на заказ.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает общую стоимость заказа с учетом скидки.
        /// </summary>
        public double Total => Amount - DiscountAmount;

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки заказа.</param>
        /// <param name="fullName">Полное имя покупателя.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="discountAmount">Сумма скидки на заказ.</param>
        public Order(Address address, string fullName, List<Item> items, double discountAmount)
        {
            Id = IdGenerator.GetNewIdOrder();
            CreatedDate = DateTime.Now;
            FullName = fullName;
            Status = OrderStatus.New;
            Address = address;
            Items = items;
            DiscountAmount = discountAmount;
            foreach (var item in Items)
            {
                Amount += item.Cost;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="id">Идентификатор заказа.</param>
        /// <param name="createdDate">Дата создания заказа.</param>
        public Order(int id, DateTime createdDate)
        {
            Id = id;
            CreatedDate = createdDate;
        }
    }
}
