using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class _Default : System.Web.UI.Page
{

    DataClass dc = new DataClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadDropDownList();
    }

    protected void LoadDropDownList()
    {
        DataTable tbl = dc.GetServices();
        DropDownList1.DataSource = tbl;
        DropDownList1.DataTextField = "GrantTypeName";
        DropDownList1.DataValueField = "GrantTypeKey";
        DropDownList1.DataBind();
    }
}
