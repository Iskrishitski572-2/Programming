namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует статистическое создания Id для объектов.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Id <see cref="Model.Item"/>.
        /// </summary>
        private static int _idItem = 0;

        /// <summary>
        /// Id <see cref="Model.Customer"/>.
        /// </summary>
        private static int _idCustomer = 0;

        /// <summary>
        /// Id <see cref="Model.Order"/>.
        /// </summary>
        private static int _idOrder = 0;

        /// <summary>
        /// Создает новый Id и возвращает его для <see cref="Model.Item"/>.
        /// </summary>
        /// <returns>Id.</returns>
        public static int GetNewIdItem()
        {
            _idItem++;
            return _idItem;
        }

        /// <summary>
        /// Создает новый Id и возвращает его для <see cref="Model.Customer"/>.
        /// </summary>
        /// <returns>Id.</returns>
        public static int GetNewIdCustomer()
        {
            _idCustomer++;
            return _idCustomer;
        }

        /// <summary>
        /// Создает новый Id и возвращает его для <see cref="Model.Order"/>.
        /// </summary>
        /// <returns>Id.</returns>
        public static int GetNewIdOrder()
        {
            _idOrder++;
            return _idOrder;
        }
    }
}
