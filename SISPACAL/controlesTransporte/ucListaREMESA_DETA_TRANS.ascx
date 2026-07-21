<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaREMESA_DETA_TRANS.ascx.vb" Inherits="controles_ucListaREMESA_DETA_TRANS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<script type="text/javascript">

    function CalcularValorTotal(s, e) {
        var total = speABONO_CAPITAL.GetValue() + speABONO_INTERES.GetValue() + speABONO_INTERES_IVA.GetValue();
        if (isNumber(total)) {
            lblTOTAL.SetValue(round(total, 2));
        }
        else
            lblTOTAL.SetValue(round(0, 0));
    }

    function round(value, exp) {
        if (typeof exp === 'undefined' || +exp === 0)
            return Math.round(value);

        value = +value;
        exp = +exp;

        if (isNaN(value) || !(typeof exp === 'number' && exp % 1 === 0))
            return NaN;

        // Shift
        value = value.toString().split('e');
        value = Math.round(+(value[0] + 'e' + (value[1] ? (+value[1] + exp) : exp)));

        // Shift back
        value = value.toString().split('e');
        return +(value[0] + 'e' + (value[1] ? (+value[1] - exp) : -exp));
    }
    function isNumber(n) {
        return !isNaN(parseFloat(n)) && isFinite(n);
    }

    function OnEndCallbackGrid(s, e) {
        cpMantREMESA_ENCA_TRANS.PerformCallback('');
    }
</script>


<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="ID_REMESA_DETA">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents EndCallback="OnEndCallbackGrid" RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" ButtonType="Image" VisibleIndex="0" Visible="False" Width="50px" Caption=" "  >             
            <EditButton Visible="False" Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" >
            <Image ToolTip="Editar" IconID="edit_edit_16x16"></Image>
            </EditButton>            
            <UpdateButton Visible="False" Image-ToolTip="Guardar" Image-IconID="save_save_16x16" >
            <Image ToolTip="Guardar" IconID="save_save_16x16"></Image>
            </UpdateButton>                     
            <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" >
            <Image ToolTip="Cancelar" IconID="history_undo_16x16"></Image>
            </CancelButton>    
        </dx:GridViewCommandColumn>          
        <dx:GridViewCommandColumn Name="Edicion2" ButtonType="Image" VisibleIndex="1" Visible="False" Width="50px" Caption=" "  >               
            <EditButton Visible="False" Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" >
            <Image ToolTip="Editar" IconID="edit_edit_16x16"></Image>
            </EditButton>            
            <UpdateButton Visible="False" Image-ToolTip="Guardar" Image-IconID="save_save_16x16" >
            <Image ToolTip="Guardar" IconID="save_save_16x16"></Image>
            </UpdateButton>                     
            <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" >
            <Image ToolTip="Cancelar" IconID="history_undo_16x16"></Image>
            </CancelButton>    
        </dx:GridViewCommandColumn>  
        <dx:GridViewDataTextColumn FieldName="ID_REMESA_DETA" ReadOnly="True" VisibleIndex="2" Caption="Id remesa deta" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_REMESA_ENCA" VisibleIndex="3" Caption="Id remesa enca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CREDITO_ENCA" VisibleIndex="4" Caption="Id credito enca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="UID_REMESA_DETA" VisibleIndex="5" Caption="Uid remesa deta" Visible="false" />
                <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="6" Caption="Zafra" UnboundType="String" HeaderStyle-Wrap="True" Width="70px" ReadOnly="true"  >
<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="DESCRIP_FINAN" VisibleIndex="7" Caption="Financiamiento" Width="200px"  UnboundType="String" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="DOCUMENTO" VisibleIndex="8" Caption="Tipo Docto." UnboundType="String" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="NO_DOCUMENTO" VisibleIndex="9" Caption="No. Docto" UnboundType="String" ReadOnly="true" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="10" Caption="Fecha" UnboundType="String" Width="80px" HeaderStyle-Wrap="True" ReadOnly="true"   >
<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_ULTMOVTO" VisibleIndex="11" Caption="Ultimo movto." UnboundType="String"  Width="80px" HeaderStyle-Wrap="True" ReadOnly="true" >
<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataSpinEditColumn FieldName="TASA_INTERES" VisibleIndex="12" Caption="Tasa Interes" Width="80px" HeaderStyle-Wrap="True" UnboundType="Decimal" ReadOnly="true"  >
             <PropertiesSpinEdit ClientInstanceName="speTASA_INTERES" DecimalPlaces="2" DisplayFormatString="#,##0.00" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>   
<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="SALDO" VisibleIndex="13" Caption="Saldo Capital" Width="80px" HeaderStyle-Wrap="True" UnboundType="Decimal" ReadOnly="true"  >
            <PropertiesSpinEdit ClientInstanceName="speSALDO" DecimalPlaces="2" DisplayFormatString="#,##0.00" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>                

<HeaderStyle Wrap="True"></HeaderStyle>

            <CellStyle HorizontalAlign="Right"></CellStyle>            
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="INTERES_PENDIENTE" VisibleIndex="14" Caption="Interes pendiente" Width="80px" HeaderStyle-Wrap="True" UnboundType="Decimal" ReadOnly="true" >
            <PropertiesSpinEdit ClientInstanceName="speINTERES_PENDIENTE" DecimalPlaces="2" DisplayFormatString="#,##0.00" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>                

<HeaderStyle Wrap="True"></HeaderStyle>

            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="INTERES_IVA_PENDIENTE" VisibleIndex="15" Caption="IVA Interes pendiente" Width="80px" HeaderStyle-Wrap="True" UnboundType="Decimal" ReadOnly="true"  >
            <PropertiesSpinEdit ClientInstanceName="speINTERES_IVA_PENDIENTE" DecimalPlaces="2" DisplayFormatString="#,##0.00" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>                
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>                

