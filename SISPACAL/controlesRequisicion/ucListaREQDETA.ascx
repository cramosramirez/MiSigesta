<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaREQDETA.ascx.vb" Inherits="controles_ucListaREQDETA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxCallbackPanel ID="cpListaREQDETA" ClientInstanceName="cpListaREQDETA" runat="server" ShowLoadingPanel="false" Width="100%" >        
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">  
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_REQDETA" Width="100%" ClientInstanceName="gridREQDETA" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" ShowNewButtonInHeader="true" ButtonType="Image" VisibleIndex="0" Visible="False" Width="50px" Caption=" "  >
            <NewButton Visible="False" Image-ToolTip="Agregar" Image-IconID="actions_new_16x16" >
                <Image ToolTip="Agregar" IconID="actions_new_16x16"></Image>
            </NewButton>      
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
        <dx:GridViewCommandColumn Name="Edicion2" ButtonType="Image" VisibleIndex="0" Visible="False" Width="50px" Caption=" "  >
            <NewButton Visible="False" Image-ToolTip="Agregar" Image-IconID="actions_new_16x16" >
                <Image ToolTip="Agregar" IconID="actions_new_16x16"></Image>
            </NewButton>      
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
        <dx:GridViewDataTextColumn FieldName="ID_REQDETA" ReadOnly="True" VisibleIndex="2" Caption="Id reqdeta" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_REQENCA" VisibleIndex="3" Caption="Id reqenca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIGO" VisibleIndex="4" Width="100px" Caption="CODIGO" CellStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="CANTIDAD" VisibleIndex="5" Width="80px" Caption="CANTIDAD" CellStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="UNIDAD" VisibleIndex="6" Width="80px" Caption="UNIDAD" CellStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="DESCRIPCION" VisibleIndex="7" Width="500px" Caption="DESCRIPCION" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="OBSERVACION" VisibleIndex="8" Width="240px" Caption="OBSERVACION" HeaderStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="9" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="10" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="11" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="12" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="REFERENCIA" VisibleIndex="13" Caption="Referencia" Visible="false"/>
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="14" Width="40px" >
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="False"  ShowHeaderFilterButton="False" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />      
</dx:ASPxGridView>
    </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>

<dx:ASPxHiddenField runat="server" ClientInstanceName="hfSolicREQENCA" ID="hfSolicREQENCA" />

<asp:ObjectDataSource ID="odsReqDetaCache" runat="server" TypeName="cREQDETAcache" 
    InsertMethod="Agregar" SelectMethod="ObtenerLista" UpdateMethod="Actualizar" DeleteMethod="Eliminar" >       
     <SelectParameters>       
        <asp:Parameter Name="nombreSesion" Type="String" />
     </SelectParameters>
     <InsertParameters>
        <asp:Parameter Name="ID_REQDETA" Type="Int32" />
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />        
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="REFERENCIA" Type="String" />
     </InsertParameters>  
     <UpdateParameters>    
       <asp:Parameter Name="ID_REQDETA" Type="Int32" />
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />        
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="REFERENCIA" Type="String" />         
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REQDETA" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarREQDETA" DeleteMethod="EliminarREQDETA" UpdateMethod="ActualizarREQDETA"
    TypeName="SISPACAL.BL.cREQDETA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REQDETA" Type="Int32" />
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REQDETA" Type="Int32" />
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REQDETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorREQENCA" runat="server" 
    SelectMethod="ObtenerListaPorREQENCA" InsertMethod="AgregarREQDETA" DeleteMethod="EliminarREQDETA" UpdateMethod="ActualizarREQDETA"
    TypeName="SISPACAL.BL.cREQDETA">
    <SelectParameters>
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REQDETA" Type="Int32" />
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REQDETA" Type="Int32" />
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="CANTIDAD" Type="String" />
        <asp:Parameter Name="UNIDAD" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REQDETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
