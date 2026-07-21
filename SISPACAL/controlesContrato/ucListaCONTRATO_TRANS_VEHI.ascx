<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTRATO_TRANS_VEHI.ascx.vb" Inherits="controles_ucListaCONTRATO_TRANS_VEHI" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="ID_CONTRA_TRANS_VEHI">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>        
        <dx:GridViewCommandColumn Name="Edicion" ButtonType="Image" VisibleIndex="0" Visible="False" Width="50px" Caption=" "  >             
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
        <dx:GridViewDataCheckColumn FieldName="ES_CONTRATADO" VisibleIndex="2" Caption="Contratado" Width="80px"  />
        <dx:GridViewDataTextColumn FieldName="ID_CONTRA_TRANS_VEHI" ReadOnly="True" VisibleIndex="2" Caption="Id contra trans vehi" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CONTRA_TRANS" VisibleIndex="3" Caption="Id contra trans" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TRANSPORTE" VisibleIndex="4" Caption="Id transporte" Visible="false" />        
        <dx:GridViewDataComboBoxColumn FieldName="ID_TIPOTRANS" VisibleIndex="5" Caption="Tipo Transporte" Width="260px" >
            <Settings AllowAutoFilter = "False" />
            <PropertiesComboBox DropDownStyle="DropDownList" DataSourceID="odsTipoTransporte" ValueField="ID_TIPOTRANS" TextField="NOMBRE" ValueType="System.Int32"  IncrementalFilteringMode="Contains" >           
            </PropertiesComboBox> 
        </dx:GridViewDataComboBoxColumn>                
        <dx:GridViewDataSpinEditColumn FieldName="CAPACIDAD" VisibleIndex="5" Caption="Capacidad" Width="120px" >
            <PropertiesSpinEdit ClientInstanceName="speCAPACIDAD" DecimalPlaces="2" DisplayFormatString="#,##0.00" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>    
            <HeaderStyle HorizontalAlign="Right"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>    
        <dx:GridViewDataTextColumn FieldName="PLACA" VisibleIndex="5" Caption="Placa" ReadOnly="True" />
        <dx:GridViewDataTextColumn FieldName="REMOLQUE" VisibleIndex="6" Caption="Remolque" />
        <dx:GridViewDataTextColumn FieldName="MARCA" VisibleIndex="9" Caption="Marca" Width="120px" />
        <dx:GridViewDataTextColumn FieldName="ANIO" VisibleIndex="9" Caption="Año" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="10" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="11" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="12" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="13" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " Visible="false" Name="Eliminar" VisibleIndex="14">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsCONTRATO_TRANS_VEHIcache" runat="server" TypeName="cCONTRATO_TRANS_VEHIcache"     
    SelectMethod="ObtenerLista" UpdateMethod="Actualizar" DeleteMethod="Eliminar">       
     <SelectParameters>             
        <asp:Parameter Name="nombreSesion_ucListaCONTRATO_TRANS_VEHI" Type="String" />
     </SelectParameters>     
     <UpdateParameters>    
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="MARCA" Type="String" />
        <asp:Parameter Name="ANIO" Type="String" />
        <asp:Parameter Name="ES_CONTRATADO" Type="Boolean" />
        <asp:Parameter Name="REFERENCIA" Type="String" />                   
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTRATO_TRANS_VEHI" DeleteMethod="EliminarCONTRATO_TRANS_VEHI" UpdateMethod="ActualizarCONTRATO_TRANS_VEHI"
    TypeName="SISPACAL.BL.cCONTRATO_TRANS_VEHI">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="MARCA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="MARCA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO_TRANS" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO_TRANS" InsertMethod="AgregarCONTRATO_TRANS_VEHI" DeleteMethod="EliminarCONTRATO_TRANS_VEHI" UpdateMethod="ActualizarCONTRATO_TRANS_VEHI"
    TypeName="SISPACAL.BL.cCONTRATO_TRANS_VEHI">
    <SelectParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="MARCA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="MARCA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTRANSPORTE" runat="server" 
    SelectMethod="ObtenerListaPorTRANSPORTE" InsertMethod="AgregarCONTRATO_TRANS_VEHI" DeleteMethod="EliminarCONTRATO_TRANS_VEHI" UpdateMethod="ActualizarCONTRATO_TRANS_VEHI"
    TypeName="SISPACAL.BL.cCONTRATO_TRANS_VEHI">
    <SelectParameters>
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="MARCA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRA_TRANS" Type="Int32" />
        <asp:Parameter Name="ID_TRANSPORTE" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="REMOLQUE" Type="String" />
        <asp:Parameter Name="PLACA" Type="String" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="MARCA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRA_TRANS_VEHI" Type="Int32" />
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