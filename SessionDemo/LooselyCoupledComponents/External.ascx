<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="External.ascx.cs" Inherits="SessionDemo.External" EnableViewState="false" %>

<%@ Register TagPrefix="usr" TagName="Internal" Src="~/LooselyCoupledComponents/Internal.ascx" %>

<div style="border:2px solid #a9208d;">
    External
    <usr:Internal runat="server" Name="First" />
    <usr:Internal runat="server" Name="Second" />
</div>
