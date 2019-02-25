using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageUsers : System.Web.UI.Page
{
    private string sUserName = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadAllUsers();
            sUserName = ddlAllUsers.Text.ToString();
            LoadUserInformation();
        }

        lblChangeUserStatus.Text = "";
        sUserName = ddlAllUsers.Text.ToString();
    }

    protected void LoadAllUsers()
    {
        //lstUsers.DataSource = Roles.GetUsersInRole("Customer");
        ddlAllUsers.DataSource = Membership.GetAllUsers();
        ddlAllUsers.DataBind();
    }

    protected void LoadUserInformation()
    {
        MembershipUser user = Membership.GetUser(sUserName);
        chkApproved.Checked = user.IsApproved;
        chkLockedOut.Checked = user.IsLockedOut;
        if (user.IsLockedOut)
            chkLockedOut.Enabled = true;
        //LoadRolesForUser();

        if(Roles.IsUserInRole(sUserName, "ReportViewer") 
            || Roles.IsUserInRole(sUserName, "DataCapturer"))
        {
            btnChangeRole.Visible = true;

            if (Roles.IsUserInRole(sUserName, "ReportViewer"))
            {
                lblStatus.Text = "This user is a REPORTVIEWER, click the button below to change user to DATACAPTURER";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Font.Size = 12;
            }

            if (Roles.IsUserInRole(sUserName, "DataCapturer"))
            {
                lblStatus.Text = "This user is a DATACAPTURER, click the button below to change user to REPORTVIEWER";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Font.Size = 12;
            }
        }
        else
        {
            lblStatus.Text = "";
            btnChangeRole.Visible = false;
        }

       
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (sUserName != "")
        {

            if (!Roles.IsUserInRole(sUserName, "Admin"))
            {
                ProfileCommon pcProfile = Profile.GetProfile(sUserName);

                CCustomer customer =
                        CCustomer.GetCustomer(Convert.ToInt32(pcProfile.CustomerID));

                if(customer != null) 
                {

                    string sVirtualFolder = customer.Cus_ProfilePic;
                    string sPhysicalPath = Server.MapPath(sVirtualFolder);

                    //Step 3: Check if file exists
                    if (File.Exists(sPhysicalPath))
                    {
                        //Step 4: Delete image file
                        File.Delete(sPhysicalPath);
                    }
                }


                lblStatus.Text = "User \"" + sUserName + "\" successfully deleted.";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Font.Size = 12;

                //Step 4: Delete record from database
                Membership.DeleteUser(sUserName, true);

                LoadAllUsers();
            }
            else
            {
                lblStatus.Text ="User \""+sUserName+"\" is an admin, you cannot delete user with admin role.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Font.Size = 12;
            }
        }
    }

    protected void ddlAllUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblChangeUserStatus.Text = "";
        LoadUserInformation();
    }

    protected void chkApproved_CheckedChanged(object sender, EventArgs e)
    {
        MembershipUser user = Membership.GetUser(sUserName);
        user.IsApproved = chkApproved.Checked;
        Membership.UpdateUser(user);
        LoadUserInformation();
    }

    protected void chkLockedOut_CheckedChanged(object sender, EventArgs e)
    {
        if (!chkLockedOut.Checked)
        {
            MembershipUser user = Membership.GetUser(sUserName);
            user.UnlockUser();
            chkLockedOut.Enabled = false;
        }
    }

    protected void btnChangeRole_Click(object sender, EventArgs e)
    {
        bool UserInRole = Roles.IsUserInRole(sUserName, "ReportViewer");

        if (UserInRole)
        {
            // RemovedControl user from ReportViewer
            Roles.RemoveUserFromRole(sUserName, "ReportViewer");

            // Add user to role DataCapturer
            Roles.AddUserToRole(sUserName, "DataCapturer");

            lblChangeUserStatus.Text = "User \""+sUserName + "\" is now a DataCapturer";
        }
        else
        {
            // RemovedControl user from ReportViewer
            Roles.RemoveUserFromRole(sUserName, "DataCapturer");

            // Add user to role DataCapturer
            Roles.AddUserToRole(sUserName, "ReportViewer");
            lblChangeUserStatus.Text = "User \"" + sUserName + "\" is now a ReportViewer";
        }


        lblChangeUserStatus.ForeColor = System.Drawing.Color.Green;
        lblChangeUserStatus.Font.Size = 12;
        LoadUserInformation();
    }
}