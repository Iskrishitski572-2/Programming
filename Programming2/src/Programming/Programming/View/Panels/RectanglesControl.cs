using Programming.Model;
using Programming.Model.Geometry;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса RectanglesControl.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[5];

        /// <summary>
        /// Текущий выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает экземпляр класса RectanglesControl.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            FillRectangles(_rectangles);

            // Заполнение RectanglesListBox.
            var rectangles = new List<string>() {"Rectangle 1","Rectangle 2","Rectangle 3",
                "Rectangle 4","Rectangle 5"};
            foreach (var rectangle in rectangles)
            {
                RectanglesListBox.Items.Add(rectangle);
            }

            RectanglesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Заполнение массива прямоугольников случайными прямоугольниками.
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников.</param>
        private void FillRectangles(Rectangle[] rectangles)
        {
            for (int i = 0; i < 5; i++)
            {
                rectangles[i] = RectangleFactory.Randomize();
            }
        }

        /// <summary>
        /// Выбор элемента в RectanglesListBox с последующим обновлением информации в TextBox.
        /// </summary>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthTextBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Length.ToString();
            WidthTextBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Width.ToString();
            ColorTextBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Color;
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IDTextBox.Text = _currentRectangle.ID.ToString();
        }

        /// <summary>
        /// Изменение данных в LengthTextBox.
        /// </summary>
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LengthTextBox.BackColor = AppColors.NormalColor;
                _currentRectangle.Length = Convert.ToDouble(LengthTextBox.Text);
            }
            catch
            {
                LengthTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменение данных в WidthTextBox.
        /// </summary>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = AppColors.NormalColor;
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменение данных в ColorTextBox.
        /// </summary>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        /// <summary>
        /// Запрет на изменение XTextBox.
        /// </summary>
        private void XTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Запрет на изменение YTextBox.
        /// </summary>
        private void YTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Запрет на изменение IDTextBox.
        /// </summary>
        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработчик, который выбирает элемент с максимальной шириной.
        /// </summary>
        private void FindButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = index;
        }

        /// <summary>
        /// Возвращает индекс прямоугольника с самой большой шириной. 
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников.</param>
        /// <returns>Индекс.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int index = 0;
            double maxWidth = 0;

            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    index = i;
                }
            }

            return index;
        }
    }
}
