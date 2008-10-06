using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default_MasterSwitch : Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        SwitchMaster();
    }

    private void SwitchMaster()
    {
        if (IsPostBack)
        {
            var eventTarget = Request.Form["__EVENTTARGET"];
            if (string.IsNullOrEmpty(eventTarget)) return;
            var switchControlName = Session["MasterSwitch"] as string;
            if (string.IsNullOrEmpty(switchControlName)) return;
            if (string.Compare(eventTarget, switchControlName, true) != 0) return;
            SetMaster(Request.Form[eventTarget]);
        }
    }

    private void SetMaster(string masterNumber)
    {
        if (string.IsNullOrEmpty(masterNumber)) return;
        if (string.Compare(this.MasterPageFile, masterNumber, true) != 0) this.MasterPageFile = string.Format("masters/Master{0}.master", masterNumber);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["MasterSwitch"] = MasterSwitch.UniqueID;

            //preselect the drop down
            foreach (ListItem i in MasterSwitch.Items)
            {
                if (Master.GetType().Name.Contains(i.Value))
                {
                    MasterSwitch.SelectedValue = i.Value;
                }
            }
        }
    }
}
