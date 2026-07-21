<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaLABFAB_ANALISIS.ascx.vb" Inherits="controles_ucListaLABFAB_ANALISIS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_ANALISIS" Width="100%">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <Settings ShowGroupPanel="true" />
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
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="true">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ToolTip="Editar Análisis"  ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_ANALISIS") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_ANALISIS") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colNuevoAnalisis" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnNuevoAnalisis" Image-IconID="print_preview_16x16" Image-ToolTip="Ingreso de Analisis">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewDataTextColumn FieldName="ID_ETAPA" VisibleIndex="2" Caption="Cód. Etapa" UnboundType="Integer" Width="80px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ETAPA" VisibleIndex="2" Caption="Etapa" UnboundType="String" Width="200px" Settings-HeaderFilterMode="CheckedList" />
        <dx:GridViewDataTextColumn FieldName="ID_MUESTRA" VisibleIndex="3" Caption="Cód muestra" Width="80px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_MUESTRA" VisibleIndex="3" Caption="Muestra" UnboundType="String" Width="200px" Settings-HeaderFilterMode="CheckedList" />                
        <dx:GridViewDataTextColumn FieldName="ID_ANALISIS" ReadOnly="True" VisibleIndex="4" Caption="Cód Analisis" Width="80px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ANALISIS" VisibleIndex="4" Caption="Analisis" Settings-HeaderFilterMode="CheckedList" />
        <dx:GridViewDataTextColumn FieldName="FORMULA" VisibleIndex="5" Caption="Formula" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="OBSERVACIONES" VisibleIndex="6" Caption="Observaciones" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ORDEN_EJEC" VisibleIndex="6" Caption="Orden" />
        <dx:GridViewDataTextColumn FieldName="CANT_ANALISIS" VisibleIndex="7" Caption="Analisis x Dia" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="8" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="9" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="10" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="11" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="12">
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarLABFAB_ANALISIS" DeleteMethod="EliminarLABFAB_ANALISIS" UpdateMethod="ActualizarLABFAB_ANALISIS"
    TypeName="SISPACAL.BL.cLABFAB_ANALISIS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_MUESTRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_ANALISIS" Type="String" />
        <asp:Parameter Name="FORMULA" Type="String" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CANT_ANALISIS" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_MUESTRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_ANALISIS" Type="String" />
        <asp:Parameter Name="FORMULA" Type="String" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CANT_ANALISIS" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_MUESTRA" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_MUESTRA" InsertMethod="AgregarLABFAB_ANALISIS" DeleteMethod="EliminarLABFAB_ANALISIS" UpdateMethod="ActualizarLABFAB_ANALISIS"
    TypeName="SISPACAL.BL.cLABFAB_ANALISIS">
    <SelectParameters>
        <asp:Parameter Name="ID_MUESTRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_MUESTRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_ANALISIS" Type="String" />
        <asp:Parameter Name="FORMULA" Type="String" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CANT_ANALISIS" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_MUESTRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_ANALISIS" Type="String" />
        <asp:Parameter Name="FORMULA" Type="String" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CANT_ANALISIS" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
