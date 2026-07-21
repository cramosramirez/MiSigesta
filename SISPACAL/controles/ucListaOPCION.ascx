<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaOPCION.ascx.vb" Inherits="controles_ucListaOPCION" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleOPCION.ascx" tagname="ucVistaDetalleOPCION" tagprefix="uc1" %>
<%@ Register assembly="DevExpress.Web.ASPxTreeList.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTreeList" tagprefix="dx" %>

<center style="margin-left: 40px">
<dx:ASPxTreeList ID="trlOpcion" Theme="Office2003Blue" ClientInstanceName="tree" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_OPCION" ParentFieldName="ID_OPCION_PADRE" Width="85%" >    
    <ClientSideEvents CustomButtonClick="function(s,e){     
                                                    if(e.buttonID=='btnEliminar'){
                                                        s.PerformCallback('btnEliminar;' + e.nodeKey.toString());                                                        
                                                    }
                                                    if(e.buttonID=='btnSubir'){
                                                        s.PerformCallback('btnSubir;' + e.nodeKey.toString());                                                        
                                                    }  
                                                    if(e.buttonID=='btnBajar'){
                                                        s.PerformCallback('btnBajar;' + e.nodeKey.toString());                                                        
                                                    } 
                                                }"
                      EndCallback="function(s, e){if(s.cpMensaje != null){ AsignarMensaje(s.cpMensaje); delete s.cpMensaje;}}"  />
    <SettingsBehavior ExpandCollapseAction="NodeDblClick" AllowSort="true" AllowFocusedNode="true" />
    <SettingsEditing Mode="EditForm" AllowNodeDragDrop="true" />
    <SettingsPopupEditForm Width="400" />      
    <Settings ScrollableHeight="430" GridLines="Vertical" HorizontalScrollBarMode="Hidden" VerticalScrollBarMode="Auto" />     
    <SettingsPager Mode="ShowPager" PageSize="80" >
         <PageSizeItemSettings Items="80, 100, 150, 200" Visible="true" Caption="Registros" />
    </SettingsPager>     
    <Columns>        
        <dx:TreeListTextColumn FieldName="ID_OPCION" VisibleIndex="0" ReadOnly="true" Visible="false" >            
        </dx:TreeListTextColumn>
        <dx:TreeListTextColumn FieldName="NOMBRE_OPCION" Caption="Opción" VisibleIndex="1"  >             
            <EditFormSettings VisibleIndex="0" />          
        </dx:TreeListTextColumn>
        <dx:TreeListTextColumn FieldName="ORDEN" Caption="Orden" ShowInCustomizationForm="true" Visible="false" SortIndex="0" SortOrder="Ascending" >                       
        </dx:TreeListTextColumn>
        <dx:TreeListTextColumn FieldName="URL" VisibleIndex="3" Caption="URL"  >  
            <EditFormSettings VisibleIndex="2" />          
        </dx:TreeListTextColumn>
        <dx:TreeListCheckColumn FieldName="ACTIVO" Width="60px" VisibleIndex="4" Caption="Activo"  >  
            <EditFormSettings VisibleIndex="3" />          
            <HeaderStyle HorizontalAlign="Center" /> 
        </dx:TreeListCheckColumn>
        <dx:TreeListTextColumn FieldName="USUARIO_CREA" VisibleIndex="5" Visible="false" />  
        <dx:TreeListTextColumn FieldName="FECHA_CREA" VisibleIndex="6" Visible="false" />  
        <dx:TreeListTextColumn FieldName="USUARIO_ACT" VisibleIndex="7" Visible="false" />  
        <dx:TreeListTextColumn FieldName="FECHA_ACT" VisibleIndex="8" Visible="false" />  
        <dx:TreeListCommandColumn Width="30px" ButtonType="Image" Caption=" " Name="colSubir" VisibleIndex="9" >
            <CustomButtons>            
                <dx:TreeListCommandColumnCustomButton ID="btnSubir" Image-ToolTip="Subir" Image-IconID="arrows_moveup_16x16" />                              
            </CustomButtons>
            <HeaderStyle HorizontalAlign="Center" /> 
            <CellStyle HorizontalAlign="Center" />     
        </dx:TreeListCommandColumn>
        <dx:TreeListCommandColumn Width="30px" ButtonType="Image" Caption=" " Name="colBajar" VisibleIndex="9" >
            <CustomButtons>            
                <dx:TreeListCommandColumnCustomButton ID="btnBajar" Image-ToolTip="Bajar" Image-IconID="arrows_movedown_16x16" />                              
            </CustomButtons>
            <HeaderStyle HorizontalAlign="Center" /> 
            <CellStyle HorizontalAlign="Center" />     
        </dx:TreeListCommandColumn>
        <dx:TreeListCommandColumn Width="30px" ButtonType="Image" VisibleIndex="9" Name="colAgregar" Caption=" " ShowNewButtonInHeader="true" >             
            <NewButton Visible="true" Image-IconID="actions_new_16x16" Image-ToolTip="Nuevo" Text="" /> 
            <UpdateButton Image-IconID="save_save_16x16" Image-ToolTip="Guardar" />  
            <CancelButton Image-IconID="history_undo_16x16" Image-ToolTip="Cancelar" />  
            <HeaderStyle HorizontalAlign="Center" /> 
            <CellStyle HorizontalAlign="Center" >               
            </CellStyle>  
        </dx:TreeListCommandColumn>
        <dx:TreeListCommandColumn Width="30px" ButtonType="Image" Caption=" " VisibleIndex="10" Name="colEditar" >                                 
            <EditButton Visible="true" Image-IconID="edit_edit_16x16" Image-ToolTip="Editar" />          
            <UpdateButton Image-IconID="save_save_16x16" Image-ToolTip="Guardar" />  
            <CancelButton Image-IconID="history_undo_16x16" Image-ToolTip="Cancelar" />  
            <HeaderStyle HorizontalAlign="Center" /> 
            <CellStyle HorizontalAlign="Center" >               
            </CellStyle>  
        </dx:TreeListCommandColumn>               
        <dx:TreeListCommandColumn Width="30px" ButtonType="Image" Caption=" " Name="colEliminar" VisibleIndex="11" >
            <CustomButtons>            
                <dx:TreeListCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16" />                              
            </CustomButtons>
            <HeaderStyle HorizontalAlign="Center" /> 
            <CellStyle HorizontalAlign="Center" />     
        </dx:TreeListCommandColumn>
        <dx:TreeListCommandColumn Width="50px" Caption=" " Name="colVacia" VisibleIndex="12" >
        </dx:TreeListCommandColumn>
    </Columns>
    <Styles>
      <AlternatingNode Enabled="false" />
    </Styles>
</dx:ASPxTreeList>
<asp:ObjectDataSource ID="odsLista" runat="server"  
    SelectMethod="ObtenerLista" InsertMethod="AgregarOPCION" DeleteMethod="EliminarOPCION" UpdateMethod="ActualizarOPCION"
    TypeName="SISPACAL.BL.cOPCION">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="RecuperarOcultas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="ORDEN" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_OPCION" Type="Int32" />
        <asp:Parameter Name="NOMBRE_OPCION" Type="String" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="URL" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
        <asp:Parameter Name="ID_OPCION_PADRE" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_OPCION" Type="Int32" />
        <asp:Parameter Name="NOMBRE_OPCION" Type="String" />
        <asp:Parameter Name="ORDEN" Type="Int32" />
        <asp:Parameter Name="URL" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
        <asp:Parameter Name="ID_OPCION_PADRE" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_OPCION" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
</center>