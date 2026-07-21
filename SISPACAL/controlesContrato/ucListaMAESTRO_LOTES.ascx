<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaMAESTRO_LOTES.ascx.vb" Inherits="controlesMaestro_ucListaMAESTRO_LOTES" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<%@ Register src="ucVistaDetalleMAESTRO_LOTES.ascx" tagname="ucVistaDetalleMAESTRO_LOTES" tagprefix="uc1" %>
    
    <dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" 
    KeyFieldName="ID_MAESTRO" Theme="Office2010Blue" DataSourceID="odsCriterios"    
        Font-Names="Arial" Font-Size="X-Small">
        <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
        <SettingsPager PageSize="8">
            <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
        </SettingsPager>
        <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
        <ClientSideEvents EndCallback="function(s, e){if(s.cpMensaje != null){ AsignarMensaje(s.cpMensaje); delete s.cpMensaje;}}" RowClick="function(s, e) {
                                                    var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();
                                    }"
        CustomButtonClick="function(s,e){                                                  
                            switch(e.buttonID){
                                case 'btnVerSUBLOTES':                                              
                                    window.open('../SubLotes/wfMantSUBLOTES.aspx?maestro=' + s.GetRowKey(e.visibleIndex), '_blank', '');
                                    break;                                                              
                                default:
                                    e.processOnServer = true;
                                    break;  
                            }                                                                                                    
                      }" />
        <Columns>            
            <dx:GridViewCommandColumn Name="Seleccionar" ShowSelectCheckbox="True" VisibleIndex="0" Visible="false" >
            </dx:GridViewCommandColumn>
            <dx:GridViewCommandColumn AllowDragDrop="False" Visible="false" Caption=" " VisibleIndex="0" ButtonType="Image">
                <CustomButtons>
                     <dx:GridViewCommandColumnCustomButton ID="btnEditar" Image-IconID="edit_edit_16x16" Image-ToolTip="Editar">                                             
                     </dx:GridViewCommandColumnCustomButton>                                        
                </CustomButtons>
            </dx:GridViewCommandColumn>               
            <dx:GridViewDataTextColumn Name="colEditar" VisibleIndex="1" Visible="false" Width="40px">
                <DataItemTemplate>
                    <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_MAESTRO") %>'></asp:ImageButton>                
                    <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                        CommandArgument='<%# Bind("ID_MAESTRO") %>' CommandName="Seleccionar" 
                        Visible="False">Seleccionar</asp:LinkButton>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Name="colMostrar" VisibleIndex="1" Visible="false">
                <DataItemTemplate>
                    <asp:ImageButton ID="lbtnMostrar" runat="server" CommandName="Mostrar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_MAESTRO") %>'></asp:ImageButton>                
                    &nbsp;<asp:LinkButton ID="lnkMostrar" runat="server" 
                        CommandArgument='<%# Bind("ID_MAESTRO") %>' CommandName="Mostrar" 
                        Visible="False">Seleccionar</asp:LinkButton>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Caption=" " Name="colVerSUBLOTES" ButtonType="Image">
                <CustomButtons>
                        <dx:GridViewCommandColumnCustomButton ID="btnVerSUBLOTES" Image-Url="../imagenes/controlRoza.png" Image-ToolTip="Mantenimiento de Sublotes">                                             
                        </dx:GridViewCommandColumnCustomButton>                                        
                </CustomButtons>
            </dx:GridViewCommandColumn>  
            <dx:GridViewDataTextColumn FieldName="ID_MAESTRO" VisibleIndex="2" Caption="Identificador" Width="80px"  />
            <dx:GridViewDataTextColumn FieldName="ZONA" VisibleIndex="2" Caption="Zona" />
            <dx:GridViewDataTextColumn FieldName="SUB_ZONA" VisibleIndex="3" Caption="Sub Zona" />
            <dx:GridViewDataTextColumn FieldName="CUI" VisibleIndex="4" Caption="CUI" />
            <dx:GridViewDataTextColumn FieldName="CODI_DEPTO" VisibleIndex="5" Caption="Codi depto" />
            <dx:GridViewDataTextColumn FieldName="NOMBRE_DEPTO" VisibleIndex="6" CellStyle-HorizontalAlign="Left" Caption="Departamento" UnboundType="String" Settings-AutoFilterCondition="Contains" />
            <dx:GridViewDataTextColumn FieldName="CODI_MUNI" VisibleIndex="7" Caption="Codi muni" />
            <dx:GridViewDataTextColumn FieldName="NOMBRE_MUNI" VisibleIndex="8" CellStyle-HorizontalAlign="Left" Caption="Municipio" UnboundType="String" Settings-AutoFilterCondition="Contains" />
            <dx:GridViewDataTextColumn FieldName="CODI_CANTON" VisibleIndex="9" Caption="Codi canton" />
            <dx:GridViewDataTextColumn FieldName="NOMBRE_CANTON" VisibleIndex="10" CellStyle-HorizontalAlign="Left" Caption="Canton" UnboundType="String" Settings-AutoFilterCondition="Contains" />
            <dx:GridViewDataTextColumn FieldName="CORRELATIVO" VisibleIndex="11" Caption="Correlativo" />
            <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="12" Caption="Cod. Proveedor" />
            <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="13" Caption="Cod. Provee" UnboundType="String" />
            <dx:GridViewDataTextColumn FieldName="CODISOCIO" VisibleIndex="14" Caption="Socio" UnboundType="String" />
            <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="15" CellStyle-HorizontalAlign="Left" Caption="Proveedor" UnboundType="String" Settings-AutoFilterCondition="Contains" />
            <dx:GridViewDataTextColumn FieldName="HACIENDA" VisibleIndex="16" CellStyle-HorizontalAlign="Left" Caption="Hacienda" Settings-AutoFilterCondition="Contains" />
            <dx:GridViewDataTextColumn FieldName="NOMBRE_COMER" VisibleIndex="16" CellStyle-HorizontalAlign="Left" Caption="Nombre comercial" Settings-AutoFilterCondition="Contains" />
            <dx:GridViewDataTextColumn FieldName="CODILOTE_COMER" VisibleIndex="17" Caption="Num. Lote" />
            <dx:GridViewDataTextColumn FieldName="MZ_CULTIVADA" VisibleIndex="18" Caption="MZ Cultivada" />
            <dx:GridViewDataTextColumn FieldName="CODIVARIEDA" VisibleIndex="19" Caption="Codivarieda" />
            <dx:GridViewDataTextColumn FieldName="ID_COMPOR" VisibleIndex="20" Caption="Id compor" />
            <dx:GridViewDataTextColumn FieldName="COD_TIPO_SUELO" VisibleIndex="21" Caption="Cod tipo suelo" />
            <dx:GridViewDataTextColumn FieldName="ID_COND_SIEMBRA" VisibleIndex="22" Caption="Id cond siembra" />
            <dx:GridViewDataTextColumn FieldName="ID_NIVEL_HUMEDAD" VisibleIndex="23" Caption="Id nivel humedad" />
            <dx:GridViewDataTextColumn FieldName="NO_CORTE" VisibleIndex="24" Caption="N° Corte" />
            <dx:GridViewDataTextColumn FieldName="MSNM" VisibleIndex="25" Caption="MSNM" />
            <dx:GridViewDataTextColumn FieldName="KM_CARRETERA" VisibleIndex="26" Caption="Km carretera" />
            <dx:GridViewDataTextColumn FieldName="KM_TIERRA" VisibleIndex="27" Caption="Km Tierra" />
            <dx:GridViewDataCheckColumn FieldName="RIESGO_PIEDRA" VisibleIndex="28" Caption="Riesgo piedra" />
            <dx:GridViewDataTextColumn FieldName="FECHA_SIEMBRA" VisibleIndex="29" Caption="Fecha siembra" />
            <dx:GridViewDataTextColumn FieldName="FECHA_CORTE" VisibleIndex="30" Caption="Fecha corte" />
            <dx:GridViewDataTextColumn FieldName="PROD_TC" VisibleIndex="31" Caption="Prod tc" />
            <dx:GridViewDataTextColumn FieldName="PROD_LB" VisibleIndex="32" Caption="Prod lb" />
            <dx:GridViewDataTextColumn FieldName="FACTOR_DESPOBLA" VisibleIndex="33" Caption="Factor despobla" />
            <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="34" Caption="Usuario crea" />
            <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="35" Caption="Fecha crea" />
            <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="36" Caption="Usuario act" />
            <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="37" Caption="Fecha act" />
            <dx:GridViewDataTextColumn FieldName="CODICONTRATO" Visible="false" VisibleIndex="15" Caption="Contrato" />
            <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="38">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
            </dx:GridViewCommandColumn>
        </Columns>
        <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
        <SettingsBehavior EnableRowHotTrack="True" />        
    </dx:ASPxGridView>
