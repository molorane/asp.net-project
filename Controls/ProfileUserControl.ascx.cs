using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_ProfileUserControl : System.Web.UI.UserControl
{
    private string sUserName = "";

    public string UserName
    {
        get { return this.sUserName; }
        set { this.sUserName = value; }
    }
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadProfile();
            pnlChangePicture.Visible = false;
        }

    }

    public void LoadProfile()
    {
        ProfileCommon pcProfile;

        if (this.sUserName.Length > 0)
            pcProfile = this.Profile.GetProfile(this.sUserName);
        else
            pcProfile = this.Profile;

        txtAddressLine1.Text = pcProfile.AddressLine1;
        txtAddressLine2.Text = pcProfile.AddressLine2;
        txtCity.Text = pcProfile.City;
        txtPostalCode.Text = pcProfile.PostalCode;

        CCustomer customer = 
                    CCustomer.GetCustomer(Convert.ToInt32(pcProfile.CustomerID));

        if (customer != null)
        {
            txtFirstName.Text = customer.Cus_FName;
            txtLastName.Text = customer.Cus_LName;
            txtContactNumber.Text = customer.Cus_ContactNumber;
            txtRSAID.Text = customer.Cus_IDNumber;
            imgPicture.ImageUrl = customer.Cus_ProfilePic;
        }

        

    }

    public void SaveProfile()
    {
        int cus_ID = 0;

        ProfileCommon pcProfile = this.Profile;

        CCustomer customer =
                CCustomer.GetCustomer(Convert.ToInt32(pcProfile.CustomerID));

        // When saving profile picture
        // Check whether the user also want to save profile picture
        // If so, call saveProfilePicture to save the attached image file If the user is updating the profile picture as well
        // Pass the previous VirtualPath to delete the Existing profile picture.

        if (customer != null)
        {

            if (pnlChangePicture.Visible)
            {
                //Before updating, delete previous image file if exist
                string sVirtualPath = Server.MapPath(customer.Cus_ProfilePic);

                if (File.Exists(sVirtualPath))
                {
                    //Step 4: Delete image file
                    File.Delete(sVirtualPath);
                }

                CCustomer.UpdateCustomer(Convert.ToInt32(pcProfile.CustomerID),
                                     txtFirstName.Text,
                                     txtLastName.Text,
                                     txtContactNumber.Text,
                                     txtRSAID.Text,
                                     saveImage());
            }
            else
            {
                CCustomer.UpdateCustomer(Convert.ToInt32(pcProfile.CustomerID),
                                     txtFirstName.Text,
                                     txtLastName.Text,
                                     txtContactNumber.Text,
                                     txtRSAID.Text,
                                     customer.Cus_ProfilePic);
            }

        }
        else
        {
            if (pnlChangePicture.Visible)
            {
                cus_ID = CCustomer.AddCustomer(txtFirstName.Text,
                                            txtLastName.Text,
                                            txtContactNumber.Text,
                                            txtRSAID.Text,
                                            saveImage()
                                            );
            }
            else
            {
                cus_ID = CCustomer.AddCustomer(txtFirstName.Text,
                                            txtLastName.Text,
                                            txtContactNumber.Text,
                                            txtRSAID.Text,
                                            null
                                            );
            }
        }

        pcProfile.AddressLine1 = txtAddressLine1.Text;
        pcProfile.AddressLine2 = txtAddressLine2.Text;
        pcProfile.City = txtCity.Text;
        pcProfile.PostalCode = txtPostalCode.Text;
        pcProfile.CustomerID = cus_ID;

        pcProfile.Save();

        pnlChangePicture.Visible = false;
    }

    protected void cvtxtRSAID_ServerValidate(object source, ServerValidateEventArgs args)
    {
        bool IsValidRSAID = CCustomer.ValidateCustomerIDNumber(txtRSAID.Text.ToString());

        bool IsValidLength = (txtRSAID.Text.Length == 13);

        if (IsValidLength)
        {
            if (IsValidRSAID)
                args.IsValid = true;
            else
                args.IsValid = false;
        }
        else
        {
            args.IsValid = false;
        }
    }

    public string saveImage()
    {
        string path = null;
       
        //Set folders
        string sVirtualFolder = "~/ProfilePicture/";
        string sPhysicalFolder = Server.MapPath(sVirtualFolder);

        //Create the filename
        string sFileName = Profile.UserName;

        //Get file extension from selected file
        string sExtension = System.IO.Path.GetExtension(fuPictureUpload.FileName);

        string sVirtualPath = sVirtualFolder + sFileName + sExtension;
        string sPhysicalPath = sPhysicalFolder + sFileName + sExtension;

        //Save the file to disk
        fuPictureUpload.SaveAs(System.IO.Path.Combine(sPhysicalFolder, sFileName + sExtension));

        //Set value of the ImageUrl parameter
        imgPicture.ImageUrl = sVirtualPath;

        path = sVirtualPath;

        pnlChangePicture.Visible = false;

        return path;
    }

    protected void cvFileUpload_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (fuPictureUpload.HasFile)
        {
            string fileExtension = System.IO.Path.GetExtension(fuPictureUpload.FileName);

            string fileExtensionLower = fileExtension.ToLower();

            if (fileExtensionLower != ".jpg" && fileExtensionLower != ".jpeg" && fileExtensionLower != ".png")
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
        else
        {
            args.IsValid = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        pnlChangePicture.Visible = true;
    }
    
}