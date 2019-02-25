<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Login to have access to your Dashboard</h3>
    <p>
        <asp:Login ID="Login2" runat="server" CreateUserText="Register" CreateUserUrl="~/Account/Register.aspx" DestinationPageUrl="~/Default.aspx" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" ForeColor="#333333" Height="231px" style="text-align: left" Width="429px">
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
    </p>
    

    </asp:Content>

