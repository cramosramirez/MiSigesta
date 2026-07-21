<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucRegistroEjecutadoQuemaRoza.ascx.vb" Inherits="controlesProforma_ucRegistroEjecutadoQuemaRoza" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaCONTROL_QUEMA_SALDO" Src="~/controlesProforma/ucListaCONTROL_QUEMA_SALDO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTROL_ROZA_SALDO" Src="~/controlesProforma/ucListaCONTROL_ROZA_SALDO.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxCallbackPanel ID="cpRegistroInventarioQuemaRoza" ClientInstanceName="cpRegistroInventarioQuemaRoza" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">   
          <table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
			       <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
            </tr>
		    <tr>
		        <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Liquidación de Inventario de Quema y Roza Proyectado</asp:Label></td>
		    </tr>
		    <tr>
			    <td>  
                <table>
                    <tr>
                        <td><dx:ASPxLabel ID="lbl1" runat="server" Text="Zafra:"  ></dx:ASPxLabel></td>
                        <td>
                            <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px" AutoPostBack="true" >
                            </dx:ASPxComboBox>
                        </td>
                        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Catorcena"  ></dx:ASPxLabel></td>
                        <td>
                            <dx:ASPxComboBox ID="cbxCATORCENA" runat="server" ValueType="System.Int32" 
                                Width="120px" DropDownStyle="DropDown" AutoPostBack="true" >
                                <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" /> 
                            </dx:ASPxComboBox>
                        </td>
                        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Tipo Inventario:"></dx:ASPxLabel></td>
                        <td>
                            <dx:ASPxComboBox ID="cbxTIPO_INVENTARIO" runat="server" ValueType="System.Int32" 
                                Width="120px" DropDownStyle="DropDown" >
                                <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" /> 
                                <Items>
                                    <dx:ListEditItem Value="1" Text="QUEMA" Selected="true" />  
                                    <dx:ListEditItem Value="2" Text="ROZA" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Codi Provee:"  ></dx:ASPxLabel></td>
                        <td>
                            <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true"
                                Width="120px">
                            </dx:ASPxSpinEdit>
                        </td>
                        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Codi Socio:"  ></dx:ASPxLabel></td>
                        <td>
                            <dx:ASPxSpinEdit ID="speCODISOCIO" runat="server"  AllowNull="true" Width="120px">
                            </dx:ASPxSpinEdit>
                        </td>
                        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Nombre Proveedor:"  ></dx:ASPxLabel></td>
                        <td>
                            <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px"></dx:ASPxTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Nombre Lote:"  ></dx:ASPxLabel></td>
                        <th colspan="3" >
                            <dx:ASPxTextBox ID="txtNOMBLOTE" runat="server" Width="100%"></dx:ASPxTextBox>
                        </th>
                        <td>
                            <dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Estado:" />
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="cbxTIPO_SALDO" runat="server" ValueType="System.Int32" 
                                Width="120px" DropDownStyle="DropDown" >
                                <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" /> 
                                <Items>
                                    <dx:ListEditItem Value="-1" Text="TODOS" Selected="true" />  
                                    <dx:ListEditItem Value="1" Text="CON SALDO" />
                                    <dx:ListEditItem Value="2" Text="SIN SALDO" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                    </tr>
                </table>              
                </td>
            </tr>
            <tr>
                <td>
                    <uc1:ucListaCONTROL_QUEMA_SALDO id="ucListaCONTROL_QUEMA_SALDO1" 
                        VerIncrementoSaldo="true"
                        VerCODI_PROVEE="true" VerNOMBRE_PROVEEDOR="true" VerCODILOTE="true" VerNOMBLOTE="true"  
                        VerFECHA_HORA_QUEMA_PROY ="true" VerFECHA_HORA_QUEMA_REAL="true"
                        VerTC_PROY="true" VerTC_REAL="true" 
                        VerFECHA_HORA_QUEMA="false" VerENTRADAS="false" VerSALIDAS="false" VerSALDO="true"  
                        VerModificacionTCQuema="true" 
                        PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" PermitirEditarInline="false" PermitirEliminar="false" runat="server" PermitirEditar="false"
                        Visible="false" />
                    <uc1:ucListaCONTROL_ROZA_SALDO id="ucListaCONTROL_ROZA_SALDO1" TamanoPagina="10" 
                        VerIncrementoSaldo="true"
                        VerCODI_PROVEE="true" VerNOMBRE_PROVEEDOR="true" VerCODILOTE="true" VerNOMBLOTE="true"  
                        VerFECHA_HORA_QUEMA_PROY ="true" VerFECHA_HORA_QUEMA_REAL="true" VerFECHA_HORA_ROZA_PROY="true" VerFECHA_HORA_ROZA_REAL="false" 
                        VerTC_PROY="true" VerTC_REAL="true" VerHORAS_QUEMA="false" VerHORAS_ROZA="false" 
                        VerFECHA_HORA_QUEMA="false" VerFECHA_HORA_ROZA="false" VerENTRADAS="false" VerSALIDAS="false" VerSALDO="true"         
                        VerModificacionTCRoza="true"    
                        MostrarCheckUnaSeleccion="false" PermitirEditarInline="false" PermitirEliminar="false" PermitirEliminarInline="false" runat="server" PermitirEditar="false"
                        Visible="false"  />                   
                </td>
		    </tr>	      
           </table>
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>


