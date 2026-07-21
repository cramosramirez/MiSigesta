<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPROFORMA.ascx.vb" Inherits="controles_ucListaPROFORMA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Font-Size="X-Small" Width="100%" KeyFieldName="ID_PROFORMA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
                        CustomButtonClick="function(s,e){                                                  
                            switch(e.buttonID){
                                case 'btnVistaPrevia':                                                                                                     
                                    MostrarProforma(s.GetRowKey(e.visibleIndex));
                                    break; 
                                case 'btnEliminar':   
                                    var aceptar;  
                                    aceptar = confirm('Esta seguro de eliminar este proforma');
                                    if(aceptar)
                                        e.processOnServer = true;                                    
                                    break;  
                                default:
                                    e.processOnServer = true;
                                    break;  
                            }                                                                                                    
                      }"
    />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
                <DataItemTemplate>
                    <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_PROFORMA") %>'></asp:ImageButton>                                   
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PROFORMA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
                </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colVistaPrevia" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa de la Solicitud">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="ID_PROFORMA" ReadOnly="True" VisibleIndex="2" Caption="Id proforma" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="3" Caption="Zafra" UnboundType="String" Width="100px" />
        <dx:GridViewDataTextColumn FieldName="DIAZAFRA" VisibleIndex="4" Caption="Diazafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOPROFORMA" VisibleIndex="5" Caption="N° Proforma" Width="100px" />
        <dx:GridViewDataTextColumn FieldName="CODICONTRATO" VisibleIndex="6" Caption="Codicontrato" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="7" Caption="Cod. Proveedor" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="7" Caption="Cod. Provee" UnboundType="String" Width="80px" />
        <dx:GridViewDataTextColumn FieldName="CODISOCIO" VisibleIndex="7" Caption="Cod. Socio" UnboundType="String" Width="80px"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="7" Caption="Proveedor" UnboundType="String"   />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="8" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODILOTE" VisibleIndex="8" Caption="Cod. Lote" UnboundType="String"   />
        <dx:GridViewDataTextColumn FieldName="NOMLOTE" VisibleIndex="8" Caption="Lote" UnboundType="String"   />
        <dx:GridViewDataTextColumn FieldName="CODTRANSPORT" VisibleIndex="9" Caption="Codtransport" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES_MOTORISTA" VisibleIndex="10" Caption="Nombres motorista" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_CANA" VisibleIndex="11" Caption="Id tipo cana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CARGADORA" VisibleIndex="12" Caption="Id cargadora" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_SUPERVISOR" VisibleIndex="13" Caption="Id supervisor" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_QUEMA" VisibleIndex="14" Caption="Fecha quema" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CORTA" VisibleIndex="15" Caption="Fecha corta" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="QUEMAPROG" VisibleIndex="16" Caption="Quemaprog" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="QUEMANOPROG" VisibleIndex="17" Caption="Quemanoprog" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CARGA" VisibleIndex="18" Caption="Fecha carga" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_PATIO" VisibleIndex="19" Caption="Fecha patio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PRODUCTO" VisibleIndex="20" Caption="Id producto" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="FIN_LOTE" VisibleIndex="21" Caption="Fin lote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ENTRADA" VisibleIndex="22" Caption="Fecha entrada" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PLACAVEHIC" VisibleIndex="23" Caption="Placavehic" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPOTRANS" VisibleIndex="24" Caption="Id tipotrans" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="SERVICIO_ROZA" VisibleIndex="25" Caption="Servicio roza" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="TRANSPORTE_PROPIO" VisibleIndex="26" Caption="Transporte propio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_ROZA" VisibleIndex="27" Caption="Id proveedor roza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CARGADOR" VisibleIndex="28" Caption="Id cargador" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TIPO_TARIFA_CARGADORA" VisibleIndex="29" Caption="Tipo tarifa cargadora" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_MOTORISTA" VisibleIndex="30" Caption="Id motorista" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OBSERVACIONES" VisibleIndex="31" Caption="Observaciones" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ENVIO" VisibleIndex="32" Caption="Id envio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="33" Caption="Estado" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NROBOLETA" VisibleIndex="33" Caption="N° Boleta envío" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ESTADO" VisibleIndex="33" Caption="Estado Proforma" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="34" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="35" Caption="Fecha Emisión" Width="80px" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm" >
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="36" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="37" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="38">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPROFORMA" DeleteMethod="EliminarPROFORMA" UpdateMethod="ActualizarPROFORMA"
    TypeName="SISPACAL.BL.cPROFORMA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarPROFORMA" DeleteMethod="EliminarPROFORMA" UpdateMethod="ActualizarPROFORMA"
    TypeName="SISPACAL.BL.cPROFORMA">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_CANA" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_CANA" InsertMethod="AgregarPROFORMA" DeleteMethod="EliminarPROFORMA" UpdateMethod="ActualizarPROFORMA"
    TypeName="SISPACAL.BL.cPROFORMA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCARGADORA" runat="server" 
    SelectMethod="ObtenerListaPorCARGADORA" InsertMethod="AgregarPROFORMA" DeleteMethod="EliminarPROFORMA" UpdateMethod="ActualizarPROFORMA"
    TypeName="SISPACAL.BL.cPROFORMA">
    <SelectParameters>
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSUPERVISOR" runat="server" 
    SelectMethod="ObtenerListaPorSUPERVISOR" InsertMethod="AgregarPROFORMA" DeleteMethod="EliminarPROFORMA" UpdateMethod="ActualizarPROFORMA"
    TypeName="SISPACAL.BL.cPROFORMA">
    <SelectParameters>
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPRODUCTO" runat="server" 
    SelectMethod="ObtenerListaPorPRODUCTO" InsertMethod="AgregarPROFORMA" DeleteMethod="EliminarPROFORMA" UpdateMethod="ActualizarPROFORMA"
    TypeName="SISPACAL.BL.cPROFORMA">
    <SelectParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_TRANSPORTE" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_TRANSPORTE" InsertMethod="AgregarPROFORMA" DeleteMethod="EliminarPROFORMA" UpdateMethod="ActualizarPROFORMA"
    TypeName="SISPACAL.BL.cPROFORMA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_ROZA" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_ROZA" InsertMethod="AgregarPROFORMA" DeleteMethod="EliminarPROFORMA" UpdateMethod="ActualizarPROFORMA"
    TypeName="SISPACAL.BL.cPROFORMA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCARGADOR" runat="server" 
    SelectMethod="ObtenerListaPorCARGADOR" InsertMethod="AgregarPROFORMA" DeleteMethod="EliminarPROFORMA" UpdateMethod="ActualizarPROFORMA"
    TypeName="SISPACAL.BL.cPROFORMA">
    <SelectParameters>
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorENVIO" runat="server" 
    SelectMethod="ObtenerListaPorENVIO" InsertMethod="AgregarPROFORMA" DeleteMethod="EliminarPROFORMA" UpdateMethod="ActualizarPROFORMA"
    TypeName="SISPACAL.BL.cPROFORMA">
    <SelectParameters>
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOPROFORMA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRES_MOTORISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_SUPERVISOR" Type="Int32" />
        <asp:Parameter Name="FECHA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTA" Type="DateTime" />
        <asp:Parameter Name="QUEMAPROG" Type="Boolean" />
        <asp:Parameter Name="QUEMANOPROG" Type="Boolean" />
        <asp:Parameter Name="FECHA_CARGA" Type="DateTime" />
        <asp:Parameter Name="FECHA_PATIO" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_ENTRADA" Type="DateTime" />
        <asp:Parameter Name="PLACAVEHIC" Type="String" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="SERVICIO_ROZA" Type="Boolean" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="TIPO_TARIFA_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ID_ENVIO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROFORMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
