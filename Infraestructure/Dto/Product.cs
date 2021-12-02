using System;

namespace Infraestructure.Dto
{
    public class Product
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Product(int code, string description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        public string ToString()
        {
            return $"{this.Code} | {this.Description} | {Math.Round(this.Price, 2)} ";
        }

    }
}
