<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCOMPROB_ENCA.ascx.vb" Inherits="controles_ucListaCOMPROB_ENCA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsListaPorCriterios" KeyFieldName="ID_COMPROB_ENCA" Width="100%">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="true" Caption="Asociar" Name="Editar" CellStyle-HorizontalAlign="Center" Width="40px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_COMPROB_ENCA")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_COMPROB_ENCA")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="ID_COMPROB_ENCA" ReadOnly="True" VisibleIndex="2" Caption="Id comprob enca" Width="150px" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CATORCENA" VisibleIndex="4" Caption="Id catorcena" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_PLANILLA" VisibleIndex="5" Caption="Id tipo planilla" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_COMPROB" VisibleIndex="6" Caption="Id tipo comprob" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NUM_DOCTO" VisibleIndex="7" Caption="Numero" Width="50px" />
        <dx:GridViewDataTextColumn FieldName="SERIE" VisibleIndex="8" Caption="Serie" Width="50px" />        
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="9" Caption="Estado" Width="50px" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="10" Caption="Fecha" Width="50px" >
             <PropertiesTextEdit DisplayFormatString="dd/MM/yy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODIGO" VisibleIndex="11" Caption="Codigo" Width="80px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="12" Caption="Nombres" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="13" Caption="Apellidos" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="14" Caption="Direccion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODI_DEPTO" VisibleIndex="15" Caption="Codi depto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODI_MUNI" VisibleIndex="16" Caption="Codi muni" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="17" Caption="Nit" Width="90px" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="18" Caption="Dui" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NRC" VisibleIndex="19" Caption="Nrc" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="GIRO" VisibleIndex="20" Caption="Giro" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CORREO" VisibleIndex="21" Caption="Correo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SUMAS" VisibleIndex="22" Caption="Sumas" Width="100px" >
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="IVA" VisibleIndex="23" Caption="Iva" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="RENTA" VisibleIndex="24" Caption="Renta" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SUBTOTAL" VisibleIndex="25" Caption="Subtotal" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="IVA_RETENIDO" VisibleIndex="26" Caption="Iva retenido" Width="90px" >
            <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NUM_CCF" VisibleIndex="27" Caption="Resolucion / No. de Control" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="TOTAL" VisibleIndex="27" Caption="Total" Width="100px" >
             <PropertiesTextEdit DisplayFormatString="#,###,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="28" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="29" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PLANILLA_COMPROB" VisibleIndex="30" Caption="Id planilla comprob" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="31" Visible="false">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text=" " Image-ToolTip="Eliminar" Image-IconID="edit_delete_16x16">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="99" Visible="true" Caption="Desasociar" Name="Desasociar" CellStyle-HorizontalAlign="Center" Width="40px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnDesasociar" runat="server" CommandName="Desasociar" ImageUrl="~/imagenes/undo.png"  CommandArgument='<%# Bind("ID_COMPROB_ENCA")%>'></asp:ImageButton>                                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" 
    TypeName="SISPACAL.BL.cCOMPROB_ENCA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter DefaultValue="-1" Name="ID_TIPO_PLANILLA" Type="Int32" />      
    </SelectParameters>    
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCOMPROB_ENCA" DeleteMethod="EliminarCOMPROB_ENCA" UpdateMethod="ActualizarCOMPROB_ENCA"
    TypeName="SISPACAL.BL.cCOMPROB_ENCA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCOMPROB_ENCA" DeleteMethod="EliminarCOMPROB_ENCA" UpdateMethod="ActualizarCOMPROB_ENCA"
    TypeName="SISPACAL.BL.cCOMPROB_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCATORCENA_ZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorCATORCENA_ZAFRA" InsertMethod="AgregarCOMPROB_ENCA" DeleteMethod="EliminarCOMPROB_ENCA" UpdateMethod="ActualizarCOMPROB_ENCA"
    TypeName="SISPACAL.BL.cCOMPROB_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_PLANILLA" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_PLANILLA" InsertMethod="AgregarCOMPROB_ENCA" DeleteMethod="EliminarCOMPROB_ENCA" UpdateMethod="ActualizarCOMPROB_ENCA"
    TypeName="SISPACAL.BL.cCOMPROB_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_COMPROB" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_COMPROB" InsertMethod="AgregarCOMPROB_ENCA" DeleteMethod="EliminarCOMPROB_ENCA" UpdateMethod="ActualizarCOMPROB_ENCA"
    TypeName="SISPACAL.BL.cCOMPROB_ENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarCOMPROB_ENCA" DeleteMethod="EliminarCOMPROB_ENCA" UpdateMethod="ActualizarCOMPROB_ENCA"
    TypeName="SISPACAL.BL.cCOMPROB_ENCA">
    <SelectParameters>
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_COMPROB" Type="Int32" />
        <asp:Parameter Name="SERIE" Type="String" />
        <asp:Parameter Name="NUM_DOCTO" Type="Int32" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="GIRO" Type="String" />
        <asp:Parameter Name="CORREO" Type="String" />
        <asp:Parameter Name="SUMAS" Type="Decimal" />
        <asp:Parameter Name="IVA" Type="Decimal" />
        <asp:Parameter Name="RENTA" Type="Decimal" />
        <asp:Parameter Name="SUBTOTAL" Type="Decimal" />
        <asp:Parameter Name="IVA_RETENIDO" Type="Decimal" />
        <asp:Parameter Name="TOTAL" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="ID_PLANILLA_COMPROB" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_COMPROB_ENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
