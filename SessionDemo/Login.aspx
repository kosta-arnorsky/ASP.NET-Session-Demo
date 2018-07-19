<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SessionDemo.Login" EnableSessionState="False" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <asp:HyperLink runat="server" NavigateUrl="~/Protected">A protected page</asp:HyperLink>
    <br>
    <br>
    <asp:Label runat="server" AssociatedControlID="ctlTextBoxUsername">Username:</asp:Label>
    <asp:TextBox runat="server" ID="ctlTextBoxUsername" />
    <br>
    <asp:Button runat="server" Text="Login" OnClick="Login_Click" />
</asp:Content>
