<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPROVEEDOR.ascx.vb" Inherits="controles_ucListaPROVEEDOR" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="CODIPROVEEDOR" Theme="Office2010Blue" Font-Names="Arial" Width="100%">   
     <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
        <SettingsPager PageSize="8">
            <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
        </SettingsPager>
        <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
        <ClientSideEvents RowClick="function(s, e) {
                                                    var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();
                                    }"
                 CustomButtonClick="function(s,e){
                                        if(e.buttonID == 'btnEditar'){
                                            EditarProveedor(s.GetRowKey(e.visibleIndex));                                                                                   
                                        }
                                        if(e.buttonID == 'btnEliminar'){
                                            var aceptar;  
                                            aceptar = confirm('Esta seguro de eliminar este proveedor');
                                            if(aceptar)
                                                e.processOnServer = true;                                                                                 
                                        }
                                    }"  
        />        
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Visible="false" Name="colEditar" VisibleIndex="0" ButtonType="Image">
                <CustomButtons>
                     <dx:GridViewCommandColumnCustomButton ID="btnEditar" Image-IconID="edit_edit_16x16" Image-ToolTip="Editar">                                             
                     </dx:GridViewCommandColumnCustomButton>                                        
                </CustomButtons>
            </dx:GridViewCommandColumn>  
            <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
            </dx:GridViewCommandColumn>            
            <dx:GridViewDataTextColumn VisibleIndex="1">
                <DataItemTemplate>
                    <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("CODIPROVEEDOR") %>'></asp:ImageButton>                                   
                     <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("CODIPROVEEDOR") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" ReadOnly="True" Visible="false" VisibleIndex="2" Caption="Codiproveedor" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="3" Caption="Cod Provee" />
        <dx:GridViewDataTextColumn FieldName="CODISOCIO" VisibleIndex="4" Caption="Cod Socio" />
         <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="5" Caption="Nombres" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="6" Caption="Apellidos" />       
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="8" Caption="Direccion" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO" VisibleIndex="8" Caption="Municipio" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO" VisibleIndex="8" Caption="Departamento" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="EDAD" Visible="false" VisibleIndex="7" Caption="Edad" />
        
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="9" Caption="Telefono" />
        <dx:GridViewDataTextColumn FieldName="CELULAR" Visible="false" VisibleIndex="10" Caption="Celular" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="11" Caption="DUI" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="12" Caption="NIT" />
        <dx:GridViewDataTextColumn FieldName="CREDITFISCAL" VisibleIndex="13" Caption="NRC" />        
        <dx:GridViewDataTextColumn FieldName="PROFESION" Visible="false" VisibleIndex="14" Caption="Profesion" />
        <dx:GridViewDataTextColumn FieldName="NOMBRENIT" Visible="false" VisibleIndex="15" Caption="Nombrenit" />
        <dx:GridViewDataTextColumn FieldName="APODERADO" Visible="false" VisibleIndex="16" Caption="Apoderado" />
        <dx:GridViewDataTextColumn FieldName="DUI_APODERADO" Visible="false" VisibleIndex="17" Caption="Dui apoderado" />
        <dx:GridViewDataTextColumn FieldName="NIT_APODERADO" Visible="false" VisibleIndex="18" Caption="Nit apoderado" />
        <dx:GridViewDataTextColumn FieldName="USER_CREA" Visible="false" VisibleIndex="19" Caption="User crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" Visible="false" VisibleIndex="20" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USER_ACT" Visible="false" VisibleIndex="21" Caption="User act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" Visible="false" VisibleIndex="22" Caption="Fecha act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_NAC" Visible="false" VisibleIndex="23" Caption="Fecha nac" />
        <dx:GridViewDataTextColumn FieldName="TIPO" VisibleIndex="24" UnboundType="String" Caption="Tipo Contribuyente" />
        <dx:GridViewDataTextColumn FieldName="CORREO" Visible="true" VisibleIndex="24" Caption="Correo" />
        <dx:GridViewDataTextColumn FieldName="NUM_CUENTA" VisibleIndex="25" Caption="No. de Cuenta" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_BANCO" VisibleIndex="26" UnboundType="String" Caption="Banco" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="27">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True" AllowSelectSingleRowOnly="true" />    
</dx:ASPxGridView>
<dx:ASPxHiddenField ID="hfListaPROVEEDOR" ClientInstanceName="hfListaPROVEEDOR" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>

<asp:ObjectDataSource ID="odsListaNombreCompleto" runat="server" SelectMethod="ObtenerListaPorNombreCompleto" TypeName="SISPACAL.BL.cPROVEEDOR">
    <SelectParameters>
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />   
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPROVEEDOR" DeleteMethod="EliminarPROVEEDOR" UpdateMethod="ActualizarPROVEEDOR"
    TypeName="SISPACAL.BL.cPROVEEDOR">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="EDAD" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="CELULAR" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="CREDITFISCAL" Type="String" />
        <asp:Parameter Name="PROFESION" Type="String" />
        <asp:Parameter Name="NOMBRENIT" Type="String" />
        <asp:Parameter Name="APODERADO" Type="String" />
        <asp:Parameter Name="DUI_APODERADO" Type="String" />
        <asp:Parameter Name="NIT_APODERADO" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="FECHA_NAC" Type="DateTime" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="EDAD" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="CELULAR" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="CREDITFISCAL" Type="String" />
        <asp:Parameter Name="PROFESION" Type="String" />
        <asp:Parameter Name="NOMBRENIT" Type="String" />
        <asp:Parameter Name="APODERADO" Type="String" />
        <asp:Parameter Name="DUI_APODERADO" Type="String" />
        <asp:Parameter Name="NIT_APODERADO" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="FECHA_NAC" Type="DateTime" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios"  TypeName="SISPACAL.BL.cPROVEEDOR">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />         
        <asp:Parameter Name="CREDITFISCAL" Type="String" />   
        <asp:Parameter Name="ID_ZAFRA_CONTRATADA" Type="Int32" />
        <asp:Parameter Name="soloProveedoresConContrato" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
