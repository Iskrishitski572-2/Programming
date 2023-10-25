using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
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
                //VALUDATOR
                _fullName = value;
            }
        }

        public string Adress
        {
            get => _adress;
            set
            {
                //VALUDATOR
                _adress = value;
            }
        }

        public Customer(string fullName, string adress, int id)
        {
            FullName = fullName;
            Adress = adress;

            //Id = GENERATOR id;


        }


    }
}
