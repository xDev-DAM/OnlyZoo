using OnlyZoo.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZooXDEV.model
{
    internal class Merch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private string Description { get; set; }
        private int Stock { get; set; }
        private double Prize { get; set; }
        public string Image { get; set; }

        public Merch(int Id,string Name,string Descripcion,int Stock,double Prize,string Image)
        {
            this.Id = Id;
            this.Name = Name;  
            this.Description = Descripcion;
            this.Stock = Stock;
            this.Prize = Prize;
            this.Image = Image;
        }
        public override bool Equals(object? obj)
        {
            return obj is Merch merch &&
                   Id == merch.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
