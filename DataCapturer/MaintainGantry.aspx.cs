using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataCapturer_MaintainGantry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString.Get("GantryID") != null)
        {
            hPageHeader.InnerText = "Edit Gantry information";
            EditMode();

            FillData(Int32.Parse(Request.QueryString.Get("GantryID")));
        }
        else
        {
            hPageHeader.InnerText = "Add a new Gantry";
            InsertMode();
        }
    }

    private void FillData(int _iGantryID)
    {
        CGantry Gantry = CGantry.GetGantry(_iGantryID);

        if(Gantry != null)
        {
            txtGantryID.Text = Gantry.GantryID.ToString();
            txtGantryName.Text = Gantry.Gantry_Name;
            txtGantryDesc.Text = Gantry.Gantry_Desc;
            txtGpsLocation.Text = Gantry.Gantry_GPSLocation;
            txtTRateID.Text = Gantry.TRateID.ToString();
            txtROfficeID.Text = Gantry.ROfficeID.ToString();
        }
    }

    public void EditMode()
    {
        btnAddGantry.Visible = false;
        btnEditGantry.Visible = true;
    }

    public void InsertMode()
    {
        btnAddGantry.Visible = true;
        btnEditGantry.Visible = false;
    }


    protected void btnAddGantry_Click(object sender, EventArgs e)
    {
       int GantryAdded = CGantry.MaintainGantry(Convert.ToInt32(txtGantryID.Text),
                                txtGantryName.Text,
                                txtGantryDesc.Text,
                                txtGpsLocation.Text,
                                Convert.ToInt32(txtTRateID.Text),
                                Convert.ToInt32(txtROfficeID.Text));
        
        if(GantryAdded == 1)
        {
            Response.Redirect("~/DataCapturer/ViewGantries.aspx");
        }
        else
        {
            lblStatus.Text = "Gantry could not be added.";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            lblStatus.Font.Size = 12;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/DataCapturer/ViewGantries.aspx");
    }

    protected void btnEditGantry_Click(object sender, EventArgs e)
    {
        int GantryEdited = CGantry.MaintainGantry(Convert.ToInt32(txtGantryID.Text),
                                txtGantryName.Text,
                                txtGantryDesc.Text,
                                txtGpsLocation.Text,
                                Convert.ToInt32(txtTRateID.Text),
                                Convert.ToInt32(txtROfficeID.Text));

        if (GantryEdited == 1)
        {
            Response.Redirect("~/DataCapturer/ViewGantries.aspx");
        }
        else
        {
            lblStatus.Text = "Gantry could not be edited.";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            lblStatus.Font.Size = 12;
        }
    }
}