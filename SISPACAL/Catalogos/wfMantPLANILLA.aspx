<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantPLANILLA.aspx.vb" Inherits="wfMantPLANILLA" title="Mantenimiento de Planilla" %>
<%@ Register Src="~/controles/ucMantPLANILLA.ascx" TagName="ucMantPLANILLA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
        <ContentTemplate>   
        <uc1:ucMantPLANILLA id="ucMantPLANILLA1" runat="server"></uc1:ucMantPLANILLA>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
