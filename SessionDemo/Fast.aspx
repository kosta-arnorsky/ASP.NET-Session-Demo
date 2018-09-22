<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Fast.aspx.cs" Inherits="SessionDemo.Fast" EnableSessionState="False" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <p>I'm a fast page</p>
    <p>
        Session was set at<asp:Literal runat="server" ID="ctlLiteralTime" />
    </p>
    <p>
        Processed at
        <asp:Literal runat="server" ID="ctlLiteralEnded" />
    </p>
</asp:Content>
