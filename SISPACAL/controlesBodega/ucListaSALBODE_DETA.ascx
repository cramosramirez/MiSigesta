<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSALBODE_DETA.ascx.vb" Inherits="controles_ucListaSALBODE_DETA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<script type="text/javascript">

    function CalcularValorTotal(s, e) {
        var total = speCANTIDAD.GetValue() * spePRECIO_UNITARIO.GetValue();
        if (isNumber(total)) {
            lblTOTAL.SetValue(round(total, 2));
        }
        else
            lblTOTAL.SetValue(round(0, 0));
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
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  KeyFieldName="ID_SALBODE_DETA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0" /> 
        <dx:GridViewCommandColumn Name="Edicion" ButtonType="Image" VisibleIndex="0" Visible="False" Width="50px" Caption=" "  >             
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
        <dx:GridViewCommandColumn Name="Edicion2" ButtonType="Image" VisibleIndex="0" Visible="False" Width="50px" Caption=" "  >               
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
        <dx:GridViewDataTextColumn FieldName="ID_SALBODE_DETA" ReadOnly="True" VisibleIndex="2" Caption="Id salbode deta" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ID_SALBODE_ENCA" VisibleIndex="3" Caption="Id salbode enca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="4" Caption="Id solicitud" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PRODUCTO" VisibleIndex="5" Caption="Id producto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NO_DOCUMENTO" VisibleIndex="6" Caption="N° Retiro" UnboundType="Integer" ReadOnly="true" Visible="false" />
        <dx:GridViewDataDateColumn FieldName="FECHA" VisibleIndex="6" Caption="Fecha sol. Retiro" UnboundType="DateTime" ReadOnly="true" Visible="false" >
            <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" />  
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="NUM_SOLICITUD" VisibleIndex="6" Caption="N° Solicitud" UnboundType="String" ReadOnly="true" />
        <dx:GridViewDataDateColumn FieldName="FECHA_SOLIC" VisibleIndex="6" Caption="Fecha Solicitud" ReadOnly="true" UnboundType="DateTime" Visible="false" >
            <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" />  
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="ESTADO_SOLIC_AGRICOLA" VisibleIndex="6" Caption="Estado Solic." UnboundType="String" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="CODI_PROVEE" VisibleIndex="6" Caption="Código" UnboundType="Integer" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="6" Caption="Productor" UnboundType="String" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR_AGRICOLA" VisibleIndex="6" Caption="Casa comercial" UnboundType="String" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PRODUCTO" VisibleIndex="6" Caption="Producto" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="UNIDAD" VisibleIndex="7" Caption="Unidad" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PRESENTACION" VisibleIndex="8" Caption="Presentacion" Width="120px" ReadOnly="true" />        
        <dx:GridViewDataTextColumn FieldName="CANTIDAD" VisibleIndex="9" Caption="Cantidad Solicitada" Width="120px"  ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00##" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataSpinEditColumn FieldName="CANT_ANULADA" VisibleIndex="9" Caption="Cantidad Anulada" Width="110px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" Visible="false" >
            <PropertiesSpinEdit DisplayFormatString="#,##0.00##"  ClientInstanceName="speCANTIDAD_ANULADA" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>            
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>  
        <dx:GridViewDataSpinEditColumn FieldName="CANT_ENTREGADA" VisibleIndex="9" Caption="Cantidad Entregada" Width="110px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" >
            <PropertiesSpinEdit DisplayFormatString="#,##0.00##"  ClientInstanceName="speCANTIDAD" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>            
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>  
        <dx:GridViewDataSpinEditColumn FieldName="PRECIO_UNITARIO" VisibleIndex="9" ReadOnly="true" Caption="Precio Unitario" Width="100px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" Visible="false" >
            <PropertiesSpinEdit ClientInstanceName="spePRECIO_UNITARIO" DecimalPlaces="4" DisplayFormatString="#,##0.00##" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>    
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>  
        <dx:GridViewDataSpinEditColumn FieldName="TOTAL" VisibleIndex="10" Caption="Valor" ReadOnly="true" Width="130px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" Visible="false" >                        
            <PropertiesSpinEdit ClientInstanceName="lblTOTAL" DisplayFormatString="#,##0.00"  DecimalPlaces="2" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>                        
        </dx:GridViewDataSpinEditColumn>          
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="13" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="14" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="14" Caption="Estado" UnboundType="String" ReadOnly="true" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CANT_DEVUELTA" VisibleIndex="15" Width="100px"  HeaderStyle-Wrap="True" Caption="Cantidad Total Devuelta a Bodega para el N° de Retiro y Producto" UnboundType="Decimal" HeaderStyle-ForeColor="Blue" CellStyle-ForeColor="Blue"  ReadOnly="true" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " Visible="false" 
            Name="Eliminar" VisibleIndex="15">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" TypeName="SISPACAL.BL.cSALBODE_DETA"     
    SelectMethod="ObtenerListaPRODUCTOS_SOLIC_CONSIGNACION" UpdateMethod="ActualizarSALBODE_DETA">       
     <SelectParameters>             
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_INI" Type="String" />
        <asp:Parameter Name="FECHA_FIN" Type="String" />
        <asp:Parameter Name="NUM_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="NUM_SALBODE" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_ESTADO" Type="Int32" />
     </SelectParameters>     
     <UpdateParameters>    
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />            
        <asp:Parameter Name="CANT_ANULADA" Type="Decimal" />     
        <asp:Parameter Name="CANT_ENTREGADA" Type="Decimal" />                              
    </UpdateParameters>    
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSALBODE_DETAcache" runat="server" TypeName="cSALBODE_DETAcache"     
    SelectMethod="ObtenerLista" UpdateMethod="Actualizar">       
     <SelectParameters>             
        <asp:Parameter Name="nombreSesion_ucListaSALBODE_DETA" Type="String" />
     </SelectParameters>     
     <UpdateParameters>    
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_ENCA" Type="Int32" />      
        <asp:Parameter Name="CANT_ANULADA" Type="Decimal" />     
        <asp:Parameter Name="CANT_ENTREGADA" Type="Decimal" />     
        <asp:Parameter Name="REFERENCIA" Type="String" />                   
    </UpdateParameters>    
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSALBODE_DETA" DeleteMethod="EliminarSALBODE_DETA" UpdateMethod="ActualizarSALBODE_DETA"
    TypeName="SISPACAL.BL.cSALBODE_DETA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CANT_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CANT_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSALBODE_ENCA" runat="server" 
    SelectMethod="ObtenerListaPorSALBODE_ENCA" InsertMethod="AgregarSALBODE_DETA" DeleteMethod="EliminarSALBODE_DETA" UpdateMethod="ActualizarSALBODE_DETA"
    TypeName="SISPACAL.BL.cSALBODE_DETA">
    <SelectParameters>
        <asp:Parameter Name="ID_SALBODE_ENCA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CANT_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CANT_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPRODUCTO" runat="server" 
    SelectMethod="ObtenerListaPorPRODUCTO" InsertMethod="AgregarSALBODE_DETA" DeleteMethod="EliminarSALBODE_DETA" UpdateMethod="ActualizarSALBODE_DETA"
    TypeName="SISPACAL.BL.cSALBODE_DETA">
    <SelectParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CANT_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
        <asp:Parameter Name="ID_SALBODE_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CANT_ENTREGADA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SALBODE_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
