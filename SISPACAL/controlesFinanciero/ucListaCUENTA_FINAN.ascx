<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCUENTA_FINAN.ascx.vb" Inherits="controles_ucListaCUENTA_FINAN" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_CUENTA_FINAN" Width="100%" >
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
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_CUENTA_FINAN") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_CUENTA_FINAN") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CUENTA_FINAN" ReadOnly="True" VisibleIndex="2" Caption="Id cuenta finan" Visible="false"   />
        <dx:GridViewDataTextColumn FieldName="CODIGO_CUENTA" VisibleIndex="3" Caption="Codigo Cuenta" HeaderStyle-Wrap="True" Width="40px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CUENTA" VisibleIndex="4" Caption="Concepto de Financiamiento" />
        <dx:GridViewDataTextColumn FieldName="DESCRIP_CUENTA" VisibleIndex="5" Caption="Descrip cuenta" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TIPO_FTO" VisibleIndex="6" Caption="Tipo fto" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="TIPO_FINANCIAMIENTO" VisibleIndex="6" Caption="Tipo Financiamiento" UnboundType="String" HeaderStyle-Wrap="True" Width="50px" />
        <dx:GridViewDataCheckColumn FieldName="APLICA_SOLIC_AGRICOLA" VisibleIndex="7" Caption="Aplica Solic. Agricola" HeaderStyle-Wrap="True" Width="50px" />
        <dx:GridViewDataCheckColumn FieldName="APLICA_ANALIS_FTO" VisibleIndex="8" Caption="Aplica Análisis Financiero" HeaderStyle-Wrap="True" Width="50px" />
        <dx:GridViewDataCheckColumn FieldName="APLICA_FACTURACION" VisibleIndex="9" Caption="Aplica Facturación" HeaderStyle-Wrap="True" Width="50px" />
        <dx:GridViewDataCheckColumn FieldName="APLICA_INTERES" VisibleIndex="10" Caption="Aplica Interes" HeaderStyle-Wrap="True" Width="50px" />
        <dx:GridViewDataCheckColumn FieldName="APLICA_EMISION_CHEQ" VisibleIndex="11" Caption="Aplica Emisión Cheque" HeaderStyle-Wrap="True" Width="50px" />
        <dx:GridViewDataCheckColumn FieldName="APLICA_DESCTO_PLA" VisibleIndex="12" Caption="Aplica Descto. Planilla" HeaderStyle-Wrap="True" Width="50px" />
        <dx:GridViewDataTextColumn FieldName="PORC_SUBSIDIO" VisibleIndex="13" Caption="% Subsidio" >
            <PropertiesTextEdit DisplayFormatString="{0:P}" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="14" Caption="Zafra" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="15" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="16" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="17" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="18" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="19">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
         </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCUENTA_FINAN" DeleteMethod="EliminarCUENTA_FINAN" UpdateMethod="ActualizarCUENTA_FINAN"
    TypeName="SISPACAL.BL.cCUENTA_FINAN">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CODIGO_CUENTA" Type="String" />
        <asp:Parameter Name="NOMBRE_CUENTA" Type="String" />
        <asp:Parameter Name="DESCRIP_CUENTA" Type="String" />
        <asp:Parameter Name="TIPO_FTO" Type="Int32" />
        <asp:Parameter Name="APLICA_SOLIC_AGRICOLA" Type="Boolean" />
        <asp:Parameter Name="APLICA_ANALIS_FTO" Type="Boolean" />
        <asp:Parameter Name="APLICA_FACTURACION" Type="Boolean" />
        <asp:Parameter Name="APLICA_INTERES" Type="Boolean" />
        <asp:Parameter Name="APLICA_EMISION_CHEQ" Type="Boolean" />
        <asp:Parameter Name="APLICA_DESCTO_PLA" Type="Boolean" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="CODIGO_CUENTA" Type="String" />
        <asp:Parameter Name="NOMBRE_CUENTA" Type="String" />
        <asp:Parameter Name="DESCRIP_CUENTA" Type="String" />
        <asp:Parameter Name="TIPO_FTO" Type="Int32" />
        <asp:Parameter Name="APLICA_SOLIC_AGRICOLA" Type="Boolean" />
        <asp:Parameter Name="APLICA_ANALIS_FTO" Type="Boolean" />
        <asp:Parameter Name="APLICA_FACTURACION" Type="Boolean" />
        <asp:Parameter Name="APLICA_INTERES" Type="Boolean" />
        <asp:Parameter Name="APLICA_EMISION_CHEQ" Type="Boolean" />
        <asp:Parameter Name="APLICA_DESCTO_PLA" Type="Boolean" />
        <asp:Parameter Name="PORC_SUBSIDIO" Type="Decimal" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
