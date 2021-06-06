using System;
using System.Collections.Generic;
using System.Text;

namespace ItinnovDesign.SoC.Model
{
    public interface IProductRepository
    {
        IList<Product> FindAll();
    }
}
