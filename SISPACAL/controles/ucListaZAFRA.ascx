<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaZAFRA.ascx.vb" Inherits="controles_ucListaZAFRA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_ZAFRA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager PageSize="15">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <SettingsCommandButton> 
         <NewButton Text="Agregar"></NewButton> 
         <EditButton Text="Editar"></EditButton> 
         <DeleteButton Text="Eliminar"></DeleteButton> 
    </SettingsCommandButton> 
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_ZAFRA") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_ZAFRA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" ReadOnly="True" VisibleIndex="2" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="3" Caption="Nombre zafra" />
        <dx:GridViewDataTextColumn FieldName="DIAZAFRA" VisibleIndex="4" Caption="Dia zafra" />
        <dx:GridViewDataTextColumn FieldName="CATORCENA" VisibleIndex="5" Caption="Catorcena" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INICIO" VisibleIndex="6" Caption="Fecha inicio" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_FINAL" VisibleIndex="7" Caption="Fecha final" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="POL" VisibleIndex="8" Caption="Pol" />
        <dx:GridViewDataTextColumn FieldName="HUMEDAD" VisibleIndex="9" Caption="Humedad" />
        <dx:GridViewDataTextColumn FieldName="PUREZA_MIEL" VisibleIndex="10" Caption="Pureza de miel" />
        <dx:GridViewDataTextColumn FieldName="EFICIENCIA" VisibleIndex="11" Caption="Eficiencia" />
        <dx:GridViewDataTextColumn FieldName="PRECIO_LIBRA_AZUCAR" VisibleIndex="12" Caption="Valor Inicial Pago (VIP)" />
        <dx:GridViewDataTextColumn FieldName="CONSTANTE_A" VisibleIndex="13" Caption="Constante a" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CONSTANTE_B" VisibleIndex="14" Caption="Constante b" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CONSTANTE_D" VisibleIndex="15" Caption="Constante d" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CONSTANTE_E" VisibleIndex="16" Caption="Constante e" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ULTFECHA_CIERRE_DIARIO" VisibleIndex="17" Caption="Ultfecha cierre diario" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="ACTIVA" VisibleIndex="18" Caption="Activa" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="19" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="20" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="21" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="22" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="DISPO_INVE_ROZA" VisibleIndex="23" Caption="Dispo inve roza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="REND_MODFINAN" VisibleIndex="24" Caption="Rend. para Modulo Finan" />
        <dx:GridViewDataTextColumn FieldName="TARIFA_ROZA_MODFINAN" VisibleIndex="25" Caption="Tarifa roza Modulo Finan" />
        <dx:GridViewDataTextColumn FieldName="TARIFA_ALZA_MODFINAN" VisibleIndex="26" Caption="Tarifa alza Modulo Finan" />
        <dx:GridViewDataTextColumn FieldName="TARIFA_QUERQUEO" VisibleIndex="27" Caption="Tarifa Querqueo" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="28">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text=" " Image-ToolTip="Eliminar" Image-IconID="edit_delete_16x16">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarZAFRA" DeleteMethod="EliminarZAFRA" UpdateMethod="ActualizarZAFRA"
    TypeName="SISPACAL.BL.cZAFRA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_ZAFRA" Type="String" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="CATORCENA" Type="Int32" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
        <asp:Parameter Name="POL" Type="Decimal" />
        <asp:Parameter Name="HUMEDAD" Type="Decimal" />
        <asp:Parameter Name="PUREZA_MIEL" Type="Decimal" />
        <asp:Parameter Name="EFICIENCIA" Type="Decimal" />
        <asp:Parameter Name="PRECIO_LIBRA_AZUCAR" Type="Decimal" />
        <asp:Parameter Name="CONSTANTE_A" Type="Decimal" />
        <asp:Parameter Name="CONSTANTE_B" Type="Decimal" />
        <asp:Parameter Name="CONSTANTE_D" Type="Decimal" />
        <asp:Parameter Name="CONSTANTE_E" Type="Decimal" />
        <asp:Parameter Name="ULTFECHA_CIERRE_DIARIO" Type="DateTime" />
        <asp:Parameter Name="ACTIVA" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DISPO_INVE_ROZA" Type="Decimal" />
        <asp:Parameter Name="REND_MODFINAN" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ROZA_MODFINAN" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA_MODFINAN" Type="Decimal" />
        <asp:Parameter Name="TARIFA_QUERQUEO" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_ZAFRA" Type="String" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="CATORCENA" Type="Int32" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
        <asp:Parameter Name="POL" Type="Decimal" />
        <asp:Parameter Name="HUMEDAD" Type="Decimal" />
        <asp:Parameter Name="PUREZA_MIEL" Type="Decimal" />
        <asp:Parameter Name="EFICIENCIA" Type="Decimal" />
        <asp:Parameter Name="PRECIO_LIBRA_AZUCAR" Type="Decimal" />
        <asp:Parameter Name="CONSTANTE_A" Type="Decimal" />
        <asp:Parameter Name="CONSTANTE_B" Type="Decimal" />
        <asp:Parameter Name="CONSTANTE_D" Type="Decimal" />
        <asp:Parameter Name="CONSTANTE_E" Type="Decimal" />
        <asp:Parameter Name="ULTFECHA_CIERRE_DIARIO" Type="DateTime" />
        <asp:Parameter Name="ACTIVA" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DISPO_INVE_ROZA" Type="Decimal" />
        <asp:Parameter Name="REND_MODFINAN" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ROZA_MODFINAN" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA_MODFINAN" Type="Decimal" />
        <asp:Parameter Name="TARIFA_QUERQUEO" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
