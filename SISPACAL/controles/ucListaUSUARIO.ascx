<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaUSUARIO.ascx.vb" Inherits="controles_ucListaUSUARIO" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleUSUARIO.ascx" tagname="ucVistaDetalleUSUARIO" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="USUARIO" Width="100%" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents EndCallback="function(s, e){if(s.cpMensaje != null){ AsignarMensaje(s.cpMensaje); delete s.cpMensaje;}}" RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("USUARIO") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("USUARIO") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO" ReadOnly="True" VisibleIndex="2" Caption="Usuario" />
        <dx:GridViewDataTextColumn FieldName="ID_PERFIL" VisibleIndex="3" Visible="false" Caption="Id perfil" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE" VisibleIndex="4" Caption="Nombre" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="EMAIL" VisibleIndex="5" Caption="Email" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="CLAVE" VisibleIndex="6" Visible="false" Caption="Clave" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PERFIL" VisibleIndex="6" Caption="Perfil Asignado" UnboundType="String" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataCheckColumn FieldName="ACTIVO" VisibleIndex="7" Caption="Activo" />
        <dx:GridViewDataCheckColumn FieldName="BLOQUEADO" VisibleIndex="8" Caption="Bloqueado" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="9" Visible="false" Caption="Usuario crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="10" Visible="false" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="11" Visible="false" Caption="Usuario act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="12" Visible="false" Caption="Fecha act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ULTACCESO" VisibleIndex="13" Caption="Último acceso" Settings-AllowAutoFilter="False"  >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="14">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True"  />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarUSUARIO" DeleteMethod="EliminarUSUARIO" UpdateMethod="ActualizarUSUARIO"
    TypeName="SISPACAL.BL.cUSUARIO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PERFIL" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CLAVE" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
        <asp:Parameter Name="BLOQUEADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTACCESO" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PERFIL" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CLAVE" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
        <asp:Parameter Name="BLOQUEADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTACCESO" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPERFIL" runat="server" 
    SelectMethod="ObtenerListaPorPERFIL" InsertMethod="AgregarUSUARIO" DeleteMethod="EliminarUSUARIO" UpdateMethod="ActualizarUSUARIO"
    TypeName="SISPACAL.BL.cUSUARIO">
    <SelectParameters>
        <asp:Parameter Name="ID_PERFIL" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PERFIL" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CLAVE" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
        <asp:Parameter Name="BLOQUEADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTACCESO" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PERFIL" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CLAVE" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
        <asp:Parameter Name="BLOQUEADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTACCESO" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
