<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProfileUserControl.ascx.cs" Inherits="Controls_ProfileUserControl" %>

<h3>Profile Information</h3>
<p>
    <asp:Label ID="lblFirstName" runat="server" Text="First Name:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtFirstName" runat="server" Width="188px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvtxtFirstName" runat="server" ControlToValidate="txtFirstName" CssClass="ErrorMessage" ErrorMessage="First name required"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="lblLastName" runat="server" Text="Last Name:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtLastName" runat="server" Width="188px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvtxtLastName" runat="server" ControlToValidate="txtLastName" CssClass="ErrorMessage" ErrorMessage="Last name required"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="lblContactNumber" runat="server" Text="Contact Number:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtContactNumber" runat="server" Width="188px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvtxtContactNumber" runat="server" ControlToValidate="txtContactNumber" CssClass="ErrorMessage" ErrorMessage="Cellphone required"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="lblRSAID" runat="server" Text="RSA ID:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtRSAID" runat="server" Width="188px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvtxtRSAID" runat="server" ControlToValidate="txtRSAID" CssClass="ErrorMessage" ErrorMessage="ID required"></asp:RequiredFieldValidator>
    <asp:CustomValidator ID="cvtxtRSAID" runat="server" ControlToValidate="txtRSAID" CssClass="ErrorMessage" ErrorMessage="ID is not valid" OnServerValidate="cvtxtRSAID_ServerValidate"></asp:CustomValidator>
</p>
<p>
    <asp:Label ID="lblAddressLine1" runat="server" Text="Address Line 1:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtAddressLine1" runat="server" Width="188px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAddressLine1" CssClass="ErrorMessage" ErrorMessage="Address Line 1 required"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="lblAddressLine2" runat="server" Text="Address Line 2:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtAddressLine2" runat="server" Width="188px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lblCity" runat="server" Text="City:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtCity" runat="server" Width="188px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvtxtCity" runat="server" ControlToValidate="txtCity" CssClass="ErrorMessage" ErrorMessage="City field required"></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="lblPostalCode" runat="server" Text="Postal Code:" Width="100px"></asp:Label>
    <asp:TextBox ID="txtPostalCode" runat="server" Width="188px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvtxtPostalCode" runat="server" ControlToValidate="txtPostalCode" CssClass="ErrorMessage" ErrorMessage="Postal code empty"></asp:RequiredFieldValidator>
</p>

<p>
    <asp:Label ID="lblPicture" runat="server" Text="Profile Picture:" Width="100px"></asp:Label>
    <asp:Image ID="imgPicture" runat="server" Width="100px" />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload Picture" />
</p>
<asp:Panel ID="pnlChangePicture" runat="server">
    <asp:FileUpload ID="fuPictureUpload" runat="server" />
    <asp:CustomValidator ID="cvFileUpload" runat="server" 
        ErrorMessage="Only .jpg,.png,.jpeg Files are allowed" 
        ControlToValidate="fuPictureUpload" 
        CssClass="ErrorMessage" 
        OnServerValidate="cvFileUpload_ServerValidate" Display="Dynamic"></asp:CustomValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="fuPictureUpload" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Select an image file (jpg/png)"></asp:RequiredFieldValidator>
    <br />
</asp:Panel>
<p>
    <asp:Label ID="lblStatus" runat="server"></asp:Label>
</p>

