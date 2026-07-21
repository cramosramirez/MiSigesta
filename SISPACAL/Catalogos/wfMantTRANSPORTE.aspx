<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantTRANSPORTE.aspx.vb" Inherits="wfMantTRANSPORTE" title="Mantenimiento de Transporte" %>
<%@ Register Src="~/controles/ucMantTRANSPORTE.ascx" TagName="ucMantTRANSPORTE" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>
    <uc1:ucMantTRANSPORTE id="ucMantTRANSPORTE1" runat="server"></uc1:ucMantTRANSPORTE>
         </ContentTemplate>                 
    </asp:UpdatePanel>
</asp:Content>
