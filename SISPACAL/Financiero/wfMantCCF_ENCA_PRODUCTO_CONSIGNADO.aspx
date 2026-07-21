<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantCCF_ENCA_PRODUCTO_CONSIGNADO.aspx.vb" Inherits="Financiero_wfMantCCF_ENCA_PRODUCTO_CONSIGNADO" %>
<%@ Register Src="~/controlesFinanciero/ucMantCCF_ENCA_CONSIGNADO.ascx" TagName="ucMantCCF_ENCA_CONSIGNADO" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantCCF_ENCA_CONSIGNADO id="ucMantCCF_ENCA_CONSIGNADO1" CONCEPTO_CCF="ProductosConsignados" runat="server"></uc1:ucMantCCF_ENCA_CONSIGNADO>
</asp:Content>
