<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfImportacionSubLotes.aspx.vb" Inherits="PlanCosecha_wfImportacionSubLotes" %>
<%@ Register Src="~/controlesSubLote/ucImportacionSubLotes.ascx" TagName="ucImportacionSubLotes" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucImportacionSubLotes id="ucImportacionSubLotes1" runat="server"></uc1:ucImportacionSubLotes>
</asp:Content>

