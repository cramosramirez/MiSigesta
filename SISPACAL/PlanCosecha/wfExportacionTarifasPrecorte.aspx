<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfExportacionTarifasPrecorte.aspx.vb" Inherits="PlanCosecha_wfExportacionTarifasPrecorte" %>
<%@ Register Src="~/controlesFinanciero/ucExportacionTarifasCAT.ascx" TagName="ucExportacionTarifasCAT" TagPrefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucExportacionTarifasCAT id="ucExportacionTarifasCAT1" runat="server"></uc1:ucExportacionTarifasCAT>
</asp:Content>

