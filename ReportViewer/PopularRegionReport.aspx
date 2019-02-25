<%@ Page Title="PopularRegionReport" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="PopularRegionReport.aspx.cs" Inherits="ReportViewer_PopularRegionReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Popular Region Report</h3>

    <p>
        <asp:Label ID="lblStartDate" runat="server" Text="Start Date:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStartDate" runat="server" Width="160px"></asp:TextBox>
    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtStartDate" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Start date required"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator 
        ID="revtxtStartDate" 
        runat="server" 
        ErrorMessage="Please Enter a valid date in the format (mm/dd/yyyy)"
        ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$" ControlToValidate="txtStartDate" CssClass="ErrorMessage" Display="Dynamic"></asp:RegularExpressionValidator>
    </p>
    <p>
        <asp:Label ID="lblEndDate" runat="server" Text="End Date:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEndDate" runat="server" Width="163px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEndDate" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="End date required"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator 
            ID="revtxtEndDate" 
            runat="server" 
            ErrorMessage="Please Enter a valid date in the format (mm/dd/yyyy)"
            ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$" ControlToValidate="txtEndDate" CssClass="ErrorMessage" Display="Dynamic"></asp:RegularExpressionValidator>
    </p>
    <p>
        <asp:Button ID="btnSearch" runat="server" Text="Get Report" />
    </p>
<p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsPopularRegionReport" ForeColor="#333333" GridLines="None" AllowPaging="True">
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
        <asp:ObjectDataSource ID="odsPopularRegionReport" runat="server" SelectMethod="PopularRegionReport" TypeName="CRegion">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtStartDate" Name="StartDate" PropertyName="Text" Type="DateTime" DefaultValue="05/30/2017" />
                <asp:ControlParameter ControlID="txtEndDate" Name="EndDate" PropertyName="Text" Type="DateTime" DefaultValue="06/06/2017" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p> 
</asp:Content>

