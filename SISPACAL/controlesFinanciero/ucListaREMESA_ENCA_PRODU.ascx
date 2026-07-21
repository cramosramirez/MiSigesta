<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaREMESA_ENCA_PRODU.ascx.vb" Inherits="controles_ucListaREMESA_ENCA_PRODU" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%"  KeyFieldName="ID_REMESA_ENCA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
         <dx:GridViewDataTextColumn VisibleIndex="0" Visible="true" Caption="Editar" Name="Editar" CellStyle-HorizontalAlign="Center" Width="40px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_REMESA_ENCA")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_REMESA_ENCA")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_REMESA_ENCA" ReadOnly="True" VisibleIndex="2" Caption="Identificador" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="2" Caption="Zafra" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="3" Caption="Codiproveedor" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIBANCO" VisibleIndex="4" Caption="Codibanco" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="4" Caption="Código" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="4" Caption="Productor" UnboundType="String" Width="300px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_BANCO" VisibleIndex="4" Caption="Banco" UnboundType="String" Width="300px" />
        <dx:GridViewDataTextColumn FieldName="FECHA_REMESA" VisibleIndex="5" Caption="Fecha Remesa" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="UID_REMESA_ENCA" VisibleIndex="6" Caption="Uid remesa enca" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="NO_REMESA" VisibleIndex="7" Caption="No Remesa" />
        <dx:GridViewDataTextColumn FieldName="OBSERVACION" VisibleIndex="8" Caption="Observacion" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ABONO_CAPITAL" VisibleIndex="9" Caption="Abono Credito" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ABONO_INTERES" VisibleIndex="10" Caption="Abono Interes" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ABONO_INTERES_IVA" VisibleIndex="11" Caption="Abono IVA Interes" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TOTAL" VisibleIndex="12" Caption="Total" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="13" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="14" Caption="Fecha crea" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="15" Caption="Usuario act" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="16" Caption="Fecha act" Visible="false"  />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="17">
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

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarREMESA_ENCA_PRODU" DeleteMethod="EliminarREMESA_ENCA_PRODU" UpdateMethod="ActualizarREMESA_ENCA_PRODU"
    TypeName="SISPACAL.BL.cREMESA_ENCA_PRODU">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="FECHA_REMESA" Type="DateTime" />
        <asp:Parameter Name="UID_REMESA_ENCA" Type="Object" />
        <asp:Parameter Name="NO_REMESA" Type="String" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="FECHA_REMESA" Type="DateTime" />
        <asp:Parameter Name="UID_REMESA_ENCA" Type="Object" />
        <asp:Parameter Name="NO_REMESA" Type="String" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorBANCOS" runat="server" 
    SelectMethod="ObtenerListaPorBANCOS" InsertMethod="AgregarREMESA_ENCA_PRODU" DeleteMethod="EliminarREMESA_ENCA_PRODU" UpdateMethod="ActualizarREMESA_ENCA_PRODU"
    TypeName="SISPACAL.BL.cREMESA_ENCA_PRODU">
    <SelectParameters>
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="FECHA_REMESA" Type="DateTime" />
        <asp:Parameter Name="UID_REMESA_ENCA" Type="Object" />
        <asp:Parameter Name="NO_REMESA" Type="String" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODIBANCO" Type="Int32" />
        <asp:Parameter Name="FECHA_REMESA" Type="DateTime" />
        <asp:Parameter Name="UID_REMESA_ENCA" Type="Object" />
        <asp:Parameter Name="NO_REMESA" Type="String" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
