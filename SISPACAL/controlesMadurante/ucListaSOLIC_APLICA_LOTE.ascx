<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_APLICA_LOTE.ascx.vb" Inherits="controles_ucListaSOLIC_APLICA_LOTE" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>




<script type="text/javascript">
    var currentColumnName;

    function OnGridSelectionChanged(s, e) {
        CallbackUcVistaDetalle();
    }

    function CallbackUcVistaDetalle() {
        cpVistaDetalleSOLIC_APLICACION.PerformCallback('TotalizarMZ');
    }
    function OnAllCheckedChanged(s, e) {
        if (s.GetChecked())
            grid.SelectRows();
        else
            grid.UnselectRows();
    }       
    
</script>

<dx:ASPxGridView ID="dxgvLista" runat="server" ClientInstanceName="grid" AutoGenerateColumns="False" KeyFieldName="ID_SOLIC_APLICA_LOTE" Width="100%" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>     
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Caption=" " ButtonType="Image" Width="60px" Visible="False">
            <NewButton Visible="False" Image-ToolTip="Agregar" Image-IconID="actions_new_16x16" >
                <Image ToolTip="Agregar" IconID="actions_new_16x16"></Image>
            </NewButton>      
            <EditButton Visible="False" Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" >
                <Image ToolTip="Editar" IconID="edit_edit_16x16"></Image>
            </EditButton>            
            <UpdateButton Visible="False" Image-ToolTip="Guardar" Image-IconID="save_save_16x16" >
                <Image ToolTip="Guardar" IconID="save_save_16x16"></Image>
            </UpdateButton>                     
            <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" >
                <Image ToolTip="Cancelar" IconID="history_undo_16x16"></Image>
            </CancelButton>    
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Width="10px" Visible="false" VisibleIndex="0">            
            <HeaderCaptionTemplate>
                <dx:ASPxCheckBox ID="chkTodo" ClientInstanceName="chkTodo" Visible="<%#GetCheckBoxVisible()%>" EnableViewState="true" OnInit="chkTodo_Init" runat="server" ToolTip="Seleccionar todos los lotes">                   
                    <ClientSideEvents CheckedChanged="OnAllCheckedChanged" />
                </dx:ASPxCheckBox>                
            </HeaderCaptionTemplate>            
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn FieldName="ID_SOLIC_APLICA_LOTE" ReadOnly="True" VisibleIndex="2" Caption="Id solic aplica lote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="3" Caption="Id solicitud" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NO_SOLICITUD" VisibleIndex="4" Caption="N° Solicitud" UnboundType="Integer" SortIndex="0" SortOrder="Descending" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNO_SOLICITUD" runat="server" Text='<%# Eval("NO_SOLICITUD")%>' ></dx:ASPxLabel>
            </EditItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="5" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="6" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="7" Caption="Cód. Productor" UnboundType="Integer" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblCODIPROVEEDOR" runat="server" Text='<%# Eval("CODIPROVEEDOR")%>' ></dx:ASPxLabel>
            </EditItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="8" Caption="Productor" UnboundType="String" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNOMBRE_PROVEEDOR" runat="server" Text='<%# Eval("NOMBRE_PROVEEDOR")%>' ></dx:ASPxLabel>
            </EditItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODILOTE" UnboundType="String" VisibleIndex="9" Caption="Cod. lote" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblCODILOTE" runat="server" Text='<%# Eval("CODILOTE") %>' ></dx:ASPxLabel>
            </EditItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" VisibleIndex="10" UnboundType="String" Caption="Nombre lote" >          
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNOMBLOTE" runat="server" Text='<%# Eval("NOMBLOTE") %>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataSpinEditColumn FieldName="MZ" VisibleIndex="11" CellStyle-Font-Bold="true" Caption="Area MZ" >        
            <Settings AllowAutoFilter = "False" />                        
            <PropertiesSpinEdit ClientInstanceName="speMZ" DecimalPlaces="2" AllowNull="false" runat="server"> 
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right" Font-Bold="true"></Style>
            </PropertiesSpinEdit>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataTextColumn FieldName="TC_MZ" VisibleIndex="12" Caption="TC/MZ" CellStyle-HorizontalAlign="Right" UnboundType="Decimal" >        
            <Settings AllowAutoFilter = "False" />    
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />  
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblTC_MZ" runat="server" Text='<%# Eval("TC_MZ")%>' ></dx:ASPxLabel>
            </EditItemTemplate>                                          

<CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TONELADAS" VisibleIndex="13" Caption="Toneladas" >        
            <Settings AllowAutoFilter = "False" />                        
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />  
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblTONELADAS" runat="server" Text='<%# Eval("TONELADAS")%>' ></dx:ASPxLabel>
            </EditItemTemplate>  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataDateColumn FieldName="FECHA_APLICA" VisibleIndex="14" CellStyle-Font-Bold="true" CellStyle-HorizontalAlign="Center" Caption="Fecha de Aplicación" >
            <PropertiesDateEdit AllowNull="true" AllowUserInput="true" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" ></PropertiesDateEdit>             
            <EditCellStyle BackColor="Yellow" Font-Bold="true" />     
