using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using lab.domain;
using lab.domain.interfaces;
using StructureMap;

namespace lab.userControls
{
    public partial class ProductList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IProductRepository pr = ObjectFactory.GetInstance<IProductRepository>();
            List<IProduct> products = pr.All();
            ProductListRepeater.DataSource = products;
            ProductListRepeater.DataBind();
        }

        protected string GetTurnaroundText(int turnaround)
        {
            if (1 == turnaround) return "1 day";
            else return turnaround.ToString() + " days";
        }
    }
}