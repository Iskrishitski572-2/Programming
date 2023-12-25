using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    public static class DataTools
    {
        /// <summary>
        /// Метод для получения отсортированного списка элементов на основе заданного условия.
        /// </summary>
        /// <param name="items">Список элементов.</param>
        /// <param name="test">Условие для фильтрации элементов.</param>
        /// <returns>Отсортированный список элементов.</returns>
        public static List<Item> GetSortedListItems(List<Item> items, Func<string, bool> test)
        {
            List<Item> newItems = new List<Item>();

            foreach (Item item in items)
            {
                if (test(item.Name))
                {
                    newItems.Add(item);
                }
            }

            return newItems;
        }

        /// <summary>
        /// Метод для получения отсортированного списка элементов на основе заданного критерия сравнения.
        /// </summary>
        /// <param name="items">Список элементов.</param>
        /// <param name="orderBy">Критерий сравнения для сортировки элементов.</param>
        /// <returns>Отсортированный список элементов.</returns>
        public static List<Item> GetSortedListItems(List<Item> items, Func<Item, IComparable> orderBy)
        {
            return items.OrderBy(orderBy).ToList();
        }
    }
}
