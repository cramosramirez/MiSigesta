<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaANALISIS_PRECOSECHA.ascx.vb" Inherits="controles_ucListaANALISIS_PRECOSECHA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleANALISIS_PRECOSECHA.ascx" tagname="ucVistaDetalleANALISIS_PRECOSECHA" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Font-Size="X-Small" KeyFieldName="ID_ANALISIS_PRE">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents EndCallback="function(s, e){if(s.cpMensaje != null){ AsignarMensaje(s.cpMensaje); delete s.cpMensaje;}}" RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
         CustomButtonClick="function(s,e){                                                  
                            switch(e.buttonID){
                                case 'btnVistaPrevia':                                                                                                     
                                    MostrarOrdenAnalisisPreCosecha(s.GetRowKey(e.visibleIndex));
                                    break;                               
                                case 'btnHojaResultado':                                                                                                     
                                    MostrarHojaResultadoPreCosecha(s.GetRowKey(e.visibleIndex));
                                    break;
                                default:
                                    e.processOnServer = true;
                                    break;  
                            }                                                                                                    
                      }" 
    />
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Visible="false" Caption=" " Name="colEditar" VisibleIndex="0" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEditar" Image-IconID="edit_edit_16x16" Image-ToolTip="Editar">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>          
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>            
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_ANALISIS_PRE") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_ANALISIS_PRE") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colVistaPrevia" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa de la Orden">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="true" Caption=" " Name="colHojaResultado" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnHojaResultado" Image-IconID="chart_stackedarea_16x16" Image-ToolTip="Hoja de Resultado de Análisis">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="ID_ANALISIS_PRE" ReadOnly="True" VisibleIndex="2" Visible="false" Caption="Id analisis pre" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="3" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="4" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NO_ANALISIS" VisibleIndex="5" Caption="N° Análisis" />
        <dx:GridViewDataTextColumn FieldName="FECHA_MUESTRA" VisibleIndex="6" Caption="Fecha Muestra" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NO_MUESTRA" VisibleIndex="7" Caption="N° Muestra" />
        <dx:GridViewDataTextColumn FieldName="ZONA" VisibleIndex="7" Caption="Zona" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="SUB_ZONA" VisibleIndex="7" Caption="Sub Zona" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="CODIPROVEE" VisibleIndex="7" Caption="Cod. Proveedor" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="CODISOCIO" VisibleIndex="7" Caption="Cod. Socio" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="7" Caption="Nombre Proveedor" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="CODILOTE" VisibleIndex="7" Caption="Cod. Lote" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" VisibleIndex="7" Caption="Nombre Lote" UnboundType="String"/>
        <%--<dx:GridViewDataTextColumn FieldName="CODI_SUBLOTE" VisibleIndex="7" Caption="Cod. Porción" UnboundType="String"/>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_SUBLOTE" VisibleIndex="7" Caption="Nombre Porción" UnboundType="String"/>--%>
        <dx:GridViewDataTextColumn FieldName="AREA_MUESTRA" VisibleIndex="8" Caption="Area Muestra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="BAGAZO_BRUTO" VisibleIndex="9" Caption="Bagazo bruto"  Visible="false" />
        <dx:GridViewDataTextColumn FieldName="BAGAZO_NETO" VisibleIndex="10" Caption="Bagazo neto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="POL" VisibleIndex="11" Caption="Pol" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="BRIX" VisibleIndex="12" Caption="Brix" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FIBRA_CANA" VisibleIndex="13" Caption="Fibra cana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="HUMEDAD" VisibleIndex="14" Caption="Humedad" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="POL_JUGO" VisibleIndex="15" Caption="Pol jugo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="JUGO_CANA" VisibleIndex="16" Caption="Jugo cana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="POL_CANA" VisibleIndex="17" Caption="Pol cana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PUREZA_JUGO" VisibleIndex="18" Caption="Pureza jugo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PUREZA_AZUCAR" VisibleIndex="19" Caption="Pureza azucar" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SJM" VisibleIndex="20" Caption="Sjm" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="RENDIA_CALC1" VisibleIndex="21" Caption="Rendia calc1" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="RENDIA_CALC2" VisibleIndex="22" Caption="Rendia calc2" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="POL_LECTURA" VisibleIndex="23" Caption="Pol lectura" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PH" VisibleIndex="24" Caption="Ph" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="AZUCAR_REDUCTORES" VisibleIndex="25" Caption="Azucar reductores" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ALMIDON_JUGO" VisibleIndex="26" Caption="Almidon jugo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ACIDEZ_JUGO" VisibleIndex="27" Caption="Acidez jugo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ABSORVANCIA" VisibleIndex="28" Caption="Absorvancia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="DEXTRANA" VisibleIndex="29" Caption="Dextrana" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_LEE_BAGAZO_BRUTO" VisibleIndex="30" Caption="Usuario lee bagazo bruto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_LEE_BAGAZO_BRUTO" VisibleIndex="31" Caption="Fecha lee bagazo bruto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_LEE_BAGAZO_TARA" VisibleIndex="32" Caption="Usuario lee bagazo tara" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_LEE_BAGAZO_TARA" VisibleIndex="33" Caption="Fecha lee bagazo tara" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_LEE_POL" VisibleIndex="34" Caption="Usuario lee pol" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_LEE_POL" VisibleIndex="35" Caption="Fecha lee pol" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_LEE_BRIX" VisibleIndex="36" Caption="Usuario lee brix" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_LEE_BRIX" VisibleIndex="37" Caption="Fecha lee brix" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="38" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="39" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="40" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CT" VisibleIndex="41" Caption="Fecha ct" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="42">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios"  TypeName="SISPACAL.BL.cANALISIS_PRECOSECHA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="" Name="SUB_ZONA" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODIPROVEE" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODISOCIO" Type="String" />
        <asp:Parameter DefaultValue="" Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="-1" Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="CODIAGRON" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarANALISIS_PRECOSECHA" DeleteMethod="EliminarANALISIS_PRECOSECHA" UpdateMethod="ActualizarANALISIS_PRECOSECHA"
    TypeName="SISPACAL.BL.cANALISIS_PRECOSECHA">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ANALISIS_PRE" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="NO_ANALISIS" Type="Int32" />
        <asp:Parameter Name="FECHA_MUESTRA" Type="DateTime" />
        <asp:Parameter Name="NO_MUESTRA" Type="Int32" />
        <asp:Parameter Name="AREA_MUESTRA" Type="Decimal" />
        <asp:Parameter Name="BAGAZO_BRUTO" Type="Decimal" />
        <asp:Parameter Name="BAGAZO_NETO" Type="Decimal" />
        <asp:Parameter Name="POL" Type="Decimal" />
        <asp:Parameter Name="BRIX" Type="Decimal" />
        <asp:Parameter Name="FIBRA_CANA" Type="Decimal" />
        <asp:Parameter Name="HUMEDAD" Type="Decimal" />
        <asp:Parameter Name="POL_JUGO" Type="Decimal" />
        <asp:Parameter Name="JUGO_CANA" Type="Decimal" />
        <asp:Parameter Name="POL_CANA" Type="Decimal" />
        <asp:Parameter Name="PUREZA_JUGO" Type="Decimal" />
        <asp:Parameter Name="PUREZA_AZUCAR" Type="Decimal" />
        <asp:Parameter Name="SJM" Type="Decimal" />
        <asp:Parameter Name="RENDIA_CALC1" Type="Decimal" />
        <asp:Parameter Name="RENDIA_CALC2" Type="Decimal" />
        <asp:Parameter Name="POL_LECTURA" Type="Decimal" />
        <asp:Parameter Name="PH" Type="Decimal" />
        <asp:Parameter Name="AZUCAR_REDUCTORES" Type="Decimal" />
        <asp:Parameter Name="ALMIDON_JUGO" Type="Decimal" />
        <asp:Parameter Name="ACIDEZ_JUGO" Type="Decimal" />
        <asp:Parameter Name="ABSORVANCIA" Type="Decimal" />
        <asp:Parameter Name="DEXTRANA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_LEE_BAGAZO_BRUTO" Type="String" />
        <asp:Parameter Name="FECHA_LEE_BAGAZO_BRUTO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_LEE_BAGAZO_TARA" Type="String" />
        <asp:Parameter Name="FECHA_LEE_BAGAZO_TARA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_LEE_POL" Type="String" />
        <asp:Parameter Name="FECHA_LEE_POL" Type="DateTime" />
        <asp:Parameter Name="USUARIO_LEE_BRIX" Type="String" />
        <asp:Parameter Name="FECHA_LEE_BRIX" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_CT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANALISIS_PRE" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="NO_ANALISIS" Type="Int32" />
        <asp:Parameter Name="FECHA_MUESTRA" Type="DateTime" />
        <asp:Parameter Name="NO_MUESTRA" Type="Int32" />
        <asp:Parameter Name="AREA_MUESTRA" Type="Decimal" />
        <asp:Parameter Name="BAGAZO_BRUTO" Type="Decimal" />
        <asp:Parameter Name="BAGAZO_NETO" Type="Decimal" />
        <asp:Parameter Name="POL" Type="Decimal" />
        <asp:Parameter Name="BRIX" Type="Decimal" />
        <asp:Parameter Name="FIBRA_CANA" Type="Decimal" />
        <asp:Parameter Name="HUMEDAD" Type="Decimal" />
        <asp:Parameter Name="POL_JUGO" Type="Decimal" />
        <asp:Parameter Name="JUGO_CANA" Type="Decimal" />
        <asp:Parameter Name="POL_CANA" Type="Decimal" />
        <asp:Parameter Name="PUREZA_JUGO" Type="Decimal" />
        <asp:Parameter Name="PUREZA_AZUCAR" Type="Decimal" />
        <asp:Parameter Name="SJM" Type="Decimal" />
        <asp:Parameter Name="RENDIA_CALC1" Type="Decimal" />
        <asp:Parameter Name="RENDIA_CALC2" Type="Decimal" />
        <asp:Parameter Name="POL_LECTURA" Type="Decimal" />
        <asp:Parameter Name="PH" Type="Decimal" />
        <asp:Parameter Name="AZUCAR_REDUCTORES" Type="Decimal" />
        <asp:Parameter Name="ALMIDON_JUGO" Type="Decimal" />
        <asp:Parameter Name="ACIDEZ_JUGO" Type="Decimal" />
        <asp:Parameter Name="ABSORVANCIA" Type="Decimal" />
        <asp:Parameter Name="DEXTRANA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_LEE_BAGAZO_BRUTO" Type="String" />
        <asp:Parameter Name="FECHA_LEE_BAGAZO_BRUTO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_LEE_BAGAZO_TARA" Type="String" />
        <asp:Parameter Name="FECHA_LEE_BAGAZO_TARA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_LEE_POL" Type="String" />
        <asp:Parameter Name="FECHA_LEE_POL" Type="DateTime" />
        <asp:Parameter Name="USUARIO_LEE_BRIX" Type="String" />
        <asp:Parameter Name="FECHA_LEE_BRIX" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_CT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ANALISIS_PRE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
