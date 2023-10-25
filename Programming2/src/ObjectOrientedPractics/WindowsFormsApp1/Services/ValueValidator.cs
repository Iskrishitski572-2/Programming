namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует статистическую валидацию данных.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверка длины строки.
        /// </summary>
        /// <param name="value">Проверяемое строка.</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое проходит проверку.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new System.ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }

        /// <summary>
        /// Проверка на диапазон числа от min до max.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Минимальное значение числа.</param>
        /// <param name="max">Максимальное значение числа.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое проходит проверку.</param>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"{propertyName} должно быть от {min} до {max}");
            }
        }

        /// <summary>
        /// Проверка на диапазон числа от min до max.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Минимальное значение числа.</param>
        /// <param name="max">Максимальное значение числа.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое проходит проверку.</param>
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"{propertyName} должно быть от {min} до {max}");
            }
        }
    }
}
