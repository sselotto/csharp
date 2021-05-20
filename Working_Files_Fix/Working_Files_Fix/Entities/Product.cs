using System;
using System.IO;

namespace Working_Files_Fix
{
    class Product
    {   //Declaração das Propriedades
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        //Construtor
        public Product(String name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }
    }
}
