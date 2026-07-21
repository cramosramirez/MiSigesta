<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfMapaPlanCosecha01.aspx.vb" Inherits="Mapas_wfMapaPlanCosecha01" %>

<%@ Register Assembly="DevExpress.XtraCharts.v14.2.Web, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>











<%@ Register assembly="DevExpress.XtraCharts.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts" tagprefix="cc1" %>
<%@ Register Src="~/controles/ucBarraNavegacion.ascx" TagName="ucBarraNavegacion" TagPrefix="uc1" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script src="SigestaMapa.js" type="text/javascript"></script>
<style type="text/css">  
   .contenedorLogin
    { 
        width: 99%;
        height:44px;         
        padding: 5px; 
        font-size: small;                
	    border-radius: 7px;
	    border: 1px solid #999999;		    
        -moz-border-radius: 7px;
        -webkit-border-radius: 7px;
        -moz-box-shadow: 0px 1px 2px rgba(000,000,000,0.5), inset 0px 1px 0px rgba(255,255,255,1);
        -webkit-box-shadow: 0px 1px 2px rgba(000,000,000,0.5), inset 0px 0px 0px rgba(255,255,255,1);    
        box-shadow: 0px 1px 2px rgba(000,000,000,0.5), inset 0px 1px 0px rgba(255,255,255,1);          
        }    
