using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Пользовательский интерфейс покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Форма вызывающая при добавление скидки категории.
        /// </summary>
        private readonly AddDiscountForm _discountForm = new AddDiscountForm();

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Флаг для смены события AcceptButton. Если он == true добавляем customer иначе редактируем.
        /// </summary>
        private bool _flag;

        /// <summary>
        /// 
        /// </summary>
        private List<IDiscount> _discounts = new List<IDiscount>();

        /// <summary>
        /// Проверка на валидацию.
        /// </summary>
        private bool _switchValidation;

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Создает экземпляр класса CustomerTap.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            addressControl1.ValidationRequested += AddressControlValidationRequested;
            _discountForm.ValidationRequested += DiscountDiscountFormGetInfo;
        }

        /// <summary>
        /// Включение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void EnabledVisibleButtonsAccept()
        {
            acceptButton.Visible = true;
            cancelButton.Visible = true;
            addDiscountsButton.Visible = true;
            removeDiscountsButton.Visible = true;
        }

        /// <summary>
        /// Отключение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void DisabledVisibleButtonsAccept()
        {
            acceptButton.Visible = false;
            cancelButton.Visible = false;
            addDiscountsButton.Visible = false;
            removeDiscountsButton.Visible = false;
        }

        /// <summary>
        /// Включение всех элементов TextBox.
        /// </summary>
        private void EnabledTextBox()
        {
            fullNameTextBox.ReadOnly = false;
            isPriorityCheckBox.Enabled = true;
            addressControl1.EnabledTextBox();
            customersListBox.Enabled = false;
        }

        /// <summary>
        /// Отключение всех элементов TextBox.
        /// </summary>
        private void DisabledTextBox()
        {
            fullNameTextBox.ReadOnly = true;
            isPriorityCheckBox.Enabled = false;
            addressControl1.DisabledTextBox();
            customersListBox.Enabled = true;
        }

        /// <summary>
        /// Включение всех элементов Buttons.
        /// </summary>
        private void EnabledButtons()
        {
            addButton.Enabled = true;
            if (!_flag)
            {
                editButton.Enabled = true;
                removeButton.Enabled = true;
            }
            else
            {
                editButton.Enabled = false;
                removeButton.Enabled = false;
            }
        }

        /// <summary>
        /// Отключение всех элементов Buttons.
        /// </summary>
        private void DisabledButtons()
        {
            addButton.Enabled = false;
            editButton.Enabled = false;
            removeButton.Enabled = false;
        }

        /// <summary>
        /// События добавления нового покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            customersListBox.SelectedIndex = -1;
            isPriorityCheckBox.Checked = false;
            EnabledVisibleButtonsAccept();
            EnabledTextBox();
            DisabledButtons();
            ClearTextBox();

            _currentCustomer = new Customer();

            _discountForm.UpdateCategoryComboBox(_currentCustomer.Discounts);

            discountsListBox.Items.Add(_currentCustomer.Discounts[0].Info);
            addressControl1.Address = new Address();
            _flag = true;
            _switchValidation = true;
            addressControl1.SwitchValidation = true;
        }

        /// <summary>
        /// Добавление покупателя.
        /// </summary>
        private void AddCustomer()
        {
            var fullName = _currentCustomer.FullName;
            var isPriority = _currentCustomer.IsPriority;
            var address = addressControl1.Address;
            var customer = new Customer(fullName, isPriority, address);

            customer.Discounts.Clear();
            foreach (var discount in _currentCustomer.Discounts)
            {
                customer.Discounts.Add(discount);
            }

            Customers.Add(customer);
            customersListBox.Items.Add(customer.FullName);

            DisabledVisibleButtonsAccept();
            EnabledButtons();
            DisabledTextBox();
            ClearTextBox();
        }

        /// <summary>
        /// Событие изменения покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButtonClick(object sender, EventArgs e)
        {
            EnabledVisibleButtonsAccept();
            EnabledTextBox();
            DisabledButtons();

            _discounts = new List<IDiscount>();
            foreach (var d in _currentCustomer.Discounts)
            {
                _discounts.Add(d);
            }

            _discountForm.UpdateCategoryComboBox(_currentCustomer.Discounts);

            _flag = false;
            _switchValidation = true;
            addressControl1.SwitchValidation = true;

        }

        /// <summary>
        /// Изменения покупателя.
        /// </summary>
        private void EditCustomer()
        {
            _currentCustomer.Address = addressControl1.Address;
            _currentCustomer.IsPriority = isPriorityCheckBox.Checked;
            _currentCustomer.FullName = fullNameTextBox.Text;

            Customers[customersListBox.SelectedIndex] = _currentCustomer;
            customersListBox.Items[customersListBox.SelectedIndex] = _currentCustomer.FullName;


            DisabledVisibleButtonsAccept();
            EnabledButtons();
            DisabledTextBox();
        }

        /// <summary>
        /// Событие удаления покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButtonClick(object sender, EventArgs e)
        {
            Customers.RemoveAt(customersListBox.SelectedIndex);
            customersListBox.Items.RemoveAt(customersListBox.SelectedIndex);
            ClearTextBox();
        }

        /// <summary>
        /// Событие принятия добавления или редактирования покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptButtonClick(object sender, EventArgs e)
        {
            _switchValidation = false;
            addressControl1.SwitchValidation = false;
            if (_flag)
            {
                AddCustomer();
            }
            else
            {
                EditCustomer();
            }
        }

        /// <summary>
        /// Событие отмены добавления или редактирования покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            _switchValidation = false;
            addressControl1.SwitchValidation = false;
            if (_flag)
            {
                EnabledButtons();
                DisabledTextBox();
                DisabledVisibleButtonsAccept();
                ClearTextBox();
            }
            else
            {
                EnabledButtons();
                DisabledTextBox();
                DisabledVisibleButtonsAccept();
                ClearTextBox();
                FillInfo();
                discountsListBox.Items.Clear();
                _currentCustomer.Discounts.Clear();
                _currentCustomer.Discounts = _discounts;
                foreach (var discount in _currentCustomer.Discounts)
                {
                    discountsListBox.Items.Add(discount.Info);
                }
            }
        }

        /// <summary>
        /// Заполнения полей TextBox.
        /// </summary>
        private void FillInfo()
        {
            idTextBox.Text = _currentCustomer.Id.ToString();
            fullNameTextBox.Text = _currentCustomer.FullName;
            addressControl1.Address = _currentCustomer.Address;
            isPriorityCheckBox.Checked = _currentCustomer.IsPriority;
            addressControl1.FillInfo();
            foreach (var discount in _currentCustomer.Discounts)
            {
                discountsListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Выбор элемента в customerListBox с последующим обновлением информации в TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex == -1)
            {
                removeButton.Enabled = false;
                editButton.Enabled = false;
            }
            else
            {
                _currentCustomer = Customers[customersListBox.SelectedIndex];
                removeButton.Enabled = true;
                editButton.Enabled = true;
                addressControl1.Address = _currentCustomer.Address;
                ClearTextBox();
                FillInfo();
            }
        }

        /// <summary>
        /// Очистка всех полей.
        /// </summary>
        private void ClearTextBox()
        {
            idTextBox.Text = "";
            fullNameTextBox.Text = "";
            addressControl1.ClearTextBox();
            isPriorityCheckBox.Checked = false;
            discountsListBox.Items.Clear();
        }

        /// <summary>
        /// Валидация fullNameTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBoxTextChanged(object sender, EventArgs e)
        {
            if (_switchValidation)
            {
                try
                {
                    _currentCustomer.FullName = fullNameTextBox.Text;
                    fullNameTextBox.BackColor = Color.White;
                    CheckAcceptButton();
                }
                catch
                {
                    fullNameTextBox.BackColor = Color.Red;
                    acceptButton.Enabled = false;
                }
            }
            else
            {
                fullNameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Проверка на включение AcceptButton.
        /// </summary>
        private void CheckAcceptButton()
        {
            var fullName = fullNameTextBox.BackColor == Color.White;

            acceptButton.Enabled = fullName;
        }

        /// <summary>
        /// Обработчик события запроса на валидацию адреса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressControlValidationRequested(object sender, EventArgs e)
        {
            var allFieldsValid = addressControl1.CheckAcceptButton();
            acceptButton.Enabled = allFieldsValid;
        }

        /// <summary>
        /// Обновляет данные в customerListBox.
        /// </summary>
        public void RefreshData()
        {
            if (Customers.Count <= 0) return;

            foreach (var customer in Customers)
            {
                customersListBox.Items.Add(customer.FullName);
            }
        }

        /// <summary>
        /// Обработчик изменения состояния checkBox1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (_switchValidation)
            {
                _currentCustomer.IsPriority = isPriorityCheckBox.Checked;
            }
        }

        /// <summary>
        /// Обработчик нажатия на AddDiscountsButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDiscountsButtonClick(object sender, EventArgs e)
        {
            _discountForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик события получения информации от DiscountForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiscountDiscountFormGetInfo(object sender, EventArgs e)
        {
            _currentCustomer.Discounts.Add(_discountForm.GetDiscount());
            discountsListBox.Items.Add(_discountForm.GetDiscount().Info);
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в discountsListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiscountsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            removeDiscountsButton.Enabled = discountsListBox.SelectedIndex != 0 && discountsListBox.SelectedIndex != -1;
        }

        /// <summary>
        /// Обработчик нажатия на кнопку удаления скидки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveDiscountsButtonClick(object sender, EventArgs e)
        {
            _currentCustomer.Discounts.RemoveAt(discountsListBox.SelectedIndex);
            discountsListBox.Items.RemoveAt(discountsListBox.SelectedIndex);
            _discountForm.UpdateCategoryComboBox(_currentCustomer.Discounts);
        }
    }
}
