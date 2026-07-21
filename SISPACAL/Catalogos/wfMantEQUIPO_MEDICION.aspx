<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantEQUIPO_MEDICION.aspx.vb" Inherits="wfMantEQUIPO_MEDICION" title="Mantenimiento de Equipo medicion" %>
<%@ Register Src="~/controles/ucMantEQUIPO_MEDICION.ascx" TagName="ucMantEQUIPO_MEDICION" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate> 
    <uc1:ucMantEQUIPO_MEDICION id="ucMantEQUIPO_MEDICION1" runat="server"></uc1:ucMantEQUIPO_MEDICION>
    </ContentTemplate>                 
    </asp:UpdatePanel> 
</asp:Content>
