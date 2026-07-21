<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCARGADOR.ascx.vb" Inherits="controles_ucListaOPERADOR" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<script type="text/javascript">
    function Seleccion_lstCARGADOR(s, e) {
        cpAsignacionCargadorCargadora.PerformCallback('SeleccionCargador');
    }
</script>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_CARGADOR">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents SelectionChanged="Seleccion_lstCARGADOR"  RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0">                         
        </dx:GridViewCommandColumn>       
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colEditar" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_CARGADOR") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_CARGADOR") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>          
        <dx:GridViewDataTextColumn FieldName="ID_CARGADOR" ReadOnly="True" VisibleIndex="2" Caption="Código" Width="70px"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CARGADOR" VisibleIndex="3" Caption="Nombre Operador" Width="300px" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="4" Caption="Dui" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="5" Caption="Nit" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="6" Caption="Direccion" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="7" Caption="Usuario crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="8" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="9" Caption="Usuario act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="10" Caption="Fecha act" />
        <dx:GridViewDataTextColumn FieldName="CODIGO" VisibleIndex="11" Caption="Codigo" Width="70px" Settings-AutoFilterCondition="Contains" />  
        <dx:GridViewDataCheckColumn FieldName="ES_EMPLEADO_INGENIO" VisibleIndex="12" Caption="Empleado JIBOA" />      
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="13">
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarCARGADOR" DeleteMethod="EliminarCARGADOR" UpdateMethod="ActualizarCARGADOR"
    TypeName="SISPACAL.BL.cCARGADOR">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ES_EMPLEADO_INGENIO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="NOMBRE_CARGADOR" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="ES_EMPLEADO_INGENIO" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="NOMBRE_CARGADOR" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="ES_EMPLEADO_INGENIO" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
