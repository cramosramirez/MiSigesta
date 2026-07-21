<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfReporte.aspx.vb" Inherits="Reportes_wfReporte" %>
<%@ Register TagPrefix="uc1" TagName="ucReporte" Src="~/controles/ucReporte.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriterios" Src="~/controles/ucCriterios.ascx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
             
                <uc1:ucReporte id="ucReporte1" runat="server"></uc1:ucReporte>
       
</asp:Content>

