namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string name)
        {
            if (value <= 0)
            {
                throw new System.ArgumentException($"{name} должно быть больше нуля");
            }
        }

        public static void AssertOnPositiveValue(double value, string name)
        {
            if (value <= 0)
            {
                throw new System.ArgumentException($"{name} должно быть больше нуля");
            }
        }

        public static void AssertValueInRange(int value, string name, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"{name} должно быть от {min} до {max}");
            }
        }
        
        public static void AssertValueInRange(double value, string name, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"{name} должно быть от {min} до {max}");
            }
        }
    }
}