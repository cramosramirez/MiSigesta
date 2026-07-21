<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaREQENCA.ascx.vb" Inherits="controles_ucListaREQENCA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_REQENCA" Width="100%" Font-Size="X-Small"  >
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
                                case 'btnVistaPrevia':                                                                                                     
                                    //MostrarSolicAgricolaMadurante(s.GetRowKey(e.visibleIndex));
                                    break; 
                                default:
                                    e.processOnServer = true;
                                    break;  
                            }                                                                                                    
                      }" />
    <Columns>
       <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Procesar" ToolTip="Procesar" CommandName="Editar" ImageUrl="~/imagenes/editar.png"  CommandArgument='<%# Bind("ID_REQENCA") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_REQENCA") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn VisibleIndex="2" AllowDragDrop="False" Visible="false" Caption=" " Name="colVistaPrevia" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnVistaPrevia" Image-IconID="print_preview_16x16" Image-ToolTip="Vista previa de la Solicitud">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewDataTextColumn FieldName="ID_REQENCA" ReadOnly="True" VisibleIndex="2" Caption="Id reqenca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PERIODOREQ" VisibleIndex="3" Caption="Id periodoreq" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_SECCION" VisibleIndex="4" Caption="Id seccion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITANTE" VisibleIndex="5" Caption="Id solicitante" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PERIODO" VisibleIndex="6" Caption="Periodo" UnboundType="String" Visible="false" />            
        <dx:GridViewDataTextColumn FieldName="NO_REQ" VisibleIndex="7" Caption="No. Solicitud" Width="110px" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODI_REQ" VisibleIndex="7" Caption="No. Solicitud" Width="110px" />
        <dx:GridViewDataTextColumn FieldName="AREA_DEPTO" VisibleIndex="8" Caption="Area/Departamento" UnboundType="String" />            
        <dx:GridViewDataTextColumn FieldName="SOLICITANTE" VisibleIndex="9" Caption="Solicitante" UnboundType="String" />            
        <dx:GridViewDataTextColumn FieldName="FECHA_EMISION" VisibleIndex="10" Caption="Fecha Emision" Width="100px"  >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ETAPA" VisibleIndex="10" Caption="Etapa" UnboundType="String" />  
        <dx:GridViewDataTextColumn FieldName="NO_REQ_PH" VisibleIndex="8" Caption="No req ph" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_REQ_PH" VisibleIndex="9" Caption="Fecha req ph" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NO_ORDEN_PH" VisibleIndex="10" Caption="No orden ph" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ORDEN_PH" VisibleIndex="11" Caption="Fecha orden ph" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TOTAL_ORDEN_PH" VisibleIndex="12" Caption="Total orden ph" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="AFECTO_ORDEN_PH" VisibleIndex="13" Caption="Afecto orden ph" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="IVA_ORDEN_PH" VisibleIndex="14" Caption="Iva orden ph" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NO_INGRESO_ALM" VisibleIndex="15" Caption="No ingreso alm" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INGRESO_ALM" VisibleIndex="16" Caption="Fecha ingreso alm" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NO_QUEDAN" VisibleIndex="17" Caption="No quedan" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_QUEDAN" VisibleIndex="18" Caption="Fecha quedan" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="19" Caption="Estado" Visible="false" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="SECCION" VisibleIndex="20" Caption="Sección" />
        <dx:GridViewDataTextColumn FieldName="EQUIPO" VisibleIndex="20" Caption="Equipo" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROPOSITO" VisibleIndex="20" Caption="Propósito" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="FECHA_MAX_DE_SUMINISTRO" VisibleIndex="20" Caption="Fecha Máx. Suministro" Width="100px" UnboundType="String" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_INGRESO_ESTIMADA" VisibleIndex="20" Caption="Fecha Estimada Ing." Width="100px" UnboundType="String" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="COMENTARIO_EST" VisibleIndex="20" Caption="Comentario" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_APROB" VisibleIndex="21" Caption="Usuario aprob" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_APROB" VisibleIndex="22" Caption="Fecha aprob" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_NOAPROB" VisibleIndex="23" Caption="Usuario noaprob" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_NOAPROB" VisibleIndex="24" Caption="Fecha noaprob" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ANUL" VisibleIndex="25" Caption="Usuario anul" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ANUL" VisibleIndex="26" Caption="Fecha anul" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="27" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="28" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="29" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="30" Caption="Fecha act" Visible="false" />
       <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="31">
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
    SelectMethod="ObtenerListaPorCriterios"  TypeName="SISPACAL.BL.cREQENCA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="NO_REQ" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="CODI_REQ" Type="String" />
        <asp:Parameter DefaultValue="" Name="ID_SECCION" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="ID_SOLICITANTE" Type="Int32" />        
        <asp:Parameter DefaultValue="" Name="ID_REQETAPA" Type="Int32" />    
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarREQENCA" DeleteMethod="EliminarREQENCA" UpdateMethod="ActualizarREQENCA"
    TypeName="SISPACAL.BL.cREQENCA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter Name="ID_SECCION" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITANTE" Type="Int32" />
        <asp:Parameter Name="NO_REQ" Type="Int32" />
        <asp:Parameter Name="FECHA_EMISION" Type="DateTime" />
        <asp:Parameter Name="NO_REQ_PH" Type="String" />
        <asp:Parameter Name="FECHA_REQ_PH" Type="DateTime" />
        <asp:Parameter Name="NO_ORDEN_PH" Type="String" />
        <asp:Parameter Name="FECHA_ORDEN_PH" Type="DateTime" />
        <asp:Parameter Name="TOTAL_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="AFECTO_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="IVA_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="NO_INGRESO_ALM" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO_ALM" Type="DateTime" />
        <asp:Parameter Name="NO_QUEDAN" Type="String" />
        <asp:Parameter Name="FECHA_QUEDAN" Type="DateTime" />
        <asp:Parameter Name="ID_REQETAPA" Type="Int32" />
        <asp:Parameter Name="USO" Type="String" />
        <asp:Parameter Name="USUARIO_APROB" Type="String" />
        <asp:Parameter Name="FECHA_APROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_NOAPROB" Type="String" />
        <asp:Parameter Name="FECHA_NOAPROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ANUL" Type="String" />
        <asp:Parameter Name="FECHA_ANUL" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter Name="ID_SECCION" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITANTE" Type="Int32" />
        <asp:Parameter Name="NO_REQ" Type="Int32" />
        <asp:Parameter Name="FECHA_EMISION" Type="DateTime" />
        <asp:Parameter Name="NO_REQ_PH" Type="String" />
        <asp:Parameter Name="FECHA_REQ_PH" Type="DateTime" />
        <asp:Parameter Name="NO_ORDEN_PH" Type="String" />
        <asp:Parameter Name="FECHA_ORDEN_PH" Type="DateTime" />
        <asp:Parameter Name="TOTAL_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="AFECTO_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="IVA_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="NO_INGRESO_ALM" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO_ALM" Type="DateTime" />
        <asp:Parameter Name="NO_QUEDAN" Type="String" />
        <asp:Parameter Name="FECHA_QUEDAN" Type="DateTime" />
        <asp:Parameter Name="ID_REQETAPA" Type="Int32" />
        <asp:Parameter Name="USO" Type="String" />
        <asp:Parameter Name="USUARIO_APROB" Type="String" />
        <asp:Parameter Name="FECHA_APROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_NOAPROB" Type="String" />
        <asp:Parameter Name="FECHA_NOAPROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ANUL" Type="String" />
        <asp:Parameter Name="FECHA_ANUL" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPERIODOREQ" runat="server" 
    SelectMethod="ObtenerListaPorPERIODOREQ" InsertMethod="AgregarREQENCA" DeleteMethod="EliminarREQENCA" UpdateMethod="ActualizarREQENCA"
    TypeName="SISPACAL.BL.cREQENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter Name="ID_SECCION" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITANTE" Type="Int32" />
        <asp:Parameter Name="NO_REQ" Type="Int32" />
        <asp:Parameter Name="FECHA_EMISION" Type="DateTime" />
        <asp:Parameter Name="NO_REQ_PH" Type="String" />
        <asp:Parameter Name="FECHA_REQ_PH" Type="DateTime" />
        <asp:Parameter Name="NO_ORDEN_PH" Type="String" />
        <asp:Parameter Name="FECHA_ORDEN_PH" Type="DateTime" />
        <asp:Parameter Name="TOTAL_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="AFECTO_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="IVA_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="NO_INGRESO_ALM" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO_ALM" Type="DateTime" />
        <asp:Parameter Name="NO_QUEDAN" Type="String" />
        <asp:Parameter Name="FECHA_QUEDAN" Type="DateTime" />
        <asp:Parameter Name="ID_REQETAPA" Type="Int32" />
        <asp:Parameter Name="USO" Type="String" />
        <asp:Parameter Name="USUARIO_APROB" Type="String" />
        <asp:Parameter Name="FECHA_APROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_NOAPROB" Type="String" />
        <asp:Parameter Name="FECHA_NOAPROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ANUL" Type="String" />
        <asp:Parameter Name="FECHA_ANUL" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter Name="ID_SECCION" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITANTE" Type="Int32" />
        <asp:Parameter Name="NO_REQ" Type="Int32" />
        <asp:Parameter Name="FECHA_EMISION" Type="DateTime" />
        <asp:Parameter Name="NO_REQ_PH" Type="String" />
        <asp:Parameter Name="FECHA_REQ_PH" Type="DateTime" />
        <asp:Parameter Name="NO_ORDEN_PH" Type="String" />
        <asp:Parameter Name="FECHA_ORDEN_PH" Type="DateTime" />
        <asp:Parameter Name="TOTAL_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="AFECTO_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="IVA_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="NO_INGRESO_ALM" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO_ALM" Type="DateTime" />
        <asp:Parameter Name="NO_QUEDAN" Type="String" />
        <asp:Parameter Name="FECHA_QUEDAN" Type="DateTime" />
        <asp:Parameter Name="ID_REQETAPA" Type="Int32" />
        <asp:Parameter Name="USO" Type="String" />
        <asp:Parameter Name="USUARIO_APROB" Type="String" />
        <asp:Parameter Name="FECHA_APROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_NOAPROB" Type="String" />
        <asp:Parameter Name="FECHA_NOAPROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ANUL" Type="String" />
        <asp:Parameter Name="FECHA_ANUL" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSECCION" runat="server" 
    SelectMethod="ObtenerListaPorSECCION" InsertMethod="AgregarREQENCA" DeleteMethod="EliminarREQENCA" UpdateMethod="ActualizarREQENCA"
    TypeName="SISPACAL.BL.cREQENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_SECCION" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter Name="ID_SECCION" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITANTE" Type="Int32" />
        <asp:Parameter Name="NO_REQ" Type="Int32" />
        <asp:Parameter Name="FECHA_EMISION" Type="DateTime" />
        <asp:Parameter Name="NO_REQ_PH" Type="String" />
        <asp:Parameter Name="FECHA_REQ_PH" Type="DateTime" />
        <asp:Parameter Name="NO_ORDEN_PH" Type="String" />
        <asp:Parameter Name="FECHA_ORDEN_PH" Type="DateTime" />
        <asp:Parameter Name="TOTAL_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="AFECTO_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="IVA_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="NO_INGRESO_ALM" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO_ALM" Type="DateTime" />
        <asp:Parameter Name="NO_QUEDAN" Type="String" />
        <asp:Parameter Name="FECHA_QUEDAN" Type="DateTime" />
        <asp:Parameter Name="ID_REQETAPA" Type="Int32" />
        <asp:Parameter Name="USO" Type="String" />
        <asp:Parameter Name="USUARIO_APROB" Type="String" />
        <asp:Parameter Name="FECHA_APROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_NOAPROB" Type="String" />
        <asp:Parameter Name="FECHA_NOAPROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ANUL" Type="String" />
        <asp:Parameter Name="FECHA_ANUL" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter Name="ID_SECCION" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITANTE" Type="Int32" />
        <asp:Parameter Name="NO_REQ" Type="Int32" />
        <asp:Parameter Name="FECHA_EMISION" Type="DateTime" />
        <asp:Parameter Name="NO_REQ_PH" Type="String" />
        <asp:Parameter Name="FECHA_REQ_PH" Type="DateTime" />
        <asp:Parameter Name="NO_ORDEN_PH" Type="String" />
        <asp:Parameter Name="FECHA_ORDEN_PH" Type="DateTime" />
        <asp:Parameter Name="TOTAL_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="AFECTO_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="IVA_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="NO_INGRESO_ALM" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO_ALM" Type="DateTime" />
        <asp:Parameter Name="NO_QUEDAN" Type="String" />
        <asp:Parameter Name="FECHA_QUEDAN" Type="DateTime" />
        <asp:Parameter Name="ID_REQETAPA" Type="Int32" />
        <asp:Parameter Name="USO" Type="String" />
        <asp:Parameter Name="USUARIO_APROB" Type="String" />
        <asp:Parameter Name="FECHA_APROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_NOAPROB" Type="String" />
        <asp:Parameter Name="FECHA_NOAPROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ANUL" Type="String" />
        <asp:Parameter Name="FECHA_ANUL" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLICITANTE" runat="server" 
    SelectMethod="ObtenerListaPorSOLICITANTE" InsertMethod="AgregarREQENCA" DeleteMethod="EliminarREQENCA" UpdateMethod="ActualizarREQENCA"
    TypeName="SISPACAL.BL.cREQENCA">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITANTE" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter Name="ID_SECCION" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITANTE" Type="Int32" />
        <asp:Parameter Name="NO_REQ" Type="Int32" />
        <asp:Parameter Name="FECHA_EMISION" Type="DateTime" />
        <asp:Parameter Name="NO_REQ_PH" Type="String" />
        <asp:Parameter Name="FECHA_REQ_PH" Type="DateTime" />
        <asp:Parameter Name="NO_ORDEN_PH" Type="String" />
        <asp:Parameter Name="FECHA_ORDEN_PH" Type="DateTime" />
        <asp:Parameter Name="TOTAL_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="AFECTO_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="IVA_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="NO_INGRESO_ALM" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO_ALM" Type="DateTime" />
        <asp:Parameter Name="NO_QUEDAN" Type="String" />
        <asp:Parameter Name="FECHA_QUEDAN" Type="DateTime" />
        <asp:Parameter Name="ID_REQETAPA" Type="Int32" />
        <asp:Parameter Name="USO" Type="String" />
        <asp:Parameter Name="USUARIO_APROB" Type="String" />
        <asp:Parameter Name="FECHA_APROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_NOAPROB" Type="String" />
        <asp:Parameter Name="FECHA_NOAPROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ANUL" Type="String" />
        <asp:Parameter Name="FECHA_ANUL" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
        <asp:Parameter Name="ID_PERIODOREQ" Type="Int32" />
        <asp:Parameter Name="ID_SECCION" Type="Int32" />
        <asp:Parameter Name="ID_SOLICITANTE" Type="Int32" />
        <asp:Parameter Name="NO_REQ" Type="Int32" />
        <asp:Parameter Name="FECHA_EMISION" Type="DateTime" />
        <asp:Parameter Name="NO_REQ_PH" Type="String" />
        <asp:Parameter Name="FECHA_REQ_PH" Type="DateTime" />
        <asp:Parameter Name="NO_ORDEN_PH" Type="String" />
        <asp:Parameter Name="FECHA_ORDEN_PH" Type="DateTime" />
        <asp:Parameter Name="TOTAL_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="AFECTO_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="IVA_ORDEN_PH" Type="Decimal" />
        <asp:Parameter Name="NO_INGRESO_ALM" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO_ALM" Type="DateTime" />
        <asp:Parameter Name="NO_QUEDAN" Type="String" />
        <asp:Parameter Name="FECHA_QUEDAN" Type="DateTime" />
        <asp:Parameter Name="ID_REQETAPA" Type="Int32" />
        <asp:Parameter Name="USO" Type="String" />
        <asp:Parameter Name="USUARIO_APROB" Type="String" />
        <asp:Parameter Name="FECHA_APROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_NOAPROB" Type="String" />
        <asp:Parameter Name="FECHA_NOAPROB" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ANUL" Type="String" />
        <asp:Parameter Name="FECHA_ANUL" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REQENCA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
