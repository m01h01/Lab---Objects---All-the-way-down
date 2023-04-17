using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab___Objects___All_the_way_down.Brands;

namespace Lab___Objects___All_the_way_down
{
    internal class CompartmentType
    {
        public enum Compartment {BusinessCard, CheckBook, Coin, CreditCard, IDcard};

        Compartment _compartment;

        public CompartmentType(Compartment compartment)
        {
            _compartment = compartment;
        }
        public override string ToString()
        {
            return $"{_compartment}";
        }
    }
}
