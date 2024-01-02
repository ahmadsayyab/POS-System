using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_System.Core.Classes
{
    public class SaleDetail
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
    }
}
