﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.model
{
    internal class ProductList
    {
        private List<Product> Products { get; set; }
        public ProductList(List<Product> Products) { 
            this.Products = Products;
            if (this.Products == null) {
                this.Products = new();
            }
        }

        public bool AddProd(Product p) {
            if (!Products.Contains(p)) { 
                Products.Add(p);
                return true;
            }
            return false;
        }

        public bool RemoveProd(Product p) {
            return Products.Remove(p);
        }

        public Product? GetProductById(int Id) {
            foreach (Product prod in Products){
                if (prod.Id == Id) { return prod; }
            }
            return null;
        }
    }
}
