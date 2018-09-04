<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionDemo.PageSharedData" EnableSessionState="False" EnableViewState="false" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    Item ID <%: Item.Id %><br>
    Item Property1 <%: Item.Property1 %><br>
    Item Property2 <%: Item.Property2 %><br>
    <br>
    <asp:Button runat="server" Text="DoSomething" OnClick="DoSomething_Click" /><br>
    <asp:Literal runat="server" ID="ctlLiteralActionResult" />
</asp:Content>
