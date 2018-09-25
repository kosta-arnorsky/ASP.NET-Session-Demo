<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionDemo.ControlData2" EnableSessionState="False" EnableViewState="false" %>

<%@ Register TagPrefix="usr" TagName="ItemTr" Src="~/ControlData2/ItemTr.ascx" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    Page
    <asp:ListView runat="server" ID="ctlListViewItems" ItemType="FakeBackend.Item">
        <LayoutTemplate>
            <table>
                <tr>
                    <th></th>
                    <th>Item ID
                    </th>
                    <th>Item Property1
                    </th>
                    <th>Item Property2
                    </th>
                </tr>
                <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <usr:ItemTr runat="server" Item="<%# Item %>" />
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
