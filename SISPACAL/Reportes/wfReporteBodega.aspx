<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfReporteBodega.aspx.vb" MasterPageFile="~/Principal.master" Inherits="Reportes_wfReporteBodega" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteBodega" Src="~/controlesBodega/ucReporteBodega.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">             
                <uc1:ucReporteBodega id="ucReporteBodega1" runat="server"></uc1:ucReporteBodega>       
</asp:Content>


