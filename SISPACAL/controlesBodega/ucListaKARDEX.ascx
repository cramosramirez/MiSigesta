<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaKARDEX.ascx.vb" Inherits="controles_ucListaKARDEX" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%"  Font-Size="x-Small" Font-Names="Tahoma" KeyFieldName="ID_KARDEX">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>        
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="Edicion"  >
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_KARDEX") %>'>Editar</asp:LinkButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_KARDEX") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_KARDEX" ReadOnly="True" VisibleIndex="2" Caption="Id" SortIndex="1" SortOrder="Ascending"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="3" Caption="Fecha" Width="90px"  >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yy HH:mm"  />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="REFERENCIA" VisibleIndex="4" Caption="Referencia" Width="250px" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="UID_DOCUMENTO" VisibleIndex="5" Caption="Uid documento" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_MOVTO" VisibleIndex="6" Caption="Id tipo movto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PRODUCTO" VisibleIndex="7" Caption="Cód.Producto" />
        <dx:GridViewDataTextColumn FieldName="TIPO_MOVTO" VisibleIndex="7" Caption="Tipo" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="7" Caption="Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PRODUCTO" VisibleIndex="7" Caption="Producto" UnboundType="String" Width="350px"  />
        <dx:GridViewDataTextColumn FieldName="ENT_UNIDAD" VisibleIndex="8" Caption="Entrada Unidades" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" Width="80px"   />
        <dx:GridViewDataTextColumn FieldName="ENT_PRECIO_UNITARIO" VisibleIndex="9" Caption="Entrada Precio" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00###" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ENT_TOTAL" VisibleIndex="10" Caption="Entrada Total" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="SAL_UNIDAD" VisibleIndex="11" Caption="Salida Unidades" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" Width="80px" />
        <dx:GridViewDataTextColumn FieldName="SAL_PRECIO_UNITARIO" VisibleIndex="12" Caption="Salida Precio" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00###" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SAL_TOTAL" VisibleIndex="13" Caption="Salida Total" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="SDO_UNIDAD" VisibleIndex="14" Caption="Saldo Unidades" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" Width="80px" />
        <dx:GridViewDataTextColumn FieldName="SDO_PRECIO_UNITARIO" VisibleIndex="15" Caption="Saldo Precio" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00###" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SDO_TOTAL" VisibleIndex="16" Caption="Saldo Total" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="17" Caption="Usuario crea" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="19" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="20" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_BODEGA" VisibleIndex="21" Caption="Id bodega" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="UID_DOCUMENTO_DETA" VisibleIndex="22" Caption="Uid documento deta" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="23" Visible="false">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarKARDEX" DeleteMethod="EliminarKARDEX" UpdateMethod="ActualizarKARDEX"
    TypeName="SISPACAL.BL.cKARDEX">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_KARDEX" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="REFERENCIA" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="ENT_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="ENT_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="ENT_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SAL_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SAL_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SAL_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SDO_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SDO_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SDO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_KARDEX" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="REFERENCIA" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="ENT_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="ENT_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="ENT_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SAL_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SAL_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SAL_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SDO_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SDO_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SDO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_KARDEX" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_MOVTO" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_MOVTO" InsertMethod="AgregarKARDEX" DeleteMethod="EliminarKARDEX" UpdateMethod="ActualizarKARDEX"
    TypeName="SISPACAL.BL.cKARDEX">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_KARDEX" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="REFERENCIA" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="ENT_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="ENT_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="ENT_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SAL_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SAL_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SAL_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SDO_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SDO_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SDO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_KARDEX" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="REFERENCIA" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="ENT_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="ENT_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="ENT_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SAL_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SAL_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SAL_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SDO_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SDO_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SDO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_KARDEX" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPRODUCTO" runat="server" 
    SelectMethod="ObtenerListaPorPRODUCTO" InsertMethod="AgregarKARDEX" DeleteMethod="EliminarKARDEX" UpdateMethod="ActualizarKARDEX"
    TypeName="SISPACAL.BL.cKARDEX">
    <SelectParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_KARDEX" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="REFERENCIA" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="ENT_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="ENT_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="ENT_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SAL_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SAL_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SAL_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SDO_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SDO_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SDO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_KARDEX" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="REFERENCIA" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="ENT_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="ENT_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="ENT_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SAL_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SAL_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SAL_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SDO_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SDO_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SDO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_KARDEX" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorBODEGA" runat="server" 
    SelectMethod="ObtenerListaPorBODEGA" InsertMethod="AgregarKARDEX" DeleteMethod="EliminarKARDEX" UpdateMethod="ActualizarKARDEX"
    TypeName="SISPACAL.BL.cKARDEX">
    <SelectParameters>
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_KARDEX" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="REFERENCIA" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="ENT_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="ENT_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="ENT_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SAL_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SAL_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SAL_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SDO_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SDO_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SDO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_KARDEX" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="REFERENCIA" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO" Type="Object" />
        <asp:Parameter Name="ID_TIPO_MOVTO" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="ENT_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="ENT_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="ENT_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SAL_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SAL_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SAL_TOTAL" Type="Decimal" />
        <asp:Parameter Name="SDO_UNIDAD" Type="Decimal" />
        <asp:Parameter Name="SDO_PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SDO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_BODEGA" Type="Int32" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_KARDEX" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
