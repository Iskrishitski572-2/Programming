using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {

        private object[] _time =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        public List<Item> Items { get; set; }

        public List<Customer> Customers { get; set; }

        private PriorityOrder _order;

        public Customer customer = new Customer("Aboba naidenov", true, new Address(123456, "qwe", "qwer", "qwert", "qwerty", "qwertyn"));


        public PriorityOrdersTab()
        {
            InitializeComponent();
            object[] orderStatus = Enum.GetNames(typeof(OrderStatus));
            statusComboBox.Items.AddRange(orderStatus);
            deliveryTimeComboBox.Items.AddRange(_time);
        }

        private void StatusComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _order.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), statusComboBox.Text);
        }

        private void DeliveryTimeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _order.DeliveryTime = deliveryTimeComboBox.Text;
        }

        public void UpdateOrders()
        {
            Random random = new Random();
            var index = random.Next(0, Customers.Count);
            _order = new PriorityOrder(customer.Address, customer.FullName, new List<Item>(), 0, "");
            ///_order = new PriorityOrder(Customers[index].Address, Customers[index].FullName, new List<Item>(), 0, "");
        }

        public void UpdateTextBox()
        {
            idTextBox.Text = _order.Id.ToString();
            createdTextBox.Text = _order.CreatedDate.ToString();
            statusComboBox.Text = _order.Status.ToString();
            addressControl1.Address = _order.Address;
            deliveryTimeComboBox.Text = _order.DeliveryTime;
            addressControl1.FillInfo();
        }

        private void UpdateAmmount()
        {
            amountCounterLabel.Text = _order.Amount.ToString();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            var random = new Random();
            var index = random.Next(0, Items.Count);
            _order.Items.Add(Items[index]);
            itemsListBox.Items.Add(Items[index].Name);
            _order.Amount += Items[index].Cost;
            UpdateAmmount();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var index = itemsListBox.SelectedIndex;
            _order.Amount -= _order.Items[index].Cost;
            _order.Items.RemoveAt(index);
            itemsListBox.Items.RemoveAt(index);
            UpdateAmmount();
        }

        private void ItemsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = itemsListBox.SelectedIndex != -1;
        }

        private void СlearButtonClick(object sender, EventArgs e)
        {
            _order.Items.Clear();
            itemsListBox.Items.Clear();
            _order.Amount = 0;
            UpdateAmmount();
            removeButton.Enabled = false;
        }
    }
}
