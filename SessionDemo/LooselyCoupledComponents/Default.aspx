<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionDemo.LooselyCoupledComponents" EnableSessionState="False" EnableViewState="false" %>

<%@ Register TagPrefix="usr" TagName="External" Src="~/LooselyCoupledComponents/External.ascx" %>
<%@ Register TagPrefix="usr" TagName="Snippet" Src="~/LooselyCoupledComponents/Snippet.ascx" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    Page
    <usr:External runat="server" />
    <br>
    <br>
    Some code:
    <usr:Snippet runat="server" />
</asp:Content>