</style>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">    
        <style type="text/css">
          html { height: 100% }
          body { height: 100%; margin: 0px; padding: 0px }
          #map_canvas { width: 100%; height: 85%; border-width:1px; border-style:inset; border-color:Navy }
        </style>
        <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
        <script type="text/javascript" src="http://maps.google.com/maps/api/js?key=AIzaSyDIJ9XX2ZvRKCJcFRrl-lRanEtFUow4piM&callback=InicializarMapa"></script>  
        <title>SIGESTA - Planeacion de Cosecha</title>  
    </head>
    
    <script type="text/javascript" language="javascript" >
        function OnEndCallback(s, e) {
            if (postponedCallbackValue != null) {
                cpMapa.PerformCallback(postponedCallbackValue);
                postponedCallbackValue = null;
            }
            else {
                //  Llenar mapa de Google con la infomación obtenida
                Cargando(false);
                if (s.cpResultCallback != undefined) {
                    if (s.cpResultCallback == 'LlenarMapa') {
                        Ingenio.imagen = s.cpImagenIngenio;
                        LimpiarMapa();                                                
                        for (i in s.cpCapas) {
                            if (s.cpCapas[i] == 'CapaSubZonas') {
                                AgregarArea(s.cpCapaZubZonas);
                            }
                            if (s.cpCapas[i] == 'CapaZonas') {
                                AgregarArea(s.cpCapaZonas);
                            }
                            if (s.cpCapas[i] == 'CapaCantones') {
                                AgregarArea(s.cpCapaCantones);
                            }
                            if (s.cpCapas[i] == 'CapaMunicipios') {
                                AgregarArea(s.cpCapaMunicipios);
                            }
                            if (s.cpCapas[i] == 'CapaDepartamentos') {
                                AgregarArea(s.cpCapaDepartamentos);
                            }
                        }
                    }
                    if (s.cpResultCallback == 'PopupInfo') {
                        popupInfo.Show();
                    }   
                }                  
            }
        }
        function CargarMapa() {
            if (cbxCENSO.GetValue() == null) {
                AsignarMensaje('Seleccione un censo');
            }
            else {
                Cargando(true);
                cpMapa.PerformCallback('LlenarMapa');
            }            
        }
        function AsignarMensaje(mensaje) {
            pcMessageBoxBoton.SetVisible(true);
            aspxMensajeAlerta.SetText(mensaje);
            pcMessageBox.Show();
            pcMessageBox.UpdatePosition();
        }
    </script>
    <body onload="InicializarMapa()" style="margin:0px 10px 10px 10px;scroll='no'"   >
            <form id="form1" runat="server">               
                    <div class="contenedorLogin">
                        <div style="float:left">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/logoINJIBOA01.jpeg" AlternateText="" />
                        </div>
                        <div style="float:right">
                                <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">
                                <AnonymousTemplate>
                                    [ <a href="~/Login.aspx" ID="HeadLoginStatus" runat="server">Iniciar Sesión</a> ]
                                </AnonymousTemplate>
                                <LoggedInTemplate>          
                                    <span class="mensaje1">Bienvenido(a):</span><span class="bold"><asp:LoginName ID="HeadLoginName" runat="server" /></span>
                                    [ <asp:LoginStatus ID="HeadLoginStatus" runat="server" LogoutAction="Redirect" LogoutText="Cerrar Sesión" OnLoggedOut="LoginStatus_LoggedOut" LogoutPageUrl="~/"/> ]
                                </LoggedInTemplate>
                            </asp:LoginView> 
                        </div>                
                    </div>      
                    <div style="background: #7795BD url('../imagenes/fase2/fondo_menu.png') repeat-x; border-right: 1px solid #8BA0BC; border-bottom: 1px solid #8BA0BC" >     
                        <dx:ASPxMenu ID="ASPxMenu1" runat="server" ></dx:ASPxMenu>
                    </div>
                    <uc1:ucBarraNavegacion ID="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
                    <table>
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Zafra:"/></td>
                                        <td><dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" 
                                            ValueField="ID_ZAFRA" AutoPostBack="true" TextField="NOMBRE_ZAFRA"  Width="120px" >               
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Censo:"/></td>
                                        <td>
                                            <dx:ASPxComboBox ID="cbxCENSO" ClientInstanceName="cbxCENSO" runat="server" ValueType="System.Int32" DataSourceID="odsCenso"
                                            ValueField="ID_CENSO" TextField="FECHA_CENSO"  Width="120px"  >                                                                    
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Tipo de mapa:" /></td>
                                        <td>
                                            <dx:ASPxComboBox runat="server" ID="cbxTipoMapa" AutoPostBack="true" ValueType="System.Int32" Width="150px" >
                                                <Items>
                                                    <dx:ListEditItem Text="Mapa de Tercios" Value="1" Selected="true"/>
                                                    <dx:ListEditItem Text="Mapa de Tipo de Caña" Value="2" />                                            
                                                </Items>
                                            </dx:ASPxComboBox>
                                        </td>                    
                                    </tr>                           
                                    <tr align="left">
                                        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Tercio:"/></td>
                                        <td>
                                            <dx:ASPxComboBox runat="server" ID="cbxTERCIO" ValueType="System.Int32" Width="120px" >
                                                <Items>
                                                    <dx:ListEditItem Text="[Todos]" Value="-1" Selected="true"/>
                                                    <dx:ListEditItem Text="1" Value="1" />
                                                    <dx:ListEditItem Text="2" Value="2" />
                                                    <dx:ListEditItem Text="3" Value="3" />
                                                </Items>
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td><dx:ASPxLabel ID="ASPxLabel21" runat="server" Text="Sub Tercio:" /></td>                  
                                        <td><dx:ASPxComboBox runat="server" ID="cbxSUB_TERCIO" Width="120px" /></td> 
                                        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Tipo de Caña:"/></td>                                            
                                        <td><dx:ASPxComboBox runat="server" ID="cbxTIPO" DataSourceID="odsTiposCana" 
                                                ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO" 
                                                AutoPostBack="true" Width="150px" Height="16px" >           
                                                </dx:ASPxComboBox>
                                        </td>
                                        <td><dx:ASPxLabel ID="ASPxLabel20" runat="server" Text="Sub Tipo de Caña:">
                                            </dx:ASPxLabel></td>
                                        <td><dx:ASPxComboBox runat="server" ID="cbxSUB_TIPO" ValueType="System.Int32" 
                                                ValueField="ID_TIPO" TextField="NOM_TIPO" Width="120px" Height="16px" >           
                                                </dx:ASPxComboBox>
                                        </td>  
                                    </tr>                                           
                                </table> 
                             </td>
                             <td>                            
                                <dx:ASPxRoundPanel ID="ASPxRoundPanel1" HeaderText="Representación" ShowHeader="false" runat="server" Width="200px">                             
                                    <ContentPaddings Padding="0px" PaddingBottom="0px" PaddingLeft="0px" 
                                        PaddingRight="0px" PaddingTop="0px" />
                                    <PanelCollection>
                                        <dx:PanelContent runat="server">
                                            <table>
                                                <tr>
                                                    <td><img alt="Verde" src="../imagenes/mapa/punto_verdeA.png" /></td>
                                                    <td><dx:ASPxLabel ID="lblRepVerde" runat="server" Text="1° Tercio" /></td>
                                                </tr>
                                                <tr>
                                                    <td><img alt="Azul" src="../imagenes/mapa/punto_azulA.png" /></td>
                                                    <td><dx:ASPxLabel ID="lblRepAzul" runat="server" Text="2° Tercio" /></td>
                                                </tr>
                                                <tr>
                                                    <td><img alt="Rojo" src="../imagenes/mapa/punto_rojoA.png" /></td>
                                                    <td><dx:ASPxLabel ID="lblRepRojo" runat="server" Text="3° Tercio" /></td>
                                                </tr>
                                             </table>
                                        </dx:PanelContent>
                                    </PanelCollection>
                                </dx:ASPxRoundPanel>
                             </td>
                          </tr>
                    </table>  
                    <dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" ClientInstanceName="ldpCargando" runat="server" Modal="True" Text="Cargando..." >
                    </dx:ASPxLoadingPanel>  



                    <dx:ASPxPopupControl ID="pcMessageBox" ClientInstanceName="pcMessageBox" runat="server"
                            Modal="true" ShowOnPageLoad="false" AppearAfter="0" HeaderText="Mensaje" Height="100px"
                            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Text=""
                            Width="200px" AllowDragging="True" AllowResize="True" CloseAction="CloseButton"
                            PopupAction="None">
                            <ContentStyle HorizontalAlign="Center">
                            </ContentStyle>
                            <ContentCollection>
                                <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                                    <dx:ASPxLabel ID="aspxMensajeAlerta" runat="server" ClientInstanceName="aspxMensajeAlerta">
                                    </dx:ASPxLabel>
                                    <br />
                                    <br />
                                    <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Aceptar" AutoPostBack="False" ClientInstanceName="pcMessageBoxBoton" CausesValidation="False"
                                        UseSubmitBehavior="False">
                                        <ClientSideEvents Click="function(s, e) { pcMessageBox.Hide();}" />
                                    </dx:ASPxButton>
                                </dx:PopupControlContentControl>
                            </ContentCollection>
                    </dx:ASPxPopupControl>

                    <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
                    </asp:ObjectDataSource>       
                    <asp:ObjectDataSource ID="odsCenso" runat="server" 
                        TypeName="SISPACAL.BL.cCENSO" SelectMethod="ObtenerListaPorZAFRA">    
                      <SelectParameters>
                         <asp:ControlParameter ControlID="cbxZAFRA" Name="ID_ZAFRA" PropertyName="Value" Type="Int32" />
                         <asp:Parameter Name="recuperarHijas" DefaultValue="false" Type="Boolean" />     
                         <asp:Parameter Name="recuperarForaneas" DefaultValue="false" Type="Boolean" />     
                         <asp:Parameter Name="asColumnaOrden" DefaultValue="FECHA_CENSO" Type="String" />
                         <asp:Parameter Name="asTipoOrden" DefaultValue="ASC" Type="String" />
                      </SelectParameters> 
                      </asp:ObjectDataSource>
                      <asp:ObjectDataSource ID="odsTiposCana" runat="server" 
                        TypeName="SISPACAL.BL.cTIPOS_GENERALES" SelectMethod="RecuperarPorTipo" 
                        OldValuesParameterFormatString="original_{0}" >    
                      <SelectParameters>    
                         <asp:Parameter Name="agregarVacio" DefaultValue="False" Type="Boolean"  />
                         <asp:Parameter Name="agregarTodos" DefaultValue="True" Type="Boolean" />  
                         <asp:Parameter Name="ID_TIPO" DefaultValue="-1" Type="Int32" />     
                         <asp:Parameter Name="ID_TIPO_TABLA" DefaultValue="1" Type="Int32" />     
                         <asp:Parameter Name="ID_TIPO_PADRE" DefaultValue="-1" Type="Int32" />     
                      </SelectParameters> 
                     </asp:ObjectDataSource>
                      <asp:ObjectDataSource ID="odsGrafico" runat="server" 
                        OldValuesParameterFormatString="original_{0}" 
                        SelectMethod="ObtenerDataSetEntregaPorCatorcena" TypeName="SISPACAL.BL.cMapa">
                        <SelectParameters>
                            <asp:Parameter Name="NOMBRE_ZAFRA" Type="String" />
                            <asp:Parameter Name="CODI_DEPTO" Type="String" />
                            <asp:Parameter Name="CODI_MUNI" Type="String" />
                            <asp:Parameter Name="CODI_CANTON" Type="String" />
                            <asp:Parameter Name="ZONA" Type="String" />
                            <asp:Parameter Name="SUB_ZONA" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="odsRendimiento" runat="server" 
                        OldValuesParameterFormatString="original_{0}" 
                        SelectMethod="ObtenerDataSetRendimientoPorCatorcena" TypeName="SISPACAL.BL.cMapa">
                        <SelectParameters>
                            <asp:Parameter Name="NOMBRE_ZAFRA" Type="String" />
                            <asp:Parameter Name="CODI_DEPTO" Type="String" />
                            <asp:Parameter Name="CODI_MUNI" Type="String" />
                            <asp:Parameter Name="CODI_CANTON" Type="String" />
                            <asp:Parameter Name="ZONA" Type="String" />
                            <asp:Parameter Name="SUB_ZONA" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                       

                     <asp:ObjectDataSource ID="odsGraficoEntregaTercio" runat="server" 
                        OldValuesParameterFormatString="original_{0}" 
                        SelectMethod="ObtenerDataSetEntregaPorTercio" TypeName="SISPACAL.BL.cMapa">
                        <SelectParameters>
                            <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
                            <asp:Parameter Name="CODI_DEPTO" Type="String" />
                            <asp:Parameter Name="CODI_MUNI" Type="String" />
                            <asp:Parameter Name="CODI_CANTON" Type="String" />
                            <asp:Parameter Name="ZONA" Type="String" />
                            <asp:Parameter Name="SUB_ZONA" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="odsGraficoRendimientoTercio" runat="server" 
                        OldValuesParameterFormatString="original_{0}" 
                        SelectMethod="ObtenerDataSetRendimientoPorTercio" TypeName="SISPACAL.BL.cMapa">
                        <SelectParameters>
                            <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
                            <asp:Parameter Name="CODI_DEPTO" Type="String" />
                            <asp:Parameter Name="CODI_MUNI" Type="String" />
                            <asp:Parameter Name="CODI_CANTON" Type="String" />
                            <asp:Parameter Name="ZONA" Type="String" />
                            <asp:Parameter Name="SUB_ZONA" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
            
                <dx:ASPxCallbackPanel runat="server" ID="cpMapa" ShowLoadingPanel="false" ClientInstanceName="cpMapa" >                    
                    <ClientSideEvents EndCallback="OnEndCallback"></ClientSideEvents>
                        <PanelCollection>
                            <dx:PanelContent ID="PanelContent20" runat="server"> 
                             <dx:ASPxPopupControl ID="popupInfo" ClientInstanceName="popupInfo" CloseAction="CloseButton" Width="1200px" 
                                runat="server" PopupHorizontalAlign="LeftSides" Modal="true" HeaderText="Información"   
                                PopupVerticalAlign="Below" EnableHierarchyRecreation="True" AllowDragging="True" >                                
                                <ContentCollection>
                                    <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server">
                                                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btOK">
                                                    <PanelCollection>
                                                        <dx:PanelContent ID="PanelContent1" runat="server">                                                                                                                         
                                                             <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server" ColCount="3">
                                                                <Items>                                                                                                                                 
                                                                    <dx:LayoutGroup GroupBoxDecoration="HeadingLine" 
                                                                        Caption="Contratado">
                                                                        <Items>
                                                                            <dx:LayoutItem Caption="Cañeros:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                                                                        <dx:ASPxLabel ID="lblCaneros" runat="server" Text="ASPxLabel" Width="100px" >
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                            <dx:LayoutItem Caption="Contratos:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                                                                        <dx:ASPxLabel ID="lblContratos" runat="server" Text="ASPxLabel" Width="100px">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                            <dx:LayoutItem Caption="Lotes:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                                                                        <dx:ASPxLabel ID="lblLotes" runat="server" Text="ASPxLabel" Width="100px">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                            <dx:LayoutItem Caption="Area:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                                                                        <dx:ASPxLabel ID="lblArea_Contratada" runat="server" Text="ASPxLabel">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                            <dx:LayoutItem Caption="Tc/Mz:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                                                                        <dx:ASPxLabel ID="lblTc_Mz_Contratada" runat="server" Text="ASPxLabel" Width="100px">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                            <dx:LayoutItem Caption="Total TC:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                                                                                        <dx:ASPxLabel ID="lblTC_Contratada" runat="server" Text="ASPxLabel" Width="100px">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                        </Items>
                                                                    </dx:LayoutGroup>
                                                                    <dx:LayoutGroup GroupBoxDecoration="HeadingLine" ShowCaption="True" Caption="Censo" >
                                                                        <Items>
                                                                            <dx:EmptyLayoutItem>
                                                                            </dx:EmptyLayoutItem>
                                                                            <dx:EmptyLayoutItem>
                                                                            </dx:EmptyLayoutItem>
                                                                            <dx:EmptyLayoutItem>
                                                                            </dx:EmptyLayoutItem>
                                                                            <dx:LayoutItem Caption="Area:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                                                                                        <dx:ASPxLabel ID="lblArea_Censo" runat="server" Text="ASPxLabel" Width="100px">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                            <dx:LayoutItem Caption="Tc/Mz:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                                                                                        <dx:ASPxLabel ID="lblTc_Mz_Censo" runat="server" Text="ASPxLabel" Width="100px">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                             <dx:LayoutItem Caption="Total TC:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">
                                                                                        <dx:ASPxLabel ID="lblTC_Censo" runat="server" Text="ASPxLabel" Width="100px">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                        </Items>
                                                                    </dx:LayoutGroup>          
                                                                    <dx:LayoutGroup GroupBoxDecoration="HeadingLine" ShowCaption="True" Caption="Entregado" >
                                                                        <Items>
                                                                            <dx:EmptyLayoutItem>
                                                                            </dx:EmptyLayoutItem>
                                                                            <dx:EmptyLayoutItem>
                                                                            </dx:EmptyLayoutItem>
                                                                            <dx:EmptyLayoutItem>
                                                                            </dx:EmptyLayoutItem>
                                                                            <dx:LayoutItem Caption="Area:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                                                                        <dx:ASPxLabel ID="lblArea_Entregada" runat="server" Text="ASPxLabel" Width="100px">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                            <dx:LayoutItem Caption="Tc/Mz:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                                                                        <dx:ASPxLabel ID="lblTc_Mz_Entregada" runat="server" Text="ASPxLabel" Width="100px">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                             <dx:LayoutItem Caption="Total TC:">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                                                                        <dx:ASPxLabel ID="lblTC_Entregada" runat="server" Text="ASPxLabel" Width="100px">
                                                                                        </dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                            </dx:LayoutItem>
                                                                        </Items>
                                                                    </dx:LayoutGroup>                                                                    
                                                                </Items>
                                                                 <SettingsItems VerticalAlign="Middle" />
                                                                 <SettingsItemCaptions VerticalAlign="Middle" />
                                                            </dx:ASPxFormLayout>  

                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                          <dxchartsui:WebChartControl ID="chartEntregaCanaCatorcena" runat="server" 
                                                                 CrosshairEnabled="True" Height="200px" Width="580px" 
                                                                 DataSourceID="odsGrafico" AppearanceNameSerializable="Gray" 
                                                                 PaletteBaseColorNumber="2" PaletteName="Default">                                                                                                                               
                                                                <diagramserializable>
                                                                    <cc1:XYDiagram>
                                                                        <axisx visibleinpanesserializable="-1" title-font="Tahoma, 10pt" 
                                                                            title-text="Catorcenas" title-visible="True">
                                                                            <label>
                                                                                <numericoptions precision="0" />
