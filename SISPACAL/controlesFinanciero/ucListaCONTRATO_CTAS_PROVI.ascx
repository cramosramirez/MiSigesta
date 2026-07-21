<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTRATO_CTAS_PROVI.ascx.vb" Inherits="controles_ucListaCONTRATO_CTAS_PROVI" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleCONTRATO_CTAS_PROVI.ascx" tagname="ucVistaDetalleCONTRATO_CTAS_PROVI" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_CONTRATO_CTAS_PROVI" Width="100%">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0" />        
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="false">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_CONTRATO_CTAS_PROVI") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_CONTRATO_CTAS_PROVI") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CONTRATO_CTAS_PROVI" ReadOnly="True" VisibleIndex="2" Caption="Id contrato ctas provi" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CONTRATO_FINAN" VisibleIndex="3" Caption="Id contrato finan" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODICONTRATO" VisibleIndex="4" Caption="Codicontrato" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="5" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="5" Caption="Cód. Provee" UnboundType="String" Width="80px" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="5" Caption="Proveedor" UnboundType="String"  Visible="false" Width="250px" />
        <dx:GridViewDataTextColumn FieldName="NO_CONTRATO" VisibleIndex="5" Caption="N° Contrato" UnboundType="Integer" Width="60px" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_APLICA" VisibleIndex="5" Caption="Fecha" Width="80px" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CONCEPTO_FINANCIAMIENTO" VisibleIndex="5" Caption="Concepto" UnboundType="String" Visible="false" Width="200px"  />        
        <dx:GridViewDataTextColumn FieldName="CONCEPTO" VisibleIndex="7" Caption="Descripción" Width="350px" CellStyle-HorizontalAlign="Left" />
        <dx:GridViewDataTextColumn FieldName="PROVISION" VisibleIndex="8" Caption="Monto Reservado" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CUENTA_FINAN" VisibleIndex="9" Caption="Uid solic agri prod" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="UID_SOLICITUD" VisibleIndex="10" Caption="Uid Solicitud" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="11" Caption="Zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="12" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="13" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="14" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="15" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="16">
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
    SelectMethod="ObtenerListaPorCriterios"  TypeName="SISPACAL.BL.cCONTRATO_CTAS_PROVI">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />        
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTRATO_CTAS_PROVI" DeleteMethod="EliminarCONTRATO_CTAS_PROVI" UpdateMethod="ActualizarCONTRATO_CTAS_PROVI"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS_PROVI">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO_FINAN" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO_FINAN" InsertMethod="AgregarCONTRATO_CTAS_PROVI" DeleteMethod="EliminarCONTRATO_CTAS_PROVI" UpdateMethod="ActualizarCONTRATO_CTAS_PROVI"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS_PROVI">
    <SelectParameters>
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO" InsertMethod="AgregarCONTRATO_CTAS_PROVI" DeleteMethod="EliminarCONTRATO_CTAS_PROVI" UpdateMethod="ActualizarCONTRATO_CTAS_PROVI"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS_PROVI">
    <SelectParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCONTRATO_CTAS_PROVI" DeleteMethod="EliminarCONTRATO_CTAS_PROVI" UpdateMethod="ActualizarCONTRATO_CTAS_PROVI"
    TypeName="SISPACAL.BL.cCONTRATO_CTAS_PROVI">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="FECHA_APLICA" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="UID_SOLIC_AGRI_PROD" Type="Object" />
        <asp:Parameter Name="UID_SOLIC_AGRI_VUELO" Type="Object" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_CTAS_PROVI" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
