<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCONTRATO_LG.ascx.vb" Inherits="controles_ucMantCONTRATO_LG" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTRATO_LG" Src="~/controlesContrato/ucListaCONTRATO_LG.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTRATO_LG" Src="~/controlesContrato/ucVistaDetalleCONTRATO_LG.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>





<%@ Register TagPrefix="uc1" TagName="ucListaMAESTRO_LOTES" Src="~/controlesContrato/ucListaMAESTRO_LOTES.ascx" %>

<script type="text/javascript">
    var postponedCallbackRequired = false;

    function CrearProveedor() {
        window.open("../Contratos/wfMantPROVEEDOR.aspx?op=1", "_blank", "")
    }
    function CrearSocio() {
        window.open("../Contratos/wfMantPROVEEDOR.aspx?op=2", "_blank", "")
    }
    function CrearLote() {
        window.open("../Contratos/wfMantMAESTRO_LOTES.aspx?op=1", "_blank", "")
    }
    function EditarLote(idmaestro) {
        window.open("../Contratos/wfMantMAESTRO_LOTES.aspx?op=2&id=" + idmaestro, "_blank", "")
    }
    function CrearContrato() {
        ldpCargando.Show();
        cpMantCONTRATO_LG.PerformCallback('CrearContrato');
    }
    function GuardarContrato() {
        ldpCargando.Show();
        cpMantCONTRATO_LG.PerformCallback('GuardarContrato');
    }
    function MostrarLotes() {
        ldpCargando.Show();
        cpMantCONTRATO_LG.PerformCallback('MostrarLotes');
    }
    function ObtenerSocio() {
        cpMantCONTRATO_LG.PerformCallback('ObtenerSocio');
    }
    function AgregarLotes(e) {
        ldpCargando.Show();
        cpMantCONTRATO_LG.PerformCallback('AgregarLotes;' + e.toString());
    }
    function OnEndCallback(s, e) {
        AsignarError('');
        ldpCargando.Hide();
        if (s.cpOpcion == 'MostrarLotes')
            pcMaestroLotes.Show();
        if (s.cpOpcion == 'Error')
            AsignarError(s.cpError);
        if (s.cpOpcion == 'CerrarAgregarLotes')
            pcMaestroLotes.Hide();      
        if (postponedCallbackRequired) {
            cpMantCONTRATO.PerformCallback();
            postponedCallbackRequired = false;
            }
    }   
</script>

<dx:ASPxCallbackPanel ID="cpMantCONTRATO_LG" ClientInstanceName="cpMantCONTRATO_LG" runat="server" ShowLoadingPanel="false" Width="100%" >
    <ClientSideEvents EndCallback="OnEndCallback" ></ClientSideEvents>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">   
<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
    <tr>
        <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Contratos legales</asp:Label></td>
    </tr>
    <tr>
        <td>
            <dx:ASPxFormLayout ID="ucCriteriosLotesLayout" ClientInstanceName="ucCriteriosLotesLayout" runat="server" EnableTheming="True" Width="200px" >
            <Items>
                <dx:LayoutGroup ColCount="4" Caption="Criterios de búsqueda"  
                    GroupBoxDecoration="HeadingLine" SettingsItemCaptions-Location="Left" 
                    Name="glCriterios">
                    <Items>
                        <dx:LayoutItem Caption="Zafra:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32">
                                    </dx:ASPxComboBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="N° Contrato:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">                           
                                    <dx:ASPxSpinEdit ID="txtNO_CONTRATO" runat="server" AllowNull="true" 
                                        AllowUserInput="true" ClientInstanceName="txtNO_CONTRATO" >                                        
                                    </dx:ASPxSpinEdit>     
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>        
                        <dx:LayoutItem Caption="Cod. Provee:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">                           
                                    <dx:ASPxSpinEdit ID="txtCODIPROVEE" runat="server" AllowNull="true" 
                                        AllowUserInput="true" ClientInstanceName="txtCODIPROVEE" >                                        
                                    </dx:ASPxSpinEdit>     
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>                        
                        <dx:LayoutItem Caption="Cod. Socio:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxSpinEdit ID="txtCODISOCIO" runat="server" 
                                        ClientInstanceName="txtCODISOCIO">                                        
                                    </dx:ASPxSpinEdit>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                    </Items>
                    <SettingsItemCaptions HorizontalAlign="Left" Location="Left" 
                        VerticalAlign="Middle" />
                    <SettingsItems HorizontalAlign="Right" VerticalAlign="Middle" />
                </dx:LayoutGroup>
            </Items>
            <SettingsItems ShowCaption="True" />
        </dx:ASPxFormLayout>
        </td>
    </tr>		  
    <tr>
        <td><uc1:ucListaCONTRATO_LG id="ucListaCONTRATO_LG1" VerCODISOCIO="false" PermitirVistaPrevia="true" runat="server"></uc1:ucListaCONTRATO_LG></td>
    </tr>
    <tr>
        <td><uc1:ucVistaDetalleCONTRATO_LG ID="ucVistaDetalleCONTRATO_LG1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTRATO_LG></td>
    </tr>                          
