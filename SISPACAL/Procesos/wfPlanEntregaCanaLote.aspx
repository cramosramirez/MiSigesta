<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfPlanEntregaCanaLote.aspx.vb" Inherits="Procesos_wfPlanEntregaCanaLote" %>
<%@ Register Src="~/controles/ucPlanEntregaCanaPorLote.ascx" TagName="ucPlanEntregaCanaPorLote" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
        <ContentTemplate> 
        <uc1:ucPlanEntregaCanaPorLote id="ucPlanEntregaCanaPorLote1" runat="server"></uc1:ucPlanEntregaCanaPorLote>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

