using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Пользовательский интерфейс покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Флаг для смены события AcceptButton. Если он == true добавляем customer иначе редактируем.
        /// </summary>
        private bool _flag = false;

        /// <summary>
        /// Проверка на валидацию.
        /// </summary>
        private bool _switchValidation = false;

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
        }

        /// <summary>
        /// Включение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        public void EnabledVisibleButtonsAccept()
        {
            acceptButton.Visible = true;
            cancelButton.Visible = true;
        }

        /// <summary>
        /// Отключение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void DisabledVisibleButtonsAccept()
        {
            acceptButton.Visible = false;
            cancelButton.Visible = false;
        }

        /// <summary>
        /// Включение всех элементов TextBox.
        /// </summary>
        private void EnabledTextBox()
        {
            fullNameTextBox.ReadOnly = false;
            addressControl1.EnabledTextBox();
            customersListBox.Enabled = false;
        }

        /// <summary>
        /// Отключение всех элементов TextBox.
        /// </summary>
        private void DisabledTextBox()
        {
            fullNameTextBox.ReadOnly = true;
            addressControl1.DisabledTextBox();
            customersListBox.Enabled = true;
        }

        /// <summary>
        /// Включение всех элементов Buttons.
        /// </summary>
        private void EnabledButtons()
        {
            addButton.Enabled = true;
            editButton.Enabled = false;
            removeButton.Enabled = false;
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
        private void AddButtonClick(object sender, System.EventArgs e)
        {
            customersListBox.SelectedIndex = -1;
            EnabledVisibleButtonsAccept();
            EnabledTextBox();
            DisabledButtons();
            ClearTextBox();

            _currentCustomer = new Customer();
            addressControl1.Address = new Address();
            _flag = true;
            _switchValidation = true;
            addressControl1._switchValidation = true;
        }

        /// <summary>
        /// Добавление покупателя.
        /// </summary>
        private void AddCustomer()
        {
            var fullName = _currentCustomer.FullName;
            var address = addressControl1.Address;
            var customer = new Customer(fullName, address);

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
        private void EditButtonClick(object sender, System.EventArgs e)
        {
            EnabledVisibleButtonsAccept();
            EnabledTextBox();
            DisabledButtons();

            _flag = false;
            _switchValidation = true;
            addressControl1._switchValidation = true;

        }

        /// <summary>
        /// Изменения покупателя.
        /// </summary>
        private void EditCustomer()
        {
            _currentCustomer.Address = addressControl1.Address;
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
        private void AcceptButtonClick(object sender, System.EventArgs e)
        {
            _switchValidation = false;
            addressControl1._switchValidation = false;
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
            addressControl1._switchValidation = false;
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
                FillInfo();
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
            addressControl1.FillInfo();
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
            var address = addressControl1.CheckAcceptButton();

            if (fullName && address)
            {
                acceptButton.Enabled = true;
            }
            else
            {
                acceptButton.Enabled = false;
            }
        }

        /// <summary>
        /// Событие.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressControlValidationRequested(object sender, EventArgs e)
        {
            bool allFieldsValid = addressControl1.CheckAcceptButton();

            acceptButton.Enabled = allFieldsValid;
        }
    }
}
