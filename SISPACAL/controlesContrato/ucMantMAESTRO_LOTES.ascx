<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantMAESTRO_LOTES.ascx.vb" Inherits="controles_ucMantMAESTRO_LOTES" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>




<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaMAESTRO_LOTES" Src="~/controlesContrato/ucListaMAESTRO_LOTES.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleMAESTRO_LOTES" Src="~/controlesContrato/ucVistaDetalleMAESTRO_LOTES.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosLotes" Src="~/controlesContrato/ucCriteriosLotes.ascx" %>

<script type="text/javascript">
    var postponedCallbackRequired = false;

    function VistaPrevia() {
        var ZONA = '';
        var SUB_ZONA = '';
        var CODI_DEPTO = '';
        var CODI_MUNI = '';
        var CODI_CANTON = '';
        var CODIPROVEE = '';
        var CODISOCIO = '';
        var CODICONTRATO = '';
        if (cbxZONA.GetValue() != null)
            ZONA = cbxZONA.GetValue();
        if (cbxSUB_ZONA.GetValue() != null)
            SUB_ZONA = cbxSUB_ZONA.GetValue();
        if (cbxDEPARTAMENTO.GetValue() != null)
            CODI_DEPTO = cbxDEPARTAMENTO.GetValue();
        if (cbxMUNICIPIO.GetValue() != null)
            CODI_MUNI = cbxMUNICIPIO.GetValue();
        if (cbxCANTON.GetValue() != null)
            CODI_CANTON = cbxCANTON.GetValue();
        if (txtCODIPROVEE.GetValue() != null)
            CODIPROVEE = txtCODIPROVEE.GetValue();
        if (txtCODISOCIO.GetValue() != null)
            CODISOCIO = txtCODISOCIO.GetValue();
        if (spnCONTRATO.GetValue() != null)
            CONTRATO = spnCONTRATO.GetValue();
        window.open("../reportes/wfReporteModalDev.aspx?n=11&par=" + ZONA + ';' + SUB_ZONA + ';' + CODI_DEPTO + ';' + CODI_MUNI + ';' + CODI_CANTON + ';' + CODIPROVEE + ';' + CODISOCIO + ';' + CODICONTRATO, "_blank", "")
    }  
    function MostrarDetalle() {       
        ucVistaDetalleMAESTRO_LOTESLayout.SetVisible(true);
    }
    function CargarMaestroLotes(s, e) {           
        ldpCargando.Show();
        cpMantMAESTRO_LOTES.PerformCallback('CargarMaestroLotes;');
    }
    function GuardarMaestroLotes() {
        ldpCargando.Show();
        cpMantMAESTRO_LOTES.PerformCallback('GuardarMaestroLotes;');
    }

    function OnEndCallback(s, e) {
        ldpCargando.Hide();
        if (s.cpOpcion == 'Error')
            AsignarError(s.cpError);
        if (postponedCallbackRequired) {
            cpMantMAESTRO_LOTES.PerformCallback();
            postponedCallbackRequired = false;
        }
    }   
</script>

<dx:ASPxCallbackPanel ID="cpMantMAESTRO_LOTES" ClientInstanceName="cpMantMAESTRO_LOTES" runat="server" ShowLoadingPanel="false" Width="100%" >
    <ClientSideEvents EndCallback="OnEndCallback" ></ClientSideEvents>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">   
            <table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
                      <tr><td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td></tr>
                      <tr><td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">Mantenimiento de Maestro de Lotes</asp:Label></td></tr>
                      <tr><td><uc1:ucCriteriosLotes id="ucCriteriosLotes1" runat="server"></uc1:ucCriteriosLotes></td></tr>    
		              <tr>
                        <td>
                            <uc1:ucListaMAESTRO_LOTES id="ucListaMAESTRO_LOTES1" PermitirEditar="true" PermitirEliminar="true" PermitirSeleccionar="true" runat="server" VerCODIPROVEEDOR="false"  
                             VerCODI_DEPTO="false" VerCODI_MUNI="false" VerCODI_CANTON="false" VerCORRELATIVO="false"
                             VerMZ_CULTIVADA="false" VerCODIVARIEDA="false" VerID_COMPOR="false" VerCOD_TIPO_SUELO="false"
                             VerID_COND_SIEMBRA="false" VerID_NIVEL_HUMEDAD="false" VerNO_CORTE="false" VerMSNM="false"
                             VerKM_CARRETERA="false" VerKM_TIERRA="false" VerRIESGO_PIEDRA="false" VerFECHA_SIEMBRA="false"
                             VerFECHA_CORTE="false" VerPROD_TC="false" VerPROD_LB="false" VerFACTOR_DESPOBLA="false"
                             VerUSUARIO_CREA="false" VerFECHA_CREA="false" VerUSUARIO_ACT="false" VerFECHA_ACT="false" ></uc1:ucListaMAESTRO_LOTES>
                        </td>
                      </tr>
                      <tr>
                        <td>
                        <uc1:ucVistaDetalleMAESTRO_LOTES ID="ucVistaDetalleMAESTRO_LOTES1" runat="server"></uc1:ucVistaDetalleMAESTRO_LOTES>
                        </td>
                      </tr>
            </table>

            <dx:ASPxPopupControl ID="pcLotesPorCanton" runat="server" CloseAction="CloseButton" Modal="True" Width="1000px"
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcLogin"
                    HeaderText="Lotes que pertencen al cantón" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
                    <ContentCollection>
                        <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                            <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btOK">
                                <PanelCollection>
                                    <dx:PanelContent ID="PanelContent1" runat="server">
                                    <dx:ASPxLabel ID="lblpcMensaje" runat="server" Text="" Font-Bold="true" ForeColor="Red">
                                    </dx:ASPxLabel>
                                    <hr />
                                    <uc1:ucListaMAESTRO_LOTES id="ucListaMAESTRO_LOTES2" PermitirEliminar="false" PermitirSeleccionar="false" runat="server" VerCODIPROVEEDOR="false" 
                                         PermitirEditar="false" PermitirMostrar="true" TamanoPagina="10" 
                                         VerCODI_DEPTO="false" VerNOMBRE_DEPARTAMENTO="false" VerNOMBRE_MUNICIPIO="false" VerNOMBRE_CANTON="false" VerCODI_MUNI="false" VerCODI_CANTON="false" VerCORRELATIVO="false"
                                         VerMZ_CULTIVADA="false" VerCODIVARIEDA="false" VerID_COMPOR="false" VerCOD_TIPO_SUELO="false"
                                         VerID_COND_SIEMBRA="false" VerID_NIVEL_HUMEDAD="false" VerNO_CORTE="false" VerMSNM="false"
                                         VerKM_CARRETERA="false" VerKM_TIERRA="false" VerRIESGO_PIEDRA="false" VerFECHA_SIEMBRA="false"
                                         VerFECHA_CORTE="false" VerPROD_TC="false" VerPROD_LB="false" VerFACTOR_DESPOBLA="false"
                                         VerUSUARIO_CREA="false" VerFECHA_CREA="false" VerUSUARIO_ACT="false" VerFECHA_ACT="false" ></uc1:ucListaMAESTRO_LOTES>
                                    </dx:PanelContent>
                                </PanelCollection>
                            </dx:ASPxPanel>
                        </dx:PopupControlContentControl>
                    </ContentCollection>
            </dx:ASPxPopupControl>
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" ClientInstanceName="ldpCargando" runat="server" Modal="True" Text="Cargando..." >
</dx:ASPxLoadingPanel>

