<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionDemo.DataAmongnRequests" EnableSessionState="False" EnableViewState="false" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <asp:HiddenField runat="server" ID="ctlHiddenFieldAccumulator" />
    <br>
    <asp:TextBox runat="server" ID="ctlTextBoxUserInput" /> <asp:Button runat="server" Text="Post" OnClick="Post_Click" /><br>
    <br>
    I don't need a state to have all data:
    <br>
    <asp:Literal runat="server" ID="ctlLiteralActionResult" />
</asp:Content>
