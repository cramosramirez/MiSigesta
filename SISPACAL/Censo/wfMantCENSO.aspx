<%@ Page Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantCENSO.aspx.vb" Inherits="wfMantCENSO" title="Mantenimiento de Censo" %>
<%@ Register Src="~/controlesCenso/ucMantCENSO.ascx" TagName="ucMantCENSO" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantCENSO id="ucMantCENSO1" runat="server"></uc1:ucMantCENSO>
</asp:Content>
