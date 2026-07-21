<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantPLAN_SEMANAL.aspx.vb" Inherits="wfMantPLAN_SEMANAL" title="Mantenimiento de Plan semanal" %>
<%@ Register Src="~/controles/ucMantPLAN_SEMANAL.ascx" TagName="ucMantPLAN_SEMANAL" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
        <ContentTemplate> 
        <uc1:ucMantPLAN_SEMANAL id="ucMantPLAN_SEMANAL1" runat="server"></uc1:ucMantPLAN_SEMANAL>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