<NumericOptions Precision="0"></NumericOptions>
                                                                            </label>
<VisualRange AutoSideMargins="False" SideMarginsValue="0"></VisualRange>

<WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                                                                        </axisx>
                                                                        <axisy visibleinpanesserializable="-1" title-font="Tahoma, 10pt" 
                                                                            title-text="TC Entregada" title-visible="True">
                                                                        </axisy>
                                                                    </cc1:XYDiagram>
                                                                </diagramserializable>                                                                
                                                                <seriesserializable>
                                                                    <cc1:Series ArgumentDataMember="NO_CATORCENA" LegendText="Catorcena" 
                                                                        Name="Serie1" SeriesPointsSorting="Ascending" 
                                                                        ValueDataMembersSerializable="NETOTONEL" ArgumentScaleType="Numerical" 
                                                                        LabelsVisibility="True">
                                                                        <viewserializable>
                                                                            <cc1:AreaSeriesView MarkerVisibility="True">
                                                                            </cc1:AreaSeriesView>
                                                                        </viewserializable>
                                                                        <labelserializable>
                                                                            <cc1:PointSeriesLabel ResolveOverlappingMode="JustifyAllAroundPoint">
                                                                                <pointoptionsserializable>
                                                                                    <cc1:PointOptions>
                                                                                        <valuenumericoptions format="Number" />
