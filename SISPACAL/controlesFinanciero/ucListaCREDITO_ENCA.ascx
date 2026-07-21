<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCREDITO_ENCA.ascx.vb" Inherits="controles_ucListaCREDITO_ENCA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_CREDITO_ENCA">
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
                    CommandArgument='<%# Bind("ID_CREDITO_ENCA") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_CREDITO_ENCA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CREDITO_ENCA" ReadOnly="True" VisibleIndex="2" Caption="Id credito enca" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="3" Caption="Codiproveedor" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="4" Caption="Id zafra" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="5" Caption="Zafra" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_COMPROB" VisibleIndex="6" Caption="Id tipo comprob" />
        <dx:GridViewDataTextColumn FieldName="ID_CUENTA_FINAN" VisibleIndex="7" Caption="Id cuenta finan" />
        <dx:GridViewDataTextColumn FieldName="DESCRIP_FINAN" VisibleIndex="8" Caption="Descrip finan" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEE" VisibleIndex="9" Caption="Id provee" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="10" Caption="Fecha" />
        <dx:GridViewDataTextColumn FieldName="NO_COMPROB" VisibleIndex="11" Caption="No comprob" />
        <dx:GridViewDataTextColumn FieldName="FECHA_APLIC" VisibleIndex="12" Caption="Fecha aplic" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ULTMOV" VisibleIndex="13" Caption="Fecha ultmov" />
        <dx:GridViewDataTextColumn FieldName="UID_REFERENCIA" VisibleIndex="14" Caption="Uid referencia" />
        <dx:GridViewDataTextColumn FieldName="TASAINT" VisibleIndex="15" Caption="Tasaint" />
        <dx:GridViewDataTextColumn FieldName="CARGO" VisibleIndex="16" Caption="Cargo" />
        <dx:GridViewDataTextColumn FieldName="ABONO" VisibleIndex="17" Caption="Abono" />
        <dx:GridViewDataTextColumn FieldName="SALDO" VisibleIndex="18" Caption="Saldo" />
        <dx:GridViewDataTextColumn FieldName="INTERES" VisibleIndex="19" Caption="Interes" />
        <dx:GridViewDataTextColumn FieldName="IVA_INTERES" VisibleIndex="20" Caption="Iva interes" />
        <dx:GridViewDataTextColumn FieldName="ABONO_IVA" VisibleIndex="21" Caption="Abono iva" />
        <dx:GridViewDataTextColumn FieldName="ABONO_INTERES" VisibleIndex="22" Caption="Abono interes" />
        <dx:GridViewDataTextColumn FieldName="ABONO_INTERES_IVA" VisibleIndex="23" Caption="Abono interes iva" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="24" Caption="Usuario crea" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="25" Caption="Fecha crea" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="26" Caption="Usuario act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="27" Caption="Fecha act" />
        <dx:GridViewDataCheckColumn FieldName="ES_SALDO_INSOLUTO" VisibleIndex="28" Caption="Es saldo insoluto" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="29">
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarCREDITO_ENCA" DeleteMethod="EliminarCREDITO_ENCA" UpdateMethod="ActualizarCREDITO_ENCA"
    TypeName="SISPACAL.BL.cCREDITO_ENCA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="DESCRIP_FINAN" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="FECHA_APLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="UID_REFERENCIA" Type="Object" />
        <asp:Parameter Name="TASAINT" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="INTERES" Type="Decimal" />
        <asp:Parameter Name="IVA_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_IVA" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_SALDO_INSOLUTO" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="DESCRIP_FINAN" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="FECHA_APLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="UID_REFERENCIA" Type="Object" />
        <asp:Parameter Name="TASAINT" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="INTERES" Type="Decimal" />
        <asp:Parameter Name="IVA_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_IVA" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_SALDO_INSOLUTO" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarCREDITO_ENCA" DeleteMethod="EliminarCREDITO_ENCA" UpdateMethod="ActualizarCREDITO_ENCA"
    TypeName="SISPACAL.BL.cCREDITO_ENCA">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="DESCRIP_FINAN" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="FECHA_APLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="UID_REFERENCIA" Type="Object" />
        <asp:Parameter Name="TASAINT" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="INTERES" Type="Decimal" />
        <asp:Parameter Name="IVA_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_IVA" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_SALDO_INSOLUTO" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="DESCRIP_FINAN" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="FECHA_APLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="UID_REFERENCIA" Type="Object" />
        <asp:Parameter Name="TASAINT" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="INTERES" Type="Decimal" />
        <asp:Parameter Name="IVA_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_IVA" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_SALDO_INSOLUTO" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCREDITO_ENCA" DeleteMethod="EliminarCREDITO_ENCA" UpdateMethod="ActualizarCREDITO_ENCA"
    TypeName="SISPACAL.BL.cCREDITO_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="DESCRIP_FINAN" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="FECHA_APLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="UID_REFERENCIA" Type="Object" />
        <asp:Parameter Name="TASAINT" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="INTERES" Type="Decimal" />
        <asp:Parameter Name="IVA_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_IVA" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_SALDO_INSOLUTO" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="DESCRIP_FINAN" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="FECHA_APLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="UID_REFERENCIA" Type="Object" />
        <asp:Parameter Name="TASAINT" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="INTERES" Type="Decimal" />
        <asp:Parameter Name="IVA_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_IVA" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_SALDO_INSOLUTO" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCUENTA_FINAN" runat="server" 
    SelectMethod="ObtenerListaPorCUENTA_FINAN" InsertMethod="AgregarCREDITO_ENCA" DeleteMethod="EliminarCREDITO_ENCA" UpdateMethod="ActualizarCREDITO_ENCA"
    TypeName="SISPACAL.BL.cCREDITO_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="DESCRIP_FINAN" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="FECHA_APLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="UID_REFERENCIA" Type="Object" />
        <asp:Parameter Name="TASAINT" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="INTERES" Type="Decimal" />
        <asp:Parameter Name="IVA_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_IVA" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_SALDO_INSOLUTO" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="DESCRIP_FINAN" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="FECHA_APLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="UID_REFERENCIA" Type="Object" />
        <asp:Parameter Name="TASAINT" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="INTERES" Type="Decimal" />
        <asp:Parameter Name="IVA_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_IVA" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_SALDO_INSOLUTO" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AGRICOLA" InsertMethod="AgregarCREDITO_ENCA" DeleteMethod="EliminarCREDITO_ENCA" UpdateMethod="ActualizarCREDITO_ENCA"
    TypeName="SISPACAL.BL.cCREDITO_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="DESCRIP_FINAN" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="FECHA_APLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="UID_REFERENCIA" Type="Object" />
        <asp:Parameter Name="TASAINT" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="INTERES" Type="Decimal" />
        <asp:Parameter Name="IVA_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_IVA" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_SALDO_INSOLUTO" Type="Boolean" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="DESCRIP_FINAN" Type="String" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="NO_COMPROB" Type="String" />
        <asp:Parameter Name="FECHA_APLIC" Type="DateTime" />
        <asp:Parameter Name="FECHA_ULTMOV" Type="DateTime" />
        <asp:Parameter Name="UID_REFERENCIA" Type="Object" />
        <asp:Parameter Name="TASAINT" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="SALDO" Type="Decimal" />
        <asp:Parameter Name="INTERES" Type="Decimal" />
        <asp:Parameter Name="IVA_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_IVA" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ES_SALDO_INSOLUTO" Type="Boolean" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
