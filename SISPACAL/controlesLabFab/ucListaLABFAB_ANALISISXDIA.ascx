<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaLABFAB_ANALISISXDIA.ascx.vb" Inherits="controles_ucListaLABFAB_ANALISISXDIA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="odsLista" KeyFieldName="ID_ANALISISXDIA">
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
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="true" Width="50px" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_ANALISISXDIA") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_ANALISISXDIA") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ANALISISXDIA" ReadOnly="True" VisibleIndex="2" Caption="Id analisisxdia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_DIAZAFRA" VisibleIndex="3" Caption="Id diazafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="4" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ANALISIS" VisibleIndex="5" Caption="Id analisis" Visible="false" SortIndex="3" />

        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="5" Caption="Zafra" UnboundType="String" Width="80 px"  /> 
        <dx:GridViewDataTextColumn FieldName="DIAZAFRA" VisibleIndex="6" Caption="Dia Zafra" SortIndex="0" Width="80px"  /> 
        <dx:GridViewDataTextColumn FieldName="ID_ETAPA" VisibleIndex="7" Caption="Cód. Etapa" UnboundType="Integer" Width="80px" SortIndex="1" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ETAPA" VisibleIndex="8" Caption="Etapa" UnboundType="String" Width="200px" Settings-HeaderFilterMode="CheckedList" />
        <dx:GridViewDataTextColumn FieldName="ID_MUESTRA" VisibleIndex="9" Caption="Cód muestra" UnboundType="Integer" Width="80px" SortIndex="2" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_MUESTRA" VisibleIndex="10" Caption="Muestra" UnboundType="String" Width="200px" Settings-HeaderFilterMode="CheckedList" />                
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ANALISIS" VisibleIndex="11" Caption="Analisis" Settings-HeaderFilterMode="CheckedList" UnboundType="String"  />
               
        <dx:GridViewDataTextColumn FieldName="NO_ANALISIS" VisibleIndex="12" Caption="N° Análisis" />        
        <dx:GridViewDataTextColumn FieldName="VALOR" VisibleIndex="13" Caption="Valor" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="14" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="15" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="16" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="17" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="18">
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarLABFAB_ANALISISXDIA" DeleteMethod="EliminarLABFAB_ANALISISXDIA" UpdateMethod="ActualizarLABFAB_ANALISISXDIA"
    TypeName="SISPACAL.BL.cLABFAB_ANALISISXDIA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANALISISXDIA" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="NO_ANALISIS" Type="Int32" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANALISISXDIA" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="NO_ANALISIS" Type="Int32" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANALISISXDIA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_DIAZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_DIAZAFRA" InsertMethod="AgregarLABFAB_ANALISISXDIA" DeleteMethod="EliminarLABFAB_ANALISISXDIA" UpdateMethod="ActualizarLABFAB_ANALISISXDIA"
    TypeName="SISPACAL.BL.cLABFAB_ANALISISXDIA">
    <SelectParameters>
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANALISISXDIA" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="NO_ANALISIS" Type="Int32" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANALISISXDIA" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="NO_ANALISIS" Type="Int32" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANALISISXDIA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_ANALISIS" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_ANALISIS" InsertMethod="AgregarLABFAB_ANALISISXDIA" DeleteMethod="EliminarLABFAB_ANALISISXDIA" UpdateMethod="ActualizarLABFAB_ANALISISXDIA"
    TypeName="SISPACAL.BL.cLABFAB_ANALISISXDIA">
    <SelectParameters>
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANALISISXDIA" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="NO_ANALISIS" Type="Int32" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANALISISXDIA" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="NO_ANALISIS" Type="Int32" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANALISISXDIA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
