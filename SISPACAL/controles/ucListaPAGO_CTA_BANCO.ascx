<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPAGO_CTA_BANCO.ascx.vb" Inherits="controles_ucListaPAGO_CTA_BANCO" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_PAGO_CTA_BANCO" Width="100%"   >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>        
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>       
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="2" Caption="Zafra" ReadOnly="true" Width="100px"  UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ID_PAGO_CTA_BANCO" ReadOnly="True" VisibleIndex="2" Caption="Id pago cta banco" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CATORCENA" VisibleIndex="3" Caption="Id catorcena" Visible="false" />                
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_PLANILLA" VisibleIndex="5" Caption="Id tipo planilla" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TIPO_PLANILLA" VisibleIndex="6" Caption="Tipo planilla" ReadOnly="true" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CATORCENA" VisibleIndex="6" Caption="Catorcena" UnboundType="Integer" ReadOnly="true" Width="50px"  />
        <dx:GridViewDataTextColumn FieldName="CODIBANCO" VisibleIndex="6" Caption="Codibanco" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIGO" VisibleIndex="6" Caption="Código" ReadOnly="true" UnboundType="Integer" SortIndex="0" SortOrder="Ascending" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR_TRANSPORTISTA" VisibleIndex="6" Caption="Código" ReadOnly="true" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR_TRANSPORTISTA" VisibleIndex="6" Caption="Nombre" ReadOnly="true" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_BANCO" VisibleIndex="6" Caption="Banco" ReadOnly="true" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NUM_CUENTA" VisibleIndex="7" Caption="N° Cuenta" ReadOnly="true" />
        <dx:GridViewDataCheckColumn FieldName="ES_CTA_CORRIENTE" VisibleIndex="8" Caption="Cuenta Corriente" ReadOnly="true" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Width="40px" />
        <dx:GridViewDataTextColumn FieldName="MONTO_PAGO" VisibleIndex="9" Caption="Monto Pago" ReadOnly="true" Width="120px" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataCheckColumn FieldName="ENTREGO_CCF" VisibleIndex="10" CellStyle-BackColor="#E3F1FB" Caption="Entregó CCF" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Width="40px" />
        <dx:GridViewDataCheckColumn FieldName="PAGO_GENERADO" VisibleIndex="11" Caption="Pago" ReadOnly="true" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Width="40px" />
        <dx:GridViewDataTextColumn FieldName="FECHA_GENPAGO_" VisibleIndex="12" Caption="Fecha Generación del Pago" ReadOnly="true" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Width="120px" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="13" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="14" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="15" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="16" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn Name="Edicion" ButtonType="Image" VisibleIndex="17" Caption=" "    >          
            <EditButton Visible="False" Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" >
                <Image ToolTip="Editar" IconID="edit_edit_16x16"></Image>
            </EditButton>   
            <UpdateButton Visible="False" Image-ToolTip="Guardar" Image-IconID="save_save_16x16" >
                <Image ToolTip="Guardar" IconID="save_save_16x16"></Image>
            </UpdateButton>                     
            <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" >
                <Image ToolTip="Cancelar" IconID="history_undo_16x16"></Image>
            </CancelButton>    
        </dx:GridViewCommandColumn>
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" InsertMethod="AgregarPAGO_CTA_BANCO" DeleteMethod="EliminarPAGO_CTA_BANCO" UpdateMethod="ActualizarPAGO_CTA_BANCO"
    TypeName="SISPACAL.BL.cPAGO_CTA_BANCO">
    <SelectParameters>
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ES_CONTRIBUYENTE" Type="Int32" />
        <asp:Parameter Name="MOSTRAR_POR" Type="Int32" />
        <asp:Parameter Name="asColumnaOrden" DefaultValue=""  Type="String" />
        <asp:Parameter Name="asTipoOrden" DefaultValue="ASC"  Type="String" />
        <asp:Parameter Name="CODIBANCO" DefaultValue="-1"  Type="Int32" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PAGO_CTA_BANCO" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="NUM_CUENTA" Type="String" />
        <asp:Parameter Name="ES_CTA_CORRIENTE" Type="Boolean" />
        <asp:Parameter Name="MONTO_PAGO" Type="Decimal" />
        <asp:Parameter Name="ENTREGO_CCF" Type="Boolean" />
        <asp:Parameter Name="PAGO_GENERADO" Type="Boolean" />
        <asp:Parameter Name="FECHA_GENPAGO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PAGO_CTA_BANCO" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="NUM_CUENTA" Type="String" />
        <asp:Parameter Name="ES_CTA_CORRIENTE" Type="Boolean" />
        <asp:Parameter Name="MONTO_PAGO" Type="Decimal" />
        <asp:Parameter Name="ENTREGO_CCF" Type="Boolean" />
        <asp:Parameter Name="PAGO_GENERADO" Type="Boolean" />
        <asp:Parameter Name="FECHA_GENPAGO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PAGO_CTA_BANCO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPAGO_CTA_BANCO" DeleteMethod="EliminarPAGO_CTA_BANCO" UpdateMethod="ActualizarPAGO_CTA_BANCO"
    TypeName="SISPACAL.BL.cPAGO_CTA_BANCO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PAGO_CTA_BANCO" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="NUM_CUENTA" Type="String" />
        <asp:Parameter Name="ES_CTA_CORRIENTE" Type="Boolean" />
        <asp:Parameter Name="MONTO_PAGO" Type="Decimal" />
        <asp:Parameter Name="ENTREGO_CCF" Type="Boolean" />
        <asp:Parameter Name="PAGO_GENERADO" Type="Boolean" />
        <asp:Parameter Name="FECHA_GENPAGO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PAGO_CTA_BANCO" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="NUM_CUENTA" Type="String" />
        <asp:Parameter Name="ES_CTA_CORRIENTE" Type="Boolean" />
        <asp:Parameter Name="MONTO_PAGO" Type="Decimal" />
        <asp:Parameter Name="ENTREGO_CCF" Type="Boolean" />
        <asp:Parameter Name="PAGO_GENERADO" Type="Boolean" />
        <asp:Parameter Name="FECHA_GENPAGO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PAGO_CTA_BANCO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCATORCENA_ZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorCATORCENA_ZAFRA" InsertMethod="AgregarPAGO_CTA_BANCO" DeleteMethod="EliminarPAGO_CTA_BANCO" UpdateMethod="ActualizarPAGO_CTA_BANCO"
    TypeName="SISPACAL.BL.cPAGO_CTA_BANCO">
    <SelectParameters>
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PAGO_CTA_BANCO" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="NUM_CUENTA" Type="String" />
        <asp:Parameter Name="ES_CTA_CORRIENTE" Type="Boolean" />
        <asp:Parameter Name="MONTO_PAGO" Type="Decimal" />
        <asp:Parameter Name="ENTREGO_CCF" Type="Boolean" />
        <asp:Parameter Name="PAGO_GENERADO" Type="Boolean" />
        <asp:Parameter Name="FECHA_GENPAGO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PAGO_CTA_BANCO" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="NUM_CUENTA" Type="String" />
        <asp:Parameter Name="ES_CTA_CORRIENTE" Type="Boolean" />
        <asp:Parameter Name="MONTO_PAGO" Type="Decimal" />
        <asp:Parameter Name="ENTREGO_CCF" Type="Boolean" />
        <asp:Parameter Name="PAGO_GENERADO" Type="Boolean" />
        <asp:Parameter Name="FECHA_GENPAGO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PAGO_CTA_BANCO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPLANILLA" runat="server" 
    SelectMethod="ObtenerListaPorPLANILLA" InsertMethod="AgregarPAGO_CTA_BANCO" DeleteMethod="EliminarPAGO_CTA_BANCO" UpdateMethod="ActualizarPAGO_CTA_BANCO"
    TypeName="SISPACAL.BL.cPAGO_CTA_BANCO">
    <SelectParameters>
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PAGO_CTA_BANCO" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="NUM_CUENTA" Type="String" />
        <asp:Parameter Name="ES_CTA_CORRIENTE" Type="Boolean" />
        <asp:Parameter Name="MONTO_PAGO" Type="Decimal" />
        <asp:Parameter Name="ENTREGO_CCF" Type="Boolean" />
        <asp:Parameter Name="PAGO_GENERADO" Type="Boolean" />
        <asp:Parameter Name="FECHA_GENPAGO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PAGO_CTA_BANCO" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="NUM_CUENTA" Type="String" />
        <asp:Parameter Name="ES_CTA_CORRIENTE" Type="Boolean" />
        <asp:Parameter Name="MONTO_PAGO" Type="Decimal" />
        <asp:Parameter Name="ENTREGO_CCF" Type="Boolean" />
        <asp:Parameter Name="PAGO_GENERADO" Type="Boolean" />
        <asp:Parameter Name="FECHA_GENPAGO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PAGO_CTA_BANCO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_PLANILLA" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_PLANILLA" InsertMethod="AgregarPAGO_CTA_BANCO" DeleteMethod="EliminarPAGO_CTA_BANCO" UpdateMethod="ActualizarPAGO_CTA_BANCO"
    TypeName="SISPACAL.BL.cPAGO_CTA_BANCO">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PAGO_CTA_BANCO" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="NUM_CUENTA" Type="String" />
        <asp:Parameter Name="ES_CTA_CORRIENTE" Type="Boolean" />
        <asp:Parameter Name="MONTO_PAGO" Type="Decimal" />
        <asp:Parameter Name="ENTREGO_CCF" Type="Boolean" />
        <asp:Parameter Name="PAGO_GENERADO" Type="Boolean" />
        <asp:Parameter Name="FECHA_GENPAGO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PAGO_CTA_BANCO" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR_TRANSPORTISTA" Type="String" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="NUM_CUENTA" Type="String" />
        <asp:Parameter Name="ES_CTA_CORRIENTE" Type="Boolean" />
        <asp:Parameter Name="MONTO_PAGO" Type="Decimal" />
        <asp:Parameter Name="ENTREGO_CCF" Type="Boolean" />
        <asp:Parameter Name="PAGO_GENERADO" Type="Boolean" />
        <asp:Parameter Name="FECHA_GENPAGO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PAGO_CTA_BANCO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
