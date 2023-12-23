﻿namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Перечисления состояния заказа.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Новый заказ.
        /// </summary>
        New,

        /// <summary>
        /// Обрабатывается.
        /// </summary>
        Processing,

        /// <summary>
        /// Собирается на складе.
        /// </summary>
        Assembly,

        /// <summary>
        /// Отправлен.
        /// </summary>
        Sent,

        /// <summary>
        /// Доставлен.
        /// </summary>
        Delivered,

        /// <summary>
        /// Возврат.
        /// </summary>
        Returned,

        /// <summary>
        /// Отменен (со стороны магазина).
        /// </summary>
        Abandoned
    }
}
