<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTROL_QUEMA_SALDO.ascx.vb" Inherits="controles_ucListaCONTROL_QUEMA_SALDO" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" Theme="Glass"  AutoGenerateColumns="False" Width="100%" KeyFieldName="ID_QUEMA_SALDO">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" Title="INVENTARIO POR TIPO DE QUEMA"
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
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
                <asp:ImageButton ID="lbtnIncrementoSaldo" runat="server" AlternateText="Incrementar Saldo de Quema" ToolTip="Incrementar Saldo de Quema" CommandName="IncrementarSaldo" ImageUrl="~/imagenes/generar.png"  CommandArgument='<%# Bind("ID_QUEMA_SALDO")%>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colModificacionFechaQuema" Width="20px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnControlModiFechaQuema" runat="server" AlternateText="Modificación Fecha de Quema" ToolTip="Modificación Fecha de Quema" CommandName="ModificarFechaQuema" ImageUrl="~/imagenes/controlQuema.png"  CommandArgument='<%# Bind("ID_QUEMA_SALDO")%>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colModificacionTCQuema" Width="20px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnControlModiTCQuema" runat="server" AlternateText="Modificación TC Quema" ToolTip="Modificación TC Quema" CommandName="ModificarTCQuema" ImageUrl="~/imagenes/fire.png"  CommandArgument='<%# Bind("ID_QUEMA_SALDO")%>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn FieldName="CODI_PROVEE" ReadOnly="True" VisibleIndex="2" Caption="Cód Provee" Width="100px"  UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" ReadOnly="True" VisibleIndex="2" Caption="Proveedor" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODILOTE" ReadOnly="True" VisibleIndex="2" Caption="Cod. Lote" Width="80px" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" ReadOnly="True" VisibleIndex="2" Caption="Lote" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_QUEMA_SALDO" ReadOnly="True" VisibleIndex="2" Caption="Id quema saldo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="4" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_QUEMA" VisibleIndex="5" Caption="Fecha/Hora Quema" />
        <dx:GridViewDataCheckColumn FieldName="QUEMA_PROGRAMADA" VisibleIndex="6" Caption="Quema Programada" Width="80px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" />
        <dx:GridViewDataCheckColumn FieldName="QUEMA_NOPROG" VisibleIndex="7" Caption="Quema No Programada" Width="80px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" />        
        <dx:GridViewDataCheckColumn FieldName="ES_PROYECCION" VisibleIndex="9" Caption="Es Proyección" Width="80px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" />
        <dx:GridViewDataTextColumn FieldName="ENTRADAS" VisibleIndex="10" Caption="Entradas" />
        <dx:GridViewDataTextColumn FieldName="SALIDAS" VisibleIndex="11" Caption="Salidas" />        
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_QUEMA_PROY" VisibleIndex="12" Caption="Fecha/Hora Quema Proyectada" Width="120px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Visible="false" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_QUEMA_REAL2" VisibleIndex="12" Caption="Fecha/Hora Quema Real" Width="120px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TC_PROY" VisibleIndex="12" Caption="TC Proyectada" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="TC_REAL2" VisibleIndex="12" Caption="TC Real" UnboundType="String" CellStyle-HorizontalAlign="Right" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SALDO" VisibleIndex="12" Caption="Saldo" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="13" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="14" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="15" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="16" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="17">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>        
	   </Columns>    
    <Settings ShowFilterRow="False" ShowTitlePanel="true"  ShowHeaderFilterButton="False" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsListaPorLiquidacion" runat="server" 
    SelectMethod="ObtenerListaPorCriteriosLiquidacion" TypeName="SISPACAL.BL.cCONTROL_QUEMA_SALDO">
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

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTROL_QUEMA_SALDO" DeleteMethod="EliminarCONTROL_QUEMA_SALDO" UpdateMethod="ActualizarCONTROL_QUEMA_SALDO"
    TypeName="SISPACAL.BL.cCONTROL_QUEMA_SALDO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_QUEMA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ES_PROYECCION" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_QUEMA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ES_PROYECCION" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_QUEMA_SALDO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCONTROL_QUEMA_SALDO" DeleteMethod="EliminarCONTROL_QUEMA_SALDO" UpdateMethod="ActualizarCONTROL_QUEMA_SALDO"
    TypeName="SISPACAL.BL.cCONTROL_QUEMA_SALDO">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_QUEMA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ES_PROYECCION" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_QUEMA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ES_PROYECCION" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_QUEMA_SALDO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarCONTROL_QUEMA_SALDO" DeleteMethod="EliminarCONTROL_QUEMA_SALDO" UpdateMethod="ActualizarCONTROL_QUEMA_SALDO"
    TypeName="SISPACAL.BL.cCONTROL_QUEMA_SALDO">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_QUEMA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ES_PROYECCION" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_QUEMA_SALDO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="ES_PROYECCION" Type="Boolean" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_QUEMA_SALDO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
