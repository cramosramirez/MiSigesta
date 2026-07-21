<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_OIP_TRANS.ascx.vb" Inherits="controles_ucListaSOLIC_OIP_TRANS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%"  KeyFieldName="ID_OIP_TRANS">
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
                                    MostrarOPI_TRANS(s.GetRowKey(e.visibleIndex));                                    
                                    break;                                  
                                default:
                                    e.processOnServer = true;
                                    break;  
                            }                                                                                                    
                      }" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Width="20px">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_OIP_TRANS")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_OIP_TRANS")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
         <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="True" Caption=" " Name="colVistaPrevia" ButtonType="Image" Width="20px">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa de la OIP">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colAnalisisFinanciero" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnAnalisisFinanciero" Image-IconID="miscellaneous_currency_16x16" Image-ToolTip="Análisis Financiero">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewDataTextColumn FieldName="ID_OIP_TRANS" ReadOnly="True" VisibleIndex="2" Caption="Identificador" SortIndex="0"  />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="2" Caption="Zafra" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODTRANSPORT" VisibleIndex="3" Caption="Cod. Transp." />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TRANSPORTISTA" VisibleIndex="3" Caption="Nombre transportista" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_BANCO" VisibleIndex="3" Caption="Banco" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="4" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NUM_OIP_ZAFRA" VisibleIndex="4" Caption="N° OIP" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="5" Caption="Fecha" >
             <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="MONTO" VisibleIndex="6" Caption="Monto" >
             <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CUOTA_CORTE" VisibleIndex="7" Caption="Cuota x Corte" >
             <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="UID_OIP_TRANS" VisibleIndex="8" Caption="Uid oip trans" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PORC_DESC" VisibleIndex="9" Caption="% Descuento" />
        <dx:GridViewDataTextColumn FieldName="PORC_DESCEFECTIVO" VisibleIndex="10" Caption="% Descto. Planilla" />        
        <dx:GridViewDataTextColumn FieldName="REFERENCIA_GF" VisibleIndex="12" Caption="Referencia gf" Visible="false" />
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
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_OIP_TRANS" DeleteMethod="EliminarSOLIC_OIP_TRANS" UpdateMethod="ActualizarSOLIC_OIP_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_OIP_TRANS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_OIP_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CUOTA_CORTE" Type="Decimal" />
        <asp:Parameter Name="UID_OIP_TRANS" Type="Object" />
        <asp:Parameter Name="PORC_DESC" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCEFECTIVO" Type="Decimal" />
        <asp:Parameter Name="NUM_OIP_ZAFRA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA_GF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_OIP_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CUOTA_CORTE" Type="Decimal" />
        <asp:Parameter Name="UID_OIP_TRANS" Type="Object" />
        <asp:Parameter Name="PORC_DESC" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCEFECTIVO" Type="Decimal" />
        <asp:Parameter Name="NUM_OIP_ZAFRA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA_GF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_OIP_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTRANSPORTISTA" runat="server" 
    SelectMethod="ObtenerListaPorTRANSPORTISTA" InsertMethod="AgregarSOLIC_OIP_TRANS" DeleteMethod="EliminarSOLIC_OIP_TRANS" UpdateMethod="ActualizarSOLIC_OIP_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_OIP_TRANS">
    <SelectParameters>
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_OIP_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CUOTA_CORTE" Type="Decimal" />
        <asp:Parameter Name="UID_OIP_TRANS" Type="Object" />
        <asp:Parameter Name="PORC_DESC" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCEFECTIVO" Type="Decimal" />
        <asp:Parameter Name="NUM_OIP_ZAFRA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA_GF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_OIP_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CUOTA_CORTE" Type="Decimal" />
        <asp:Parameter Name="UID_OIP_TRANS" Type="Object" />
        <asp:Parameter Name="PORC_DESC" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCEFECTIVO" Type="Decimal" />
        <asp:Parameter Name="NUM_OIP_ZAFRA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA_GF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_OIP_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarSOLIC_OIP_TRANS" DeleteMethod="EliminarSOLIC_OIP_TRANS" UpdateMethod="ActualizarSOLIC_OIP_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_OIP_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_OIP_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CUOTA_CORTE" Type="Decimal" />
        <asp:Parameter Name="UID_OIP_TRANS" Type="Object" />
        <asp:Parameter Name="PORC_DESC" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCEFECTIVO" Type="Decimal" />
        <asp:Parameter Name="NUM_OIP_ZAFRA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA_GF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_OIP_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CUOTA_CORTE" Type="Decimal" />
        <asp:Parameter Name="UID_OIP_TRANS" Type="Object" />
        <asp:Parameter Name="PORC_DESC" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCEFECTIVO" Type="Decimal" />
        <asp:Parameter Name="NUM_OIP_ZAFRA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA_GF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_OIP_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
