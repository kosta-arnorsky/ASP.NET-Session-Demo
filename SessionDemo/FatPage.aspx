<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FatPage.aspx.cs" Inherits="SessionDemo.FatPage" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <p>I'm a big fat page and I use the session</p>
    <p>
        Session was set at
        <asp:Literal runat="server" ID="ctlLiteralTime" />
    </p>
    <p>
        Processed
        <asp:Literal runat="server" ID="ctlLiteralEnded" />
    </p>
</asp:Content>
