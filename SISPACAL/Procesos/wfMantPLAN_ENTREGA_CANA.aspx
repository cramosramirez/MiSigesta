<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantPLAN_ENTREGA_CANA.aspx.vb" Inherits="wfMantPLAN_ENTREGA_CANA" title="Mantenimiento de Plan entrega cana" %>
<%@ Register Src="~/controles/ucMantPLAN_ENTREGA_CANA.ascx" TagName="ucMantPLAN_ENTREGA_CANA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
        <ContentTemplate> 
        <uc1:ucMantPLAN_ENTREGA_CANA id="ucMantPLAN_ENTREGA_CANA1" runat="server"></uc1:ucMantPLAN_ENTREGA_CANA>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
