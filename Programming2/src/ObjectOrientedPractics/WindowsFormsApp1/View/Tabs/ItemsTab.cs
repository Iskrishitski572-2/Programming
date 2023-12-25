﻿using System;
using ObjectOrientedPractics.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Пользовательский интерфейс товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Флаг для смены события AcceptButton. Если он == true добавляем item, иначе редактируем.
        /// </summary>
        private bool _flag;

        /// <summary>
        /// Проверка на валидацию.
        /// </summary>
        private bool _switchValidation;

        private List<Item> _displayedItems;

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Создает экземпляр класса ItemsTab.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            var categories = Enum.GetNames(typeof(Category));
            var sorting = Enum.GetNames(typeof(Sorting));
            categoryComboBox.Items.AddRange(categories);
            findComboBox.Items.AddRange(sorting);
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
            categoryComboBox.Enabled = true;
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
            categoryComboBox.Enabled = false;
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
            costTextBox.Text = @"0";
            categoryComboBox.SelectedIndex = 0;

            _currentItem = new Item();
            _flag = true;
            _switchValidation = true;
        }

        /// <summary>
        /// Добавление товара.
        /// </summary>
        private void AddItem()
        {
            var name = _currentItem.Name;
            var cost = _currentItem.Cost;
            var category = _currentItem.Category;
            var info = _currentItem.Info;
            Item newItem = new Item(name, category, info, cost);


            Items.Add(newItem);
            comboBox1_SelectedIndexChanged(0, EventArgs.Empty);
            _switchValidation = false;


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
            _switchValidation = true;
        }

        /// <summary>
        /// Изменения товара.
        /// </summary>
        private void EditItem()
        {
            var s = _displayedItems[itemsListBox.SelectedIndex];

            int index = Items.IndexOf(s);
            Items[index] = _currentItem;
            comboBox1_SelectedIndexChanged(0, EventArgs.Empty);
            _switchValidation = false;

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
            Items.RemoveAt(itemsListBox.SelectedIndex);
            comboBox1_SelectedIndexChanged(0, EventArgs.Empty);

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
            _switchValidation = false;
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
            categoryComboBox.Text = _currentItem.Category.ToString();
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
                var s = _displayedItems[itemsListBox.SelectedIndex];

                int index = Items.IndexOf(s);
                _currentItem = Items[index];
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
            categoryComboBox.SelectedIndex = -1;
            costTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Валидация CostTextBox на цену товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBoxTextChanged(object sender, EventArgs e)
        {
            if (_switchValidation)
            {
                try
                {
                    _currentItem.Cost = Convert.ToDouble(costTextBox.Text);
                    costTextBox.BackColor = Color.White;
                    CheckAcceptButton();
                }
                catch
                {
                    costTextBox.BackColor = Color.Red;
                    acceptButton.Enabled = false;
                }
            }
            else
            {
                costTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_switchValidation)
            {
                try
                {
                    _currentItem.Category = (Category)Enum.Parse(typeof(Category), categoryComboBox.Text);
                    categoryComboBox.BackColor = Color.White;
                    CheckAcceptButton();
                }
                catch
                {
                    categoryComboBox.BackColor = Color.Red;
                    acceptButton.Enabled = false;
                }
            }
            else
            {
                categoryComboBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Валидация NameTextBox на количество символов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            if (_switchValidation)
            {
                try
                {
                    _currentItem.Name = nameTextBox.Text;
                    nameTextBox.BackColor = Color.White;
                    CheckAcceptButton();
                }
                catch
                {
                    nameTextBox.BackColor = Color.Red;
                    acceptButton.Enabled = false;
                }
            }
            else
            {
                nameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Валидация DescriptionTextBox на количество символов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTextBoxTextChanged(object sender, EventArgs e)
        {
            if (_switchValidation)
            {
                try
                {
                    _currentItem.Info = descriptionTextBox.Text;
                    descriptionTextBox.BackColor = Color.White;
                    CheckAcceptButton();
                }
                catch
                {
                    descriptionTextBox.BackColor = Color.Red;
                    acceptButton.Enabled = false;
                }
            }
            else
            {
                descriptionTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Проверка на включение AcceptButton.
        /// </summary>
        private void CheckAcceptButton()
        {
            var cost = costTextBox.BackColor == Color.White;
            var category = categoryComboBox.BackColor == Color.White;
            var name = nameTextBox.BackColor == Color.White;
            var description = descriptionTextBox.BackColor == Color.White;

            if (cost && category && name && description)
            {
                acceptButton.Enabled = true;
            }
        }

        /// <summary>
        /// Обновления itemsListBox.
        /// </summary>
        public void RefreshData()
        {
            if (Items.Count > 0)
            {
                RefreshListBox(Items);
            }

            _displayedItems = new List<Item>(Items);
            findComboBox.SelectedIndex = 0;
        }

        private void RefreshListBox(List<Item> items)
        {
            itemsListBox.Items.Clear();
            foreach (var item in items)
            {
                itemsListBox.Items.Add(item.Name);
            }
        }

        private void FindTextBoxTextChanged(object sender, EventArgs e)
        {
            _displayedItems = new List<Item>(Items);
            if (findTextBox.Text == "")
            {
                comboBox1_SelectedIndexChanged(0, EventArgs.Empty);
                return;
            }

            _displayedItems = DataTools.GetSortedListItems(Items,
                s => s.IndexOf(findTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0);

            RefreshListBox(_displayedItems);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSorting = (Sorting)findComboBox.SelectedIndex;
            switch (selectedSorting)
            {
                case Sorting.ID:
                    {
                        _displayedItems = DataTools.GetSortedListItems(Items, item => item.Id);
                        RefreshListBox(_displayedItems);
                        break;
                    }
                case Sorting.Name:
                    {
                        _displayedItems = DataTools.GetSortedListItems(Items, item => item.Name);
                        RefreshListBox(_displayedItems);
                        break;
                    }
                case Sorting.CostGreater:
                    {
                        _displayedItems = DataTools.GetSortedListItems(Items, item => item.Cost);
                        RefreshListBox(_displayedItems);
                        break;
                    }
                case Sorting.CostLess:
                    {
                        _displayedItems = DataTools.GetSortedListItems(Items, item => item.Cost * -1);
                        RefreshListBox(_displayedItems);
                        break;
                    }
            }

        }


    }
}
