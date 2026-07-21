<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTROL_ROZA_SALDO.ascx.vb" Inherits="controles_ucListaCONTROL_ROZA_SALDO" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<script type="text/javascript">
    function SeleccionFila(s, e) {        
         cpINVENTARIO_ROZA.PerformCallback('SeleccionRoza');
     }      
</script>

<dx:ASPxGridView ID="dxgvLista" runat="server" Theme="Office2003Olive" AutoGenerateColumns="False" Width="100%" Font-Names="Arial" KeyFieldName="ID_ROZA_SALDO">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" Title="INVENTARIO POR PORCION / TIPO DE CAÑA / TIPO DE ROZA / TIPO DE QUEMA"
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents SelectionChanged="SeleccionFila" RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <CancelButton Text="Cancelar"></CancelButton>
            <UpdateButton Text="Guardar"></UpdateButton>
            <EditButton Text="Editar" Visible="False"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Caption=" " Name="CheckSeleccionar" Width="10px" Visible="false" VisibleIndex="0">                                  
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colIncrementoSaldo" Width="20px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnIncrementoSaldo" runat="server" AlternateText="Incrementar Saldo de Roza" ToolTip="Incrementar Saldo de Roza" CommandName="IncrementarSaldo" ImageUrl="~/imagenes/generar.png"  CommandArgument='<%# Bind("ID_ROZA_SALDO")%>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colModificacionFechaQuema" Width="20px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnControlModiFechaQuema" runat="server" AlternateText="Modificación Fecha de Quema" ToolTip="Modificación Fecha de Quema" CommandName="ModificarFechaQuema" ImageUrl="~/imagenes/controlQuema.png"  CommandArgument='<%# Bind("ID_ROZA_SALDO")%>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colModificacionTCRoza" Width="20px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnControlModiTCRoza" runat="server" AlternateText="Modificación TC Roza" ToolTip="Modificación TC Roza" CommandName="ModificarTCRoza" ImageUrl="~/imagenes/roza.png"  CommandArgument='<%# Bind("ID_ROZA_SALDO")%>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
         <dx:GridViewDataTextColumn FieldName="CODI_PROVEE" ReadOnly="True" VisibleIndex="2" Caption="Cód Provee" Width="100px"  UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" ReadOnly="True" VisibleIndex="2" Caption="Proveedor" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODILOTE" ReadOnly="True" VisibleIndex="2" Caption="Cod. Lote" Width="80px" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" ReadOnly="True" VisibleIndex="2" Caption="Lote" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ROZA_SALDO" ReadOnly="True" VisibleIndex="2" Caption="Id roza saldo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="4" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_ROZA" VisibleIndex="5" Caption="Id proveedor roza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_CANA" VisibleIndex="6" Caption="Id tipo cana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_ROZA" VisibleIndex="7" Caption="Id tipo roza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PORCION" VisibleIndex="7" Caption="Porcion" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="TIPO_CANA" VisibleIndex="7" Caption="Tipo Caña" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="TIPO_ROZA" VisibleIndex="7" Caption="Tipo Roza" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR_ROZA" VisibleIndex="7" Caption="Proveedores de Roza" UnboundType="String" />                  
        <dx:GridViewDataTextColumn FieldName="HORAS_QUEMA" VisibleIndex="7" CellStyle-HorizontalAlign="Right" Caption="Hrs. Quema" UnboundType="String" />        
        <dx:GridViewDataTextColumn FieldName="HORAS_ROZA" VisibleIndex="7" CellStyle-HorizontalAlign="Right" Caption="Hrs. Roza" UnboundType="String" />        
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_QUEMA_CALC" VisibleIndex="8" Caption="Fecha/Hora Quema" UnboundType="String">            
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_ROZA" VisibleIndex="9" Caption="Fecha/Hora Roza" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm" />  
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataCheckColumn FieldName="QUEMA_PROGRAMADA" VisibleIndex="10" Caption="Quema Prog." Width="100px" />
        <dx:GridViewDataCheckColumn FieldName="QUEMA_NOPROG" VisibleIndex="11" Caption="Quema no Prog." Width="100px" />
        <dx:GridViewDataCheckColumn FieldName="CANA_VERDE" VisibleIndex="12" Caption="Caña Verde" Width="100px" />
        <dx:GridViewDataCheckColumn FieldName="ES_QUERQUEO" VisibleIndex="12" Caption="Querqueo" Width="80px" />
        <dx:GridViewDataTextColumn FieldName="PROVEEDOR_QUERQUEO" VisibleIndex="12" Caption="Frente/Querqueo" UnboundType="String" />   
        <dx:GridViewDataCheckColumn FieldName="ES_PROYECCION" VisibleIndex="12" Caption="Es Proyección" Width="100px" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ENTRADAS" VisibleIndex="13" Caption="Entradas(t)" />
        <dx:GridViewDataTextColumn FieldName="SALIDAS" VisibleIndex="14" Caption="Salidas(t)" />        
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_QUEMA_PROY2" VisibleIndex="15" Caption="Fecha/Hora Quema Proyectada" Width="120px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" UnboundType="String" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_ROZA_PROY" VisibleIndex="15" Caption="Fecha/Hora Roza Proyectada" Width="120px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Visible="false" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_QUEMA_REAL2" VisibleIndex="15" Caption="Fecha/Hora Quema Real" Width="120px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_ROZA_REAL2" VisibleIndex="15" Caption="Fecha/Hora Roza Real" Width="120px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TC_PROY" VisibleIndex="15" Caption="TC Proyectada" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TC_REAL2" VisibleIndex="15" Caption="TC Real" UnboundType="String" CellStyle-HorizontalAlign="Right" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SALDO" VisibleIndex="15" Caption="Saldo(t)" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="16" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="17" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="18" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="19" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="20">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>        
	   </Columns>    
    <Settings ShowFilterRow="False" ShowTitlePanel="true"  ShowHeaderFilterButton="False" />
    <SettingsBehavior EnableRowHotTrack="false" AllowFocusedRow="True" AllowSelectByRowClick="true"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsListaPorLiquidacion" runat="server" 
    SelectMethod="ObtenerListaPorCriteriosLiquidacion" TypeName="SISPACAL.BL.cCONTROL_ROZA_SALDO">
    <SelectParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="-1" Name="NO_CATORCENA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="CODIPROVEE" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODISOCIO" Type="String" />
        <asp:Parameter DefaultValue="" Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="" Name="NOMBRE_LOTE" Type="String" />
        <asp:Parameter DefaultValue="-1" Name="ES_PROYECCION" Type="Int32" />
        <asp:Parameter DefaultValue="-1" Name="TIPO_SALDO" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" TypeName="SISPACAL.BL.cCONTROL_ROZA_SALDO">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_ROZA" Type="String" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Int32" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Int32" />
        <asp:Parameter Name="CANA_VERDE" Type="Int32" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="ES_PROYECCION" Type="Int32" />
        <asp:Parameter Name="TIPO_SALDO" Type="Int32" />
        <asp:Parameter Name="ES_QUERQUEO" Type="Int32" />
        <asp:Parameter Name="ID_SUBLOTES" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTROL_ROZA_SALDO" DeleteMethod="EliminarCONTROL_ROZA_SALDO" UpdateMethod="ActualizarCONTROL_ROZA_SALDO"
    TypeName="SISPACAL.BL.cCONTROL_ROZA_SALDO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ROZA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="FECHA_HORA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ROZA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="FECHA_HORA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ROZA_SALDO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCONTROL_ROZA_SALDO" DeleteMethod="EliminarCONTROL_ROZA_SALDO" UpdateMethod="ActualizarCONTROL_ROZA_SALDO"
    TypeName="SISPACAL.BL.cCONTROL_ROZA_SALDO">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ROZA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="FECHA_HORA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ROZA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="FECHA_HORA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ROZA_SALDO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_ROZA" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_ROZA" InsertMethod="AgregarCONTROL_ROZA_SALDO" DeleteMethod="EliminarCONTROL_ROZA_SALDO" UpdateMethod="ActualizarCONTROL_ROZA_SALDO"
    TypeName="SISPACAL.BL.cCONTROL_ROZA_SALDO">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ROZA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="FECHA_HORA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ROZA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="FECHA_HORA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ROZA_SALDO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPOS_GENERALES" runat="server" 
    SelectMethod="ObtenerListaPorTIPOS_GENERALES" InsertMethod="AgregarCONTROL_ROZA_SALDO" DeleteMethod="EliminarCONTROL_ROZA_SALDO" UpdateMethod="ActualizarCONTROL_ROZA_SALDO"
    TypeName="SISPACAL.BL.cCONTROL_ROZA_SALDO">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ROZA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="FECHA_HORA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ROZA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="FECHA_HORA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ROZA_SALDO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
