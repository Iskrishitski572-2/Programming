using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Панель скидок.
    /// </summary>
    public partial class DiscountsTab : UserControl
    {
        /// <summary>
        /// Процентная скидка на электронику.
        /// </summary>
        private PercentDiscount _discount = new PercentDiscount(Category.Electronics);

        /// <summary>
        /// Список товаров для расчета скидки.
        /// </summary>
        public List<Item> Items = new List<Item>();

        /// <summary>
        /// Создает экземпляр DiscountsTab.
        /// </summary>
        public DiscountsTab()
        {
            InitializeComponent();
            UpdateLabel();
        }

        /// <summary>
        /// Обновляет информацию на метке.
        /// </summary>
        private void UpdateLabel()
        {
            var totalCost = 0.0;

            foreach (var item in Items)
            {
                totalCost += item.Cost;
            }

            infoLabel.Text = $@"Информация: {_discount.Info}";
            amountLabel.Text = totalCost.ToString();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Рассчитать".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButtonClick(object sender, System.EventArgs e)
        {
            MessageBox.Show(_discount.Calculate(Items).ToString());
            UpdateLabel();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Применить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyButtonClick(object sender, System.EventArgs e)
        {
            MessageBox.Show(_discount.Apply(Items).ToString());
            UpdateLabel();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Обновить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButtonClick(object sender, System.EventArgs e)
        {
            _discount.Update(Items);
            UpdateLabel();
        }
    }
}
