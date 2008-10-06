using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class masters_Master11 : System.Web.UI.MasterPage
{
    protected void CssStyleReference_Init(object sender, EventArgs e)
    {
        CssStyleReference.Href = "~/styles/style11.css";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
