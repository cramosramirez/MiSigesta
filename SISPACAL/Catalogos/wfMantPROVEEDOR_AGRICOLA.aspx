<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantPROVEEDOR_AGRICOLA.aspx.vb" Inherits="Catalogos_wfMantPROVEEDOR_AGRICOLA" %>
<%@ Register Src="~/controlesInventario/ucMantPROVEEDOR_AGRICOLA.ascx" TagName="ucMantPROVEEDOR_AGRICOLA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantPROVEEDOR_AGRICOLA id="ucMantPROVEEDOR_AGRICOLA1" runat="server"></uc1:ucMantPROVEEDOR_AGRICOLA>  
</asp:Content>

