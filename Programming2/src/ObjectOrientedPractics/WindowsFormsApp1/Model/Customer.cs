using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// 
        /// </summary>
        private bool _isPriority;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Возвращает ID покупателя.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает и задает полное имя покупателя. Должно быть не более 200
        /// символов.
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, FullName);
                _fullName = value;
            }
        }

        public bool IsPriority { get { return _isPriority; } set { _isPriority = value; } }


        /// <summary>
        /// Возвращает и задает адрес.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {

                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает корзину.
        /// </summary>
        public Cart Cart { get { return _cart; } set { _cart = value; } }

        /// <summary>
        /// Возвращает и задает список заказов.
        /// </summary>
        public List<Order> Orders { get { return _orders; } set { _orders = value; } }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя. Должно быть не более 200 символов.</param>
        /// <param name="isPriority"></param>
        /// <param name="address">Адрес. Должен быть не более 500 символов</param>
        /// <param name="cart">Корзина.</param>
        /// <param name="orders">Список заказов.</param>
        public Customer(string fullName, bool isPriority, Address address, Cart cart = null, List<Order> orders = null)
        {
            Id = IdGenerator.GetNewIdCustomer();
            IsPriority = isPriority;
            FullName = fullName;
            Address = address;
            Cart = cart ?? new Cart();
            Orders = orders ?? new List<Order>();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>. Используются для десериализации JSON файла.
        /// </summary>
        /// <param name="id">Id.</param>
        public Customer(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer() { Cart = new Cart(); }
    }
}