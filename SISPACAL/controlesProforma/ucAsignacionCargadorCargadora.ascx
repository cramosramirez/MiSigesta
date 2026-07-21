<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAsignacionCargadorCargadora.ascx.vb" Inherits="controlesProforma_ucAsignacionCargadorCargadora" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaCARGADORA" Src="~/controles/ucListaCARGADORA.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaCARGADOR" Src="~/controles/ucListaCARGADOR.ascx" %>

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<dx:ASPxCallbackPanel ID="cpAsignacionCargadorCargadora" ClientInstanceName="cpAsignacionCargadorCargadora" runat="server" ShowLoadingPanel="false" Width="100%" >    
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
                        <th colspan="2">
                        </th>
                    </tr>
                    <tr>
                        <td style="vertical-align:top">
                            <dx:ASPxFormLayout ID="frmlyCARGADORAS" runat="server" Width="500px">
                                <Items>
                                    <dx:LayoutGroup Caption="Cargadoras" ColCount="1">
                                        <Items>
                                            <dx:LayoutItem ShowCaption="False">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                                        <uc1:ucListaCARGADORA id="ucListaCARGADORA1" MostrarCheckUnaSeleccion="true" PermitirEditar="false" PermitirEliminar="false" runat="server"
                                                        VerID_CARGADORA="true" ORIGEN="AsignaCargador" VerTIPO_CARGADORA="true" VerNOMBRE="true" PermitirRowHotTrack="false" TamanoPagina="20" 
                                                        ></uc1:ucListaCARGADORA>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                    </dx:LayoutGroup>
                                </Items>
                            </dx:ASPxFormLayout>
                        </td>
                        <td style="margin-left:80px; vertical-align:top">
                            <dx:ASPxFormLayout ID="frmlyCARGADORES" runat="server" Width="600px">
                                <Items>
                                    <dx:LayoutGroup Caption="Operadores (Marque los operadores a asignar)" ColCount="1">
                                        <Items>
                                            <dx:LayoutItem ShowCaption="False">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                                        <uc1:ucListaCARGADOR id="ucListaCARGADOR1" MostrarCheckVariaSeleccion="true" PermitirEditar="false" PermitirEliminar="false" runat="server"
                                                         VerDIRECCION="false" VerDUI="false" VerFECHA_ACT="false" VerFECHA_CREA="false" VerNIT="false" VerUSUARIO_CREA="false" VerUSUARIO_ACT="false" PermitirRowHotTrack="false" TamanoPagina="20" 
                                                        ></uc1:ucListaCARGADOR>
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