<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPROYFIN_ING_LOTE.ascx.vb" Inherits="controles_ucListaPROYFIN_ING_LOTE" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<script type="text/javascript">
    function CalcularTC1(s, e) {
        var mz;
        var tc_mz;
        var total;

        if (isNumber(MZ1.GetValue()))
            mz = round(MZ1.GetValue(), 2);
        else
            mz = 0;

        if (isNumber(TC_MZ1.GetValue()))
            tc_mz = round(TC_MZ1.GetValue(), 2);
        else
            tc_mz = 0;

        total = mz * tc_mz;

        if (isNumber(total)) {            
            TC1.SetValue(round(total, 2));
            var lbs;
            lbs = REND1.GetValue() * TC1.GetValue();            
            LBS1.SetValue(lbs);
        }
        else
            TC1.SetValue(round(0, 0));            
    }

    function CalcularTC2(s, e) {
        var mz;
        var tc_mz;
        var total;

        if (isNumber(MZ2.GetValue()))
            mz = round(MZ2.GetValue(), 2);
        else
            mz = 0;

        if (isNumber(TC_MZ2.GetValue()))
            tc_mz = round(TC_MZ2.GetValue(), 2);
        else
            tc_mz = 0;

        total = mz * tc_mz;

        if (isNumber(total)) {
            TC2.SetValue(round(total, 2));
            var lbs;
            lbs = REND2.GetValue() * TC2.GetValue();
            LBS2.SetValue(lbs);
        }
        else
            TC2.SetValue(round(0, 0));
    }

    function CalcularTC3(s, e) {
        var mz;
        var tc_mz;
        var total;

        if (isNumber(MZ3.GetValue()))
            mz = round(MZ3.GetValue(), 2);
        else
            mz = 0;

        if (isNumber(TC_MZ3.GetValue()))
            tc_mz = round(TC_MZ3.GetValue(), 2);
        else
            tc_mz = 0;

        total = mz * tc_mz;

        if (isNumber(total)) {
            TC3.SetValue(round(total, 2));
            var lbs;
            lbs = REND3.GetValue() * TC3.GetValue();
            LBS3.SetValue(lbs);
        }
        else
            TC3.SetValue(round(0, 0));
    }

    function CalcularTC4(s, e) {
        var mz;
        var tc_mz;
        var total;

        if (isNumber(MZ4.GetValue()))
            mz = round(MZ4.GetValue(), 2);
        else
            mz = 0;

        if (isNumber(TC_MZ4.GetValue()))
            tc_mz = round(TC_MZ4.GetValue(), 2);
        else
            tc_mz = 0;

        total = mz * tc_mz;

        if (isNumber(total)) {
            TC4.SetValue(round(total, 2));
            var lbs;
            lbs = REND4.GetValue() * TC4.GetValue();
            LBS4.SetValue(lbs);
        }
        else
            TC4.SetValue(round(0, 0));
    }

    function CalcularTC5(s, e) {
        var mz;
        var tc_mz;
        var total;

        if (isNumber(MZ5.GetValue()))
            mz = round(MZ5.GetValue(), 2);
        else
            mz = 0;

        if (isNumber(TC_MZ5.GetValue()))
            tc_mz = round(TC_MZ5.GetValue(), 2);
        else
            tc_mz = 0;

        total = mz * tc_mz;

        if (isNumber(total)) {
            TC5.SetValue(round(total, 2));
            var lbs;
            lbs = REND5.GetValue() * TC5.GetValue();
            LBS5.SetValue(lbs);
        }
        else
            TC5.SetValue(round(0, 0));
    }

    function CalcularTC6(s, e) {
        var mz;
        var tc_mz;
        var total;

        if (isNumber(MZ6.GetValue()))
            mz = round(MZ6.GetValue(), 2);
        else
            mz = 0;

        if (isNumber(TC_MZ6.GetValue()))
            tc_mz = round(TC_MZ6.GetValue(), 2);
        else
            tc_mz = 0;

        total = mz * tc_mz;

        if (isNumber(total)) {
            TC6.SetValue(round(total, 2));
            var lbs;
            lbs = REND6.GetValue() * TC6.GetValue();
            LBS6.SetValue(lbs);
        }
        else
            TC6.SetValue(round(0, 0));
    }

    function CalcularTC7(s, e) {
        var mz;
        var tc_mz;
        var total;

        if (isNumber(MZ7.GetValue()))
            mz = round(MZ7.GetValue(), 2);
        else
            mz = 0;

        if (isNumber(TC_MZ7.GetValue()))
            tc_mz = round(TC_MZ7.GetValue(), 2);
        else
            tc_mz = 0;

        total = mz * tc_mz;

        if (isNumber(total)) {
            TC7.SetValue(round(total, 2));
            var lbs;
            lbs = REND7.GetValue() * TC7.GetValue();
            LBS7.SetValue(lbs);
        }
        else
            TC7.SetValue(round(0, 0));
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

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  DataSourceID="odsLista" KeyFieldName="ID_PROYFIN_ING_LOTE" Theme="Metropolis">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager PageSize="15">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />    
    <Columns>
        <dx:GridViewBandColumn Name="G0" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" Caption="LOTE" FixedStyle="Left" >
            <Columns>
         <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="CheckSeleccionar" Caption=" " Width="30px" Visible="false" VisibleIndex="0" FixedStyle="Left">                         
        </dx:GridViewCommandColumn>   
        <dx:GridViewCommandColumn Name="Edicion2" ButtonType="Image" VisibleIndex="0" CellStyle-HorizontalAlign="Center" Width="30px" Caption=" " FixedStyle="Left"  >
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
        </dx:GridViewCommandColumn>          
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="colEditar" Width="30px" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar proyección" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_PROYFIN_ING_LOTE") %>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandArgument='<%# Bind("ID_PROYFIN_ING_LOTE")%>' CommandName="Seleccionar" Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>           
        <dx:GridViewDataTextColumn FieldName="ID_PROYFIN_ING_LOTE" ReadOnly="True" VisibleIndex="2" Caption="Id proyfin ing lote" Width="50px" Visible="false" >           
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PROYFIN_ING" VisibleIndex="3" Caption="Id proyfin ing" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ACCESLOTE" VisibleIndex="4" Caption="Acceslote" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CODILOTE" VisibleIndex="4" Caption="Cod." UnboundType="String" Width="30px" HeaderStyle-Font-Bold="true" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" FixedStyle="Left"  />
        <dx:GridViewDataTextColumn FieldName="NOMBLOTE" VisibleIndex="4" Caption="Lote" UnboundType="String" Width="150px" HeaderStyle-Font-Bold="true" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" FixedStyle="Left"  />
        <dx:GridViewDataTextColumn FieldName="NO_CONTRATO" VisibleIndex="5" Caption="Contrato" Width="60px"  HeaderStyle-Font-Bold="true" HeaderStyle-Wrap="True" ReadOnly="true" SortIndex="0" SortOrder="Ascending" FixedStyle="Left"    />
        <dx:GridViewDataTextColumn FieldName="CICLO" VisibleIndex="6" Caption="Ciclo" Width="50px" HeaderStyle-Font-Bold="true" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" FixedStyle="Left" />
                </Columns>
        </dx:GridViewBandColumn>
        <dx:GridViewBandColumn Name="G1" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" Caption=" " >
            <Columns>
                <dx:GridViewDataSpinEditColumn FieldName="CICLO1" VisibleIndex="7" Caption="Ciclo" Width="50px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                    <PropertiesSpinEdit SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    <CellStyle HorizontalAlign="Right"></CellStyle>
                </dx:GridViewDataSpinEditColumn>
                <dx:GridViewDataSpinEditColumn FieldName="MZ1" VisibleIndex="8" Caption="MZ" Width="60px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                    <PropertiesSpinEdit SpinButtons-ShowIncrementButtons="false" ClientInstanceName="MZ1"  Style-HorizontalAlign="Right" Style-BackColor="LightYellow" ClientSideEvents-ValueChanged="CalcularTC1" />                          
                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    <CellStyle HorizontalAlign="Right"></CellStyle>            
                </dx:GridViewDataSpinEditColumn>
                <dx:GridViewDataSpinEditColumn FieldName="TC_MZ1" VisibleIndex="9" Caption="TC/MZ" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                    <PropertiesSpinEdit SpinButtons-ShowIncrementButtons="false" ClientInstanceName="TC_MZ1" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" ClientSideEvents-ValueChanged="CalcularTC1" />                          
                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    <CellStyle HorizontalAlign="Right"></CellStyle>
                </dx:GridViewDataSpinEditColumn>
                <dx:GridViewDataTextColumn FieldName="TC1" VisibleIndex="10" Caption="Total TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                    <PropertiesTextEdit DisplayFormatString="#,##0.00" ClientInstanceName="TC1" />            
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataSpinEditColumn FieldName="REND1" VisibleIndex="11" Caption="Lbs/TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                    <PropertiesSpinEdit ClientInstanceName="REND1" ClientSideEvents-ValueChanged="CalcularTC1" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    <CellStyle HorizontalAlign="Right"></CellStyle>
                </dx:GridViewDataSpinEditColumn>
                <dx:GridViewDataTextColumn FieldName="LBS1" VisibleIndex="12" Caption="Total Lbs" Width="90px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                    <PropertiesTextEdit ClientInstanceName="LBS1" DisplayFormatString="#,##0.00" />
                </dx:GridViewDataTextColumn>
            </Columns>
        </dx:GridViewBandColumn>
        
        <dx:GridViewBandColumn Name="G2" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" Caption=" " >
            <Columns>
            <dx:GridViewDataSpinEditColumn FieldName="CICLO2" VisibleIndex="13" Caption="Ciclo" Width="50px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
             <PropertiesSpinEdit SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="MZ2" VisibleIndex="14" Caption="MZ" Width="60px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="MZ2" ClientSideEvents-ValueChanged="CalcularTC2" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="TC_MZ2" VisibleIndex="15" Caption="TC/MZ" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="TC_MZ2" ClientSideEvents-ValueChanged="CalcularTC2" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="TC2" VisibleIndex="16" Caption="Total TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="TC2" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataSpinEditColumn FieldName="REND2" VisibleIndex="17" Caption="Lbs/TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="REND2" ClientSideEvents-ValueChanged="CalcularTC2" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="LBS2" VisibleIndex="18" Caption="Total Lbs" Width="90px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="LBS2" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
            </Columns> 
        </dx:GridViewBandColumn>

        <dx:GridViewBandColumn Name="G3" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true"  Caption=" " >
            <Columns>
            <dx:GridViewDataSpinEditColumn FieldName="CICLO3" VisibleIndex="19" Caption="Ciclo" Width="50px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="MZ3" VisibleIndex="20" Caption="MZ" Width="60px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="MZ3" ClientSideEvents-ValueChanged="CalcularTC3" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="TC_MZ3" VisibleIndex="21" Caption="TC/MZ" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="TC_MZ3" ClientSideEvents-ValueChanged="CalcularTC3" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="TC3" VisibleIndex="22" Caption="Total TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesTextEdit ClientInstanceName="TC3" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataSpinEditColumn FieldName="REND3" VisibleIndex="23" Caption="Lbs/TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesSpinEdit ClientInstanceName="REND3" ClientSideEvents-ValueChanged="CalcularTC3" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="LBS3" VisibleIndex="24" Caption="Total Lbs" Width="90px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="LBS3" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
            </Columns>
          </dx:GridViewBandColumn>  

        <dx:GridViewBandColumn Name="G4" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true"  Caption=" " >
            <Columns>
            <dx:GridViewDataSpinEditColumn FieldName="CICLO4" VisibleIndex="25" Caption="Ciclo" Width="50px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="MZ4" VisibleIndex="26" Caption="MZ" Width="60px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                 <PropertiesSpinEdit ClientInstanceName="MZ4" ClientSideEvents-ValueChanged="CalcularTC4" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="TC_MZ4" VisibleIndex="27" Caption="TC/MZ" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="TC_MZ4" ClientSideEvents-ValueChanged="CalcularTC4" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="TC4" VisibleIndex="28" Caption="Total TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="TC4" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataSpinEditColumn FieldName="REND4" VisibleIndex="29" Caption="Lbs/TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="REND4" ClientSideEvents-ValueChanged="CalcularTC4" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="LBS4" VisibleIndex="30" Caption="Total Lbs" Width="90px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="LBS4" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
            </Columns>
          </dx:GridViewBandColumn> 

        <dx:GridViewBandColumn Name="G5" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true"  Caption=" " >
            <Columns>
            <dx:GridViewDataSpinEditColumn FieldName="CICLO5" VisibleIndex="31" Caption="Ciclo" Width="50px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="MZ5" VisibleIndex="32" Caption="MZ" Width="60px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="MZ5" ClientSideEvents-ValueChanged="CalcularTC5" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="TC_MZ5" VisibleIndex="33" Caption="TC/MZ" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="TC_MZ5" ClientSideEvents-ValueChanged="CalcularTC5" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="TC5" VisibleIndex="34" Caption="Total TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="TC5" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataSpinEditColumn FieldName="REND5" VisibleIndex="35" Caption="Lbs/TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="REND5" ClientSideEvents-ValueChanged="CalcularTC5" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="LBS5" VisibleIndex="36" Caption="Total Lbs" Width="90px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="LBS5" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
            </Columns>
        </dx:GridViewBandColumn> 

        <dx:GridViewBandColumn Name="G6" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true"  Caption=" " >
            <Columns>
            <dx:GridViewDataSpinEditColumn FieldName="CICLO6" VisibleIndex="37" Caption="Ciclo" Width="50px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="MZ6" VisibleIndex="38" Caption="MZ" Width="60px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center"  >
                 <PropertiesSpinEdit ClientInstanceName="MZ6" ClientSideEvents-ValueChanged="CalcularTC6" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="TC_MZ6" VisibleIndex="39" Caption="TC/MZ" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                 <PropertiesSpinEdit ClientInstanceName="TC_MZ6" ClientSideEvents-ValueChanged="CalcularTC6" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="TC6" VisibleIndex="40" Caption="Total TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="TC6" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataSpinEditColumn FieldName="REND6" VisibleIndex="41" Caption="Lbs/TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                 <PropertiesSpinEdit ClientInstanceName="REND6" ClientSideEvents-ValueChanged="CalcularTC6" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="LBS6" VisibleIndex="42" Caption="Total Lbs" Width="90px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="LBS6" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
        </Columns>
        </dx:GridViewBandColumn> 

        <dx:GridViewBandColumn Name="G7" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true"  Caption=" " >
            <Columns>
            <dx:GridViewDataSpinEditColumn FieldName="CICLO7" VisibleIndex="43" Caption="Ciclo" Width="50px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="MZ7" VisibleIndex="44" Caption="MZ" Width="60px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="MZ7" ClientSideEvents-ValueChanged="CalcularTC7" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataSpinEditColumn FieldName="TC_MZ7" VisibleIndex="45" Caption="TC/MZ" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="TC_MZ7" ClientSideEvents-ValueChanged="CalcularTC7" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="TC7" VisibleIndex="46" Caption="Total TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="TC7" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataSpinEditColumn FieldName="REND7" VisibleIndex="47" Caption="Lbs/TC" Width="70px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
                <PropertiesSpinEdit ClientInstanceName="REND7" ClientSideEvents-ValueChanged="CalcularTC7" SpinButtons-ShowIncrementButtons="false" Style-HorizontalAlign="Right" Style-BackColor="LightYellow" />                          
                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                <CellStyle HorizontalAlign="Right"></CellStyle>
            </dx:GridViewDataSpinEditColumn>
            <dx:GridViewDataTextColumn FieldName="LBS7" VisibleIndex="48" Caption="Total Lbs" Width="90px" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" >
                <PropertiesTextEdit ClientInstanceName="LBS7" DisplayFormatString="#,##0.00" />
            </dx:GridViewDataTextColumn>
        </Columns>
        </dx:GridViewBandColumn> 
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="49">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text=" " Image-ToolTip="Eliminar" Image-IconID="edit_delete_16x16">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFooter="true" />
        <TotalSummary>
            <dx:ASPxSummaryItem FieldName="MZ1" SummaryType="Sum" DisplayFormat="{0}" />
            <dx:ASPxSummaryItem FieldName="MZ2" SummaryType="Sum" DisplayFormat="{0}" />
            <dx:ASPxSummaryItem FieldName="MZ3" SummaryType="Sum" DisplayFormat="{0}" />
            <dx:ASPxSummaryItem FieldName="MZ4" SummaryType="Sum" DisplayFormat="{0}" />
            <dx:ASPxSummaryItem FieldName="MZ5" SummaryType="Sum" DisplayFormat="{0}" />
            <dx:ASPxSummaryItem FieldName="MZ6" SummaryType="Sum" DisplayFormat="{0}" />
            <dx:ASPxSummaryItem FieldName="MZ7" SummaryType="Sum" DisplayFormat="{0}" />

            <dx:ASPxSummaryItem FieldName="TC1" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="TC2" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="TC3" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="TC4" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="TC5" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="TC6" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="TC7" SummaryType="Sum" DisplayFormat="{0:n2}" />

            <dx:ASPxSummaryItem FieldName="REND1" SummaryType="Custom" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="REND2" SummaryType="Custom" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="REND3" SummaryType="Custom" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="REND4" SummaryType="Custom" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="REND5" SummaryType="Custom" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="REND6" SummaryType="Custom" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="REND7" SummaryType="Custom" DisplayFormat="{0:n2}" />
                        
            <dx:ASPxSummaryItem FieldName="LBS1" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="LBS2" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="LBS3" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="LBS4" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="LBS5" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="LBS6" SummaryType="Sum" DisplayFormat="{0:n2}" />
            <dx:ASPxSummaryItem FieldName="LBS7" SummaryType="Sum" DisplayFormat="{0:n2}" />

            <dx:ASPxSummaryItem FieldName="LBS1" SummaryType="Custom" DisplayFormat="Valor: {0:c}" />
            <dx:ASPxSummaryItem FieldName="LBS2" SummaryType="Custom" DisplayFormat="Valor: {0:c}" />
            <dx:ASPxSummaryItem FieldName="LBS3" SummaryType="Custom" DisplayFormat="Valor: {0:c}" />
            <dx:ASPxSummaryItem FieldName="LBS4" SummaryType="Custom" DisplayFormat="Valor: {0:c}" />
            <dx:ASPxSummaryItem FieldName="LBS5" SummaryType="Custom" DisplayFormat="Valor: {0:c}" />
            <dx:ASPxSummaryItem FieldName="LBS6" SummaryType="Custom" DisplayFormat="Valor: {0:c}" />
            <dx:ASPxSummaryItem FieldName="LBS7" SummaryType="Custom" DisplayFormat="Valor: {0:c}" />

        </TotalSummary>
    <SettingsEditing Mode="Inline" /> 
    <Settings VerticalScrollBarMode="Visible" HorizontalScrollBarMode="Visible" VerticalScrollBarStyle="Standard" VerticalScrollableHeight="550" ShowFilterRow="False"  ShowHeaderFilterButton="False" />    
    <SettingsBehavior AllowFocusedRow="True" />     
