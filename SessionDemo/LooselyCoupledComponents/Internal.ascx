<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Internal.ascx.cs" Inherits="SessionDemo.Internal" EnableViewState="false" %>

<div style="border: 2px solid #f79b00;">
    Internal <%: Name %>
    <br>
    Some action:
    <asp:Button runat="server" Text="Post" OnClick="Post_Click" />
</div>
