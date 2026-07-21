<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaLOTES_LG.ascx.vb" Inherits="controles_ucListaLOTES_LG" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<script type="text/javascript">
    var currentColumnName;
    function Grid_BatchEditConfirmShowing(s, e) {
        alert(e.requestTriggerID);        
    }
    function OnBatchEditStartEditing(s, e) {
        currentColumnName = e.focusedColumn.fieldName;
    }
    function OnBatchEditEndEditing(s, e) {
        window.setTimeout(function () {
            var area = s.batchEditApi.GetCellValue(e.visibleIndex, "AREA");
            var toneladas = s.batchEditApi.GetCellValue(e.visibleIndex, "TONELADAS");
            s.batchEditApi.SetCellValue(e.visibleIndex, "TONEL_CALC", area * toneladas);
        }, 10);
    }

    function OnAllCheckedChanged(s, e) {        
        if (s.GetChecked())
            grid.SelectRows();
        else
            grid.UnselectRows();
    }
    function SeleccionFila(s, e) {             
        if (s.cpVisibleCheckTodos)
            chkTodo.SetChecked(s.GetSelectedRowCount() == s.cpVisibleRowCount && s.cpVisibleRowCount > 0);
        if (s.cpPlanCosechaCallback)            
            cpMantPLAN_COSECHA.PerformCallback('ObtenerSaldosLote');
    }

    function CallbackLotes(s, e) {        
        cpMantCONTRATO_LG.PerformCallback('TotalizarMZ_TONEL');
    }
