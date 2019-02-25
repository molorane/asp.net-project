<%@ Page Title="Maintain Vehicle" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="MaintainVehicle.aspx.cs" Inherits="Customer_MaintainVehicle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Maintain Vehicle </h3>
    <asp:ListView ID="ListView1" runat="server" DataSourceID="odsGetCusVehicles" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="VehicleIDLabel" runat="server" Text='<%# Eval("VehicleID") %>' />
                </td>
                <td>
                    <asp:Label ID="Vehicle_MakeLabel" runat="server" Text='<%# Eval("Vehicle_Make") %>' />
                </td>
                <td>
                    <asp:Label ID="Vehicle_ModelLabel" runat="server" Text='<%# Eval("Vehicle_Model") %>' />
                </td>
                <td>
                    <asp:Label ID="Vehicle_RegistrationLabel" runat="server" Text='<%# Eval("Vehicle_Registration") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color:#008A8C;color: #FFFFFF;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
                <td>
                    <asp:TextBox ID="VehicleIDTextBox" runat="server" Text='<%# Bind("VehicleID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="Vehicle_MakeTextBox" runat="server" Text='<%# Bind("Vehicle_Make") %>' />
                </td>
                <td>
                    <asp:TextBox ID="Vehicle_ModelTextBox" runat="server" Text='<%# Bind("Vehicle_Model") %>' />
                </td>
                <td>
                    <asp:TextBox ID="Vehicle_RegistrationTextBox" runat="server" Text='<%# Bind("Vehicle_Registration") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                </td>
                <td>
                    
                </td>
                <td>
                    <asp:TextBox ID="Vehicle_MakeTextBox" runat="server" Text='<%# Bind("Vehicle_Make") %>' />
                </td>
                <td>
                    <asp:TextBox ID="Vehicle_ModelTextBox" runat="server" Text='<%# Bind("Vehicle_Model") %>' />
                </td>
                <td>
                    <asp:TextBox ID="Vehicle_RegistrationTextBox" runat="server" Text='<%# Bind("Vehicle_Registration") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color:#DCDCDC;color: #000000;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="VehicleIDLabel" runat="server" Text='<%# Eval("VehicleID") %>' />
                </td>
                <td>
                    <asp:Label ID="Vehicle_MakeLabel" runat="server" Text='<%# Eval("Vehicle_Make") %>' />
                </td>
                <td>
                    <asp:Label ID="Vehicle_ModelLabel" runat="server" Text='<%# Eval("Vehicle_Model") %>' />
                </td>
                <td>
                    <asp:Label ID="Vehicle_RegistrationLabel" runat="server" Text='<%# Eval("Vehicle_Registration") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                <th runat="server"></th>
                                <th runat="server">VehicleID</th>
                                <th runat="server">Vehicle_Make</th>
                                <th runat="server">Vehicle_Model</th>
                                <th runat="server">Vehicle_Registration</th>
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                        <asp:DataPager ID="DataPager1" runat="server">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="VehicleIDLabel" runat="server" Text='<%# Eval("VehicleID") %>' />
                </td>
                <td>
                    <asp:Label ID="Vehicle_MakeLabel" runat="server" Text='<%# Eval("Vehicle_Make") %>' />
                </td>
                <td>
                    <asp:Label ID="Vehicle_ModelLabel" runat="server" Text='<%# Eval("Vehicle_Model") %>' />
                </td>
                <td>
                    <asp:Label ID="Vehicle_RegistrationLabel" runat="server" Text='<%# Eval("Vehicle_Registration") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:ObjectDataSource ID="odsGetCusVehicles" runat="server" DeleteMethod="DeleteVehicle" InsertMethod="InsertVehicle" SelectMethod="GetCustomerVehicles" TypeName="CVehicle" UpdateMethod="UpdateVehicle">
        <DeleteParameters>
            <asp:Parameter Name="VehicleID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Vehicle_Make" Type="String" />
            <asp:Parameter Name="Vehicle_Model" Type="String" />
            <asp:Parameter Name="Vehicle_Registration" Type="String" />
            <asp:ProfileParameter Name="CustomerID" PropertyName="CustomerID" Type="Int32" />
        </InsertParameters>
        <SelectParameters>
            <asp:ProfileParameter Name="CustomerID" PropertyName="CustomerID" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="VehicleID" Type="Int32" />
            <asp:Parameter Name="Vehicle_Make" Type="String" />
            <asp:Parameter Name="Vehicle_Model" Type="String" />
            <asp:Parameter Name="Vehicle_Registration" Type="String" />
            <asp:ProfileParameter Name="CustomerID" PropertyName="CustomerID" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <p>
        
    </p>
</asp:Content>

