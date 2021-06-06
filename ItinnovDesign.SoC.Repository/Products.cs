using System;
using System.Collections.Generic;

namespace ITInnovDesign.SoC.Repository
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Rrp { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
