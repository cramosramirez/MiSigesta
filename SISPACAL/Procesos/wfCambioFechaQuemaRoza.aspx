<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfCambioFechaQuemaRoza.aspx.vb" Inherits="Procesos_wfCambioFechaQuemaRoza" %>
<%@ Register Src="~/controlesProforma/ucRegistroProforma.ascx" TagName="ucRegistroProforma" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucRegistroProforma id="ucRegistroProforma1" TIPO_OPERACION="CambioFechaQuemaRoza" runat="server"></uc1:ucRegistroProforma>
</asp:Content>

