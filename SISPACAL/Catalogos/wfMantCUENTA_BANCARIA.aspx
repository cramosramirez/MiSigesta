<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantCUENTA_BANCARIA.aspx.vb" Inherits="wfMantCUENTA_BANCARIA" title="Mantenimiento de Cuenta bancaria" %>
<%@ Register Src="~/controles/ucMantCUENTA_BANCARIA.ascx" TagName="ucMantCUENTA_BANCARIA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate> 
    <uc1:ucMantCUENTA_BANCARIA id="ucMantCUENTA_BANCARIA1" runat="server"></uc1:ucMantCUENTA_BANCARIA>
    </ContentTemplate>                 
    </asp:UpdatePanel> 
</asp:Content>
