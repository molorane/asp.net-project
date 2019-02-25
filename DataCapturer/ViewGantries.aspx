<%@ Page Title="View Gantries" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="ViewGantries.aspx.cs" Inherits="DataCapturer_ViewGantries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>View Gantries</h3>

    <p>
        <asp:GridView ID="gvGantries" runat="server" AutoGenerateColumns="False" DataSourceID="odsGantries" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="GantryID" HeaderText="GantryID" SortExpression="GantryID" />
                <asp:BoundField DataField="Gantry_Name" HeaderText="Gantry Name" SortExpression="Gantry_Name" />
                <asp:BoundField DataField="Gantry_Desc" HeaderText="Gantry Desc" SortExpression="Gantry_Desc" />
                <asp:BoundField DataField="Gantry_GPSLocation" HeaderText="Gantry GPSLocation" SortExpression="Gantry_GPSLocation" />
                <asp:BoundField DataField="TRateID" HeaderText="TRateID" SortExpression="TRateID" />
                <asp:BoundField DataField="ROfficeID" HeaderText="ROfficeID" SortExpression="ROfficeID" />
                <asp:TemplateField HeaderText="Navigate" ShowHeader="False">
                    <EditItemTemplate>
                        <asp:Button ID="Button1" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                        &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Button ID="btnEdit" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit details" OnClick="btnEdit_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="odsGantries" runat="server" InsertMethod="MaintainGantry" SelectMethod="GetGantries" TypeName="CGantry" UpdateMethod="MaintainGantry">
        </asp:ObjectDataSource>
    </p>
    <p>
        <asp:Button ID="btnAddGantry" runat="server" Text="Add Gantry" OnClick="btnAddGantry_Click" />
    </p>
</asp:Content>

