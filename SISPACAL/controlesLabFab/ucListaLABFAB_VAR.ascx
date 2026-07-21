<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaLABFAB_VAR.ascx.vb" Inherits="controles_ucListaLABFAB_VAR" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<dx:ASPxCallbackPanel ID="cpListaLABFAB_VAR" ClientInstanceName="cpListaLABFAB_VAR" runat="server" ShowLoadingPanel="false" Width="100%" >    
    <ClientSideEvents EndCallback="OnEndCallbackCP" /> 
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">  
        
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%" Font-Names="Arial Narrow" Font-Size="Small" DataSourceID="odsLista" KeyFieldName="ID_VAR">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>      
    <Settings ShowTitlePanel="true" /> 
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar"
        Title="VARIABLES DE LA FORMULA DEL ANALISIS" />
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
        <dx:GridViewDataTextColumn FieldName="ID_VAR" ReadOnly="True" VisibleIndex="2" Caption="Id var" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ANALISIS" VisibleIndex="3" Caption="Id analisis" Visible="false" />
        <dx:GridViewDataComboBoxColumn FieldName="ID_TIPOVAR" VisibleIndex="4" Caption="Tipo de Variable" Width="230px" >
            <PropertiesComboBox DropDownStyle="DropDownList" DataSourceID="odsLABFAB_TIPOVAR" ValueField="ID_TIPOVAR" TextField="NOMBRE_TIPOVAR" ValueType="System.Int32" IncrementalFilteringMode="Contains" >            
            <Columns>                                
                <dx:ListBoxColumn Caption="Tipo" FieldName="NOMBRE_TIPOVAR" Width="500px" />
            </Columns>
            </PropertiesComboBox>      
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_VAR" VisibleIndex="5" Caption="Nombre Variable" Width="100px" >
            <Settings AllowAutoFilter = "False" />
            <EditItemTemplate>
                 <dx:ASPxLabel ID="lblNOMBRE_VAR" runat="server" Text='<%# Eval("NOMBRE_VAR") %>' ></dx:ASPxLabel>
            </EditItemTemplate> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="DESCRIP_VAR" VisibleIndex="6" Caption="Descripción" Width="400px" />
        <dx:GridViewDataComboBoxColumn FieldName="ID_ANALISIS_REF" VisibleIndex="7" Caption="Refiere al Análisis" Width="100px" >
            <PropertiesComboBox DropDownStyle="DropDownList" DataSourceID="odsLABFAB_ANALISIS" ValueField="ID_ANALISIS" TextField="NOMBRE_ANALISIS" ValueType="System.Int32" IncrementalFilteringMode="Contains" >            
            <Columns>                                
                <dx:ListBoxColumn Caption="Análisis" FieldName="NOMBRE_ANALISIS" Width="500px" />
            </Columns>
            </PropertiesComboBox>  
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataTextColumn FieldName="TABLA_REF" VisibleIndex="8" Caption="En función de Tabla" Width="100px" />
        <dx:GridViewDataTextColumn FieldName="COLUM1_REF" VisibleIndex="9" Caption="Columna 1 Ref." Width="100px" />
        <dx:GridViewDataTextColumn FieldName="COLUM2_REF" VisibleIndex="10" Caption="Columna 2 Ref." Width="100px" />
        <dx:GridViewDataTextColumn FieldName="COLUM_VALOR_REF" VisibleIndex="11" Caption="Columna Valor Ref." Width="100px" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="12" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="13" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="14" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="15" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="16" Visible="false" >
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
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

