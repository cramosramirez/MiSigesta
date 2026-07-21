<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReporteServicioEsp.aspx.vb" Inherits="Reportes_wfReporteServicioEsp" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteServiciosEsp" Src="~/controlesFinanciero/ucReporteServiciosEsp.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporteServiciosEsp id="ucReporteServiciosEsp1" runat="server"></uc1:ucReporteServiciosEsp>    
</asp:Content>

