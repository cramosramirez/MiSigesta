<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantSOLIC_ENCA_FRENTE_ROZA.aspx.vb" Inherits="Financiero_wfMantSOLIC_ENCA_FRENTE_ROZA" %>
<%@ Register Src="~/controlesFrentes/ucMantSOLIC_ENCA_FRENTE.ascx" TagName="ucMantSOLIC_ENCA_FRENTE" TagPrefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
     <uc1:ucMantSOLIC_ENCA_FRENTE id="ucMantSOLIC_ENCA_FRENTE1" TIPO_PROVEEDOR="FrenteRoza"  runat="server"></uc1:ucMantSOLIC_ENCA_FRENTE>
</asp:Content>