<dx:ASPxPopupControl ID="pcLiquidarSaldos" runat="server" CloseAction="CloseButton" Modal="True" Width="300px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcLiquidarSaldos"
        HeaderText="Liquidación de Saldos" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server">
                <dx:ASPxPanel ID="ASPxPanel1" runat="server" DefaultButton="btOK">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent2" runat="server">
                            <table width="100%">
                                <tr>
                                     <td><dx:ASPxLabel ID="lblLiquidarSaldos" runat="server" text="Liquidar Saldos con Horas mayores a:" /></td>
                                     <td><dx:ASPxSpinEdit ID="speHorasLiquidar" runat="server" NumberType="Integer" Width="100px"  /></td>
                                </tr>
                            </table>
                            <table width="100%">
                            <tr>                                    
                                <td align="center">
                                    <dx:ASPxButton ID="btnLiquidarSaldoHoras" runat="server" CausesValidation="false" AutoPostBack="true" Text="Liquidar Saldo">                                        
                                    </dx:ASPxButton>    
                                </td>
                                <td align="center">  
                                    <dx:ASPxButton ID="btnCancelarSaldoHoras" AutoPostBack="false" runat="server" Text="Cancelar">
                                        <ClientSideEvents Click="function(s,e){pcLiquidarSaldos.Hide()}" /> 
                                    </dx:ASPxButton> 
                                </td>                                      
                            </tr>                            
                        </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl> 
                        

