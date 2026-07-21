<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfAsignacionTransporte.aspx.vb" Inherits="Procesos_wfAsignacionTransporte" %>
<%@ Register Src="~/controlesProforma/ucAsignacionTransporte.ascx" TagName="ucAsignacionTransporte" TagPrefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucAsignacionTransporte id="ucAsignacionTransporte1" runat="server"></uc1:ucAsignacionTransporte>
</asp:Content>

