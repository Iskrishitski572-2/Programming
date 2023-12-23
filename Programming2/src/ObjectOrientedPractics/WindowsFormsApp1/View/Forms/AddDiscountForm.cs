using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Forms
{
    /// <summary>
    /// Форма скидок.
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Событие позволяющие передавать данные в CustomersTab.
        /// </summary>
        public event EventHandler ValidationRequested;

        /// <summary>
        /// Массив имен перечислений.
        /// </summary>
        public object[] Categories = Enum.GetNames(typeof(Category));

        /// <summary>
        /// Конструктор <see cref="AddDiscountForm"/>.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
            categoryComboBox.Items.AddRange(Categories);
        }

        /// <summary>
        /// Событие выбора категории в categoryComboBox.
        /// </summary>
        private void CategoryComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            acceptButton.Enabled = categoryComboBox.SelectedIndex != -1;
        }

        /// <summary>
        /// Событие принятие выбора категории.
        /// </summary>
        private void AcceptButtonClick(object sender, EventArgs e)
        {
            ValidationRequested?.Invoke(this, EventArgs.Empty);
            categoryComboBox.Items.RemoveAt(categoryComboBox.SelectedIndex);
            categoryComboBox.SelectedIndex = -1;
            acceptButton.Enabled = false;
            Close();
        }

        /// <summary>
        /// Событие отмены выбора категории.
        /// </summary>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            categoryComboBox.SelectedIndex = -1;
            Close();
        }

        /// <summary>
        /// Получение скидки с выбранной категории.
        /// </summary>
        /// <returns>new PercentDiscount(category).</returns>
        public PercentDiscount GetDiscount()
        {
            var category = (Category)Enum.Parse(typeof(Category), categoryComboBox.Text);
            return new PercentDiscount(category);
        }

        /// <summary>
        /// Обновление categoryComboBox.
        /// </summary>
        /// <param name="discounts">Список текущих скидок.</param>
        public void UpdateCategoryComboBox(List<IDiscount> discounts)
        {
            var percentDiscountsCategories = discounts.OfType<PercentDiscount>().ToArray();
            object[] sd = new object[percentDiscountsCategories.Length];
            for (int i = 0; i < sd.Length; i++)
            {
                sd[i] = Enum.GetName(typeof(Category), percentDiscountsCategories[i].Category);
            }
            var categoryDifference = Categories.Except(sd).ToArray();
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(categoryDifference);
        }
    }
}
