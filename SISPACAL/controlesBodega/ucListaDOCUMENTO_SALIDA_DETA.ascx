<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaDOCUMENTO_SALIDA_DETA.ascx.vb" Inherits="controles_ucListaDOCUMENTO_SALIDA_DETA" %>
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

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_DOCSAL_ENCA_DETA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
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
        <dx:GridViewDataTextColumn FieldName="ID_DOCSAL_ENCA_DETA" ReadOnly="True" VisibleIndex="2" Caption="Id ccf deta" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_DOCSAL_ENCA" VisibleIndex="3" Caption="Id ccf enca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PRODUCTO" VisibleIndex="4" Caption="Id"  Width="0px" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="4" Caption="Proveedor" ReadOnly="true"  Width="150px" CellStyle-HorizontalAlign="Left" UnboundType="String"  /> 
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PRODUCTO" VisibleIndex="5" Caption="Producto"  Width="150px" CellStyle-HorizontalAlign="Left" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="UNIDAD" VisibleIndex="6" Caption="Unidad" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PRESENTACION" VisibleIndex="7" Caption="Presentación" ReadOnly="true"  Width="250px" CellStyle-HorizontalAlign="Left" />
        <dx:GridViewDataSpinEditColumn FieldName="CANTIDAD" VisibleIndex="8" Caption="Cantidad" Width="110px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" >
            <PropertiesSpinEdit DisplayFormatString="#,##0.####"  ClientInstanceName="speCANTIDAD" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>            
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>    
        <dx:GridViewDataSpinEditColumn FieldName="PRECIO_UNITARIO" VisibleIndex="9" ReadOnly="true" Caption="Precio Unitario" Width="100px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right">
            <PropertiesSpinEdit ClientInstanceName="spePRECIO_UNITARIO" DecimalPlaces="4" DisplayFormatString="#,##0.00##" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>    
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>        
        <dx:GridViewDataSpinEditColumn FieldName="TOTAL" VisibleIndex="10" Caption="Valor" ReadOnly="true" Width="130px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right">                        
            <PropertiesSpinEdit ClientInstanceName="lblTOTAL" DisplayFormatString="#,##0.00"  DecimalPlaces="2" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>                        
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataTextColumn VisibleIndex="11" Name="Eliminar" Caption=" " Width="20px"  CellStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEliminar" runat="server" AlternateText="Eliminar" ToolTip="Eliminar" CommandName="Eliminar" ImageUrl="~/imagenes/eliminar.png"  CommandArgument='<%# Bind("ID_DOCSAL_ENCA_DETA")%>'></asp:ImageButton>                             
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>	   
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  /> 	  
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsDOCUMENTO_SALIDA_DETAcache" runat="server" TypeName="cDOCUMENTO_SALIDA_DETAcache"     
    SelectMethod="ObtenerLista" 
    UpdateMethod="Actualizar" DeleteMethod="Eliminar">       
     <SelectParameters>             
        <asp:Parameter Name="nombreSesion_ucListaDOCUMENTO_SALIDA_DETA" Type="String" />
     </SelectParameters>     
     <UpdateParameters>    
        <asp:Parameter Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />      
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="REFERENCIA" Type="String" />                   
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarDOCUMENTO_SALIDA_DETA" DeleteMethod="EliminarDOCUMENTO_SALIDA_DETA" UpdateMethod="ActualizarDOCUMENTO_SALIDA_DETA"
    TypeName="SISPACAL.BL.cDOCUMENTO_SALIDA_DETA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDOCUMENTO_SALIDA_ENCA" runat="server" 
    SelectMethod="ObtenerListaPorDOCUMENTO_SALIDA_ENCA" InsertMethod="AgregarDOCUMENTO_SALIDA_DETA" DeleteMethod="EliminarDOCUMENTO_SALIDA_DETA" UpdateMethod="ActualizarDOCUMENTO_SALIDA_DETA"
    TypeName="SISPACAL.BL.cDOCUMENTO_SALIDA_DETA">
    <SelectParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPRODUCTO" runat="server" 
    SelectMethod="ObtenerListaPorPRODUCTO" InsertMethod="AgregarDOCUMENTO_SALIDA_DETA" DeleteMethod="EliminarDOCUMENTO_SALIDA_DETA" UpdateMethod="ActualizarDOCUMENTO_SALIDA_DETA"
    TypeName="SISPACAL.BL.cDOCUMENTO_SALIDA_DETA">
    <SelectParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_DOCSAL_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="UID_DOCUMENTO_DETA" Type="Object" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DOCSAL_ENCA_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
