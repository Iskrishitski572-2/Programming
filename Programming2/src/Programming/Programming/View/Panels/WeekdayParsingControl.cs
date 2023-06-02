namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса WeekdayParsingControl.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса WeekdayParsingControl.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик, который считывает текст из WeekdayTextBox и проверяет есть ли такой день недели.
        /// </summary>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues(typeof(Weekday));
            var flag = false;

            foreach (var enymValue in enumValues)
            {
                var stringValue = enymValue.ToString();

                if (WeekdayTextBox.Text == stringValue)
                {
                    flag = !flag;
                    ResultParsing.Text = $"Это день недели ({stringValue} = " +
                                         $"{(int)Enum.Parse(typeof(Weekday), stringValue)})";
                }
            }

            if (!flag)
            {
                ResultParsing.Text = "Нет такого дня недели";
            }
        }
    }
}
