<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAsignacionCargadoraZona.ascx.vb" Inherits="controlesProforma_ucAsignacionCargadoraZona" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaZONAS" Src="~/controles/ucListaZONAS.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaCARGADORA" Src="~/controles/ucListaCARGADORA.ascx" %>

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<dx:ASPxCallbackPanel ID="cpAsignacionCargadoraZona" ClientInstanceName="cpAsignacionCargadoraZona" runat="server" ShowLoadingPanel="false" Width="100%" >    
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">              
            <center>
                <table>
                    <tr align="left">  
                        <td></td>                      
                        <td style="text-align:left">
                            <table>
                                <tr>
                                    <td style="padding-right:10px">
                                        <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Zafra:">
                                        </dx:ASPxLabel>                                        
                                    </td>
                                    <td>
                                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server" HorizontalAlign="Right" DropDownStyle="DropDownList" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px" AutoPostBack="true">
                                        </dx:ASPxComboBox>
                                    </td>
                                </tr>
                            </table>                            
                        </td>                        
                    </tr>
                    <tr>
                        <td style="vertical-align:top">
                            <dx:ASPxFormLayout ID="frmlyZONAS" runat="server" Width="400px">
                                <Items>
                                    <dx:LayoutGroup Caption="Zonas (Seleccione la Zona a la que asignará cargadoras)" ColCount="1">
                                        <Items>
                                            <dx:LayoutItem ShowCaption="False">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer25" runat="server">
                                                        <uc1:ucListaZONAS id="ucListaZONAS1" PermitirRowHotTrack="false" MostrarCheckUnaSeleccion="true" VerZONA="false" VerUSER_CREA="false" VerUSER_ACT="false" VerFECHA_ACT="false" VerFECHA_CREA="false" PermitirEditar="false" PermitirEliminar="false" runat="server"></uc1:ucListaZONAS>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                    </dx:LayoutGroup>
                                </Items>
                            </dx:ASPxFormLayout>
                        </td>
                        <td style="margin-left:80px; vertical-align:top">
                            <dx:ASPxFormLayout ID="frmlyCARGADORAS" runat="server" Width="500px">
                                <Items>
                                    <dx:LayoutGroup Caption="Cargadoras (Marque las cargadora para la Zona seleccionada)" ColCount="1">
                                        <Items>
                                            <dx:LayoutItem ShowCaption="False">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                                        <uc1:ucListaCARGADORA id="ucListaCARGADORA1" MostrarCheckVariaSeleccion="true" PermitirEditar="false" PermitirEliminar="false" runat="server"
                                                        VerID_CARGADORA="true" ORIGEN="AsignaCargadora" VerTIPO_CARGADORA="true" VerNOMBRE="true" PermitirRowHotTrack="false" TamanoPagina="20" 
                                                        ></uc1:ucListaCARGADORA>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                    </dx:LayoutGroup>
                                </Items>
                            </dx:ASPxFormLayout>
                        </td>
                    </tr>
                </table>
            </center>
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>