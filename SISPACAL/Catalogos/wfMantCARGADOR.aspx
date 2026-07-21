<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantCARGADOR.aspx.vb" Inherits="wfMantCARGADOR" title="Mantenimiento de Cargador" %>
<%@ Register Src="~/controles/ucMantCARGADOR.ascx" TagName="ucMantCARGADOR" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>   
    <uc1:ucMantCARGADOR id="ucMantCARGADOR1" runat="server"></uc1:ucMantCARGADOR>
     </ContentTemplate>                 
    </asp:UpdatePanel>  
</asp:Content>
