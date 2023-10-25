using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private string _fullName;

        private string _adress;

        public int Id { get; }

        public string FullName
        {
            get => _fullName;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, FullName);
                _fullName = value;
            }
        }

        public string Adress
        {
            get => _adress;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, Adress);
                _adress = value;
            }
        }

        public Customer(string fullName, string adress, int id)
        {
            FullName = fullName;
            Adress = adress;

            Id = IdGenerator.GetNewIdCustomer();


        }


    }
}
