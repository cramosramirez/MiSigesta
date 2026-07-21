<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_QUEMANOPROG.ascx.vb" Inherits="controles_ucListaSOLIC_QUEMANOPROG" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleSOLIC_QUEMANOPROG.ascx" tagname="ucVistaDetalleSOLIC_QUEMANOPROG" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_SOLIC_QUEMANOPROG" Width="100%">
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
                    CommandArgument='<%# Bind("ID_SOLIC_QUEMANOPROG") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_SOLIC_QUEMANOPROG") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_SOLIC_QUEMANOPROG" ReadOnly="True" VisibleIndex="2" Caption="Id solic quemanoprog" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="4" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_SOLIC" VisibleIndex="5" Caption="Fecha Solicitud"  />
        <dx:GridViewDataTextColumn FieldName="NO_SOLICITUD" VisibleIndex="6" Caption="No Solicitud" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="7" Caption="Codiproveedor" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="7" Caption="Codigo" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODISOCIO" VisibleIndex="7" Caption="Socio"  UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBREPROVEEDOR" VisibleIndex="7" Caption="Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODILOTE" VisibleIndex="7" Caption="Codi Lote" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" VisibleIndex="7" Caption="Nombre Lote" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ZONA" VisibleIndex="8" Caption="Zona" />
        <dx:GridViewDataTextColumn FieldName="FECHA_HORA_QUEMA" VisibleIndex="9" Caption="Fecha Quema" />
        <dx:GridViewDataTextColumn FieldName="AREA" VisibleIndex="10" Caption="Area" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="TONEL" VisibleIndex="11" Caption="Tonel" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="TIPO_QUEMA" VisibleIndex="12" Caption="Tipo quema" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CODIVARIEDA" VisibleIndex="13" Caption="Codivarieda" Visible="false"  />
        <dx:GridViewDataCheckColumn FieldName="BRECHAS" VisibleIndex="14" Caption="Brechas" Visible="false"  />
        <dx:GridViewDataCheckColumn FieldName="RONDAS" VisibleIndex="15" Caption="Rondas" Visible="false"  />
        <dx:GridViewDataCheckColumn FieldName="VIGILANCIA" VisibleIndex="16" Caption="Vigilancia" Visible="false"  />
        <dx:GridViewDataCheckColumn FieldName="MADURANTE" VisibleIndex="17" Caption="Madurante" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_APLICA" VisibleIndex="18" Caption="Fecha aplica" Visible="false"  />
        <dx:GridViewDataCheckColumn FieldName="PRE_MUESTRA" VisibleIndex="19" Caption="Pre muestra" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_ROZA" VisibleIndex="20" Caption="Fecha roza" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_INI_VENTANA" VisibleIndex="21" Caption="Fecha ini ventana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_FIN_VENTANA" VisibleIndex="22" Caption="Fecha fin ventana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OBSERVACIONES" VisibleIndex="23" Caption="Observaciones" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CODIAGRON" VisibleIndex="24" Caption="Codiagron" Visible="false"  />
        <dx:GridViewDataCheckColumn FieldName="CON_DENUNCIA" VisibleIndex="25" Caption="Con denuncia" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="26" Caption="Zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="27" Caption="Usuario crea" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="28" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="29" Caption="Usuario act" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="30" Caption="Fecha act" Visible="false"  />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="31">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsCriterios" runat="server" SelectMethod="ObtenerLista" TypeName="SISPACAL.BL.cSOLIC_QUEMANOPROG">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODIPROVEE" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODISOCIO" Type="String" />
        <asp:Parameter DefaultValue="" Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="" Name="NOMBLOTE" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_QUEMANOPROG" DeleteMethod="EliminarSOLIC_QUEMANOPROG" UpdateMethod="ActualizarSOLIC_QUEMANOPROG"
    TypeName="SISPACAL.BL.cSOLIC_QUEMANOPROG">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="NO_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="TIPO_QUEMA" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="BRECHAS" Type="Boolean" />
        <asp:Parameter Name="RONDAS" Type="Boolean" />
        <asp:Parameter Name="VIGILANCIA" Type="Boolean" />
        <asp:Parameter Name="MADURANTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="PRE_MUESTRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_VENTANA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_VENTANA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CON_DENUNCIA" Type="Boolean" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="NO_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="TIPO_QUEMA" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="BRECHAS" Type="Boolean" />
        <asp:Parameter Name="RONDAS" Type="Boolean" />
        <asp:Parameter Name="VIGILANCIA" Type="Boolean" />
        <asp:Parameter Name="MADURANTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="PRE_MUESTRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_VENTANA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_VENTANA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CON_DENUNCIA" Type="Boolean" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarSOLIC_QUEMANOPROG" DeleteMethod="EliminarSOLIC_QUEMANOPROG" UpdateMethod="ActualizarSOLIC_QUEMANOPROG"
    TypeName="SISPACAL.BL.cSOLIC_QUEMANOPROG">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="NO_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="TIPO_QUEMA" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="BRECHAS" Type="Boolean" />
        <asp:Parameter Name="RONDAS" Type="Boolean" />
        <asp:Parameter Name="VIGILANCIA" Type="Boolean" />
        <asp:Parameter Name="MADURANTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="PRE_MUESTRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_VENTANA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_VENTANA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CON_DENUNCIA" Type="Boolean" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="NO_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="TIPO_QUEMA" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="BRECHAS" Type="Boolean" />
        <asp:Parameter Name="RONDAS" Type="Boolean" />
        <asp:Parameter Name="VIGILANCIA" Type="Boolean" />
        <asp:Parameter Name="MADURANTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="PRE_MUESTRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_VENTANA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_VENTANA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CON_DENUNCIA" Type="Boolean" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarSOLIC_QUEMANOPROG" DeleteMethod="EliminarSOLIC_QUEMANOPROG" UpdateMethod="ActualizarSOLIC_QUEMANOPROG"
    TypeName="SISPACAL.BL.cSOLIC_QUEMANOPROG">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="NO_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="TIPO_QUEMA" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="BRECHAS" Type="Boolean" />
        <asp:Parameter Name="RONDAS" Type="Boolean" />
        <asp:Parameter Name="VIGILANCIA" Type="Boolean" />
        <asp:Parameter Name="MADURANTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="PRE_MUESTRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_VENTANA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_VENTANA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CON_DENUNCIA" Type="Boolean" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="NO_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="TIPO_QUEMA" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="BRECHAS" Type="Boolean" />
        <asp:Parameter Name="RONDAS" Type="Boolean" />
        <asp:Parameter Name="VIGILANCIA" Type="Boolean" />
        <asp:Parameter Name="MADURANTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="PRE_MUESTRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_VENTANA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_VENTANA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CON_DENUNCIA" Type="Boolean" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarSOLIC_QUEMANOPROG" DeleteMethod="EliminarSOLIC_QUEMANOPROG" UpdateMethod="ActualizarSOLIC_QUEMANOPROG"
    TypeName="SISPACAL.BL.cSOLIC_QUEMANOPROG">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="NO_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="TIPO_QUEMA" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="BRECHAS" Type="Boolean" />
        <asp:Parameter Name="RONDAS" Type="Boolean" />
        <asp:Parameter Name="VIGILANCIA" Type="Boolean" />
        <asp:Parameter Name="MADURANTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="PRE_MUESTRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_VENTANA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_VENTANA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CON_DENUNCIA" Type="Boolean" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="NO_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="TIPO_QUEMA" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="BRECHAS" Type="Boolean" />
        <asp:Parameter Name="RONDAS" Type="Boolean" />
        <asp:Parameter Name="VIGILANCIA" Type="Boolean" />
        <asp:Parameter Name="MADURANTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="PRE_MUESTRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_VENTANA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_VENTANA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CON_DENUNCIA" Type="Boolean" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorVARIEDAD" runat="server" 
    SelectMethod="ObtenerListaPorVARIEDAD" InsertMethod="AgregarSOLIC_QUEMANOPROG" DeleteMethod="EliminarSOLIC_QUEMANOPROG" UpdateMethod="ActualizarSOLIC_QUEMANOPROG"
    TypeName="SISPACAL.BL.cSOLIC_QUEMANOPROG">
    <SelectParameters>
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="NO_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="TIPO_QUEMA" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="BRECHAS" Type="Boolean" />
        <asp:Parameter Name="RONDAS" Type="Boolean" />
        <asp:Parameter Name="VIGILANCIA" Type="Boolean" />
        <asp:Parameter Name="MADURANTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="PRE_MUESTRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_VENTANA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_VENTANA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CON_DENUNCIA" Type="Boolean" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="FECHA_SOLIC" Type="DateTime" />
        <asp:Parameter Name="NO_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="FECHA_HORA_QUEMA" Type="DateTime" />
        <asp:Parameter Name="AREA" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="TIPO_QUEMA" Type="String" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="BRECHAS" Type="Boolean" />
        <asp:Parameter Name="RONDAS" Type="Boolean" />
        <asp:Parameter Name="VIGILANCIA" Type="Boolean" />
        <asp:Parameter Name="MADURANTE" Type="Boolean" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="PRE_MUESTRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_ROZA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_VENTANA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_VENTANA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACIONES" Type="String" />
        <asp:Parameter Name="CODIAGRON" Type="String" />
        <asp:Parameter Name="CON_DENUNCIA" Type="Boolean" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_QUEMANOPROG" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
