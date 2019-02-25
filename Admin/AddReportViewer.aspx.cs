using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddReportViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!Roles.RoleExists("ReportViewer"))
        {
            Roles.CreateRole("ReportViewer");
        }

        try
        {
            String password = Membership.GeneratePassword(6, 1);

            Membership.CreateUser(txtUserName.Text, password);

            Roles.AddUserToRole(txtUserName.Text, "ReportViewer");

            lblStatus.Text = "Manager: " + txtUserName.Text + " created successfully<br />" +
                               "Generated Password: " + password;
            
        }
        catch (Exception ex)
        {
            lblStatus.Text = ex.Message;
            lblStatus.Font.Size = 12;
            lblStatus.ForeColor = System.Drawing.Color.Red;
        }
    }
}