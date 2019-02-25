<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <p>
        <asp:LoginView ID="lgnView" runat="server">
                <LoggedInTemplate>
                    <p>
                        <asp:LoginName ID="LoginName1" runat="server" 
                            FormatString="Welcome, {0}!" />
                    </p>
                </LoggedInTemplate>
                <AnonymousTemplate>
                    <p>
                        <a runat="server" href="~/Account/Register.aspx">Register</a>
                     </p>
                </AnonymousTemplate>
                <RoleGroups>
                    <asp:RoleGroup Roles="Customer">
                        <ContentTemplate>
                            
                            <!--  Tolls balance for today as well as their total outstanding tolls balance. -->
                            <asp:Label ID="lblTollsBalance" runat="server" 
                                Text="Your toll balance" 
                                CssClass="ErrorMessage" 
                                Font-Bold="False" Font-Size="14"></asp:Label>

                        </ContentTemplate>
                    </asp:RoleGroup>
                    <asp:RoleGroup Roles="DataCapturer">
                        <ContentTemplate>
                            <UBT:ChangePasswordLink runat="server" ID="ChangePasswordLink" />
                        </ContentTemplate>
                    </asp:RoleGroup>
                    <asp:RoleGroup Roles="ReportViewer">
                        <ContentTemplate>
                            <UBT:ChangePasswordLink runat="server" ID="ChangePasswordLink" />
                        </ContentTemplate>
                    </asp:RoleGroup>
                    <asp:RoleGroup Roles="Admin">
                        <ContentTemplate>
                            <UBT:ChangePasswordLink runat="server" ID="ChangePasswordLink" />
                        </ContentTemplate>
                    </asp:RoleGroup>
                </RoleGroups>
            </asp:LoginView>
    </p>
    <p>
        <b>Under Bridge Tolls (UBT)</b> is a large international company specialising in the production and deployment of electronic road tolling systems. The system is made up of gantries that utilise cameras to read a vehicle's licence number when it passes underneath a gantry. Each time a vehicle passes under a UBT gantry the user is charged a toll. This system is used to raise revenue for the maintenance of roads within a country.
    </p>
    <p>
        The <b>UBT</b> system is being applied to a test city, Bloemfontein, within the Free State. You have been hired to develop a website for <b>UBT</b>.
    </p>
    <p>
        In order to get information regarding their toll charges, a customer must register on the website. Once registered, a customer can then register his/her vehicles and view information regarding the amount he/she owes in tolls.
    </p>

</asp:Content>

