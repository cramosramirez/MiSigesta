<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfRegistroInventarioRozaQuemaProyectada.aspx.vb" Inherits="Procesos_wfRegistroInventarioRozaQuemaProyectada" %>
<%@ Register Src="~/controlesProforma/ucRegistroInventarioQuemaRoza.ascx" TagName="ucRegistroInventarioQuemaRoza" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucRegistroInventarioQuemaRoza id="ucRegistroInventarioQuemaRoza1" TIPO_INGRESO="Proyectada" runat="server"></uc1:ucRegistroInventarioQuemaRoza>
</asp:Content>


