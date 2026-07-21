<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfMapaES.aspx.vb" Inherits="Mapas_wfMapaES" %>

<%@ Register Assembly="DevExpress.XtraCharts.v14.2.Web, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>











<%@ Register assembly="DevExpress.XtraCharts.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts" tagprefix="cc1" %>

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
    <head runat="server">    
        <style type="text/css">
          html { height: 100% }
          body { height: 100%; margin: 0px; padding: 0px }
          #map_canvas { width: 100%; height: 85%; border-width:1px; border-style:inset; border-color:Navy }
        </style>
        <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
        <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>  
        <title>SIGESTA - Mapa de Lotes de Caña</title>  
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
                }
                if (s.cpResultCallback == 'PopupInfo') {
                    popupInfo.Show();
                }                
            }
        }
    </script>
    <body onload="InicializarMapa()" style="margin: 0px 20px 10px 10px; scroll="no""  >
            <form id="form1" runat="server">               
                <div class="contenedorLogin">
                    <div style="float:left">
                        <asp:Image ID="Image1" runat="server" 
                            ImageUrl="~/imagenes/logoINJIBOA01.jpeg" AlternateText="" /></div>
                        <div style="float:right">
                            <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">
                            <AnonymousTemplate>
                                [ <a href="Login.aspx" ID="HeadLoginStatus" runat="server">Iniciar Sesión</a> ]
                            </AnonymousTemplate>
                            <LoggedInTemplate>          
                                <span class="mensaje1">Bienvenido(a):</span><span class="bold"><asp:LoginName ID="HeadLoginName" runat="server" /></span>
                                [ <asp:LoginStatus ID="HeadLoginStatus" runat="server" LogoutAction="Redirect" LogoutText="Cerrar Sesión" OnLoggedOut="LoginStatus_LoggedOut" LogoutPageUrl="~/"/> ]
                            </LoggedInTemplate>
                        </asp:LoginView>  
                        </div>          
                    </div>                
                </div>      
                <div style="background: #7795BD url('../imagenes/fase2/fondo_menu.png') repeat-x; border-right: 1px solid #8BA0BC; border-bottom: 1px solid #8BA0BC" >     
                    <dx:ASPxMenu ID="ASPxMenu1" runat="server" ></dx:ASPxMenu>
                </div>
                <dx:ASPxCallbackPanel runat="server" ID="cpMapa" ShowLoadingPanel="false" ClientInstanceName="cpMapa" >
                    <ClientSideEvents EndCallback="OnEndCallback" />            
                        <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">  
                            <table cellpadding="0" cellspacing="0" border="0">
                                <tr align="left">
                                    <td>
                                        <dx:ASPxButton ID="btnProcesar" runat="server" ClientInstanceName="btnProcesar" AutoPostBack="False" Text="Ver origen de Contratos" Width="80px" Theme="Office2010Blue" >                                                      
                                        <ClientSideEvents Click="function() {     
                                                            Cargando(true);
                                                            cpMapa.PerformCallback('ProcesarContratos');                                                                                 
                                                           }"  />
                                        </dx:ASPxButton>
                                    </td> 
                                    <td style="padding-left:5px">
                                        <dx:ASPxButton ID="ASPxButton1" runat="server" ClientInstanceName="btnTipoCana" AutoPostBack="False" Text="Ver tipo de caña" Width="80px" Theme="Office2010Blue" >                                                      
                                        <ClientSideEvents Click="function() {     
                                                            Cargando(true);
                                                            cpMapa.PerformCallback('ProcesarTipoCana');                                                                                 
                                                           }"  />
                                        </dx:ASPxButton>
                                    </td>                   
                                    <td style="padding-left:5px">
                                        <dx:ASPxButton ID="btnLimpiar" runat="server" AutoPostBack="False" Text="Limpiar" Width="80px" Theme="Office2010Blue" >    
                                            <ClientSideEvents Click="function() {                                                                   
                                                            LimpiarMapa();                                                                                                 
                                                    }"  />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>                                
                            </table>
                            <dx:ASPxPopupControl ID="popupInfo" ClientInstanceName="popupInfo" CloseAction="CloseButton" Width="570px" 
                                runat="server" PopupHorizontalAlign="LeftSides" Modal="true" HeaderText="Información"   
                                PopupVerticalAlign="Below" EnableHierarchyRecreation="True" AllowDragging="True" >                                
                                <ContentCollection>
                                    <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                                                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btOK">
                                                    <PanelCollection>
                                                        <dx:PanelContent runat="server">                                                                                                                         
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
            </form>            
            <div id="map_canvas"></div>      
    </body>
</html>



