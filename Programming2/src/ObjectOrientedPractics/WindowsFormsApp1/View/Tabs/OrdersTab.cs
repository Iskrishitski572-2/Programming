using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Пользовательский интерфейс заказов.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customer { get; set; }

        /// <summary>
        /// Создает экземпляр OrdersTab.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            UpdateOrdersDataGridView();
            var OrderStatus = Enum.GetNames(typeof(OrderStatus));
            statusComboBox.Items.AddRange(OrderStatus);
        }

        /// <summary>
        /// Обновляет список товаров.
        /// </summary>
        public void UpdateOrders()
        {
            _orders.Clear();
            for (int i = 0; i < Customer.Count; i++)
            {
                for (int j = 0; j < Customer[i].Orders.Count; j++)
                {
                    Customer[i].Orders[j].FullName = Customer[i].FullName;
                    _orders.Add(Customer[i].Orders[j]);
                }
            }
            _orders = _orders.OrderBy(o => o.Id).ToList();
        }

        /// <summary>
        /// Обновляет строки OrdersDataGridView. 
        /// </summary>
        public void UpdateOrdersDataGridView()
        {
            ordersDataGridView.Rows.Clear();
            for (int j = 0; j < _orders.Count; j++)
            {
                var s = _orders[j].Address;
                string addres = $"{s.Index}, {s.Country}, {s.City}, {s.Street}, {s.Building}, {s.Apartment}";
                ordersDataGridView.Rows.Add();
                ordersDataGridView.Rows[j].Cells[0].Value = _orders[j].Id;
                ordersDataGridView.Rows[j].Cells[1].Value = _orders[j].CreatedDate;
                ordersDataGridView.Rows[j].Cells[2].Value = _orders[j].Status;
                ordersDataGridView.Rows[j].Cells[3].Value = _orders[j].FullName;
                ordersDataGridView.Rows[j].Cells[4].Value = addres;
                ordersDataGridView.Rows[j].Cells[5].Value = _orders[j].Amount;
            }

        }

        /// <summary>
        /// События изменения индекса ordersDataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = ordersDataGridView.CurrentCell.RowIndex;
            UpdateTextBox(index);
        }

        /// <summary>
        /// Обновление информации в textBoxs.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateTextBox(int index)
        {
            idTextBox.Text = _orders[index].Id.ToString();
            createdTextBox.Text = _orders[index].CreatedDate.ToString();
            statusComboBox.Text = _orders[index].Status.ToString();
            addressControl1.Address = _orders[index].Address;
            addressControl1.FillInfo();

            itemsListBox.Items.Clear();
            var items = _orders[index].Items;
            foreach (var item in items)
            {
                itemsListBox.Items.Add(item.Name);
            }

            amountCounterLabel.Text = _orders[index].Amount.ToString();
        }

        /// <summary>
        /// Событие изменения статуса заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ordersDataGridView.CurrentCell.RowIndex;
            if (index != -1)
            {
                _orders[index].Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), statusComboBox.Text);
                ordersDataGridView.Rows[index].Cells[2].Value = _orders[index].Status;
            }
        }
    }
}
