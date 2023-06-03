using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Реализует статистическое хранение цветов.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет фона TextBox.
        /// </summary>
        public static Color NormalColor = Color.White;

        /// <summary>
        /// Цвет ошибки.
        /// </summary>
        public static Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Цвет квадрата, который не пересекает другой квадрат.
        /// </summary>
        public static Color CollisionFalse = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет квадрата, который пересекает другой квадрат.
        /// </summary>
        public static Color CollisionTrue = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет фона ComboBox для весны.
        /// </summary>
        public static Color SpringColor = Color.Green;

        /// <summary>
        /// Цвет фона ComboBox для осени.
        /// </summary>
        public static Color AutumnColor = Color.Orange;
    }
}