<dx:ASPxPopupControl ID="pcEjecucionReal" runat="server" CloseAction="CloseButton" Modal="True" Width="350px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcEjecucionReal"
        HeaderText="Liquidación de Inventario" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btOK">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">                                                
                        <dx:ASPxLabel ID="lblpcMensaje" runat="server" Font-Bold="true" ForeColor="Blue" />
                        <hr />  
                        <dx:ASPxLabel ID="lblIDEjecucion" runat="server" ClientVisible="false" />
                        <table width="100%">
                            <tr id="trFECHA_QUEMA_OLD1" runat="server">
                                <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" text="Fecha actual de Quema:" /></td>
                                <td>
                                    <dx:ASPxTextBox ID="txtFECHA_HORA_QUEMA_ACTUAL" HorizontalAlign="Right" runat="server" Width="150px" ClientEnabled="false">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                    </dx:ASPxTextBox>
                                </td>
                            </tr>
                            <tr id="trFECHA_QUEMA_OLD2" runat="server">
                                <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" text="Nueva Fecha de Quema:" /></td>
                                <td>
                                    <dx:ASPxDateEdit ID="dteFECHA_HORA_QUEMA_NUEVA" runat="server" HorizontalAlign="Right" 
                                        DisplayFormatString="dd/MM/yyyy HH:mm" EditFormat="Custom" UseMaskBehavior="True" 
                                        EditFormatString="dd/MM/yyyy HH:mm" Width="150px">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        <TimeSectionProperties Visible="true">                                            
                                            <TimeEditProperties EditFormatString="hh:mm tt"></TimeEditProperties>
                                        </TimeSectionProperties>
                                    </dx:ASPxDateEdit>
                                </td>
                            </tr>
                            <tr id="trFECHA_ROZA_OLD1" runat="server">
                                <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" text="Fecha actual de Roza:" /></td>
                                <td>
                                    <dx:ASPxTextBox ID="txtFECHA_HORA_ROZA_ACTUAL" HorizontalAlign="Right" runat="server" Width="150px" ClientEnabled="false">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                    </dx:ASPxTextBox>
                                </td>
                            </tr>
                            <tr id="trFECHA_ROZA_OLD2" runat="server">
                                <td><dx:ASPxLabel ID="ASPxLabel14" runat="server" text="Nueva Fecha de Roza:" /></td>
                                <td>
                                    <dx:ASPxDateEdit ID="dteFECHA_HORA_ROZA_NUEVA" runat="server" HorizontalAlign="Right" 
                                        DisplayFormatString="dd/MM/yyyy HH:mm" EditFormat="Custom" UseMaskBehavior="True" 
                                        EditFormatString="dd/MM/yyyy HH:mm" Width="150px">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        <TimeSectionProperties Visible="true">                                            
                                            <TimeEditProperties EditFormatString="hh:mm tt"></TimeEditProperties>
                                        </TimeSectionProperties>
                                    </dx:ASPxDateEdit>
                                </td>
                            </tr>
                        </table>                     
                        <table width="100%" runat="server" id="tblTipoLiquidacion"  >
                            <tr>
                                <th colspan="2">                                    
                                    <dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Seleccione el Tipo de Reversión de Proyección:"  />
                                </th>
                            </tr>
                            <tr>   
                                <th colspan="2" align="center"  >                                    
                                    <dx:ASPxRadioButtonList ID="rblTipoLiquidacion"  runat="server" ValueType="System.Int32" 
                                        ItemSpacing="20px" RepeatDirection="Horizontal"  >
                                        <ClientSideEvents ValueChanged="function(s, e) {
	                                            if (s.GetValue()==1){
                                                    speCantidadLiquidarTC.SetEnabled(false);		
                                                    speCantidadLiquidarTC.SetText('');
	                                            }
	                                            else{
		                                            speCantidadLiquidarTC.SetEnabled(true);
                                                    speCantidadLiquidarTC.SetValue(0);
                                                }
                                          }" />
                                        <Items>
                                            <dx:ListEditItem Text="Total" Value="1" />  
                                            <dx:ListEditItem Text="Parcial" Value="2" />
                                        </Items>
                                        <Border BorderStyle="None" />
                                    </dx:ASPxRadioButtonList>                                                                     
                                </th>                              
                            </tr>                            
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Cantidad a Revertir(TC):"  />
                                </td>                                
                                <td>
                                    <dx:ASPxSpinEdit ID="speCantidadLiquidarTC" ClientInstanceName="speCantidadLiquidarTC" HorizontalAlign="Right" runat="server" AllowNull="false" DecimalPlaces="0" Width="90px" NumberType="Float" >
                                        <SpinButtons ShowIncrementButtons="false" />  
                                    </dx:ASPxSpinEdit>
                                </td> 
                            </tr>
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="lblCantidadReal" runat="server" Text="Cantidad Real (TC):"  />
                                </td>                                
                                <td>
                                    <dx:ASPxSpinEdit ID="speCantidadRealTC" ClientInstanceName="speCantidadRealTC" HorizontalAlign="Right" runat="server" AllowNull="false" DecimalPlaces="0" Width="90px" NumberType="Float"  >
                                        <SpinButtons ShowIncrementButtons="false" />  
                                    </dx:ASPxSpinEdit>
                                </td> 
                            </tr>
                       </table>
                       <table width="100%">
                            <tr>                                    
                                <td align="center">
                                    <dx:ASPxButton ID="btnLiquidar" runat="server" CausesValidation="false" AutoPostBack="true" Text="Aplicar inventario ejecutado">                                        
                                    </dx:ASPxButton>    
                                </td>
                                <td align="center">  
                                    <dx:ASPxButton ID="btnCancelar" AutoPostBack="false" runat="server" Text="Cancelar">
                                        <ClientSideEvents Click="function(s,e){pcEjecucionReal.Hide()}" /> 
                                    </dx:ASPxButton> 
                                </td>                                      
                            </tr>                            
                        </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl>


<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>