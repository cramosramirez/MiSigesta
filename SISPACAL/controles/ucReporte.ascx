<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucReporte.ascx.vb" Inherits="controles_ucReporte" %>
<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriterios" Src="~/controles/ucCriterios.ascx" %>

<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tbody>
        <tr>
            <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td> 
        </tr>
        <tr>
            <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server" /></td>
        </tr>             
        <tr>
            <td><uc1:ucCriterios id="ucCriterios1" runat="server"></uc1:ucCriterios></td>            
        </tr>        
        <tr>
            <td><hr /></td>
        </tr>
    </tbody>
</table>
<table width="100%" >
    <tr>
        <td>        
           <CR:CrystalReportViewer  Width="980px" BestFitPage="False" ID="crvReportes" 
                runat="server" AutoDataBind="true" HasCrystalLogo="False" 
                HasToggleGroupTreeButton="false" ToolPanelView="None" 
                ToolPanelWidth="" />            
        </td>
    </tr>
</table>



