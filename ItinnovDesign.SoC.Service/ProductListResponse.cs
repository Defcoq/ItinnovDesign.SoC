using System;
using System.Collections.Generic;
using System.Text;

namespace ItinnovDesign.SoC.Service
{
    public class ProductListResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public IList<ProductViewModel> Products { get; set; }
    }
}
