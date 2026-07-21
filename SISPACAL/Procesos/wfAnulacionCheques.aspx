<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfAnulacionCheques.aspx.vb" Inherits="Procesos_wfAnulacionCheques" %>
<%@ Register Src="~/controles/ucOperacionCheques.ascx" TagName="ucOperacionCheques" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
        <ContentTemplate>    
            <uc1:ucOperacionCheques id="ucOperacionCheques1"  TIPO_OPERACION="Anulacion" runat="server"></uc1:ucOperacionCheques>
        </ContentTemplate>                 
        </asp:UpdatePanel> 
</asp:Content>

