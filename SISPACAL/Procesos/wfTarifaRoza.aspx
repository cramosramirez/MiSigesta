<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfTarifaRoza.aspx.vb" Inherits="Procesos_wfTarifaRoza" %>
<%@ Register Src="~/controles/ucTarifaRoza.ascx" TagName="ucTarifaRoza" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">    
        <uc1:ucTarifaRoza id="ucTarifaRoza1" runat="server"></uc1:ucTarifaRoza>
</asp:Content>