<HeaderStyle Wrap="True"></HeaderStyle>

            <CellStyle HorizontalAlign="Right"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
                
        <dx:GridViewDataSpinEditColumn FieldName="ABONO_CAPITAL" VisibleIndex="16" Caption="Abono Credito" Width="80px" CellStyle-HorizontalAlign="Right" >
            <PropertiesSpinEdit ClientInstanceName="speABONO_CAPITAL" DecimalPlaces="2" DisplayFormatString="#,##0.00" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right" BackColor="#FFFFCC"></Style>
            </PropertiesSpinEdit>                
            <CellStyle HorizontalAlign="Right" BackColor="#E0F1FC"></CellStyle>
        </dx:GridViewDataSpinEditColumn>       
                
        <dx:GridViewDataSpinEditColumn FieldName="ABONO_INTERES" VisibleIndex="17" Caption="Abono Interes" Width="80px" HeaderStyle-Wrap="True" CellStyle-HorizontalAlign="Right" >
            <PropertiesSpinEdit ClientInstanceName="speABONO_INTERES" DecimalPlaces="2" DisplayFormatString="#,##0.00" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right" BackColor="#FFFFCC"></Style>
            </PropertiesSpinEdit>  
            <HeaderStyle Wrap="True"></HeaderStyle>
            <CellStyle HorizontalAlign="Right" BackColor="#E0F1FC"></CellStyle>
        </dx:GridViewDataSpinEditColumn>

        <dx:GridViewDataSpinEditColumn FieldName="ABONO_INTERES_IVA" VisibleIndex="18" Caption="Abono IVA Interes" Width="80px" HeaderStyle-Wrap="True" CellStyle-HorizontalAlign="Right" >
            <PropertiesSpinEdit ClientInstanceName="speABONO_INTERES_IVA" DecimalPlaces="2" DisplayFormatString="#,##0.00" Style-HorizontalAlign="Right" ClientSideEvents-ValueChanged="CalcularValorTotal" SpinButtons-ShowIncrementButtons="false" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right" BackColor="#FFFFCC"></Style>
            </PropertiesSpinEdit>  
            <HeaderStyle Wrap="True"></HeaderStyle>
            <CellStyle HorizontalAlign="Right" BackColor="#E0F1FC"></CellStyle>
        </dx:GridViewDataSpinEditColumn>
        
       <dx:GridViewDataSpinEditColumn FieldName="TOTAL" VisibleIndex="19" ReadOnly="true" Caption="Total Abono" Width="80px" HeaderStyle-Wrap="True" CellStyle-HorizontalAlign="Right" >                        
            <PropertiesSpinEdit ClientInstanceName="lblTOTAL" DisplayFormatString="#,##0.00"  DecimalPlaces="2" runat="server" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="CalcularValorTotal"></ClientSideEvents>
                <Style HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>                      
            <HeaderStyle Wrap="True"></HeaderStyle>
            <CellStyle HorizontalAlign="Right" BackColor="#E0F1FC"></CellStyle>
        </dx:GridViewDataSpinEditColumn>

        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " Visible="false"  
            Name="Eliminar" VisibleIndex="20">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsREMESA_DETA_TRANScache" runat="server" TypeName="cREMESA_DETA_TRANScache"     
    SelectMethod="ObtenerLista" UpdateMethod="Actualizar">       
     <SelectParameters>             
        <asp:Parameter Name="nombreSesion_ucListaREMESA_DETA_TRANS" Type="String" />
     </SelectParameters>     
     <UpdateParameters>    
        <asp:Parameter Name="ID_REMESA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />      
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
        <asp:Parameter Name="REFERENCIA" Type="String" />                   
    </UpdateParameters> 
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarREMESA_DETA_TRANS" DeleteMethod="EliminarREMESA_DETA_TRANS" UpdateMethod="ActualizarREMESA_DETA_TRANS"
    TypeName="SISPACAL.BL.cREMESA_DETA_TRANS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REMESA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REMESA_DETA" Type="Object" />
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REMESA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REMESA_DETA" Type="Object" />
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REMESA_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorREMESA_ENCA_TRANS" runat="server" 
    SelectMethod="ObtenerListaPorREMESA_ENCA_TRANS" InsertMethod="AgregarREMESA_DETA_TRANS" DeleteMethod="EliminarREMESA_DETA_TRANS" UpdateMethod="ActualizarREMESA_DETA_TRANS"
    TypeName="SISPACAL.BL.cREMESA_DETA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REMESA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REMESA_DETA" Type="Object" />
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REMESA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REMESA_DETA" Type="Object" />
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REMESA_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCREDITO_ENCA_TRANS" runat="server" 
    SelectMethod="ObtenerListaPorCREDITO_ENCA_TRANS" InsertMethod="AgregarREMESA_DETA_TRANS" DeleteMethod="EliminarREMESA_DETA_TRANS" UpdateMethod="ActualizarREMESA_DETA_TRANS"
    TypeName="SISPACAL.BL.cREMESA_DETA_TRANS">
    <SelectParameters>
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_REMESA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REMESA_DETA" Type="Object" />
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_REMESA_DETA" Type="Int32" />
        <asp:Parameter Name="ID_REMESA_ENCA" Type="Int32" />
        <asp:Parameter Name="ID_CREDITO_ENCA" Type="Int32" />
        <asp:Parameter Name="UID_REMESA_DETA" Type="Object" />
        <asp:Parameter Name="ABONO_CAPITAL" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES" Type="Decimal" />
        <asp:Parameter Name="ABONO_INTERES_IVA" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_REMESA_DETA" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
