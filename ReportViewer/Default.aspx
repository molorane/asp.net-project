<%@ Page Title="ReportViewer" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ReportViewer_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Report Viewer</h3>
    <p>
        <asp:HyperLink ID="hplNinetyDayUnpaidReport" 
            runat="server"
            NavigateUrl="~/ReportViewer/NinetyDayUnpaidReport.aspx">NinetyDayUnpaidReport</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="hplOutstandingTollsReport"
             runat="server"
            NavigateUrl="~/ReportViewer/OutstandingTollsReport.aspx">OutstandingTollsReport</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="hplPopularRegionReport" 
            runat="server"
            NavigateUrl="~/ReportViewer/PopularRegionReport.aspx">PopularRegionReport</asp:HyperLink>
    </p>
</asp:Content>

