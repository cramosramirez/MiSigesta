<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTRATO_TRANS.ascx.vb" Inherits="controles_ucListaCONTRATO_TRANS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%"  KeyFieldName="ID_CONTRA_TRANS">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents EndCallback="function(s, e){if(s.cpMensaje != null){ AsignarMensaje(s.cpMensaje); delete s.cpMensaje;}}"  RowClick="function(s, e) {
                        var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}"           
                      CustomButtonClick="function(s,e){                                                  
                            switch(e.buttonID){
                                case 'btnVistaPrevia':                                                                                                     
                                    MostrarContratoTransporte(s.GetRowKey(e.visibleIndex));
                                    break; 
                                case 'btnEliminar':   
                                    var aceptar;  
                                    aceptar = confirm('Esta seguro de eliminar este contrato');
                                    if(aceptar)
                                        e.processOnServer = true;                                    
                                    break;  
                                default:
                                    e.processOnServer = true;
                                    break;  
                            }                                                                                                    
                      }"           />
    <Columns>
         <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0" />    
        <dx:GridViewCommandColumn AllowDragDrop="False" Visible="false" Caption="" Name="colEditar" VisibleIndex="0" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEditar" Image-IconID="edit_edit_16x16" Image-ToolTip="Editar">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>            
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="true" Caption="Editar" Name="Editar" CellStyle-HorizontalAlign="Center" Width="40px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_CONTRA_TRANS")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_CONTRA_TRANS")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption="Ver Reporte Contrato" Name="colVistaPrevia" ButtonType="Image" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Width="50px"   >
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa del Contrato">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="ID_CONTRA_TRANS" ReadOnly="True" VisibleIndex="2" Caption="Id contra trans" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="3" UnboundType="String" Caption="Zafra" />
        <dx:GridViewDataTextColumn FieldName="COD_CONTRATO" VisibleIndex="3" Caption="Cod contrato" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NO_CONTRATO" VisibleIndex="4" Caption="No. Contrato" SortIndex="1" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="5" Caption="Id zafra" Visible="false" SortIndex="0"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_CONTRA" VisibleIndex="5" Caption="Fecha Contrato" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECINI" VisibleIndex="6" Caption="Fecha Inicial" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECFIN" VisibleIndex="7" Caption="Fecha Final" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="LUGAR_CORTE" VisibleIndex="8" Caption="Lugar corte" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="CODTRANSPORT" VisibleIndex="10" Caption="Código Trans." />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TRANS" VisibleIndex="11" Caption="Nombre Trans" />
        <dx:GridViewDataTextColumn FieldName="NIT_TRANS" VisibleIndex="12" Caption="Nit trans" Visible="false" />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTRATO_TRANS" DeleteMethod="EliminarCONTRATO_TRANS" UpdateMethod="ActualizarCONTRATO_TRANS"
    TypeName="SISPACAL.BL.cCONTRATO_TRANS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="COD_CONTRATO" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECINI" Type="DateTime" />
        <asp:Parameter Name="FECFIN" Type="DateTime" />
        <asp:Parameter Name="LUGAR_CORTE" Type="String" />
        <asp:Parameter Name="FECHA_CONTRA" Type="DateTime" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRE_TRANS" Type="String" />
        <asp:Parameter Name="NIT_TRANS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="COD_CONTRATO" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECINI" Type="DateTime" />
        <asp:Parameter Name="FECFIN" Type="DateTime" />
        <asp:Parameter Name="LUGAR_CORTE" Type="String" />
        <asp:Parameter Name="FECHA_CONTRA" Type="DateTime" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRE_TRANS" Type="String" />
        <asp:Parameter Name="NIT_TRANS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCONTRATO_TRANS" DeleteMethod="EliminarCONTRATO_TRANS" UpdateMethod="ActualizarCONTRATO_TRANS"
    TypeName="SISPACAL.BL.cCONTRATO_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="COD_CONTRATO" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECINI" Type="DateTime" />
        <asp:Parameter Name="FECFIN" Type="DateTime" />
        <asp:Parameter Name="LUGAR_CORTE" Type="String" />
        <asp:Parameter Name="FECHA_CONTRA" Type="DateTime" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRE_TRANS" Type="String" />
        <asp:Parameter Name="NIT_TRANS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="COD_CONTRATO" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECINI" Type="DateTime" />
        <asp:Parameter Name="FECFIN" Type="DateTime" />
        <asp:Parameter Name="LUGAR_CORTE" Type="String" />
        <asp:Parameter Name="FECHA_CONTRA" Type="DateTime" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRE_TRANS" Type="String" />
        <asp:Parameter Name="NIT_TRANS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTRANSPORTISTA" runat="server" 
    SelectMethod="ObtenerListaPorTRANSPORTISTA" InsertMethod="AgregarCONTRATO_TRANS" DeleteMethod="EliminarCONTRATO_TRANS" UpdateMethod="ActualizarCONTRATO_TRANS"
    TypeName="SISPACAL.BL.cCONTRATO_TRANS">
    <SelectParameters>
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="COD_CONTRATO" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECINI" Type="DateTime" />
        <asp:Parameter Name="FECFIN" Type="DateTime" />
        <asp:Parameter Name="LUGAR_CORTE" Type="String" />
        <asp:Parameter Name="FECHA_CONTRA" Type="DateTime" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRE_TRANS" Type="String" />
        <asp:Parameter Name="NIT_TRANS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="COD_CONTRATO" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECINI" Type="DateTime" />
        <asp:Parameter Name="FECFIN" Type="DateTime" />
        <asp:Parameter Name="LUGAR_CORTE" Type="String" />
        <asp:Parameter Name="FECHA_CONTRA" Type="DateTime" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="NOMBRE_TRANS" Type="String" />
        <asp:Parameter Name="NIT_TRANS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
