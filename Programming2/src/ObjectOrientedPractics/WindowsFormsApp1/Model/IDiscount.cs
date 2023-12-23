using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс для представления скидок, применяемых к списку товаров
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Получает информацию о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Рассчитывает общую сумму скидки на основе списка товаров.
        /// </summary>
        /// <param name="items">Список товаров для расчета скидки.</param>
        /// <returns>Рассчитанная сумма скидки.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к общей стоимости списка товаров.
        /// </summary>
        /// <param name="items">Список товаров, к которому применяется скидка.</param>
        /// <returns>Общая стоимость со скидкой.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет скидку на основе предоставленного списка товаров.
        /// Этот метод может использоваться для динамической настройки скидки.
        /// </summary>
        /// <param name="items">Список товаров для обновления скидки.</param>
        void Update(List<Item> items);
    }
}
