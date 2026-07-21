<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaESTICANA.ascx.vb" Inherits="controles_ucListaESTICANA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<script type="text/javascript">
    function CalcularTONEL_ESTICANA(s, e) {
        var mz;
        var tc_mz;
        var total;

        if (isNumber(spMZ_CENSO.GetValue()))
            mz = round(spMZ_CENSO.GetValue(), 2);
        else
            mz = 0;        
        
        if (isNumber(spTONEL_MZ_CENSO.GetValue()))
            tc_mz = round(spTONEL_MZ_CENSO.GetValue(), 2);
        else
            tc_mz = 0;        

        total = mz * tc_mz;

        if (isNumber(total)) {
            spTONEL_CENSO.SetValue(round(total, 2));
        }
        else
            spTONEL_CENSO.SetValue(round(0, 0));
    }    
    function round(value, exp) {
        if (typeof exp === 'undefined' || +exp === 0)
            return Math.round(value);

        value = +value;
        exp = +exp;

        if (isNaN(value) || !(typeof exp === 'number' && exp % 1 === 0))
            return NaN;

        // Shift
        value = value.toString().split('e');
        value = Math.round(+(value[0] + 'e' + (value[1] ? (+value[1] + exp) : exp)));

        // Shift back
        value = value.toString().split('e');
        return +(value[0] + 'e' + (value[1] ? (+value[1] - exp) : -exp));
    }
    function isNumber(n) {
        return !isNaN(parseFloat(n)) && isFinite(n);
    }    
