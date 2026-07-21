<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfFormulaDextrana.aspx.vb" Inherits="PreCosecha_LaboratorioCalidad_wfFormulaDextrana" %>
<%@ Register TagPrefix="uc1" TagName="ucFormulaDextrana" Src="~/controlesCenso/ucFormulaDextrana.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucFormulaDextrana id="ucFormulaDextrana1" runat="server"></uc1:ucFormulaDextrana>
</asp:Content>

