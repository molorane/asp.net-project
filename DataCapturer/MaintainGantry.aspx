<%@ Page Title="Maintain Gantry" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="MaintainGantry.aspx.cs" Inherits="DataCapturer_MaintainGantry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h2 id="hPageHeader" runat="server">Add/Edit Gantry</h2>

     <p>
        <asp:Label ID="lblGantryID" runat="server" Text="Gantry ID:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtGantryID" runat="server" Width="216px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvGantryID" runat="server" ControlToValidate="txtGantryID" CssClass="ErrorMessage" ErrorMessage="Gantry name required" Display="Dynamic"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator3" 
             runat="server" 
             ControlToValidate="txtGantryID" 
             CssClass="ErrorMessage" 
             Display="Dynamic" 
             ErrorMessage="Only numbers required"
             ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
    </p>
    <p>
        <asp:Label ID="lblGantryName" runat="server" Text="Gantry Name:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtGantryName" runat="server" Width="216px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtGantryName" runat="server" ControlToValidate="txtGantryName" CssClass="ErrorMessage" ErrorMessage="Gantry name required"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="lblGantryDesc" runat="server" Text="Gantry Description:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtGantryDesc" runat="server" Width="223px" Height="52px" TextMode="MultiLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtGantryDesc" CssClass="ErrorMessage" ErrorMessage="Gantry description required"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="lblGpsLocation" runat="server" Text="Gantry GPS Location:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtGpsLocation" runat="server" Width="216px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtGpsLocation" CssClass="ErrorMessage" ErrorMessage="Gantry GPS Location required"></asp:RequiredFieldValidator>
    </p>

    <p>
        <asp:Label ID="lblTRateID" runat="server" Text="TRateID:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTRateID" runat="server" Width="219px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTRateID" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="TRateID required"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
            runat="server" 
            ControlToValidate="txtTRateID" 
            CssClass="ErrorMessage" 
            Display="Dynamic" 
            ErrorMessage="Only numbers required" 
            ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
    </p>

    <p>
        <asp:Label ID="lblROfficeID" runat="server" Text="ROfficeID:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtROfficeID" runat="server" Width="215px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
            runat="server" 
            ControlToValidate="txtROfficeID" 
            CssClass="ErrorMessage" 
            Display="Dynamic" 
            ErrorMessage="Gantry ROfficeID required"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtROfficeID" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Only numbers required" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
    </p>
    <p>
        <asp:Button ID="btnAddGantry" runat="server" OnClick="btnAddGantry_Click" Text="Add Gantry" />
        <asp:Button ID="btnEditGantry" runat="server" Text="Edit Gantry" OnClick="btnEditGantry_Click" />
        <asp:Button ID="btnCancel" runat="server" CausesValidation="False" OnClick="btnCancel_Click" Text="Cancel" />
    </p>
    <p>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </p>

    </asp:Content>

