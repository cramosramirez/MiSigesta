<%@ Page Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfRegistroEjecutadoQuemaRoza.aspx.vb" Inherits="Procesos_wfRegistroEjecutadoQuemaRoza" %>
<%@ Register Src="~/controlesProforma/ucRegistroEjecutadoQuemaRoza.ascx" TagName="ucRegistroEjecutadoQuemaRoza" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucRegistroEjecutadoQuemaRoza id="ucRegistroEjecutadoQuemaRoza1" TIPO_INGRESO="Ejecutada" runat="server"></uc1:ucRegistroEjecutadoQuemaRoza>
</asp:Content>