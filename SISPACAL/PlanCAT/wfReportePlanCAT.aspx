<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReportePlanCAT.aspx.vb" Inherits="PlanCAT_wfReportePlanCAT" %>
<%@ Register src="~/controlesCenso/ucReportePlanCAT.ascx" tagname="ucReportePlanCAT" tagprefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReportePlanCAT ID="ucReportePlanCAT1" runat="server" />
</asp:Content>

