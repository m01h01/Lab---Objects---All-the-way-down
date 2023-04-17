using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab___Objects___All_the_way_down.Brands;

namespace Lab___Objects___All_the_way_down
{
    internal class Material
    {
        public enum Materials {Canvas, Fabric, Leather,Rubber, Suede, Wool };

        Materials _material;

        public Material(Materials materials)
        {
            _material = materials;
        }
        public override string ToString()
        {
            return $"{_material}";
        }
    }
}
