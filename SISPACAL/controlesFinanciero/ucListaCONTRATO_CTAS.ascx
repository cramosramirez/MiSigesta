<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTRATO_CTAS.ascx.vb" Inherits="controles_ucListaCONTRATO_CTAS" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleCONTRATO_CTAS.ascx" tagname="ucVistaDetalleCONTRATO_CTAS" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_CONTRATO_CTAS" Width="100%" >
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
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="Seleccionar">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_CONTRATO_CTAS") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_CONTRATO_CTAS") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CONTRATO_CTAS" ReadOnly="True" VisibleIndex="2" Caption="Id contrato ctas" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CONTRATO_FINAN" VisibleIndex="3" Caption="Id contrato finan" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODICONTRATO" VisibleIndex="4" Caption="Codicontrato" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="5" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CUENTA_FINAN" VisibleIndex="6" Caption="Id cuenta finan" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CONCEPTO" VisibleIndex="6" Caption="CONCEPTO" UnboundType="String" Width="400px" CellStyle-HorizontalAlign="Left"  />
        <dx:GridViewDataTextColumn FieldName="CARGO" VisibleIndex="7" Caption="MONTO" HeaderStyle-HorizontalAlign="Right" CellStyle-HorizontalAlign="Right"  />
        <dx:GridViewDataTextColumn FieldName="ABONO" VisibleIndex="8" Caption="ABONO" HeaderStyle-HorizontalAlign="Right" CellStyle-HorizontalAlign="Right"/>
        <dx:GridViewDataTextColumn FieldName="SALDO" CellStyle-BackColor="#ffff99" VisibleIndex="9" Caption="SALDO" HeaderStyle-HorizontalAlign="Right" CellStyle-HorizontalAlign="Right"/>
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="10" Caption="Zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="11" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="12" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="13" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="14" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="15">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>   
    <Settings ShowFilterRow="True" ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="False" AllowFocusedRow="False"  />      
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTRATO_CTAS" DeleteMethod="EliminarCONTRATO_CTAS" UpdateMethod="ActualizarCONTRATO_CTAS"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO_FINAN" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO_FINAN" InsertMethod="AgregarCONTRATO_CTAS" DeleteMethod="EliminarCONTRATO_CTAS" UpdateMethod="ActualizarCONTRATO_CTAS"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS">
    <SelectParameters>
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO" InsertMethod="AgregarCONTRATO_CTAS" DeleteMethod="EliminarCONTRATO_CTAS" UpdateMethod="ActualizarCONTRATO_CTAS"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS">
    <SelectParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCONTRATO_CTAS" DeleteMethod="EliminarCONTRATO_CTAS" UpdateMethod="ActualizarCONTRATO_CTAS"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCUENTA_FINAN" runat="server" 
    SelectMethod="ObtenerListaPorCUENTA_FINAN" InsertMethod="AgregarCONTRATO_CTAS" DeleteMethod="EliminarCONTRATO_CTAS" UpdateMethod="ActualizarCONTRATO_CTAS"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS">
    <SelectParameters>
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
