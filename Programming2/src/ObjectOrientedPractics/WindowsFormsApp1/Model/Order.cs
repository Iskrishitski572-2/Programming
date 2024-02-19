using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Id заказа.
        /// </summary>
        private int _id;

        /// <summary>
        /// Время создания заказа.
        /// </summary>
        private DateTime _createdDate;

        /// <summary>
        /// Состояние заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Адрес заказа.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Полное имя;
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Сумма заказа.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Возвращает Id товара.
        /// </summary>
        public int Id { get { return _id; } private set { _id = value; } }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime CreatedDate { get { return _createdDate; } private set { _createdDate = value; } }

        /// <summary>
        /// Возвращает и задает состояния заказа.
        /// </summary>
        public OrderStatus Status { get { return _status; } set { _status = value; } }

        /// <summary>
        /// Возвращает и задает адрес заказа.
        /// </summary>
        public Address Address { get { return _address; } set { _address = value; } }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// </summary>
        public string FullName { get { return _fullName; } set { _fullName = value; } }

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Возвращает и задает стоимость заказа.
        /// </summary>
        public double Amount { get { return _amount; } set { _amount = value; } }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="fullName"></param>
        /// <param name="items"></param>
        /// <param name="amount"></param>
        public Order(Address address, string fullName, List<Item> items, double amount)
        {
            Id = IdGenerator.GetNewIdOrder();
            CreatedDate = DateTime.Now;
            FullName = fullName;
            Status = OrderStatus.New;
            Address = address;
            Items = items;
            Amount = amount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdDate"></param>
        public Order(int id, DateTime createdDate)
        {
            Id = id;
            CreatedDate = createdDate;
        }
    }
}
