using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._5
{
    internal struct Notebook
    {
        private string model;
        private string brand;
        private decimal price;

        public Notebook(string model, string brand, decimal price)
        {
            this.model = model;
            this.brand = brand;
            this.price = price;
        }

        public void ShowStruct()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Price: {price}");
        }
    }
}
