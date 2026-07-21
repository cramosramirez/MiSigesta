<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCCF_ENCA.ascx.vb" Inherits="controles_ucListaCCF_ENCA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="ID_CCF_ENCA">
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
                                    MostrarCCF(s.GetRowKey(e.visibleIndex));
                                    break; 
                                case 'btnEliminar':   
                                    var aceptar;  
                                    aceptar = confirm('Esta seguro de eliminar este comprobante');
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
       <dx:GridViewDataTextColumn VisibleIndex="0" Visible="true" Caption="Editar" Name="Editar" CellStyle-HorizontalAlign="Center" Width="40px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_CCF_ENCA")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_CCF_ENCA")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="1" AllowDragDrop="False" Caption="Ver CCF" Visible="false" Name="colVistaPrevia" ButtonType="Image" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Width="50px"   >
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa de la Orden">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="ID_CCF_ENCA" ReadOnly="True" VisibleIndex="2" Caption="Id ccf enca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="4" Caption="Id solicitud" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CUENTA_FINAN" VisibleIndex="5" Caption="Id cuenta finan" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_COMPROB" VisibleIndex="6" Caption="Id tipo comprob" Visible="false" />           
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="6" Caption="Zafra" Width="80px" UnboundType="String"  />     
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="9" Caption="Código Productor" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="9" Caption="Código Productor" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="10" Caption="Productor" UnboundType="String" Width="300px" />
        <dx:GridViewDataTextColumn FieldName="NUM_SOLICITUD" VisibleIndex="10" Caption="N° Solicitud" Width="80px" CellStyle-HorizontalAlign="Right" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="NO_ORDEN" VisibleIndex="10" Caption="N° Orden" Width="80px" CellStyle-HorizontalAlign="Right" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEE_AGRICOLA" VisibleIndex="10" Caption="Casa Comercial" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="TIPO_COMPROB" VisibleIndex="10" Caption="Tipo Comprob." UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NO_CCF" VisibleIndex="11" Caption="No Comprob." CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="12" Caption="Fecha" >        
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CONDI_COMPRA" VisibleIndex="13" Caption="Condición Compra" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="SUB_TOTAL" VisibleIndex="13" Caption="SubTotal" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="DESCTO_PORC" VisibleIndex="14" Caption="%Desc." >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="DESCTO_MONTO" VisibleIndex="15" Caption="Desc.($)" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SUMAS" VisibleIndex="16" Caption="Sumas" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="IVA" VisibleIndex="17" Caption="Iva" >
             <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TOTAL" VisibleIndex="18" Caption="Total" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TOTAL_LETRAS" VisibleIndex="19" Caption="Total letras" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREACION" VisibleIndex="20" Caption="Usuario creacion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREACION" VisibleIndex="21" Caption="Fecha creacion" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="22">
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

<asp:ObjectDataSource ID="odsListaPorCONCEPTO_CCF" runat="server" 
    SelectMethod="ObtenerListaPorCONCEPTO_CCF" TypeName="SISPACAL.BL.cCCF_ENCA">
    <SelectParameters>
        <asp:Parameter Name="CONCEPTO_CCF" Type="Int32" />        
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCCF_ENCA" DeleteMethod="EliminarCCF_ENCA" UpdateMethod="ActualizarCCF_ENCA"
    TypeName="SISPACAL.BL.cCCF_ENCA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCCF_ENCA" DeleteMethod="EliminarCCF_ENCA" UpdateMethod="ActualizarCCF_ENCA"
    TypeName="SISPACAL.BL.cCCF_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_AGRICOLA" InsertMethod="AgregarCCF_ENCA" DeleteMethod="EliminarCCF_ENCA" UpdateMethod="ActualizarCCF_ENCA"
    TypeName="SISPACAL.BL.cCCF_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCUENTA_FINAN" runat="server" 
    SelectMethod="ObtenerListaPorCUENTA_FINAN" InsertMethod="AgregarCCF_ENCA" DeleteMethod="EliminarCCF_ENCA" UpdateMethod="ActualizarCCF_ENCA"
    TypeName="SISPACAL.BL.cCCF_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_COMPROB" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_COMPROB" InsertMethod="AgregarCCF_ENCA" DeleteMethod="EliminarCCF_ENCA" UpdateMethod="ActualizarCCF_ENCA"
    TypeName="SISPACAL.BL.cCCF_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarCCF_ENCA" DeleteMethod="EliminarCCF_ENCA" UpdateMethod="ActualizarCCF_ENCA"
    TypeName="SISPACAL.BL.cCCF_ENCA">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="TOTAL_LETRAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
