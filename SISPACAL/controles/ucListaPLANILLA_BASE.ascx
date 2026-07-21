<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPLANILLA_BASE.ascx.vb" Inherits="controles_ucListaPLANILLA_BASE" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_PLANILLA_BASE" Width="100%"  >
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
        <dx:GridViewCommandColumn AllowDragDrop="False" Visible="false" Caption="" Name="colEditar" VisibleIndex="0" ButtonType="Image">
            <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEditar" Image-IconID="edit_edit_16x16" Image-ToolTip="Editar">                                             
                    </dx:GridViewCommandColumnCustomButton>                                        
            </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>            
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="true" Caption="Editar" Name="Editar" CellStyle-HorizontalAlign="Center" Width="40px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_PLANILLA_BASE")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_PLANILLA_BASE")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>       
        <dx:GridViewDataTextColumn FieldName="ID_PLANILLA_BASE" ReadOnly="True" VisibleIndex="2" Caption="Id planilla base" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ZAFRA" VisibleIndex="3" Caption="Id zafra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CATORCENA" VisibleIndex="4" Caption="Id catorcena" Visible="false" SortIndex="0" SortOrder="Descending"  />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_PLANILLA" VisibleIndex="5" Caption="Id tipo planilla" Visible="false" SortIndex="1" SortOrder="Ascending"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ZAFRA" VisibleIndex="5" Caption="Zafra" UnboundType="String" />            
        <dx:GridViewDataTextColumn FieldName="CORTE" VisibleIndex="5" Caption="N° Corte" Width="80px" UnboundType="Integer" />            
        <dx:GridViewDataTextColumn FieldName="TIPO_PLANILLA" VisibleIndex="5" Caption="Tipo Planilla" UnboundType="String" Width="200px"  /> 
        <dx:GridViewDataTextColumn FieldName="FECHA_INICIO" VisibleIndex="6" Caption="Fecha Inicio" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_FIN" VisibleIndex="7" Caption="Fecha Fin" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_PAGO_CADENA" VisibleIndex="8" Caption="Fecha Pago" UnboundType="String" >            
        </dx:GridViewDataTextColumn>
         <dx:GridViewDataTextColumn FieldName="FECHA_COMPROB_CADENA" VisibleIndex="8" Caption="Fecha Comprob." Width="120px"  UnboundType="String" >            
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CTACONTA_PLANI_CANA" VisibleIndex="8" Caption="Cta. Caña Azúcar" Width="120px" >            
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NO_ANTICIPO_CADENA" VisibleIndex="9" Caption="N° Anticipo" UnboundType="String" Width="80px"  />
        <dx:GridViewDataTextColumn FieldName="NO_ANTICIPO_LETRAS" VisibleIndex="10" Caption="N° Anticipo letras" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="VALOR_UNIT_PAGO_GEN" VisibleIndex="11" Caption="Valor Unitario Pago" UnboundType="Decimal" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00####################" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="12" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="13" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="14" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="15" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CONCEPTO" VisibleIndex="16" Caption="Concepto" />
       <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="17">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsListaPorZAFRA_TIPO_PLANILLA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA_TIPO_PLANILLA"  TypeName="SISPACAL.BL.cPLANILLA_BASE">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" DefaultValue="0" Type="Int32" />        
        <asp:Parameter Name="ID_TIPO_PLANILLA" DefaultValue="0" Type="Int32"  />        
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPLANILLA_BASE" DeleteMethod="EliminarPLANILLA_BASE" UpdateMethod="ActualizarPLANILLA_BASE"
    TypeName="SISPACAL.BL.cPLANILLA_BASE">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PLANILLA_BASE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="FECHA_PAGO" Type="DateTime" />
        <asp:Parameter Name="NO_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="NO_ANTICIPO_LETRAS" Type="String" />
        <asp:Parameter Name="VALOR_UNIT_PAGO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PLANILLA_BASE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="FECHA_PAGO" Type="DateTime" />
        <asp:Parameter Name="NO_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="NO_ANTICIPO_LETRAS" Type="String" />
        <asp:Parameter Name="VALOR_UNIT_PAGO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PLANILLA_BASE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorZAFRA" runat="server" 
    SelectMethod="ObtenerListaPorZAFRA" InsertMethod="AgregarPLANILLA_BASE" DeleteMethod="EliminarPLANILLA_BASE" UpdateMethod="ActualizarPLANILLA_BASE"
    TypeName="SISPACAL.BL.cPLANILLA_BASE">
    <SelectParameters>
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PLANILLA_BASE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="FECHA_PAGO" Type="DateTime" />
        <asp:Parameter Name="NO_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="NO_ANTICIPO_LETRAS" Type="String" />
        <asp:Parameter Name="VALOR_UNIT_PAGO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PLANILLA_BASE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="FECHA_PAGO" Type="DateTime" />
        <asp:Parameter Name="NO_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="NO_ANTICIPO_LETRAS" Type="String" />
        <asp:Parameter Name="VALOR_UNIT_PAGO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PLANILLA_BASE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_PLANILLA" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_PLANILLA" InsertMethod="AgregarPLANILLA_BASE" DeleteMethod="EliminarPLANILLA_BASE" UpdateMethod="ActualizarPLANILLA_BASE"
    TypeName="SISPACAL.BL.cPLANILLA_BASE">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PLANILLA_BASE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="FECHA_PAGO" Type="DateTime" />
        <asp:Parameter Name="NO_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="NO_ANTICIPO_LETRAS" Type="String" />
        <asp:Parameter Name="VALOR_UNIT_PAGO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PLANILLA_BASE" Type="Int32" />
        <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
        <asp:Parameter Name="ID_CATORCENA" Type="Int32" />
        <asp:Parameter Name="ID_TIPO_PLANILLA" Type="Int32" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="FECHA_PAGO" Type="DateTime" />
        <asp:Parameter Name="NO_ANTICIPO" Type="Int32" />
        <asp:Parameter Name="NO_ANTICIPO_LETRAS" Type="String" />
        <asp:Parameter Name="VALOR_UNIT_PAGO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="CONCEPTO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PLANILLA_BASE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
