<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_ENCA_TRANS.ascx.vb" Inherits="controles_ucListaSOLIC_ENCA_TRANS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_SOLICITUD">
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
                                    MostrarSolicTransporte(s.GetRowKey(e.visibleIndex));
                                    break;                                                               
                                case 'btnEliminar':   
                                    var aceptar;  
                                    aceptar = confirm('Esta seguro de eliminar esta solicitud?');
                                    if(aceptar)
                                        e.processOnServer = true;                                    
                                    break;  
                                default:
                                    e.processOnServer = true;
                                    break;  
                            }                                                                                                    
                      }"
        />
    <Columns>
        <dx:GridViewDataTextColumn VisibleIndex="1" Caption="Editar" Width="10px"  CellStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/editar.png"  CommandArgument='<%# Bind("ID_SOLICITUD") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_SOLICITUD") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
         <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="true" Caption=" " Name="colVistaPrevia" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa de la Solicitud">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="2" Caption="Zafra" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" ReadOnly="True" VisibleIndex="2" Caption="Identificador" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" SortIndex="0"   />
        <dx:GridViewDataTextColumn FieldName="ID_CONTRA_TRANS" VisibleIndex="4" Caption="Id contra trans" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CUENTA_FINAN" VisibleIndex="5" Caption="Id cuenta finan" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CONDI_COMPRA" VisibleIndex="6" Caption="Condi compra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NUM_SOLIC_ZAFRA" VisibleIndex="7" Caption="N° Solicitud" SortIndex="1"  />
        <dx:GridViewDataTextColumn FieldName="CONDICION_COMPRA" VisibleIndex="7" Caption="Cond. Compra" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODTRANSPORT" VisibleIndex="8" Caption="Cód. Transp." />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TRANSPORTISTA" VisibleIndex="8" Caption="Nombre Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ACTIVIDAD" VisibleIndex="9" Caption="Actividad" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="FECHA_SOLIC" VisibleIndex="10" Caption="Fecha solicitud" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NO_CONTRATO" VisibleIndex="10" Caption="Contrato al que aplica" UnboundType="Integer" />
        <dx:GridViewDataTextColumn FieldName="DESCRIP_ESTADO_SOLIC" VisibleIndex="10" Caption="Estado" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="PROVEEDOR_TRANSPO" VisibleIndex="10" Caption="Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ID_CONTRA_TRANS_VEHI" VisibleIndex="11" Caption="Id contra trans vehi" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TRANSPORTE" VisibleIndex="12" Caption="Id transporte" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SUB_TOTAL" VisibleIndex="13" Caption="Sub Total" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00#####" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CESC" VisibleIndex="14" Caption="CESC" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00#####" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="IVA" VisibleIndex="14" Caption="Iva" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00#####" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TOTAL" VisibleIndex="15" Caption="Total" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00#####" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_SOLIC" VisibleIndex="16" Caption="Id estado solic" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="UID_SOLIC_ENCA_TRANS" VisibleIndex="17" Caption="Uid solic enca trans" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OBSERVACIONES" VisibleIndex="18" Caption="Observaciones" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="19" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="20" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="21" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="22" Caption="Fecha act" Visible="false" />        
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="24">
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_ENCA_TRANS" DeleteMethod="EliminarSOLIC_ENCA_TRANS" UpdateMethod="ActualizarSOLIC_ENCA_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLIC_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter Name="UID_SOLIC_ENCA_TRANS" Type="Object" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLIC_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter Name="UID_SOLIC_ENCA_TRANS" Type="Object" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarSOLIC_ENCA_TRANS" DeleteMethod="EliminarSOLIC_ENCA_TRANS" UpdateMethod="ActualizarSOLIC_ENCA_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLIC_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter Name="UID_SOLIC_ENCA_TRANS" Type="Object" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLIC_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter Name="UID_SOLIC_ENCA_TRANS" Type="Object" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCUENTA_FINAN" runat="server" 
    SelectMethod="ObtenerListaPorCUENTA_FINAN" InsertMethod="AgregarSOLIC_ENCA_TRANS" DeleteMethod="EliminarSOLIC_ENCA_TRANS" UpdateMethod="ActualizarSOLIC_ENCA_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLIC_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter Name="UID_SOLIC_ENCA_TRANS" Type="Object" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLIC_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter Name="UID_SOLIC_ENCA_TRANS" Type="Object" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTRANSPORTISTA" runat="server" 
    SelectMethod="ObtenerListaPorTRANSPORTISTA" InsertMethod="AgregarSOLIC_ENCA_TRANS" DeleteMethod="EliminarSOLIC_ENCA_TRANS" UpdateMethod="ActualizarSOLIC_ENCA_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLIC_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter Name="UID_SOLIC_ENCA_TRANS" Type="Object" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLIC_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter Name="UID_SOLIC_ENCA_TRANS" Type="Object" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_SOLIC" runat="server" 
    SelectMethod="ObtenerListaPorESTADO_SOLIC" InsertMethod="AgregarSOLIC_ENCA_TRANS" DeleteMethod="EliminarSOLIC_ENCA_TRANS" UpdateMethod="ActualizarSOLIC_ENCA_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLIC_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter Name="UID_SOLIC_ENCA_TRANS" Type="Object" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLIC_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLIC" Type="Int32" />
        <asp:Parameter Name="UID_SOLIC_ENCA_TRANS" Type="Object" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
