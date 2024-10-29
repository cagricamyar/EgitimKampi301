using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string  ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }

    }
}
