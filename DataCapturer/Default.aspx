<%@ Page Title="Home" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="DataCapturer_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Data Capturer</h3>

    <p>
        <asp:HyperLink ID="HyperLink1" runat="server"
            NavigateUrl="~/DataCapturer/AddPayment.aspx">Add Payment</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server"
            NavigateUrl="~/DataCapturer/AddTollTransaction.aspx">Add Toll Transaction</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink3" runat="server"
            NavigateUrl="~/DataCapturer/MaintainGantry.aspx">Maintain Gantry</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink4" runat="server"
            NavigateUrl="~/DataCapturer/ViewGantries.aspx">View Gantries</asp:HyperLink>
    </p>
</asp:Content>

