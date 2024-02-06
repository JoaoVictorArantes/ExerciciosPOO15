using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO15.Entities
{
    internal class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual String PriceTag()
        {
            return $"{Name}, ${Price.ToString("F2")}";
        }
    }
}
