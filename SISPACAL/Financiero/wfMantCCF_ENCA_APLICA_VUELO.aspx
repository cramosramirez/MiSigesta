<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantCCF_ENCA_APLICA_VUELO.aspx.vb" Inherits="Financiero_wfMantCCF_ENCA_APLICA_VUELO" %>
<%@ Register Src="~/controlesFinanciero/ucMantCCF_ENCA.ascx" TagName="ucMantCCF_ENCA" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantCCF_ENCA id="ucMantCCF_ENCA1" CONCEPTO_CCF="AplicacionVuelo" runat="server"></uc1:ucMantCCF_ENCA>
</asp:Content>