</script>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="ID_ESTICANA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>        
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="30px" Visible="false" VisibleIndex="0">                         
        </dx:GridViewCommandColumn>   
        <dx:GridViewCommandColumn Name="Edicion2" ButtonType="Image" VisibleIndex="0" Visible="False" CellStyle-HorizontalAlign="Center" Width="30px" Caption=" "  >
                <NewButton Image-ToolTip="Agregar" Image-IconID="actions_new_16x16" >
                    <Image ToolTip="Agregar" IconID="actions_new_16x16"></Image>
                </NewButton>      
                <EditButton Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" >
                    <Image ToolTip="Editar" IconID="edit_edit_16x16"></Image>
                </EditButton>            
                <UpdateButton Image-ToolTip="Guardar" Image-IconID="save_save_16x16" >
                    <Image ToolTip="Guardar" IconID="save_save_16x16"></Image>
                </UpdateButton>                     
                <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" >
                <Image ToolTip="Cancelar" IconID="history_undo_16x16"></Image>
                </CancelButton>    
        </dx:GridViewCommandColumn>          
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colEditar" Width="30px" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar Esticaña" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_ESTICANA") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_ESTICANA") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>   
        
        
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colVistaControlQuema" Width="40px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnControlQuema" runat="server" AlternateText="Control de inventario de Quema" ToolTip="Control de inventario de Quema" CommandName="ControlQuema" ImageUrl="~/imagenes/fire.png"  CommandArgument='<%# Bind("ID_ESTICANA")%>'></asp:ImageButton>                               
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colVistaControlRoza" Width="40px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnControlRoza" runat="server" AlternateText="Control de inventario de Roza" ToolTip="Control de inventario de Roza" CommandName="ControlRoza" ImageUrl="~/imagenes/roza.png"  CommandArgument='<%# Bind("ID_ESTICANA")%>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colVistaControlModificacionQuema" Width="40px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnControlModiQuema" runat="server" AlternateText="Modificación de Quema en Roza" ToolTip="Modificación de Quema en Roza" CommandName="ControlModiQuema" ImageUrl="~/imagenes/firemodi.png"  CommandArgument='<%# Bind("ID_ESTICANA")%>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colEmitirProforma" Width="40px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEmitirProforma" runat="server" AlternateText="Emitir Proforma de Envío" ToolTip="Emitir Proforma de Envío" CommandName="EmitirProforma" ImageUrl="~/imagenes/proforma.png"  CommandArgument='<%# Bind("ID_ESTICANA")%>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
              
        <dx:GridViewDataTextColumn FieldName="ID_ESTICANA" ReadOnly="True" VisibleIndex="2" Caption="Id." Width="50px"  Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="3" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="4" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ZONA" VisibleIndex="4" Caption="Zona" Visible="false" Width="50px" SortOrder="Ascending" SortIndex="0" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="4" Caption="Provee" UnboundType="String" CellStyle-HorizontalAlign="Right" ReadOnly="true" Width="60px"  />
        <dx:GridViewDataTextColumn FieldName="CODISOCIO" VisibleIndex="4" Caption="Socio" UnboundType="String" CellStyle-HorizontalAlign="Right" ReadOnly="true" Width="50px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="4" Caption="Proveedor" UnboundType="String" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="CONTRATO" VisibleIndex="4" Caption="Contrato" UnboundType="String" Width="60px" CellStyle-HorizontalAlign="Right" HeaderStyle-Wrap="True" ReadOnly="true"  />
        <dx:GridViewDataTextColumn FieldName="CODILOTE" VisibleIndex="4" Caption="Codi. Lote" Width="80px" CellStyle-HorizontalAlign="Right" HeaderStyle-Wrap="True" ReadOnly="true"  />
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" VisibleIndex="4" Caption="Lote" ReadOnly="true" Width="120px" />
        <dx:GridViewDataTextColumn FieldName="EDAD_LOTE" VisibleIndex="4" Caption="Edad lote" Visible="false" ReadOnly="true" />        
        <dx:GridViewDataDateColumn FieldName="FECHA_ROZA" VisibleIndex="5" Caption="Fecha Roza" Width="100px"  >
            <PropertiesDateEdit AllowNull="true" DisplayFormatString="dd/MM/yyyy" Style-BackColor="LightYellow" />  
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="REND_COSECHA" HeaderStyle-HorizontalAlign="Center" VisibleIndex="6" Caption="Rend. Cosecha" Width="60px" HeaderStyle-Wrap="True" ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" ></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="AREA_CONTRATADA" VisibleIndex="7" Caption="MZ Contratada" Width="80px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Visible="false" ReadOnly="true" UnboundType="Decimal" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" Style-BackColor="WhiteSmoke" ></PropertiesTextEdit>
            <CellStyle BackColor="WhiteSmoke" />   
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_CONTRATADA" VisibleIndex="7" Caption="TC Contratada" Width="80px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Visible="false" ReadOnly="true" UnboundType="Decimal" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" Style-BackColor="WhiteSmoke" ></PropertiesTextEdit>
            <CellStyle BackColor="WhiteSmoke" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataSpinEditColumn FieldName="MZ_CENSO" VisibleIndex="7" Caption="MZ Esticaña" Width="70px" HeaderStyle-Wrap="True" >
            <PropertiesSpinEdit ClientInstanceName="spMZ_CENSO" DecimalPlaces="2" ClientSideEvents-ValueChanged="CalcularTONEL_ESTICANA" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>              
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="TONEL_MZ_CENSO" VisibleIndex="8" Caption="TC/MZ Esticaña" Width="70px" HeaderStyle-Wrap="True" >            
            <PropertiesSpinEdit ClientInstanceName="spTONEL_MZ_CENSO" DecimalPlaces="2"  ClientSideEvents-ValueChanged="CalcularTONEL_ESTICANA" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_CENSO" HeaderStyle-HorizontalAlign="Center" VisibleIndex="9" Caption="TC Esticaña" Width="70px" HeaderStyle-Wrap="True" ReadOnly="true" >
            <PropertiesTextEdit ClientInstanceName="spTONEL_CENSO"  DisplayFormatString="#,##0.00" ></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataSpinEditColumn FieldName="TONEL_SEMILLA" VisibleIndex="10" Caption="TC Semilla" Width="70px" HeaderStyle-Wrap="True" >
            <PropertiesSpinEdit SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_MZ_ENTREGADA" HeaderStyle-HorizontalAlign="Center" VisibleIndex="11" Caption="Tonel mz entregada" Visible="false" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="TONEL_ENTREGADA" HeaderStyle-HorizontalAlign="Center" VisibleIndex="12" Caption="TC Entregada" Width="70px" HeaderStyle-Wrap="True" ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" ></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="LBS_ENTREGADA" VisibleIndex="13" Caption="Lbs entregada" Visible="false" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="VALOR_ENTREGADA" VisibleIndex="14" Caption="Valor entregada" Visible="false" ReadOnly="true" />        
         <dx:GridViewDataTextColumn FieldName="TONEL_SALDO_VAR" HeaderStyle-HorizontalAlign="Center" VisibleIndex="15" Caption="TC Variación" Width="70px" HeaderStyle-Wrap="True" ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" ></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="MZ_ENTREGAR" HeaderStyle-HorizontalAlign="Center" VisibleIndex="16" Caption="MZ Entregar" Width="70px" HeaderStyle-Wrap="True" Visible="false" ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" ></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_MZ_ENTREGAR" HeaderStyle-HorizontalAlign="Center" VisibleIndex="17" Caption="TC/MZ Entregar" Visible="false" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="TONEL_ENTREGAR" HeaderStyle-HorizontalAlign="Center" VisibleIndex="18" Caption="Saldo TC Entregar" Width="80px" HeaderStyle-Wrap="True" ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" ></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="LBS_ENTREGAR" VisibleIndex="19" Caption="Lbs entregar" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="VALOR_ENTREGAR" HeaderStyle-HorizontalAlign="Center" VisibleIndex="20" Caption="Valor entregar" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MZ_ENTREGADA" HeaderStyle-HorizontalAlign="Center" VisibleIndex="21" Caption="MZ Entregada" Width="50px" HeaderStyle-Wrap="True" Visible="false" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" ></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="LBS_CENSO" VisibleIndex="22" Caption="Lbs censo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="VALOR_CENSO" VisibleIndex="23" Caption="Valor censo" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="24" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="25" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="26" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="27" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIAGRON" VisibleIndex="28" Caption="Codiagron" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_SIEMBRA" VisibleIndex="29" Caption="Fecha siembra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_CANA" VisibleIndex="30" Caption="Id tipo cana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_ROZA" VisibleIndex="31" Caption="Id tipo roza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_ALZA" VisibleIndex="32" Caption="Id tipo alza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_TRANS" VisibleIndex="33" Caption="Id tipo trans" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FAB_SEMANA" VisibleIndex="34" Caption="Fab semana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FABRICA_CATORCENA" VisibleIndex="34" Caption="Catorcena" Visible="false" Width="70px" CellStyle-HorizontalAlign="Center" ReadOnly="true" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="FAB_SUBTERCIO" VisibleIndex="35" Caption="Fab subtercio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FAB_TERCIO" VisibleIndex="36" Caption="Fab tercio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TARIFA_ROZA" VisibleIndex="37" Caption="Tarifa roza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TARIFA_ALZA" VisibleIndex="38" Caption="Tarifa alza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TARIFA_TRANS" VisibleIndex="39" Caption="Tarifa trans" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TARIFA_CORTA" VisibleIndex="40" Caption="Tarifa corta" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TARIFA_LARGA" VisibleIndex="41" Caption="Tarifa larga" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SALDO_QUEMA" HeaderStyle-HorizontalAlign="Center" VisibleIndex="42" Caption="Saldo Quema" Width="70px" HeaderStyle-Wrap="True" ReadOnly="true" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="SALDO_ROZA" HeaderStyle-HorizontalAlign="Center" VisibleIndex="43" Caption="Saldo Roza" Width="70px" HeaderStyle-Wrap="True" ReadOnly="true" Visible="false" />                        
        <dx:GridViewDataTextColumn FieldName="ULTIMO_MADURANTE" HeaderStyle-HorizontalAlign="Center" VisibleIndex="45" Caption="Ultimo Madurante Aplicado" Width="120px" UnboundType="String" HeaderStyle-Wrap="True" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="ULTIMA_FECHA_MADURANTE" HeaderStyle-HorizontalAlign="Center" VisibleIndex="45" Caption="Ultima Fecha Aplicación" Width="80px" UnboundType="String" HeaderStyle-Wrap="True" ReadOnly="true" />
        <dx:GridViewDataCheckColumn FieldName="FIN_LOTE" HeaderStyle-HorizontalAlign="Center" VisibleIndex="45" Caption="Fin Lote" Width="60px" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="CONTRATADO" HeaderStyle-HorizontalAlign="Center" VisibleIndex="45" Caption="Contratado" Width="60px" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
             Name="Eliminar" VisibleIndex="45">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>        
        </dx:GridViewCommandColumn>
	   </Columns>    
    <SettingsEditing Mode="Inline" /> 
    <Settings VerticalScrollBarMode="Visible" VerticalScrollBarStyle="Standard" VerticalScrollableHeight="400"    ShowFilterRow="False"  ShowHeaderFilterButton="False" />
    <SettingsBehavior AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>

