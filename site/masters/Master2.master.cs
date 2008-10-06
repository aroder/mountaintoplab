using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class masters_Master2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CssStyleReference_Init(object sender, EventArgs e)
    {
        CssStyleReference.Href = "~/styles/style2.css";
    }
}
