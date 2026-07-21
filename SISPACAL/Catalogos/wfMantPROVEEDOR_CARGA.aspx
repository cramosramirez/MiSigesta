<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantPROVEEDOR_CARGA.aspx.vb" Inherits="wfMantPROVEEDOR_CARGA" title="Mantenimiento de Proveedor carga" %>
<%@ Register Src="~/controles/ucMantPROVEEDOR_CARGA.ascx" TagName="ucMantPROVEEDOR_CARGA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
 <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>    
    <uc1:ucMantPROVEEDOR_CARGA id="ucMantPROVEEDOR_CARGA1" runat="server"></uc1:ucMantPROVEEDOR_CARGA>
    </ContentTemplate>                 
    </asp:UpdatePanel>  
</asp:Content>
