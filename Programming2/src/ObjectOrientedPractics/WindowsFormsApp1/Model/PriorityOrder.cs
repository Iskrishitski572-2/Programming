using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    internal class PriorityOrder : Order
    {
        private string _deliveryTime;

        public string DeliveryTime { get { return _deliveryTime; } set { _deliveryTime = value; } }

        public PriorityOrder(Address address, string fullName, List<Item> items, double ammount, string deliveryTime) :
            base(address, fullName, items, ammount)
        {
            DeliveryTime = deliveryTime;
        }

        public PriorityOrder(int id, DateTime createdDate) : base(id, createdDate) { }
    }
}
