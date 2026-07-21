<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantPROVEEDOR_CON_CONTRATO.aspx.vb" Inherits="Contratos_wfMantPROVEEDOR_CON_CONTRATO" %>

<%@ Register Src="~/controlesContrato/ucMantPROVEEDOR.ascx" TagName="ucMantPROVEEDOR" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantPROVEEDOR id="ucMantPROVEEDOR1" MostrarProveedoresConContrato="true" runat="server"></uc1:ucMantPROVEEDOR>
</asp:Content>

