<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfEliminacionEnvio.aspx.vb" Inherits="Procesos_wfEliminacionEnvio" %>
<%@ Register Src="~/controles/ucComprobanteEnvio.ascx" TagName="ucComprobanteEnvio" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">      
    <ContentTemplate>    
        <uc1:ucComprobanteEnvio id="ucComprobanteEnvio1"  TIPO_OPERACION="Eliminacion" runat="server"></uc1:ucComprobanteEnvio>
    </ContentTemplate>                     
</asp:Content>
