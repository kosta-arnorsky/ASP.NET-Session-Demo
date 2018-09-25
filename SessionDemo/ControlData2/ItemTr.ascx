<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemTr.ascx.cs" Inherits="SessionDemo.ItemTr" EnableViewState="false" %>

<tr>
    <td style="border: 2px solid #a9208d;">
        Child control
    </td>
    <td style="border: 2px solid #a9208d;">
        <%# Item.Id %>
    </td>
    <td style="border: 2px solid #a9208d;">
        <%# Item.Property1 %>
    </td>
    <td style="border: 2px solid #a9208d;">
        <%# Item.Property2 %>
    </td>
</tr>
