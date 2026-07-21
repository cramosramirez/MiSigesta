<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaLABFAB_INFOVAR.ascx.vb" Inherits="controles_ucListaLABFAB_INFOVAR" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%" KeyFieldName="ID_INFOVAR">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="true" Width="50px" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_INFOVAR") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_INFOVAR") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_INFOVAR" ReadOnly="True" VisibleIndex="2" Caption="Id infovar" />
        <dx:GridViewDataTextColumn FieldName="ID_INFO" VisibleIndex="3" Caption="Id info" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_INFO" VisibleIndex="3" Caption="Informe" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPOVAR" VisibleIndex="4" Caption="Id tipovar" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CATEG" VisibleIndex="5" Caption="Id categ" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ORDEN" VisibleIndex="6" Caption="Orden" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TIPOVAR" VisibleIndex="6" Caption="Tipo Variable" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_INFOVAR" VisibleIndex="7" Caption="Nombre Variable" />
        <dx:GridViewDataTextColumn FieldName="DESCRIP_VAR" VisibleIndex="8" Caption="Descrip var" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ANALISIS" VisibleIndex="8" Caption="Análisis Refiere" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ID_ANALISIS_REF" VisibleIndex="9" Caption="Id analisis ref" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_INFOVAR_REF" VisibleIndex="10" Caption="Id infovar ref" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SQLREPO" VisibleIndex="11" Caption="Consulta Reporte" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="12">
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarLABFAB_INFOVAR" DeleteMethod="EliminarLABFAB_INFOVAR" UpdateMethod="ActualizarLABFAB_INFOVAR"
    TypeName="SISPACAL.BL.cLABFAB_INFOVAR">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="ID_CATEG" Type="Int32" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_INFOVAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR_REF" Type="Int32" />
        <asp:Parameter Name="SQLREPO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="ID_CATEG" Type="Int32" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_INFOVAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR_REF" Type="Int32" />
        <asp:Parameter Name="SQLREPO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_INFORME" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_INFORME" InsertMethod="AgregarLABFAB_INFOVAR" DeleteMethod="EliminarLABFAB_INFOVAR" UpdateMethod="ActualizarLABFAB_INFOVAR"
    TypeName="SISPACAL.BL.cLABFAB_INFOVAR">
    <SelectParameters>
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="ID_CATEG" Type="Int32" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_INFOVAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR_REF" Type="Int32" />
        <asp:Parameter Name="SQLREPO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="ID_CATEG" Type="Int32" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_INFOVAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR_REF" Type="Int32" />
        <asp:Parameter Name="SQLREPO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_TIPOVAR" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_TIPOVAR" InsertMethod="AgregarLABFAB_INFOVAR" DeleteMethod="EliminarLABFAB_INFOVAR" UpdateMethod="ActualizarLABFAB_INFOVAR"
    TypeName="SISPACAL.BL.cLABFAB_INFOVAR">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="ID_CATEG" Type="Int32" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_INFOVAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR_REF" Type="Int32" />
        <asp:Parameter Name="SQLREPO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="ID_CATEG" Type="Int32" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_INFOVAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR_REF" Type="Int32" />
        <asp:Parameter Name="SQLREPO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_CATEGORIA" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_CATEGORIA" InsertMethod="AgregarLABFAB_INFOVAR" DeleteMethod="EliminarLABFAB_INFOVAR" UpdateMethod="ActualizarLABFAB_INFOVAR"
    TypeName="SISPACAL.BL.cLABFAB_INFOVAR">
    <SelectParameters>
        <asp:Parameter Name="ID_CATEG" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="ID_CATEG" Type="Int32" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_INFOVAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR_REF" Type="Int32" />
        <asp:Parameter Name="SQLREPO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="ID_CATEG" Type="Int32" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NOMBRE_INFOVAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR_REF" Type="Int32" />
        <asp:Parameter Name="SQLREPO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
