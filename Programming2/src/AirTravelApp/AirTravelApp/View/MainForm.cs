using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AirTravelApp.Model;
using AirTravelApp.Model.Enums;

namespace AirTravelApp.View
{
    /// <summary>
    /// Создает главное окно.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        ///  Перечисление типов полета.
        /// </summary>
        private object[] _type = Enum.GetNames(typeof(TypeFlight));
        
        /// <summary>
        /// Список рейсов.
        /// </summary>
        private List<Flight> _flights;


        /// <summary>
        /// Список информации о рейсах.
        /// </summary>
        private List<string> _infoFlights = new List<string>();

        /// <summary>
        /// Текущий выбранный рейс.
        /// </summary>
        private Flight _currentFlights;

        /// <summary>
        /// Флаг для смены события AcceptButton. Если он == true добавляем рейс, иначе редактируем.
        /// </summary>
        private bool _flagButton;
        
        /// <summary>
        /// Создает экземпляр класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
            Serializer.IsCreateFolderAndFile();
            _flights = Serializer.GetData();
            
            if (_flights.Count > 0)
            {
               SortedFlightsAdd();
            }
            
            // timeDateTimePicker.MinDate = DateTime.Today;
            typeComboBox.Items.AddRange(_type);
        }
        
        /// <summary>
        /// Выбор элемента в flightListBox с последующим обновлением информации в TextBox.
        /// </summary>
        private void FlightListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledAcceptButton();
            if (airTravelListBox.SelectedIndex == -1)
            {
                deleteButton.Enabled = false;
                editButton.Enabled = false;
            }
            else
            {
                _currentFlights = _flights[airTravelListBox.SelectedIndex];
                editButton.Enabled = true;
                deleteButton.Enabled = true;
                FillInfo();
            }
        }

        /// <summary>
        /// Заполнение textbox.
        /// </summary>
        private void FillInfo()
        {
            departurePointTextBox.Text = _currentFlights.DeparturePoint;
            destinationTextBox.Text = _currentFlights.Destination;
            timeDateTimePicker.Value = _currentFlights.Date;
            flightTimeTextBox.Text = _currentFlights.FlightTimeMinutes.ToString();
            typeComboBox.Text = _currentFlights.Type;
        }
        
        /// <summary>
        /// Событие добавления рейса.
        /// </summary>
        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            airTravelListBox.SelectedIndex = -1;
            _flagButton = true;
            DisableButtonsClicks();
            EnableVisibleButtons();
            EnableElements();
            ClearTextBox();

            departurePointTextBox.BackColor = Color.Red;
            destinationTextBox.BackColor = Color.Red;
            flightTimeTextBox.BackColor = Color.Red;
            acceptButton.Enabled = false;
        }

    
        /// <summary>
        /// Сортировка по времени вылета add.
        /// </summary>
        private void SortedFlightsAdd()
        {
            _flights.Sort(delegate(Flight flight, Flight flight1)
            {
                return flight.Date.CompareTo(flight1.Date);
            });

            for (int i = 0; i < _flights.Count; i++)
            {
                _infoFlights.Add($"{_flights[i].Date}: {_flights[i].DeparturePoint} - {_flights[i].Destination}");
                airTravelListBox.Items.Add($"{_flights[i].Date.Day}.{_flights[i].Date.Month}." +
                                           $"{_flights[i].Date.Year}" +
                                           $" {_flights[i].Date.Hour}.{_flights[i].Date.Minute}" +
                                           $": {_flights[i].DeparturePoint} - {_flights[i].Destination}");
            }
        }
        
        /// <summary>
        /// Сортировка по времени вылета delete.
        /// </summary>
        private void SortedFlightsDelete()
        {
            _infoFlights.Clear();
            airTravelListBox.Items.Clear();
        }
        
        /// <summary>
        /// Добавление рейса.
        /// </summary>
        private void AddFlightButtonAccept()
        {
            SortedFlightsDelete();
            Flight newFlight = new Flight(departurePointTextBox.Text, destinationTextBox.Text,
                Convert.ToInt32(flightTimeTextBox.Text), timeDateTimePicker.Value, typeComboBox.Text);
            
            _flights.Insert(0, newFlight);
            
            SortedFlightsAdd();
            
            Serializer.UpdateData(_flights);
            
            
            DisableElements();
            DisableVisibleButtons();
            EnableButtonsClicks();
            ClearTextBox();
            airTravelListBox.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Событие изменения рейса.
        /// </summary>
        private void EditFlightButton_Click(object sender, EventArgs e)
        {
            _flagButton = false;
            DisableButtonsClicks();
            EnableVisibleButtons();
            EnableElements();
        }
        
        /// <summary>
        /// Изменения рейса.
        /// </summary>
        private void EditFlightButtonAccept()
        {
            Flight newFlight = new Flight(departurePointTextBox.Text, destinationTextBox.Text,
                Convert.ToInt32(flightTimeTextBox.Text), timeDateTimePicker.Value, typeComboBox.Text);
            
            _flights.RemoveAt(airTravelListBox.SelectedIndex);
            SortedFlightsDelete();
            _flights.Add(newFlight);
            
            SortedFlightsAdd();
            
            Serializer.UpdateData(_flights);
            
            DisableElements();
            DisableVisibleButtons();
            EnableButtonsClicks();
            ClearTextBox();
        }
        
        /// <summary>
        /// Событие принятия добавления или редактирования рейса.
        /// </summary>
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_flagButton)
            {
                AddFlightButtonAccept();
            }
            else
            {
                EditFlightButtonAccept();
            }
        }
        
        /// <summary>
        /// Событие отмены добавления или редактирования рейса.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            EnableButtonsClicks();
            DisableElements();
            DisableVisibleButtons();
            
            if (airTravelListBox.SelectedIndex == -1)
            {
                deleteButton.Enabled = false;
                ClearTextBox();
            }
            else
            {
                FillInfo();
            }
        }
        
        /// <summary>
        /// Событие удаления рейса.
        /// </summary>
        private void DeleteFlightButton_Click(object sender, EventArgs e)
        {
            _flights.RemoveAt(airTravelListBox.SelectedIndex); 
            _infoFlights.RemoveAt(airTravelListBox.SelectedIndex);
            airTravelListBox.Items.RemoveAt(airTravelListBox.SelectedIndex);
            Serializer.UpdateData(_flights); 
            ClearTextBox();
        }
        
        /// <summary>
        /// Включение всех элементов в groupBox.
        /// </summary>
        private void EnableElements()
        {
            airTravelListBox.Enabled = false;
            departurePointTextBox.Enabled = true;
            destinationTextBox.Enabled = true;
            timeDateTimePicker.Enabled = true;
            flightTimeTextBox.Enabled = true;
            typeComboBox.Enabled = true;
        }

        /// <summary>
        /// Отключение всех элементов groupBox.
        /// </summary>
        private void DisableElements()
        {
            airTravelListBox.Enabled = true;
            departurePointTextBox.Enabled = false;
            destinationTextBox.Enabled = false;
            timeDateTimePicker.Enabled = false;
            flightTimeTextBox.Enabled = false;
            typeComboBox.Enabled = false;
        }

        /// <summary>
        /// Очистка всех полей.
        /// </summary>
        private void ClearTextBox()
        {
            destinationTextBox.Text = "";
            departurePointTextBox.Text = "";
            flightTimeTextBox.Text = "";
            typeComboBox.Text = "";
            timeDateTimePicker.Text = "";
            
            typeComboBox.BackColor = Color.White;
            flightTimeTextBox.BackColor = Color.White;
            destinationTextBox.BackColor = Color.White;
            departurePointTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Включение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void EnableVisibleButtons()
        {
            cancelButton.Visible = true;
            acceptButton.Visible = true;
        }
        
        /// <summary>
        /// Отключение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void DisableVisibleButtons()
        {
            cancelButton.Visible = false;
            acceptButton.Visible = false;
        }

        /// <summary>
        /// Включение нажатий кнопок addButton и deleteButton.
        /// </summary>
        private void EnableButtonsClicks()
        {
            addButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        /// <summary>
        /// Отключение нажатий кнопок addButton и deleteButton.
        /// </summary>
        private void DisableButtonsClicks()
        {
            addButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        /// <summary>
        /// Включение acceptButton.
        /// </summary>
        private void EnabledAcceptButton()
        {
            var departurePoint = departurePointTextBox.BackColor == Color.White;
            var destination = destinationTextBox.BackColor == Color.White;
            var flightTime = flightTimeTextBox.BackColor == Color.White;
            if (departurePoint && destination && flightTime)
            {
                acceptButton.Enabled = true;
            }
        }

        /// <summary>
        /// Событие изменения departurePointTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeparturePointTextBox_TextChanged(object sender, EventArgs e)
        {
            if (departurePointTextBox.Text.Length > 100 || departurePointTextBox.Text.Length == 0)
            {
                acceptButton.Enabled = false;
                departurePointTextBox.BackColor = Color.Red;
            }
            else
            {
                departurePointTextBox.BackColor = Color.White;
            }
            EnabledAcceptButton();
        }

        /// <summary>
        /// Событие изменения destinationTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (destinationTextBox.Text.Length > 100 || destinationTextBox.Text.Length == 0)
            {
                acceptButton.Enabled = false;
                destinationTextBox.BackColor = Color.Red;
            }
            else
            {
                destinationTextBox.BackColor = Color.White;
            }
            EnabledAcceptButton();
        }

        /// <summary>
        /// Событие изменения flightTimeTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlightTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var flightTime = Convert.ToInt32(flightTimeTextBox.Text);
                if (flightTime < 1 || flightTime > 1000)
                {
                    acceptButton.Enabled = false;
                    flightTimeTextBox.BackColor = Color.Red;
                }
                else
                {
                    flightTimeTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                acceptButton.Enabled = false;
                flightTimeTextBox.BackColor = Color.Red;
            }
            EnabledAcceptButton();
        }

        /// <summary>
        /// Cобытие вызова tooltip жля departurePointTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeparturePointTextBox_MouseHover(object sender, EventArgs e)
        {
            departurePointToolTip.SetToolTip(departurePointTextBox, "Длина должна быть от 1 до 100");
        }

        /// <summary>
        /// Cобытие вызова tooltip жля destinationTextBox_MouseHover.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DestinationTextBox_MouseHover(object sender, EventArgs e)
        {
            destinationToolTip.SetToolTip(destinationTextBox, "Длина должна быть от 1 до 100");
        }

        /// <summary>
        /// Cобытие вызова tooltip жля flightTimeTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlightTimeTextBox_MouseHover(object sender, EventArgs e)
        {
            flightTimeToolTip.SetToolTip(flightTimeTextBox, "Время должно быть от 1 до 1000");
        }
    }
}