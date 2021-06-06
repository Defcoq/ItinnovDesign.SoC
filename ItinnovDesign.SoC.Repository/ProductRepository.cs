using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ItinnovDesign.SoC.Repository
{
    public class ProductRepository : Model.IProductRepository
    {
        public IList<Model.Product> FindAll()
        {
            var products = from p in new ITInnovDesign.SoC.Repository.ProductContext().Products
                           select new Model.Product
                           {
                               Id = p.ProductId,
                               Name = p.ProductName,
                               Price = new Model.Price(p.Rrp, p.SellingPrice)
                           };

            return products.ToList();
        }

    }
}
