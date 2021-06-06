using System;
using System.Collections.Generic;
using System.Text;

namespace ItinnovDesign.SoC.Model
{
    public static class ProductListExtensionMethods
    {
        public static void Apply(this IList<Product> products, IDiscountStrategy discountStrategy)
        {
            foreach (Product p in products)
            {
                p.Price.SetDiscountStrategyTo(discountStrategy);
            }
        }
    }
}
