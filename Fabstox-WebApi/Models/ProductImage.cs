using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabstox.Models
{
    public class ProductImage
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductImageName { get; set; }
        public virtual Product Product { get; set; }
    }
}
