<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePLAN_COSECHA.ascx.vb" Inherits="controles_ucVistaDetallePLAN_COSECHA" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>




<%@ Register tagprefix="uc1" tagname="ucListaLOTES" Src="~/controlesContrato/ucListaLOTES.ascx" %>

<script type="text/javascript">
    function checkQUEMA(s, e) {
        if (!s.GetChecked()) 
            return;
        if (s.GetText() == 'Quema Programada') {
            chkQuemaNoProgramada.SetChecked(false);
            chkCanaVerde.SetChecked(false);

            dteFechaEstimQuema.SetEnabled(true);
            dteFechaRealQuema.SetEnabled(true);
            dteFechaQuemaNoProg.SetEnabled(false);
            return;
        }
        if (s.GetText() == 'Quema No Programada') {
            chkQuemaProgramada.SetChecked(false);
            chkCanaVerde.SetChecked(false);

            dteFechaEstimQuema.SetEnabled(false);            
            dteFechaRealQuema.SetEnabled(false);            
            dteFechaQuemaNoProg.SetEnabled(true);
            return;
        }
        if (s.GetText() == 'Caña Verde') {
            chkQuemaProgramada.SetChecked(false);
            chkQuemaNoProgramada.SetChecked(false);

            dteFechaEstimQuema.SetEnabled(false);            
            dteFechaRealQuema.SetEnabled(false);
            dteFechaQuemaNoProg.SetEnabled(false);
            return;
        }
    }
</script>
<table width="100%" >
    <tr>
        <td align="center" style="margin-left: 40px">
            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                <Items>
                    <dx:LayoutGroup Caption="Creando/Editando Plan de Cosecha Semanal" ColCount="4" >
                        <Items>
                            <dx:LayoutItem Caption="ID Plan Cosecha:" ShowCaption="False" Visible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <dx:ASPxTextBox ID="txtID_PLAN_COSECHA" runat="server" Width="120px">
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                           
                            <dx:LayoutItem Caption="Zafra">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100px" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                                              
                            <dx:LayoutItem Caption="Cod. Proveedor según Contrato">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                                        <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AutoPostBack="True" 
                                            Width="80px">
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Codigo de proveedor es obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                
                            <dx:LayoutItem Caption="Nombre proveedor">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                        <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px"  DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:ASPxFormLayout>
        </td>
    </tr>
