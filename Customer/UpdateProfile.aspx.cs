using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_UpdateProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool loggedIn = HttpContext.Current.User.Identity.IsAuthenticated;

        //If Customer not logged in, redirect to login page
        if (!loggedIn)
        {
            Response.Redirect("~/Account/Login.aspx");
        }
    }

    protected void btnUpdateProfiel_Click(object sender, EventArgs e)
    {
        ProfileUserControl.SaveProfile();
    }
}