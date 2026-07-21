<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_OIP_LOTE.ascx.vb" Inherits="controles_ucListaSOLIC_OIP_LOTE" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_SOLI_LOTE" Font-Size="X-Small" Width="100%">
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
          <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Name="Edicion" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_SOLI_LOTE") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_SOLI_LOTE") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_SOLI_LOTE" ReadOnly="True" VisibleIndex="2" Caption="Id soli lote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_OPI" VisibleIndex="3" Caption="Id opi" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="4" Caption="Acceslote" Visible="false" />

        <dx:GridViewDataTextColumn FieldName="CONTRATO" UnboundType="String" VisibleIndex="5" Caption="Contrato" SortOrder="Ascending" >            
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODILOTE" UnboundType="String" VisibleIndex="6" Caption="Codigo" >           
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" VisibleIndex="7" UnboundType="String" Caption="Nombre Lote" >                      
        </dx:GridViewDataTextColumn>

        <dx:GridViewDataTextColumn FieldName="MZ" VisibleIndex="8" Caption="Mz" />
        <dx:GridViewDataTextColumn FieldName="TONEL_ESTI" VisibleIndex="9" Caption="Tonel esti" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PROPORCION" VisibleIndex="10" Caption="Proporcion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="11" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="12" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="13" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="14" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="REFERENCIA" VisibleIndex="15" Caption="Referencia" Visible="false"/>
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="16">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text=" " Image-ToolTip="Eliminar" Image-IconID="edit_delete_16x16">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>


<asp:ObjectDataSource ID="odsSolicLotesCache" runat="server" TypeName="cSOLIC_OIP_LOTEcache" SelectMethod="ObtenerLista" UpdateMethod="Actualizar">       
     <SelectParameters>       
        <asp:Parameter Name="nombreSesion" Type="String" />
     </SelectParameters>
     <UpdateParameters>    
        <asp:Parameter Name="ID_SOLI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_OPI" Type="Int32" />        
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />        
    </UpdateParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_OIP_LOTE" DeleteMethod="EliminarSOLIC_OIP_LOTE" UpdateMethod="ActualizarSOLIC_OIP_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_OIP_LOTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="PROPORCION" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="PROPORCION" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLI_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_OPI" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_OPI" InsertMethod="AgregarSOLIC_OIP_LOTE" DeleteMethod="EliminarSOLIC_OIP_LOTE" UpdateMethod="ActualizarSOLIC_OIP_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_OIP_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="PROPORCION" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="PROPORCION" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLI_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarSOLIC_OIP_LOTE" DeleteMethod="EliminarSOLIC_OIP_LOTE" UpdateMethod="ActualizarSOLIC_OIP_LOTE"
    TypeName="SISPACAL.BL.cSOLIC_OIP_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="PROPORCION" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLI_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_OPI" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_ESTI" Type="Decimal" />
        <asp:Parameter Name="PROPORCION" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLI_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
