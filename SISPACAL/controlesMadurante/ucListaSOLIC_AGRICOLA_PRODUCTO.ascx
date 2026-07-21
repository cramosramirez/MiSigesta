<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_AGRICOLA_PRODUCTO.ascx.vb" Inherits="controles_ucListaSOLIC_AGRICOLA_PRODUCTO" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<script type="text/javascript">
    function CalcularTotalProducto(s, e) {
        var dosis = s.GetValue();
        var mz;
        var totalProd;
        if (hfSolicAgricolaProducto.Get('MZ') == null) {
            mz = 0;
        }
        else {
            mz = hfSolicAgricolaProducto.Get('MZ');
        }
        if (isNumber(dosis) && isNumber(mz)) {
            totalProd = round(dosis, 4) * mz;
            speTOTAL_PRODUCTO.SetValue(totalProd);
            if (spePRECIO_UNITARIO.GetValue() != null) {
                CalcularValorTotal(s, e);
            }
        }
        else
            speTOTAL_PRODUCTO.SetValue(0);
        
    }
    function CalcularValorTotal(s, e) {
        var total = 0;
        if (hfSolicAgricolaProducto.Get('ID_CUENTA_FINAN') == 3) {
            total = speTOTAL_PRODUCTO.GetValue() * spePRECIO_UNITARIO.GetValue() * hfSolicAgricolaProducto.Get('MZ');
        }
        else {
            total = speTOTAL_PRODUCTO.GetValue() * spePRECIO_UNITARIO.GetValue();
        }
        
        if (isNumber(total)) {
            lblPRECIO_TOTAL.SetValue(round(total,2));
        } 
        else
            lblPRECIO_TOTAL.SetValue(round(0,0));
    }

    function CalcularValorAdju(s, e) {
        var total = speCANT_ADJU.GetValue() * spePRECIO_ADJU.GetValue();
        if (isNumber(total)) {
            lblTOTAL_ADJU.SetValue(round(total, 2));
        }
        else
            lblTOTAL_ADJU.SetValue(round(0, 0));
    }

    function ActualizarMontoEnContainer() {
        cpVistaDetalleSOLIC_AGRICOLA.PerformCallback('TotalizarMONTO');
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
        cpListaSOLIC_AGRICOLA_PRODUCTO.PerformCallback('TarifaProducto;' + s.GetValue());
    }
    function OnEndCallbackCP(s, e) {        
        if (s.cpMensaje != null) {
            if (s.cpMensaje == 'TarifaProducto')                
                spePRECIO_UNITARIO.SetText(s.cpTarifa);                
        }    
    }
    function OnEndCallbackGrid(s, e) {        
        if (s.cpConCambios == null)
            return;
        if (s.cpConCambios == 1)
            cpVistaDetalleSOLIC_AGRICOLA.PerformCallback('TotalizarMONTO');        
    }
