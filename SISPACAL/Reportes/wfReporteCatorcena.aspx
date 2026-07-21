<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReporteCatorcena.aspx.vb" Inherits="Reportes_wfReporteCatorcena" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteCatorcena" Src="~/controles/ucReporteCatorcena.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriterios" Src="~/controles/ucCriterios.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">             
                <uc1:ucReporteCatorcena id="ucReporteCatorcena1" runat="server"></uc1:ucReporteCatorcena>       
</asp:Content>

