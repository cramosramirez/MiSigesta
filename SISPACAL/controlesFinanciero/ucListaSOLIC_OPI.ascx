<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_OPI.ascx.vb" Inherits="controles_ucListaSOLIC_OPI" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_OPI" Width="100%">
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
                                    MostrarOPI(s.GetRowKey(e.visibleIndex));
                                    MostrarAnalisisFinanciero(4, s.GetRowKey(e.visibleIndex));
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
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_OPI") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_OPI") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
         <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colVistaPrevia" ButtonType="Image" Width="20px">
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
        <dx:GridViewDataTextColumn FieldName="ID_OPI" ReadOnly="True" VisibleIndex="2" Caption="Identificador" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="2" Caption="Zafra" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="3" Caption="Codiproveedor" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="6" Caption="Cód. Provee" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="7" Caption="Nombre Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NUM_OPI_ZAFRA" VisibleIndex="7" Caption="N° OPI" />        
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="7" Caption="Fecha OIP" SortIndex="1" SortOrder="Descending" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODICONTRATO" VisibleIndex="7" Caption="Codicontrato" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIBANCO" VisibleIndex="8" Caption="Codibanco" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_BANCO" VisibleIndex="8" Caption="Banco" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="MONTO" VisibleIndex="9" Caption="Monto" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PORC_DESCTO" VisibleIndex="10" Caption="% Descto. Solicitud" />      
        <dx:GridViewDataTextColumn FieldName="PORC_DESCTO_PLA" VisibleIndex="10" Caption="% Descto. Planilla" />
        <dx:GridViewDataTextColumn FieldName="ESTADO_NOMBRE" VisibleIndex="10" Caption="Estado" UnboundType="String" />
        <dx:GridViewDataCheckColumn FieldName="ES_ACEPTADA" VisibleIndex="10" Caption="Aceptada" />
        <dx:GridViewDataTextColumn FieldName="UID_OPI_CONTRATO" VisibleIndex="13" Caption="Uid opi contrato" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="14" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="15" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="16" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="17" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="18" Caption="Id zafra" Visible="false" />        
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="20">
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

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" TypeName="SISPACAL.BL.cSOLIC_OPI">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />        
        <asp:Parameter Name="FECHA" Type="DateTime" />        
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_OPI" DeleteMethod="EliminarSOLIC_OPI" UpdateMethod="ActualizarSOLIC_OPI"
    TypeName="SISPACAL.BL.cSOLIC_OPI">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_OPI" Type="String" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCTO" Type="Decimal" />
        <asp:Parameter Name="DESCRIP_LOTES" Type="String" />
        <asp:Parameter Name="UBICACION_LOTES" Type="String" />
        <asp:Parameter Name="UID_OPI_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_OPI" Type="String" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCTO" Type="Decimal" />
        <asp:Parameter Name="DESCRIP_LOTES" Type="String" />
        <asp:Parameter Name="UBICACION_LOTES" Type="String" />
        <asp:Parameter Name="UID_OPI_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarSOLIC_OPI" DeleteMethod="EliminarSOLIC_OPI" UpdateMethod="ActualizarSOLIC_OPI"
    TypeName="SISPACAL.BL.cSOLIC_OPI">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_OPI" Type="String" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCTO" Type="Decimal" />
        <asp:Parameter Name="DESCRIP_LOTES" Type="String" />
        <asp:Parameter Name="UBICACION_LOTES" Type="String" />
        <asp:Parameter Name="UID_OPI_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_OPI" Type="String" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCTO" Type="Decimal" />
        <asp:Parameter Name="DESCRIP_LOTES" Type="String" />
        <asp:Parameter Name="UBICACION_LOTES" Type="String" />
        <asp:Parameter Name="UID_OPI_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO" InsertMethod="AgregarSOLIC_OPI" DeleteMethod="EliminarSOLIC_OPI" UpdateMethod="ActualizarSOLIC_OPI"
    TypeName="SISPACAL.BL.cSOLIC_OPI">
    <SelectParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_OPI" Type="String" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCTO" Type="Decimal" />
        <asp:Parameter Name="DESCRIP_LOTES" Type="String" />
        <asp:Parameter Name="UBICACION_LOTES" Type="String" />
        <asp:Parameter Name="UID_OPI_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_OPI" Type="String" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCTO" Type="Decimal" />
        <asp:Parameter Name="DESCRIP_LOTES" Type="String" />
        <asp:Parameter Name="UBICACION_LOTES" Type="String" />
        <asp:Parameter Name="UID_OPI_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorBANCOS" runat="server" 
    SelectMethod="ObtenerListaPorBANCOS" InsertMethod="AgregarSOLIC_OPI" DeleteMethod="EliminarSOLIC_OPI" UpdateMethod="ActualizarSOLIC_OPI"
    TypeName="SISPACAL.BL.cSOLIC_OPI">
    <SelectParameters>
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_OPI" Type="String" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCTO" Type="Decimal" />
        <asp:Parameter Name="DESCRIP_LOTES" Type="String" />
        <asp:Parameter Name="UBICACION_LOTES" Type="String" />
        <asp:Parameter Name="UID_OPI_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_OPI" Type="String" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCTO" Type="Decimal" />
        <asp:Parameter Name="DESCRIP_LOTES" Type="String" />
        <asp:Parameter Name="UBICACION_LOTES" Type="String" />
        <asp:Parameter Name="UID_OPI_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarSOLIC_OPI" DeleteMethod="EliminarSOLIC_OPI" UpdateMethod="ActualizarSOLIC_OPI"
    TypeName="SISPACAL.BL.cSOLIC_OPI">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_OPI" Type="String" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCTO" Type="Decimal" />
        <asp:Parameter Name="DESCRIP_LOTES" Type="String" />
        <asp:Parameter Name="UBICACION_LOTES" Type="String" />
        <asp:Parameter Name="UID_OPI_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_OPI" Type="String" />
        <asp:Parameter Name="CORR_OPI" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="PORC_DESCTO" Type="Decimal" />
        <asp:Parameter Name="DESCRIP_LOTES" Type="String" />
        <asp:Parameter Name="UBICACION_LOTES" Type="String" />
        <asp:Parameter Name="UID_OPI_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