<asp:ObjectDataSource ID="odsLABFAB_TIPOVAR" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cLABFAB_TIPOVAR">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_TIPOVAR" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />                
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLABFAB_ANALISIS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorLABFAB_MUESTRA" 
    TypeName="SISPACAL.BL.cLABFAB_ANALISIS">
    <SelectParameters>
        <asp:SessionParameter SessionField="ID_MUESTRAsesion" Name="ID_MUESTRA" Type="Int32" />
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="false" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ANALISIS" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />      
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />          
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLABFAB_VARCache" runat="server" TypeName="cLABFAB_VARcache" 
    InsertMethod="Agregar" SelectMethod="ObtenerLista" UpdateMethod="Actualizar" DeleteMethod="Eliminar" >       
     <SelectParameters>       
        <asp:Parameter Name="nombreSesion" Type="String" />
     </SelectParameters>
     <InsertParameters>
        <asp:Parameter Name="ID_VAR" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="NOMBRE_VAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="TABLA_REF" Type="String" />
        <asp:Parameter Name="COLUM1_REF" Type="String" />
        <asp:Parameter Name="COLUM2_REF" Type="String" />
        <asp:Parameter Name="COLUM_VALOR_REF" Type="String" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
     </InsertParameters>  
     <UpdateParameters>    
        <asp:Parameter Name="ID_VAR" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="NOMBRE_VAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="TABLA_REF" Type="String" />
        <asp:Parameter Name="COLUM1_REF" Type="String" />
        <asp:Parameter Name="COLUM2_REF" Type="String" />
        <asp:Parameter Name="COLUM_VALOR_REF" Type="String" />
        <asp:Parameter Name="REFERENCIA" Type="String" />              
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_VAR" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarLABFAB_VAR" DeleteMethod="EliminarLABFAB_VAR" UpdateMethod="ActualizarLABFAB_VAR"
    TypeName="SISPACAL.BL.cLABFAB_VAR">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_VAR" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="COD_VAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="TABLA_REF" Type="String" />
        <asp:Parameter Name="COLUM1_REF" Type="String" />
        <asp:Parameter Name="COLUM2_REF" Type="String" />
        <asp:Parameter Name="COLUM_VALOR_REF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_VAR" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="COD_VAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="TABLA_REF" Type="String" />
        <asp:Parameter Name="COLUM1_REF" Type="String" />
        <asp:Parameter Name="COLUM2_REF" Type="String" />
        <asp:Parameter Name="COLUM_VALOR_REF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_VAR" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_ANALISIS" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_ANALISIS" InsertMethod="AgregarLABFAB_VAR" DeleteMethod="EliminarLABFAB_VAR" UpdateMethod="ActualizarLABFAB_VAR"
    TypeName="SISPACAL.BL.cLABFAB_VAR">
    <SelectParameters>
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_VAR" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="COD_VAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="TABLA_REF" Type="String" />
        <asp:Parameter Name="COLUM1_REF" Type="String" />
        <asp:Parameter Name="COLUM2_REF" Type="String" />
        <asp:Parameter Name="COLUM_VALOR_REF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_VAR" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="COD_VAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="TABLA_REF" Type="String" />
        <asp:Parameter Name="COLUM1_REF" Type="String" />
        <asp:Parameter Name="COLUM2_REF" Type="String" />
        <asp:Parameter Name="COLUM_VALOR_REF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_VAR" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLABFAB_TIPOVAR" runat="server" 
    SelectMethod="ObtenerListaPorLABFAB_TIPOVAR" InsertMethod="AgregarLABFAB_VAR" DeleteMethod="EliminarLABFAB_VAR" UpdateMethod="ActualizarLABFAB_VAR"
    TypeName="SISPACAL.BL.cLABFAB_VAR">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_VAR" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="COD_VAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="TABLA_REF" Type="String" />
        <asp:Parameter Name="COLUM1_REF" Type="String" />
        <asp:Parameter Name="COLUM2_REF" Type="String" />
        <asp:Parameter Name="COLUM_VALOR_REF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_VAR" Type="Int32" />
        <asp:Parameter Name="ID_ANALISIS" Type="Int32" />
        <asp:Parameter Name="ID_TIPOVAR" Type="Int32" />
        <asp:Parameter Name="COD_VAR" Type="String" />
        <asp:Parameter Name="DESCRIP_VAR" Type="String" />
        <asp:Parameter Name="ID_ANALISIS_REF" Type="Int32" />
        <asp:Parameter Name="TABLA_REF" Type="String" />
        <asp:Parameter Name="COLUM1_REF" Type="String" />
        <asp:Parameter Name="COLUM2_REF" Type="String" />
        <asp:Parameter Name="COLUM_VALOR_REF" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_VAR" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
