using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (User.Identity.IsAuthenticated)
        {
            ProfileCommon pcProfile;
            int CustomerID = 0;

            if (Roles.IsUserInRole("Customer"))
            {
                pcProfile = this.Profile.GetProfile(User.Identity.Name);

                CustomerID = pcProfile.CustomerID;

                Label lblTollsBalance = ((Label)lgnView.FindControl("lblTollsBalance"));
                
                lblTollsBalance.Text = CCustomer.DailyReminder(CustomerID); 
                
            }

        }
        
    }
}