</script>
<dx:ASPxCallbackPanel ID="cpListaSOLIC_AGRICOLA_PRODUCTO" ClientInstanceName="cpListaSOLIC_AGRICOLA_PRODUCTO" runat="server" ShowLoadingPanel="false" Width="100%" >    
    <ClientSideEvents EndCallback="OnEndCallbackCP" /> 
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">  
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="1190px"  KeyFieldName="ID_SOLIC_AGRI_PROD" ClientInstanceName="gridSOLIC_AGRI_PROD" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar"
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents EndCallback="OnEndCallbackGrid" RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
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
        <dx:GridViewDataTextColumn FieldName="ID_SOLIC_AGRI_PROD" ReadOnly="True" VisibleIndex="2" Caption="Id solic agri prod" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="3" Caption="Id solicitud" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="ID_PRODUCTO" VisibleIndex="4" Caption="Id Producto"  Width="500px" Visible="false" ReadOnly="true" />                                  
        <dx:GridViewDataTextColumn FieldName="ID_PROVEE" VisibleIndex="4" Caption="Id Provee"  Width="500px" Visible="false" ReadOnly="true" />                                  
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEE" VisibleIndex="4" Caption="Proveedor"  Width="200px" ReadOnly="true" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PRODUCTO" VisibleIndex="4" Caption="Producto"  Width="500px" ReadOnly="true" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="PRESENTACION" VisibleIndex="4" Caption="Presentación"  Width="100px" />
        <dx:GridViewDataSpinEditColumn FieldName="CANT_X_MZ" VisibleIndex="5" Caption="Dosis MZ" Width="100px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right">            
            <PropertiesSpinEdit ClientInstanceName="speCANT_X_MZ" DecimalPlaces="4" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularTotalProducto" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularTotalProducto"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="TOTAL_PRODUCTO" VisibleIndex="6" Caption="Cantidad" Width="100px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" >
            <PropertiesSpinEdit ClientInstanceName="speTOTAL_PRODUCTO" DecimalPlaces="4" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>            
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="PRECIO_UNITARIO" VisibleIndex="7" Caption="Precio Unitario" Width="100px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right">
            <PropertiesSpinEdit ClientInstanceName="spePRECIO_UNITARIO" DecimalPlaces="4" DisplayFormatString="#,##0.00##" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>    
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>        
        <dx:GridViewDataSpinEditColumn FieldName="PRECIO_TOTAL" VisibleIndex="8" Caption="Sub-Total" Width="150px" CellStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right">                        
            <PropertiesSpinEdit ClientInstanceName="lblPRECIO_TOTAL" DisplayFormatString="#,##0.00"  DecimalPlaces="2" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>                        
        </dx:GridViewDataSpinEditColumn>

        <dx:GridViewDataSpinEditColumn FieldName="CANT_ADJU" VisibleIndex="6" Caption="Cant. Adju" Width="100px" Visible="false"  >
            <PropertiesSpinEdit ClientInstanceName="speCANT_ADJU" DecimalPlaces="4" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorAdju"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>            
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="PRECIO_ADJU" VisibleIndex="7" Caption="Precio U. Adju" Width="100px" Visible="false" >
            <PropertiesSpinEdit ClientInstanceName="spePRECIO_ADJU" DecimalPlaces="4" DisplayFormatString="#,##0.00##" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorAdju"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>    
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>        
        <dx:GridViewDataSpinEditColumn FieldName="TOTAL_ADJU" VisibleIndex="8" Caption="Sub-Total" Width="150px" Visible="false" >                        
            <PropertiesSpinEdit ClientInstanceName="lblTOTAL_ADJU" DisplayFormatString="#,##0.00"  DecimalPlaces="2" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorAdju"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>                        
        </dx:GridViewDataSpinEditColumn>

        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="9" Caption="Usuario crea" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="10" Caption="Fecha crea" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="11" Caption="Usuario act" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="12" Caption="Fecha act" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="13" Caption="Zafra" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="REFERENCIA" VisibleIndex="13" Caption="Referencia" Visible="false" />
        <dx:GridViewDataTextColumn VisibleIndex="14" Name="Eliminar" Caption=" " Width="20px"  CellStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEliminar" runat="server" AlternateText="Eliminar" ToolTip="Eliminar" CommandName="Eliminar" ImageUrl="~/imagenes/eliminar.png"  CommandArgument='<%# Bind("ID_SOLIC_AGRI_PROD")%>'></asp:ImageButton>                             
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
  </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel> 

<dx:ASPxHiddenField runat="server" ClientInstanceName="hfSolicAgricolaProducto" ID="hfSolicAgricolaProducto" />
<asp:ObjectDataSource ID="odsProductoAgricola" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorCUENTA_FINAN" 
    TypeName="SISPACAL.BL.cPRODUCTO">
    <SelectParameters>
        <asp:SessionParameter SessionField="ID_CUENTA_FINANsesion" Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="NOMBRE_PRODUCTO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
        <asp:Parameter DefaultValue="true" Name="AgregarVacio" Type="Boolean" />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsSolicAgricolaProdCache" runat="server" TypeName="cSOLIC_AGRICOLA_PRODUCTOcache" 
    SelectMethod="ObtenerLista" UpdateMethod="Actualizar" DeleteMethod="Eliminar" >       
     <SelectParameters>       
        <asp:Parameter Name="nombreSesion" Type="String" />
     </SelectParameters>    
     <UpdateParameters>    
        <asp:Parameter Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
        <asp:Parameter Name="PRESENTACION" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32"  />
         <asp:Parameter Name="ID_PROVEE_ADJU" Type="Int32"  />
         <asp:Parameter Name="CANT_ADJU" Type="Decimal"  />
         <asp:Parameter Name="PRECIO_ADJU" Type="Decimal"  />
         <asp:Parameter Name="TOTAL_ADJU" Type="Decimal"  />
        <asp:Parameter Name="REFERENCIA" Type="String" />             
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_AGRICOLA_PRODUCTO" DeleteMethod="EliminarSOLIC_AGRICOLA_PRODUCTO" UpdateMethod="ActualizarSOLIC_AGRICOLA_PRODUCTO"
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_PRODUCTO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_AGRICOLA" InsertMethod="AgregarSOLIC_AGRICOLA_PRODUCTO" DeleteMethod="EliminarSOLIC_AGRICOLA_PRODUCTO" UpdateMethod="ActualizarSOLIC_AGRICOLA_PRODUCTO"
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_PRODUCTO">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPRODUCTO" runat="server" 
    SelectMethod="ObtenerListaPorPRODUCTO" InsertMethod="AgregarSOLIC_AGRICOLA_PRODUCTO" DeleteMethod="EliminarSOLIC_AGRICOLA_PRODUCTO" UpdateMethod="ActualizarSOLIC_AGRICOLA_PRODUCTO"
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_PRODUCTO">
    <SelectParameters>
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PRODUCTO" Type="Int32" />
        <asp:Parameter Name="CANT_X_MZ" Type="Decimal" />
        <asp:Parameter Name="TOTAL_PRODUCTO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNITARIO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_AGRI_PROD" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
