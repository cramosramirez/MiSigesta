<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfAsignacionCuentaContable.aspx.vb" Inherits="Procesos_wfAsignacionCuentaContable" %>
<%@ Register Src="~/controles/ucAsignarCuentaContableProveedor.ascx" TagName="ucAsignarCuentaContableProveedor" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
        <ContentTemplate>    
            <uc1:ucAsignarCuentaContableProveedor id="ucAsignarCuentaContableProveedor1" runat="server"></uc1:ucAsignarCuentaContableProveedor>
        </ContentTemplate>                 
        </asp:UpdatePanel> 
</asp:Content>


