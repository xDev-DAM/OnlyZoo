using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZooXDEV.model
{
    internal class Seleccionable
    {
        protected Seleccionable(string img, string name)
        {
            Img = img;
            Name = name;
        }

        protected string Img { get; set; }
        protected string Name { get; set; }

    }
}
