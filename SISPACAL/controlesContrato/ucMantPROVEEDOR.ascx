<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPROVEEDOR.ascx.vb" Inherits="controles_ucMantPROVEEDOR" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPROVEEDOR" Src="~/controlesContrato/ucListaPROVEEDOR.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePROVEEDOR" Src="~/controlesContrato/ucVistaDetallePROVEEDOR.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOCIO" Src="~/controlesContrato/ucVistaDetalleSOCIO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosProveedor" Src="~/controlesContrato/ucCriteriosProveedor.ascx" %>

<script type="text/javascript">
//    var postponedCallbackRequired = false;

//    function MostrarDetalle() {
//        ucVistaDetallePROVEEDORLayout.SetVisible(true);
//    }
//    function AgregarProveedor(s, e) {
//        ldpCargando.Show();
//        cpMantPROVEEDOR.PerformCallback('AgregarProveedor;');

//    }
//    function CargarProveedores(s, e) {
//        ldpCargando.Show();
//        cpMantPROVEEDOR.PerformCallback('CargarProveedores;');

//    }
//    function EditarProveedor(e) {
//        ldpCargando.Show();
//        cpMantPROVEEDOR.PerformCallback('EditarProveedor;' + e);
//    }
//    function CancelarEdicion() {
//        ldpCargando.Show();
//        cpMantPROVEEDOR.PerformCallback('CancelarEdicion;');
//    }
//    function GuardarProveedor() {
//        ldpCargando.Show();
//        cpMantPROVEEDOR.PerformCallback('GuardarProveedor;');
//    }

    function OnEndCallback(s, e) {
        AsignarError('');
        if (s.cpOpcion == 'AgregarProveedor' || s.cpOpcion == 'EditarProveedor' || s.cpOpcion == 'ErrorGuardar') {
            ucVistaDetallePROVEEDORLayout.SetVisible(true);
            if (s.cpOpcion == 'ErrorGuardar')
                AsignarError(s.cpError);
        }
        else
            ucVistaDetallePROVEEDORLayout.SetVisible(false);
        ldpCargando.Hide();
        if (postponedCallbackRequired) {
            cpMantproveedor.PerformCallback();
            postponedCallbackRequired = false;
        }
    }   
</script>

<dx:ASPxCallbackPanel ID="cpMantPROVEEDOR" ClientInstanceName="cpMantPROVEEDOR" runat="server" ShowLoadingPanel="false" Width="100%" >
    <ClientSideEvents EndCallback="OnEndCallback" ></ClientSideEvents>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">   
            <table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
                      <tr><td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td></tr>
                      <tr><td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">Mantenimiento de Proveedores/Socios</asp:Label></td></tr>
                      <tr><td><uc1:ucCriteriosProveedor id="ucCriteriosProveedor1" runat="server"></uc1:ucCriteriosProveedor></td></tr>    
		              <tr>
                        <td>
                            <uc1:ucListaPROVEEDOR id="ucListaPROVEEDOR1" runat="server" PermitirSeleccionar="true" PermitirEliminar="true" 
                             VerUSUARIO_CREA="false" VerFECHA_CREA="false" VerUSUARIO_ACT="false" VerFECHA_ACT="false"  ></uc1:ucListaPROVEEDOR>
                        </td>
                      </tr>
                      <tr>
                        <td>
                        <uc1:ucVistaDetallePROVEEDOR ID="ucVistaDetallePROVEEDOR1" runat="server" ></uc1:ucVistaDetallePROVEEDOR>
                        <uc1:ucVistaDetalleSOCIO ID="ucVistaDetalleSOCIO1" runat="server" ></uc1:ucVistaDetalleSOCIO>
                        </td>
                       </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" ClientInstanceName="ldpCargando" runat="server" Modal="True" Text="Cargando..." >
</dx:ASPxLoadingPanel>




<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="true" KeyFieldName="CODIPROVEEDOR" Visible="false" >      
</dx:ASPxGridView>
<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>