<ValueNumericOptions Format="Number"></ValueNumericOptions>
                                                                                    </cc1:PointOptions>
                                                                                </pointoptionsserializable>
                                                                            </cc1:PointSeriesLabel>
                                                                        </labelserializable>
                                                                        <legendpointoptionsserializable>
                                                                            <cc1:PointOptions>
                                                                                <valuenumericoptions format="Number" />
<ValueNumericOptions Format="Number"></ValueNumericOptions>
                                                                            </cc1:PointOptions>
                                                                        </legendpointoptionsserializable>
                                                                    </cc1:Series>
                                                                </seriesserializable>
                                                                <seriestemplate>
                                                                    <viewserializable>
                                                                        <cc1:AreaSeriesView Transparency="0">
                                                                        </cc1:AreaSeriesView>
                                                                    </viewserializable>
                                                                </seriestemplate>
                                                                <titles>
                                                                    <cc1:ChartTitle Font="Tahoma, 10pt" Text="Entrega TC por Catorcena" />
                                                                </titles>
                                                             </dxchartsui:WebChartControl>     
                                                                    </td>
                                                                    <td>
                                                                         <dxchartsui:WebChartControl ID="chartEntregaCanaTercio" runat="server" 
                                                                 CrosshairEnabled="True" Height="200px" Width="580px" 
                                                                 DataSourceID="odsGraficoEntregaTercio" AppearanceNameSerializable="Gray" 
                                                                 PaletteBaseColorNumber="2" PaletteName="Default">                                                                                                                               
                                                                <diagramserializable>
                                                                    <cc1:XYDiagram>
                                                                        <axisx visibleinpanesserializable="-1" title-font="Tahoma, 10pt" 
                                                                            title-text="Tercios" title-visible="True">
                                                                            <label>
                                                                                <numericoptions precision="0" />
