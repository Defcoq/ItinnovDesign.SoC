using System;
using System.Collections.Generic;
using System.Text;

namespace ItinnovDesign.SoC.Model
{
    public interface IDiscountStrategy
    {
        decimal ApplyExtraDiscountsTo(decimal OriginalSalePrice);
    }
}
