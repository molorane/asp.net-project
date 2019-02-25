<%@ Page Title="Register" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<%@ Register Src="~/Controls/ProfileUserControl.ascx" TagPrefix="CoolPaws" TagName="ProfileUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <!-- MM MOLORANE, 2014098616 -->
    <h3>Create Account and have access to eToll services</h3>
    <p>
        <asp:CreateUserWizard ID="wizCreateUser" 
            runat="server" 
            OnContinueButtonClick="wizCreateUser_ContinueButtonClick" 
            OnCreatedUser="wizCreateUser_CreatedUser" 
            OnFinishButtonClick="wizCreateUser_FinishButtonClick" CssClass="ErrorMessage" BackColor="White" BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt">
            <ContinueButtonStyle BackColor="#FFFFFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <CreateUserButtonStyle BackColor="#FFFFFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="#FFFFFF" />
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                </asp:CreateUserWizardStep>
                <asp:WizardStep runat="server" Title="Personal Information">
                    <UBT:ProfileUserControl runat="server" id="ProfileUserControl1" />
                    <br />
                </asp:WizardStep>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                </asp:CompleteWizardStep>
            </WizardSteps>
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="#FFFFFF" HorizontalAlign="Center" />
            <NavigationButtonStyle BackColor="#FFFFFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="#FFFFFF" />
            <SideBarStyle BackColor="#5D7B9D" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
            <StepStyle BorderWidth="0px" />
        </asp:CreateUserWizard>
    </p>
    

</asp:Content>

