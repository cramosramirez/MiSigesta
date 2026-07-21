<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaDOCUMENTO_ENTRADA_DETA.ascx.vb" Inherits="controles_ucListaDOCUMENTO_ENTRADA_DETA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_DOCENTRA_ENCA_DETA" Width="100%" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" ButtonType="Image" VisibleIndex="0" Visible="False" Width="50px" Caption=" "  >
            <NewButton Visible="False" Image-ToolTip="Agregar" Image-IconID="actions_new_16x16" >
                <Image ToolTip="Agregar" IconID="actions_new_16x16"></Image>
            </NewButton>      
            <EditButton Visible="False" Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" >
                <Image ToolTip="Editar" IconID="edit_edit_16x16"></Image>
            </EditButton>            
            <UpdateButton Visible="False" Image-ToolTip="Guardar" Image-IconID="save_save_16x16" >
                <Image ToolTip="Guardar" IconID="save_save_16x16"></Image>
            </UpdateButton>                     
            <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" >
                <Image ToolTip="Cancelar" IconID="history_undo_16x16"></Image>
            </CancelButton>    
        </dx:GridViewCommandColumn>                 
        <dx:GridViewDataTextColumn FieldName="ID_DOCENTRA_ENCA_DETA" ReadOnly="True" VisibleIndex="2" Caption="Id docentra enca deta" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ID_DOCENTRA_ENCA" VisibleIndex="3" Caption="Id docentra enca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PRODUCTO" VisibleIndex="4" Caption="Id producto" Visible="false" />
        <dx:GridViewDataSpinEditColumn FieldName="CANTIDAD" VisibleIndex="5" Caption="Cantidad" Width="80px"  >
            <PropertiesSpinEdit ClientInstanceName="speCANTIDAD" NumberType="Float" DecimalPlaces="2" DisplayFormatString="#,##0.00" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit> 
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="6" Caption="Proveedor" ReadOnly="true" CellStyle-HorizontalAlign="Left" UnboundType="String"  /> 
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PRODUCTO" VisibleIndex="6" Caption="Producto" ReadOnly="true" CellStyle-HorizontalAlign="Left" />        
        <dx:GridViewDataTextColumn FieldName="PRESENTACION" VisibleIndex="7" Caption="Presentacion" Width="200px" CellStyle-HorizontalAlign="Left" ReadOnly="true" />
        <dx:GridViewDataDateColumn FieldName="FECHA_VTO" VisibleIndex="7" Caption="Vencimiento" Width="120px"  >
            <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="UNIDAD" VisibleIndex="8" Caption="Unidad" Visible="false" />
        <dx:GridViewDataSpinEditColumn FieldName="PRECIO_UNITARIO" VisibleIndex="9" Caption="Precio Unitario" Width="130px" Visible="false" />           
        <dx:GridViewDataTextColumn FieldName="TOTAL" VisibleIndex="10" Caption="Total" Visible="false" >  
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />          
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ORDEN_DETA" VisibleIndex="11" Caption="Id orden deta" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="UID_DOCUMENTO_DETA" VisibleIndex="12" Caption="Uid documento deta" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="13" Width="40px" >
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsDOCUMENTO_ENTRADA_DETAcache" runat="server" TypeName="cDOCUMENTO_ENTRADA_DETAcache"     
    SelectMethod="ObtenerLista" 
    UpdateMethod="Actualizar" DeleteMethod="Eliminar">       
     <SelectParameters>             
        <asp:Parameter Name="nombreSesion_ucListaDOCUMENTO_ENTRADA_DETA" Type="String" />
     </SelectParameters>    
     <UpdateParameters>    
        <asp:Parameter Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="FECHA_VTO" Type="DateTime" />
        <asp:Parameter Name="REFERENCIA" Type="String" />                   
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarDOCUMENTO_ENTRADA_DETA" DeleteMethod="EliminarDOCUMENTO_ENTRADA_DETA" UpdateMethod="ActualizarDOCUMENTO_ENTRADA_DETA"
    TypeName="SISPACAL.BL.cDOCUMENTO_ENTRADA_DETA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ORDEN_DETA" Type="Int32" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ORDEN_DETA" Type="Int32" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDOCUMENTO_ENTRADA_ENCA" runat="server" 
    SelectMethod="ObtenerListaPorDOCUMENTO_ENTRADA_ENCA" InsertMethod="AgregarDOCUMENTO_ENTRADA_DETA" DeleteMethod="EliminarDOCUMENTO_ENTRADA_DETA" UpdateMethod="ActualizarDOCUMENTO_ENTRADA_DETA"
    TypeName="SISPACAL.BL.cDOCUMENTO_ENTRADA_DETA">
    <SelectParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ORDEN_DETA" Type="Int32" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ORDEN_DETA" Type="Int32" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPRODUCTO" runat="server" 
    SelectMethod="ObtenerListaPorPRODUCTO" InsertMethod="AgregarDOCUMENTO_ENTRADA_DETA" DeleteMethod="EliminarDOCUMENTO_ENTRADA_DETA" UpdateMethod="ActualizarDOCUMENTO_ENTRADA_DETA"
    TypeName="SISPACAL.BL.cDOCUMENTO_ENTRADA_DETA">
    <SelectParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ORDEN_DETA" Type="Int32" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ORDEN_DETA" Type="Int32" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorORDEN_DETA_AGRI" runat="server" 
    SelectMethod="ObtenerListaPorORDEN_DETA_AGRI" InsertMethod="AgregarDOCUMENTO_ENTRADA_DETA" DeleteMethod="EliminarDOCUMENTO_ENTRADA_DETA" UpdateMethod="ActualizarDOCUMENTO_ENTRADA_DETA"
    TypeName="SISPACAL.BL.cDOCUMENTO_ENTRADA_DETA">
    <SelectParameters>
        <asp:Parameter Name="ID_ORDEN_DETA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ORDEN_DETA" Type="Int32" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCENTRA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ORDEN_DETA" Type="Int32" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCENTRA_ENCA_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
