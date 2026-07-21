<%@ Page Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantCONTRATO_LG.aspx.vb" Inherits="wfMantCONTRATO_LG" title="Mantenimiento de Contrato legal" %>
<%@ Register Src="~/controlesContrato/ucMantCONTRATO_LG.ascx" TagName="ucMantCONTRATO_LG" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantCONTRATO_LG id="ucMantCONTRATO_LG1" TIPO_OPERACION="Ingreso" runat="server"></uc1:ucMantCONTRATO_LG>
</asp:Content>
