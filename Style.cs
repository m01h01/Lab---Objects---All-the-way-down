using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab___Objects___All_the_way_down.Brands;

namespace Lab___Objects___All_the_way_down
{
    internal class Style
    {
        public enum Styles {American, Casual, Classic, Minimalist, Modern};

        Styles _styles;

        public Style(Styles styles)
        {
            _styles = styles;
        }
        public override string ToString()
        {
            return $"{_styles}";
        }
    }
}
