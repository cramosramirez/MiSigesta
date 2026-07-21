<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfAsignarMotoristaPlaca.aspx.vb" Inherits="PlanCAT_wfAsignarMotoristaPlaca" %>
<%@ Register src="~/controlesProforma/ucAsignacionMotoristaPlaca.ascx" tagname="ucAsignacionMotoristaPlaca" tagprefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucAsignacionMotoristaPlaca ID="ucAsignacionMotoristaPlaca1" runat="server" />
</asp:Content>

