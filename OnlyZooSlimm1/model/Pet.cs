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
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public Specie PetSpecie { get; set; }
        public int Stock { get; set; }
        public double Prize { get; set; }
        
        public Pet(int Id, string Name, string Breed, string Description, Specie PetSpecie,int stock, double Prize ) {
            this.Id = Id;
            this.Name = Name;
            this.Breed = Breed;
            this.Description = Description;
            this.PetSpecie = PetSpecie;
            this.Stock = Stock;
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
