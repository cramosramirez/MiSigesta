<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_PROD_TRANS.ascx.vb" Inherits="controles_ucListaSOLIC_PROD_TRANS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<script type="text/javascript">
    
    function CalcularValorTotal(s, e) {
        var total = speCANTIDAD.GetValue() * spePRECIO_UNITARIO.GetValue();
        if (isNumber(total)) {
            lblSUB_TOTAL.SetValue(round(total, 2));
        }
        else
            lblSUB_TOTAL.SetValue(round(0, 0));
    }
    
    function ActualizarMontoEnContainer() {
        cpVistaDetalleSOLIC_ENCA_TRANS.PerformCallback('TotalizarMONTO');
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
    function OnValueChanged_ID_PRODUCTO(s, e) {
        if (s.GetValue() == null) {
            spePRECIO_UNITARIO.SetValue(0);
            CalcularValorTotal(s, e);
            return;
        }       
    }   
    function OnEndCallbackGrid(s, e) {       
        cpVistaDetalleSOLIC_PROD_TRANS.PerformCallback('');
    }
</script>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  KeyFieldName="ID_SOLIC_PROD_TRANS">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents  EndCallback="OnEndCallbackGrid" RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" ButtonType="Image" VisibleIndex="0" Visible="False" Width="30px" Caption=" "  >             
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
        <dx:GridViewCommandColumn Name="Edicion2" ButtonType="Image" VisibleIndex="0" Visible="False" Width="30px" Caption=" "  >               
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
        <dx:GridViewDataTextColumn FieldName="ID_SOLIC_PROD_TRANS" ReadOnly="True" VisibleIndex="2" Caption="Id solic prod trans" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="3" Caption="Id solicitud" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PRODUCTO" VisibleIndex="4" Caption="Id Producto"  Width="500px" Visible="false" ReadOnly="true" />                                  
        <dx:GridViewDataTextColumn FieldName="ID_PROVEE" VisibleIndex="4" Caption="Id Provee"  Width="500px" Visible="false" ReadOnly="true" />                                  
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEE" VisibleIndex="4" Caption="Proveedor"  Width="150px" ReadOnly="true" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PRODUCTO" VisibleIndex="4" Caption="Producto" CellStyle-HorizontalAlign="Left" Width="390px" ReadOnly="true" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="PRESENTACION" VisibleIndex="4" Caption="Presentación"  Width="90px" />       
        <dx:GridViewDataSpinEditColumn FieldName="CANTIDAD" VisibleIndex="6" Caption="Cantidad" Width="90px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" >
            <PropertiesSpinEdit ClientInstanceName="speCANTIDAD" DecimalPlaces="4" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>            
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="PRECIO_UNITARIO" VisibleIndex="7" Caption="Precio Unitario" Width="90px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right">
            <PropertiesSpinEdit ClientInstanceName="spePRECIO_UNITARIO" DecimalPlaces="4" DisplayFormatString="#,##0.00##" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>    
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>        
        <dx:GridViewDataSpinEditColumn FieldName="SUB_TOTAL" VisibleIndex="8" Caption="Sub-Total" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right">                        
            <PropertiesSpinEdit ClientInstanceName="lblSUB_TOTAL" DisplayFormatString="#,##0.00"  DecimalPlaces="2" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>                        
        </dx:GridViewDataSpinEditColumn>      
        <dx:GridViewDataTextColumn VisibleIndex="10" Name="Eliminar" Caption=" " Width="20px"  CellStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEliminar" runat="server" AlternateText="Eliminar" ToolTip="Eliminar" CommandName="Eliminar" ImageUrl="~/imagenes/eliminar.png"  CommandArgument='<%# Bind("ID_SOLIC_PROD_TRANS")%>'></asp:ImageButton>                             
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsSolicProdTransCache" runat="server" TypeName="cSOLIC_PROD_TRANScache" 
    SelectMethod="ObtenerLista" UpdateMethod="Actualizar" DeleteMethod="Eliminar" >       
     <SelectParameters>       
        <asp:Parameter Name="nombreSesion_uclistaSOLIC_PROD_TRANS" Type="String" />
     </SelectParameters>    
     <UpdateParameters>    
        <asp:Parameter Name="ID_SOLIC_PROD_TRANS" Type="Int32" />           
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32"  />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />       
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />                    
        <asp:Parameter Name="REFERENCIA" Type="String" />             
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PROD_TRANS" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>


<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_PROD_TRANS" DeleteMethod="EliminarSOLIC_PROD_TRANS" UpdateMethod="ActualizarSOLIC_PROD_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_PROD_TRANS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PROD_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PROD_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PROD_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_ENCA_TRANS" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_ENCA_TRANS" InsertMethod="AgregarSOLIC_PROD_TRANS" DeleteMethod="EliminarSOLIC_PROD_TRANS" UpdateMethod="ActualizarSOLIC_PROD_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_PROD_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PROD_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PROD_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PROD_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPRODUCTO" runat="server" 
    SelectMethod="ObtenerListaPorPRODUCTO" InsertMethod="AgregarSOLIC_PROD_TRANS" DeleteMethod="EliminarSOLIC_PROD_TRANS" UpdateMethod="ActualizarSOLIC_PROD_TRANS"
    TypeName="SISPACAL.BL.cSOLIC_PROD_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PROD_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PROD_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PROD_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