</table>

 <dx:ASPxPopupControl ID="pcMaestroLotes" ClientInstanceName="pcMaestroLotes" runat="server"
            Modal="true" AppearAfter="0" 
    HeaderText="Agregando lote" Height="100px"
            PopupHorizontalAlign="WindowCenter" 
    PopupVerticalAlign="WindowCenter" Text=""
            Width="900px" AllowDragging="True" AllowResize="True" CloseAction="CloseButton"
            PopupAction="None">
            <ContentStyle HorizontalAlign="Center"></ContentStyle>
            <ContentCollection>
                <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">           
                    <dx:ASPxLabel ID="lblErrorPopup" runat="server" ClientInstanceName="lblErrorPopup"  Text="" ForeColor="#CC0000" Font-Bold="True"></dx:ASPxLabel>         
                    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                        <Items>
                            <dx:LayoutGroup ColCount="3" ShowCaption="False" GroupBoxDecoration="None">
                                <Items>
                                    <dx:LayoutItem  Caption="Cod. Socio:" Name="CODISOCIOadd" >
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer004" runat="server">                                               
                                                <dx:ASPxSpinEdit ID="txtCODISOCIOadd" runat="server" Width="170px" >  
                                                    <ClientSideEvents ValueChanged="ObtenerSocio" />                              
                                                </dx:ASPxSpinEdit>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Nombre:" ColSpan="2" Name="NOMBRE_SOCIOadd" >
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer005" runat="server">
                                                <dx:ASPxTextBox ID="txtNOMBRE_SOCIOadd" Enabled="false" runat="server" Width="100%">
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>                                   
                                    <dx:LayoutItem Caption="Zafra:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer006" runat="server">
                                                <dx:ASPxComboBox ID="cbxZAFRAadd" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" runat="server">
                                                     <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                        <RequiredField ErrorText="Zafra obligatoria" IsRequired="True" />
                                                    </ValidationSettings>
                                                </dx:ASPxComboBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="MZ:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer007" runat="server">
                                                <dx:ASPxTextBox ID="txtMZadd" runat="server" Width="170px">
                                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                        <RequiredField ErrorText="Area obligatoria" IsRequired="True" />
                                                    </ValidationSettings>
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="TC:">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer008" runat="server">
                                                <dx:ASPxTextBox ID="txtTCadd" runat="server" Width="170px">
                                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                        <RequiredField ErrorText="TC obligatoria" IsRequired="True" />
                                                    </ValidationSettings>
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                        </Items>
                    </dx:ASPxFormLayout>        
                    <uc1:ucListaMAESTRO_LOTES id="ucListaMAESTRO_LOTES1" runat="server" PermitirEditar="false" PermitirEliminar="false" VerCODIPROVEEDOR="false"  
                             VerCODI_DEPTO="false" VerCODI_MUNI="false" VerCODI_CANTON="false" VerCORRELATIVO="false" VerCODICONTRATO="false"   
                             VerMZ_CULTIVADA="false" VerCODIVARIEDA="false" VerID_COMPOR="false" VerCOD_TIPO_SUELO="false" VerCODIPROVEE="false"
                             VerID_COND_SIEMBRA="false" VerID_NIVEL_HUMEDAD="false" VerNO_CORTE="false" VerMSNM="false" VerCODISOCIO="false" 
                             VerKM_CARRETERA="false" VerKM_TIERRA="false" VerRIESGO_PIEDRA="false" VerFECHA_SIEMBRA="false" VerNOMBRE_PROVEEDOR="false" 
                             VerFECHA_CORTE="false" VerPROD_TC="false" VerPROD_LB="false" VerFACTOR_DESPOBLA="false" PermitirSeleccionar="true" ComandoSeleccionar="Check"   
                             VerUSUARIO_CREA="false" VerFECHA_CREA="false" VerUSUARIO_ACT="false" VerFECHA_ACT="false" ></uc1:ucListaMAESTRO_LOTES>            
                    <dx:ASPxButton ID="btnAceptar1" runat="server" Text="Agregar" AutoPostBack="False" ClientInstanceName="btnAceptar" CausesValidation="True"
                        UseSubmitBehavior="False">
                        <ClientSideEvents Click="function(s,e){AgregarLotes(0);}" />
                    </dx:ASPxButton>
                     <dx:ASPxButton ID="btnAceptar2" runat="server" Text="Agregar y cerrar" AutoPostBack="False" ClientInstanceName="btnAceptarCerrar" CausesValidation="True"
                        UseSubmitBehavior="False">
                        <ClientSideEvents Click="function(s,e){AgregarLotes(1);}" />
                    </dx:ASPxButton>
                    <dx:ASPxButton ID="btnCancelar" runat="server" Text="Cerrar" AutoPostBack="False" ClientInstanceName="btnCancelar" CausesValidation="False"
                        UseSubmitBehavior="False">
                        <ClientSideEvents Click="function(s, e){pcMaestroLotes.Hide()}" />
                    </dx:ASPxButton>
                </dx:PopupControlContentControl>
            </ContentCollection>
</dx:ASPxPopupControl>
     </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>

<dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" ClientInstanceName="ldpCargando" runat="server" Modal="True" Text="Cargando..." >
</dx:ASPxLoadingPanel>

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

