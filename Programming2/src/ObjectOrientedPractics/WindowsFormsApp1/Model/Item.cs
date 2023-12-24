﻿using System;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Названия товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описания товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает Id товара.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает названия товара. Должно быть не более 200
        /// символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, Name);
                _name = value;
            }
        }

        /// <summary>
        ///  Возвращает и задает описания товара. Должно быть не более 1000
        ///  символов.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, Info);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цену товара. Должно быть не более 100000.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Названия товара. Должно быть не более 200 символов.</param>
        /// <param name="category">Категория товара.</param>
        /// <param name="info">Описания товара. Должно быть не более 1000 символов.</param>
        /// <param name="cost">Цена товара. Должно быть не более 100000.</param>
        public Item(string name, Category category, string info, double cost)
        {

            Id = IdGenerator.GetNewIdItem();
            Name = name;
            Category = category;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="id"></param>
        public Item(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item() { }

        public object Clone()
        {
            var clone = new Item(this.Id)
            {
                Name = this.Name,
                Category = this.Category,
                Info = this.Info,
                Cost = this.Cost
            };
            return clone;
        }

        public bool Equals(Item other)
        {
            if (other == null) return false;

            return this.Name == other.Name;
        }

        public int CompareTo(Item other)
        {
            if (other == null) return 1;

            return this.Cost.CompareTo(other.Cost);
        }
    }
}