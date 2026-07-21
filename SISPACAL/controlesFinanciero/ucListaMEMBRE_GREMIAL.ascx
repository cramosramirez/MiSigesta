<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaMEMBRE_GREMIAL.ascx.vb" Inherits="controles_ucListaMEMBRE_GREMIAL" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_MEMBRE_GREMIAL" Width="100%" >
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
        <dx:GridViewDataTextColumn VisibleIndex="1" Width="20px">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_MEMBRE_GREMIAL") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_MEMBRE_GREMIAL") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_MEMBRE_GREMIAL" ReadOnly="True" VisibleIndex="2" Caption="Identificador" SortIndex="0" SortOrder="Descending"  />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="3" Caption="Codiproveedor" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="NUM_MEMBRE_GREMIAL" VisibleIndex="4" Caption="N° de Membresia" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="5" Caption="Fecha" SortIndex="1" SortOrder="Descending" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>       

        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="6" Caption="Cód. Provee" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="6" Caption="Nombre Proveedor" UnboundType="String" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_GREMIAL" VisibleIndex="6" Caption="Nombre de Gremial" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="MONTO_X_TC" VisibleIndex="7" Caption="Monto x TC" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="UID_MEMBRE_CONTRATO" VisibleIndex="8" Caption="Uid membre contrato" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="9" Caption="Usuario crea" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="10" Caption="Fecha crea" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="11" Caption="Usuario act" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="12" Caption="Fecha act" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="13" Caption="Id zafra" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="14" Caption="Zafra" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="15">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
         </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" TypeName="SISPACAL.BL.cMEMBRE_GREMIAL">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="NUM_MEMBRE_GREMIAL" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />        
        <asp:Parameter Name="FECHA" Type="DateTime" />        
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarMEMBRE_GREMIAL" DeleteMethod="EliminarMEMBRE_GREMIAL" UpdateMethod="ActualizarMEMBRE_GREMIAL"
    TypeName="SISPACAL.BL.cMEMBRE_GREMIAL">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_MEMBRE_GREMIAL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_MEMBRE_GREMIAL" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MONTO_X_TC" Type="Decimal" />
        <asp:Parameter Name="UID_MEMBRE_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MEMBRE_GREMIAL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_MEMBRE_GREMIAL" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MONTO_X_TC" Type="Decimal" />
        <asp:Parameter Name="UID_MEMBRE_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_MEMBRE_GREMIAL" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarMEMBRE_GREMIAL" DeleteMethod="EliminarMEMBRE_GREMIAL" UpdateMethod="ActualizarMEMBRE_GREMIAL"
    TypeName="SISPACAL.BL.cMEMBRE_GREMIAL">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_MEMBRE_GREMIAL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_MEMBRE_GREMIAL" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MONTO_X_TC" Type="Decimal" />
        <asp:Parameter Name="UID_MEMBRE_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MEMBRE_GREMIAL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_MEMBRE_GREMIAL" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MONTO_X_TC" Type="Decimal" />
        <asp:Parameter Name="UID_MEMBRE_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_MEMBRE_GREMIAL" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO" InsertMethod="AgregarMEMBRE_GREMIAL" DeleteMethod="EliminarMEMBRE_GREMIAL" UpdateMethod="ActualizarMEMBRE_GREMIAL"
    TypeName="SISPACAL.BL.cMEMBRE_GREMIAL">
    <SelectParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_MEMBRE_GREMIAL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_MEMBRE_GREMIAL" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MONTO_X_TC" Type="Decimal" />
        <asp:Parameter Name="UID_MEMBRE_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MEMBRE_GREMIAL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_MEMBRE_GREMIAL" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MONTO_X_TC" Type="Decimal" />
        <asp:Parameter Name="UID_MEMBRE_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_MEMBRE_GREMIAL" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarMEMBRE_GREMIAL" DeleteMethod="EliminarMEMBRE_GREMIAL" UpdateMethod="ActualizarMEMBRE_GREMIAL"
    TypeName="SISPACAL.BL.cMEMBRE_GREMIAL">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_MEMBRE_GREMIAL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_MEMBRE_GREMIAL" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MONTO_X_TC" Type="Decimal" />
        <asp:Parameter Name="UID_MEMBRE_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MEMBRE_GREMIAL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NUM_MEMBRE_GREMIAL" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MONTO_X_TC" Type="Decimal" />
        <asp:Parameter Name="UID_MEMBRE_CONTRATO" Type="Object" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_MEMBRE_GREMIAL" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
