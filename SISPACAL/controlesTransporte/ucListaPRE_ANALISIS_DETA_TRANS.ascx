<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPRE_ANALISIS_DETA_TRANS.ascx.vb" Inherits="controles_ucListaPRE_ANALISIS_DETA_TRANS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_DETA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager PageSize="100">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" ButtonType="Image" VisibleIndex="0" Visible="true" Width="50px" Caption=" "  >             
            <EditButton Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" Visible="true" >
                <Image ToolTip="Editar" IconID="edit_edit_16x16"></Image>
            </EditButton>            
            <UpdateButton Image-ToolTip="Guardar" Image-IconID="save_save_16x16" Visible="true" >
                <Image ToolTip="Guardar" IconID="save_save_16x16"></Image>
            </UpdateButton>                     
            <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" Visible="true" >
                <Image ToolTip="Cancelar" IconID="history_undo_16x16"></Image>
            </CancelButton>    
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="ID_DETA" ReadOnly="True" VisibleIndex="2" Caption="Id deta" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ID_ENCA" VisibleIndex="3" Caption="Id enca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="UID_REF" VisibleIndex="4" Caption="Uid ref" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ORDEN" VisibleIndex="5" Caption="Orden" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NUMERO" VisibleIndex="6" Caption="N°" Width="30px" CellStyle-HorizontalAlign="Right" ReadOnly="true"  />
        <dx:GridViewDataTextColumn FieldName="DESCRIPCION" VisibleIndex="7" Caption="Descripción" ReadOnly="true" Width="700px"  />
        <dx:GridViewDataTextColumn FieldName="MONTO" VisibleIndex="8" Caption="Monto (US$)" Width="150px" HeaderStyle-HorizontalAlign="Right" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00##" />
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="ID_CATE" VisibleIndex="11" Caption="Id cate" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CATE_REF" VisibleIndex="12" Caption="Id cate ref" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="13" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="14" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="EDITAR" VisibleIndex="15" Caption="Editar" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="NEGRITA" VisibleIndex="16" Caption="Negrita" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" Visible="false" VisibleIndex="17">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" VerticalScrollBarMode="Auto" VerticalScrollableHeight="620" />
    <SettingsEditing Mode="Inline" />   
    <SettingsBehavior EnableRowHotTrack="false" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsListaPorUIF_REF" runat="server" SelectMethod="ObtenerListaPorUID_REF" UpdateMethod="ActualizarPRE_ANALISIS_DETA_TRANS" TypeName="SISPACAL.BL.cPRE_ANALISIS_DETA_TRANS">
    <SelectParameters>        
        <asp:Parameter DefaultValue="" Name="UID_REF" Type="String" />        
    </SelectParameters>  
    <UpdateParameters>
        <asp:Parameter Name="ID_DETA" Type="Int32" />
        <asp:Parameter Name="ID_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REF" Type="String" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NUMERO" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="UNIDADES" Type="String" />        
        <asp:Parameter Name="ID_CATE" Type="Int32" />
        <asp:Parameter Name="ID_CATE_REF" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="EDITAR" Type="Boolean" />
        <asp:Parameter Name="NEGRITA" Type="Boolean" />
    </UpdateParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPRE_ANALISIS_DETA_TRANS" DeleteMethod="EliminarPRE_ANALISIS_DETA_TRANS" UpdateMethod="ActualizarPRE_ANALISIS_DETA_TRANS"
    TypeName="SISPACAL.BL.cPRE_ANALISIS_DETA_TRANS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DETA" Type="Int32" />
        <asp:Parameter Name="ID_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REF" Type="String" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NUMERO" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="UNIDADES" Type="String" />
        <asp:Parameter Name="ID_CATE" Type="Int32" />
        <asp:Parameter Name="ID_CATE_REF" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="EDITAR" Type="Boolean" />
        <asp:Parameter Name="NEGRITA" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DETA" Type="Int32" />
        <asp:Parameter Name="ID_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REF" Type="String" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NUMERO" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="UNIDADES" Type="String" />
        <asp:Parameter Name="ID_CATE" Type="Int32" />
        <asp:Parameter Name="ID_CATE_REF" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="EDITAR" Type="Boolean" />
        <asp:Parameter Name="NEGRITA" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPRE_ANALISIS_ENCA_TRANS" runat="server" 
    SelectMethod="ObtenerListaPorPRE_ANALISIS_ENCA_TRANS" InsertMethod="AgregarPRE_ANALISIS_DETA_TRANS" DeleteMethod="EliminarPRE_ANALISIS_DETA_TRANS" UpdateMethod="ActualizarPRE_ANALISIS_DETA_TRANS"
    TypeName="SISPACAL.BL.cPRE_ANALISIS_DETA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_ENCA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DETA" Type="Int32" />
        <asp:Parameter Name="ID_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REF" Type="String" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NUMERO" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="UNIDADES" Type="String" />
        <asp:Parameter Name="ID_CATE" Type="Int32" />
        <asp:Parameter Name="ID_CATE_REF" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="EDITAR" Type="Boolean" />
        <asp:Parameter Name="NEGRITA" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DETA" Type="Int32" />
        <asp:Parameter Name="ID_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REF" Type="String" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="NUMERO" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="UNIDADES" Type="String" />
        <asp:Parameter Name="ID_CATE" Type="Int32" />
        <asp:Parameter Name="ID_CATE_REF" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="EDITAR" Type="Boolean" />
        <asp:Parameter Name="NEGRITA" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