<asp:ObjectDataSource ID="odsListaParaIngresoInventario" runat="server" SelectMethod="ObtenerListaParaIngresoInventario" 
    TypeName="SISPACAL.BL.cESTICANA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODIPROVEE" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODISOCIO" Type="String" />
        <asp:Parameter DefaultValue="" Name="NOMBRE_PROVEEDOR" Type="String" />                   
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" SelectMethod="ObtenerListaPorCriterios" UpdateMethod="ActualizarESTICANA"
    TypeName="SISPACAL.BL.cESTICANA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODIPROVEE" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODISOCIO" Type="String" />
        <asp:Parameter DefaultValue="" Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="" Name="NOMBLOTE" Type="String" />
        <asp:Parameter DefaultValue="" Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="CODIAGRON" Type="String" />        
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
        <asp:Parameter Name="FECHA_ROZA_DISPO" Type="DateTime" />
        <asp:Parameter Name="TONEL_SALDO_VAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_SEMILLA" Type="Decimal" />
        <asp:Parameter Name="FECHA_CIERRE" Type="DateTime" />
        <asp:Parameter Name="HORAS_GRACIA_ENTREGA" Type="Int32" />
    </UpdateParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaProforma" runat="server" SelectMethod="ObtenerListaProforma" 
    TypeName="SISPACAL.BL.cESTICANA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="TIPOS_TRANSPORTE" Type="String" />
        <asp:Parameter Name="CON_SALDO_ROZA" Type="Boolean" />               
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarESTICANA" DeleteMethod="EliminarESTICANA" UpdateMethod="ActualizarESTICANA"
    TypeName="SISPACAL.BL.cESTICANA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarESTICANA" DeleteMethod="EliminarESTICANA" UpdateMethod="ActualizarESTICANA"
    TypeName="SISPACAL.BL.cESTICANA">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarESTICANA" DeleteMethod="EliminarESTICANA" UpdateMethod="ActualizarESTICANA"
    TypeName="SISPACAL.BL.cESTICANA">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorAGRONOMO" runat="server" 
    SelectMethod="ObtenerListaPorAGRONOMO" InsertMethod="AgregarESTICANA" DeleteMethod="EliminarESTICANA" UpdateMethod="ActualizarESTICANA"
    TypeName="SISPACAL.BL.cESTICANA">
    <SelectParameters>
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPOS_GENERALES" runat="server" 
    SelectMethod="ObtenerListaPorTIPOS_GENERALES" InsertMethod="AgregarESTICANA" DeleteMethod="EliminarESTICANA" UpdateMethod="ActualizarESTICANA"
    TypeName="SISPACAL.BL.cESTICANA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGAR" Type="Decimal" />
        <asp:Parameter Name="MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="TONEL_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="LBS_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="VALOR_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_CENSO" Type="Decimal" />
        <asp:Parameter Name="TONEL_CENSO" Type="Decimal" />
        <asp:Parameter Name="LBS_CENSO" Type="Decimal" />
        <asp:Parameter Name="VALOR_CENSO" Type="Decimal" />
        <asp:Parameter Name="FIN_LOTE" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_TRANS" Type="Int32" />
        <asp:Parameter Name="FAB_SEMANA" Type="Int32" />
        <asp:Parameter Name="FAB_CATORCENA" Type="Int32" />
        <asp:Parameter Name="FAB_SUBTERCIO" Type="String" />
        <asp:Parameter Name="FAB_TERCIO" Type="Int32" />
        <asp:Parameter Name="TARIFA_ROZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_ALZA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_TRANS" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CORTA" Type="Decimal" />
        <asp:Parameter Name="TARIFA_LARGA" Type="Decimal" />
        <asp:Parameter Name="SALDO_ROZA" Type="Decimal" />
        <asp:Parameter Name="EDAD_LOTE" Type="Int32" />
        <asp:Parameter Name="SALDO_QUEMA" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ESTICANA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
