using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_System.Core.Classes
{
    public class Sale
    {
        public int QuantitySold { get; set; }

        public double TotalAmount { get; set; }

        public double DiscountPerItem { get; set; }
    }
}
