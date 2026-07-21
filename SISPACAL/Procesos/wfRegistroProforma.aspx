<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfRegistroProforma.aspx.vb" Inherits="Procesos_wfRegistroProforma" %>
<%@ Register Src="~/controlesProforma/ucRegistroProforma.ascx" TagName="ucRegistroProforma" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucRegistroProforma id="ucRegistroProforma1" TIPO_OPERACION="RegistroProforma" runat="server"></uc1:ucRegistroProforma>
</asp:Content>