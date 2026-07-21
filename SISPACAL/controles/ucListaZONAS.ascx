<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaZONAS.ascx.vb" Inherits="controles_ucListaZONAS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ZONA" Width="100%">
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
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colEditar" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_LOTES_COSECHA") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ZONA") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>  
        <dx:GridViewDataTextColumn FieldName="ZONA" ReadOnly="True" VisibleIndex="2" Caption="Zona" />
        <dx:GridViewDataTextColumn FieldName="DESCRIP_ZONA" VisibleIndex="3" Caption="Zona" />
        <dx:GridViewDataTextColumn FieldName="USER_CREA" VisibleIndex="4" Caption="User crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="5" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USER_ACT" VisibleIndex="6" Caption="User act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="7" Caption="Fecha act" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="9">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True" />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarZONAS" DeleteMethod="EliminarZONAS" UpdateMethod="ActualizarZONAS"
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_ZONA" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_ZONA" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ZONA" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaZONAS_ACTIVAS" runat="server" 
    SelectMethod="ObtenerListaZONAS_ACTIVAS" InsertMethod="AgregarZONAS" DeleteMethod="EliminarZONAS" UpdateMethod="ActualizarZONAS"
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>        
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_ZONA" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="DESCRIP_ZONA" Type="String" />
        <asp:Parameter Name="USER_CREA" Type="Int32" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USER_ACT" Type="Int32" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ZONA" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
