<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantZONAS.ascx.vb" Inherits="controlesMaestro_ucMantZONAS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<table cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr><td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">Mantenimiento de Zonas y Sub-Zonas</asp:Label></td></tr>
</table>
<br />
<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" AutoGenerateColumns="False" Width="500px" 
         KeyFieldName="ZONA" DataSourceID="odsZonas">
            <Columns>
                <dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowEditButton="true" VisibleIndex="0"  Width="40px" ButtonType="Image" >
                   <NewButton Image-IconID="actions_new_16x16" Image-ToolTip="Nuevo"></NewButton>
                   <EditButton Image-IconID="edit_edit_16x16" Image-ToolTip="Editar"></EditButton>
                </dx:GridViewCommandColumn>                
                <dx:GridViewDataTextColumn FieldName="ZONA" Width="100px"  Caption="Código Zona" VisibleIndex="1" />
                <dx:GridViewDataTextColumn FieldName="DESCRIP_ZONA" Caption="Zona"  VisibleIndex="2" />                
                <dx:GridViewDataTextColumn FieldName="USER_CREA" Caption="Usuario creacion" Visible="false" VisibleIndex="3" />                
                <dx:GridViewDataDateColumn FieldName="FECHA_CREA" Caption="Fecha creacion" Visible="false" VisibleIndex="4" />                
                <dx:GridViewDataTextColumn FieldName="USER_ACT" Caption="Usuario Act." Visible="false" VisibleIndex="5" />                
                <dx:GridViewDataDateColumn FieldName="FECHA_ACT" Caption="Fecha Act." Visible="false" VisibleIndex="6" />                
                <dx:GridViewCommandColumn Caption=" " ShowDeleteButton="true" VisibleIndex="7"  Width="40px" ButtonType="Image" >                  
                   <DeleteButton Image-IconID="edit_delete_16x16" Image-ToolTip="Eliminar"></DeleteButton>
                </dx:GridViewCommandColumn>
            </Columns>
            <Settings ShowPreview="true" />
            <SettingsPager PageSize="10" />
            <Templates>
                <EditForm>
                    <dx:ASPxFormLayout ID="formLayout" runat="server">
                        <Items>
                            <dx:LayoutItem Caption="Código Zona" FieldName="ZONA">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                        <dx:ASPxTextBox ID="ASPxFormLayout1_E2" runat="server" Width="170px" Text='<%# Eval("ZONA") %>' MaxLength="2" />
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Zona" FieldName="DESCRIP_ZONA">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                        <dx:ASPxTextBox ID="ASPxFormLayout1_E3" runat="server" Width="170px" Text='<%# Eval("DESCRIP_ZONA") %>' MaxLength="30" />
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                           
                        </Items>
                    </dx:ASPxFormLayout>
                    <div style="text-align: right; padding: 2px">          
                        <dx:ASPxButton runat="server" ID="update" Image-IconID="save_save_16x16" ToolTip="Guardar"  AutoPostBack="false">
                            <ClientSideEvents Click="function(s, e){grid.UpdateEdit();}" />                       
                        </dx:ASPxButton>                        
                        <dx:ASPxButton runat="server" ID="cancel" Image-IconID="history_undo_16x16" ToolTip="Cancelar"  AutoPostBack="false">
                            <ClientSideEvents Click="function(s, e){grid.CancelEdit();}" />                       
                        </dx:ASPxButton>
                    </div>
                </EditForm>
                <DetailRow>
                <b>Listado de sub zonas de la zona: <%# Eval("DESCRIP_ZONA") %></b>
                <dx:ASPxGridView ID="grdSubZonas" ClientInstanceName="grdSubZonas" runat="server" DataSourceID="odsSubZonas" KeyFieldName="ZONA;SUB_ZONA"
                    Width="100%" OnRowInserting="gd_RowInserting" OnRowUpdating="gd_RowUpdating" OnBeforePerformDataSelect="gd_DataSelect" OnHtmlEditFormCreated="gd_HtmlEditFormCreated">
                    <Columns>
                        <dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowEditButton="true" VisibleIndex="0"  Width="40px" ButtonType="Image" >
                           <NewButton Image-IconID="actions_new_16x16" Image-ToolTip="Nuevo"></NewButton>
                           <EditButton Image-IconID="edit_edit_16x16" Image-ToolTip="Editar"></EditButton>
                        </dx:GridViewCommandColumn>                                                                                                                    
                        <dx:GridViewDataTextColumn FieldName="ZONA" Caption="Código Zona" VisibleIndex="2" />
                        <dx:GridViewDataTextColumn FieldName="SUB_ZONA" VisibleIndex="3" Caption="Código SubZona"  />
                        <dx:GridViewDataTextColumn FieldName="DESCRIP_SUB_ZONA" Caption="Nombre SubZona"  VisibleIndex="4" />
                        <dx:GridViewDataTextColumn FieldName="NO_SUB_ZONA" Visible="false" VisibleIndex="5"  />
                        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" Caption="Usuario creacion" Visible="false" VisibleIndex="6" />                
                        <dx:GridViewDataDateColumn FieldName="FECHA_CREA" Caption="Fecha creacion" Visible="false" VisibleIndex="7" />                
                        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" Caption="Usuario Act." Visible="false" VisibleIndex="8" />                
                        <dx:GridViewDataDateColumn FieldName="FECHA_ACT" Caption="Fecha Act." Visible="false" VisibleIndex="9" />    
                        <dx:GridViewCommandColumn  Caption=" " ShowDeleteButton="true" VisibleIndex="10"  Width="40px" ButtonType="Image" >                  
                           <DeleteButton Image-IconID="edit_delete_16x16" Image-ToolTip="Eliminar"></DeleteButton>
                        </dx:GridViewCommandColumn>
                    </Columns>
                    <Templates>
                        <EditForm>
                            <dx:ASPxFormLayout ID="gd_formLayout" runat="server" ColCount="2">
                                <Items>
                                    <dx:LayoutItem Caption="Código Zona" FieldName="ZONA">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                                <dx:ASPxTextBox ID="txtZONAdetalle" ClientEnabled="false" runat="server" Width="50px" MaxLength="2" />
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Código SubZona" FieldName="SUB_ZONA">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server" SupportsDisabledAttribute="True">
                                                <dx:ASPxTextBox ID="ASPxFormLayout1_E3" runat="server" Width="50px" Text='<%# Eval("SUB_ZONA") %>' MaxLength="2" />
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>                           
                                    <dx:LayoutItem Caption="Nombre SubZona" FieldName="DESCRIP_SUB_ZONA" ColSpan="2" >
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server" SupportsDisabledAttribute="True">
                                                <dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="100%" Text='<%# Eval("DESCRIP_SUB_ZONA") %>' MaxLength="100" />
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>     
                                </Items>
                            </dx:ASPxFormLayout>
                            <div style="text-align: right; padding: 2px">          
                                <dx:ASPxButton runat="server" ID="gd_update" Image-IconID="save_save_16x16" ToolTip="Guardar"  AutoPostBack="false">
                                    <ClientSideEvents Click="function(s, e){grdSubZonas.UpdateEdit();}" />                       
                                </dx:ASPxButton>                        
                                <dx:ASPxButton runat="server" ID="gd_cancel" Image-IconID="history_undo_16x16" ToolTip="Cancelar"  AutoPostBack="false">
                                    <ClientSideEvents Click="function(s, e){grdSubZonas.CancelEdit();}" />                       
                                </dx:ASPxButton>
                            </div>
                        </EditForm>
                    </Templates>
                    <Settings ShowFooter="True" />
                    <TotalSummary>
                        <dx:ASPxSummaryItem FieldName="SUB_ZONA" SummaryType="Count" />                        
                    </TotalSummary>
                </dx:ASPxGridView>
            </DetailRow>
            </Templates>
        <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
        <SettingsDetail ShowDetailRow="true" /> 
        </dx:ASPxGridView>    
<asp:ObjectDataSource ID="odsZonas" runat="server" DeleteMethod="EliminarZONAS" 
    InsertMethod="AgregarZONAS" SelectMethod="ObtenerLista" TypeName="SISPACAL.BL.cZONAS" 
    UpdateMethod="ActualizarZONAS">
    <DeleteParameters>
        <asp:Parameter Name="ZONA" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_ZONA" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_ZONA" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSubZonas" runat="server" DeleteMethod="EliminarSUB_ZONAS" 
    InsertMethod="AgregarSUB_ZONAS" SelectMethod="ObtenerLista" TypeName="SISPACAL.BL.cSUB_ZONAS" 
    UpdateMethod="ActualizarSUB_ZONAS">
    <DeleteParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_SUB_ZONA" Type="String" />
        <asp:Parameter Name="NO_SUB_ZONA" Type="Int32"  />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <SelectParameters>        
        <asp:SessionParameter Name="ZONA" SessionField="ZONA" Type="String" />
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="false" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="SUB_ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <UpdateParameters>    
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_SUB_ZONA" Type="String" />
        <asp:Parameter Name="NO_SUB_ZONA" Type="Int32"  />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
</asp:ObjectDataSource>
    