using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.model
{
    internal class SpecieList
    {

        private List<Specie> Species;

        public SpecieList(List<Specie> Species) { 
            this.Species = Species;
            if (this.Species == null) {
                this.Species = new();
            }
        }
    }
}