<NumericOptions Precision="0"></NumericOptions>
                                                                            </label>
<VisualRange AutoSideMargins="False" SideMarginsValue="0"></VisualRange>

<WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                                                                        </axisx>
                                                                        <axisy visibleinpanesserializable="-1" title-font="Tahoma, 10pt" 
                                                                            title-text="TC Entregada" title-visible="True">
                                                                        </axisy>
                                                                    </cc1:XYDiagram>
                                                                </diagramserializable>                                                                
                                                                <seriesserializable>
                                                                    <cc1:Series ArgumentDataMember="TERCIO" LegendText="Tercio" 
                                                                        Name="Serie1" SeriesPointsSorting="Ascending" 
                                                                        ValueDataMembersSerializable="NETOTONEL" ArgumentScaleType="Numerical" 
                                                                        LabelsVisibility="True">
                                                                        <viewserializable>
                                                                            <cc1:AreaSeriesView MarkerVisibility="True">
                                                                            </cc1:AreaSeriesView>
                                                                        </viewserializable>
                                                                        <labelserializable>
                                                                            <cc1:PointSeriesLabel ResolveOverlappingMode="JustifyAllAroundPoint">
                                                                                <pointoptionsserializable>
                                                                                    <cc1:PointOptions>
                                                                                        <valuenumericoptions format="Number" />
