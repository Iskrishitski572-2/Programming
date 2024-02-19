using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    ///  Пользовательский интерфейс корзины.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Создает экземпляр CartsTab.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// События выбора элемента в itemsListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem = Items[itemsListBox.SelectedIndex];
                CheckingEnablingButtons();
            }
            catch { }
        }

        /// <summary>
        /// Событие выбора элемента в customersComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer = Customers[customersComboBox.SelectedIndex];
                CheckingEnablingButtons();
                CartListUpdate();
                AmmountUpdate();
                CheckingEnablingButtons();
            }
            catch
            {
                cartListBox.Items.Clear();
                amountCounterLabel.Text = "0";
                CheckingEnablingButtons();
            }

        }

        /// <summary>
        /// Событие выбора элемента в CartListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CartListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cartListBox.SelectedIndex != -1)
            {
                removeItemButton.Enabled = true;
            }
            else
            {
                removeItemButton.Enabled = false;
            }
        }

        /// <summary>
        /// Событие добавления товара в корзнику.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCartButtonClick(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.Add(_currentItem);
            CartListUpdate();
            AmmountUpdate();
            CheckingEnablingButtons();
        }

        /// <summary>
        /// Событие создания соказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOrderButtonClick(object sender, EventArgs e)
        {
            Order order = new Order(_currentCustomer.Address, _currentCustomer.FullName, _currentCustomer.Cart.Items, _currentCustomer.Cart.Amount);
            _currentCustomer.Orders.Add(order);
            _currentCustomer.Cart = new Cart();
            CartListUpdate();
            AmmountUpdate();
            CheckingEnablingButtons();
        }

        /// <summary>
        /// События удаления товара из корзины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButtonClick(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.RemoveAt(cartListBox.SelectedIndex);
            CartListUpdate();
            AmmountUpdate();
            removeItemButton.Enabled = false;
            CheckingEnablingButtons();
        }

        /// <summary>
        /// События очистки корзины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCartButtonClick(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.Clear();
            CartListUpdate();
            AmmountUpdate();
            CheckingEnablingButtons();
        }

        /// <summary>
        /// Провекра включения кнопок.
        /// </summary>
        private void CheckingEnablingButtons()
        {
            if (itemsListBox.SelectedIndex != -1 && customersComboBox.SelectedIndex != -1)
            {
                addToCartButton.Enabled = true;
            }
            else
            {
                addToCartButton.Enabled = false;
            }

            if (cartListBox.Items.Count > 0)
            {
                clearCartButton.Enabled = true;
                createOrderButton.Enabled = true;
            }
            else
            {
                clearCartButton.Enabled = false;
                createOrderButton.Enabled = false;
            }
        }

        /// <summary>
        /// Заполнение cartListBox.
        /// </summary>
        public void CartListUpdate()
        {
            cartListBox.Items.Clear();
            for (int i = 0; i < _currentCustomer.Cart.Items.Count; i++)
            {
                cartListBox.Items.Add(_currentCustomer.Cart.Items[i].Name);
            }
        }

        /// <summary>
        /// Обновление инормации о цене товаров в корзине.
        /// </summary>
        public void AmmountUpdate()
        {
            amountCounterLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Обновления информации.
        /// </summary>
        public void RefreshData()
        {
            itemsListBox.Items.Clear();
            if (Items.Count > 0)
            {
                foreach (var item in Items)
                {
                    itemsListBox.Items.Add(item.Name);
                }
            }

            customersComboBox.Items.Clear();
            if (Customers.Count > 0)
            {
                foreach (var customer in Customers)
                {
                    customersComboBox.Items.Add(customer.FullName);
                }
            }
        }

        /// <summary>
        /// customersComboBox.SelectedIndex = -1.
        /// </summary>
        public void IndexComboBox()
        {
            customersComboBox.SelectedIndex = -1;
        }
    }
}
