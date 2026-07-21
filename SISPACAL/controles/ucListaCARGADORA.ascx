<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCARGADORA.ascx.vb" Inherits="controles_ucListaCARGADORA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_CARGADORA" Width="100%">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0">                         
        </dx:GridViewCommandColumn>       
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colEditar" Visible="false" Width="50px" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_CARGADORA") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_CARGADORA") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TIPO_CARGADORA" VisibleIndex="2" Caption="Tipo" Width="60px" UnboundType="String" Visible="false" SortIndex="0" SortOrder="Ascending" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="ID_CARGADORA" VisibleIndex="2" Caption="Código" Width="40px" Visible="false" SortIndex="1" SortOrder="Ascending" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE" VisibleIndex="3" Width="300px" Caption="Descripción Cargadora"  Visible="false" Settings-AutoFilterCondition="Contains"/>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="4" Caption="Usuario crea"  Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="5" Caption="Fecha crea"  Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="6" Caption="Usuario act"  Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="7" Caption="Fecha act"  Visible="false"/>
        <dx:GridViewDataCheckColumn FieldName="ES_PROPIA" VisibleIndex="8" Caption="Es propia" Width="100px"   Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_CARGA" VisibleIndex="9" Caption="Id proveedor carga"  Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_CARGADORA" VisibleIndex="10" Caption="Id tipo cargadora"  Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="TARIFA_SIN_TRIPULACION" VisibleIndex="11" Caption="Tarifa sin tripulacion"  Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="TARIFA_CON_TRIPULACION" VisibleIndex="12" Caption="Tarifa con tripulacion"  Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="TARIFA_NORMAL" VisibleIndex="13" Caption="Tarifa a cobrar" Width="120px"   Visible="true">
            <PropertiesTextEdit DisplayFormatString="#,##0.00###" />
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="TARIFA_PAGAR_CARGADORA" VisibleIndex="13" Caption="Tarifa a pagar a cargadora/cosehadora" Width="100px"  Visible="true">
            <PropertiesTextEdit DisplayFormatString="#,##0.00###" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_ALZA" VisibleIndex="14" Caption="Id tipo alza"  Visible="false"/>
        <dx:GridViewDataCheckColumn FieldName="PRECALIFI_AUTO" VisibleIndex="14" Caption="Precalificada para autovolteo" Width="80px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" />
        <dx:GridViewDataCheckColumn FieldName="ACTIVO" VisibleIndex="14" Caption="Activo" Width="80px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Width="50px"  
            Name="Eliminar" VisibleIndex="15">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>      
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True" />    
</dx:ASPxGridView>
<dx:ASPxHiddenField runat="server" ClientInstanceName="hdfCARGADORA" ID="hdfCARGADORA" SyncWithServer="true"></dx:ASPxHiddenField>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCARGADORA" DeleteMethod="EliminarCARGADORA" UpdateMethod="ActualizarCARGADORA"
    TypeName="SISPACAL.BL.cCARGADORA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_PROPIA" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_CARGA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CARGADORA" Type="Int32" />
        <asp:Parameter Name="TARIFA_SIN_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CON_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_NORMAL" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_PROPIA" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_CARGA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CARGADORA" Type="Int32" />
        <asp:Parameter Name="TARIFA_SIN_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CON_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_NORMAL" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_CARGA" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_CARGA" InsertMethod="AgregarCARGADORA" DeleteMethod="EliminarCARGADORA" UpdateMethod="ActualizarCARGADORA"
    TypeName="SISPACAL.BL.cCARGADORA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_CARGA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_PROPIA" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_CARGA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CARGADORA" Type="Int32" />
        <asp:Parameter Name="TARIFA_SIN_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CON_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_NORMAL" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_PROPIA" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_CARGA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CARGADORA" Type="Int32" />
        <asp:Parameter Name="TARIFA_SIN_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CON_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_NORMAL" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_CARGADORA" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_CARGADORA" InsertMethod="AgregarCARGADORA" DeleteMethod="EliminarCARGADORA" UpdateMethod="ActualizarCARGADORA"
    TypeName="SISPACAL.BL.cCARGADORA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_CARGADORA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_PROPIA" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_CARGA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CARGADORA" Type="Int32" />
        <asp:Parameter Name="TARIFA_SIN_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CON_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_NORMAL" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_PROPIA" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_CARGA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CARGADORA" Type="Int32" />
        <asp:Parameter Name="TARIFA_SIN_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CON_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_NORMAL" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPOS_GENERALES" runat="server" 
    SelectMethod="ObtenerListaPorTIPOS_GENERALES" InsertMethod="AgregarCARGADORA" DeleteMethod="EliminarCARGADORA" UpdateMethod="ActualizarCARGADORA"
    TypeName="SISPACAL.BL.cCARGADORA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_PROPIA" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_CARGA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CARGADORA" Type="Int32" />
        <asp:Parameter Name="TARIFA_SIN_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CON_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_NORMAL" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_PROPIA" Type="Boolean" />
        <asp:Parameter Name="ID_PROVEEDOR_CARGA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_CARGADORA" Type="Int32" />
        <asp:Parameter Name="TARIFA_SIN_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_CON_TRIPULACION" Type="Decimal" />
        <asp:Parameter Name="TARIFA_NORMAL" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
