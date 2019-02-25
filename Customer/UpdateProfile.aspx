<%@ Page Title="Update Profile" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateProfile.aspx.cs" Inherits="Customer_UpdateProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <UBT:ProfileUserControl runat="server" ID="ProfileUserControl" />
    <p>
        <asp:Button ID="btnUpdateProfiel" runat="server" Text="Update Profile" OnClick="btnUpdateProfiel_Click" />
    </p>
    <p>

    </p>
</asp:Content>

