using ObjectOrientedPractics.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Пользовательский интерфейс адреса.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Проверка на валидацию.
        /// </summary>
        public bool SwitchValidation = false;

        /// <summary>
        /// Событие.
        /// </summary>
        public event EventHandler ValidationRequested;

        /// <summary>
        /// Возвращает и задает адрес.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Конструктор класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Валидация indexTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndexTextBoxTextChanged(object sender, EventArgs e)
        {
            if (SwitchValidation)
            {
                try
                {
                    Address.Index = Convert.ToInt32(indexTextBox.Text);
                    indexTextBox.BackColor = Color.White;
                }
                catch
                {
                    indexTextBox.BackColor = Color.Red;
                }
                ValidationRequested?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                indexTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Валидация countryTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountryTextBoxTextChanged(object sender, EventArgs e)
        {
            if (SwitchValidation)
            {
                try
                {
                    Address.Country = countryTextBox.Text;
                    countryTextBox.BackColor = Color.White;
                }
                catch
                {
                    countryTextBox.BackColor = Color.Red;
                }
                ValidationRequested?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                countryTextBox.BackColor = Color.White;
            }

        }

        /// <summary>
        /// Валидация cityTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CityTextBoxTextChanged(object sender, EventArgs e)
        {
            if (SwitchValidation)
            {
                try
                {
                    Address.City = cityTextBox.Text;
                    cityTextBox.BackColor = Color.White;
                }
                catch
                {
                    cityTextBox.BackColor = Color.Red;
                }
                ValidationRequested?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                cityTextBox.BackColor = Color.White;
            }

        }

        /// <summary>
        /// Валидация streetTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreetTextBoxTextChanged(object sender, EventArgs e)
        {
            if (SwitchValidation)
            {
                try
                {
                    Address.Street = streetTextBox.Text;
                    streetTextBox.BackColor = Color.White;
                }
                catch
                {
                    streetTextBox.BackColor = Color.Red;
                }
                ValidationRequested?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                streetTextBox.BackColor = Color.White;
            }

        }

        /// <summary>
        /// Валидация buildingTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildingTextBoxTextChanged(object sender, EventArgs e)
        {
            if (SwitchValidation)
            {
                try
                {
                    Address.Building = buildingTextBox.Text;
                    buildingTextBox.BackColor = Color.White;
                }
                catch
                {
                    buildingTextBox.BackColor = Color.Red;
                }
                ValidationRequested?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                buildingTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Валидация apartmentTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApartmentTextBoxTextChanged(object sender, EventArgs e)
        {
            if (SwitchValidation)
            {
                try
                {
                    Address.Apartment = apartmentTextBox.Text;
                    apartmentTextBox.BackColor = Color.White;
                }
                catch
                {
                    apartmentTextBox.BackColor = Color.Red;
                }
                ValidationRequested?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                apartmentTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Проверка на включение AcceptButton.
        /// </summary>
        /// <returns></returns>
        public bool CheckAcceptButton()
        {
            var index = indexTextBox.BackColor == Color.White;
            var country = countryTextBox.BackColor == Color.White;
            var city = cityTextBox.BackColor == Color.White;
            var street = streetTextBox.BackColor == Color.White;
            var building = buildingTextBox.BackColor == Color.White;
            var apartment = apartmentTextBox.BackColor == Color.White;

            return index && country && city && street && building && apartment;
        }

        /// <summary>
        /// Включение всех элементов TextBox.
        /// </summary>
        public void EnabledTextBox()
        {
            indexTextBox.ReadOnly = false;
            countryTextBox.ReadOnly = false;
            cityTextBox.ReadOnly = false;
            streetTextBox.ReadOnly = false;
            buildingTextBox.ReadOnly = false;
            apartmentTextBox.ReadOnly = false;
        }

        /// <summary>
        /// Отключение всех элементов TextBox.
        /// </summary>
        public void DisabledTextBox()
        {
            indexTextBox.ReadOnly = true;
            countryTextBox.ReadOnly = true;
            cityTextBox.ReadOnly = true;
            streetTextBox.ReadOnly = true;
            buildingTextBox.ReadOnly = true;
            apartmentTextBox.ReadOnly = true;
        }

        /// <summary>
        /// Заполнения полей TextBox.
        /// </summary>
        public void FillInfo()
        {
            indexTextBox.Text = Address.Index.ToString();
            countryTextBox.Text = Address.Country;
            cityTextBox.Text = Address.City;
            streetTextBox.Text = Address.Street;
            buildingTextBox.Text = Address.Building;
            apartmentTextBox.Text = Address.Apartment;
        }

        /// <summary>
        /// Очистка всех полей.
        /// </summary>
        public void ClearTextBox()
        {
            indexTextBox.Text = "";
            countryTextBox.Text = "";
            cityTextBox.Text = "";
            streetTextBox.Text = "";
            buildingTextBox.Text = "";
            apartmentTextBox.Text = "";
        }
    }
}
