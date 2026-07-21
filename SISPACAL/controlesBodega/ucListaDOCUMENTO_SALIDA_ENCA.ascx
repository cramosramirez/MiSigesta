<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaDOCUMENTO_SALIDA_ENCA.ascx.vb" Inherits="controles_ucListaDOCUMENTO_SALIDA_ENCA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%"  KeyFieldName="ID_DOCSAL_ENCA">
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
                                    MostrarDoctoSalidaInventario(s.GetRowKey(e.visibleIndex));
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
        <dx:GridViewDataTextColumn VisibleIndex="1" Width="20px" Visible="true">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_DOCSAL_ENCA") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_DOCSAL_ENCA") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" Width="20px" AllowDragDrop="False" Visible="false" Caption=" " Name="colVistaPrevia" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa del Documento">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="ID_DOCSAL_ENCA" ReadOnly="True" VisibleIndex="2" Caption="Id docsal enca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TIPO_MOVIMIENTO" VisibleIndex="2" UnboundType="String" Caption="Tipo Movimiento" />
        <dx:GridViewDataTextColumn FieldName="NO_DOCUMENTO" VisibleIndex="3" Caption="No Documento" Width="100px"  />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_MOVTO" VisibleIndex="4" Caption="Id tipo movto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_DOCTO" VisibleIndex="5" Caption="Fecha Salida" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyy"  />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_BODEGA" VisibleIndex="6" Caption="Bodega" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NO_SOLICITUD_RETIRO" VisibleIndex="6" Caption="No. Solicitud Retiro" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="UID_DOCUMENTO" VisibleIndex="6" Caption="Uid documento" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_BODEGA" VisibleIndex="7" Caption="Id bodega" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="OBSERVACIONES" VisibleIndex="9" Caption="Observaciones" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ENTREGADO" VisibleIndex="10" Caption="Entregado" />
        <dx:GridViewDataTextColumn FieldName="RECIBIDO" VisibleIndex="11" Caption="Recibido" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="12" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="13" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="14" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="15" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="16" Width="40px" >
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarDOCUMENTO_SALIDA_ENCA" DeleteMethod="EliminarDOCUMENTO_SALIDA_ENCA" UpdateMethod="ActualizarDOCUMENTO_SALIDA_ENCA"
    TypeName="SISPACAL.BL.cDOCUMENTO_SALIDA_ENCA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="FECHA_DOCTO" Type="DateTime" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD_ORG" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ENTREGADO" Type="String" />
        <asp:Parameter Name="RECIBIDO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="FECHA_DOCTO" Type="DateTime" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD_ORG" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ENTREGADO" Type="String" />
        <asp:Parameter Name="RECIBIDO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_MOVTO" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_MOVTO" InsertMethod="AgregarDOCUMENTO_SALIDA_ENCA" DeleteMethod="EliminarDOCUMENTO_SALIDA_ENCA" UpdateMethod="ActualizarDOCUMENTO_SALIDA_ENCA"
    TypeName="SISPACAL.BL.cDOCUMENTO_SALIDA_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="FECHA_DOCTO" Type="DateTime" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD_ORG" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ENTREGADO" Type="String" />
        <asp:Parameter Name="RECIBIDO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="FECHA_DOCTO" Type="DateTime" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD_ORG" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ENTREGADO" Type="String" />
        <asp:Parameter Name="RECIBIDO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorBODEGA" runat="server" 
    SelectMethod="ObtenerListaPorBODEGA" InsertMethod="AgregarDOCUMENTO_SALIDA_ENCA" DeleteMethod="EliminarDOCUMENTO_SALIDA_ENCA" UpdateMethod="ActualizarDOCUMENTO_SALIDA_ENCA"
    TypeName="SISPACAL.BL.cDOCUMENTO_SALIDA_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="FECHA_DOCTO" Type="DateTime" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD_ORG" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ENTREGADO" Type="String" />
        <asp:Parameter Name="RECIBIDO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="FECHA_DOCTO" Type="DateTime" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD_ORG" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ENTREGADO" Type="String" />
        <asp:Parameter Name="RECIBIDO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorUNIDAD_ORG" runat="server" 
    SelectMethod="ObtenerListaPorUNIDAD_ORG" InsertMethod="AgregarDOCUMENTO_SALIDA_ENCA" DeleteMethod="EliminarDOCUMENTO_SALIDA_ENCA" UpdateMethod="ActualizarDOCUMENTO_SALIDA_ENCA"
    TypeName="SISPACAL.BL.cDOCUMENTO_SALIDA_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_UNIDAD_ORG" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="FECHA_DOCTO" Type="DateTime" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD_ORG" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ENTREGADO" Type="String" />
        <asp:Parameter Name="RECIBIDO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="FECHA_DOCTO" Type="DateTime" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD_ORG" Type="Int32" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="ENTREGADO" Type="String" />
        <asp:Parameter Name="RECIBIDO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
