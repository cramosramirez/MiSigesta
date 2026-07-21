<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTROL_QUEMA.ascx.vb" Inherits="controles_ucListaCONTROL_QUEMA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Font-Names="Arial" KeyFieldName="ID_CONTROL_QUEMA" Width="100%" >
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
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="false" >
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_CONTROL_QUEMA") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_CONTROL_QUEMA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CONTROL_QUEMA" ReadOnly="True" VisibleIndex="2" Caption="Id control quema" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="3" Width="120px" Caption="Fecha Movimiento" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm" >
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_USUARIO" VisibleIndex="3" Caption="Usuario" UnboundType="String" />
        <dx:GridViewDataDateColumn FieldName="FECHA_QUEMA" VisibleIndex="3" Caption="Fecha Quema" Width="120px" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="4" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PORCION" VisibleIndex="5" Caption="Porcion" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CONCEPTO" VisibleIndex="5" Caption="Concepto" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_REF" VisibleIndex="6" Caption="Codigo ref" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_REF" VisibleIndex="7" Caption="Id ref" Visible="false" />        
        <dx:GridViewDataCheckColumn FieldName="ES_PROYECCION" VisibleIndex="7" Caption="Es Proyección" />
        <dx:GridViewDataTextColumn FieldName="NO_DOCUMENTO" VisibleIndex="8" Caption="N° Documento" UnboundType="String" CellStyle-HorizontalAlign="Right" />                
        <dx:GridViewDataCheckColumn FieldName="QUEMA_PROGRAMADA" VisibleIndex="11" Caption="Quema Programada" Width="50px" CellStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True"  />
        <dx:GridViewDataCheckColumn FieldName="QUEMA_NOPROG" VisibleIndex="12" Caption="Quema no Programada" Width="50px" CellStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True"  />   
        <dx:GridViewDataCheckColumn FieldName="CANA_VERDE" VisibleIndex="12" Caption="Caña Verde" Width="50px" CellStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Visible="false"  />             
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_QUEMA" VisibleIndex="14" Caption="Fecha hora quema" Visible="false"   />
        <dx:GridViewDataTextColumn FieldName="ENTRADAS" VisibleIndex="15" Caption="Entradas(t)" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="SALIDAS" VisibleIndex="16" Caption="Salidas(t)" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="SALDO" VisibleIndex="17" Caption="Saldo(t)" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="18" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="20" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="21" Caption="Fecha act"  Visible="false" />        
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="22">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsListaPorZAFRA_LOTE" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA_LOTE" TypeName="SISPACAL.BL.cCONTROL_QUEMA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="ACCESLOTE" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTROL_QUEMA" DeleteMethod="EliminarCONTROL_QUEMA" UpdateMethod="ActualizarCONTROL_QUEMA"
    TypeName="SISPACAL.BL.cCONTROL_QUEMA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTROL_QUEMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTROL_QUEMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTROL_QUEMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCONTROL_QUEMA" DeleteMethod="EliminarCONTROL_QUEMA" UpdateMethod="ActualizarCONTROL_QUEMA"
    TypeName="SISPACAL.BL.cCONTROL_QUEMA">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTROL_QUEMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTROL_QUEMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTROL_QUEMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarCONTROL_QUEMA" DeleteMethod="EliminarCONTROL_QUEMA" UpdateMethod="ActualizarCONTROL_QUEMA"
    TypeName="SISPACAL.BL.cCONTROL_QUEMA">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTROL_QUEMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTROL_QUEMA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="ENTRADAS" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NOPROG" Type="Boolean" />
        <asp:Parameter Name="CANA_VERDE" Type="Boolean" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTROL_QUEMA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
