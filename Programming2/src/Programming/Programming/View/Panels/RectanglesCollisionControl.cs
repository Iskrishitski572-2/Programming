using Programming.Model.Geometry;
using Programming.Model;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса RectanglesCollisionControl.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Rectangle> _rectanglesList = new List<Rectangle>();

        /// <summary>
        /// Текущий выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangleList;

        /// <summary>
        /// Список панелей прямоугольника.
        /// </summary>
        private List<Panel> _rectanglePanel = new List<Panel>();

        /// <summary>
        /// Создает экземпляр класса RectanglesCollisionControl.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Удаление выбранного прямоугольника.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _rectanglesList.RemoveAt(RectanglesParametersListBox.SelectedIndex);
                _rectanglePanel.RemoveAt(RectanglesParametersListBox.SelectedIndex);
                RectanglesPanel.Controls.RemoveAt(RectanglesParametersListBox.SelectedIndex);
                RectanglesParametersListBox.Items.RemoveAt(RectanglesParametersListBox.SelectedIndex);
                FindCollision();
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Добавление нового прямоугольника.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize();
            var panel = new Panel();

            var info = TakeInfoFromRectangle(rectangle);

            panel.Height = Convert.ToInt32(rectangle.Length);
            panel.Width = Convert.ToInt32(rectangle.Width);
            var x = Convert.ToInt32(rectangle.Center.X);
            var y = Convert.ToInt32(rectangle.Center.Y);
            panel.Location = new Point(x, y);
            panel.BackColor = AppColors.CollisionFalse;

            // Добавление в списки и на экран приложения.
            _rectanglesList.Add(rectangle);
            RectanglesParametersListBox.Items.Add(info);
            _rectanglePanel.Add(panel);
            RectanglesPanel.Controls.Add(panel);
            FindCollision();
        }

        /// <summary>
        /// Возвращает строку с данными о прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Строка с данными о прямоугольнике.</returns>
        private static string TakeInfoFromRectangle(Rectangle rectangle)
        {
            var info = $"{rectangle.ID}. " +
                       $"(X={rectangle.Center.X}; " +
                       $"Y={rectangle.Center.Y};" +
                       $" W={rectangle.Width}; " +
                       $"L={rectangle.Length})";

            return info;
        }

        /// <summary>
        /// Обновление данных в TextBox.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(ref Rectangle rectangle)
        {
            rectangle = _rectanglesList[RectanglesParametersListBox.SelectedIndex];

            IdRectangleTextBox.Text = rectangle.ID.ToString();
            XRectangleTextBox.Text = rectangle.Center.X.ToString();
            YRectangleTextBox.Text = rectangle.Center.Y.ToString();
            WidthRectangleTextBox.Text = rectangle.Width.ToString();
            HeightRectangleTextBox.Text = rectangle.Length.ToString();
        }

        /// <summary>
        /// Очистка данных в TextBox.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IdRectangleTextBox.Text = string.Empty;
            XRectangleTextBox.Text = string.Empty;
            YRectangleTextBox.Text = string.Empty;
            WidthRectangleTextBox.Text = string.Empty;
            HeightRectangleTextBox.Text = string.Empty;

            XRectangleTextBox.BackColor = AppColors.NormalColor;
            YRectangleTextBox.BackColor = AppColors.NormalColor;
            WidthRectangleTextBox.BackColor = AppColors.NormalColor;
            HeightRectangleTextBox.BackColor = AppColors.NormalColor;
        }

        /// <summary>
        /// Выбор элемента в RectanglesListBox с последующим обновлением информации в TextBox.
        /// </summary>
        private void RectanglesParametersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateRectangleInfo(ref _currentRectangleList);
            }
            catch
            {
                ClearRectangleInfo();
            }
        }

        /// <summary>
        /// Запрет на изменения IDTextBox.
        /// </summary>
        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Изменения данных в XTextBox.
        /// </summary>
        private void XRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                XRectangleTextBox.BackColor = AppColors.NormalColor;

                var x = Convert.ToDouble(XRectangleTextBox.Text);
                var y = _currentRectangleList.Center.Y;
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Center = coordinatePoint2D;
                _rectanglePanel[RectanglesParametersListBox.SelectedIndex].Location = coordinatePoint;
                RectanglesParametersListBox.Items[RectanglesParametersListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                XRectangleTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменения данных в YTextBox.
        /// </summary>
        private void YRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YRectangleTextBox.BackColor = AppColors.NormalColor;

                var y = Convert.ToDouble(YRectangleTextBox.Text);
                var x = _currentRectangleList.Center.X;
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Center = coordinatePoint2D;
                _rectanglePanel[RectanglesParametersListBox.SelectedIndex].Location = coordinatePoint;
                RectanglesParametersListBox.Items[RectanglesParametersListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                YRectangleTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменения данных в WidthRectangleTextBox.
        /// </summary>
        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthRectangleTextBox.BackColor = AppColors.NormalColor;
                var widthDouble = Convert.ToDouble(WidthRectangleTextBox.Text);
                var widthInt = Convert.ToInt32(WidthRectangleTextBox.Text);
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Width = widthDouble;
                _rectanglePanel[RectanglesParametersListBox.SelectedIndex].Width = widthInt;
                RectanglesParametersListBox.Items[RectanglesParametersListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                WidthRectangleTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменение данных в HeigthRectangleTextBox.
        /// </summary>
        private void HeightRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightRectangleTextBox.BackColor = AppColors.NormalColor;
                var heightDouble = Convert.ToDouble(HeightRectangleTextBox.Text);
                var heightInt = Convert.ToInt32(HeightRectangleTextBox.Text);
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Length = heightDouble;
                _rectanglePanel[RectanglesParametersListBox.SelectedIndex].Height = heightInt;
                RectanglesParametersListBox.Items[RectanglesParametersListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                HeightRectangleTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Проверка на пересечение прямоугольников. В случаи пересечения, прямоугольники меняют свой цвет.
        /// </summary>
        private void FindCollision()
        {
            foreach (Panel rectangle in RectanglesPanel.Controls)
            {
                rectangle.BackColor = AppColors.CollisionFalse;
            }

            for (int i = 0; i < _rectanglesList.Count; i++)
            {
                for (int j = 0; j < _rectanglesList.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]) && i != j)
                    {
                        _rectanglePanel[i].BackColor = AppColors.CollisionTrue;
                        _rectanglePanel[j].BackColor = AppColors.CollisionTrue;
                    }
                }
            }
        }

        private void IdRectangleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
