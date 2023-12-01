using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.model
{
    internal class Pet
    {
        public int Id { get; set; }
        private string Name { get; set; }
        private string Breed { get; set; }
        private string Description { get; set; }
        private Specie PetSpecie { get; set; }
        private int Stock { get; set; }
        private string Image { get; set; }
        private double Prize { get; set; }
        
        public Pet(int Id, string Name, string Breed, string Description, Specie PetSpecie,int stock,string Image, double Prize ) {
            this.Id = Id;
            this.Name = Name;
            this.Breed = Breed;
            this.Description = Description;
            this.PetSpecie = PetSpecie;
            this.Stock = Stock;
            this.Image = Image;
            this.Prize = Prize;
        }

        public override bool Equals(object? obj)
        {
            return obj is Pet pet &&
                   Id == pet.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
