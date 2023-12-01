using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.model
{
    internal class Product
    {
        public int Id { get; set; }
        private string Name { get; set; }
        private string Image { get; set; }
        private string Description { get; set; }
        private double Prize { get; set; }
        private int Stock { get; set; }
        private Specie ProductSpecie { get; set; }

        public Product(int Id,string Name, string Description, double Prize, int Stock,string Image, Specie ProductSpecie) { 
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Prize = Prize;
            this.Stock = Stock;
            this.Image = Image;
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
