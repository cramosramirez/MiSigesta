<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTROL_ENTREGA_LOTE.ascx.vb" Inherits="controles_ucListaCONTROL_ENTREGA_LOTE" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleCONTROL_ENTREGA_LOTE.ascx" tagname="ucVistaDetalleCONTROL_ENTREGA_LOTE" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_CTRL_ENTREGA_LOTE">
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
                    CommandArgument='<%# Bind("ID_CTRL_ENTREGA_LOTE") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_CTRL_ENTREGA_LOTE") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CTRL_ENTREGA_LOTE" ReadOnly="True" VisibleIndex="2" Caption="Id ctrl entrega lote" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="4" Caption="Acceslote" />
        <dx:GridViewDataTextColumn FieldName="DIAZAFRA" VisibleIndex="5" Caption="Diazafra" />
        <dx:GridViewDataTextColumn FieldName="CONCEPTO" VisibleIndex="6" Caption="Concepto" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_REF" VisibleIndex="7" Caption="Codigo ref" />
        <dx:GridViewDataTextColumn FieldName="ID_REF" VisibleIndex="8" Caption="Id ref" />
        <dx:GridViewDataTextColumn FieldName="INICIAL" VisibleIndex="9" Caption="Inicial" />
        <dx:GridViewDataTextColumn FieldName="SALIDAS" VisibleIndex="10" Caption="Salidas" />
        <dx:GridViewDataTextColumn FieldName="SALDO" VisibleIndex="11" Caption="Saldo" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="12" Caption="Usuario crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="13" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="14" Caption="Usuario act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="15" Caption="Fecha act" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="16">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleCONTROL_ENTREGA_LOTE ID="ucVistaDetalleCONTROL_ENTREGA_LOTE1" runat="server" 
                ID_CTRL_ENTREGA_LOTE='<%# Bind("ID_CTRL_ENTREGA_LOTE") %>' ID_ZAFRA='<%# Bind("ID_ZAFRA") %>' ACCESLOTE='<%# Bind("ACCESLOTE") %>' DIAZAFRA='<%# Bind("DIAZAFRA") %>' CONCEPTO='<%# Bind("CONCEPTO") %>' CODIGO_REF='<%# Bind("CODIGO_REF") %>' ID_REF='<%# Bind("ID_REF") %>' INICIAL='<%# Bind("INICIAL") %>' SALIDAS='<%# Bind("SALIDAS") %>' SALDO='<%# Bind("SALDO") %>' USUARIO_CREA='<%# Bind("USUARIO_CREA") %>' FECHA_CREA='<%# Bind("FECHA_CREA") %>' USUARIO_ACT='<%# Bind("USUARIO_ACT") %>' FECHA_ACT='<%# Bind("FECHA_ACT") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTROL_ENTREGA_LOTE" DeleteMethod="EliminarCONTROL_ENTREGA_LOTE" UpdateMethod="ActualizarCONTROL_ENTREGA_LOTE"
    TypeName="SISPACAL.BL.cCONTROL_ENTREGA_LOTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CTRL_ENTREGA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="INICIAL" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CTRL_ENTREGA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="INICIAL" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CTRL_ENTREGA_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCONTROL_ENTREGA_LOTE" DeleteMethod="EliminarCONTROL_ENTREGA_LOTE" UpdateMethod="ActualizarCONTROL_ENTREGA_LOTE"
    TypeName="SISPACAL.BL.cCONTROL_ENTREGA_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CTRL_ENTREGA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="INICIAL" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CTRL_ENTREGA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="INICIAL" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CTRL_ENTREGA_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarCONTROL_ENTREGA_LOTE" DeleteMethod="EliminarCONTROL_ENTREGA_LOTE" UpdateMethod="ActualizarCONTROL_ENTREGA_LOTE"
    TypeName="SISPACAL.BL.cCONTROL_ENTREGA_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CTRL_ENTREGA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="INICIAL" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CTRL_ENTREGA_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="CODIGO_REF" Type="String" />
        <asp:Parameter Name="ID_REF" Type="Int32" />
        <asp:Parameter Name="INICIAL" Type="Decimal" />
        <asp:Parameter Name="SALIDAS" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CTRL_ENTREGA_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
