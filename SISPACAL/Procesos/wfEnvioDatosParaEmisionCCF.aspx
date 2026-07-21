<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfEnvioDatosParaEmisionCCF.aspx.vb" Inherits="Procesos_wfEnvioDatosParaEmisionCCF" %>
<%@ Register Src="~/controlesFinanciero/ucEnvioDatosParaEmisionCCF_Prod_Trans.ascx" TagName="ucEnvioDatosParaEmisionCCF_Prod_Trans" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <ContentTemplate>    
        <uc1:ucEnvioDatosParaEmisionCCF_Prod_Trans id="ucEnvioDatosParaEmisionCCF_Prod_Trans1"  runat="server"></uc1:ucEnvioDatosParaEmisionCCF_Prod_Trans>
    </ContentTemplate> 
</asp:Content>

