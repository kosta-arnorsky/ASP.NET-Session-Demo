<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="SessionDemo.Ajax" EnableSessionState="False" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <button onclick="anAction()" type="button">Ajax calls</button>
    <br>
    <br>
    <div id="demo"></div>

    <script>
        const times = 7;
        const demo = jQuery("#demo");

        function anAction() {
            for (var i = 0; i < times; i++) {
                call("AnAction");
            }
        }

        function call(method) {
            jQuery.ajax({
                type: "POST",
                url: "<%= ResolveUrl("~/Ajax.aspx") %>/" + method,
                data: "{ }",
                contentType: "application/json; charset=utf-8",
                dataType: "json"
            }).done(function (msg) {
                demo.append(msg.d);
                demo.append("<br>");
            });
        }
    </script>
</asp:Content>
