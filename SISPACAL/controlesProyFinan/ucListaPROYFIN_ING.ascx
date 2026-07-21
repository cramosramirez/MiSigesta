<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPROYFIN_ING.ascx.vb" Inherits="controles_ucListaPROYFIN_ING" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_PROYFIN_ING" Width="100%" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager PageSize="15">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <SettingsCommandButton> 
         <NewButton Text="Agregar"></NewButton> 
         <EditButton Text="Editar"></EditButton> 
         <DeleteButton Text="Eliminar"></DeleteButton> 
    </SettingsCommandButton> 
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Width="50px" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_PROYFIN_ING") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PROYFIN_ING") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PROYFIN_ING" ReadOnly="True" VisibleIndex="2" Caption="Identificador" Width="70px"  />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="4" Caption="Codiproveedor" Width="100px"  />
        <dx:GridViewDataTextColumn FieldName="PRODUCTOR" VisibleIndex="4" Caption="Productor" Width="300px" UnboundType="String"   />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="5" Caption="Fecha" Width="80px"  >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="VIP" VisibleIndex="6" Caption="Vip" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="7" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="8" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="9" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="10" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="11" Width="80px" >
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text=" " Image-ToolTip="Eliminar" Image-IconID="edit_delete_16x16">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPROYFIN_ING" DeleteMethod="EliminarPROYFIN_ING" UpdateMethod="ActualizarPROYFIN_ING"
    TypeName="SISPACAL.BL.cPROYFIN_ING">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="VIP" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="VIP" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarPROYFIN_ING" DeleteMethod="EliminarPROYFIN_ING" UpdateMethod="ActualizarPROYFIN_ING"
    TypeName="SISPACAL.BL.cPROYFIN_ING">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="VIP" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="VIP" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
