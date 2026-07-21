<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaDIA_ZAFRA.ascx.vb" Inherits="controles_ucListaDIA_ZAFRA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_DIA_ZAFRA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager PageSize="15">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <SettingsCommandButton> 
         <NewButton Text="Agregar"></NewButton> 
         <EditButton Text="Editar"></EditButton> 
         <DeleteButton Text="Eliminar"></DeleteButton> 
    </SettingsCommandButton> 
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Visible="false" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_DIA_ZAFRA") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_DIA_ZAFRA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_DIA_ZAFRA" ReadOnly="True" VisibleIndex="2" Caption="Id dia zafra" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ucID_ZAFRA" VisibleIndex="3" Caption="Zafra" UnboundType="String" Width="100px" CellStyle-HorizontalAlign="Center"   />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="DIAZAFRA" VisibleIndex="4" Caption="Dia Zafra" SortIndex="0" SortOrder="Descending" CellStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="5" Caption="Corte a la fecha" CellStyle-HorizontalAlign="Center" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="HORA_CIERRE" VisibleIndex="5" Caption="Corte a la hora" CellStyle-HorizontalAlign="Center" >
            <PropertiesTextEdit DisplayFormatString="HH:mm" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="AZUCAR_PRODUCIDA" VisibleIndex="6" Caption="Azucar producida" Visible="false"   >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="AZUCAR_CALC1" VisibleIndex="7" Caption="Azucar al 100%" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="EFICIENCIA_REAL" VisibleIndex="8" Caption="Eficiencia real" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CIERRE" VisibleIndex="9" Caption="Usuario cierre" Visible="false"  />                
        
        <dx:GridViewDataTextColumn FieldName="ucUSUARIO_CIERRE" VisibleIndex="11" Caption="Usuario que realizó el corte" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CIERRE" VisibleIndex="11" Caption="Momento en que se realizó el corte" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="12">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text=" " Image-ToolTip="Eliminar" Image-IconID="edit_delete_16x16">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarDIA_ZAFRA" DeleteMethod="EliminarDIA_ZAFRA" UpdateMethod="ActualizarDIA_ZAFRA"
    TypeName="SISPACAL.BL.cDIA_ZAFRA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DIA_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="AZUCAR_PRODUCIDA" Type="Decimal" />
        <asp:Parameter Name="AZUCAR_CALC1" Type="Decimal" />
        <asp:Parameter Name="EFICIENCIA_REAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CIERRE" Type="String" />
        <asp:Parameter Name="FECHA_CIERRE" Type="DateTime" />
        <asp:Parameter Name="HORA_CIERRE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DIA_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="AZUCAR_PRODUCIDA" Type="Decimal" />
        <asp:Parameter Name="AZUCAR_CALC1" Type="Decimal" />
        <asp:Parameter Name="EFICIENCIA_REAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CIERRE" Type="String" />
        <asp:Parameter Name="FECHA_CIERRE" Type="DateTime" />
        <asp:Parameter Name="HORA_CIERRE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DIA_ZAFRA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarDIA_ZAFRA" DeleteMethod="EliminarDIA_ZAFRA" UpdateMethod="ActualizarDIA_ZAFRA"
    TypeName="SISPACAL.BL.cDIA_ZAFRA">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DIA_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="AZUCAR_PRODUCIDA" Type="Decimal" />
        <asp:Parameter Name="AZUCAR_CALC1" Type="Decimal" />
        <asp:Parameter Name="EFICIENCIA_REAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CIERRE" Type="String" />
        <asp:Parameter Name="FECHA_CIERRE" Type="DateTime" />
        <asp:Parameter Name="HORA_CIERRE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DIA_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="AZUCAR_PRODUCIDA" Type="Decimal" />
        <asp:Parameter Name="AZUCAR_CALC1" Type="Decimal" />
        <asp:Parameter Name="EFICIENCIA_REAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CIERRE" Type="String" />
        <asp:Parameter Name="FECHA_CIERRE" Type="DateTime" />
        <asp:Parameter Name="HORA_CIERRE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DIA_ZAFRA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
