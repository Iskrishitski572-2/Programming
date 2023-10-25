using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private string _name;

        private string _info;

        private double _cost;

        public int Id { get; }

        public string Name
        {
            get => _name;
            set
            {
                //VALIDATOR
                _name = value;
            }
        }

        public string Info
        {
            get => _info;
            set
            {
                //VALIDATOR
                _info = value;
            }
        }

        public double Cost
        {
            get => _cost;
            set
            {
                //VALUDATOR
                _cost = value;
            }
        }

        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            //Id = ID GENERATOR id;
        }
    }

}
