<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_ANTICIPO_LIQFINAN.ascx.vb" Inherits="controlesFinanciero_ucListaSOLIC_ANTICIPO_LIQFINAN" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<script type="text/javascript">
    function ObtenerSaldo(s, e) {
        var saldo_ini;
        var abono;
        var saldo_fin;
        
        if (isNumber(spSALDO_INI.GetValue()))
            saldo_ini = round(SALDO_INI.GetValue(), 2) + round(spINTERES.GetValue(), 2) + round(spINTERES_IVA.GetValue(), 2);
        else
            saldo_ini = 0;        
        if (isNumber(spABONO.GetValue()))
            abono = round(spABONO.GetValue(), 2) + round(spINTERES_ABO.GetValue(), 2) + round(spINTERES_IVA_ABO.GetValue(), 2);
        else
            abono = 0;

        saldo_fin = saldo_ini - abono;

        if (isNumber(total)) {
            spSALDO_FIN.SetValue(round(saldo_fin, 2));
        }
        else
            spSALDO_FIN.SetValue(round(0, 0));
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
</script>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" EnableCallBacks="false"  Width="100%" KeyFieldName="ID_ANTI_LIQ">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager Mode="ShowAllRecords">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>        
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="30px" Visible="false" VisibleIndex="0">                         
        </dx:GridViewCommandColumn>   
        <dx:GridViewCommandColumn Name="Edicion2" ButtonType="Image" VisibleIndex="1" Visible="False" CellStyle-HorizontalAlign="Center" Width="40px" Caption=" "  >
                <NewButton Image-ToolTip="Agregar" Image-IconID="actions_new_16x16" >
                    <Image ToolTip="Agregar" IconID="actions_new_16x16"></Image>
                </NewButton>      
                <EditButton Image-ToolTip="Editar" Image-IconID="edit_edit_16x16" >
                    <Image ToolTip="Editar" IconID="edit_edit_16x16"></Image>
                </EditButton>            
                <UpdateButton Image-ToolTip="Guardar" Image-IconID="save_save_16x16" >
                    <Image ToolTip="Guardar" IconID="save_save_16x16"></Image>
                </UpdateButton>                     
                <CancelButton Image-ToolTip="Cancelar" Image-IconID="history_undo_16x16" >
                <Image ToolTip="Cancelar" IconID="history_undo_16x16"></Image>
                </CancelButton>    

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewCommandColumn>          
        <dx:GridViewDataTextColumn VisibleIndex="2" Name="colEditar" Width="30px" Visible="false" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar Financiamiento" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_ANTI_LIQ") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_ANTI_LIQ") %>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>  
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="Liquidar" Caption=" " Width="30px"  CellStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnLiquidar" runat="server" AlternateText="Liquidar" ToolTip="Liquidar" CommandName="Liquidar" ImageUrl="~/imagenes/cash.png"  CommandArgument='<%# Bind("ID_ANTI_LIQ")%>'></asp:ImageButton>                             
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>	
        <dx:GridViewDataTextColumn FieldName="ID_ANTI_LIQ" ReadOnly="True" VisibleIndex="1" Caption="Id." Width="50px"  Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="2" Caption="Zafra" Width="70px" UnboundType="String" HeaderStyle-HorizontalAlign="Center"  />
        <dx:GridViewDataTextColumn FieldName="FINANCIAMIENTO" VisibleIndex="3" Caption="Financiamiento" Width="150px" UnboundType="String" />   
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="4" Caption="Fecha" Width="80px" UnboundType="String" />  
        <dx:GridViewDataTextColumn FieldName="NO_COMPROB" VisibleIndex="5" Caption="No.Comprob" Width="80px" UnboundType="String" /> 

        <dx:GridViewDataTextColumn FieldName="SALDO_INI" HeaderStyle-HorizontalAlign="Center" VisibleIndex="6" Caption="Saldo a la fecha" Width="100px" HeaderStyle-Wrap="True" ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" ClientInstanceName="spSALDO_INI"></PropertiesTextEdit>
            <HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="INTERES" HeaderStyle-HorizontalAlign="Center" VisibleIndex="7" Caption="Interes" Width="80px" HeaderStyle-Wrap="True" ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" ClientInstanceName="spINTERES"></PropertiesTextEdit>
            <HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="INTERES_IVA" HeaderStyle-HorizontalAlign="Center" VisibleIndex="8" Caption="Interes IVA" Width="80px" HeaderStyle-Wrap="True" ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" ClientInstanceName="spINTERES_IVA"></PropertiesTextEdit>
            <HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
         <dx:GridViewDataTextColumn FieldName="SALDO_TOTAL" HeaderStyle-HorizontalAlign="Center" VisibleIndex="8" HeaderStyle-Font-Bold="true" CellStyle-BackColor="#ffe1e1"  Caption="Saldo Total" Width="80px" UnboundType="Decimal" HeaderStyle-Wrap="True" ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00"></PropertiesTextEdit>
            <HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        
        <dx:GridViewDataSpinEditColumn FieldName="ABONO" VisibleIndex="9" Caption="Abono" Width="70px">
            <PropertiesSpinEdit DisplayFormatString="#,##0.00" ClientInstanceName="spABONO" DecimalPlaces="2" ClientSideEvents-ValueChanged="ObtenerSaldo" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" >                          
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <ClientSideEvents ValueChanged="ObtenerSaldo"></ClientSideEvents>
                <Style HorizontalAlign="Right" BackColor="LightYellow"></Style>                
            </PropertiesSpinEdit>
            <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
            <CellStyle HorizontalAlign="Right"></CellStyle>   
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="INTERES_ABO" HeaderStyle-HorizontalAlign="Center" VisibleIndex="10" Caption="(Abono) Interes" Width="80px" HeaderStyle-Wrap="True" >
            <PropertiesSpinEdit DisplayFormatString="#,##0.00" ClientInstanceName="spINTERES_ABO">
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <Style HorizontalAlign="Right" BackColor="LightYellow"></Style>
            </PropertiesSpinEdit>
            <HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="INTERES_IVA_ABO" HeaderStyle-HorizontalAlign="Center" VisibleIndex="11" Caption="(Abono) Interes IVA" Width="80px" HeaderStyle-Wrap="True">
            <PropertiesSpinEdit DisplayFormatString="#,##0.00" ClientInstanceName="spINTERES_IVA_ABO">
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <Style HorizontalAlign="Right" BackColor="LightYellow"></Style>
            </PropertiesSpinEdit>
            <HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataTextColumn FieldName="SALDO_FIN" HeaderStyle-HorizontalAlign="Center" VisibleIndex="12" Caption="Nuevo Saldo" HeaderStyle-Font-Bold="true" Width="100px" HeaderStyle-Wrap="True" ReadOnly="true" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" ClientInstanceName="spSALDO_FIN" >                                          
                <ClientSideEvents ValueChanged="ObtenerSaldo"></ClientSideEvents>
                <Style HorizontalAlign="Right" BackColor="LightYellow"></Style>
            </PropertiesTextEdit>
            <HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>        
	   </Columns>    
    <SettingsEditing Mode="Inline" /> 
    <Settings VerticalScrollBarMode="Visible" VerticalScrollBarStyle="Standard" VerticalScrollableHeight="400"  ShowFilterRow="False"  ShowHeaderFilterButton="False" />
    <SettingsBehavior AllowFocusedRow="True"   />    
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsSOLIC_ANTICIPO_LIQFINANcache" runat="server" SelectMethod="ObtenerLista" UpdateMethod="Actualizar"
    TypeName="cSOLIC_ANTICIPO_LIQFINANcache">
    <SelectParameters>
        <asp:Parameter Name="nombreSesion_ucListaSOLIC_ANTICIPO_LIQFINAN" Type="String" />  
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ANTI_LIQ" Type="Int32" />                 
        <asp:Parameter Name="ABONO" Type="Decimal" />
        <asp:Parameter Name="INTERES_ABO" Type="Decimal" />
        <asp:Parameter Name="INTERES_IVA_ABO" Type="Decimal" />
        <asp:Parameter Name="SALDO_FIN" Type="Decimal" />       
        <asp:Parameter Name="UID_REFERENCIA" Type="String" />    
    </UpdateParameters>
</asp:ObjectDataSource>