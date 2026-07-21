<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaDOCUMENTO_ENTRADA_ENCA.ascx.vb" Inherits="controles_ucListaDOCUMENTO_ENTRADA_ENCA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%" KeyFieldName="ID_DOCENTRA_ENCA">
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
                                    MostrarDoctoIngresoInventario(s.GetRowKey(e.visibleIndex));
                                    break; 
                                default:
                                    e.processOnServer = true;
                                    break;  
                            }                                                                                                    
                      }" 
    />
    <Columns>
       <dx:GridViewCommandColumn Name="Edicion" Visible="False" Caption=" " >
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption="Editar" Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Width="20px" Visible="true" Caption="Editar" CellStyle-HorizontalAlign="Center">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_DOCENTRA_ENCA") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_DOCENTRA_ENCA") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Width="20px" Caption="Reporte" Name="colVistaPrevia" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa del Documento">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="ID_DOCENTRA_ENCA" ReadOnly="True" VisibleIndex="2" Caption="Id docentra enca" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ID_BODEGA" VisibleIndex="3" Caption="Id bodega" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TIPO_MOVTO" VisibleIndex="4" Caption="Tipo Movimiento" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NO_DOCUMENTO" VisibleIndex="4" Caption="N° Ingreso" Width="100px"  />
        <dx:GridViewDataTextColumn FieldName="FEC_DOCTO" VisibleIndex="5" Caption="Fecha" Width="100px" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyy"  >
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_MOVTO" VisibleIndex="6" Caption="Id tipo movto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="UID_DOCUMENTO" VisibleIndex="7" Caption="Uid documento" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="ID_PROVEE" VisibleIndex="8" Caption="Id provee" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FORMA_ENTREGA" VisibleIndex="9" Caption="Forma entrega" Visible="false"   />
        <dx:GridViewDataTextColumn FieldName="ID_ORDEN" VisibleIndex="10" Caption="Id orden" Visible="false" />
         <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="11" Caption="Proveedor" UnboundType="String" />
          <dx:GridViewDataTextColumn FieldName="CODI_ORDEN" VisibleIndex="12" Caption="N° Orden Compra" UnboundType="String" Width="100px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TIPO" VisibleIndex="13" Caption="Tipo Comprobante" UnboundType="String" Width="120px" />
        <dx:GridViewDataTextColumn FieldName="NO_COMPROB" VisibleIndex="14" Caption="No Comprobante" Width="120px" />
        <dx:GridViewDataTextColumn FieldName="FECHA_COMPROB" VisibleIndex="15" Caption="Fecha Comprobante" Width="100px" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyy"  >
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TOTAL" VisibleIndex="16" Caption="Total" Width="120px" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00"  >
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_COMPROB" VisibleIndex="17" Caption="Id tipo comprob" Visible="false" />
        
        <dx:GridViewDataTextColumn FieldName="OBSERVACIONES" VisibleIndex="18" Caption="Observaciones" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="19" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="20" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="21" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="22" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="23" Width="20px" >
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarDOCUMENTO_ENTRADA_ENCA" DeleteMethod="EliminarDOCUMENTO_ENTRADA_ENCA" UpdateMethod="ActualizarDOCUMENTO_ENTRADA_ENCA"
    TypeName="SISPACAL.BL.cDOCUMENTO_ENTRADA_ENCA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorBODEGA" runat="server" 
    SelectMethod="ObtenerListaPorBODEGA" InsertMethod="AgregarDOCUMENTO_ENTRADA_ENCA" DeleteMethod="EliminarDOCUMENTO_ENTRADA_ENCA" UpdateMethod="ActualizarDOCUMENTO_ENTRADA_ENCA"
    TypeName="SISPACAL.BL.cDOCUMENTO_ENTRADA_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_MOVTO" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_MOVTO" InsertMethod="AgregarDOCUMENTO_ENTRADA_ENCA" DeleteMethod="EliminarDOCUMENTO_ENTRADA_ENCA" UpdateMethod="ActualizarDOCUMENTO_ENTRADA_ENCA"
    TypeName="SISPACAL.BL.cDOCUMENTO_ENTRADA_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AGRICOLA" InsertMethod="AgregarDOCUMENTO_ENTRADA_ENCA" DeleteMethod="EliminarDOCUMENTO_ENTRADA_ENCA" UpdateMethod="ActualizarDOCUMENTO_ENTRADA_ENCA"
    TypeName="SISPACAL.BL.cDOCUMENTO_ENTRADA_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorORDEN_COMPRA_AGRI" runat="server" 
    SelectMethod="ObtenerListaPorORDEN_COMPRA_AGRI" InsertMethod="AgregarDOCUMENTO_ENTRADA_ENCA" DeleteMethod="EliminarDOCUMENTO_ENTRADA_ENCA" UpdateMethod="ActualizarDOCUMENTO_ENTRADA_ENCA"
    TypeName="SISPACAL.BL.cDOCUMENTO_ENTRADA_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_COMPROB" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_COMPROB" InsertMethod="AgregarDOCUMENTO_ENTRADA_ENCA" DeleteMethod="EliminarDOCUMENTO_ENTRADA_ENCA" UpdateMethod="ActualizarDOCUMENTO_ENTRADA_ENCA"
    TypeName="SISPACAL.BL.cDOCUMENTO_ENTRADA_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="NO_DOCUMENTO" Type="Int32" />
        <asp:Parameter Name="FEC_DOCTO" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FORMA_ENTREGA" Type="Int32" />
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="FECHA_COMPROB" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
