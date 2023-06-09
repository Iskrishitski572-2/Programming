namespace Programming.Model.Classes
{
    /// <summary>
    /// Реализует статическую проверку на ошибки.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверка на позитивные числа.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="name">Имя свойства или объекта, которое проходит проверку.</param>
        public static void AssertOnPositiveValue(int value, string name)
        {
            if (value <= 0)
            {
                throw new System.ArgumentException($"{name} должно быть больше или равно нулю");
            }
        }

        /// <summary>
        /// Проверка на позитивные числа.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="name">Имя свойства или объекта, которое проходит проверку.</param>
        public static void AssertOnPositiveValue(double value, string name)
        {
            if (value <= 0)
            {
                throw new System.ArgumentException($"{name} должно быть больше или равно нулю");
            }
        }

        /// <summary>
        /// Проверка на диапазон числа от min до max.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="name">Имя свойства или объекта, которое проходит проверку.</param>
        /// <param name="min">Минимальное значение числа.</param>
        /// <param name="max">Максимальное значение числа.</param>
        public static void AssertValueInRange(int value, string name, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"{name} должно быть от {min} до {max}");
            }
        }

        /// <summary>
        /// Проверка на диапазон числа от min до max.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="name">Имя свойства или объекта, которое проходит проверку.</param>
        /// <param name="min">Минимальное значение числа.</param>
        /// <param name="max">Максимальное значение числа.</param>
        public static void AssertValueInRange(double value, string name, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"{name} должно быть от {min} до {max}");
            }
        }
    }
}
