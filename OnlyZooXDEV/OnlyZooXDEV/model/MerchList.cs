using OnlyZoo.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZooXDEV.model
{
    internal class MerchList
    {
        public List<Merch> Merchs { get; set; }

        public MerchList()
        {
            this.Merchs = new();
        }

        public bool AddMerch(Merch m)
        {
            if (!Merchs.Contains(m))
            {
                Merchs.Add(m);
                return true;
            }
            return false;
        }

        public bool RemoveProd(Merch m)
        {
            return Merchs.Remove(m);
        }

        public Merch? GetProductById(int Id)
        {
            foreach (Merch merch in Merchs)
            {
                if (merch.Id == Id) { return merch; }
            }
            return null;
        }
    }
}
