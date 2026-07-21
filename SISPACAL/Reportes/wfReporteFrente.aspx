<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReporteFrente.aspx.vb" Inherits="Reportes_wfReporteFrente" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteFrente" Src="~/controlesFrentes/ucReporteFrente.ascx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporteFrente id="ucReporteFrente1" runat="server"></uc1:ucReporteFrente>       
</asp:Content>

