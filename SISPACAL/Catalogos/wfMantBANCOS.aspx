<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantBANCOS.aspx.vb" Inherits="wfMantBANCOS" title="Mantenimiento de Bancos" %>
<%@ Register Src="~/controles/ucMantBANCOS.ascx" TagName="ucMantBANCOS" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
 <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>
    <uc1:ucMantBANCOS id="ucMantBANCOS1" runat="server"></uc1:ucMantBANCOS>
     </ContentTemplate>                 
    </asp:UpdatePanel>
</asp:Content>
