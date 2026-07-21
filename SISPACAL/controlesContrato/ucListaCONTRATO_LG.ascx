<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTRATO_LG.ascx.vb" Inherits="controles_ucListaCONTRATO_LG" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<%@ Register src="ucVistaDetalleCONTRATO.ascx" tagname="ucVistaDetalleCONTRATO" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsCriterios" KeyFieldName="CODICONTRATO" Width="100%" >    
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
                                    MostrarContratoLegalZafra(s.GetRowKey(e.visibleIndex));
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
                      }"          
    />
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
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("CODICONTRATO") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("CODICONTRATO") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption="Ver Reporte Contrato" Name="colVistaPrevia" ButtonType="Image" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Width="50px"   >
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa del Contrato">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="CODICONTRATO" Visible="false" ReadOnly="True" VisibleIndex="2" Caption="Codicontrato" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="3" UnboundType="String" Caption="Zafra en que Ingreso Contrato" />
        <dx:GridViewDataTextColumn FieldName="NO_CONTRATO" ReadOnly="True" VisibleIndex="4" Caption="N° Contrato" />        
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR"  Visible="false" VisibleIndex="5" Caption="Codiproveedor" />        
        <dx:GridViewDataTextColumn FieldName="FECHA_CONTRATOCB" VisibleIndex="6" Caption="Fecha Contrato" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy" />                               
        <dx:GridViewDataTextColumn FieldName="ESTADO_CONTRATOCB" Visible="false" VisibleIndex="7" Caption="Estado contratocb" />
        <dx:GridViewDataTextColumn FieldName="FINANCOADO" Visible="false" VisibleIndex="8" Caption="Financoado" />
        <dx:GridViewDataTextColumn FieldName="FINAN_NUMERO" Visible="false" VisibleIndex="9" Caption="Finan numero" />
        <dx:GridViewDataTextColumn FieldName="TOTALMZ_CONTRATOCB" Visible="false" VisibleIndex="13" Caption="Totalmz contratocb" />
        <dx:GridViewDataTextColumn FieldName="TONELADAS_CONTRATOCB" Visible="false" VisibleIndex="14" Caption="Toneladas contratocb" />
        <dx:GridViewDataTextColumn FieldName="OBSERVACIONES_CONTRATOCB" Visible="false" VisibleIndex="15" Caption="Observaciones contratocb" />
        <dx:GridViewDataTextColumn FieldName="USER_CREA" Visible="false" VisibleIndex="16" Caption="User crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" Visible="false" VisibleIndex="17" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USER_ACT" Visible="false" VisibleIndex="18" Caption="User act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" Visible="false" VisibleIndex="19" Caption="Fecha act" />
        <dx:GridViewDataTextColumn FieldName="NO_REGISTRO" VisibleIndex="21" Caption="No registro" />
        <dx:GridViewDataTextColumn FieldName="FECHA_REGISTRO" VisibleIndex="22" Caption="Fecha registro" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="23" UnboundType="String" Caption="Cod. Provee" />
        <dx:GridViewDataTextColumn FieldName="CODISOCIO" VisibleIndex="24" UnboundType="String" Caption="Cod. Socio" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="25" Caption="Apellidos" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="26" Caption="Nombres" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" Visible="false" VisibleIndex="27" Caption="Direccion" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" Visible="false" VisibleIndex="28" Caption="Telefono" />
        <dx:GridViewDataTextColumn FieldName="CELULAR" Visible="false" VisibleIndex="29" Caption="Celular" />
        <dx:GridViewDataTextColumn FieldName="DUI" Visible="false" VisibleIndex="30" Caption="Dui" />
        <dx:GridViewDataTextColumn FieldName="NIT" Visible="false" VisibleIndex="31" Caption="Nit" />
        <dx:GridViewDataTextColumn FieldName="CREDITFISCAL" Visible="false" VisibleIndex="32" Caption="Creditfiscal" />
        <dx:GridViewDataTextColumn FieldName="APODERADO" Visible="false" VisibleIndex="33" Caption="Apoderado" />
        <dx:GridViewDataTextColumn FieldName="DUI_APODERADO" Visible="false" VisibleIndex="34" Caption="Dui apoderado" />
        <dx:GridViewDataTextColumn FieldName="NIT_APODERADO" Visible="false" VisibleIndex="35" Caption="Nit apoderado" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" Visible="false" VisibleIndex="36" Caption="Id zafra" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="37">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<dx:ASPxHiddenField ID="hfListaCONTRATO" ClientInstanceName="hfListaCONTRATO" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>
