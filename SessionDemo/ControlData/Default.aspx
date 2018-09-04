<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionDemo.ControlData" EnableSessionState="False" EnableViewState="false" %>

<%@ Register TagPrefix="usr" TagName="ItemList" Src="~/ControlData/ItemList.ascx" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    Page
    <usr:ItemList runat="server" ID="ctlItemListItems" />
</asp:Content>
