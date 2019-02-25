using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataCapturer_AddPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pnlAddPayment.Visible = false;
        }

        lblStatus.Text = "";
    }
    
    protected void btnAddPayment_Click(object sender, EventArgs e)
    {
        var AddPaymentbtn = (Control)sender;
        GridViewRow row = (GridViewRow)AddPaymentbtn.NamingContainer;
        string TTID = row.Cells[0].Text; // TTDID of a record

        Button btnApprove = (Button)sender;
        btnApprove.Enabled = false;

        //Set txtTTID value to, value of the TTID selected
        // The txtTTID is not visible, the user can't edit it.
        // Or the field could be left visible and set to ReadOnly which is another option
        txtTTID.Text = TTID;

        //Set the Amount text field to the amount suppose to be paid
        txtAmount.Text = row.Cells[3].Text.Substring(1);

        pnlAddPayment.Visible = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lblStatus.Text = txtAmount.Text + "  " + txtTTID.Text;
        lblStatus.ForeColor = System.Drawing.Color.Green;
        lblStatus.Font.Size = 12;

        int paymentAdded = CPayment.AddPayment(
                                Convert.ToInt32(txtTTID.Text),
                                Convert.ToDecimal(txtAmount.Text));

        //Check whether transaction was successful
        if (paymentAdded != 0) 
        {
            lblStatus.Text = "Payment transaction successful.";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            lblStatus.Font.Size = 12;

            pnlAddPayment.Visible = false;
        }
        else
        {
            lblStatus.Text = "Payment transaction not successful."+ paymentAdded;
            lblStatus.ForeColor = System.Drawing.Color.Red;
            lblStatus.Font.Size = 12;
        }
        
    }

    protected void gvPayments_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        switch (e.Row.RowType)
        {
            case DataControlRowType.DataRow:
                CTollTransaction myDataRowView = (CTollTransaction)e.Row.DataItem;
                Button AddPaymentButton = e.Row.FindControl("btnAddPayment") as Button;
                AddPaymentButton.Visible = (!myDataRowView.TT_IsPaid);
                break;
        }
    }
}