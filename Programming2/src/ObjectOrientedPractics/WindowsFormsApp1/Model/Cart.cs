using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о корзине.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items { get; private set; }

        /// <summary>
        /// Возвращает общую стоимость товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items != null)
                {
                    double sum = 0;
                    for (int i = 0; i < Items.Count; i++)
                    {
                        sum += Items[i].Cost;
                    }
                    return sum;
                }
                return 0.0;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        public object Clone()
        {
            var clone = new Cart
            {
                Items = this.Items
            };
            return clone;
        }
    }
}
