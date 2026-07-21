<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCENSO_LOTES.ascx.vb" Inherits="controles_ucListaCENSO_LOTES" %>
<%@ Register src="ucVistaDetalleCENSO_LOTES.ascx" tagname="ucVistaDetalleCENSO_LOTES" tagprefix="uc1" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>




<dx:ASPxGridView ID="dxgvLista" runat="server" DataSourceID="odsListaPorZAFRA_ZONA_CENSO" AutoGenerateColumns="False" Theme="Office2010Blue" KeyFieldName="CORRELATIVO" Font-Size="X-Small" Width="100%"  >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
                    CustomButtonClick="function(s,e){
                                            if(e.buttonID=='btnEliminar'){                                            
                                                if(!window.confirm('Esta seguro de Eliminar el Registro?'))
                                                    return false;
                                                else
                                                    e.processOnServer = true;                                            
                                            }
                                          }" 
    />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" ShowEditButton="true" VisibleIndex="0" Caption="#" Width="60px" Visible="False" FixedStyle="Left">
            <NewButton Text="Agregar">
            </NewButton>
            <EditButton Text="Editar"></EditButton> 
            <DeleteButton Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0" FixedStyle="Left">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Caption=" " FixedStyle="Left" Width="50px" Visible="false" >
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("CORRELATIVO") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("CORRELATIVO") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CORRELATIVO" ReadOnly="true" UnboundType="Integer" VisibleIndex="2" Caption="Correlativo" Visible="false"  FixedStyle="Left"/>
        <dx:GridViewDataTextColumn FieldName="ID_CENSO_LOTES" ReadOnly="True" VisibleIndex="2" Caption="Id censo lotes" Visible="false" FixedStyle="Left" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" FixedStyle="Left" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="4" Caption="Acceslote" Visible="false" FixedStyle="Left" />
        <dx:GridViewDataTextColumn FieldName="FECHA_VERIFICACION" VisibleIndex="5" Caption="Fecha verificacion" Visible="false" FixedStyle="Left" />
        <dx:GridViewDataTextColumn FieldName="ZONA" Settings-AllowHeaderFilter="True" UnboundType="String" Width="60px" VisibleIndex="6" Caption="Zona" FixedStyle="Left"  />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" Settings-AllowHeaderFilter="True" UnboundType="String" Width="60px" VisibleIndex="6" Caption="Provee" FixedStyle="Left"  />
        <dx:GridViewDataTextColumn FieldName="CODISOCIO" Settings-AllowHeaderFilter="True" UnboundType="String" Width="60px" VisibleIndex="6" Caption="Socio" FixedStyle="Left"  />
        <dx:GridViewDataTextColumn FieldName="NOMBREPROVEEDOR" Settings-AllowHeaderFilter="True" UnboundType="String" Width="200px" VisibleIndex="7" Caption="Proveedor" FixedStyle="Left"  />
        <dx:GridViewDataTextColumn FieldName="CONTRATO" Settings-AllowHeaderFilter="True" UnboundType="String" Width="75px" VisibleIndex="8" Caption="Contrato"  FixedStyle="Left" />         
        <dx:GridViewDataTextColumn FieldName="CODLOTE" Settings-AllowHeaderFilter="True" UnboundType="String" Width="60px" VisibleIndex="9" Caption="Codigo" FixedStyle="Left"  />
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" Settings-AllowHeaderFilter="True" UnboundType="String" Width="150px" VisibleIndex="10" Caption="Lote"  FixedStyle="Left" />        

        <dx:GridViewDataTextColumn FieldName="MZ_ENTREGAR" VisibleIndex="11" Width="80px" Caption="MZ Entregar" CellStyle-BackColor="#ffeae8" >
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_MZ_ENTREGAR" VisibleIndex="12" Caption="TC/MZ Entregar" CellStyle-BackColor="#ffeae8"/>
        <dx:GridViewDataTextColumn FieldName="TONEL_ENTREGAR" VisibleIndex="13" Width="80px" Caption="TC Entregar" CellStyle-BackColor="#ffeae8">
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="LBS_ENTREGAR" VisibleIndex="14" Caption="LBS Entregar" Width="100px" CellStyle-BackColor="#ffeae8" >
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="VALOR_ENTREGAR" VisibleIndex="15" Width="120px" Caption="Valor US$ Entregar" CellStyle-BackColor="#ffeae8">
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>

        <dx:GridViewDataTextColumn FieldName="MZ_ENTREGADA" VisibleIndex="16" Width="80px" Caption="MZ Entregada" CellStyle-BackColor="#eeeeee">
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_MZ_ENTREGADA" VisibleIndex="17" Caption="TC/MZ Entregada" CellStyle-BackColor="#eeeeee"/>
        <dx:GridViewDataTextColumn FieldName="TONEL_ENTREGADA" VisibleIndex="18" Width="80px" Caption="TC Entregada" CellStyle-BackColor="#eeeeee">
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="LBS_ENTREGADA" VisibleIndex="19" Caption="LBS Entregada" Width="100px" CellStyle-BackColor="#eeeeee">
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="VALOR_ENTREGADA" VisibleIndex="20" Width="120px" Caption="Valor US$ Entregada" CellStyle-BackColor="#eeeeee" >
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>

        <dx:GridViewDataTextColumn FieldName="MZ_CENSO" VisibleIndex="21" Width="80px" Caption="MZ Censo" CellStyle-BackColor="#d9f2ce">
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_MZ_CENSO" VisibleIndex="22" Caption="TC/MZ Censo" CellStyle-BackColor="#d9f2ce"/>
        <dx:GridViewDataTextColumn FieldName="TONEL_CENSO" VisibleIndex="23" Width="80px" Caption="TC Censo" CellStyle-BackColor="#d9f2ce">
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="LBS_CENSO" VisibleIndex="24" Caption="LBS Censo" Width="100px" CellStyle-BackColor="#d9f2ce">
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="VALOR_CENSO" VisibleIndex="25" Width="120px" Caption="Valor US$ Censo" CellStyle-BackColor="#d9f2ce" >
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>

        <dx:GridViewDataTextColumn FieldName="ID_CENSO" VisibleIndex="26" Caption="Id censo" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="ID_MOTIVO_VARIACION" VisibleIndex="27" Caption="Id motivo variacion" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="OBSERVACION" VisibleIndex="28" Caption="Observacion" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="29" Caption="Usuario crea" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="30" Caption="Fecha crea" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="31" Caption="Usuario act" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="32" Caption="Fecha act" Visible="false"/>
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="33">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-Url="../imagenes/Eliminar.png" >
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>   
    <Templates>
        <EditForm>
            <dx:ASPxFormLayout ID="formLayout" runat="server" EnableTheming="True" 
                Theme="Office2010Blue" Width="480px">
                <Items>
                    <dx:LayoutGroup ColCount="2" GroupBoxDecoration="Box" Caption="Ingrese información de entrega">
                        <Items>
                            <dx:LayoutItem Caption="MZ a entregar" FieldName="MZ_ENTREGAR">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                        <dx:ASPxTextBox ID="ASPxFormLayout1_E2" runat="server" Width="100px" Text='<%# Eval("MZ_ENTREGAR") %>'>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="TC/MZ a entregar" FieldName="TONEL_MZ_ENTREGAR">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                        <dx:ASPxTextBox ID="ASPxFormLayout1_E1" runat="server" Width="100px" Text='<%# Eval("TONEL_MZ_ENTREGAR") %>'>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                                                      
                        </Items>
                        <SettingsItemCaptions VerticalAlign="Middle" />
                    </dx:LayoutGroup>
                </Items>
                <SettingsItems HorizontalAlign="Left" />
            </dx:ASPxFormLayout>            
            <table>
                <tr>
                    <td style="padding-right:15px">
                        <dx:ASPxButton ID="btnGuardar" Text="Guardar" UseSubmitBehavior="false" runat="server" AutoPostBack="False" Theme="Office2010Blue">
                            <ClientSideEvents Click="function(s, e){if(!s.CauseValidation())return false;eval(s.cp_NombreClienteLista).UpdateEdit();}" />
                        </dx:ASPxButton> 
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnCancelar" Text="Cancelar" UseSubmitBehavior="false" runat="server" AutoPostBack="False" Theme="Office2010Blue">
                        <ClientSideEvents Click="function(s, e){eval(s.cp_NombreClienteLista).CancelEdit();}" />  
                        </dx:ASPxButton>
                    </td>
                </tr>
            </table>  
        </EditForm>
    </Templates>
    <%--<Settings ShowFooter="True" />
    <TotalSummary>
        <dx:ASPxSummaryItem FieldName="MZ_ENTREGAR" SummaryType="Sum" />
        <dx:ASPxSummaryItem FieldName="TONEL_ENTREGAR" SummaryType="Sum" />
        <dx:ASPxSummaryItem FieldName="LBS_ENTREGAR" SummaryType="Sum" />
        <dx:ASPxSummaryItem FieldName="VALOR_ENTREGAR" SummaryType="Sum" />

        <dx:ASPxSummaryItem FieldName="MZ_ENTREGADA" SummaryType="Sum" />
        <dx:ASPxSummaryItem FieldName="TONEL_ENTREGADA" SummaryType="Sum" />
        <dx:ASPxSummaryItem FieldName="LBS_ENTREGADA" SummaryType="Sum" />
        <dx:ASPxSummaryItem FieldName="VALOR_ENTREGADA" SummaryType="Sum" />

         <dx:ASPxSummaryItem FieldName="MZ_CENSO" SummaryType="Sum" />
        <dx:ASPxSummaryItem FieldName="TONEL_CENSO" SummaryType="Sum" />
        <dx:ASPxSummaryItem FieldName="LBS_CENSO" SummaryType="Sum" />
        <dx:ASPxSummaryItem FieldName="VALOR_CENSO" SummaryType="Sum" />
    </TotalSummary>--%>
    <Settings ShowGroupPanel="true" horizontalscrollbarmode="Visible" ShowFilterRow="True" /> 
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True" />      
    <Styles AlternatingRow-Enabled="True" />
