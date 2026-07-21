<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReportesCenso.aspx.vb" Inherits="Censo_wfReportesCenso" %>
<%@ Register src="~/controlesCenso/ucReporteCenso.ascx" tagname="ucReporteCenso" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporteCenso ID="ucReporteCenso1" runat="server" />
</asp:Content>

