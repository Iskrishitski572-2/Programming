using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
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

        private double _discountAmount = 0;

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
            catch
            {
                // ignored
            }
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
                DiscountsListUpdate();
                CartListUpdate();
                AmountUpdate();
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
            AmountUpdate();
            CheckingEnablingButtons();
        }

        /// <summary>
        /// Событие создания заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOrderButtonClick(object sender, EventArgs e)
        {
            Order order;
            if (_currentCustomer.IsPriority)
            {
                order = new PriorityOrder(_currentCustomer.Address, _currentCustomer.FullName,
                    _currentCustomer.Cart.Items, _discountAmount, "12");
            }
            else
            {
                order = new Order(_currentCustomer.Address, _currentCustomer.FullName, _currentCustomer.Cart.Items, _discountAmount);
            }

            foreach (var discount in _currentCustomer.Discounts)
            {
                discount.Update(_currentCustomer.Cart.Items);
            }

            var selectedIndices = discountsCheckedListBox.CheckedIndices;

            foreach (var index in selectedIndices)
            {
                _currentCustomer.Discounts[Convert.ToInt32(index)].Apply(_currentCustomer.Cart.Items);
            }

            _currentCustomer.Orders.Add(order);

            _currentCustomer.Cart = new Cart();;
            CartListUpdate();
            DiscountsListUpdate();
            AmountUpdate();
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
            AmountUpdate();
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
            AmountUpdate();
            CheckingEnablingButtons();
        }

        /// <summary>
        /// Проверка включения кнопок.
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
            foreach (var item in _currentCustomer.Cart.Items)
            {
                cartListBox.Items.Add(item.Name);
            }
        }

        public void DiscountsListUpdate()
        {
            discountsCheckedListBox.Items.Clear();
            foreach (var discount in _currentCustomer.Discounts)
            {
                discountsCheckedListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Обновление информации о цене товаров в корзине.
        /// </summary>
        public void AmountUpdate()
        {
            amountCounterLabel.Text = _currentCustomer.Cart.Amount.ToString();

            try
            {
                _discountAmount = 0;
                var selectedDiscountIndices = discountsCheckedListBox.CheckedIndices;

                foreach (var selectedIndex in selectedDiscountIndices)
                {
                    _discountAmount += _currentCustomer.Discounts[Convert.ToInt32(selectedIndex)]
                        .Calculate(_currentCustomer.Cart.Items);
                }

                discountCounterLabel.Text = _discountAmount.ToString();
            }
            catch
            {
                // Handle exceptions appropriately
                // (It's better to provide a more specific exception type or handle specific scenarios.)
            }

            totalCounterLabel.Text = (_currentCustomer.Cart.Amount - _discountAmount).ToString();

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

        /// <summary>
        /// Обработчик изменения выбранных элементов в CheckedListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckedListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            AmountUpdate();
        }

        /// <summary>
        /// Обработчик изменения состояния элемента в CheckedListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiscountsCheckedListBoxItemCheck(object sender, ItemCheckEventArgs e)
        {
            AmountUpdate();
        }


    }
}
