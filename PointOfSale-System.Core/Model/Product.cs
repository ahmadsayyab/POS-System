using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_System.Core.Classes
{
    public class Product
    {
        public int Id { get; internal set; }
        public string Name { get; set; }
        
        public double Price { get; set; }

        public double Quantity { get; set; }

        public int IsActive { get; set; }

        
    }
}