<dx:ASPxHiddenField ID="hfListaMAESTRO_LOTES" ClientInstanceName="hfListaMAESTRO_LOTES" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>
<dx:ASPxHiddenField ID="hfListaMAESTRO_LOTESSelect" ClientInstanceName="hfListaMAESTRO_LOTESSelect" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarMAESTRO_LOTES" DeleteMethod="EliminarMAESTRO_LOTES" UpdateMethod="ActualizarMAESTRO_LOTES"
    TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarMAESTRO_LOTES" DeleteMethod="EliminarMAESTRO_LOTES" UpdateMethod="ActualizarMAESTRO_LOTES"
    TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarMAESTRO_LOTES" DeleteMethod="EliminarMAESTRO_LOTES" UpdateMethod="ActualizarMAESTRO_LOTES"
    TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_MAESTRO" DefaultValue="0" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCANTON" runat="server" 
    SelectMethod="ObtenerListaPorCANTON" InsertMethod="AgregarMAESTRO_LOTES" DeleteMethod="EliminarMAESTRO_LOTES" UpdateMethod="ActualizarMAESTRO_LOTES"
    TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>        
        <asp:Parameter Name="ID_MAESTRO" DefaultValue="0" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZONAS" runat="server" 
    SelectMethod="ObtenerListaPorZONAS" InsertMethod="AgregarMAESTRO_LOTES" DeleteMethod="EliminarMAESTRO_LOTES" UpdateMethod="ActualizarMAESTRO_LOTES"
    TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>        
        <asp:Parameter Name="ID_MAESTRO" DefaultValue="0" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSUB_ZONAS" runat="server" 
    SelectMethod="ObtenerListaPorSUB_ZONAS" InsertMethod="AgregarMAESTRO_LOTES" DeleteMethod="EliminarMAESTRO_LOTES" UpdateMethod="ActualizarMAESTRO_LOTES"
    TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_MAESTRO" DefaultValue="0" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />        
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCOMPORTAMIENTO_CANA" runat="server" 
    SelectMethod="ObtenerListaPorCOMPORTAMIENTO_CANA" InsertMethod="AgregarMAESTRO_LOTES" DeleteMethod="EliminarMAESTRO_LOTES" UpdateMethod="ActualizarMAESTRO_LOTES"
    TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_MAESTRO" DefaultValue="0" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />        
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />        
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_SUELO" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_SUELO" InsertMethod="AgregarMAESTRO_LOTES" DeleteMethod="EliminarMAESTRO_LOTES" UpdateMethod="ActualizarMAESTRO_LOTES"
    TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_MAESTRO" DefaultValue="0" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONDICION_SIEMBRA" runat="server" 
    SelectMethod="ObtenerListaPorCONDICION_SIEMBRA" InsertMethod="AgregarMAESTRO_LOTES" DeleteMethod="EliminarMAESTRO_LOTES" UpdateMethod="ActualizarMAESTRO_LOTES"
    TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_MAESTRO" DefaultValue="0" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />        
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorNIVEL_HUMEDAD" runat="server" 
    SelectMethod="ObtenerListaPorNIVEL_HUMEDAD" InsertMethod="AgregarMAESTRO_LOTES" DeleteMethod="EliminarMAESTRO_LOTES" UpdateMethod="ActualizarMAESTRO_LOTES"
    TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_MAESTRO" DefaultValue="0" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />
        <asp:Parameter Name="CUI" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CORRELATIVO" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="NOMBRE_COMER" Type="String" />
        <asp:Parameter Name="CODILOTE_COMER" Type="String" />
        <asp:Parameter Name="MZ_CULTIVADA" Type="Decimal" />
        <asp:Parameter Name="CODIVARIEDA" Type="String" />
        <asp:Parameter Name="ID_COMPOR" Type="Int32" />
        <asp:Parameter Name="COD_TIPO_SUELO" Type="String" />
        <asp:Parameter Name="ID_COND_SIEMBRA" Type="Int32" />
        <asp:Parameter Name="ID_NIVEL_HUMEDAD" Type="Int32" />
        <asp:Parameter Name="NO_CORTE" Type="Int16" />
        <asp:Parameter Name="MSNM" Type="Decimal" />
        <asp:Parameter Name="KM_CARRETERA" Type="Decimal" />
        <asp:Parameter Name="KM_TIERRA" Type="Decimal" />
        <asp:Parameter Name="RIESGO_PIEDRA" Type="Boolean" />
        <asp:Parameter Name="FECHA_SIEMBRA" Type="DateTime" />
        <asp:Parameter Name="FECHA_CORTE" Type="DateTime" />
        <asp:Parameter Name="PROD_TC" Type="Decimal" />
        <asp:Parameter Name="PROD_LB" Type="Decimal" />
        <asp:Parameter Name="FACTOR_DESPOBLA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="CODIGO_LOTE" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios"  TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="Int32"  />        
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />            
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCriteriosPorZafra" runat="server" 
    SelectMethod="ObtenerListaPorCriteriosZafra"  TypeName="SISPACAL.BL.cMAESTRO_LOTES">
    <SelectParameters>
        <asp:Parameter Name="ZONA" Type="String" />
        <asp:Parameter Name="SUB_ZONA" Type="String" />
        <asp:Parameter Name="CODI_DEPTO" Type="String" />
        <asp:Parameter Name="CODI_MUNI" Type="String" />
        <asp:Parameter Name="CODI_CANTON" Type="String" />
        <asp:Parameter Name="CODIPROVEE" Type="String" />
        <asp:Parameter Name="CODISOCIO" Type="String" />
        <asp:Parameter Name="CODICONTRATO" Type="Int32"  />        
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />    
        <asp:Parameter Name="ID_ZAFRA_CONTRATO" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>