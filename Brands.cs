using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Objects___All_the_way_down
{
    internal class Brands
    {
       public enum Brand {Coach, Levis, Tumi, Fossil, Nautica};

        Brand _brand;

        public Brands(Brand brand)
        {
            _brand = brand;
        }
        public override string ToString()
        {
            return $"{_brand}";
        }
    }
}
