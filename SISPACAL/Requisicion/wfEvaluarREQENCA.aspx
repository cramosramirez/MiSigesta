<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfEvaluarREQENCA.aspx.vb" Inherits="Requisicion_wfEvaluarREQENCA" %>
<%@ Register Src="~/controlesRequisicion/ucMantREQENCA.ascx" TagName="ucMantREQENCA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantREQENCA id="ucMantREQENCA1" ETAPA_SIGUIENTE="Aprobada" runat="server"></uc1:ucMantREQENCA>
</asp:Content>
