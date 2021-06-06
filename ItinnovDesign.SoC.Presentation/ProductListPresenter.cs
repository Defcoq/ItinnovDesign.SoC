using System;
using System.Collections.Generic;
using System.Text;

namespace ItinnovDesign.SoC.Presentation
{
    public class ProductListPresenter
    {
        private IProductListView _productListView;
        private Service.ProductService _productService;

        public ProductListPresenter(IProductListView ProductListView, Service.ProductService ProductService)
        {
            _productService = ProductService;
            _productListView = ProductListView;
        }

        public void Display()
        {
            Service.ProductListRequest productListRequest = new Service.ProductListRequest();
            productListRequest.CustomerType = _productListView.CustomerType;

            Service.ProductListResponse productResponse = _productService.GetAllProductsFor(productListRequest);

            if (productResponse.Success)
            {
                _productListView.Display(productResponse.Products);
            }
            else
            {
                _productListView.ErrorMessage = productResponse.Message;
            }

        }
    }
}
