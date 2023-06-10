using Programming.Model.Enums;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса EnumerationsControl.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Массив перечислений.
        /// </summary>
        object[] _enums = new object[]
        {
            typeof(Colors),
            typeof(Genre),
            typeof(StudentEducation),
            typeof(SmartphoneManufacturers),
            typeof(Season),
            typeof(Weekday)
        };

        /// <summary>
        /// Создает экземпляр класса EnumerationsControl.
        /// </summary>
        public EnumerationsControl()
        {
            InitializeComponent();

            // Заполнение EnumsListBox всеми перечислениями.
            EnumsListBox.Items.AddRange(_enums);
            EnumsListBox.DisplayMember = nameof(FileInfo.Name);
        }

        /// <summary>
        /// Изменения элементов ValuesListBox, при выборе другого элемента в EnumsListBox.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem == null)
            {
                return;
            }

            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();

            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }

        /// <summary>
        /// Запись индекса ValuesListBox в TextBox.
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }
    }
}
