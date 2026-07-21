<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReporteQuerqueoInjiboaRela.aspx.vb" Inherits="Reportes_wfReporteQuerqueoInjiboaRela" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteQuerqueoInjiboaRela" Src="~/controlesCenso/ucReporteQuerqueoInjiboaRela.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
     <uc1:ucReporteQuerqueoInjiboaRela id="ucReporteQuerqueoInjiboaRela1" runat="server"></uc1:ucReporteQuerqueoInjiboaRela> 
</asp:Content>

