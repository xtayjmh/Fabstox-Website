using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabstox.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public string Finish { get; set; }
        public double? Thickness { get; set; }
        public bool? FullSlab { get; set; }
        public decimal? Price { get; set; }
        public double? QTY { get; set; }
        public bool? Freight { get; set; }
        public decimal? FreightFee { get; set; }
        public int? Status { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
