using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.model
{
    internal class PetList
    {
        private List<Pet> Pets { get; set;}

        public PetList(List<Pet> Pets) {
            this.Pets = Pets;
            if (this.Pets == null) {
                this.Pets = new();
            }        
        }

        public bool AddProd(Pet p)
        {
            if (!Pets.Contains(p))
            {
                Pets.Add(p);
                return true;
            }
            return false;
        }

        public bool RemoveProd(Pet p)
        {
            return Pets.Remove(p);
        }

        public Pet? GetProductById(int Id)
        {
            foreach (Pet pet in Pets)
            {
                if (pet.Id == Id) { return pet; }
            }
            return null;
        }
    }
}
