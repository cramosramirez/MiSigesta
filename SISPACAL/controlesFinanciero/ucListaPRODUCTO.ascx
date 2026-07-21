<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPRODUCTO.ascx.vb" Inherits="controlesFinanciero_ucListaPRODUCTO" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_PRODUCTO" Width="100%"  >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="true" Caption="Editar" Name="Editar" CellStyle-HorizontalAlign="Center" Width="40px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_PRODUCTO")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_PRODUCTO")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PRODUCTO" ReadOnly="True" VisibleIndex="2" Caption="Identificador" Width="80px"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CATEGORIA" VisibleIndex="3" Caption="Categoria" UnboundType="String" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CUENTA_FINAN" VisibleIndex="3" Caption="Cuenta de Finan." UnboundType="String" Width="280px"  />       
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR_AGRICOLA" VisibleIndex="3" Caption="Proveedor" UnboundType="String" Width="220px" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PRODUCTO" VisibleIndex="3" Caption="Nombre producto" Width="250px" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_COMERCIAL" VisibleIndex="3" Caption="Nombre Comercial" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_UNIDAD" VisibleIndex="3" Caption="Unidad" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ID_CATEGORIA" VisibleIndex="4" Caption="Id categoria" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_UNIDAD" VisibleIndex="5" Caption="Id unidad" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PRECIO_UNITARIO" VisibleIndex="6" Caption="Precio unitario" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00##" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="7" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="8" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="9" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="10" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="11" Caption="Zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="VENTSEMA_INI" VisibleIndex="12" Caption="Ventsema ini" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="VENTSEMA_FIN" VisibleIndex="13" Caption="Ventsema fin" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_COMERCIAL" VisibleIndex="14" Caption="Nombre comercial" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CUENTA_FINAN" VisibleIndex="15" Caption="Id cuenta finan" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PRESENTACION" VisibleIndex="16" Caption="Presentacion" />
        <dx:GridViewDataCheckColumn FieldName="EN_CONSIGNA" VisibleIndex="16" Caption="En Consigna" />        
        <dx:GridViewDataCheckColumn FieldName="ACTIVO" VisibleIndex="16" Caption="Activo" />        
        <dx:GridViewDataTextColumn FieldName="PORC_SUBSIDIO" VisibleIndex="18" Caption="% Subsidio" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="19">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPRODUCTO" DeleteMethod="EliminarPRODUCTO" UpdateMethod="ActualizarPRODUCTO"
    TypeName="SISPACAL.BL.cPRODUCTO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="VENTSEMA_INI" Type="Int32" />
        <asp:Parameter Name="VENTSEMA_FIN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_COMERCIAL" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="VENTSEMA_INI" Type="Int32" />
        <asp:Parameter Name="VENTSEMA_FIN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_COMERCIAL" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCATEGORIA_PROD" runat="server" 
    SelectMethod="ObtenerListaPorCATEGORIA_PROD" InsertMethod="AgregarPRODUCTO" DeleteMethod="EliminarPRODUCTO" UpdateMethod="ActualizarPRODUCTO"
    TypeName="SISPACAL.BL.cPRODUCTO">
    <SelectParameters>
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="VENTSEMA_INI" Type="Int32" />
        <asp:Parameter Name="VENTSEMA_FIN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_COMERCIAL" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="VENTSEMA_INI" Type="Int32" />
        <asp:Parameter Name="VENTSEMA_FIN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_COMERCIAL" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorUNIDAD_MEDIDA" runat="server" 
    SelectMethod="ObtenerListaPorUNIDAD_MEDIDA" InsertMethod="AgregarPRODUCTO" DeleteMethod="EliminarPRODUCTO" UpdateMethod="ActualizarPRODUCTO"
    TypeName="SISPACAL.BL.cPRODUCTO">
    <SelectParameters>
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="VENTSEMA_INI" Type="Int32" />
        <asp:Parameter Name="VENTSEMA_FIN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_COMERCIAL" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="VENTSEMA_INI" Type="Int32" />
        <asp:Parameter Name="VENTSEMA_FIN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_COMERCIAL" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCUENTA_FINAN" runat="server" 
    SelectMethod="ObtenerListaPorCUENTA_FINAN" InsertMethod="AgregarPRODUCTO" DeleteMethod="EliminarPRODUCTO" UpdateMethod="ActualizarPRODUCTO"
    TypeName="SISPACAL.BL.cPRODUCTO">
    <SelectParameters>
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="VENTSEMA_INI" Type="Int32" />
        <asp:Parameter Name="VENTSEMA_FIN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_COMERCIAL" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="VENTSEMA_INI" Type="Int32" />
        <asp:Parameter Name="VENTSEMA_FIN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_COMERCIAL" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AGRICOLA" InsertMethod="AgregarPRODUCTO" DeleteMethod="EliminarPRODUCTO" UpdateMethod="ActualizarPRODUCTO"
    TypeName="SISPACAL.BL.cPRODUCTO">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="VENTSEMA_INI" Type="Int32" />
        <asp:Parameter Name="VENTSEMA_FIN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_COMERCIAL" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="ID_CATEGORIA" Type="Int32" />
        <asp:Parameter Name="ID_UNIDAD" Type="Int32" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="VENTSEMA_INI" Type="Int32" />
        <asp:Parameter Name="VENTSEMA_FIN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_COMERCIAL" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
