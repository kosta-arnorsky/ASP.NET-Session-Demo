<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FastSession.aspx.cs" Inherits="SessionDemo.FastSession" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <p>I'm a fast page but unfortunately I'm using the session</p>
    <p>
        Session was set at
        <asp:Literal runat="server" ID="ctlLiteralTime" />
    </p>
    <p>
        Processed
        <asp:Literal runat="server" ID="ctlLiteralEnded" />
    </p>
</asp:Content>
