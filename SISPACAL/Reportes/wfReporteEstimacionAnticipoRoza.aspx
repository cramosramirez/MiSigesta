<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReporteEstimacionAnticipoRoza.aspx.vb" Inherits="Reportes_wfReporteEstimacionAnticipoRoza" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteEstimacionAnticipoRoza" Src="~/controles/ucReporteEstimacionAnticipoRoza.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
             
                <uc1:ucReporteEstimacionAnticipoRoza id="ucReporteEstimacionAnticipoRoza1" runat="server"></uc1:ucReporteEstimacionAnticipoRoza>
       
</asp:Content>