<ValueNumericOptions Format="Number"></ValueNumericOptions>
                                                                                    </cc1:PointOptions>
                                                                                </pointoptionsserializable>
                                                                            </cc1:PointSeriesLabel>
                                                                        </labelserializable>
                                                                        <legendpointoptionsserializable>
                                                                            <cc1:PointOptions>
                                                                                <valuenumericoptions format="Number" />
<ValueNumericOptions Format="Number"></ValueNumericOptions>
                                                                            </cc1:PointOptions>
                                                                        </legendpointoptionsserializable>
                                                                    </cc1:Series>
                                                                </seriesserializable>
                                                                <seriestemplate>
                                                                    <viewserializable>
                                                                        <cc1:AreaSeriesView Transparency="0">
                                                                        </cc1:AreaSeriesView>
                                                                    </viewserializable>
                                                                </seriestemplate>
                                                                <titles>
                                                                    <cc1:ChartTitle Font="Tahoma, 10pt" Text="Entrega TC por Tercio" />
                                                                </titles>
                                                             </dxchartsui:WebChartControl>     
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                         <dxchartsui:WebChartControl ID="chartRendCatorcena" runat="server" 
                                                                 CrosshairEnabled="True" Height="200px" Width="580px" 
                                                                 DataSourceID="odsRendimiento" AppearanceNameSerializable="Light" 
                                                                 PaletteBaseColorNumber="6" PaletteName="Verve">                                                                                                                               
                                                                <diagramserializable>
                                                                    <cc1:XYDiagram>
                                                                        <axisx visibleinpanesserializable="-1" title-font="Tahoma, 10pt" 
                                                                            title-text="Catorcenas" title-visible="True">
                                                                            <label>
                                                                                <numericoptions precision="0" />
