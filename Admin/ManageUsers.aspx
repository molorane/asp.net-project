<%@ Page Title="Manage Users" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="ManageUsers.aspx.cs" Inherits="Admin_ManageUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
     <h2>Delete Users</h2>
    <p>
        Select User:
    </p>
    <p>
        <asp:DropDownList ID="ddlAllUsers" runat="server" 
            Height="27px" Width="172px" 
            AutoPostBack="True" 
            OnSelectedIndexChanged="ddlAllUsers_SelectedIndexChanged"></asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click"
            Text="Delete this User" />
    </p>
    <h3>PERSONAL INFORMATION</h3>
    <p>
        <asp:Label ID="lblApproved" runat="server" Text="Approved:" Width="100px"></asp:Label>
        <asp:CheckBox ID="chkApproved" runat="server" AutoPostBack="True" 
            oncheckedchanged="chkApproved_CheckedChanged" />
    </p>
    <p>
        <asp:Label ID="lblLockedOut" runat="server" Text="Locked out:" Width="100px"></asp:Label>
        <asp:CheckBox ID="chkLockedOut" runat="server" AutoPostBack="True" 
            Enabled="False" oncheckedchanged="chkLockedOut_CheckedChanged" />
    </p>
    <p>
        <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnChangeRole" runat="server" Text="Change user role" OnClick="btnChangeRole_Click" />
    </p>
     <p>
         <asp:Label ID="lblChangeUserStatus" runat="server"></asp:Label>
    </p>
</asp:Content>

