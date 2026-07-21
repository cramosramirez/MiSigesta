<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_APLICA_VUELO.ascx.vb" Inherits="controles_ucListaSOLIC_APLICA_VUELO" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_SOLIC_APLICA_VUELO">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_SOLIC_APLICA_VUELO") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_SOLIC_APLICA_VUELO") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_SOLIC_APLICA_VUELO" ReadOnly="True" VisibleIndex="2" Caption="Id solic aplica vuelo" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="3" Caption="Id solicitud" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEE" VisibleIndex="4" Caption="Id provee" />
        <dx:GridViewDataTextColumn FieldName="MEDIO_APLICA" VisibleIndex="5" Caption="Medio aplica" />
        <dx:GridViewDataTextColumn FieldName="DESCRIP_AERONAVE" VisibleIndex="6" Caption="Descrip aeronave" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PILOTO" VisibleIndex="7" Caption="Nombre piloto" />
        <dx:GridViewDataTextColumn FieldName="PRECIO_UNIT_VUELO" VisibleIndex="8" Caption="Precio unit vuelo" />
        <dx:GridViewDataTextColumn FieldName="MZ_HORAS_VUELO" VisibleIndex="9" Caption="Mz horas vuelo" />
        <dx:GridViewDataTextColumn FieldName="CARGO_VUELO" VisibleIndex="10" Caption="Cargo vuelo" />
        <dx:GridViewDataTextColumn FieldName="PRECIO_TOTAL_VUELO" VisibleIndex="11" Caption="Precio total vuelo" />
        <dx:GridViewDataTextColumn FieldName="PRECIO_UNIT_AGUA" VisibleIndex="12" Caption="Precio unit agua" />
        <dx:GridViewDataTextColumn FieldName="MZ_REGAR_AGUA" VisibleIndex="13" Caption="Mz regar agua" />
        <dx:GridViewDataTextColumn FieldName="PRECIO_TOTAL_AGUA" VisibleIndex="14" Caption="Precio total agua" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="15" Caption="Usuario crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="16" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="17" Caption="Usuario act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="18" Caption="Fecha act" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="19" Caption="Zafra" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="20">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_APLICA_VUELO" DeleteMethod="EliminarSOLIC_APLICA_VUELO" UpdateMethod="ActualizarSOLIC_APLICA_VUELO"
    TypeName="SISPACAL.BL.cSOLIC_APLICA_VUELO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_APLICA_VUELO" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="MEDIO_APLICA" Type="String" />
        <asp:Parameter Name="DESCRIP_AERONAVE" Type="String" />
        <asp:Parameter Name="NOMBRE_PILOTO" Type="String" />
        <asp:Parameter Name="PRECIO_UNIT_VUELO" Type="Decimal" />
        <asp:Parameter Name="MZ_HORAS_VUELO" Type="Decimal" />
        <asp:Parameter Name="CARGO_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNIT_AGUA" Type="Decimal" />
        <asp:Parameter Name="MZ_REGAR_AGUA" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_AGUA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_VUELO" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="MEDIO_APLICA" Type="String" />
        <asp:Parameter Name="DESCRIP_AERONAVE" Type="String" />
        <asp:Parameter Name="NOMBRE_PILOTO" Type="String" />
        <asp:Parameter Name="PRECIO_UNIT_VUELO" Type="Decimal" />
        <asp:Parameter Name="MZ_HORAS_VUELO" Type="Decimal" />
        <asp:Parameter Name="CARGO_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNIT_AGUA" Type="Decimal" />
        <asp:Parameter Name="MZ_REGAR_AGUA" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_AGUA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_VUELO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_AGRICOLA" InsertMethod="AgregarSOLIC_APLICA_VUELO" DeleteMethod="EliminarSOLIC_APLICA_VUELO" UpdateMethod="ActualizarSOLIC_APLICA_VUELO"
    TypeName="SISPACAL.BL.cSOLIC_APLICA_VUELO">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_APLICA_VUELO" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="MEDIO_APLICA" Type="String" />
        <asp:Parameter Name="DESCRIP_AERONAVE" Type="String" />
        <asp:Parameter Name="NOMBRE_PILOTO" Type="String" />
        <asp:Parameter Name="PRECIO_UNIT_VUELO" Type="Decimal" />
        <asp:Parameter Name="MZ_HORAS_VUELO" Type="Decimal" />
        <asp:Parameter Name="CARGO_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNIT_AGUA" Type="Decimal" />
        <asp:Parameter Name="MZ_REGAR_AGUA" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_AGUA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_VUELO" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="MEDIO_APLICA" Type="String" />
        <asp:Parameter Name="DESCRIP_AERONAVE" Type="String" />
        <asp:Parameter Name="NOMBRE_PILOTO" Type="String" />
        <asp:Parameter Name="PRECIO_UNIT_VUELO" Type="Decimal" />
        <asp:Parameter Name="MZ_HORAS_VUELO" Type="Decimal" />
        <asp:Parameter Name="CARGO_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNIT_AGUA" Type="Decimal" />
        <asp:Parameter Name="MZ_REGAR_AGUA" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_AGUA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_VUELO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AGRICOLA" InsertMethod="AgregarSOLIC_APLICA_VUELO" DeleteMethod="EliminarSOLIC_APLICA_VUELO" UpdateMethod="ActualizarSOLIC_APLICA_VUELO"
    TypeName="SISPACAL.BL.cSOLIC_APLICA_VUELO">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_APLICA_VUELO" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="MEDIO_APLICA" Type="String" />
        <asp:Parameter Name="DESCRIP_AERONAVE" Type="String" />
        <asp:Parameter Name="NOMBRE_PILOTO" Type="String" />
        <asp:Parameter Name="PRECIO_UNIT_VUELO" Type="Decimal" />
        <asp:Parameter Name="MZ_HORAS_VUELO" Type="Decimal" />
        <asp:Parameter Name="CARGO_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNIT_AGUA" Type="Decimal" />
        <asp:Parameter Name="MZ_REGAR_AGUA" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_AGUA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_VUELO" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="MEDIO_APLICA" Type="String" />
        <asp:Parameter Name="DESCRIP_AERONAVE" Type="String" />
        <asp:Parameter Name="NOMBRE_PILOTO" Type="String" />
        <asp:Parameter Name="PRECIO_UNIT_VUELO" Type="Decimal" />
        <asp:Parameter Name="MZ_HORAS_VUELO" Type="Decimal" />
        <asp:Parameter Name="CARGO_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_VUELO" Type="Decimal" />
        <asp:Parameter Name="PRECIO_UNIT_AGUA" Type="Decimal" />
        <asp:Parameter Name="MZ_REGAR_AGUA" Type="Decimal" />
        <asp:Parameter Name="PRECIO_TOTAL_AGUA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_APLICA_VUELO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
