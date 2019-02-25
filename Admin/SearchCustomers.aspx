<%@ Page Title="Search Surname" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="SearchCustomers.aspx.cs" Inherits="Admin_SearchCustomers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Search Customers</h3>
    <p>
        <asp:Label ID="lblSearchSurname" runat="server" Text="Search Surname:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSearchSurname" runat="server"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="rfvtxtSearchSurname" runat="server" ControlToValidate="txtSearchSurname" CssClass="ErrorMessage" ErrorMessage="Field cannot be empty"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
    </p>
    <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsCustomers" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" Visible="False" />
            <asp:BoundField DataField="Cus_FName" HeaderText="FirstName" SortExpression="Cus_FName" />
            <asp:BoundField DataField="Cus_LName" HeaderText="LastName" SortExpression="Cus_LName" />
            <asp:BoundField DataField="Cus_ContactNumber" HeaderText="Contact Number" SortExpression="Cus_ContactNumber" />
            <asp:BoundField DataField="Cus_IDNumber" HeaderText="IDNumber" SortExpression="Cus_IDNumber" />
            <asp:TemplateField HeaderText="ProfilePic" SortExpression="Cus_ProfilePic">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" Height="38px" Width="53px" ImageUrl='<%# Bind("Cus_ProfilePic") %>' />
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
    <asp:ObjectDataSource ID="odsCustomers" runat="server" SelectMethod="SearchSurname" TypeName="CCustomer">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtSearchSurname" DefaultValue="0" Name="LName" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

