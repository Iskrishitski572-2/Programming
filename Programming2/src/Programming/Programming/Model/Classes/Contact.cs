using System.Text.RegularExpressions;

namespace Programming.Model
{
    public class Contact
    {
        private string _phoneNumber;
        private string _firstName;
        private string _lastName;

        public Contact(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public Contact() { }

        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");

            if (!regex.IsMatch(value))
            {
                throw new System.ArgumentException($"{name}: {value}. Введено не корректно");
            }
        }

        public string FirstName
        {
            get { return _firstName; }

            set
            {
                AssertStringContainsOnlyLetters(value, nameof(FirstName));

                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }

            set
            {
                AssertStringContainsOnlyLetters(value, nameof(LastName));

                _lastName = value;
            }
        }

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