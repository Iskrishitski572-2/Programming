using ObjectOrientedPractics.Services;

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
        /// Адрес покупателя.
        /// </summary>
        private string _address;

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

        /// <summary>
        /// Возвращает и задает адрес. Должен быть не более 500 символов.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, Address);
                _address = value;
            }
        }


        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя. Должно быть не более 200 символов.</param>
        /// <param name="address">Адрес. Должен быть не более 500 символов</param>
        public Customer(string fullName, string address)
        {
            Id = IdGenerator.GetNewIdCustomer();
            FullName = fullName;
            Address = address;
        }
    }
}

