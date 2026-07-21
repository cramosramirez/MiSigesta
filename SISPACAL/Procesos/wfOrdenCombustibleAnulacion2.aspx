<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfOrdenCombustibleAnulacion2.aspx.vb" Inherits="Procesos_wfOrdenCombustibleAnulacion2" %>
<%@ Register Src="~/controles/ucOrdenCombustible2.ascx" TagName="ucOrdenCombustible2" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucOrdenCombustible2 id="ucOrdenCombustible21" TIPO_OPERACION="Anulacion" runat="server"></uc1:ucOrdenCombustible2>       
</asp:Content>


