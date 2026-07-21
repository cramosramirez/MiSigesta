<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_ANTICIPO_ZAFRA.ascx.vb" Inherits="controles_ucListaSOLIC_ANTICIPO_ZAFRA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_ANTI_ZAFRA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
         <dx:GridViewCommandColumn Name="Edicion" ButtonType="Image" VisibleIndex="0" Visible="False" Width="20px" Caption=" "  >             
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
        <dx:GridViewCommandColumn Name="Edicion2" ButtonType="Image" VisibleIndex="0" Visible="False" Width="20px" Caption=" "  >               
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
        <dx:GridViewDataTextColumn FieldName="ID_ANTI_ZAFRA" ReadOnly="True" VisibleIndex="2" Caption="Id anti zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ANTICIPO" VisibleIndex="3" Caption="Id anticipo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="4" Caption="Id zafra" Visible="false" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="4" Caption="Zafra" UnboundType="String" Width="160px" ReadOnly="true"  />
        <dx:GridViewDataDateColumn FieldName="FECHA_ULTMOV" VisibleIndex="5" Caption="Fecha Ultimo Movto" Width="170px" >
            <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataDateColumn>                
        <dx:GridViewDataSpinEditColumn FieldName="CUOTA" VisibleIndex="6" Caption="Cuota" Width="200px" >
            <PropertiesSpinEdit ClientInstanceName="speCUOTA" DecimalPlaces="2" DisplayFormatString="#,##0.00" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>    
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>        
        <dx:GridViewDataTextColumn VisibleIndex="9" Name="Eliminar" Caption=" " Width="20px"  CellStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEliminar" runat="server" AlternateText="Eliminar" ToolTip="Eliminar" CommandName="Eliminar" ImageUrl="~/imagenes/eliminar.png"  CommandArgument='<%# Bind("ID_ANTI_ZAFRA")%>'></asp:ImageButton>                             
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsSOLIC_ANTICIPO_ZAFRAcache" runat="server" TypeName="cSOLIC_ANTICIPO_ZAFRAcache"     
    SelectMethod="ObtenerLista" UpdateMethod="Actualizar" DeleteMethod="Eliminar">       
     <SelectParameters>             
        <asp:Parameter Name="nombreSesion_ucListaSOLIC_ANTICIPO_ZAFRA" Type="String" />
     </SelectParameters>     
     <UpdateParameters>    
        <asp:Parameter Name="ID_ANTI_ZAFRA" Type="Int32" />        
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="CUOTA" Type="Decimal" />
        <asp:Parameter Name="REFERENCIA" Type="String" />                   
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANTI_ZAFRA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_ANTICIPO_ZAFRA" DeleteMethod="EliminarSOLIC_ANTICIPO_ZAFRA" UpdateMethod="ActualizarSOLIC_ANTICIPO_ZAFRA"
    TypeName="SISPACAL.BL.cSOLIC_ANTICIPO_ZAFRA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANTI_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="CUOTA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANTI_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="CUOTA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANTI_ZAFRA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_ANTICIPO" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_ANTICIPO" InsertMethod="AgregarSOLIC_ANTICIPO_ZAFRA" DeleteMethod="EliminarSOLIC_ANTICIPO_ZAFRA" UpdateMethod="ActualizarSOLIC_ANTICIPO_ZAFRA"
    TypeName="SISPACAL.BL.cSOLIC_ANTICIPO_ZAFRA">
    <SelectParameters>
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANTI_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="CUOTA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANTI_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="CUOTA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANTI_ZAFRA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarSOLIC_ANTICIPO_ZAFRA" DeleteMethod="EliminarSOLIC_ANTICIPO_ZAFRA" UpdateMethod="ActualizarSOLIC_ANTICIPO_ZAFRA"
    TypeName="SISPACAL.BL.cSOLIC_ANTICIPO_ZAFRA">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANTI_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="CUOTA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANTI_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="CUOTA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANTI_ZAFRA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
