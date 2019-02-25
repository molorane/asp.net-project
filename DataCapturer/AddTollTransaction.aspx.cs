using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataCapturer_AddTollTransaction : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    

    protected void btnAddTollTransaction_Click(object sender, EventArgs e)
    {
        bool TransactionAdded =
                        (CTollTransaction.AddTollTransaction(txtVRegistration.Text,
                        Convert.ToInt32(txtGantryID.Text))
                        == 1) ? true : false;

        if (TransactionAdded)
        {
            lblStatus.Text = "New toll transaction added.";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            lblStatus.Font.Size = 12;
        }
        else
        {
            lblStatus.Text = "Toll transaction could not be added.";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            lblStatus.Font.Size = 12;
        }
    }
}