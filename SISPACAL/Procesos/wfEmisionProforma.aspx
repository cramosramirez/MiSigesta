<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfEmisionProforma.aspx.vb" Inherits="Procesos_wfEmisionProforma" %>
<%@ Register Src="~/controlesProforma/ucEmisionProforma.ascx" TagName="ucEmisionProforma" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucEmisionProforma id="ucEmisionProforma1" runat="server"></uc1:ucEmisionProforma>
</asp:Content>


