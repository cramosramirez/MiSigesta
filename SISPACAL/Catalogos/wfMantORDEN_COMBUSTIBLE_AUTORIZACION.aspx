<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantORDEN_COMBUSTIBLE_AUTORIZACION.aspx.vb" Inherits="wfMantORDEN_COMBUSTIBLE_AUTORIZACION" title="Mantenimiento de Orden combustible autorizacion" %>
<%@ Register Src="~/controles/ucMantORDEN_COMBUSTIBLE_AUTORIZACION.ascx" TagName="ucMantORDEN_COMBUSTIBLE_AUTORIZACION" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>   
    <uc1:ucMantORDEN_COMBUSTIBLE_AUTORIZACION id="ucMantORDEN_COMBUSTIBLE_AUTORIZACION1" runat="server"></uc1:ucMantORDEN_COMBUSTIBLE_AUTORIZACION>
    </ContentTemplate>                 
    </asp:UpdatePanel>  
</asp:Content>
