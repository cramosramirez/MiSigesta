<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTRATO_FINAN.ascx.vb" Inherits="controles_ucListaCONTRATO_FINAN" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetalleCONTRATO_FINAN.ascx" tagname="ucVistaDetalleCONTRATO_FINAN" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_CONTRATO_FINAN" Width="100%" >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
                       CustomButtonClick="function(s,e){                                                  
                            switch(e.buttonID){
                                case 'btnVerAnalisisFinanciero':                                         
                                    MostrarAnalisisFinancieroConsulta(2, s.cpkeyIDs[e.visibleIndex]);
                                    break;
                                case 'btnVerContrato':                                         
                                    MostrarContratoZafra(s.cpKeyValues[e.visibleIndex]);
                                    break; 
                                default:
                                    e.processOnServer = true;
                                    break;  
                            }                                                                                                    
                      }"          
        />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar"></NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
         <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="10px" Visible="false" VisibleIndex="0" />        
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="Seleccionar" Visible="false" >
            <DataItemTemplate>
               <asp:LinkButton ID="lbtnSeleccionar" ForeColor="Blue" runat="server" CommandArgument='<%# Bind("ID_CONTRATO_FINAN") %>' CommandName="Seleccionar">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CONTRATO_FINAN" ReadOnly="True" VisibleIndex="2" Caption="Id contrato finan" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="3" Caption="Zafra" Visible="false" />
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption="Ver Análisis Financiero" Name="colVistaPrevia" Width="50px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVerAnalisisFinanciero" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa del Análisis Financiero">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="true" Caption="Ver Contrato" Name="colVistaPrevia" Width="50px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVerContrato" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa del Contrato">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="CODICONTRATO" VisibleIndex="4" Caption="Contrato" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NO_CONTRATO" CellStyle-HorizontalAlign="Right" VisibleIndex="4" Width="50px"  Caption="Contrato" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="MZ" VisibleIndex="5" Caption="MZ" />
        <dx:GridViewDataTextColumn FieldName="TONEL_MZ" VisibleIndex="6" Caption="TC/MZ" />
        <dx:GridViewDataTextColumn FieldName="TONEL" VisibleIndex="7" Caption="TC" PropertiesTextEdit-DisplayFormatString="#,###,##0.00"  />
        <dx:GridViewDataTextColumn FieldName="REND_COSECHA" VisibleIndex="8" Caption="REND." />
        <dx:GridViewDataTextColumn FieldName="LIBRAS" VisibleIndex="9" Caption="LBS." PropertiesTextEdit-DisplayFormatString="#,###,##0.00"  />
        <dx:GridViewDataTextColumn FieldName="VIP" VisibleIndex="10" Caption="VIP" />
        <dx:GridViewDataTextColumn FieldName="VALOR_CONTRA" CellStyle-BackColor="#dfeeff" HeaderStyle-Font-Bold="true" PropertiesTextEdit-DisplayFormatString="#,###,##0.00"  VisibleIndex="11" Caption="VALOR CONTRATO" />
        <dx:GridViewDataTextColumn FieldName="PROVI_ROZA" VisibleIndex="12" Caption="ROZA" PropertiesTextEdit-DisplayFormatString="#,###,##0.00" />
        <dx:GridViewDataTextColumn FieldName="PROVI_ALZA" VisibleIndex="13" Caption="ALZA" PropertiesTextEdit-DisplayFormatString="#,###,##0.00" />
        <dx:GridViewDataTextColumn FieldName="PROVI_TRANS" VisibleIndex="14" Caption="TRANS" PropertiesTextEdit-DisplayFormatString="#,###,##0.00"  />
        <dx:GridViewDataTextColumn FieldName="TOTAL_CAT" VisibleIndex="14" Caption="TOTAL CAT" PropertiesTextEdit-DisplayFormatString="#,###,##0.00" UnboundType="Decimal" />
        <dx:GridViewDataTextColumn FieldName="PROVISION" VisibleIndex="15" Caption="FINAN. RESERVADOS" PropertiesTextEdit-DisplayFormatString="#,###,##0.00" />
        <dx:GridViewDataTextColumn FieldName="CARGO" VisibleIndex="16" Caption="MONTO FINANCIADO" PropertiesTextEdit-DisplayFormatString="#,###,##0.00" />
        <dx:GridViewDataTextColumn FieldName="ABONO" VisibleIndex="17" Caption="ABONO" PropertiesTextEdit-DisplayFormatString="#,###,##0.00" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="DISPONIBLE" VisibleIndex="18" HeaderStyle-Font-Bold="true" CellStyle-BackColor="#ffff99" PropertiesTextEdit-DisplayFormatString="#,###,##0.00" Caption="DISPONIBLE" />        
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="21" Caption="Usuario crea" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="22" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="23" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="24" Caption="Fecha act" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="25">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFooter="true" ShowFilterRow="True" ShowHeaderFilterButton="True" />
    <SettingsBehavior ProcessSelectionChangedOnServer="true" EnableRowHotTrack="false" />    
    <TotalSummary>
            <dx:ASPxSummaryItem FieldName="NO_CONTRATO" SummaryType="Count" DisplayFormat="Contratos: {0}" />                
            <dx:ASPxSummaryItem FieldName="MZ" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="TONEL" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="LIBRAS" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="VALOR_CONTRA" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="PROVI_ROZA" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="PROVI_ALZA" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="PROVI_TRANS" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="TOTAL_CAT" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="PROVISION" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="VIP" SummaryType="Average" DisplayFormat="{0:#,###,##0.000000}" />
            <dx:ASPxSummaryItem FieldName="CARGO" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="ABONO" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />
            <dx:ASPxSummaryItem FieldName="DISPONIBLE" SummaryType="Sum" DisplayFormat="{0:#,###,##0.00}" />            
     </TotalSummary>
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" TypeName="SISPACAL.BL.cCONTRATO_FINAN">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32"  />        
        <asp:Parameter DefaultValue="" Name="CODIPROVEEDOR" Type="String" />        
        <asp:Parameter DefaultValue="" Name="NOMBRE_PROVEEDOR" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorZAFRA_PROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA_PROVEEDOR" TypeName="SISPACAL.BL.cCONTRATO_FINAN">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ZAFRA" Type="Int32"  />        
        <asp:Parameter DefaultValue="" Name="CODIPROVEEDOR" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTRATO_FINAN" DeleteMethod="EliminarCONTRATO_FINAN" UpdateMethod="ActualizarCONTRATO_FINAN"
    TypeName="SISPACAL.BL.cCONTRATO_FINAN">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="LIBRAS" Type="Decimal" />
        <asp:Parameter Name="VIP" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ROZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ALZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_TRANS" Type="Decimal" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="DISPONIBLE" Type="Decimal" />        
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="LIBRAS" Type="Decimal" />
        <asp:Parameter Name="VIP" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ROZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ALZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_TRANS" Type="Decimal" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="DISPONIBLE" Type="Decimal" />        
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarCONTRATO_FINAN" DeleteMethod="EliminarCONTRATO_FINAN" UpdateMethod="ActualizarCONTRATO_FINAN"
    TypeName="SISPACAL.BL.cCONTRATO_FINAN">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="LIBRAS" Type="Decimal" />
        <asp:Parameter Name="VIP" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ROZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ALZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_TRANS" Type="Decimal" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="DISPONIBLE" Type="Decimal" />        
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="LIBRAS" Type="Decimal" />
        <asp:Parameter Name="VIP" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ROZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ALZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_TRANS" Type="Decimal" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="DISPONIBLE" Type="Decimal" />        
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO" InsertMethod="AgregarCONTRATO_FINAN" DeleteMethod="EliminarCONTRATO_FINAN" UpdateMethod="ActualizarCONTRATO_FINAN"
    TypeName="SISPACAL.BL.cCONTRATO_FINAN">
    <SelectParameters>
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="LIBRAS" Type="Decimal" />
        <asp:Parameter Name="VIP" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ROZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ALZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_TRANS" Type="Decimal" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="DISPONIBLE" Type="Decimal" />        
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="CODICONTRATO" Type="String" />
        <asp:Parameter Name="MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL_MZ" Type="Decimal" />
        <asp:Parameter Name="TONEL" Type="Decimal" />
        <asp:Parameter Name="REND_COSECHA" Type="Decimal" />
        <asp:Parameter Name="LIBRAS" Type="Decimal" />
        <asp:Parameter Name="VIP" Type="Decimal" />
        <asp:Parameter Name="VALOR_CONTRA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ROZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_ALZA" Type="Decimal" />
        <asp:Parameter Name="PROVI_TRANS" Type="Decimal" />
        <asp:Parameter Name="PROVISION" Type="Decimal" />
        <asp:Parameter Name="CARGO" Type="Decimal" />
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="DISPONIBLE" Type="Decimal" />        
        <asp:Parameter Name="ZAFRA" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_FINAN" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
