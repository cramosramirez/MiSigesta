<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReporteRozaInjiboaRela.aspx.vb" Inherits="Reportes_wfReporteRozaInjiboaRela" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteRozaInjiboaRela" Src="~/controlesCenso/ucReporteRozaInjiboaRela.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporteRozaInjiboaRela id="ucReporteRozaInjiboaRela1" runat="server"></uc1:ucReporteRozaInjiboaRela>   
</asp:Content>