</dx:ASPxGridView>

<dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="dxgvLista"></dx:ASPxGridViewExporter>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPROYFIN_ING_LOTE" DeleteMethod="EliminarPROYFIN_ING_LOTE" UpdateMethod="ActualizarPROYFIN_ING_LOTE"
    TypeName="SISPACAL.BL.cPROYFIN_ING_LOTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROYFIN_ING_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="CICLO" Type="Int32" />
        <asp:Parameter Name="CICLO1" Type="Int32" />
        <asp:Parameter Name="MZ1" Type="Decimal" />
        <asp:Parameter Name="TC_MZ1" Type="Decimal" />
        <asp:Parameter Name="TC1" Type="Decimal" />
        <asp:Parameter Name="REND1" Type="Decimal" />
        <asp:Parameter Name="LBS1" Type="Decimal" />
        <asp:Parameter Name="CICLO2" Type="Int32" />
        <asp:Parameter Name="MZ2" Type="Decimal" />
        <asp:Parameter Name="TC_MZ2" Type="Decimal" />
        <asp:Parameter Name="TC2" Type="Decimal" />
        <asp:Parameter Name="REND2" Type="Decimal" />
        <asp:Parameter Name="LBS2" Type="Decimal" />
        <asp:Parameter Name="CICLO3" Type="Int32" />
        <asp:Parameter Name="MZ3" Type="Decimal" />
        <asp:Parameter Name="TC_MZ3" Type="Decimal" />
        <asp:Parameter Name="TC3" Type="Decimal" />
        <asp:Parameter Name="REND3" Type="Decimal" />
        <asp:Parameter Name="LBS3" Type="Decimal" />
        <asp:Parameter Name="CICLO4" Type="Int32" />
        <asp:Parameter Name="MZ4" Type="Decimal" />
        <asp:Parameter Name="TC_MZ4" Type="Decimal" />
        <asp:Parameter Name="TC4" Type="Decimal" />
        <asp:Parameter Name="REND4" Type="Decimal" />
        <asp:Parameter Name="LBS4" Type="Decimal" />
        <asp:Parameter Name="CICLO5" Type="Int32" />
        <asp:Parameter Name="MZ5" Type="Decimal" />
        <asp:Parameter Name="TC_MZ5" Type="Decimal" />
        <asp:Parameter Name="TC5" Type="Decimal" />
        <asp:Parameter Name="REND5" Type="Decimal" />
        <asp:Parameter Name="LBS5" Type="Decimal" />
        <asp:Parameter Name="CICLO6" Type="Int32" />
        <asp:Parameter Name="MZ6" Type="Decimal" />
        <asp:Parameter Name="TC_MZ6" Type="Decimal" />
        <asp:Parameter Name="TC6" Type="Decimal" />
        <asp:Parameter Name="REND6" Type="Decimal" />
        <asp:Parameter Name="LBS6" Type="Decimal" />
        <asp:Parameter Name="CICLO7" Type="Int32" />
        <asp:Parameter Name="MZ7" Type="Decimal" />
        <asp:Parameter Name="TC_MZ7" Type="Decimal" />
        <asp:Parameter Name="TC7" Type="Decimal" />
        <asp:Parameter Name="REND7" Type="Decimal" />
        <asp:Parameter Name="LBS7" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROYFIN_ING_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="CICLO" Type="Int32" />
        <asp:Parameter Name="CICLO1" Type="Int32" />
        <asp:Parameter Name="MZ1" Type="Decimal" />
        <asp:Parameter Name="TC_MZ1" Type="Decimal" />
        <asp:Parameter Name="TC1" Type="Decimal" />
        <asp:Parameter Name="REND1" Type="Decimal" />
        <asp:Parameter Name="LBS1" Type="Decimal" />
        <asp:Parameter Name="CICLO2" Type="Int32" />
        <asp:Parameter Name="MZ2" Type="Decimal" />
        <asp:Parameter Name="TC_MZ2" Type="Decimal" />
        <asp:Parameter Name="TC2" Type="Decimal" />
        <asp:Parameter Name="REND2" Type="Decimal" />
        <asp:Parameter Name="LBS2" Type="Decimal" />
        <asp:Parameter Name="CICLO3" Type="Int32" />
        <asp:Parameter Name="MZ3" Type="Decimal" />
        <asp:Parameter Name="TC_MZ3" Type="Decimal" />
        <asp:Parameter Name="TC3" Type="Decimal" />
        <asp:Parameter Name="REND3" Type="Decimal" />
        <asp:Parameter Name="LBS3" Type="Decimal" />
        <asp:Parameter Name="CICLO4" Type="Int32" />
        <asp:Parameter Name="MZ4" Type="Decimal" />
        <asp:Parameter Name="TC_MZ4" Type="Decimal" />
        <asp:Parameter Name="TC4" Type="Decimal" />
        <asp:Parameter Name="REND4" Type="Decimal" />
        <asp:Parameter Name="LBS4" Type="Decimal" />
        <asp:Parameter Name="CICLO5" Type="Int32" />
        <asp:Parameter Name="MZ5" Type="Decimal" />
        <asp:Parameter Name="TC_MZ5" Type="Decimal" />
        <asp:Parameter Name="TC5" Type="Decimal" />
        <asp:Parameter Name="REND5" Type="Decimal" />
        <asp:Parameter Name="LBS5" Type="Decimal" />
        <asp:Parameter Name="CICLO6" Type="Int32" />
        <asp:Parameter Name="MZ6" Type="Decimal" />
        <asp:Parameter Name="TC_MZ6" Type="Decimal" />
        <asp:Parameter Name="TC6" Type="Decimal" />
        <asp:Parameter Name="REND6" Type="Decimal" />
        <asp:Parameter Name="LBS6" Type="Decimal" />
        <asp:Parameter Name="CICLO7" Type="Int32" />
        <asp:Parameter Name="MZ7" Type="Decimal" />
        <asp:Parameter Name="TC_MZ7" Type="Decimal" />
        <asp:Parameter Name="TC7" Type="Decimal" />
        <asp:Parameter Name="REND7" Type="Decimal" />
        <asp:Parameter Name="LBS7" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROYFIN_ING_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROYFIN_ING" runat="server" 
    SelectMethod="ObtenerListaPorPROYFIN_ING" InsertMethod="AgregarPROYFIN_ING_LOTE" DeleteMethod="EliminarPROYFIN_ING_LOTE" UpdateMethod="ActualizarPROYFIN_ING_LOTE"
    TypeName="SISPACAL.BL.cPROYFIN_ING_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROYFIN_ING_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="CICLO" Type="Int32" />
        <asp:Parameter Name="CICLO1" Type="Int32" />
        <asp:Parameter Name="MZ1" Type="Decimal" />
        <asp:Parameter Name="TC_MZ1" Type="Decimal" />
        <asp:Parameter Name="TC1" Type="Decimal" />
        <asp:Parameter Name="REND1" Type="Decimal" />
        <asp:Parameter Name="LBS1" Type="Decimal" />
        <asp:Parameter Name="CICLO2" Type="Int32" />
        <asp:Parameter Name="MZ2" Type="Decimal" />
        <asp:Parameter Name="TC_MZ2" Type="Decimal" />
        <asp:Parameter Name="TC2" Type="Decimal" />
        <asp:Parameter Name="REND2" Type="Decimal" />
        <asp:Parameter Name="LBS2" Type="Decimal" />
        <asp:Parameter Name="CICLO3" Type="Int32" />
        <asp:Parameter Name="MZ3" Type="Decimal" />
        <asp:Parameter Name="TC_MZ3" Type="Decimal" />
        <asp:Parameter Name="TC3" Type="Decimal" />
        <asp:Parameter Name="REND3" Type="Decimal" />
        <asp:Parameter Name="LBS3" Type="Decimal" />
        <asp:Parameter Name="CICLO4" Type="Int32" />
        <asp:Parameter Name="MZ4" Type="Decimal" />
        <asp:Parameter Name="TC_MZ4" Type="Decimal" />
        <asp:Parameter Name="TC4" Type="Decimal" />
        <asp:Parameter Name="REND4" Type="Decimal" />
        <asp:Parameter Name="LBS4" Type="Decimal" />
        <asp:Parameter Name="CICLO5" Type="Int32" />
        <asp:Parameter Name="MZ5" Type="Decimal" />
        <asp:Parameter Name="TC_MZ5" Type="Decimal" />
        <asp:Parameter Name="TC5" Type="Decimal" />
        <asp:Parameter Name="REND5" Type="Decimal" />
        <asp:Parameter Name="LBS5" Type="Decimal" />
        <asp:Parameter Name="CICLO6" Type="Int32" />
        <asp:Parameter Name="MZ6" Type="Decimal" />
        <asp:Parameter Name="TC_MZ6" Type="Decimal" />
        <asp:Parameter Name="TC6" Type="Decimal" />
        <asp:Parameter Name="REND6" Type="Decimal" />
        <asp:Parameter Name="LBS6" Type="Decimal" />
        <asp:Parameter Name="CICLO7" Type="Int32" />
        <asp:Parameter Name="MZ7" Type="Decimal" />
        <asp:Parameter Name="TC_MZ7" Type="Decimal" />
        <asp:Parameter Name="TC7" Type="Decimal" />
        <asp:Parameter Name="REND7" Type="Decimal" />
        <asp:Parameter Name="LBS7" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROYFIN_ING_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="CICLO" Type="Int32" />
        <asp:Parameter Name="CICLO1" Type="Int32" />
        <asp:Parameter Name="MZ1" Type="Decimal" />
        <asp:Parameter Name="TC_MZ1" Type="Decimal" />
        <asp:Parameter Name="TC1" Type="Decimal" />
        <asp:Parameter Name="REND1" Type="Decimal" />
        <asp:Parameter Name="LBS1" Type="Decimal" />
        <asp:Parameter Name="CICLO2" Type="Int32" />
        <asp:Parameter Name="MZ2" Type="Decimal" />
        <asp:Parameter Name="TC_MZ2" Type="Decimal" />
        <asp:Parameter Name="TC2" Type="Decimal" />
        <asp:Parameter Name="REND2" Type="Decimal" />
        <asp:Parameter Name="LBS2" Type="Decimal" />
        <asp:Parameter Name="CICLO3" Type="Int32" />
        <asp:Parameter Name="MZ3" Type="Decimal" />
        <asp:Parameter Name="TC_MZ3" Type="Decimal" />
        <asp:Parameter Name="TC3" Type="Decimal" />
        <asp:Parameter Name="REND3" Type="Decimal" />
        <asp:Parameter Name="LBS3" Type="Decimal" />
        <asp:Parameter Name="CICLO4" Type="Int32" />
        <asp:Parameter Name="MZ4" Type="Decimal" />
        <asp:Parameter Name="TC_MZ4" Type="Decimal" />
        <asp:Parameter Name="TC4" Type="Decimal" />
        <asp:Parameter Name="REND4" Type="Decimal" />
        <asp:Parameter Name="LBS4" Type="Decimal" />
        <asp:Parameter Name="CICLO5" Type="Int32" />
        <asp:Parameter Name="MZ5" Type="Decimal" />
        <asp:Parameter Name="TC_MZ5" Type="Decimal" />
        <asp:Parameter Name="TC5" Type="Decimal" />
        <asp:Parameter Name="REND5" Type="Decimal" />
        <asp:Parameter Name="LBS5" Type="Decimal" />
        <asp:Parameter Name="CICLO6" Type="Int32" />
        <asp:Parameter Name="MZ6" Type="Decimal" />
        <asp:Parameter Name="TC_MZ6" Type="Decimal" />
        <asp:Parameter Name="TC6" Type="Decimal" />
        <asp:Parameter Name="REND6" Type="Decimal" />
        <asp:Parameter Name="LBS6" Type="Decimal" />
        <asp:Parameter Name="CICLO7" Type="Int32" />
        <asp:Parameter Name="MZ7" Type="Decimal" />
        <asp:Parameter Name="TC_MZ7" Type="Decimal" />
        <asp:Parameter Name="TC7" Type="Decimal" />
        <asp:Parameter Name="REND7" Type="Decimal" />
        <asp:Parameter Name="LBS7" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROYFIN_ING_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorLOTES" runat="server" 
    SelectMethod="ObtenerListaPorLOTES" InsertMethod="AgregarPROYFIN_ING_LOTE" DeleteMethod="EliminarPROYFIN_ING_LOTE" UpdateMethod="ActualizarPROYFIN_ING_LOTE"
    TypeName="SISPACAL.BL.cPROYFIN_ING_LOTE">
    <SelectParameters>
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROYFIN_ING_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="CICLO" Type="Int32" />
        <asp:Parameter Name="CICLO1" Type="Int32" />
        <asp:Parameter Name="MZ1" Type="Decimal" />
        <asp:Parameter Name="TC_MZ1" Type="Decimal" />
        <asp:Parameter Name="TC1" Type="Decimal" />
        <asp:Parameter Name="REND1" Type="Decimal" />
        <asp:Parameter Name="LBS1" Type="Decimal" />
        <asp:Parameter Name="CICLO2" Type="Int32" />
        <asp:Parameter Name="MZ2" Type="Decimal" />
        <asp:Parameter Name="TC_MZ2" Type="Decimal" />
        <asp:Parameter Name="TC2" Type="Decimal" />
        <asp:Parameter Name="REND2" Type="Decimal" />
        <asp:Parameter Name="LBS2" Type="Decimal" />
        <asp:Parameter Name="CICLO3" Type="Int32" />
        <asp:Parameter Name="MZ3" Type="Decimal" />
        <asp:Parameter Name="TC_MZ3" Type="Decimal" />
        <asp:Parameter Name="TC3" Type="Decimal" />
        <asp:Parameter Name="REND3" Type="Decimal" />
        <asp:Parameter Name="LBS3" Type="Decimal" />
        <asp:Parameter Name="CICLO4" Type="Int32" />
        <asp:Parameter Name="MZ4" Type="Decimal" />
        <asp:Parameter Name="TC_MZ4" Type="Decimal" />
        <asp:Parameter Name="TC4" Type="Decimal" />
        <asp:Parameter Name="REND4" Type="Decimal" />
        <asp:Parameter Name="LBS4" Type="Decimal" />
        <asp:Parameter Name="CICLO5" Type="Int32" />
        <asp:Parameter Name="MZ5" Type="Decimal" />
        <asp:Parameter Name="TC_MZ5" Type="Decimal" />
        <asp:Parameter Name="TC5" Type="Decimal" />
        <asp:Parameter Name="REND5" Type="Decimal" />
        <asp:Parameter Name="LBS5" Type="Decimal" />
        <asp:Parameter Name="CICLO6" Type="Int32" />
        <asp:Parameter Name="MZ6" Type="Decimal" />
        <asp:Parameter Name="TC_MZ6" Type="Decimal" />
        <asp:Parameter Name="TC6" Type="Decimal" />
        <asp:Parameter Name="REND6" Type="Decimal" />
        <asp:Parameter Name="LBS6" Type="Decimal" />
        <asp:Parameter Name="CICLO7" Type="Int32" />
        <asp:Parameter Name="MZ7" Type="Decimal" />
        <asp:Parameter Name="TC_MZ7" Type="Decimal" />
        <asp:Parameter Name="TC7" Type="Decimal" />
        <asp:Parameter Name="REND7" Type="Decimal" />
        <asp:Parameter Name="LBS7" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROYFIN_ING_LOTE" Type="Int32" />
        <asp:Parameter Name="ID_PROYFIN_ING" Type="Int32" />
        <asp:Parameter Name="ACCESLOTE" Type="String" />
        <asp:Parameter Name="NO_CONTRATO" Type="Int32" />
        <asp:Parameter Name="CICLO" Type="Int32" />
        <asp:Parameter Name="CICLO1" Type="Int32" />
        <asp:Parameter Name="MZ1" Type="Decimal" />
        <asp:Parameter Name="TC_MZ1" Type="Decimal" />
        <asp:Parameter Name="TC1" Type="Decimal" />
        <asp:Parameter Name="REND1" Type="Decimal" />
        <asp:Parameter Name="LBS1" Type="Decimal" />
        <asp:Parameter Name="CICLO2" Type="Int32" />
        <asp:Parameter Name="MZ2" Type="Decimal" />
        <asp:Parameter Name="TC_MZ2" Type="Decimal" />
        <asp:Parameter Name="TC2" Type="Decimal" />
        <asp:Parameter Name="REND2" Type="Decimal" />
        <asp:Parameter Name="LBS2" Type="Decimal" />
        <asp:Parameter Name="CICLO3" Type="Int32" />
        <asp:Parameter Name="MZ3" Type="Decimal" />
        <asp:Parameter Name="TC_MZ3" Type="Decimal" />
        <asp:Parameter Name="TC3" Type="Decimal" />
        <asp:Parameter Name="REND3" Type="Decimal" />
        <asp:Parameter Name="LBS3" Type="Decimal" />
        <asp:Parameter Name="CICLO4" Type="Int32" />
        <asp:Parameter Name="MZ4" Type="Decimal" />
        <asp:Parameter Name="TC_MZ4" Type="Decimal" />
        <asp:Parameter Name="TC4" Type="Decimal" />
        <asp:Parameter Name="REND4" Type="Decimal" />
        <asp:Parameter Name="LBS4" Type="Decimal" />
        <asp:Parameter Name="CICLO5" Type="Int32" />
        <asp:Parameter Name="MZ5" Type="Decimal" />
        <asp:Parameter Name="TC_MZ5" Type="Decimal" />
        <asp:Parameter Name="TC5" Type="Decimal" />
        <asp:Parameter Name="REND5" Type="Decimal" />
        <asp:Parameter Name="LBS5" Type="Decimal" />
        <asp:Parameter Name="CICLO6" Type="Int32" />
        <asp:Parameter Name="MZ6" Type="Decimal" />
        <asp:Parameter Name="TC_MZ6" Type="Decimal" />
        <asp:Parameter Name="TC6" Type="Decimal" />
        <asp:Parameter Name="REND6" Type="Decimal" />
        <asp:Parameter Name="LBS6" Type="Decimal" />
        <asp:Parameter Name="CICLO7" Type="Int32" />
        <asp:Parameter Name="MZ7" Type="Decimal" />
        <asp:Parameter Name="TC_MZ7" Type="Decimal" />
        <asp:Parameter Name="TC7" Type="Decimal" />
        <asp:Parameter Name="REND7" Type="Decimal" />
        <asp:Parameter Name="LBS7" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROYFIN_ING_LOTE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
