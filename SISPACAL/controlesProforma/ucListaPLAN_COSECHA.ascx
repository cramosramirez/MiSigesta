<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPLAN_COSECHA.ascx.vb" Inherits="controles_ucListaPLAN_COSECHA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_PLAN_COSECHA" Width="100%" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents EndCallback="function(s, e){if(s.cpMensaje != null){ AsignarMensaje(s.cpMensaje); delete s.cpMensaje;}}"
         RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0" />        
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>          
         <dx:GridViewDataTextColumn VisibleIndex="1" Name="colEditar" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_PLAN_COSECHA") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_PLAN_COSECHA") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>

         <dx:GridViewDataTextColumn VisibleIndex="1" Name="colVistaControlQuema" Width="40px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnControlQuema" runat="server" AlternateText="Control de inventario de Quema" ToolTip="Control de inventario de Quema" CommandName="ControlQuema" ImageUrl="~/imagenes/fire.png"  CommandArgument='<%# Bind("ID_PLAN_COSECHA") %>'></asp:ImageButton>                               
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colVistaControlRoza" Width="40px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnControlRoza" runat="server" AlternateText="Control de inventario de Roza" ToolTip="Control de inventario de Roza" CommandName="ControlRoza" ImageUrl="~/imagenes/roza.png"  CommandArgument='<%# Bind("ID_PLAN_COSECHA") %>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colVistaControlModificacionQuema" Width="40px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnControlModiQuema" runat="server" AlternateText="Modificación de Quema en Roza" ToolTip="Modificación de Quema en Roza" CommandName="ControlModiQuema" ImageUrl="~/imagenes/firemodi.png"  CommandArgument='<%# Bind("ID_PLAN_COSECHA") %>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colEmitirProforma" Width="40px" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEmitirProforma" runat="server" AlternateText="Emitir Proforma de Envío" ToolTip="Emitir Proforma de Envío" CommandName="EmitirProforma" ImageUrl="~/imagenes/proforma.png"  CommandArgument='<%# Bind("ID_PLAN_COSECHA") %>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn FieldName="ZONA" VisibleIndex="2" Caption="Zona" Width="50px" SortIndex="1" SortOrder="Ascending" UnboundType="String" Visible="false" />       
        <dx:GridViewDataTextColumn FieldName="ID_PLAN_COSECHA" ReadOnly="True" VisibleIndex="2" Caption="Id plan cosecha" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="4" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CATORCENA" VisibleIndex="4" Caption="Catorcena" CellStyle-HorizontalAlign="Right" />                    
        <dx:GridViewDataTextColumn FieldName="SEMANA" VisibleIndex="4" Caption="Semana" CellStyle-HorizontalAlign="Right" />                    
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="4" Caption="Codi provee" UnboundType="String" Width="70px" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="CODISOCIO" VisibleIndex="4" Caption="Codi Socio" UnboundType="String" Width="70px" CellStyle-HorizontalAlign="Right" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="4" Caption="Proveedor" SortIndex="2" SortOrder="Ascending" Width="300px" UnboundType="String" Settings-AutoFilterCondition="Contains"  />
        <dx:GridViewDataTextColumn FieldName="CODILOTE" VisibleIndex="4" Caption="Codi. Lote" Width="70px" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" VisibleIndex="4" Caption="Lote" Width="200px" UnboundType="String" Settings-AutoFilterCondition="Contains"  />
        <dx:GridViewDataTextColumn FieldName="MZ_SALDO" VisibleIndex="5" Caption="ha Saldo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TONEL_SALDO" VisibleIndex="6" Caption="t Saldo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MZ_COSECHA" VisibleIndex="7" Caption="ha Cosechar" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TONEL_MZ_COSECHA" VisibleIndex="8" Caption="TCH Cosecha" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TONEL_COSECHA" VisibleIndex="9" Caption="t a Cosechar" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CUOTA_DIARIA" VisibleIndex="10" Caption="Cuota diaria" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INI_COSECHA" VisibleIndex="11" Caption="Fecha Inicio" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy" CellStyle-HorizontalAlign="Center" />
        <dx:GridViewDataTextColumn FieldName="FECHA_FIN_COSECHA" VisibleIndex="12" Caption="Fecha Fin" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy" CellStyle-HorizontalAlign="Center" />        
        <dx:GridViewDataTextColumn FieldName="TOTAL_SEMANA" VisibleIndex="13" Caption="Total (t) Semana" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="SALDO_QUEMA" VisibleIndex="13" Caption="Saldo de Quema" UnboundType="Decimal" Visible="false" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SALDO_ROZA" VisibleIndex="13" Caption="Saldo de Roza" UnboundType="Decimal" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataCheckColumn FieldName="QUEMA_PROGRAMADA" VisibleIndex="14" Caption="Quema Prog." Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="QUEMA_NO_PROGRAMADA" VisibleIndex="15" Caption="Quema No Prog." Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_CANA" VisibleIndex="16" Caption="Id tipo cana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_ROZA" VisibleIndex="17" Caption="Id tipo roza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_ALZA" VisibleIndex="18" Caption="Id tipo alza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CARGADORA" VisibleIndex="19" Caption="Id cargadora" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CARGADOR" VisibleIndex="20" Caption="Id cargador" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPOTRANS" VisibleIndex="21" Caption="Id tipotrans" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="TRANSPORTE_PROPIO" VisibleIndex="22" Caption="Transporte propio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="23" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="24" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="25" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="26" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="27">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>       
	   </Columns>   
    <GroupSummary>
        <dx:ASPxSummaryItem FieldName="ACCESLOTE" DisplayFormat="Cant. Lotes.:{0:#,###,##0}" SummaryType="Count" />
        <dx:ASPxSummaryItem FieldName="MZ_COSECHA" DisplayFormat="Total ha.:{0:#,###,##0.00}" SummaryType="Sum" />
        <dx:ASPxSummaryItem FieldName="TONEL_COSECHA" DisplayFormat="Total t.:{0:#,###,##0.00}" SummaryType="Sum" />        
    </GroupSummary>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" TypeName="SISPACAL.BL.cPLAN_COSECHA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CATORCENA" Type="Int32"  />
        <asp:Parameter Name="SEMANA" Type="Int32" />
        <asp:Parameter Name="FECHA_INI" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="-1" Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="CODIAGRON" Type="String" />        
        <asp:Parameter Name="TIPOS_TRANSPORTE" Type="String" />   
        <asp:Parameter Name="CON_SALDO_ROZA" Type="Boolean" />   
        <asp:Parameter Name="FIN_LOTE" Type="Int32" />   
        <asp:Parameter Name="CON_CUOTA_DIARIA" Type="Boolean" />  
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaParaProforma" runat="server" 
    SelectMethod="ObtenerListaParaProforma" TypeName="SISPACAL.BL.cPLAN_COSECHA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CATORCENA" Type="Int32"  />
        <asp:Parameter Name="SEMANA" Type="Int32" />
        <asp:Parameter Name="FECHA_INI" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="-1" Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="CODIAGRON" Type="String" />        
        <asp:Parameter Name="TIPOS_TRANSPORTE" Type="String" />   
        <asp:Parameter Name="CON_SALDO_ROZA" Type="Boolean" />   
        <asp:Parameter Name="FIN_LOTE" Type="Int32" />  
        <asp:Parameter Name="FECHA_PROFORMA" Type="DateTime" />         
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPLAN_COSECHA" DeleteMethod="EliminarPLAN_COSECHA" UpdateMethod="ActualizarPLAN_COSECHA"
    TypeName="SISPACAL.BL.cPLAN_COSECHA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PLAN_COSECHA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ_SALDO" Type="Decimal" />
        <asp:Parameter Name="TONEL_SALDO" Type="Decimal" />
        <asp:Parameter Name="MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_COSECHA" Type="Decimal" />
        <asp:Parameter Name="CUOTA_DIARIA" Type="Decimal" />
        <asp:Parameter Name="FECHA_INI_COSECHA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_COSECHA" Type="DateTime" />
        <asp:Parameter Name="TOTAL_SEMANA" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NO_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ_SALDO" Type="Decimal" />
        <asp:Parameter Name="TONEL_SALDO" Type="Decimal" />
        <asp:Parameter Name="MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_COSECHA" Type="Decimal" />
        <asp:Parameter Name="CUOTA_DIARIA" Type="Decimal" />
        <asp:Parameter Name="FECHA_INI_COSECHA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_COSECHA" Type="DateTime" />
        <asp:Parameter Name="TOTAL_SEMANA" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NO_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarPLAN_COSECHA" DeleteMethod="EliminarPLAN_COSECHA" UpdateMethod="ActualizarPLAN_COSECHA"
    TypeName="SISPACAL.BL.cPLAN_COSECHA">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PLAN_COSECHA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ_SALDO" Type="Decimal" />
        <asp:Parameter Name="TONEL_SALDO" Type="Decimal" />
        <asp:Parameter Name="MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_COSECHA" Type="Decimal" />
        <asp:Parameter Name="CUOTA_DIARIA" Type="Decimal" />
        <asp:Parameter Name="FECHA_INI_COSECHA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_COSECHA" Type="DateTime" />
        <asp:Parameter Name="TOTAL_SEMANA" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NO_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ_SALDO" Type="Decimal" />
        <asp:Parameter Name="TONEL_SALDO" Type="Decimal" />
        <asp:Parameter Name="MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_COSECHA" Type="Decimal" />
        <asp:Parameter Name="CUOTA_DIARIA" Type="Decimal" />
        <asp:Parameter Name="FECHA_INI_COSECHA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_COSECHA" Type="DateTime" />
        <asp:Parameter Name="TOTAL_SEMANA" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NO_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarPLAN_COSECHA" DeleteMethod="EliminarPLAN_COSECHA" UpdateMethod="ActualizarPLAN_COSECHA"
    TypeName="SISPACAL.BL.cPLAN_COSECHA">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PLAN_COSECHA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ_SALDO" Type="Decimal" />
        <asp:Parameter Name="TONEL_SALDO" Type="Decimal" />
        <asp:Parameter Name="MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_COSECHA" Type="Decimal" />
        <asp:Parameter Name="CUOTA_DIARIA" Type="Decimal" />
        <asp:Parameter Name="FECHA_INI_COSECHA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_COSECHA" Type="DateTime" />
        <asp:Parameter Name="TOTAL_SEMANA" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NO_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ_SALDO" Type="Decimal" />
        <asp:Parameter Name="TONEL_SALDO" Type="Decimal" />
        <asp:Parameter Name="MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_COSECHA" Type="Decimal" />
        <asp:Parameter Name="CUOTA_DIARIA" Type="Decimal" />
        <asp:Parameter Name="FECHA_INI_COSECHA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_COSECHA" Type="DateTime" />
        <asp:Parameter Name="TOTAL_SEMANA" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NO_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCARGADORA" runat="server" 
    SelectMethod="ObtenerListaPorCARGADORA" InsertMethod="AgregarPLAN_COSECHA" DeleteMethod="EliminarPLAN_COSECHA" UpdateMethod="ActualizarPLAN_COSECHA"
    TypeName="SISPACAL.BL.cPLAN_COSECHA">
    <SelectParameters>
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PLAN_COSECHA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ_SALDO" Type="Decimal" />
        <asp:Parameter Name="TONEL_SALDO" Type="Decimal" />
        <asp:Parameter Name="MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_COSECHA" Type="Decimal" />
        <asp:Parameter Name="CUOTA_DIARIA" Type="Decimal" />
        <asp:Parameter Name="FECHA_INI_COSECHA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_COSECHA" Type="DateTime" />
        <asp:Parameter Name="TOTAL_SEMANA" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NO_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="MZ_SALDO" Type="Decimal" />
        <asp:Parameter Name="TONEL_SALDO" Type="Decimal" />
        <asp:Parameter Name="MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ_COSECHA" Type="Decimal" />
        <asp:Parameter Name="TONEL_COSECHA" Type="Decimal" />
        <asp:Parameter Name="CUOTA_DIARIA" Type="Decimal" />
        <asp:Parameter Name="FECHA_INI_COSECHA" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_COSECHA" Type="DateTime" />
        <asp:Parameter Name="TOTAL_SEMANA" Type="Decimal" />
        <asp:Parameter Name="QUEMA_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="QUEMA_NO_PROGRAMADA" Type="Boolean" />
        <asp:Parameter Name="ID_TIPO_CANA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ROZA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_ALZA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADORA" Type="Int32" />
        <asp:Parameter Name="ID_CARGADOR" Type="Int32" />
        <asp:Parameter Name="ID_TIPOTRANS" Type="Int32" />
        <asp:Parameter Name="TRANSPORTE_PROPIO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
