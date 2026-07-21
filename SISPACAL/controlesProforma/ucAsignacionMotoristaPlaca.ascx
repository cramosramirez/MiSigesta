<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAsignacionMotoristaPlaca.ascx.vb" Inherits="controlesProforma_ucAsignacionMotoristaPlaca" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaTRANSPORTE" Src="~/controles/ucListaTRANSPORTE.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaMOTORISTA" Src="~/controles/ucListaMOTORISTA.ascx" %>

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<dx:ASPxCallbackPanel ID="cpAsignacionMotoristaPlaca" ClientInstanceName="cpAsignacionMotoristaPlaca" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">              
            <center>
                <table>                   
                    <tr>
                        <th colspan="2">
                        </th>
                    </tr>
                    <tr>
                        <td style="vertical-align:top">
                            <dx:ASPxFormLayout ID="frmlyPLACAS" runat="server" Width="900px">
                                <Items>
                                    <dx:LayoutGroup Caption="Placas" ColCount="1">
                                        <Items>
                                            <dx:LayoutItem ShowCaption="False">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">                                                       
                                                       <uc1:ucListaTRANSPORTE id="ucListaTRANSPORTE1" runat="server" MostrarCheckUnaSeleccion="true" VerREMOLQUE="false"  TamanoPagina="15" PermitirEditar="false" PermitirEliminar="false" />    
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                    </dx:LayoutGroup>
                                </Items>
                            </dx:ASPxFormLayout>
                        </td>
                        <td style="margin-left:80px; vertical-align:top">
                            <dx:ASPxFormLayout ID="frmlyMOTORISTAS" runat="server" Width="600px">
                                <Items>
                                    <dx:LayoutGroup Caption="Motoristas (Marque los motoristas a asignar a la Placa)" ColCount="1">
                                        <Items>
                                            <dx:LayoutItem ShowCaption="False">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                                        <dx:ASPxCheckBox ID="chkVerSoloAsignados" AutoPostBack="true" Text="Mostrar solo los motoristas asignados al Transporte seleccionado"  runat="server"></dx:ASPxCheckBox>
                                                         <uc1:ucListaMOTORISTA id="ucListaMOTORISTA1" runat="server" MostrarCheckVariaSeleccion="true" TamanoPagina="15" PermitirEditar="false" PermitirEliminar="false" VerUSUARIO_CREA = "false" VerFECHA_CREA  = "false" VerUSUARIO_ACT = "false" VerFECHA_ACT = "false" />    
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