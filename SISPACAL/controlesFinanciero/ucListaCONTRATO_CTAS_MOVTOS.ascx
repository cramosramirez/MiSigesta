<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTRATO_CTAS_MOVTOS.ascx.vb" Inherits="controles_ucListaCONTRATO_CTAS_MOVTOS" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleCONTRATO_CTAS_MOVTOS.ascx" tagname="ucVistaDetalleCONTRATO_CTAS_MOVTOS" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_CONTRATO_CTAS_MOVTOS">
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
                    CommandArgument='<%# Bind("ID_CONTRATO_CTAS_MOVTOS") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_CONTRATO_CTAS_MOVTOS") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CONTRATO_CTAS_MOVTOS" ReadOnly="True" VisibleIndex="2" Caption="Id contrato ctas movtos" />
        <dx:GridViewDataTextColumn FieldName="ID_CONTRATO_CTAS" VisibleIndex="3" Caption="Id contrato ctas" />
        <dx:GridViewDataTextColumn FieldName="CODICONTRATO" VisibleIndex="4" Caption="Codicontrato" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="5" Caption="Id zafra" />
        <dx:GridViewDataTextColumn FieldName="FECHA_APLICA" VisibleIndex="6" Caption="Fecha aplica" />
        <dx:GridViewDataTextColumn FieldName="CONCEPTO" VisibleIndex="7" Caption="Concepto" />
        <dx:GridViewDataTextColumn FieldName="SALDO_INI" VisibleIndex="8" Caption="Saldo ini" />
        <dx:GridViewDataTextColumn FieldName="CARGO" VisibleIndex="9" Caption="Cargo" />
        <dx:GridViewDataTextColumn FieldName="ABONO" VisibleIndex="10" Caption="Abono" />
        <dx:GridViewDataTextColumn FieldName="SALDO_FIN" VisibleIndex="11" Caption="Saldo fin" />
        <dx:GridViewDataTextColumn FieldName="UID_SOLIC_AGRI_PROD" VisibleIndex="12" Caption="Uid solic agri prod" />
        <dx:GridViewDataTextColumn FieldName="UID_SOLIC_AGRI_VUELO" VisibleIndex="13" Caption="Uid solic agri vuelo" />
        <dx:GridViewDataTextColumn FieldName="UID_PLANILLA" VisibleIndex="14" Caption="Uid planilla" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="15" Caption="Zafra" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="16" Caption="Usuario crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="17" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="18" Caption="Usuario act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="19" Caption="Fecha act" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="20">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleCONTRATO_CTAS_MOVTOS ID="ucVistaDetalleCONTRATO_CTAS_MOVTOS1" runat="server" 
                ID_CONTRATO_CTAS_MOVTOS='<%# Bind("ID_CONTRATO_CTAS_MOVTOS") %>' ID_CONTRATO_CTAS='<%# Bind("ID_CONTRATO_CTAS") %>' CODICONTRATO='<%# Bind("CODICONTRATO") %>' ID_ZAFRA='<%# Bind("ID_ZAFRA") %>' FECHA_APLICA='<%# Bind("FECHA_APLICA") %>' CONCEPTO='<%# Bind("CONCEPTO") %>' SALDO_INI='<%# Bind("SALDO_INI") %>' CARGO='<%# Bind("CARGO") %>' ABONO='<%# Bind("ABONO") %>' SALDO_FIN='<%# Bind("SALDO_FIN") %>' UID_SOLIC_AGRI_PROD='<%# Bind("UID_SOLIC_AGRI_PROD") %>' UID_SOLIC_AGRI_VUELO='<%# Bind("UID_SOLIC_AGRI_VUELO") %>' UID_PLANILLA='<%# Bind("UID_PLANILLA") %>' ZAFRA='<%# Bind("ZAFRA") %>' USUARIO_CREA='<%# Bind("USUARIO_CREA") %>' FECHA_CREA='<%# Bind("FECHA_CREA") %>' USUARIO_ACT='<%# Bind("USUARIO_ACT") %>' FECHA_ACT='<%# Bind("FECHA_ACT") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTRATO_CTAS_MOVTOS" DeleteMethod="EliminarCONTRATO_CTAS_MOVTOS" UpdateMethod="ActualizarCONTRATO_CTAS_MOVTOS"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS_MOVTOS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="SALDO_INI" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO_FIN" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="UID_PLANILLA" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="SALDO_INI" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO_FIN" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="UID_PLANILLA" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO_CTAS" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO_CTAS" InsertMethod="AgregarCONTRATO_CTAS_MOVTOS" DeleteMethod="EliminarCONTRATO_CTAS_MOVTOS" UpdateMethod="ActualizarCONTRATO_CTAS_MOVTOS"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS_MOVTOS">
    <SelectParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="SALDO_INI" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO_FIN" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="UID_PLANILLA" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="SALDO_INI" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO_FIN" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="UID_PLANILLA" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO" InsertMethod="AgregarCONTRATO_CTAS_MOVTOS" DeleteMethod="EliminarCONTRATO_CTAS_MOVTOS" UpdateMethod="ActualizarCONTRATO_CTAS_MOVTOS"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS_MOVTOS">
    <SelectParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="SALDO_INI" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO_FIN" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="UID_PLANILLA" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="SALDO_INI" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO_FIN" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="UID_PLANILLA" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCONTRATO_CTAS_MOVTOS" DeleteMethod="EliminarCONTRATO_CTAS_MOVTOS" UpdateMethod="ActualizarCONTRATO_CTAS_MOVTOS"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS_MOVTOS">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="SALDO_INI" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO_FIN" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="UID_PLANILLA" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="SALDO_INI" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO_FIN" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="UID_PLANILLA" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_MOVTOS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
