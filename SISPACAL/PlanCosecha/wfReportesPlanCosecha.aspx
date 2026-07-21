<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReportesPlanCosecha.aspx.vb" Inherits="PlanCosecha_wfReportesPlanCosecha" %>
<%@ Register src="~/controlesCenso/ucReportePlanCosecha.ascx" tagname="ucReportePlanCosecha" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReportePlanCosecha ID="ucReportePlanCosecha1" runat="server" />
</asp:Content>

