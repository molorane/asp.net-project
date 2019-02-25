<%@ Page Title="Customer" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Customer_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Customer Dashboard</h3>
    <p>
        <asp:HyperLink ID="hplManageVehicle" 
            runat="server"
            NavigateUrl="~/Customer/MaintainVehicle.aspx">Manage Vehicle</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="hplUpdateProfile" 
            runat="server"
            NavigateUrl="~/Customer/UpdateProfile.aspx">Update Profile</asp:HyperLink>
    </p>
</asp:Content>

