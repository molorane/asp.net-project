using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataCapturer_ViewGantries : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnAddGantry_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/DataCapturer/MaintainGantry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        var Editbtn = (Control)sender;
        GridViewRow row = (GridViewRow)Editbtn.NamingContainer;
        string GantryID = row.Cells[0].Text; // GantryID of a record

        Response.Redirect("~/DataCapturer/MaintainGantry.aspx?GantryID=" + GantryID);
    }
}