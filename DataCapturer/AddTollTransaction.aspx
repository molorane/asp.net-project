<%@ Page Title="Add Toll Transaction" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="AddTollTransaction.aspx.cs" Inherits="DataCapturer_AddTollTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Add Toll Transaction</h3>
    
    <p>
        <asp:Label ID="lblVRegistration" runat="server" Text="Vehicle Registration:"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtVRegistration" runat="server" Width="202px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtVRegistration" CssClass="ErrorMessage" ErrorMessage="Vehicle Registration"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="lblGantryID" runat="server" Text="Gantry ID:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtGantryID" runat="server" Width="202px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtGantryID" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Gantry ID required"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtGantryID" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Only numeric values are required" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
    </p>
    <p>
        <asp:Button ID="btnAddTollTransaction" runat="server" Text="Create Transaction" OnClick="btnAddTollTransaction_Click" />
    </p>
    <p>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </p>
    
</asp:Content>

