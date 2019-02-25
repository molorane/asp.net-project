<%@ Page Title="OutstandingTollsReport" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="OutstandingTollsReport.aspx.cs" Inherits="ReportViewer_OutstandingTollsReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Outstanding Tolls Report</h3>
    <asp:GridView ID="gvOutstandingTollsReport" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsOutstandingTollsReport" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="ROfficeID" HeaderText="ROfficeID" SortExpression="ROfficeID" />
            <asp:BoundField DataField="ROffice_Name" HeaderText="ROffice_Name" SortExpression="ROffice_Name" />
            <asp:BoundField DataField="TotalOutstanding" HeaderText="TotalOutstanding" SortExpression="TotalOutstanding" />
            <asp:BoundField DataField="NumberOfTolls" HeaderText="NumberOfTolls" SortExpression="NumberOfTolls" />
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
<asp:ObjectDataSource ID="odsOutstandingTollsReport" runat="server" SelectMethod="OutstandingTollsReport" TypeName="CRegion"></asp:ObjectDataSource>
</asp:Content>

