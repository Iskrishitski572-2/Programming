using System.Text.RegularExpressions;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о человеке и его контактных данных.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Хранит значение номера телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Хранит значение имени человека.
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Хранит значение фамилии человека.
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Создает экземпляр класса Contact. 
        /// </summary>
        /// <param name="firstName">Имя. Должно состоять только из
        /// букв.</param>
        /// <param name="lastName">Фамилия. Должна состоять только из
        /// букв.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        public Contact(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Создает экземпляр класса Contact.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Проверяет, что строка состоит из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="name">Имя свойства, которая подлежит проверки.</param>
        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");

            if (!regex.IsMatch(value))
            {
                throw new System.ArgumentException($"{name}: {value}. Введено не корректно");
            }
        }

        /// <summary>
        /// Возвращает и задает имя человека. Должно состоять только
        /// из букв.
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }

            set
            {
                AssertStringContainsOnlyLetters(value, nameof(FirstName));

                _firstName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию человека. Должно состоять только
        /// из букв.
        /// </summary>
        public string LastName
        {
            get { return _lastName; }

            set
            {
                AssertStringContainsOnlyLetters(value, nameof(LastName));

                _lastName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона человека.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }

            set
            {
                string pattern = @"^[+]\d{1,18}$";

                if (!Regex.IsMatch(value, pattern))
                {
                    throw new System.ArgumentException("Неверный формат номера");
                }

                _phoneNumber = value;
            }
        }
    }
}