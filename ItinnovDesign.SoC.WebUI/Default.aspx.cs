using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ItinnovDesign.SoC.WebUI
{
    public partial class _Default : Page, Presentation.IProductListView
    {
        private Presentation.ProductListPresenter _presenter;
        public Service.ProductService productService { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new Presentation.ProductListPresenter(this, productService);
            this.ddlCustomerType.SelectedIndexChanged += delegate { _presenter.Display(); };
        }


        protected void Page_Load(object sender, EventArgs e)
        {
           // var prova = productService.
            if (Page.IsPostBack != true)
                _presenter.Display();
        }

        public void Display(IList<Service.ProductViewModel> Products)
        {
            rptProducts.DataSource = Products;
            rptProducts.DataBind();
        }

        public Model.CustomerType CustomerType
        {
            get { return (Model.CustomerType)Enum.ToObject(typeof(Model.CustomerType), int.Parse(this.ddlCustomerType.SelectedValue)); }
        }


        public string ErrorMessage
        {
            set { lblErrorMessage.Text = String.Format("<p><strong>Error</strong><br/>{0}<p/>", value); }
        }
    }
}