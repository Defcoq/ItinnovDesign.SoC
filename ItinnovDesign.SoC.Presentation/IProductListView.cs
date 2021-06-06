using System;
using System.Collections.Generic;
using System.Text;

namespace ItinnovDesign.SoC.Presentation
{
    public interface IProductListView
    {
        void Display(IList<Service.ProductViewModel> Products);
        Model.CustomerType CustomerType { get; }
        string ErrorMessage { set; }
    }
}
