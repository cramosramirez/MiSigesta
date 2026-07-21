<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfExportacionExcel.aspx.vb" Inherits="PlanCosecha_wfExportacionExcel" %>
<%@ Register Src="~/controlesCenso/ucExportacionExcel.ascx" TagName="ucExportacionExcel" TagPrefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">    
    <uc1:ucExportacionExcel id="ucExportacionExcel1" runat="server"></uc1:ucExportacionExcel>
</asp:Content>