<NumericOptions Precision="0"></NumericOptions>
                                                                            </label>
<VisualRange AutoSideMargins="False" SideMarginsValue="0"></VisualRange>

<WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                                                                        </axisx>
                                                                        <axisy visibleinpanesserializable="-1" title-font="Tahoma, 10pt" 
                                                                            title-text="Rendimiento" title-visible="True">
                                                                        </axisy>
                                                                    </cc1:XYDiagram>
                                                                </diagramserializable>                                                                
                                                                <seriesserializable>
                                                                    <cc1:Series ArgumentDataMember="NO_CATORCENA" LegendText="Rendimiento" 
                                                                        Name="Serie1" SeriesPointsSorting="Ascending" 
                                                                        ValueDataMembersSerializable="RENDIMIENTO" ArgumentScaleType="Numerical" 
                                                                        LabelsVisibility="True">
                                                                        <viewserializable>
                                                                            <cc1:AreaSeriesView MarkerVisibility="True">
                                                                            </cc1:AreaSeriesView>
                                                                        </viewserializable>
                                                                        <labelserializable>
                                                                            <cc1:PointSeriesLabel ResolveOverlappingMode="JustifyAllAroundPoint">
                                                                                <pointoptionsserializable>
                                                                                    <cc1:PointOptions>
                                                                                        <valuenumericoptions format="Number" />
<ValueNumericOptions Format="Number"></ValueNumericOptions>
                                                                                    </cc1:PointOptions>
                                                                                </pointoptionsserializable>
                                                                            </cc1:PointSeriesLabel>
                                                                        </labelserializable>
                                                                        <legendpointoptionsserializable>
                                                                            <cc1:PointOptions>
                                                                                <valuenumericoptions format="Number" />
