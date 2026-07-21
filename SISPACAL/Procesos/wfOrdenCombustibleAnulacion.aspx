<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfOrdenCombustibleAnulacion.aspx.vb" Inherits="Procesos_wfOrdenCombustibleAnulacion" %>
<%@ Register Src="~/controles/ucOrdenCombustible.ascx" TagName="ucOrdenCombustible" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
   <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>    
        <uc1:ucOrdenCombustible id="ucOrdenCombustible1" TIPO_OPERACION="Anulacion" runat="server"></uc1:ucOrdenCombustible>
      </ContentTemplate>                 
    </asp:UpdatePanel> 
</asp:Content>

