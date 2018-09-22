<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SessionDemo.Login" EnableSessionState="False" EnableViewState="false" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <asp:HyperLink runat="server" NavigateUrl="~/Protected">A protected page</asp:HyperLink>
    <br>
    <br>
    <asp:Label runat="server" AssociatedControlID="ctlTextBoxUsername">Username:</asp:Label>
    <asp:TextBox runat="server" ID="ctlTextBoxUsername" />
    try jkally or acooper
    <br>
    <asp:Button runat="server" Text="Login" OnClick="Login_Click" /><br>
    <asp:Label runat="server" ID="ctlLabelError" Style="color: red;" />
</asp:Content>
