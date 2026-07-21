<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaORDEN_COMPRA_AGRI.ascx.vb" Inherits="controles_ucListaORDEN_COMPRA_AGRI" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%"  KeyFieldName="ID_ORDEN">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
         CustomButtonClick="function(s,e){                                                  
                            switch(e.buttonID){
                                case 'btnVistaPrevia':                                                                                                     
                                    MostrarOrdenCompraPorOrden(s.GetRowKey(e.visibleIndex));
                                    break; 
                                case 'btnEliminar':   
                                    var aceptar;  
                                    aceptar = confirm('Esta seguro de eliminar esta orden de compra?');
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
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_ORDEN")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_ORDEN")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="1" AllowDragDrop="False" Caption="Ver Reporte Orden" Name="colVistaPrevia" ButtonType="Image" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Width="50px"   >
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa de la Orden">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="ID_ORDEN" ReadOnly="True" VisibleIndex="2" Caption="Id orden" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEE" VisibleIndex="3" Caption="Id provee" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="3" Caption="Zafra" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="3" Caption="CodiProveedor" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PRODUCTOR" VisibleIndex="3" Caption="Productor" Width="300px" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="NUM_SOLICITUD" VisibleIndex="3" Caption="N° Solicitud" Width="80px" CellStyle-HorizontalAlign="Right" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="3" Caption="Proveedor Agrícola" UnboundType="String" Width="300px" />
        <dx:GridViewDataTextColumn FieldName="CONDICION_COMPRA" VisibleIndex="3" Caption="Condicion Compra" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="NO_ORDEN" VisibleIndex="4" Caption="No Orden" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CODI_ORDEN" VisibleIndex="5" Caption="N° Orden" CellStyle-HorizontalAlign="Right"  />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="6" Caption="Fecha" Width="100px" SortIndex="1" SortOrder="Descending" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="7" Caption="Id solicitud" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="CONDI_COMPRA" VisibleIndex="9" Caption="Condi compra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SUB_TOTAL" VisibleIndex="10" Caption="Sub Total" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="IVA" VisibleIndex="11" Caption="IVA" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TOTAL" VisibleIndex="12" Caption="Total" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CCF_NOMBRE" VisibleIndex="13" Caption="Ccf nombre" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="LUGAR_ENTREGA" VisibleIndex="14" Caption="Lugar entrega" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CONTACTO" VisibleIndex="15" Caption="Contacto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="16" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="17" Caption="Fecha crea" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="18">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarORDEN_COMPRA_AGRI" DeleteMethod="EliminarORDEN_COMPRA_AGRI" UpdateMethod="ActualizarORDEN_COMPRA_AGRI"
    TypeName="SISPACAL.BL.cORDEN_COMPRA_AGRI">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_ORDEN" Type="Int32" />
        <asp:Parameter Name="CODI_ORDEN" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CCF_NOMBRE" Type="String" />
        <asp:Parameter Name="LUGAR_ENTREGA" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_ORDEN" Type="Int32" />
        <asp:Parameter Name="CODI_ORDEN" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CCF_NOMBRE" Type="String" />
        <asp:Parameter Name="LUGAR_ENTREGA" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AGRICOLA" InsertMethod="AgregarORDEN_COMPRA_AGRI" DeleteMethod="EliminarORDEN_COMPRA_AGRI" UpdateMethod="ActualizarORDEN_COMPRA_AGRI"
    TypeName="SISPACAL.BL.cORDEN_COMPRA_AGRI">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_ORDEN" Type="Int32" />
        <asp:Parameter Name="CODI_ORDEN" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CCF_NOMBRE" Type="String" />
        <asp:Parameter Name="LUGAR_ENTREGA" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_ORDEN" Type="Int32" />
        <asp:Parameter Name="CODI_ORDEN" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CCF_NOMBRE" Type="String" />
        <asp:Parameter Name="LUGAR_ENTREGA" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_AGRICOLA" InsertMethod="AgregarORDEN_COMPRA_AGRI" DeleteMethod="EliminarORDEN_COMPRA_AGRI" UpdateMethod="ActualizarORDEN_COMPRA_AGRI"
    TypeName="SISPACAL.BL.cORDEN_COMPRA_AGRI">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_ORDEN" Type="Int32" />
        <asp:Parameter Name="CODI_ORDEN" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CCF_NOMBRE" Type="String" />
        <asp:Parameter Name="LUGAR_ENTREGA" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_ORDEN" Type="Int32" />
        <asp:Parameter Name="CODI_ORDEN" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CCF_NOMBRE" Type="String" />
        <asp:Parameter Name="LUGAR_ENTREGA" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarORDEN_COMPRA_AGRI" DeleteMethod="EliminarORDEN_COMPRA_AGRI" UpdateMethod="ActualizarORDEN_COMPRA_AGRI"
    TypeName="SISPACAL.BL.cORDEN_COMPRA_AGRI">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_ORDEN" Type="Int32" />
        <asp:Parameter Name="CODI_ORDEN" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CCF_NOMBRE" Type="String" />
        <asp:Parameter Name="LUGAR_ENTREGA" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_ORDEN" Type="Int32" />
        <asp:Parameter Name="CODI_ORDEN" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="CCF_NOMBRE" Type="String" />
        <asp:Parameter Name="LUGAR_ENTREGA" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ORDEN" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
