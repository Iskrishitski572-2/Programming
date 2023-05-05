using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;

        public Contact(string firstName, string lastName, int number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        public Contact() { }
    
        public string FirstName
        {
            get => _firstName;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(FirstName));
                _firstName = value;
            } 
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(LastName));
                _lastName = value;  
            } 
        }

        public int Number { get; set; }

        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            if (!regex.IsMatch(value))
            {
                throw new System.ArgumentException($"{name}: {value}. Введено не корректно");
            }
        }
    }
}