<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfConsultaPesoBascula.aspx.vb" Inherits="Procesos_wfConsultaPesoBascula" %>
<%@ Register Src="~/controles/ucBascula.ascx" TagName="ucBascula" TagPrefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">     
        <uc1:ucBascula id="ucBascula1"  TIPO_OPERACION="Consulta" runat="server"></uc1:ucBascula>       
</asp:Content>

