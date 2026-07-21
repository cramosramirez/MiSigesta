<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaLABFAB_MUESTRA.ascx.vb" Inherits="controles_ucListaLABFAB_MUESTRA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_MUESTRA" Width="100%" >
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
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_MUESTRA") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_MUESTRA") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="ID_ETAPA" VisibleIndex="3" Caption="Cód. etapa" Width="80px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ETAPA" VisibleIndex="3" Caption="Etapa" UnboundType="String" Width="300px" />
        <dx:GridViewDataTextColumn FieldName="ID_MUESTRA" ReadOnly="True" VisibleIndex="4" Caption="Cód. Muestra" Width="80px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_MUESTRA" VisibleIndex="4" Caption="Muestra" />        
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="5" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="6" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="7" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="8" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="9">
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarLABFAB_MUESTRA" DeleteMethod="EliminarLABFAB_MUESTRA" UpdateMethod="ActualizarLABFAB_MUESTRA"
    TypeName="SISPACAL.BL.cLABFAB_MUESTRA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_MUESTRA" Type="Int32" />
        <asp:Parameter Name="ID_ETAPA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_MUESTRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MUESTRA" Type="Int32" />
        <asp:Parameter Name="ID_ETAPA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_MUESTRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_MUESTRA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_ETAPA" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_ETAPA" InsertMethod="AgregarLABFAB_MUESTRA" DeleteMethod="EliminarLABFAB_MUESTRA" UpdateMethod="ActualizarLABFAB_MUESTRA"
    TypeName="SISPACAL.BL.cLABFAB_MUESTRA">
    <SelectParameters>
        <asp:Parameter Name="ID_ETAPA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_MUESTRA" Type="Int32" />
        <asp:Parameter Name="ID_ETAPA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_MUESTRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MUESTRA" Type="Int32" />
        <asp:Parameter Name="ID_ETAPA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_MUESTRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_MUESTRA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
