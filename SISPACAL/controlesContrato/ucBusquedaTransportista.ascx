<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucBusquedaTransportista.ascx.vb" Inherits="controlesContrato_ucBusquedaTransportista" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTRANSPORTISTA" Src="~/controles/ucListaTRANSPORTISTA.ascx" %>

<table>
    <tr>
        <td>
        <table>
            <tr>
                <td>
                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Nombre transportista:"></dx:ASPxLabel>
                </td>
                <td>
                    <dx:ASPxTextBox ID="txtNOMBRE_TRANSPORTISTA" AutoCompleteType="Disabled" runat="server" Width="300px"></dx:ASPxTextBox>
                </td>
                <td>
                    <dx:ASPxButton ID="btnBuscar" AutoPostBack="true" runat="server" Text="Buscar"></dx:ASPxButton>
                </td>
            </tr>
        </table>
        </td>
    </tr>
    <tr>
        <td>
             <uc1:ucListaTRANSPORTISTA id="ucListaTRANSPORTISTA1" runat="server" SeleccionarFilaSideServer="true" SeleccionarFilaPorClick="true" PermitirFilaDeFiltro="false" PermitirFocoEnFilas="true" PermitirFiltroEnEncabezado="false" PermitirSeleccionar="true" PermitirEditar="false" PermitirEditarInline="false" PermitirEliminar="false" 
              VerTELEFONO="false" VerDUI="false" VerNIT="true" verCREDITO_FISCAL="false" VerCOD_SIGASI_S="false" VerCOD_COMBUST_S="false" VerCREDITFISCAL="false" VerTIPO_CONTRIBUYENTE="false" VerCOD_SIGASI="false" VerNOCUENTA="false" VerCOD_COMBUST="false"  VerUSUARIO_CREA="false" VerFECHA_CREA="false" VerUSUARIO_ACT="false" VerFECHA_ACT="false"  ></uc1:ucListaTRANSPORTISTA>
        </td>
    </tr> 
    <tr>
        <td>
            <hr />
        </td>
    </tr> 
    <tr>
        <td>
            <table>
                <tr>
                    <td style="padding-right:20px" >
                        <dx:ASPxButton ID="btnAceptar" AutoPostBack="true" runat="server" Text="Aceptar"></dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnCancelar" AutoPostBack="true" runat="server" Text="Cancelar"></dx:ASPxButton>
                    </td>
                </tr>
            </table>
        </td>
    </tr> 
</table>