<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataDateColumn FieldName="FECHA_INI_VENTANA" VisibleIndex="15" Caption="Fecha Inicial de Ventana" CellStyle-BackColor="LightGreen" CellStyle-HorizontalAlign="Center" ReadOnly="true">
            <PropertiesDateEdit AllowNull="true" AllowUserInput="true" DisplayFormatString="dd/MM/yyyy" UseMaskBehavior="true" ></PropertiesDateEdit>                        

<CellStyle HorizontalAlign="Center" BackColor="LightGreen"></CellStyle>
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataDateColumn FieldName="FECHA_FIN_VENTANA" VisibleIndex="16" Caption="Fecha Final de Ventana" CellStyle-BackColor="Red" CellStyle-HorizontalAlign="Center" ReadOnly="true">
            <PropertiesDateEdit AllowNull="true" AllowUserInput="true" DisplayFormatString="dd/MM/yyyy" UseMaskBehavior="true" ></PropertiesDateEdit>                        

<CellStyle HorizontalAlign="Center" BackColor="#FF6666"></CellStyle>
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataDateColumn FieldName="FECHA_ROZA_MADURANTE" VisibleIndex="17" Caption="Fecha Roza de Ventana" CellStyle-HorizontalAlign="Center" ReadOnly="true">
            <PropertiesDateEdit AllowNull="true" AllowUserInput="true" DisplayFormatString="dd/MM/yyyy" UseMaskBehavior="true" ></PropertiesDateEdit>                        

<CellStyle HorizontalAlign="Center" BackColor="#99CCFF"></CellStyle>
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PRODUCTO" VisibleIndex="18" Caption="Id producto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PRODUCTO" UnboundType="String" VisibleIndex="19" Caption="Producto" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNOMBRE_PRODUCTO" runat="server" Text='<%# Eval("NOMBRE_PRODUCTO") %>' ></dx:ASPxLabel>
            </EditItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataSpinEditColumn FieldName="CANT_X_MZ" VisibleIndex="20" Caption="Dosis MZ" Width="100px" Visible="false" >            
            <PropertiesSpinEdit ClientInstanceName="speCANT_X_MZ" DecimalPlaces="4" AllowNull="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="TOTAL_PRODUCTO" VisibleIndex="21" ReadOnly="true" Caption="Total Producto" Width="100px" Visible="false" >
            <PropertiesSpinEdit ClientInstanceName="speTOTAL_PRODUCTO" DecimalPlaces="4" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>            
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataTextColumn FieldName="VARIEDAD" UnboundType="String" VisibleIndex="22" Caption="Variedad" Visible="false" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblVARIEDAD" runat="server" Text='<%# Eval("VARIEDAD") %>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="UBICACION" UnboundType="String" VisibleIndex="23" Caption="Ubicación" Visible="false" >
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblUBICACION" Font-Size="X-Small" runat="server" Text='<%# Eval("UBICACION") %>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>                
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="24" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="25" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="26" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="28" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="29" Caption="Zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_MAESTRO" VisibleIndex="30" Caption="Id maestro" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="27">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>   
    <SettingsEditing Mode="Inline" />
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<dx:ASPxHiddenField runat="server" ClientInstanceName="hfSolicAplicaLote" ID="hfSolicAplicaLote" />


<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" TypeName="SISPACAL.BL.cSOLIC_APLICA_LOTE" SelectMethod="ObtenerListaPorCriterios" UpdateMethod="ActualizarMZ"  >       
     <SelectParameters>       
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="NUM_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
     </SelectParameters>  
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />       
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
    </UpdateParameters>   
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSolicAplicaLoteCache" runat="server" TypeName="cSOLIC_APLICA_LOTEcache" SelectMethod="ObtenerLista" UpdateMethod="Actualizar">       
     <SelectParameters>       
        <asp:Parameter Name="nombreSesion" Type="String" />
     </SelectParameters>
     <UpdateParameters>    
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />     
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />  
        <asp:Parameter Name="REFERENCIA" Type="String" />        
    </UpdateParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_APLICA_LOTE" DeleteMethod="EliminarSOLIC_APLICA_LOTE" UpdateMethod="ActualizarSOLIC_APLICA_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_APLICA_LOTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_AGRICOLA" InsertMethod="AgregarSOLIC_APLICA_LOTE" DeleteMethod="EliminarSOLIC_APLICA_LOTE" UpdateMethod="ActualizarSOLIC_APLICA_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_APLICA_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarSOLIC_APLICA_LOTE" DeleteMethod="EliminarSOLIC_APLICA_LOTE" UpdateMethod="ActualizarSOLIC_APLICA_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_APLICA_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarSOLIC_APLICA_LOTE" DeleteMethod="EliminarSOLIC_APLICA_LOTE" UpdateMethod="ActualizarSOLIC_APLICA_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_APLICA_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMAESTRO_LOTES" runat="server" 
    SelectMethod="ObtenerListaPorMAESTRO_LOTES" InsertMethod="AgregarSOLIC_APLICA_LOTE" DeleteMethod="EliminarSOLIC_APLICA_LOTE" UpdateMethod="ActualizarSOLIC_APLICA_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_APLICA_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
