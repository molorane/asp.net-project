<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Welcome to ADMINISTRATION section</h3>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/ManageUsers.aspx">Manage Users</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin/AddReportViewer.aspx">Add Report Viewer</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Admin/SearchCustomers.aspx">Search Customer</asp:HyperLink>
    </p>
</asp:Content>

