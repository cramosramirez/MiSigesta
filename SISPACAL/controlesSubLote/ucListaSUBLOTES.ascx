<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSUBLOTES.ascx.vb" Inherits="controlesSubLote_ucListaSUBLOTES" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<script type="text/javascript">
    function OnAllCheckedChanged(s, e) {        
        if (s.GetChecked())
            grid.SelectRows();
        else
            grid.UnselectRows();
    }

    function SeleccionFila(s, e) {
        if (s.cpVisibleCheckTodos)
            chkTodo.SetChecked(s.GetSelectedRowCount() == s.cpVisibleRowCount && s.cpVisibleRowCount > 0);
        if (s.cpPlanCosechaCallback)
            cpMantPLAN_COSECHA.PerformCallback('ObtenerSaldosLote');
    }
 
</script>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" ClientInstanceName="grid" KeyFieldName="ID_SUBLOTES" Width="100%" Theme="Moderno"   >
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents SelectionChanged="SeleccionFila" EndCallback="function(s, e){if(s.cpMensaje != null){ AsignarMensaje(s.cpMensaje); delete s.cpMensaje;}}" RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
              />
    <Columns>                 
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="Editar"  Caption="Editar" Width="50px"  CellStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/editar.png"  CommandArgument='<%# Bind("ID_SUBLOTES") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_SUBLOTES") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
         <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Width="10px" Visible="false" VisibleIndex="0">            
            <HeaderCaptionTemplate>
                <dx:ASPxCheckBox ID="chkTodo" ClientInstanceName="chkTodo" Visible="<%#GetCheckBoxVisible()%>" EnableViewState="true" OnInit="chkTodo_Init" runat="server" ToolTip="Seleccionar todas las porciones">                   
                    <ClientSideEvents CheckedChanged="OnAllCheckedChanged" />
                </dx:ASPxCheckBox>                
            </HeaderCaptionTemplate>            
        </dx:GridViewCommandColumn>

        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" Name="ACCESLOTE" UnboundType="String" VisibleIndex="1" Caption="Acceslote" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODILOTE" Name="CODILOTE" UnboundType="String" VisibleIndex="1" Caption="Cod. Lote contrato" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" Name="NOMBLOTE" UnboundType="String" VisibleIndex="1" Caption="Lote contrato" Visible="false"/>

        <dx:GridViewDataTextColumn FieldName="ID_MAESTRO" VisibleIndex="3" Caption="Id Maestro"  Width="100px" Visible="false"/>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_MAESTRO" UnboundType="String" VisibleIndex="4" Caption="Lote Maestro" Visible="false"/>   
         <dx:GridViewDataTextColumn FieldName="CODIGO" ReadOnly="True" VisibleIndex="2" Caption="Cod. Porcion" Width="100px" />
        <dx:GridViewDataTextColumn FieldName="CORRELATIVO" VisibleIndex="5" Caption="Correlativo" Width="80px"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PORCION" VisibleIndex="6" Caption="Nombre porción" />
        <dx:GridViewDataTextColumn FieldName="VARIEDAD" UnboundType="String" VisibleIndex="7" Caption="Variedad"/>
        <dx:GridViewDataTextColumn FieldName="TIPO_CANA" UnboundType="String" VisibleIndex="7" Caption="Tipo Caña"/>

        <dx:GridViewDataTextColumn FieldName="AREA_EFEC" VisibleIndex="8" Caption="ha Efectiva">
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TC_MZ_EFEC" VisibleIndex="8" Caption="TCH Efectiva">
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TC_EFEC" VisibleIndex="8" Caption="(t) Efectiva">
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>

        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" 
            Name="Eliminar" VisibleIndex="24">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-IconID="edit_delete_16x16">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
         </dx:GridViewCommandColumn>
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True" AllowSelectByRowClick="true" />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorMAESTRO_LOTES" TypeName="SISPACAL.BL.cSUBLOTES">
    <SelectParameters>
        <asp:Parameter Name="ID_MAESTRO" Type="Int32" />       
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaSUBLOTES_CONTRATADOS" runat="server" 
    SelectMethod="ObtenerListaSUBLOTES_CONTRATADOS" TypeName="SISPACAL.BL.cSUBLOTES">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="ID_ZAFRA_CONTRATO" Type="Int32" />          
    </SelectParameters>
</asp:ObjectDataSource>