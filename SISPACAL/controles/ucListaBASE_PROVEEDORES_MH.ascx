<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaBASE_PROVEEDORES_MH.ascx.vb" Inherits="controles_ucListaBASE_PROVEEDORES_MH" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="odsLista" KeyFieldName="ID_BASE_PROVEE">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager PageSize="15">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />   
    <Columns>
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="true" Caption="Editar" Name="Editar" CellStyle-HorizontalAlign="Center" Width="40px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_BASE_PROVEE") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_BASE_PROVEE") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_BASE_PROVEE" ReadOnly="True" VisibleIndex="2" Caption="Id base provee" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TIPO_PERSONA" VisibleIndex="2" Caption="Tipo persona" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="3" Caption="DUI" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="4" Caption="NIT" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="5" Caption="Nombres" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="6" Caption="Apellidos" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="7" Caption="Telefono" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="8" Caption="Direccion"  />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO" VisibleIndex="8" Caption="Municipio" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO" VisibleIndex="8" Caption="Departamento" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODI_DEPTO" VisibleIndex="9" Caption="Codi depto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODI_MUNI" VisibleIndex="10" Caption="Codi muni" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CORREO" VisibleIndex="11" Caption="Correo" />
        <dx:GridViewDataTextColumn FieldName="NRC" VisibleIndex="12" Caption="NRC" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_PERSONA" VisibleIndex="13" Caption="Id tipo persona" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ACTIVIDAD" VisibleIndex="14" Caption="Actividad" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="15">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text=" " Image-ToolTip="Eliminar" Image-IconID="edit_delete_16x16">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarBASE_PROVEEDORES_MH" DeleteMethod="EliminarBASE_PROVEEDORES_MH" UpdateMethod="ActualizarBASE_PROVEEDORES_MH"
    TypeName="SISPACAL.BL.cBASE_PROVEEDORES_MH">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_BASE_PROVEE" Type="Int32" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_BASE_PROVEE" Type="Int32" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_BASE_PROVEE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarBASE_PROVEEDORES_MH" DeleteMethod="EliminarBASE_PROVEEDORES_MH" UpdateMethod="ActualizarBASE_PROVEEDORES_MH"
    TypeName="SISPACAL.BL.cBASE_PROVEEDORES_MH">
    <SelectParameters>
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_BASE_PROVEE" Type="Int32" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_BASE_PROVEE" Type="Int32" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_BASE_PROVEE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_PERSONA" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_PERSONA" InsertMethod="AgregarBASE_PROVEEDORES_MH" DeleteMethod="EliminarBASE_PROVEEDORES_MH" UpdateMethod="ActualizarBASE_PROVEEDORES_MH"
    TypeName="SISPACAL.BL.cBASE_PROVEEDORES_MH">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_BASE_PROVEE" Type="Int32" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_BASE_PROVEE" Type="Int32" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Int32" />
        <asp:Parameter Name="ACTIVIDAD" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_BASE_PROVEE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
