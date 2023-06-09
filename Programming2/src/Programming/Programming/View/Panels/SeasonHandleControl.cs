using Programming.Model;
using Programming.Model.Classes;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса SeasonHandleControl.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса SeasonHandleControl.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();

            // Заполнение SeasonComboBox.
            SeasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));
        }

        /// <summary>
        /// Обработчик, который выводит сообщение или изменяет цвет панели в зависимости от
        /// выбранного времени года в SeasonComboBox.
        /// </summary>
        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Spring":
                    BackColor = AppColors.SpringColor;
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    BackColor = AppColors.AutumnColor;
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
            }
        }
    }
}