</dx:ASPxGridView>
<dx:ASPxHiddenField ID="hfListaCENSO_LOTES" ClientInstanceName="hfListaCanaContratada" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>
<asp:ObjectDataSource ID="odsListaPorZAFRA_ZONA_CENSO" runat="server" OldValuesParameterFormatString="{0}" 
    SelectMethod="ObtenerListaParaIngresoCenso" UpdateMethod="ActualizarCENSOporLOTE"
    TypeName="SISPACAL.BL.cCENSO_LOTES">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="-1" Name="ID_CENSO" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />  
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" /> 
        <asp:Parameter Name="CORRELATIVO" Type="Int32" />      
    </UpdateParameters>    
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCENSO_LOTES" DeleteMethod="EliminarCENSO_LOTES" UpdateMethod="ActualizarCENSO_LOTES"
    TypeName="SISPACAL.BL.cCENSO_LOTES">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_VERIFICACION" Type="DateTime" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_VERIFICACION" Type="DateTime" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCENSO_LOTES" DeleteMethod="EliminarCENSO_LOTES" UpdateMethod="ActualizarCENSO_LOTES"
    TypeName="SISPACAL.BL.cCENSO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_VERIFICACION" Type="DateTime" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_VERIFICACION" Type="DateTime" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarCENSO_LOTES" DeleteMethod="EliminarCENSO_LOTES" UpdateMethod="ActualizarCENSO_LOTES"
    TypeName="SISPACAL.BL.cCENSO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_VERIFICACION" Type="DateTime" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_VERIFICACION" Type="DateTime" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCENSO" runat="server" 
    SelectMethod="ObtenerListaPorCENSO" InsertMethod="AgregarCENSO_LOTES" DeleteMethod="EliminarCENSO_LOTES" UpdateMethod="ActualizarCENSO_LOTES"
    TypeName="SISPACAL.BL.cCENSO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_VERIFICACION" Type="DateTime" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_VERIFICACION" Type="DateTime" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMOTIVO_VARIACION" runat="server" 
    SelectMethod="ObtenerListaPorMOTIVO_VARIACION" InsertMethod="AgregarCENSO_LOTES" DeleteMethod="EliminarCENSO_LOTES" UpdateMethod="ActualizarCENSO_LOTES"
    TypeName="SISPACAL.BL.cCENSO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_VERIFICACION" Type="DateTime" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_VERIFICACION" Type="DateTime" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="ID_CENSO" Type="Int32" />
        <asp:Parameter Name="ID_MOTIVO_VARIACION" Type="Int32" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CENSO_LOTES" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
