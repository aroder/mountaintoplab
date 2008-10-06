using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class masters_Master1 : System.Web.UI.MasterPage
{

    protected void CssStyleReference_Init(object sender, EventArgs e)
    {
        CssStyleReference.Href = "~/styles/style1.css";
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
