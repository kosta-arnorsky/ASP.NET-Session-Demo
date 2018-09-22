<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionDemo.Default" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <asp:HyperLink runat="server" NavigateUrl="~/FatPage.aspx">Fat</asp:HyperLink>
        <asp:HyperLink runat="server" NavigateUrl="~/FastSession.aspx">Fast with session</asp:HyperLink>
        <asp:HyperLink runat="server" NavigateUrl="~/Fast.aspx">Fast</asp:HyperLink>
        <br>
        <asp:HyperLink runat="server" NavigateUrl="~/Ajax.aspx">Ajax</asp:HyperLink>
        <asp:HyperLink runat="server" NavigateUrl="~/AjaxSession.aspx">Ajax with session</asp:HyperLink>
        <br>
        <asp:HyperLink runat="server" NavigateUrl="~/DataAmongnRequests/">Passing data among requests</asp:HyperLink>
        <asp:HyperLink runat="server" NavigateUrl="~/PageSharedData/?id=3">Using the same data across page</asp:HyperLink>
        <asp:HyperLink runat="server" NavigateUrl="~/ControlData/">Passing data in child controls</asp:HyperLink>
        <asp:HyperLink runat="server" NavigateUrl="~/LooselyCoupledComponents/">Loosely coupled components</asp:HyperLink>
        <br>
        <br>
        <br>
    </div>
    <div>
        Session was set at
        <asp:Literal runat="server" ID="ctlLiteralTime" />
        <br>
        <br>
        <br>
    </div>
    <div id="demo">
        Loading a big fat page which uses the session<br>
        <br>
        <iframe src="<%: ResolveClientUrl("~/FatPage.aspx") %>"></iframe>
        <br>
        <br>
    </div>

    <script>
        var demo = jQuery("#demo");

        setTimeout(function () {
            demo.append("Loading a fast page which uses the session<br><br><iframe src=\"<%: ResolveClientUrl("~/FastSession.aspx") %>\"></iframe><br><br>");
            demo.append("Loading a fast page which dosen't use the session<br><br><iframe src=\"<%: ResolveClientUrl("~/Fast.aspx") %>\"></iframe>");
        }, 1111);
    </script>
</asp:Content>
