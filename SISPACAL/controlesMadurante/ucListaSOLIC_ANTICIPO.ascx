<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_ANTICIPO.ascx.vb" Inherits="controles_ucListaSOLIC_ANTICIPO" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_ANTICIPO" Width="100%" >
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
                                    MostrarSolicAnticipo(s.GetRowKey(e.visibleIndex));
                                    MostrarAnalisisFinanciero(5, s.GetRowKey(e.visibleIndex));
                                    break;  
                                case 'btnAnalisisFinanciero':                                                                                                     
                                    MostrarAnalisisFinanciero(5, s.GetRowKey(e.visibleIndex));
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
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_ANTICIPO") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_ANTICIPO") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
         <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colVistaPrevia" ButtonType="Image" Width="20px">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa de la Solicitud">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colAnalisisFinanciero" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnAnalisisFinanciero" Image-IconID="miscellaneous_currency_16x16" Image-ToolTip="Análisis Financiero">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewDataTextColumn FieldName="ID_ANTICIPO" ReadOnly="True" VisibleIndex="2" Caption="Identificador" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="3" Caption="Codiproveedor" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CUENTA" VisibleIndex="3" Caption="Tipo de Financiamiento" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NUM_ANTICIPO" VisibleIndex="4" Caption="N° Préstamo" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="5" Caption="Cód. Provee" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="6" Caption="Nombre Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="5" Caption="Fecha" SortIndex="1" SortOrder="Descending" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CONCEPTO" VisibleIndex="6" Caption="Concepto" />
        <dx:GridViewDataTextColumn FieldName="MONTO" VisibleIndex="7" Caption="Monto" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>      
        <dx:GridViewDataTextColumn FieldName="FECHA_CHEQUE" VisibleIndex="7" Caption="Fecha Cheque" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="INTERES" VisibleIndex="7" Caption="% Interes" UnboundType="String">            
        </dx:GridViewDataTextColumn>    
        <dx:GridViewDataTextColumn FieldName="ESTADO_NOMBRE" VisibleIndex="7" Caption="Estado" UnboundType="String" />
         <dx:GridViewDataCheckColumn FieldName="ES_ACEPTADA" VisibleIndex="7" Caption="Aceptada" /> 
        <dx:GridViewDataTextColumn FieldName="UID_ANTICIPO_CONTRATO" VisibleIndex="11" Caption="Uid anticipo contrato" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="12" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="13" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="14" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="15" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="16" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="17" Caption="Zafra" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="18">
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
    SelectMethod="ObtenerListaPorCriterios" TypeName="SISPACAL.BL.cSOLIC_ANTICIPO">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="NUM_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />        
        <asp:Parameter Name="FECHA" Type="DateTime" />        
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_ANTICIPO" DeleteMethod="EliminarSOLIC_ANTICIPO" UpdateMethod="ActualizarSOLIC_ANTICIPO"
    TypeName="SISPACAL.BL.cSOLIC_ANTICIPO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONS" Type="Decimal" />
        <asp:Parameter Name="UID_ANTICIPO_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONS" Type="Decimal" />
        <asp:Parameter Name="UID_ANTICIPO_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarSOLIC_ANTICIPO" DeleteMethod="EliminarSOLIC_ANTICIPO" UpdateMethod="ActualizarSOLIC_ANTICIPO"
    TypeName="SISPACAL.BL.cSOLIC_ANTICIPO">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONS" Type="Decimal" />
        <asp:Parameter Name="UID_ANTICIPO_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONS" Type="Decimal" />
        <asp:Parameter Name="UID_ANTICIPO_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO" InsertMethod="AgregarSOLIC_ANTICIPO" DeleteMethod="EliminarSOLIC_ANTICIPO" UpdateMethod="ActualizarSOLIC_ANTICIPO"
    TypeName="SISPACAL.BL.cSOLIC_ANTICIPO">
    <SelectParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONS" Type="Decimal" />
        <asp:Parameter Name="UID_ANTICIPO_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONS" Type="Decimal" />
        <asp:Parameter Name="UID_ANTICIPO_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarSOLIC_ANTICIPO" DeleteMethod="EliminarSOLIC_ANTICIPO" UpdateMethod="ActualizarSOLIC_ANTICIPO"
    TypeName="SISPACAL.BL.cSOLIC_ANTICIPO">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONS" Type="Decimal" />
        <asp:Parameter Name="UID_ANTICIPO_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONS" Type="Decimal" />
        <asp:Parameter Name="UID_ANTICIPO_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