</script>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  
    KeyFieldName="ACCESLOTE" Font-Size="X-Small" ClientInstanceName="grid" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents SelectionChanged="SeleccionFila" EndCallback="CallbackLotes" RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
        CustomButtonClick="function(s,e){                                                  
                            switch(e.buttonID){
                                case 'btnEditarLoteMaestro':                                                                                                                                      
                                    EditarLote(s.cpKeyMaestroLotes[e.visibleIndex]);
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
            <CancelButton Text="Cancelar"></CancelButton>
            <UpdateButton Text="Guardar"></UpdateButton>
            <EditButton Text="Editar" Visible="False"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Width="10px" Visible="false" VisibleIndex="0">            
            <HeaderCaptionTemplate>
                <dx:ASPxCheckBox ID="chkTodo" ClientInstanceName="chkTodo" Visible="<%#GetCheckBoxVisible()%>" EnableViewState="true" OnInit="chkTodo_Init" runat="server" ToolTip="Seleccionar todos los lotes">                   
                    <ClientSideEvents CheckedChanged="OnAllCheckedChanged" />
                </dx:ASPxCheckBox>                
            </HeaderCaptionTemplate>            
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>     
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" Visible="true" ReadOnly="True" VisibleIndex="2" Caption="Acceslote"  />
        <dx:GridViewDataTextColumn FieldName="CUI" VisibleIndex="3" Caption="CUI" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ANIOZAFRA" VisibleIndex="4" Caption="Zafra" />
        <dx:GridViewDataTextColumn FieldName="NO_CONTRATO" Width="80px" Visible="false" VisibleIndex="4" Caption="Contrato" UnboundType="String" CellStyle-HorizontalAlign="Right" > 
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNO_CONTRATO" runat="server" Text='<%# Eval("NO_CONTRATO") %>' ></dx:ASPxLabel>
            </EditItemTemplate>   
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODILOTE" EditFormSettings-Visible="False" VisibleIndex="5" Caption="Cod. Comercial" > 
            <Settings AllowAutoFilter = "False" />
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblCODILOTE" runat="server" Text='<%# Eval("CODILOTE") %>' ></dx:ASPxLabel>
            </EditItemTemplate>      
        </dx:GridViewDataTextColumn>     
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" VisibleIndex="6" Caption="Nombre Comercial" Settings-AutoFilterCondition="Contains">         
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataSpinEditColumn FieldName="AREA" VisibleIndex="7" Caption="Area/Mz" >
            <Settings AllowAutoFilter = "False" />
            <PropertiesSpinEdit MinValue="0" ></PropertiesSpinEdit>  
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="AREA_CANA" VisibleIndex="7" Caption="Area Caña" Width="110px"  >
            <Settings AllowAutoFilter = "False" />
            <PropertiesSpinEdit MinValue="0" ></PropertiesSpinEdit>  
        </dx:GridViewDataSpinEditColumn>        
        <dx:GridViewDataSpinEditColumn FieldName="TONELADAS" VisibleIndex="8" Caption="Ton/Mz" >     
            <Settings AllowAutoFilter = "False" />   
            <PropertiesSpinEdit MinValue="0" ></PropertiesSpinEdit>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_TC" EditFormSettings-Visible="False" VisibleIndex="9" Caption="Tonel TC" >
            <Settings AllowAutoFilter = "False" />
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblTONEL_TC" runat="server" Text='<%# Eval("TONEL_TC") %>' ></dx:ASPxLabel>
            </EditItemTemplate>      
            <PropertiesTextEdit  />
        </dx:GridViewDataTextColumn>  
        <dx:GridViewDataTextColumn FieldName="MZ_CENSO" Visible="false" VisibleIndex="10" UnboundType="Decimal" Caption="Area Esticaña" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_MZ_CENSO" Visible="false" VisibleIndex="10" UnboundType="Decimal" Caption="TC/MZ Esticaña" />
        <dx:GridViewDataTextColumn FieldName="TONEL_CENSO" Visible="false" VisibleIndex="10" UnboundType="Decimal" Caption="TC Esticaña" />      
        <dx:GridViewDataSpinEditColumn FieldName="EDAD_LOTE" VisibleIndex="10" Caption="Corte" >
            <Settings AllowAutoFilter = "False" />
            <PropertiesSpinEdit MinValue="1" MaxValue="9999"></PropertiesSpinEdit>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataComboBoxColumn FieldName="CODIVARIEDA" VisibleIndex="11" Caption="Variedad" >
            <Settings AllowAutoFilter = "False" />
            <PropertiesComboBox DropDownStyle="DropDownList" DataSourceID="odsVariedad" ValueField="CODIVARIEDA" TextField="NOM_VARIEDAD" ValueType="System.String" TextFormatString="{0} ({1})" IncrementalFilteringMode="Contains" >
            <Columns>
                <dx:ListBoxColumn Caption="Codigo" FieldName="CODIVARIEDA" Width="80px" />
                <dx:ListBoxColumn Caption="Descripcion" FieldName="NOM_VARIEDAD" Width="180px" />
            </Columns>
            </PropertiesComboBox> 
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataTextColumn FieldName="NOM_VARIEDAD" VisibleIndex="11" EditFormSettings-Visible="False" Visible="false" UnboundType="String" Caption="Variedad" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CANTON" VisibleIndex="12" EditFormSettings-Visible="False" UnboundType="String" Caption="Canton"  >
            <Settings AllowAutoFilter = "False" />
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNOMBRE_CANTON" runat="server" Text='<%# Eval("NOMBRE_CANTON") %>' ></dx:ASPxLabel>
            </EditItemTemplate>      
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="ZONA" CellStyle-HorizontalAlign="Center" VisibleIndex="13" EditFormSettings-Visible="False" Caption="Zona"  >
            <Settings AllowAutoFilter = "False" />
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblZONA" runat="server" Text='<%# Eval("ZONA") %>' ></dx:ASPxLabel>
            </EditItemTemplate>      
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="CODISOCIO" VisibleIndex="14" UnboundType="String" Caption="Socio">
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblCODISOCIO" runat="server" Text='<%# Eval("CODISOCIO") %>' ></dx:ASPxLabel>
            </EditItemTemplate>  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODISOCIO_NUMERICO" VisibleIndex="14" CellStyle-HorizontalAlign="Right" UnboundType="String" Caption="Socio">
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblCODISOCIO" runat="server" Text='<%# Eval("CODISOCIO_NUMERICO") %>' ></dx:ASPxLabel>
            </EditItemTemplate>  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_SOCIO" EditFormSettings-Visible="False" VisibleIndex="15" UnboundType="String" Caption="Nombre Socio" Settings-AutoFilterCondition="Contains">        
            <Settings HeaderFilterMode="CheckedList" />            
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNOMBRE_SOCIO" runat="server" Text='<%# Eval("NOMBRE_SOCIO") %>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataComboBoxColumn FieldName="TIPO_DERECHO" VisibleIndex="15" Caption="Tenencia Tierra" >
            <Settings AllowAutoFilter = "False" />
            <PropertiesComboBox DropDownStyle="DropDownList" ValueType="System.Int32" IncrementalFilteringMode="Contains" >
            <Items>
                <dx:ListEditItem Text="PROPIETARIO" Value="1" />
                <dx:ListEditItem Text="ARRENDATARIO" Value="2" />
                <dx:ListEditItem Text="ASIGNATARIO" Value="3" />
            </Items>           
            </PropertiesComboBox> 
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" Visible="false" VisibleIndex="16" Caption="Codiproveedor" />                
        <dx:GridViewDataTextColumn FieldName="CODIAGRON" Visible="false" VisibleIndex="17" Caption="Codiagron" />        
        <dx:GridViewDataTextColumn FieldName="CODIUBICACION" Visible="false" VisibleIndex="19" Caption="Codiubicacion" />
        <dx:GridViewDataTextColumn FieldName="CODICONTRATO" Visible="false" VisibleIndex="20" Caption="Contrato" />                  
        <dx:GridViewDataTextColumn FieldName="USER_CREA" Visible="false" VisibleIndex="24" Caption="User crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" Visible="false" VisibleIndex="25" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USER_ACT" Visible="false" VisibleIndex="26" Caption="User act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" Visible="false" VisibleIndex="27" Caption="Fecha act" />               
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" Visible="false" VisibleIndex="38" Caption="Id zafra" />
        <dx:GridViewDataTextColumn FieldName="ID_MAESTRO" Visible="false" VisibleIndex="38" Caption="Id maestro" />        
        <dx:GridViewDataTextColumn FieldName="CODIAGRON" Visible="false" VisibleIndex="40" Caption="Cód. Tec." />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_AGRONOMO" Visible="false" VisibleIndex="41" UnboundType="String" Caption="Técnico asignado" />
        <dx:GridViewDataTextColumn FieldName="TIPO_CANA" EditFormSettings-Visible="False" VisibleIndex="42" UnboundType="String" Caption="Tipo Caña" Settings-AutoFilterCondition="Contains" Visible="false" >                              
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblTIPO_CANA" runat="server" Font-Size="XX-Small" Text='<%# Eval("TIPO_CANA")%>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TIPO_ROZA" EditFormSettings-Visible="False" VisibleIndex="42" UnboundType="String" Caption="Tipo Roza" Settings-AutoFilterCondition="Contains" Visible="false" >                              
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblTIPO_ROZA" runat="server" Font-Size="XX-Small" Text='<%# Eval("TIPO_ROZA")%>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TIPO_ALZA" EditFormSettings-Visible="False" VisibleIndex="42" UnboundType="String" Caption="Tipo Alza" Settings-AutoFilterCondition="Contains" Visible="false" >                              
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblTIPO_ALZA" runat="server" Font-Size="XX-Small" Text='<%# Eval("TIPO_ROZA")%>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TIPO_TRANS" EditFormSettings-Visible="False" VisibleIndex="42" UnboundType="String" Caption="Tipo Transporte" Settings-AutoFilterCondition="Contains" Visible="false" >                              
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblTIPO_TRANS" runat="server" Font-Size="XX-Small" Text='<%# Eval("TIPO_TRANS")%>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>

        <dx:GridViewDataCheckColumn FieldName="RIESGO_PIEDRA" VisibleIndex="42" Caption="Riesgo piedra" Visible="false" >
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataCheckColumn FieldName="REPARA_ACCESO" VisibleIndex="42" Caption="Repara. acceso" Visible="false" >
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataCheckColumn FieldName="SIN_ACCESO_PROPIO" VisibleIndex="42" Caption="Sin acceso propio" Visible="false" >
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataTextColumn FieldName="HACIENDA" VisibleIndex="42" Caption="Hacienda" UnboundType="String" Visible="false" >
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="42" AllowDragDrop="False" Visible="false" Caption=" " Name="colEditarLoteMaestro" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEditarLoteMaestro" Image-IconID="format_pictureshapeoutlinecolor_16x16" Image-ToolTip="Editar Lote Maestro">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewDataTextColumn FieldName="CONTRATO_TRASPASO" Visible="false" Width="130px" VisibleIndex="42" Caption="Traspaso del Contrato" UnboundType="String" > 
            <Settings AllowAutoFilter = "False" />
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNO_CONTRATO_TRASPASO" runat="server" Font-Size="XX-Small" Text='<%# Eval("CONTRATO_TRASPASO") %>' ></dx:ASPxLabel>
            </EditItemTemplate>      
        </dx:GridViewDataTextColumn>         
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="42">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>       
       <Settings ShowFilterRow="true" /> 
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO" runat="server" TypeName="SISPACAL.BL.cLOTES_LG" SelectMethod="ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR_CONTRATADO" >       
     <SelectParameters>       
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODIAGRON" Type="String" />
     </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsZAFRA_CONTRATADA_PROVEEDOR" runat="server" TypeName="SISPACAL.BL.cLOTES_LG" SelectMethod="ObtenerListaPorZAFRA_CONTRATADA_PROVEEDOR" >       
     <SelectParameters>       
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODIAGRON" Type="String" />
     </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA_NO_CONTRATO" runat="server" TypeName="SISPACAL.BL.cLOTES_LG" SelectMethod="ObtenerListaPorZAFRA_NO_CONTRATO" >       
     <SelectParameters>       
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="NO_CONTRATO" Type="Int32" />        
     </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCriterios2" runat="server" TypeName="SISPACAL.BL.cLOTES_LG" SelectMethod="ObtenerListaPorCriterios2" >       
     <SelectParameters>       
        <asp:Parameter DefaultValue="0" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="" Name="SUB_ZONA" Type="String" />        
        <asp:Parameter DefaultValue="" Name="CODI_DEPTO" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODI_MUNI" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODI_CANTON" Type="String" />        
        <asp:Parameter DefaultValue="" Name="CODIPROVEE" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODISOCIO" Type="String" />
        <asp:Parameter DefaultValue="" Name="NOMBRE_PROVEEDOR" Type="String" />
     </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLotesCache" runat="server" TypeName="cLOTES_LGcache" SelectMethod="ObtenerLista" UpdateMethod="ActualizarLOTES_LG">       
     <SelectParameters>       
        <asp:Parameter Name="nombreSesion" Type="String" />
     </SelectParameters>
     <UpdateParameters>    
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />      
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />             
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="TIPO_DERECHO" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="ID_LOTE_TRASPASO" Type="Int32" />
        <asp:Parameter Name="AREA_CANA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="REPARA_ACCESO" Type="Boolean" />
        <asp:Parameter Name="SIN_ACCESO_PROPIO" Type="Boolean" />
    </UpdateParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsVariedad" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cVARIEDAD">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="false" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="CODIVARIEDA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarLOTES_LG" DeleteMethod="EliminarLOTES_LG" UpdateMethod="ActualizarLOTES_LG"
    TypeName="SISPACAL.BL.cLOTES_LG">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarLOTES_LG" DeleteMethod="EliminarLOTES_LG" UpdateMethod="ActualizarLOTES_LG"
    TypeName="SISPACAL.BL.cLOTES_LG">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorAGRONOMO" runat="server" 
    SelectMethod="ObtenerListaPorAGRONOMO" InsertMethod="AgregarLOTES_LG" DeleteMethod="EliminarLOTES_LG" UpdateMethod="ActualizarLOTES_LG"
    TypeName="SISPACAL.BL.cLOTES_LG">
    <SelectParameters>
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorVARIEDAD" runat="server" 
    SelectMethod="ObtenerListaPorVARIEDAD" InsertMethod="AgregarLOTES_LG" DeleteMethod="EliminarLOTES_LG" UpdateMethod="ActualizarLOTES_LG"
    TypeName="SISPACAL.BL.cLOTES_LG">
    <SelectParameters>
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorUBICACION" runat="server" 
    SelectMethod="ObtenerListaPorUBICACION" InsertMethod="AgregarLOTES_LG" DeleteMethod="EliminarLOTES_LG" UpdateMethod="ActualizarLOTES_LG"
    TypeName="SISPACAL.BL.cLOTES_LG">
    <SelectParameters>
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO_LG" InsertMethod="AgregarLOTES_LG" DeleteMethod="EliminarLOTES_LG" UpdateMethod="ActualizarLOTES_LG"
    TypeName="SISPACAL.BL.cLOTES_LG">
    <SelectParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />        
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMAESTRO_LOTES" runat="server" 
    SelectMethod="ObtenerListaPorMAESTRO_LOTES" InsertMethod="AgregarLOTES_LG" DeleteMethod="EliminarLOTES_LG" UpdateMethod="ActualizarLOTES_LG"
    TypeName="SISPACAL.BL.cLOTES_LG">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarLOTES_LG" DeleteMethod="EliminarLOTES" UpdateMethod="ActualizarLOTES_LG"
    TypeName="SISPACAL.BL.cLOTES_LG">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ANIOZAFRA" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="CODIUBICACION" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONELADAS" Type="Decimal" />
        <asp:Parameter Name="TONEL_TC" Type="Decimal" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="EDAD_LOTE" Type="Decimal" />
        <asp:Parameter Name="FFCHPROXENT" Type="DateTime" />
        <asp:Parameter Name="TONXENTREGAR" Type="Decimal" />
        <asp:Parameter Name="ENTREGADA" Type="Int32" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="fin_lote" Type="Boolean" />
        <asp:Parameter Name="REND_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="LBS_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRATADO" Type="Decimal" />
        <asp:Parameter Name="REND_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
