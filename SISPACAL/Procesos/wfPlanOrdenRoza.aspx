<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfPlanOrdenRoza.aspx.vb" Inherits="Procesos_wfPlanOrdenRoza" %>
<%@ Register Src="~/controles/ucPlanOrdenRoza.ascx" TagName="ucPlanOrdenRoza" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
        <ContentTemplate> 
        <uc1:ucPlanOrdenRoza id="ucPlanOrdenRoza1" runat="server"></uc1:ucPlanOrdenRoza>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

