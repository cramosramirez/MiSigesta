<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReporteRequisicion.aspx.vb" Inherits="Reportes_ucReporteRequisicion" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteRequisicion" Src="~/controlesRequisicion/ucReporteRequisicion.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">             
    <uc1:ucReporteRequisicion id="ucReporteRequisicion1" runat="server"></uc1:ucReporteRequisicion>       
</asp:Content>

