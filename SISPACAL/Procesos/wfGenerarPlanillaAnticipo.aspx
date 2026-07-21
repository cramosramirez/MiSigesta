<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfGenerarPlanillaAnticipo.aspx.vb" Inherits="Procesos_wfGenerarPlanillaAnticipo" %>
<%@ Register Src="~/controles/ucPlanillaAnticipos.ascx" TagName="ucPlanillaAnticipos" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
        <ContentTemplate> 
        <uc1:ucPlanillaAnticipos id="ucPlanillaAnticipos1" runat="server"></uc1:ucPlanillaAnticipos>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

