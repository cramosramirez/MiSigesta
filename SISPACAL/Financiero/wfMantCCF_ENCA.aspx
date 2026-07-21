<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantCCF_ENCA.aspx.vb" Inherits="Financiero_wfMantCCF_ENCA" %>
<%@ Register Src="~/controlesFinanciero/ucMantCCF_ENCA.ascx" TagName="ucMantCCF_ENCA" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantCCF_ENCA id="ucMantCCF_ENCA1" CONCEPTO_CCF="ProductosNoConsignados" runat="server"></uc1:ucMantCCF_ENCA>
</asp:Content>


