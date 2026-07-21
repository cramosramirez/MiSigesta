<%@ Page Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantCONTRATO.aspx.vb" Inherits="wfMantCONTRATO" title="Mantenimiento de Contrato" %>
<%@ Register Src="~/controlesContrato/ucMantCONTRATO.ascx" TagName="ucMantCONTRATO" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantCONTRATO id="ucMantCONTRATO1" TIPO_OPERACION="Ingreso" runat="server"></uc1:ucMantCONTRATO>
</asp:Content>
