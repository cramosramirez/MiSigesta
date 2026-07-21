<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantPROVEEDOR_COMBUSTIBLE.aspx.vb" Inherits="wfMantPROVEEDOR_COMBUSTIBLE" title="Mantenimiento de Proveedor combustible" %>
<%@ Register Src="~/controles/ucMantPROVEEDOR_COMBUSTIBLE.ascx" TagName="ucMantPROVEEDOR_COMBUSTIBLE" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>    
    <uc1:ucMantPROVEEDOR_COMBUSTIBLE id="ucMantPROVEEDOR_COMBUSTIBLE1" runat="server"></uc1:ucMantPROVEEDOR_COMBUSTIBLE>
    </ContentTemplate>                 
    </asp:UpdatePanel>  
</asp:Content>
