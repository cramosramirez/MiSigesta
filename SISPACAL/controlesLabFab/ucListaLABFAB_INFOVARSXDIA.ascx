<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaLABFAB_INFOVARSXDIA.ascx.vb" Inherits="controles_ucListaLABFAB_INFOVARSXDIA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxCallbackPanel ID="cpListaLABFAB_INFOVARSXDIA" ClientInstanceName="cpListaLABFAB_INFOVARSXDIA" runat="server" ShowLoadingPanel="false" Width="100%" >    
    <ClientSideEvents EndCallback="OnEndCallbackCP" /> 
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">  

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%" KeyFieldName="ID_INFOVARSXDIA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" ShowNewButtonInHeader="true" ButtonType="Image" VisibleIndex="0" Visible="False" Width="50px" Caption="x"  >
             <EditButton Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" >
                <Image ToolTip="Editar" IconID="edit_edit_16x16"></Image>
                            </EditButton>            
                            <UpdateButton Visible="False" Image-ToolTip="Guardar" Image-IconID="save_save_16x16" >
                <Image ToolTip="Guardar" IconID="save_save_16x16"></Image>
                            </UpdateButton>                     
                            <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" >
                <Image ToolTip="Cancelar" IconID="history_undo_16x16"></Image>
            </CancelButton>    
        </dx:GridViewCommandColumn>  
        <dx:GridViewDataTextColumn FieldName="ID_INFOVARSXDIA" ReadOnly="True" VisibleIndex="2" Caption="Id infovarsxdia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_INFO" VisibleIndex="3" Caption="Id info" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ID_INFOVAR" VisibleIndex="4" Caption="Id infovar" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ID_DIAZAFRA" VisibleIndex="5" Caption="Id diazafra" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="6" Caption="Id zafra" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="DIAZAFRA" VisibleIndex="7" Caption="Diazafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TIPOVAR" VisibleIndex="7" Caption="Tipo Variable" ReadOnly="true" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_VAR" VisibleIndex="8" Caption="Variable" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="VALOR" VisibleIndex="9" Caption="Valor" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="10" Caption="Usuario crea" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="11" Caption="Fecha crea" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="12" Caption="Usuario act" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="13" Caption="Fecha act" Visible="false"  />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="14">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

  </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel> 


<asp:ObjectDataSource ID="odsLABFAB_INFOVARSXDIACache" runat="server" TypeName="cLABFAB_INFOVARSXDIAcache" 
    InsertMethod="Agregar" SelectMethod="ObtenerLista" UpdateMethod="Actualizar" DeleteMethod="Eliminar" >       
     <SelectParameters>       
        <asp:Parameter Name="nombreSesion" Type="String" />
     </SelectParameters>
     <InsertParameters>
        <asp:Parameter Name="ID_INFOVARSXDIA" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_VAR" Type="String" />
        <asp:Parameter Name="VALOR" Type="Decimal" />       
        <asp:Parameter Name="REFERENCIA" Type="String" />  
     </InsertParameters>  
     <UpdateParameters>    
        <asp:Parameter Name="ID_INFOVARSXDIA" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_VAR" Type="String" />
        <asp:Parameter Name="VALOR" Type="Decimal" />       
        <asp:Parameter Name="REFERENCIA" Type="String" />          
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_VARXANALISIS" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>


<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarLABFAB_INFOVARSXDIA" DeleteMethod="EliminarLABFAB_INFOVARSXDIA" UpdateMethod="ActualizarLABFAB_INFOVARSXDIA"
    TypeName="SISPACAL.BL.cLABFAB_INFOVARSXDIA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFOVARSXDIA" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_VAR" Type="String" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFOVARSXDIA" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_VAR" Type="String" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFOVARSXDIA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_INFORME" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_INFORME" InsertMethod="AgregarLABFAB_INFOVARSXDIA" DeleteMethod="EliminarLABFAB_INFOVARSXDIA" UpdateMethod="ActualizarLABFAB_INFOVARSXDIA"
    TypeName="SISPACAL.BL.cLABFAB_INFOVARSXDIA">
    <SelectParameters>
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFOVARSXDIA" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_VAR" Type="String" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFOVARSXDIA" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_VAR" Type="String" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFOVARSXDIA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_DIAZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_DIAZAFRA" InsertMethod="AgregarLABFAB_INFOVARSXDIA" DeleteMethod="EliminarLABFAB_INFOVARSXDIA" UpdateMethod="ActualizarLABFAB_INFOVARSXDIA"
    TypeName="SISPACAL.BL.cLABFAB_INFOVARSXDIA">
    <SelectParameters>
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFOVARSXDIA" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_VAR" Type="String" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFOVARSXDIA" Type="Int32" />
        <asp:Parameter Name="ID_INFO" Type="Int32" />
        <asp:Parameter Name="ID_INFOVAR" Type="Int32" />
        <asp:Parameter Name="ID_DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
        <asp:Parameter Name="NOMBRE_VAR" Type="String" />
        <asp:Parameter Name="VALOR" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFOVARSXDIA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
