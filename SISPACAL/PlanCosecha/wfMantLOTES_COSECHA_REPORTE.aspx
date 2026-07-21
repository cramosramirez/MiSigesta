<%@ Page Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantLOTES_COSECHA_REPORTE.aspx.vb" Inherits="PlanCosecha_wfMantLOTES_COSECHA_REPORTE" %>

<%@ Register Src="~/controlesProforma/ucMantLOTES_COSECHA.ascx" TagName="ucMantLOTES_COSECHA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    &nbsp;&nbsp;&nbsp;
    <uc1:ucMantLOTES_COSECHA id="ucMantLOTES_COSECHA1" ES_REPORTE="True" runat="server"></uc1:ucMantLOTES_COSECHA>
</asp:Content>
