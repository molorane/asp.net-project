<%@ Page Title="NinetyDayUnpaidReport" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="NinetyDayUnpaidReport.aspx.cs" Inherits="ReportViewer_NinetyDayUnpaidReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->  
    <h3>Ninety Days Unpaid Tolls Report</h3>
     <asp:GridView ID="gvUnpaidTolls" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsUnpaidTolls" ForeColor="#333333" GridLines="None">
         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
         <Columns>
             <asp:BoundField DataField="TTID" HeaderText="TTID" SortExpression="TTID" />
             <asp:BoundField DataField="TT_DateTime" HeaderText="TT_DateTime" SortExpression="TT_DateTime" DataFormatString="{0:g}" />
             <asp:CheckBoxField DataField="TT_IsPaid" HeaderText="TT_IsPaid" SortExpression="TT_IsPaid" />
             <asp:BoundField DataField="TT_Amount" HeaderText="TT_Amount" SortExpression="TT_Amount" DataFormatString="{0:c}" />
             <asp:BoundField DataField="TT_VehicleRegistration" HeaderText="TT_VehicleRegistration" SortExpression="TT_VehicleRegistration" />
             <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
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
      <asp:ObjectDataSource ID="odsUnpaidTolls" runat="server" SelectMethod="NinetyDayUnpaidReport" TypeName="CTollTransaction"></asp:ObjectDataSource>
</asp:Content>

