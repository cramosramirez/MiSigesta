<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantUSUARIO.aspx.vb" Inherits="wfMantUSUARIO" title="Mantenimiento de Usuario" %>
<%@ Register Src="~/controles/ucMantUSUARIO.ascx" TagName="ucMantUSUARIO" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>    
        <uc1:ucMantUSUARIO id="ucMantUSUARIO1" runat="server"></uc1:ucMantUSUARIO>
    </ContentTemplate>                 
    </asp:UpdatePanel>     
</asp:Content>
