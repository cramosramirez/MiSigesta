<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantCCF_ENCA_FRENTE_ROZA.aspx.vb" Inherits="Financiero_wfMantCCF_ENCA_FRENTE_ROZA" %>
<%@ Register Src="~/controlesFrentes/ucMantCCF_ENCA_FRENTE.ascx" TagName="ucMantCCF_ENCA_FRENTE" TagPrefix="uc1" %>


<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantCCF_ENCA_FRENTE id="ucMantCCF_ENCA_FRENTE1" TIPO_PROVEEDOR="FrenteRoza"  runat="server"></uc1:ucMantCCF_ENCA_FRENTE>
</asp:Content>

