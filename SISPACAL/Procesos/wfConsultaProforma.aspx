<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfConsultaProforma.aspx.vb" Inherits="Procesos_wfConsultaProforma" %>
<%@ Register Src="~/controlesProforma/ucMantPROFORMA.ascx" TagName="ucMantPROFORMA" TagPrefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <ContentTemplate>    
        <uc1:ucMantPROFORMA id="ucMantPROFORMA1" TIPO_OPERACION="ConsultaProforma" runat="server"></uc1:ucMantPROFORMA>    
    </ContentTemplate>    
</asp:Content>

