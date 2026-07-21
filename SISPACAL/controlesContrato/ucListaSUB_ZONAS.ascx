<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSUB_ZONAS.ascx.vb" Inherits="controlesMaestro_ucListaSUB_ZONAS" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleSUB_ZONAS.ascx" tagname="ucVistaDetalleSUB_ZONAS" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="SUB_ZONA">
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
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("SUB_ZONA") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("SUB_ZONA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SUB_ZONA" ReadOnly="True" VisibleIndex="2" Caption="Sub zona" />
        <dx:GridViewDataTextColumn FieldName="DESCRIP_SUB_ZONA" VisibleIndex="3" Caption="Descrip sub zona" />
        <dx:GridViewDataTextColumn FieldName="NO_SUB_ZONA" VisibleIndex="4" Caption="No sub zona" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="5" Caption="Usuario crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="6" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="7" Caption="Usuario act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="8" Caption="Fecha act" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="9">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleSUB_ZONAS ID="ucVistaDetalleSUB_ZONAS1" runat="server" 
                ZONA='<%# Bind("ZONA") %>' SUB_ZONA='<%# Bind("SUB_ZONA") %>' DESCRIP_SUB_ZONA='<%# Bind("DESCRIP_SUB_ZONA") %>' NO_SUB_ZONA='<%# Bind("NO_SUB_ZONA") %>' USUARIO_CREA='<%# Bind("USUARIO_CREA") %>' FECHA_CREA='<%# Bind("FECHA_CREA") %>' USUARIO_ACT='<%# Bind("USUARIO_ACT") %>' FECHA_ACT='<%# Bind("FECHA_ACT") %>' />
             <div style="text-align:right; padding:2px 2px 2px 2px"><table cellpadding="0" cellspacing="0">
                    <tr><td><dx:ASPxButton ID="btnGuardar" runat="server" AutoPostBack="False" Text="Guardar" Width="74px">   
                                <ClientSideEvents Click="function(s, e){if(!s.CauseValidation())return false;eval(s.cp_NombreClienteLista).UpdateEdit();}" />
                            </dx:ASPxButton></td>
                        <td style="padding-left: 13px;"><dx:ASPxButton ID="btnCancelar" runat="server" AutoPostBack="False" Text="Cancelar" Width="74px" CausesValidation="False">
                                <ClientSideEvents Click="function(s, e){eval(s.cp_NombreClienteLista).CancelEdit();}" />                            
             </dx:ASPxButton></td></tr></table></div>
        </EditForm>
        <EmptyDataRow>
            <dx:ASPxButton ID="btnAgregar" runat="server" AutoPostBack="False" Text="Agregar">
                <ClientSideEvents Click="function(s, e) {eval(s.cp_NombreClienteLista).AddNewRow();}" />
            </dx:ASPxButton>
            <dx:ASPxLabel ID="lblEmptyDataRow" runat="server" Text="No existen registros para mostrar"></dx:ASPxLabel>
        </EmptyDataRow>
    </Templates>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSUB_ZONAS" DeleteMethod="EliminarSUB_ZONAS" UpdateMethod="ActualizarSUB_ZONAS"
    TypeName="SISPACAL.BL.cSUB_ZONAS">
    <SelectParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="0" Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_SUB_ZONA" Type="String" />
        <asp:Parameter Name="NO_SUB_ZONA" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_SUB_ZONA" Type="String" />
        <asp:Parameter Name="NO_SUB_ZONA" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZONAS" runat="server" 
    SelectMethod="ObtenerListaPorZONAS" InsertMethod="AgregarSUB_ZONAS" DeleteMethod="EliminarSUB_ZONAS" UpdateMethod="ActualizarSUB_ZONAS"
    TypeName="SISPACAL.BL.cSUB_ZONAS">
    <SelectParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="0" Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_SUB_ZONA" Type="String" />
        <asp:Parameter Name="NO_SUB_ZONA" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_SUB_ZONA" Type="String" />
        <asp:Parameter Name="NO_SUB_ZONA" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
