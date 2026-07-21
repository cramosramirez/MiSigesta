<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPERIODOREQ.ascx.vb" Inherits="controles_ucListaPERIODOREQ" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetallePERIODOREQ.ascx" tagname="ucVistaDetallePERIODOREQ" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_PERIODOREQ">
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
                    CommandArgument='<%# Bind("ID_PERIODOREQ") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PERIODOREQ") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PERIODOREQ" ReadOnly="True" VisibleIndex="2" Caption="Id periodoreq" />
        <dx:GridViewDataTextColumn FieldName="DESCRIP_PERIODO" VisibleIndex="3" Caption="Descrip periodo" />
        <dx:GridViewDataCheckColumn FieldName="ACTIVO" VisibleIndex="4" Caption="Activo" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREACION" VisibleIndex="5" Caption="Usuario creacion" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREACION" VisibleIndex="6" Caption="Fecha creacion" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CIERRE" VisibleIndex="7" Caption="Usuario cierre" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CIERRE" VisibleIndex="8" Caption="Fecha cierre" />
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
            <uc1:ucVistaDetallePERIODOREQ ID="ucVistaDetallePERIODOREQ1" runat="server" 
                ID_PERIODOREQ='<%# Bind("ID_PERIODOREQ") %>' DESCRIP_PERIODO='<%# Bind("DESCRIP_PERIODO") %>' ACTIVO='<%# Bind("ACTIVO") %>' USUARIO_CREACION='<%# Bind("USUARIO_CREACION") %>' FECHA_CREACION='<%# Bind("FECHA_CREACION") %>' USUARIO_CIERRE='<%# Bind("USUARIO_CIERRE") %>' FECHA_CIERRE='<%# Bind("FECHA_CIERRE") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarPERIODOREQ" DeleteMethod="EliminarPERIODOREQ" UpdateMethod="ActualizarPERIODOREQ"
    TypeName="SISPACAL.BL.cPERIODOREQ">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter Name="DESCRIP_PERIODO" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CIERRE" Type="String" />
        <asp:Parameter Name="FECHA_CIERRE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter Name="DESCRIP_PERIODO" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CIERRE" Type="String" />
        <asp:Parameter Name="FECHA_CIERRE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
