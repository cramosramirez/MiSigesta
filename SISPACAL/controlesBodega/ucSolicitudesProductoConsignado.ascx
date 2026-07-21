<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucSolicitudesProductoConsignado.ascx.vb" Inherits="controlesBodega_ucSolicitudesProductoConsignado" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSALBODE_DETA" Src="~/controlesBodega/ucListaSALBODE_DETA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosSolicitudesProductoConsignacion" Src="~/controlesBodega/ucCriteriosSolicitudesProductoConsignacion.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<table cellSpacing="0" cellPadding="0" width="100%">
    <tr>
        <td>
            <uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
        </td>                
    </tr>
    <tr>
        <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Productos en consignación solicitados para retiro</asp:Label></TD>        
    </tr>
    <tr>
        <td>
            <table>
                <tr>
                    <uc1:ucCriteriosSolicitudesProductoConsignacion runat="server" id="ucCriteriosSolicitudesProductoConsignacion1" />
                </tr>
            </table>
        </td>        
    </tr>
    <tr>        
        <td>
            <uc1:ucListaSALBODE_DETA id="ucListaSALBODE_DETA1" MostrarCheckVariaSeleccion="true" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" runat="server"
                VerCANT_ANULADA="true" VerFECHA_SOLIC="true" VerESTADO_SOLIC_AGRICOLA="true" VerESTADO="true" VerFECHA="true" VerNO_DOCUMENTO="true"   />
        </td>
    </tr>
</table>

<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />  
