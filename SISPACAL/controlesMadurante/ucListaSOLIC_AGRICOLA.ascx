<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_AGRICOLA.ascx.vb" Inherits="controles_ucListaSOLIC_AGRICOLA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleSOLIC_AGRICOLA.ascx" tagname="ucVistaDetalleSOLIC_AGRICOLA" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_SOLICITUD" Width="100%"  >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents EndCallback="function(s, e){if(s.cpMensaje != null){ AsignarMensaje(s.cpMensaje); delete s.cpMensaje;}}" RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
             CustomButtonClick="function(s,e){                                                  
                            switch(e.buttonID){
                                case 'btnVistaPrevia':          
                                    s.GetRowValues(e.visibleIndex, 'ID_SOLICITUD;CONDI_COMPRA', MostrarReportesCondicionalesSolicAgricola);                                    
                                    break;                               
                                case 'btnVistaAplicacion':                                                                                                     
                                    MostrarSolicAplicaciones(s.GetRowKey(e.visibleIndex));
                                    break;  
                                case 'btnAnalisisFinanciero':                                                                                                     
                                    MostrarAnalisisFinanciero(1, s.GetRowKey(e.visibleIndex));
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
                      }" />
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0" /> 
        <dx:GridViewCommandColumn AllowDragDrop="False" Visible="false" Caption=" " Name="colEditar" VisibleIndex="0" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnProcesar" Image-IconID="edit_edit_16x16" Image-ToolTip="Procesar">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>        
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Caption="Editar" CellStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/editar.png"  CommandArgument='<%# Bind("ID_SOLICITUD") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_SOLICITUD") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colVistaPrevia" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa de la Solicitud">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colVistaAplicacion" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaAplicacion" Image-Url="../imagenes/checkin.png" Image-ToolTip="Aplicaciones en Solicitud">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colAnalisisFinanciero" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnAnalisisFinanciero" Image-IconID="miscellaneous_currency_16x16" Image-ToolTip="Análisis Financiero">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewDataTextColumn Caption="Generar Orden" Name="colGenerarOrden" VisibleIndex="2" HeaderStyle-Wrap="True" Width="40px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnGenerarOC" runat="server" AlternateText="Generar Orden de Compra" ToolTip="Generar Orden de Compra" CommandName="GenerarOrdenCompra" ImageUrl="~/imagenes/generar.png"  CommandArgument='<%# Bind("ID_SOLICITUD") %>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" ReadOnly="True" VisibleIndex="2" Caption="Identificador"/>
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="NUM_SOLICITUD" VisibleIndex="4" Caption="N° Solicitud" />
        <dx:GridViewDataTextColumn FieldName="CONDICION_COMPRA" VisibleIndex="4" Caption="Cond. Compra" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="5" Caption="Codiproveedor" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="5" Caption="Cód. Provee" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="CODISOCIO" VisibleIndex="5" Caption="Cód. Socio" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="6" Caption="Nombre Proveedor" />
        <dx:GridViewDataTextColumn FieldName="ACTIVIDAD" VisibleIndex="7" Caption="Actividad" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="FECHA_SOLIC" VisibleIndex="8" Caption="Fecha Solicitud" SortIndex="1" SortOrder="Descending"  >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CONTRATOS" VisibleIndex="9" Caption="Contratos Aplica"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_APLICA" VisibleIndex="9" Caption="Fecha Aplicación" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CASA_COMERCIAL" VisibleIndex="9" Caption="Proveedor Agrícola" UnboundType="String" />            
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="10" Caption="Dui" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="11" Caption="Nit" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="NRC" VisibleIndex="12" Caption="Nrc" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="TIPO_CONTRIBUYENTE" VisibleIndex="13" Caption="Tipo contribuyente" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TIPO_CONTRIBUYENTE" VisibleIndex="13" Caption="Tipo contribuyente" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="SUB_TOTAL" VisibleIndex="14" Caption="Sub total" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="IVA" VisibleIndex="15" Caption="Iva" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="TOTAL" VisibleIndex="16" Caption="Total" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="17" Caption="Estado" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ESTADO_NOMBRE" VisibleIndex="17" Caption="Estado" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CUENTA" VisibleIndex="17" Caption="Tipo de Financiamiento" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="OBSERVACIONES" VisibleIndex="18" Caption="Observaciones" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="19" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="20" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="21" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="22" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="23" Caption="Zafra" />
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

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" TypeName="SISPACAL.BL.cSOLIC_AGRICOLA">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLICITUD" Type="DateTime" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_AGRICOLA" DeleteMethod="EliminarSOLIC_AGRICOLA" UpdateMethod="ActualizarSOLIC_AGRICOLA"
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="Int32" />
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
        <asp:Parameter Name="NUM_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="Int32" />
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
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarSOLIC_AGRICOLA" DeleteMethod="EliminarSOLIC_AGRICOLA" UpdateMethod="ActualizarSOLIC_AGRICOLA"
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA">
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
        <asp:Parameter Name="NUM_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="Int32" />
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
        <asp:Parameter Name="NUM_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="Int32" />
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
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarSOLIC_AGRICOLA" DeleteMethod="EliminarSOLIC_AGRICOLA" UpdateMethod="ActualizarSOLIC_AGRICOLA"
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="NUM_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="Int32" />
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
        <asp:Parameter Name="NUM_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="Int32" />
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
