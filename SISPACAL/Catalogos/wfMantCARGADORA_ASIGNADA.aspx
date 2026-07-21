<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantCARGADORA_ASIGNADA.aspx.vb" Inherits="wfMantCARGADORA_ASIGNADA" title="Mantenimiento de Cargadora asignada" %>
<%@ Register Src="~/controles/ucMantCARGADORA_ASIGNADA.ascx" TagName="ucMantCARGADORA_ASIGNADA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>   
    <uc1:ucMantCARGADORA_ASIGNADA id="ucMantCARGADORA_ASIGNADA1" runat="server"></uc1:ucMantCARGADORA_ASIGNADA>
     </ContentTemplate>                 
    </asp:UpdatePanel> 
</asp:Content>
