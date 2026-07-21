<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfAsignacionTransporteExtraordinario.aspx.vb" Inherits="Procesos_wfAsignacionTransporteExtraordinario" %>
<%@ Register Src="~/controlesProforma/ucAsignacionTransporte.ascx" TagName="ucAsignacionTransporte" TagPrefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucAsignacionTransporte id="ucAsignacionTransporte1" runat="server" PROFORMA_EXTRAORDINARIO="true" ></uc1:ucAsignacionTransporte>
</asp:Content>

