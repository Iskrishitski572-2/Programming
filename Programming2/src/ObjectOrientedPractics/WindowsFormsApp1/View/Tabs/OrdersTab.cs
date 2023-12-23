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

        private Order _currentOrder;

        private PriorityOrder _currentPriorityOrder;

        private object[] _time =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        /// <summary>
        /// Создает экземпляр OrdersTab.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            UpdateOrdersDataGridView();
            var orderStatus = Enum.GetNames(typeof(OrderStatus));
            statusComboBox.Items.AddRange(orderStatus);
            deliveryTimeComboBox.Items.AddRange(_time);
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
                    Customer[i].Orders[j].Address = Customer[i].Address;
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
                var address = $"{s.Index}, {s.Country}, {s.City}, {s.Street}, {s.Building}, {s.Apartment}";
                ordersDataGridView.Rows.Add();
                ordersDataGridView.Rows[j].Cells[0].Value = _orders[j].Id;
                ordersDataGridView.Rows[j].Cells[1].Value = _orders[j].CreatedDate;
                ordersDataGridView.Rows[j].Cells[2].Value = _orders[j].Status;
                ordersDataGridView.Rows[j].Cells[3].Value = _orders[j].FullName;
                ordersDataGridView.Rows[j].Cells[4].Value = address;
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
            if (_orders[index] is PriorityOrder priority)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }

            UpdateTextBox(index);
        }

        /// <summary>
        /// Обновление информации в textBoxs.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateTextBox(int index)
        {
            var isPriority = _orders[index] is PriorityOrder priority;

            if (isPriority)
            {
                _currentPriorityOrder = (PriorityOrder)_orders[index];
                _currentOrder = null;
                deliveryTimeComboBox.Text = _currentPriorityOrder.DeliveryTime;
            }
            else
            {
                deliveryTimeComboBox.SelectedIndex = -1;
                _currentPriorityOrder = null;
                _currentOrder = _orders[index];
            }

            idTextBox.Text = isPriority ? _currentPriorityOrder.Id.ToString() : _currentOrder.Id.ToString();
            createdTextBox.Text = isPriority ? _currentPriorityOrder.CreatedDate.ToString() : _currentOrder.CreatedDate.ToString();
            statusComboBox.Text = isPriority ? _currentPriorityOrder.Status.ToString() : _currentOrder.Status.ToString();
            addressControl1.Address = isPriority ? _currentPriorityOrder.Address : _currentOrder.Address;
            addressControl1.FillInfo();

            itemsListBox.Items.Clear();
            var items = isPriority ? _currentPriorityOrder.Items : _currentOrder.Items; ;
            foreach (var item in items)
            {
                itemsListBox.Items.Add(item.Name);
            }

            amountCounterLabel.Text = isPriority ? _currentPriorityOrder.Amount.ToString() : _currentOrder.Amount.ToString();
        }

        /// <summary>
        /// Событие изменения статуса заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var index = ordersDataGridView.CurrentCell.RowIndex;
                var isPriority = _orders[index] is PriorityOrder priority;
                if (isPriority && index != -1)
                {
                    _currentPriorityOrder.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), statusComboBox.Text);
                    ordersDataGridView.Rows[index].Cells[2].Value = _currentPriorityOrder.Status;
                }
                else if (index != -1)
                {
                    _currentOrder.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), statusComboBox.Text);
                    ordersDataGridView.Rows[index].Cells[2].Value = _currentOrder.Status;
                }
            }
            catch
            {
                // ignored
            }
        }

        private void deliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var index = ordersDataGridView.CurrentCell.RowIndex;
                var isPriority = _orders[index] is PriorityOrder priority;
                if (isPriority && index != -1)
                {
                    _currentPriorityOrder.DeliveryTime = deliveryTimeComboBox.Text;
                }
            }
            catch
            {
                // ignored
            }

        }
    }
}
