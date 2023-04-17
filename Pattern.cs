using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab___Objects___All_the_way_down.Brands;

namespace Lab___Objects___All_the_way_down
{
    internal class Pattern
    {
        public enum Patterns {Camouflage, Cartoon, Chevron, Geometric, Floral, Solid, Striped, Plaid };

        Patterns _pattern;

        public Pattern (Patterns pattern)
        {
            _pattern = pattern;
        }
        public override string ToString()
        {
            return $"{_pattern}";
        }
    }
}
