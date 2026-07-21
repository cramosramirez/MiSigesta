<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTROL_ROZA.ascx.vb" Inherits="controles_ucListaCONTROL_ROZA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<dx:ASPxGridView ID="dxgvLista" runat="server" DataSourceID="odsListaPorZAFRA_LOTE" Font-Names="Arial"  AutoGenerateColumns="False" Width="100%" KeyFieldName="ID_CONTROL_ROZA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents EndCallback="function(s, e){if(s.cpSALDO_ROZA!=undefined){gVistaDetalleCONTROL_ROZA_SALDO_ROZA.SetValue(s.cpSALDO_ROZA)} }"  RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="false" >
            <DataItemTemplate>
                <%--<asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_CONTROL_ROZA") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_CONTROL_ROZA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>--%>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CONTROL_ROZA" ReadOnly="True" Visible="false" VisibleIndex="2" Caption="Id control roza" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="3" Width="120px" Caption="Fecha Movimiento" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm" >
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_USUARIO" VisibleIndex="3" Caption="Usuario" UnboundType="String" />        
        <dx:GridViewDataDateColumn FieldName="FECHA_QUEMA" VisibleIndex="3" Caption="Fecha de Quema" Width="90px" UnboundType="String" />
        <dx:GridViewDataDateColumn FieldName="FECHA_ROZA" VisibleIndex="3" Caption="Fecha de Roza" Width="90px" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="4" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="DIAZAFRA" VisibleIndex="5" Caption="Dia Zafra" CellStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CONCEPTO" VisibleIndex="6" Caption="Concepto" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_REF" VisibleIndex="7" Caption="CODIGO_REF" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="ID_REF" VisibleIndex="8" Caption="Id Referencia" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FORMA_COSECHA" VisibleIndex="8" Caption="Forma de Cosecha" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="TIPO_ROZA" VisibleIndex="8" Caption="Tipo Roza" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="PROVEEDOR_ROZA" VisibleIndex="8" Caption="Proveedor Roza"  UnboundType="String"  />
        <dx:GridViewDataCheckColumn FieldName="ES_QUERQUEO" VisibleIndex="8" Caption="Querqueo"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TIPO_TRANS" VisibleIndex="8" Caption="Tipo Vehículo"  UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="NO_DOCUMENTO" VisibleIndex="8" Caption="N° Documento" UnboundType="String" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataCheckColumn FieldName="ES_PROYECCION" VisibleIndex="7" Caption="Proyección" />
        <dx:GridViewDataTextColumn FieldName="ENTRADAS" VisibleIndex="9" Caption="Entradas" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="SALIDAS" VisibleIndex="10" Caption="Salidas" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="SALDO" VisibleIndex="11" Caption="Saldo" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="12" Caption="Usuario crea" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="14" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="15" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="16">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True" ShowHeaderFilterButton="True" />
    <SettingsBehavior AllowFocusedRow="True" AllowSort="false" />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsListaPorZAFRA_LOTE" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA_LOTE" TypeName="SISPACAL.BL.cCONTROL_ROZA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="ID_CONTROL_ROZA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorCONTROL_SALDO_ROZA" runat="server" 
    SelectMethod="ObtenerListaPorCONTROL_ROZA_SALDO" TypeName="SISPACAL.BL.cCONTROL_ROZA">
    <SelectParameters>
        <asp:Parameter Name="ID_ROZA_SALDO" Type="Int32" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="ID_CONTROL_ROZA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>