</table>
<dx:ASPxLabel ID="lblDetalle" runat="server" Text="Seleccione el lote contratado que programara" 
    ForeColor="#4881A2" Font-Bold="True" Font-Names="Arial" 
    Font-Size="Small" />
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />  
<uc1:ucListaLOTES id="ucListaLOTES1" CallbackPlanCosecha="true" VerAREA="false" VerAREA_CANA="false" VerTONELADAS="false" VerTONEL_TC="false" VerMZ_CENSO="true" VerTONEL_MZ_CENSO="true" VerTONEL_CENSO="true"           
          MostrarCheckUnaSeleccion="true" NombreGridCliente="ucListaLOTES1" PermitirEditarInline="false" TipoEdicion="0" TamanoPagina="5" PermitirEliminar="false" runat="server" VerNO_CONTRATO="true" VerCUI="false" VerCODISOCIO="false" VerANIOZAFRA="false" PermitirEditar="false"></uc1:ucListaLOTES>
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<table width="100%" >
    <tr>
        <td align="center"> 
            <dx:ASPxFormLayout ID="frmlComplemento" runat="server" Width="80%">
                <Items>
                    <dx:LayoutGroup Caption="Información de Plan de Cosecha Semanal" ColCount="6" >
                        <Items>
                            <dx:LayoutItem Caption="Saldo disponible ha">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="txtMZ_SALDO" HorizontalAlign="Right" Width="100px" DisplayFormatString="#,##0.00"   
                                            SpinButtons-ShowIncrementButtons="false" runat="server" Number="0"  DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Saldo disponible (t)">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="txtTONEL_SALDO" runat="server" HorizontalAlign="Right" Width="100%" DisplayFormatString="#,##0.00"  
                                            SpinButtons-ShowIncrementButtons="false" Number="0"  DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                          
                            <dx:LayoutItem Caption="ha a Cosechar">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="txtMZ_COSECHA" runat="server" AutoPostBack="true" HorizontalAlign="Right" DisplayFormatString="{0:F2}" Width="100px" 
                                            SpinButtons-ShowIncrementButtons="false" Number="0">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="MZ a Cosechar es obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                            
                            <dx:LayoutItem Caption="TCH a Cosechar" Visible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="txtTC_MZ_COSECHA" runat="server" HorizontalAlign="Right" Width="120px"  
                                            SpinButtons-ShowIncrementButtons="false" Number="0"  DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                           <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="TC/MZ a Cosechar es obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Cuota Diaria (t)">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                                        <dx:ASPxSpinEdit ID="txtCUOTA_DIARIA" runat="server" AutoPostBack="true" HorizontalAlign="Right"  Width="80px" 
                                            Number="0" DisplayFormatString="{0:F2}">
                                             <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
                                             <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Cuota Diaria TC es obligatoria" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>      
                            <dx:LayoutItem Caption="(t) a Cosechar" ColSpan="2">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="txtTONEL_COSECHA" runat="server" HorizontalAlign="Right" Width="100px" DisplayFormatString="{0:F2}" 
                                            SpinButtons-ShowIncrementButtons="false" Number="0">                                            
                                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />      
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                                                            
                            <dx:LayoutItem Caption="Fecha inicio Cosecha">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxDateEdit ID="dteFECHA_INI_COSECHA" AutoPostBack="true" runat="server" HorizontalAlign="Right"   
                                            DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                            EditFormatString="dd/MM/yyyy" Width="100px">
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Fecha inicio de cosecha es obligatoria" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Fecha fin Cosecha">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxDateEdit ID="dteFECHA_FIN_COSECHA" AutoPostBack="true" runat="server" HorizontalAlign="Right" 
                                            DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                            EditFormatString="dd/MM/yyyy" Width="100px">
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Fecha fin de cosecha es obligatoria" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Duración Lote (Días)">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="txtTOTAL_SEMANA" runat="server" HorizontalAlign="Right" Width="100px" DisplayFormatString="{0:F2}"
                                            SpinButtons-ShowIncrementButtons="false" Number="0"  DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                            
                            <dx:LayoutItem Caption="Tipo Caña" ColSpan="3">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxComboBox ID="cbxID_TIPO_CANA" DataSourceID="odsTipoCana" DropDownStyle="DropDownList" runat="server" AutoPostBack="true" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO" Width="100%" >
                                                     <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                                        ErrorDisplayMode="ImageWithTooltip" 
                                                        RequiredField-ErrorText="Tipo de Caña es obligatorio" >
                                                        <RequiredField IsRequired="True" ErrorText="Tipo de Caña es obligatorio"></RequiredField>
                                                    </ValidationSettings>
                                                    <ClientSideEvents ValueChanged="function(s,e){hfucVistaDetallePLAN_COSECHA.Set('ID_TIPO_CANA',s.GetValue())}" />
                                         </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                            
                            
                            <dx:LayoutItem Caption="Tipo Roza" ColSpan="2" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxComboBox ID="cbxID_TIPO_ROZA" AutoPostBack="true" DropDownStyle="DropDownList" runat="server" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO"  Width="100%">
                                                    <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                                        ErrorDisplayMode="ImageWithTooltip" 
                                                        RequiredField-ErrorText="Tipo de Roza es obligatorio" >
                                                        <RequiredField IsRequired="True" ErrorText="Tipo de Roza es obligatorio"></RequiredField>
                                                    </ValidationSettings>
                                                    <ClientSideEvents ValueChanged="function(s,e){hfucVistaDetallePLAN_COSECHA.Set('ID_TIPO_ROZA',s.GetValue())}" />
                                                </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Tipo Alza" ColSpan="4">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxComboBox ID="cbxID_TIPO_ALZA" AutoPostBack="true" runat="server" Width="100%" DropDownStyle="DropDownList" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO">
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Tipo de Alza es obligatoria" IsRequired="True" />
                                            </ValidationSettings>
                                            <ClientSideEvents ValueChanged="function(s,e){hfucVistaDetallePLAN_COSECHA.Set('ID_TIPO_ALZA',s.GetValue())}" />
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                            
                           
                            <dx:LayoutItem Caption="Cargadora" ColSpan="6" ClientVisible="false" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                        <dx:ASPxComboBox ID="cbxCARGADORA" runat="server" Width="100%" DropDownStyle="DropDownList" ValueType="System.Int32" ValueField="ID_CARGADORA" TextField="NOMBRE" TextFormatString="{0} - {1}">
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Cargadora es obligatoria" IsRequired="True" />
                                            </ValidationSettings>      
                                            <Columns>                                                        
                                                <dx:ListBoxColumn Caption="Codigo" FieldName="ID_CARGADORA" Width="100px" />                                                            
                                                <dx:ListBoxColumn Caption="Nombre" FieldName="NOMBRE" Width="300px" />                                                        
                                            </Columns>        
                                            <ClientSideEvents ValueChanged="function(s,e){hfucVistaDetallePLAN_COSECHA.Set('ID_CARGADORA',s.GetValue())}" />                              
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>  
                            <dx:LayoutItem Caption="Cód. Cargador" ClientVisible="false" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                                        <dx:ASPxSpinEdit ID="txtID_CARGADOR" runat="server" AutoPostBack="true" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" Number="0" Width="100px" >
                                                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                          <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Cargador es obligatoria" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Cargador" ColSpan="5" ClientVisible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                                        <dx:ASPxTextBox ID="txtNOMBRE_CARGADOR" runat="server" Width="100%"  DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>   
                                           
                            <dx:LayoutItem Caption="Tipo Transporte" ColSpan="2">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxComboBox ID="cbxID_TIPO_TRANS" runat="server" Width="100%" DropDownStyle="DropDownList" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO">
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Tipo de Transporte es obligatoria" IsRequired="True" />
                                            </ValidationSettings>
                                            <ClientSideEvents ValueChanged="function(s,e){hfucVistaDetallePLAN_COSECHA.Set('ID_TIPO_TRANS',s.GetValue())}" />
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>     
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem> 
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>     
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>     
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                            <dx:LayoutItem Caption="Quema Programada" ShowCaption="False" ClientVisible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                        <dx:ASPxCheckBox runat="server" ID="chkQuemaProgramada" Text="Quema Programada" ClientInstanceName="chkQuemaProgramada" >
                                            <ClientSideEvents CheckedChanged="checkQUEMA" />
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Fecha estimada" ClientVisible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">
                                        <dx:ASPxDateEdit ID="dteFECHA_ESTIM_QUEMA" ClientInstanceName="dteFechaEstimQuema" runat="server" HorizontalAlign="Right"   
                                            DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                            EditFormatString="dd/MM/yyyy" Width="100%">                                           
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Fecha real quema" ColSpan="2" ClientVisible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                                        <dx:ASPxDateEdit ID="dteFECHA_REAL_QUEMA" ClientInstanceName="dteFechaRealQuema" runat="server" HorizontalAlign="Right"   
                                            DisplayFormatString="dd/MM/yyyy hh:mm tt" EditFormat="Custom" UseMaskBehavior="True" 
                                            EditFormatString="dd/MM/yyyy hh:mm tt" Width="100%">                                           
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem ColSpan="2"></dx:EmptyLayoutItem>

                            <dx:LayoutItem Caption="Quema No Programada" ShowCaption="False" ClientVisible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                        <dx:ASPxCheckBox runat="server" Text="Quema No Programada" ID="chkQuemaNoProgramada" ClientInstanceName="chkQuemaNoProgramada" >
                                            <ClientSideEvents CheckedChanged="checkQUEMA" />
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>  
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                            <dx:LayoutItem Caption="Fecha no progra." ColSpan="2" ClientVisible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer15" runat="server">                                        
                                        <dx:ASPxDateEdit ID="dteFECHA_QUEMA_NOPROG" ClientInstanceName="dteFechaQuemaNoProg" runat="server" HorizontalAlign="Right"   
                                            DisplayFormatString="dd/MM/yyyy hh:mm tt" EditFormat="Custom" UseMaskBehavior="True" 
                                            EditFormatString="dd/MM/yyyy hh:mm tt" Width="100%">                                           
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>  
                            <dx:EmptyLayoutItem ColSpan="2"></dx:EmptyLayoutItem>
                            <dx:LayoutItem Caption="Caña Verde" ColSpan="6" ShowCaption="false" ClientVisible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                        <dx:ASPxCheckBox runat="server" ID="chkCanaVerde" Text="Caña Verde" ClientInstanceName="chkCanaVerde" >
                                            <ClientSideEvents CheckedChanged="checkQUEMA" />
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>  
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:ASPxFormLayout>
        </td>
    </tr>
</table>

<dx:ASPxHiddenField ID="hfucVistaDetallePLAN_COSECHA" ClientInstanceName="hfucVistaDetallePLAN_COSECHA" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>
<asp:ObjectDataSource ID="odsTipoCana" runat="server" 
    TypeName="SISPACAL.BL.cTIPOS_GENERALES" SelectMethod="RecuperarPorTipo" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>    
     <asp:Parameter Name="agregarVacio" DefaultValue="False" Type="Boolean"  />
     <asp:Parameter Name="agregarTodos" DefaultValue="False" Type="Boolean" />  
     <asp:Parameter Name="ID_TIPO" DefaultValue="-1" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_TABLA" DefaultValue="15" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_PADRE" DefaultValue="-1" Type="Int32" />     
  </SelectParameters> 
 </asp:ObjectDataSource>
