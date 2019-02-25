<%@ Page Title="Add Report Viewer" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="AddReportViewer.aspx.cs" Inherits="Admin_AddReportViewer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Add Report Viewer</h3>
    <p>
        <asp:Label ID="lbluserName" runat="server" Text="UserName:  "></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtUserName" runat="server" ControlToValidate="txtUserName" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="UserName is required"></asp:RequiredFieldValidator>
    </p>
<p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create User" />
    </p>
<p>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </p>
</asp:Content>

