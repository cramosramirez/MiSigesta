<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaAGRONOMO.ascx.vb" Inherits="controles_ucListaAGRONOMO" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleAGRONOMO.ascx" tagname="ucVistaDetalleAGRONOMO" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="CODIAGRON" Width="100%" Font-Size="X-Small" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Visible="false" Caption=" " Name="colEditar" VisibleIndex="0" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEditar" Image-IconID="edit_edit_16x16" Image-ToolTip="Editar">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>       
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="true">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("CODIAGRON") %>'></asp:ImageButton>                
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("CODIAGRON") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODIAGRON" ReadOnly="True" VisibleIndex="2" Caption="Codigo" />
        <dx:GridViewDataTextColumn FieldName="APELLIDO_AGRONOMO" VisibleIndex="3" Caption="Apellidos" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_AGRONOMO" VisibleIndex="4" Caption="Nombres" />
        <dx:GridViewDataTextColumn FieldName="TELEF_AGRONOMO" VisibleIndex="5" Caption="Telefono" />
        <dx:GridViewDataTextColumn FieldName="ZONA" VisibleIndex="6" Caption="Zona" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ESTADO_AGRONOMO" VisibleIndex="7" Caption="Estado agronomo"  Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="ESTADO" VisibleIndex="7" UnboundType="Boolean" Caption="Activo" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="8" Caption="Ususario Crea" Visible="false"   />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="9" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="10" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="11" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_SIGESTA" VisibleIndex="12" Caption="Usuario SIGESTA"  />
        <dx:GridViewDataCheckColumn FieldName="VER_CONTRATO" VisibleIndex="12" UnboundType="Boolean" Caption="Ver en Contrato" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="37">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsPager PageSize="20" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True" />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarAGRONOMO" DeleteMethod="EliminarAGRONOMO" UpdateMethod="ActualizarAGRONOMO"
    TypeName="SISPACAL.BL.cAGRONOMO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="APELLIDO_AGRONOMO" Type="String" />
        <asp:Parameter Name="NOMBRE_AGRONOMO" Type="String" />
        <asp:Parameter Name="TELEF_AGRONOMO" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="ESTADO_AGRONOMO" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="USUARIO_SIGESTA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="APELLIDO_AGRONOMO" Type="String" />
        <asp:Parameter Name="NOMBRE_AGRONOMO" Type="String" />
        <asp:Parameter Name="TELEF_AGRONOMO" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="ESTADO_AGRONOMO" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="USUARIO_SIGESTA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIAGRON" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZONAS" runat="server" 
    SelectMethod="ObtenerListaPorZONAS" InsertMethod="AgregarAGRONOMO" DeleteMethod="EliminarAGRONOMO" UpdateMethod="ActualizarAGRONOMO"
    TypeName="SISPACAL.BL.cAGRONOMO">
    <SelectParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="APELLIDO_AGRONOMO" Type="String" />
        <asp:Parameter Name="NOMBRE_AGRONOMO" Type="String" />
        <asp:Parameter Name="TELEF_AGRONOMO" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="ESTADO_AGRONOMO" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="USUARIO_SIGESTA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="APELLIDO_AGRONOMO" Type="String" />
        <asp:Parameter Name="NOMBRE_AGRONOMO" Type="String" />
        <asp:Parameter Name="TELEF_AGRONOMO" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="ESTADO_AGRONOMO" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="USUARIO_SIGESTA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIAGRON" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorUSUARIO" runat="server" 
    SelectMethod="ObtenerListaPorUSUARIO" InsertMethod="AgregarAGRONOMO" DeleteMethod="EliminarAGRONOMO" UpdateMethod="ActualizarAGRONOMO"
    TypeName="SISPACAL.BL.cAGRONOMO">
    <SelectParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="APELLIDO_AGRONOMO" Type="String" />
        <asp:Parameter Name="NOMBRE_AGRONOMO" Type="String" />
        <asp:Parameter Name="TELEF_AGRONOMO" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="ESTADO_AGRONOMO" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="USUARIO_SIGESTA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="APELLIDO_AGRONOMO" Type="String" />
        <asp:Parameter Name="NOMBRE_AGRONOMO" Type="String" />
        <asp:Parameter Name="TELEF_AGRONOMO" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="ESTADO_AGRONOMO" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="USUARIO_SIGESTA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIAGRON" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
