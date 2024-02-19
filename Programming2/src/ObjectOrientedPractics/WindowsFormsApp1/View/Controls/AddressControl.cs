using ObjectOrientedPractics.Model;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Пользовательский интерфейс адресса.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адресс.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Проверка на валидацию.
        /// </summary>
        public bool _switchValidation = false;

        /// <summary>
        /// Событие.
        /// </summary>
        public event EventHandler ValidationRequested;

        /// <summary>
        /// 
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Включение всех элементов TextBox.
        /// </summary>
        public void EnabledTextBox()
        {
            postIndexTextBox.Enabled = true;
            countryTextBox.Enabled = true;
            cityTextBox.Enabled = true;
            streetTextBox.Enabled = true;
            buildingTextBox.Enabled = true;
            apartmentTextBox.Enabled = true;
        }

        /// <summary>
        /// Отключение всех элементов TextBox.
        /// </summary>
        public void DisabledTextBox()
        {
            postIndexTextBox.Enabled = false;
            countryTextBox.Enabled = false;
            cityTextBox.Enabled = false;
            streetTextBox.Enabled = false;
            buildingTextBox.Enabled = false;
            apartmentTextBox.Enabled = false;
        }

        /// <summary>
        /// Заполнения полей TextBox.
        /// </summary>
        public void FillInfo()
        {
            postIndexTextBox.Text = Address.Index.ToString();
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
            postIndexTextBox.Text = "";
            countryTextBox.Text = "";
            cityTextBox.Text = "";
            streetTextBox.Text = "";
            buildingTextBox.Text = "";
            apartmentTextBox.Text = "";
        }

        /// <summary>
        /// Валидация indexTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndexTextBoxTextChanged(object sender, System.EventArgs e)
        {
            if (_switchValidation == true)
            {
                try
                {
                    Address.Index = Convert.ToInt32(postIndexTextBox.Text);
                    postIndexTextBox.BackColor = Color.White;
                }
                catch
                {
                    postIndexTextBox.BackColor = Color.Red;
                }
                ValidationRequested?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                postIndexTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Валидация countryTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountryTextBoxTextChanged(object sender, System.EventArgs e)
        {
            if (_switchValidation == true)
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
        private void CityTextBoxTextChanged(object sender, System.EventArgs e)
        {
            if (_switchValidation == true)
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
        private void StreetTextBoxTextChanged(object sender, System.EventArgs e)
        {
            if (_switchValidation == true)
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
        private void BuildingTextBoxTextChanged(object sender, System.EventArgs e)
        {
            if (_switchValidation == true)
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
        private void ApartmentTextBoxTextChanged(object sender, System.EventArgs e)
        {
            if (_switchValidation == true)
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
            var index = postIndexTextBox.BackColor == Color.White;
            var country = countryTextBox.BackColor == Color.White;
            var city = cityTextBox.BackColor == Color.White;
            var street = streetTextBox.BackColor == Color.White;
            var building = buildingTextBox.BackColor == Color.White;
            var apartment = apartmentTextBox.BackColor == Color.White;

            if (index && country && city && street && building && apartment)
            {
                return true;
            }
            return false;
        }
    }
}
