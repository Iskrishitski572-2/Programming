using System;
using ObjectOrientedPractics.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Пользовательский интерфейс товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Флаг для смены события AcceptButton. Если он == true добавляем item, иначе редактируем.
        /// </summary>
        private bool _flag = false;

        /// <summary>
        /// Создает экземпляр класса ItemsTab.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
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
            costTextBox.ReadOnly = false;
            nameTextBox.ReadOnly = false;
            descriptionTextBox.ReadOnly = false;
            itemsListBox.Enabled = false;
        }

        /// <summary>
        /// Отключение всех элементов TextBox.
        /// </summary>
        private void DisabledTextBox()
        {
            costTextBox.ReadOnly = true;
            nameTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            itemsListBox.Enabled = true;
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
        /// События добавления нового товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            itemsListBox.SelectedIndex = -1;
            EnabledVisibleButtonsAccept();
            EnabledTextBox();
            DisabledButtons();
            ClearTextBox();
            costTextBox.Text = "0";

            _flag = true;
        }

        /// <summary>
        /// Добавление товара.
        /// </summary>
        private void AddItem()
        {
            var name = nameTextBox.Text;
            var description = descriptionTextBox.Text;
            var cost = Convert.ToDouble(costTextBox.Text);
            var item = new Item(name, description, cost);

            _items.Add(item);
            itemsListBox.Items.Add(item.Name);

            DisabledVisibleButtonsAccept();
            EnabledButtons();
            DisabledTextBox();
            ClearTextBox();
        }

        /// <summary>
        /// Событие изменения товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButtonClick(object sender, EventArgs e)
        {
            EnabledVisibleButtonsAccept();
            EnabledTextBox();
            DisabledButtons();

            _flag = false;
        }

        /// <summary>
        /// Изменения товара.
        /// </summary>
        private void EditItem()
        {
            _currentItem.Name = nameTextBox.Text;
            _currentItem.Cost = Convert.ToDouble(costTextBox.Text);
            _currentItem.Info = descriptionTextBox.Text;

            _items[itemsListBox.SelectedIndex] = _currentItem;
            itemsListBox.Items[itemsListBox.SelectedIndex] = _currentItem.Name;


            DisabledVisibleButtonsAccept();
            EnabledButtons();
            DisabledTextBox();
        }

        /// <summary>
        /// Событие удаления товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButtonClick(object sender, EventArgs e)
        {
            _items.RemoveAt(itemsListBox.SelectedIndex);
            itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);
            ClearTextBox();
        }

        /// <summary>
        /// Событие принятия добавления или редактирования товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptButtonClick(object sender, EventArgs e)
        {
            if (_flag)
            {
                AddItem();
            }
            else
            {
                EditItem();
            }
        }

        /// <summary>
        /// Событие отмены добавления или редактирования товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
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
            idTextBox.Text = _currentItem.Id.ToString();
            costTextBox.Text = _currentItem.Cost.ToString();
            nameTextBox.Text = _currentItem.Name;
            descriptionTextBox.Text = _currentItem.Info;
        }

        /// <summary>
        /// Выбор элемента в itemsListBox с последующим обновлением информации в TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                removeButton.Enabled = false;
                editButton.Enabled = false;
            }
            else
            {
                _currentItem = _items[itemsListBox.SelectedIndex];
                removeButton.Enabled = true;
                editButton.Enabled = true;
                FillInfo();
            }
        }

        /// <summary>
        /// Очистка всех полей.
        /// </summary>
        private void ClearTextBox()
        {
            idTextBox.Text = "";
            costTextBox.Text = "";
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            costTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Валидация CostTextBox на цену товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBoxTextChanged(object sender, EventArgs e)
        {
            try
            {
                var cost = Convert.ToDouble(costTextBox.Text);
                costTextBox.BackColor = Color.White;

                ValueValidator.AssertValueInRange(cost, 0, 100000, nameof(cost));
                CheckAcceptButton();
            }
            catch
            {
                costTextBox.BackColor = Color.Red;
                acceptButton.Enabled = false;
            }
        }

        /// <summary>
        /// Валидация NameTextBox на количество символов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            try
            {
                var name = nameTextBox.Text;
                nameTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(name, 200, nameof(name));
                CheckAcceptButton();
            }
            catch
            {
                nameTextBox.BackColor = Color.Red;
                acceptButton.Enabled = false;
            }
        }

        /// <summary>
        /// Валидация DescriptionTextBox на количество символов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTextBoxTextChanged(object sender, EventArgs e)
        {
            try
            {
                var description = descriptionTextBox.Text;
                descriptionTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(description, 1000, nameof(description));
                CheckAcceptButton();
            }
            catch
            {
                descriptionTextBox.BackColor = Color.Red;
                acceptButton.Enabled = false;
            }
        }

        /// <summary>
        /// Проверка на включение AcceptButton.
        /// </summary>
        private void CheckAcceptButton()
        {
            var cost = costTextBox.BackColor == Color.White;
            var name = nameTextBox.BackColor == Color.White;
            var description = descriptionTextBox.BackColor == Color.White;

            if (cost && name && description)
            {
                acceptButton.Enabled = true;
            }
        }
    }
}
