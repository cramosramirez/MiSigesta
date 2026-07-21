<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantPLAN_CATORCENA.aspx.vb" Inherits="wfMantPLAN_CATORCENA" title="Mantenimiento de Plan catorcena" %>
<%@ Register Src="~/controles/ucMantPLAN_CATORCENA.ascx" TagName="ucMantPLAN_CATORCENA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
        <ContentTemplate> 
        <uc1:ucMantPLAN_CATORCENA id="ucMantPLAN_CATORCENA1" runat="server"></uc1:ucMantPLAN_CATORCENA>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
