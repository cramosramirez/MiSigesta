<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPROVEEDOR_ROZA.ascx.vb" Inherits="controles_ucListaPROVEEDOR_ROZA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%" KeyFieldName="ID_PROVEEDOR_ROZA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>                
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="true">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_PROVEEDOR_ROZA")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_PROVEEDOR_ROZA")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_ROZA" ReadOnly="True" VisibleIndex="2" Caption="Id proveedor roza" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR_ROZA" VisibleIndex="3" Caption="Nombre proveedor roza" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="4" Caption="Usuario crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="5" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="6" Caption="Usuario act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="7" Caption="Fecha act" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="8" Caption="Nit" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="9" Caption="Dui" />
        <dx:GridViewDataTextColumn FieldName="CREDITO_FISCAL" VisibleIndex="10" Caption="Credito fiscal" />
        <dx:GridViewDataCheckColumn FieldName="ES_CONTRIBUYENTE" VisibleIndex="11" Caption="Es contribuyente" />
        <dx:GridViewDataTextColumn FieldName="FACTOR_PAGO" VisibleIndex="12" Caption="Factor pago" />
        <dx:GridViewDataTextColumn FieldName="TIPO_ROZA" VisibleIndex="13" Caption="Tipo de Roza" UnboundType="String" />        
        <dx:GridViewDataCheckColumn FieldName="ACTIVO" VisibleIndex="14" Caption="Activo" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="15">
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarPROVEEDOR_ROZA" DeleteMethod="EliminarPROVEEDOR_ROZA" UpdateMethod="ActualizarPROVEEDOR_ROZA"
    TypeName="SISPACAL.BL.cPROVEEDOR_ROZA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR_ROZA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CREDITO_FISCAL" Type="String" />
        <asp:Parameter Name="ES_CONTRIBUYENTE" Type="Boolean" />
        <asp:Parameter Name="FACTOR_PAGO" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR_ROZA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CREDITO_FISCAL" Type="String" />
        <asp:Parameter Name="ES_CONTRIBUYENTE" Type="Boolean" />
        <asp:Parameter Name="FACTOR_PAGO" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPOS_GENERALES" runat="server" 
    SelectMethod="ObtenerListaPorTIPOS_GENERALES" InsertMethod="AgregarPROVEEDOR_ROZA" DeleteMethod="EliminarPROVEEDOR_ROZA" UpdateMethod="ActualizarPROVEEDOR_ROZA"
    TypeName="SISPACAL.BL.cPROVEEDOR_ROZA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR_ROZA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CREDITO_FISCAL" Type="String" />
        <asp:Parameter Name="ES_CONTRIBUYENTE" Type="Boolean" />
        <asp:Parameter Name="FACTOR_PAGO" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR_ROZA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CREDITO_FISCAL" Type="String" />
        <asp:Parameter Name="ES_CONTRIBUYENTE" Type="Boolean" />
        <asp:Parameter Name="FACTOR_PAGO" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
