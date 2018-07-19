<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionDemo.Protected" EnableSessionState="False" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    Username:
    <asp:Literal runat="server" ID="ctlLiteralUsername" />
    <br>
    Name:
    <asp:Literal runat="server" ID="ctlLiteralName" />
    <br>
    Position:
    <asp:Literal runat="server" ID="ctlLiteralPosition" />
    <br>
    <asp:Button runat="server" Text="Logout" OnClick="Logout_Click" />
</asp:Content>
