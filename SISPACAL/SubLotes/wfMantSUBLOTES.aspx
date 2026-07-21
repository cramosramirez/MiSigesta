<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfMantSUBLOTES.aspx.vb" Inherits="SubLotes_wfMantSUBLOTES" %>
<%@ Register Src="~/controlesSubLote/ucMantSUBLOTES.ascx" TagName="ucMantSUBLOTES" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
       <uc1:ucMantSUBLOTES id="ucMantSUBLOTES1" runat="server"></uc1:ucMantSUBLOTES>
</asp:Content>

