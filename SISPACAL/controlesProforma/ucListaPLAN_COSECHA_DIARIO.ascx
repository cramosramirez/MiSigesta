<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPLAN_COSECHA_DIARIO.ascx.vb" Inherits="controles_ucListaPLAN_COSECHA_DIARIO" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%" EnableRowsCache="false" KeyFieldName="ID_PLAN_COSECHA_DIARIO">
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
        <%--<dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_PLAN_COSECHA_DIARIO") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PLAN_COSECHA_DIARIO") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>--%>
        <dx:GridViewDataTextColumn FieldName="ID_PLAN_COSECHA_DIARIO" ReadOnly="True" VisibleIndex="2" Caption="Id plan cosecha diario" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="4" ReadOnly="True" Visible="false" Caption="Id zafra" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="5" ReadOnly="True" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ZONA" Width="50px" VisibleIndex="6" Caption="Zona" EditFormSettings-Visible="False" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" Width="90px" VisibleIndex="7" Caption="Cod. Provee" EditFormSettings-Visible="False" />            
        <dx:GridViewDataTextColumn FieldName="CCODISOCIO" Width="70px" VisibleIndex="8" Caption="Cod Socio" EditFormSettings-Visible="False" />           
        <dx:GridViewDataTextColumn FieldName="PROVEEDOR" Width="300px" VisibleIndex="9" ReadOnly="True" Caption="Productor" EditFormSettings-Visible="False" />
        <dx:GridViewDataTextColumn FieldName="CODILOTE" Width="70px" VisibleIndex="10" ReadOnly="True" Caption="Cod. Lote" EditFormSettings-Visible="False" />
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" Width="200px" VisibleIndex="11" ReadOnly="True" Caption="Nombre Lote" EditFormSettings-Visible="False" />                
        <dx:GridViewDataSpinEditColumn  FieldName="ROZA_PROYECTADA" CellStyle-HorizontalAlign="Right" Width="100px" HeaderStyle-Wrap="True"  VisibleIndex="14" Caption="Roza Proyectada" >
            <PropertiesSpinEdit MinValue="0" MaxValue="100000" >            
                <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" ErrorText="Ingrese el valor de Roza Proyectada" />
            </PropertiesSpinEdit>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataCheckColumn FieldName="AUTORIZADO" CellStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Width="90px" VisibleIndex="15" Caption="Autorizado a Entrega de Caña" > 
            <PropertiesCheckEdit AllowGrayed="true" AllowGrayedByClick="false" />
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="16" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="17" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="18" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="19" Caption="Fecha act" Visible="false"   />
        <dx:GridViewDataTextColumn FieldName="DIAZAFRA" VisibleIndex="20" ReadOnly="True" Visible="false" Caption="Dia zafra" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="21">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" UpdateMethod="ActualizarPLAN_COSECHA_DIARIO" TypeName="SISPACAL.BL.cPLAN_COSECHA_DIARIO">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1"  Name="ID_ZAFRA" Type="Int32"  />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="DIAZAFRA"  Type="Int32" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
    </SelectParameters>   
    <UpdateParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA_DIARIO" Type="Int32" />        
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CCODISOCIO" Type="String" />
        <asp:Parameter Name="PROVEEDOR" Type="String" />        
        <asp:Parameter Name="ROZA_PROYECTADA" Type="Decimal" />
        <asp:Parameter Name="AUTORIZADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
    </UpdateParameters>   
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPLAN_COSECHA_DIARIO" DeleteMethod="EliminarPLAN_COSECHA_DIARIO" UpdateMethod="ActualizarPLAN_COSECHA_DIARIO"
    TypeName="SISPACAL.BL.cPLAN_COSECHA_DIARIO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PLAN_COSECHA_DIARIO" Type="Int32" />        
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CCODISOCIO" Type="String" />
        <asp:Parameter Name="PROVEEDOR" Type="String" />       
        <asp:Parameter Name="ROZA_PROYECTADA" Type="Decimal" />
        <asp:Parameter Name="AUTORIZADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA_DIARIO" Type="Int32" />        
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CCODISOCIO" Type="String" />
        <asp:Parameter Name="PROVEEDOR" Type="String" />       
        <asp:Parameter Name="ROZA_PROYECTADA" Type="Decimal" />
        <asp:Parameter Name="AUTORIZADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA_DIARIO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarPLAN_COSECHA_DIARIO" DeleteMethod="EliminarPLAN_COSECHA_DIARIO" UpdateMethod="ActualizarPLAN_COSECHA_DIARIO"
    TypeName="SISPACAL.BL.cPLAN_COSECHA_DIARIO">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PLAN_COSECHA_DIARIO" Type="Int32" />        
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CCODISOCIO" Type="String" />
        <asp:Parameter Name="PROVEEDOR" Type="String" />     
        <asp:Parameter Name="ROZA_PROYECTADA" Type="Decimal" />
        <asp:Parameter Name="AUTORIZADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA_DIARIO" Type="Int32" />        
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CCODISOCIO" Type="String" />
        <asp:Parameter Name="PROVEEDOR" Type="String" />      
        <asp:Parameter Name="ROZA_PROYECTADA" Type="Decimal" />
        <asp:Parameter Name="AUTORIZADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA_DIARIO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarPLAN_COSECHA_DIARIO" DeleteMethod="EliminarPLAN_COSECHA_DIARIO" UpdateMethod="ActualizarPLAN_COSECHA_DIARIO"
    TypeName="SISPACAL.BL.cPLAN_COSECHA_DIARIO">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PLAN_COSECHA_DIARIO" Type="Int32" />        
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CCODISOCIO" Type="String" />
        <asp:Parameter Name="PROVEEDOR" Type="String" />       
        <asp:Parameter Name="ROZA_PROYECTADA" Type="Decimal" />
        <asp:Parameter Name="AUTORIZADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA_DIARIO" Type="Int32" />        
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="CODILOTE" Type="String" />
        <asp:Parameter Name="NOMBLOTE" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CCODISOCIO" Type="String" />
        <asp:Parameter Name="PROVEEDOR" Type="String" />       
        <asp:Parameter Name="ROZA_PROYECTADA" Type="Decimal" />
        <asp:Parameter Name="AUTORIZADO" Type="Boolean" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="DIAZAFRA" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PLAN_COSECHA_DIARIO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
