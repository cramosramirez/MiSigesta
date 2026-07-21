<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaTRANSPORTISTA.ascx.vb" Inherits="controles_ucListaTRANSPORTISTA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleTRANSPORTISTA.ascx" tagname="ucVistaDetalleTRANSPORTISTA" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="CODTRANSPORT" Width="100%" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents EndCallback="function(s, e){if(s.cpMensaje != null){ AsignarMensaje(s.cpMensaje); delete s.cpMensaje;}}" RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>        
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
       <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("CODTRANSPORT") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("CODTRANSPORT") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODTRANSPORT" ReadOnly="True" VisibleIndex="2" SortIndex="0" SortOrder="Ascending" Caption="Código" />
        <dx:GridViewDataCheckColumn FieldName="ACTIVO" VisibleIndex="3" Caption="Activo" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="4" Caption="Nombres" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="5" Caption="Apellidos" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="5" Caption="DUI" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="6" Caption="NIT" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="7" Caption="Direccion" />  
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO" VisibleIndex="8" Caption="Municipio" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO" VisibleIndex="8" Caption="Departamento" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="8" Caption="Telefono" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="CREDITO_FISCAL" VisibleIndex="9" Caption="NRC" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="CORREO" VisibleIndex="9" Caption="Correo" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CH" VisibleIndex="9" Caption="Nombre en Cheque" Visible="false" />       
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="11" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="12" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="13" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="14" Caption="Fecha act" Visible="false" />        
        <dx:GridViewDataCheckColumn FieldName="ES_INGENIO" VisibleIndex="16" Caption="Es Ingenio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOCUENTA" VisibleIndex="17" Caption="N° Cuenta Contable" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="COD_SIGASI" VisibleIndex="18" Caption="Cód. SIGASI" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="COD_COMBUST" VisibleIndex="19" Caption="Cód. Combustible" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="COD_SIGASI_S" VisibleIndex="19" UnboundType="String" Caption="Cód. SIGASI" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="COD_COMBUST_S" VisibleIndex="19" UnboundType="String" Caption="Cód. Combustible" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="NUM_CUENTA" VisibleIndex="20" Caption="No. de Cuenta" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_BANCO" VisibleIndex="20" UnboundType="String" Caption="Banco" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="20">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True" AllowSelectSingleRowOnly="true" />      
</dx:ASPxGridView>

<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>

<asp:ObjectDataSource ID="odsListaNombreCompleto" runat="server" SelectMethod="ObtenerListaPorNombreCompleto" TypeName="SISPACAL.BL.cTRANSPORTISTA">
    <SelectParameters>
        <asp:Parameter Name="NOMBRE_TRANSPORTISTA" Type="String" />   
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorZafraContratada" runat="server" SelectMethod="ObtenerListaPorZAFRA_CONTRATADA" TypeName="SISPACAL.BL.cTRANSPORTISTA">
    <SelectParameters>      
        <asp:Parameter Name="ID_ZAFRA_CONTRATADA" Type="Int32" />   
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarTRANSPORTISTA" DeleteMethod="EliminarTRANSPORTISTA" UpdateMethod="ActualizarTRANSPORTISTA"
    TypeName="SISPACAL.BL.cTRANSPORTISTA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="CREDITO_FISCAL" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="NOMBRE_CH" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ES_INGENIO" Type="Boolean" />
        <asp:Parameter Name="NOCUENTA" Type="String" />
        <asp:Parameter Name="COD_SIGASI" Type="Int32" />
        <asp:Parameter Name="COD_COMBUST" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="CREDITO_FISCAL" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="NOMBRE_CH" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ES_INGENIO" Type="Boolean" />
        <asp:Parameter Name="NOCUENTA" Type="String" />
        <asp:Parameter Name="COD_SIGASI" Type="Int32" />
        <asp:Parameter Name="COD_COMBUST" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
