<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemList.ascx.cs" Inherits="SessionDemo.ItemList" EnableViewState="false" %>

<div style="border:2px solid #a9208d;">
    Child control
    <asp:ListView runat="server" ID="ctlListViewItems" ItemType="FakeBackend.Item">
        <LayoutTemplate>
            <table>
                <tr>
                    <th>
                        Item ID
                    </th>
                    <th>
                        Item Property1
                    </th>
                    <th>
                        Item Property2
                    </th>
                </tr>
                <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <%# Item.Id %>
                </td>
                <td>
                    <%# Item.Property1 %>
                </td>
                <td>
                    <%# Item.Property2 %>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</div>
