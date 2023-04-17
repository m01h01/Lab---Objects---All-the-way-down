using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Objects___All_the_way_down
{
    internal class WalletCreated
    {
        double _originalCost;
        double _sellingPrice;
        Brands _brand;
        Material _material;
        Style _style;
        Pattern _pattern;
        CompartmentType _compartmentType;

        public WalletCreated(double originalCost, double price, Brands brand, Material material, Style style, Pattern pattern, CompartmentType compartmentType)
        {
            _originalCost = originalCost;
            _sellingPrice = price;
            _brand = brand;
            _material = material;
            _style = style;
            _pattern = pattern;
            _compartmentType = compartmentType;
        }

        public double OriginalCost { get => _originalCost; set => _originalCost = value; }
        public double Price { get => _sellingPrice; set => _sellingPrice = value; }
        internal Brands Brands { get => _brand; set => _brand = value; }
        internal Material Material { get => _material; set => _material = value; }
        internal Style Style { get => _style; set => _style = value; }
        internal Pattern Pattern { get => _pattern; set => _pattern = value; }
        internal CompartmentType CompartmentType { get => _compartmentType; set => _compartmentType = value; }

        public override string ToString()
        {
               return $"Original Cost:{_originalCost.ToString("c")} - Selling Price:{_sellingPrice.ToString("c")}" +
               $" - Brand:{_brand} - Material:{_material}" +
               $" - Style:{_style} - Pattern:{_pattern} \n" +
               $"Compartment Type:{_compartmentType}";  
            
        }
    }
}
