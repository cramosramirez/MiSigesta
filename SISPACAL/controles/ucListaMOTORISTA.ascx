<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaMOTORISTA.ascx.vb" Inherits="controles_ucListaMOTORISTA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%" KeyFieldName="ID_MOTORISTA">
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
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="Edicion"  Visible="true">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_MOTORISTA") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_MOTORISTA") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_MOTORISTA" ReadOnly="True" VisibleIndex="2" Caption="ID Motorista" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" Width="70px"  />        
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="3" Caption="Nombres" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="4" Caption="Apellidos" Settings-AutoFilterCondition="Contains" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="5" Caption="Nit" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="6" Caption="Dui" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="7" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="8" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="9" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="10" Caption="Fecha act" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="LICENCIA" VisibleIndex="11" Caption="Licencia" />
        <dx:GridViewDataCheckColumn FieldName="ACTIVO" VisibleIndex="12" Caption="Activo" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="13">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
       <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsListaPorTransporte" runat="server" 
    SelectMethod="ObtenerListaPorTRANSPORTE" TypeName="SISPACAL.BL.cMOTORISTA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_TRANSPORTE" Type="Int32"  />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarMOTORISTA" DeleteMethod="EliminarMOTORISTA" UpdateMethod="ActualizarMOTORISTA"
    TypeName="SISPACAL.BL.cMOTORISTA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="LICENCIA" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="LICENCIA" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_MOTORISTA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
