<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfRegistroInventarioRozaQuemaEjecutada.aspx.vb" Inherits="Procesos_wfRegistroInventarioRozaQuemaEjecutada" %>
<%@ Register Src="~/controlesProforma/ucRegistroInventarioQuemaRoza.ascx" TagName="ucRegistroInventarioQuemaRoza" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucRegistroInventarioQuemaRoza id="ucRegistroInventarioQuemaRoza1" TIPO_INGRESO="Ejecutada" runat="server"></uc1:ucRegistroInventarioQuemaRoza>
</asp:Content>


