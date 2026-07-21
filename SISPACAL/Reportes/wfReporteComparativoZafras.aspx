<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReporteComparativoZafras.aspx.vb" Inherits="Reportes_wfReporteComparativoZafras" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteProduccion" Src="~/controlesCenso/ucReporteProduccion.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporteProduccion id="ucReporteProduccion1" runat="server"></uc1:ucReporteProduccion>
</asp:Content>

