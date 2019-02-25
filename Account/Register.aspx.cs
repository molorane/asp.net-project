using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            wizCreateUser.ActiveStepIndex = 0;
        }
    }

    protected void wizCreateUser_CreatedUser(object sender, EventArgs e)
    {
        string sUserName = wizCreateUser.UserName.ToString();
        if (!Roles.RoleExists("Customer"))
        {
            Roles.CreateRole("Customer");
        }

        Roles.AddUserToRole(sUserName, "Customer");
    }

    protected void wizCreateUser_ContinueButtonClick(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }

    protected void wizCreateUser_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        Controls_ProfileUserControl ucProfile = (Controls_ProfileUserControl)wizCreateUser.FindControl("ProfileUserControl1");

        ucProfile.SaveProfile();
    }
}