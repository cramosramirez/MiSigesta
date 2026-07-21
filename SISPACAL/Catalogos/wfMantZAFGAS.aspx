<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantZAFGAS.aspx.vb" Inherits="wfMantZAFGAS" title="Mantenimiento de Zafgas" %>
<%@ Register Src="~/controles/ucMantZAFGAS.ascx" TagName="ucMantZAFGAS" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>    
    <uc1:ucMantZAFGAS id="ucMantZAFGAS1" runat="server"></uc1:ucMantZAFGAS>
     </ContentTemplate>                 
    </asp:UpdatePanel> 
</asp:Content>
