<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReportes.aspx.vb" Inherits="PreCosecha_LaboratorioCalidad_wfReportes" %>
<%@ Register src="~/controlesCenso/ucReporteLabPreCosecha.ascx" tagname="ucReporteLabPreCosecha" tagprefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporteLabPreCosecha ID="ucReporteLabPreCosecha1" runat="server" />
</asp:Content>

