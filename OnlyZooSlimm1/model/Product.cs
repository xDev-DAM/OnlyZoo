using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.model
{
    internal class Product
    {
        public int Id;
        private string Name;
        private string Description;
        private double Prize;
        private int Stock;
        private Specie ProductSpecie;

        public Product(int Id,string Name, string Description, double Prize, int Stock, Specie ProductSpecie) { 
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Prize = Prize;
            this.Stock = Stock;
            this.ProductSpecie = ProductSpecie;
        }

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   Id == product.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
