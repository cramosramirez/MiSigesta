<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCCF_ENCA_TRANS.ascx.vb" Inherits="controles_ucListaCCF_ENCA_TRANS" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleCCF_ENCA_TRANS.ascx" tagname="ucVistaDetalleCCF_ENCA_TRANS" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" Width="100%"  KeyFieldName="ID_CCF_TRANS">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewDataTextColumn VisibleIndex="0" Visible="true" Caption="Editar" Name="Editar" CellStyle-HorizontalAlign="Center" Width="40px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_CCF_TRANS")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_CCF_TRANS")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CCF_TRANS" ReadOnly="True" VisibleIndex="2" Caption="Id ccf trans" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="2" Caption="Zafra" Width="80px" UnboundType="String"  />     
        <dx:GridViewDataTextColumn FieldName="CODTRANSPORT" VisibleIndex="3" Caption="Cod. Transport." />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_TRANSPORTISTA" VisibleIndex="3" Caption="Transportista" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NUM_SOLICITUD" VisibleIndex="3" Caption="N° Solicitud" Width="80px" CellStyle-HorizontalAlign="Right" UnboundType="String"  />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="4" Caption="Id zafra" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="5" Caption="Id solicitud" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CUENTA_FINAN" VisibleIndex="6" Caption="Id cuenta finan" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_COMPROB" VisibleIndex="7" Caption="Id tipo comprob" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEE" VisibleIndex="8" Caption="Id provee" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="8" Caption="Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="TIPO_COMPROB" VisibleIndex="8" Caption="Tipo Comprob." UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NO_CCF" VisibleIndex="9" Caption="No Comprob" />
        <dx:GridViewDataTextColumn FieldName="CONDI_COMPRA" VisibleIndex="10" Caption="Condi compra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="UID_CCF" VisibleIndex="11" Caption="Uid ccf" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="12" Caption="Fecha" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_CONDI_COMPRA" VisibleIndex="13" Caption="Condición Compra" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="SUB_TOTAL" VisibleIndex="13" Caption="SubTotal" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="DESCTO_PORC" VisibleIndex="14" Caption="% Desc" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="DESCTO_MONTO" VisibleIndex="15" Caption="Desc.($)" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="SUMAS" VisibleIndex="16" Caption="Sumas" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CESC" VisibleIndex="17" Caption="CESC" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00###" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="IVA" VisibleIndex="17" Caption="Iva" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TOTAL" VisibleIndex="18" Caption="Total" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREACION" VisibleIndex="19" Caption="Usuario creacion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREACION" VisibleIndex="20" Caption="Fecha creacion" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="21">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
         </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCCF_ENCA_TRANS" DeleteMethod="EliminarCCF_ENCA_TRANS" UpdateMethod="ActualizarCCF_ENCA_TRANS"
    TypeName="SISPACAL.BL.cCCF_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTRANSPORTISTA" runat="server" 
    SelectMethod="ObtenerListaPorTRANSPORTISTA" InsertMethod="AgregarCCF_ENCA_TRANS" DeleteMethod="EliminarCCF_ENCA_TRANS" UpdateMethod="ActualizarCCF_ENCA_TRANS"
    TypeName="SISPACAL.BL.cCCF_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCCF_ENCA_TRANS" DeleteMethod="EliminarCCF_ENCA_TRANS" UpdateMethod="ActualizarCCF_ENCA_TRANS"
    TypeName="SISPACAL.BL.cCCF_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLIC_ENCA_TRANS" runat="server" 
    SelectMethod="ObtenerListaPorSOLIC_ENCA_TRANS" InsertMethod="AgregarCCF_ENCA_TRANS" DeleteMethod="EliminarCCF_ENCA_TRANS" UpdateMethod="ActualizarCCF_ENCA_TRANS"
    TypeName="SISPACAL.BL.cCCF_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCUENTA_FINAN" runat="server" 
    SelectMethod="ObtenerListaPorCUENTA_FINAN" InsertMethod="AgregarCCF_ENCA_TRANS" DeleteMethod="EliminarCCF_ENCA_TRANS" UpdateMethod="ActualizarCCF_ENCA_TRANS"
    TypeName="SISPACAL.BL.cCCF_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_COMPROB" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_COMPROB" InsertMethod="AgregarCCF_ENCA_TRANS" DeleteMethod="EliminarCCF_ENCA_TRANS" UpdateMethod="ActualizarCCF_ENCA_TRANS"
    TypeName="SISPACAL.BL.cCCF_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AGRICOLA" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AGRICOLA" InsertMethod="AgregarCCF_ENCA_TRANS" DeleteMethod="EliminarCCF_ENCA_TRANS" UpdateMethod="ActualizarCCF_ENCA_TRANS"
    TypeName="SISPACAL.BL.cCCF_ENCA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
        <asp:Parameter Name="CODTRANSPORT" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Int32" />
        <asp:Parameter Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NO_CCF" Type="String" />
        <asp:Parameter Name="CONDI_COMPRA" Type="Int32" />
        <asp:Parameter Name="UID_CCF" Type="Object" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="SUB_TOTAL" Type="Decimal" />
        <asp:Parameter Name="DESCTO_PORC" Type="Decimal" />
        <asp:Parameter Name="DESCTO_MONTO" Type="Decimal" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CCF_TRANS" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
