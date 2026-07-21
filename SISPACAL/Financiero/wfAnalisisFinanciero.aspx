<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfAnalisisFinanciero.aspx.vb" Inherits="Financiero_wfAnalisisFinanciero" %>
<%@ Register Src="~/controlesFinanciero/ucAnalisisFinanciero.ascx" TagName="ucAnalisisFinanciero" TagPrefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucAnalisisFinanciero id="ucAnalisisFinanciero1" runat="server"></uc1:ucAnalisisFinanciero>
</asp:Content>