<ValueNumericOptions Format="Number"></ValueNumericOptions>
                                                                            </cc1:PointOptions>
                                                                        </legendpointoptionsserializable>
                                                                    </cc1:Series>
                                                                </seriesserializable>
                                                                <seriestemplate>
                                                                    <viewserializable>
                                                                        <cc1:AreaSeriesView Transparency="0">
                                                                        </cc1:AreaSeriesView>
                                                                    </viewserializable>
                                                                </seriestemplate>
                                                                <titles>
                                                                    <cc1:ChartTitle Font="Tahoma, 10pt" Text="Rendimiento por Catorcena" />
                                                                </titles>
                                                             </dxchartsui:WebChartControl> 
                                                                    </td>
                                                                    <td>
                                                                         <dxchartsui:WebChartControl ID="chartRendTercio" runat="server" 
                                                                 CrosshairEnabled="True" Height="200px" Width="580px" 
                                                                 DataSourceID="odsGraficoRendimientoTercio" AppearanceNameSerializable="Light" 
                                                                 PaletteBaseColorNumber="6" PaletteName="Verve">                                                                                                                               
                                                                <diagramserializable>
                                                                    <cc1:XYDiagram>
                                                                        <axisx visibleinpanesserializable="-1" title-font="Tahoma, 10pt" 
                                                                            title-text="Tercios" title-visible="True">
                                                                            <label>
                                                                                <numericoptions precision="0" />
<NumericOptions Precision="0"></NumericOptions>
                                                                            </label>
<VisualRange AutoSideMargins="False" SideMarginsValue="0"></VisualRange>

<WholeRange AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                                                                        </axisx>
                                                                        <axisy visibleinpanesserializable="-1" title-font="Tahoma, 10pt" 
                                                                            title-text="Rendimiento" title-visible="True">
                                                                        </axisy>
                                                                    </cc1:XYDiagram>
                                                                </diagramserializable>                                                                
                                                                <seriesserializable>
                                                                    <cc1:Series ArgumentDataMember="TERCIO" LegendText="Rendimiento" 
                                                                        Name="Serie1" SeriesPointsSorting="Ascending" 
                                                                        ValueDataMembersSerializable="RENDIMIENTO" ArgumentScaleType="Numerical" 
                                                                        LabelsVisibility="True">
                                                                        <viewserializable>
                                                                            <cc1:AreaSeriesView MarkerVisibility="True">
                                                                            </cc1:AreaSeriesView>
                                                                        </viewserializable>
                                                                        <labelserializable>
                                                                            <cc1:PointSeriesLabel ResolveOverlappingMode="JustifyAllAroundPoint">
                                                                                <pointoptionsserializable>
                                                                                    <cc1:PointOptions>
                                                                                        <valuenumericoptions format="Number" />
<ValueNumericOptions Format="Number"></ValueNumericOptions>
                                                                                    </cc1:PointOptions>
                                                                                </pointoptionsserializable>
                                                                            </cc1:PointSeriesLabel>
                                                                        </labelserializable>
                                                                        <legendpointoptionsserializable>
                                                                            <cc1:PointOptions>
                                                                                <valuenumericoptions format="Number" />
<ValueNumericOptions Format="Number"></ValueNumericOptions>
                                                                            </cc1:PointOptions>
                                                                        </legendpointoptionsserializable>
                                                                    </cc1:Series>
                                                                </seriesserializable>
                                                                <seriestemplate>
                                                                    <viewserializable>
                                                                        <cc1:AreaSeriesView Transparency="0">
                                                                        </cc1:AreaSeriesView>
                                                                    </viewserializable>
                                                                </seriestemplate>
                                                                <titles>
                                                                    <cc1:ChartTitle Font="Tahoma, 10pt" Text="Rendimiento por Tercio" />
                                                                </titles>
                                                             </dxchartsui:WebChartControl> 
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                          
                                                             
                                                             
                                                                                                                                                                                                                                    
                                                        </dx:PanelContent>
                                                    </PanelCollection>
                                                </dx:ASPxPanel>
                                    </dx:PopupControlContentControl>
                                </ContentCollection>
                            </dx:ASPxPopupControl>
                            </dx:PanelContent>
                        </PanelCollection>
                </dx:ASPxCallbackPanel> 
            </form> 
            <div id="map_canvas"></div>     
    </body>
</html>




