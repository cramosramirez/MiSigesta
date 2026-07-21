<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucReporteCatorcena.ascx.vb" Inherits="controles_ucReporteCatorcena" %>
<%@ Register Src="~/controles/ucBarraNavegacion.ascx" TagName="ucBarraNavegacion" TagPrefix="uc1" %>
<%@ Register Src="~/controles/ucCriterios.ascx" TagName="ucCriterios" TagPrefix="uc1" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<table id="TableMant" border="0" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td>
            <uc1:ucBarraNavegacion ID="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
        </td>
    </tr>
    <tr>
        <td align="center" class="EncabezadoSecciones">
            <asp:Label ID="lblTitulo" runat="server" style="Z-INDEX: 101" />
        </td>
    </tr>
    <tr>
        <td>
            <uc1:ucCriterios ID="ucCriterios1" runat="server"></uc1:ucCriterios>
        </td>
    </tr>
    <tr>
        <td>
            <hr />
        </td>
    </tr>
</table>
<table width="100%">
    <tr>
        <td>
            <CR:CrystalReportViewer ID="crvReportes" runat="server" AutoDataBind="true" HasToggleParameterPanelButton="false"      
                BestFitPage="False" HasCrystalLogo="False" HasToggleGroupTreeButton="false"  
                PrintMode="ActiveX" ToolPanelView="None" ToolPanelWidth="" Width="980px" />
        </td>
    </tr>
</table>

