using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.model
{
    internal class Specie
    {
        private int Id { get; set; }
        private string Name { get; set; }

        public Specie(int id, string name) {
            this.Id = id;
            this.Name = name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Specie specie &&
                   Id == specie.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
