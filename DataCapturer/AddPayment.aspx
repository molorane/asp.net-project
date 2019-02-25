<%@ Page Title="Add Payment" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="AddPayment.aspx.cs" Inherits="DataCapturer_AddPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Add Payment</h3>
    <p>&nbsp;</p>

    <asp:GridView ID="gvPayments" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsTollTransactions" ForeColor="#333333" GridLines="None" OnRowDataBound="gvPayments_RowDataBound">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="TTID" HeaderText="TTID" SortExpression="TTID" />
            <asp:BoundField DataField="TT_DateTime" HeaderText="TT_DateTime" SortExpression="TT_DateTime" DataFormatString="{0:g}" />
            <asp:CheckBoxField DataField="TT_IsPaid" HeaderText="TT_IsPaid" SortExpression="TT_IsPaid" />
            <asp:BoundField DataField="TT_Amount" HeaderText="TT_Amount" SortExpression="TT_Amount" DataFormatString="{0:c}" />
            <asp:BoundField DataField="TT_VehicleRegistration" HeaderText="TT_VehicleRegistration" SortExpression="TT_VehicleRegistration" />
            <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
            <asp:TemplateField HeaderText="Action" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btnAddPayment" runat="server" CommandName="Select" OnClick="btnAddPayment_Click" Text="Add Payment" OnClientClick="this.disabled=true;" UseSubmitBehavior="False" />
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
    <asp:ObjectDataSource ID="odsTollTransactions" runat="server" SelectMethod="GetTollTransactions" TypeName="CTollTransaction"></asp:ObjectDataSource>

    <p>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </p>
    <asp:Panel ID="pnlAddPayment" runat="server">
        <h3>Add Payment For Transaction</h3>
        <p>
            <asp:TextBox ID="txtTTID" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAmount" runat="server" Text="Pay Amount:"></asp:Label>
            <asp:TextBox ID="txtAmount" runat="server" Width="145px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAmount" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Amount required"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAmount" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Only numbers allowed" ValidationExpression="^\d+(\.\d\d)?$"></asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Add Payment" OnClick="Button1_Click" />
        </p>
    </asp:Panel>
    <br />
</asp:Content>

