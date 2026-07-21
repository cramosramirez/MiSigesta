<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaTRANSPORTE.ascx.vb" Inherits="controles_ucListaTRANSPORTE" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" Theme="Office2003Blue" AutoGenerateColumns="False" KeyFieldName="ID_TRANSPORTE">
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
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0">                         
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn FieldName="ID_TRANSPORTE" ReadOnly="True" VisibleIndex="2" Caption="Id Transporte" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" Width="70px" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CODTRANSPORT" VisibleIndex="3" Caption="Cod. Transportista" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center"  Width="70px" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TRANSPORTISTA" VisibleIndex="3" Caption="Transportista" UnboundType="String" Settings-AutoFilterCondition="Contains" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="PLACA" VisibleIndex="3" Caption="Placa" Width="160px"  />
        <dx:GridViewDataTextColumn FieldName="TIPOTRANS" VisibleIndex="3" Caption="Tipo Transporte" UnboundType="String" Width="270px" Visible="false"  />        
        <dx:GridViewDataTextColumn FieldName="ID_TIPOTRANS" VisibleIndex="5" Caption="Id tipotrans" Visible="false" />
        <dx:GridViewDataComboBoxColumn FieldName="ID_TIPOTRANS" VisibleIndex="3" Caption="Tipo Transporte" Width="260px" >
            <Settings AllowAutoFilter = "False" />
            <PropertiesComboBox DropDownStyle="DropDownList" DataSourceID="odsTipoTransporte" ValueField="ID_TIPOTRANS" TextField="NOMBRE" ValueType="System.Int32"  IncrementalFilteringMode="Contains" >           
            </PropertiesComboBox> 
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataTextColumn FieldName="REMOLQUE" VisibleIndex="6" Caption="Remolque" Width="160px" />
        <dx:GridViewDataTextColumn FieldName="MARCA" VisibleIndex="6" Caption="Marca" Width="210px" />        
        <dx:GridViewDataSpinEditColumn FieldName="CAPACIDAD" VisibleIndex="6" Caption="Capacidad" Width="150px" >
            <PropertiesSpinEdit ClientInstanceName="speCAPACIDAD" DecimalPlaces="2" DisplayFormatString="#,##0.00" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>    
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>     
        <dx:GridViewDataTextColumn FieldName="ANIO" VisibleIndex="6" Caption="Año" Width="100px" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="7" Caption="Usuario crea" Visible="false"   />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="8" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="9" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="10" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="11" Width="20px" >
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>


<asp:ObjectDataSource ID="odsTRANSPORTEcache" runat="server" TypeName="cTRANSPORTEcache"     
    SelectMethod="ObtenerLista" UpdateMethod="Actualizar" DeleteMethod="Eliminar">       
     <SelectParameters>             
        <asp:Parameter Name="nombreSesion_ucListaTRANSPORTE" Type="String" />
     </SelectParameters>     
     <UpdateParameters>    
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />        
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />        
        <asp:Parameter Name="PLACA" Type="String" /> 
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" /> 
        <asp:Parameter Name="REMOLQUE" Type="String" />   
        <asp:Parameter Name="MARCA" Type="String" /> 
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="REFERENCIA" Type="String" />                   
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarTRANSPORTE" DeleteMethod="EliminarTRANSPORTE" UpdateMethod="ActualizarTRANSPORTE"
    TypeName="SISPACAL.BL.cTRANSPORTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTRANSPORTISTA" runat="server" 
    SelectMethod="ObtenerListaPorTRANSPORTISTA" InsertMethod="AgregarTRANSPORTE" DeleteMethod="EliminarTRANSPORTE" UpdateMethod="ActualizarTRANSPORTE"
    TypeName="SISPACAL.BL.cTRANSPORTE">
    <SelectParameters>
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_TRANSPORTE" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_TRANSPORTE" InsertMethod="AgregarTRANSPORTE" DeleteMethod="EliminarTRANSPORTE" UpdateMethod="ActualizarTRANSPORTE"
    TypeName="SISPACAL.BL.cTRANSPORTE">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTipoTransporte" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPO_TRANSPORTE">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />      
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