<asp:ObjectDataSource ID="odsCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios"  TypeName="SISPACAL.BL.cCONTRATO_LG">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" DefaultValue="0" Type="Int32" />        
        <asp:Parameter Name="NO_CONTRATO" DefaultValue="0" Type="Int32"  />        
        <asp:Parameter Name="CODIPROVEE" DefaultValue="" Type="String" />
        <asp:Parameter Name="CODISOCIO" DefaultValue="" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTRATO_LG" DeleteMethod="EliminarCONTRATO_LG" UpdateMethod="ActualizarCONTRATO_LG"
    TypeName="SISPACAL.BL.cCONTRATO_LG">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="FECHA_CONTRATOCB" Type="DateTime" />
        <asp:Parameter Name="ESTADO_CONTRATOCB" Type="Int32" />
        <asp:Parameter Name="FINANCOADO" Type="String" />
        <asp:Parameter Name="FINAN_NUMERO" Type="String" />     
        <asp:Parameter Name="TOTALMZ_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="TONELADAS_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="OBSERVACIONES_CONTRATOCB" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />        
        <asp:Parameter Name="NO_REGISTRO" Type="String" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="CELULAR" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="CREDITFISCAL" Type="String" />
        <asp:Parameter Name="APODERADO" Type="String" />
        <asp:Parameter Name="DUI_APODERADO" Type="String" />
        <asp:Parameter Name="NIT_APODERADO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="FECHA_CONTRATOCB" Type="DateTime" />
        <asp:Parameter Name="ESTADO_CONTRATOCB" Type="Int32" />
        <asp:Parameter Name="FINANCOADO" Type="String" />
        <asp:Parameter Name="FINAN_NUMERO" Type="String" />
        <asp:Parameter Name="TOTALMZ_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="TONELADAS_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="OBSERVACIONES_CONTRATOCB" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="NO_REGISTRO" Type="String" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="CELULAR" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="CREDITFISCAL" Type="String" />
        <asp:Parameter Name="APODERADO" Type="String" />
        <asp:Parameter Name="DUI_APODERADO" Type="String" />
        <asp:Parameter Name="NIT_APODERADO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarCONTRATO_LG" DeleteMethod="EliminarCONTRATO_LG" UpdateMethod="ActualizarCONTRATO_LG"
    TypeName="SISPACAL.BL.cCONTRATO_LG">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="FECHA_CONTRATOCB" Type="DateTime" />
        <asp:Parameter Name="ESTADO_CONTRATOCB" Type="Int32" />
        <asp:Parameter Name="FINANCOADO" Type="String" />
        <asp:Parameter Name="FINAN_NUMERO" Type="String" />
        <asp:Parameter Name="TOTALMZ_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="TONELADAS_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="OBSERVACIONES_CONTRATOCB" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="NO_REGISTRO" Type="String" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="CELULAR" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="CREDITFISCAL" Type="String" />
        <asp:Parameter Name="APODERADO" Type="String" />
        <asp:Parameter Name="DUI_APODERADO" Type="String" />
        <asp:Parameter Name="NIT_APODERADO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="FECHA_CONTRATOCB" Type="DateTime" />
        <asp:Parameter Name="ESTADO_CONTRATOCB" Type="Int32" />
        <asp:Parameter Name="FINANCOADO" Type="String" />
        <asp:Parameter Name="FINAN_NUMERO" Type="String" />
        <asp:Parameter Name="TOTALMZ_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="TONELADAS_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="OBSERVACIONES_CONTRATOCB" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="NO_REGISTRO" Type="String" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="CELULAR" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="CREDITFISCAL" Type="String" />
        <asp:Parameter Name="APODERADO" Type="String" />
        <asp:Parameter Name="DUI_APODERADO" Type="String" />
        <asp:Parameter Name="NIT_APODERADO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCONTRATO_LG" DeleteMethod="EliminarCONTRATO_LG" UpdateMethod="ActualizarCONTRATO_LG"
    TypeName="SISPACAL.BL.cCONTRATO_LG">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="FECHA_CONTRATOCB" Type="DateTime" />
        <asp:Parameter Name="ESTADO_CONTRATOCB" Type="Int32" />
        <asp:Parameter Name="FINANCOADO" Type="String" />
        <asp:Parameter Name="FINAN_NUMERO" Type="String" />
        <asp:Parameter Name="TOTALMZ_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="TONELADAS_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="OBSERVACIONES_CONTRATOCB" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="NO_REGISTRO" Type="String" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="CELULAR" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="CREDITFISCAL" Type="String" />
        <asp:Parameter Name="APODERADO" Type="String" />
        <asp:Parameter Name="DUI_APODERADO" Type="String" />
        <asp:Parameter Name="NIT_APODERADO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="FECHA_CONTRATOCB" Type="DateTime" />
        <asp:Parameter Name="ESTADO_CONTRATOCB" Type="Int32" />
        <asp:Parameter Name="FINANCOADO" Type="String" />
        <asp:Parameter Name="FINAN_NUMERO" Type="String" />
        <asp:Parameter Name="TOTALMZ_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="TONELADAS_CONTRATOCB" Type="Decimal" />
        <asp:Parameter Name="OBSERVACIONES_CONTRATOCB" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="NO_REGISTRO" Type="String" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="CELULAR" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="CREDITFISCAL" Type="String" />
        <asp:Parameter Name="APODERADO" Type="String" />
        <asp:Parameter Name="DUI_APODERADO" Type="String" />
        <asp:Parameter Name="NIT_APODERADO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
