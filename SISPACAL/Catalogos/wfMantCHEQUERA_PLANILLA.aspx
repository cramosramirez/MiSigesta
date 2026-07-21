<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantCHEQUERA_PLANILLA.aspx.vb" Inherits="wfMantCHEQUERA_PLANILLA" title="Mantenimiento de Chequera planilla" %>
<%@ Register Src="~/controles/ucMantCHEQUERA_PLANILLA.ascx" TagName="ucMantCHEQUERA_PLANILLA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>   
    <uc1:ucMantCHEQUERA_PLANILLA id="ucMantCHEQUERA_PLANILLA1" runat="server"></uc1:ucMantCHEQUERA_PLANILLA>
     </ContentTemplate>                 
    </asp:UpdatePanel>  
</asp:Content>
