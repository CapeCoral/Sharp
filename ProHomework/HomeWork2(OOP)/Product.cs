using System;
namespace HomeWork2_OOP
{
    public class Product
    {
        public string Name { get; private set; }
        public Money Price { get; private set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// Применить скидку на сумму
        /// </summary>
        /// <param name="discount">сумма скидки</param>
        public void Discount(Money discount)
        {
            Price.Subrtract(discount);
        }

        /// <summary>
        /// Получить описание товара
        /// </summary>
        public override string ToString()
        {
            return $"{Name} {Price.ToString()}";
        }
    }
}

