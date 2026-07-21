<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucRegistroInventarioQuemaRoza.ascx.vb" Inherits="controlesProforma_ucRegistroInventarioQuemaRoza" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaLOTES_COSECHA" Src="~/controlesProforma/ucListaLOTES_COSECHA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePLAN_COSECHA" Src="~/controlesProforma/ucVistaDetallePLAN_COSECHA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTROL_ROZA" Src="~/controlesProforma/ucVistaDetalleCONTROL_ROZA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTROL_QUEMA" Src="~/controlesProforma/ucVistaDetalleCONTROL_QUEMA.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxCallbackPanel ID="cpRegistroInventarioQuemaRoza" ClientInstanceName="cpRegistroInventarioQuemaRoza" runat="server" ShowLoadingPanel="false" Width="100%" >    
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">   
      <table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Registro de Inventario de Quema y Roza</asp:Label></td>
		   </tr>
		   <tr>
			   <td>   
               <dx:ASPxFormLayout ID="ucCriteriosRegistroInventarioQuemaRoza" runat="server" SettingsItemCaptions-Location="Left" 
                    Name="glCriterios">
                       <Items>
                           <dx:LayoutGroup Caption="Criterios de búsqueda" ColCount="4" 
                               GroupBoxDecoration="HeadingLine">
                               <Items>
                                   <dx:LayoutItem Caption="Zafra:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                               <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px" AutoPostBack="true" >
                                                </dx:ASPxComboBox>
                                           </dx:LayoutItemNestedControlContainer>   
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Zona:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                               <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" runat="server" DataSourceID="odsZona" TextField="DESCRIP_ZONA" ValueField="ZONA" Width="120px" >                            
                                               </dx:ASPxComboBox>         
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>    
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                              
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                   <dx:LayoutItem Caption="Catorcena" ClientVisible="false">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                                               <dx:ASPxComboBox ID="cbxCATORCENA" runat="server" ValueType="System.Int32" 
                                                   Width="120px" DropDownStyle="DropDown" AutoPostBack="true" >
                                                    <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" /> 
                                                </dx:ASPxComboBox>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Semana" ClientVisible="false">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                                <dx:ASPxComboBox ID="cbxSEMANA" runat="server" ValueType="System.String" 
                                                    Width="120px" DropDownStyle="DropDownList" />
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>                                    
                                                                 
                                   <dx:LayoutItem Caption="Cod. Provee:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                                <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true"
                                                    Width="120px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Cod. Socio:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                               <dx:ASPxSpinEdit ID="speCODISOCIO" runat="server"  AllowNull="true"
                                                   Width="120px">
                                               </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Nombre Proveedor:" ColSpan="2">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                                               <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="100%">
                                               </dx:ASPxTextBox>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>                                     
                               </Items>
                           </dx:LayoutGroup>
                       </Items>

<SettingsItemCaptions Location="Left"></SettingsItemCaptions>
                   </dx:ASPxFormLayout>
                </td>
		   </tr>
	       <tr>
            <td><uc1:ucListaLOTES_COSECHA id="ucListaLOTES_COSECHA1" 
                        VerCONTRATO="false" VerFECHA_ROZA="false" VerREND_COSECHA="false" VerMZ_CENSO="false" VerTONEL_MZ_CENSO="false" VerTONEL_CENSO="false"
                        VerTONEL_SEMILLA="false" VerTONEL_ENTREGADA="false" VerTONEL_SALDO_VAR="false" VerTONEL_ENTREGAR="false"
                        VerFIN_LOTE="false" VerULTIMO_MADURANTE="false" VerULTIMA_FECHA_MADURANTE="false"                    
                        PermitirRowHotTrack="false" runat="server" PermitirFilaDeFiltro="true"
                        PermitirEditar="false" PermitirEliminar="false" 
                        PermitirVistaControlQuema="true" PermitirVistaControlRoza="true" MostrarUnaPagina="true"
                ></uc1:ucListaLOTES_COSECHA>                
                <uc1:ucVistaDetalleCONTROL_ROZA ID="ucVistaDetalleCONTROL_ROZA1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTROL_ROZA>
                <uc1:ucVistaDetalleCONTROL_QUEMA ID="ucVistaDetalleCONTROL_QUEMA1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTROL_QUEMA>
            </td>
        </tr>
</table>
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>

<dx:ASPxPopupControl ID="pcModificarQuema" runat="server" CloseAction="CloseButton" Modal="True" Width="400px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcModificarQuema"
        HeaderText="Modificando Fecha/Hora de Quema" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server">
                <dx:ASPxPanel ID="ASPxPanel1" runat="server" DefaultButton="btOK">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent2" runat="server">                                                
                        <dx:ASPxLabel ID="lblpcMensajeModiQuema" runat="server" Font-Bold="true" ForeColor="Blue" />
                        <table width="100%">
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" text="Fecha actual de Quema:" /></td>
                                <td>
                                    <dx:ASPxTextBox ID="txtFECHA_HORA_QUEMA_ACTUAL" HorizontalAlign="Right" runat="server" Width="150px" ClientEnabled="false">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                    </dx:ASPxTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" text="Nueva Fecha de Quema:" /></td>
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
                        </table>
                        <table width="100%">
                            <tr>                                    
                                <td align="center">
                                    <dx:ASPxButton ID="btnAceptarModiQuema" runat="server" CausesValidation="false" AutoPostBack="true" Text="Aceptar">                                        
                                    </dx:ASPxButton>    
                                </td>
                                <td align="center">  
                                    <dx:ASPxButton ID="btnCancelarModiQuema" runat="server" Text="Cancelar">
                                        <ClientSideEvents Click="function(s,e){pcModificarQuema.Hide()}" /> 
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

<dx:ASPxPopupControl ID="pcLiquidarSaldo" runat="server" CloseAction="CloseButton" Modal="True" Width="300px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcLiquidarSaldo"
        HeaderText="Confirmación" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btOK">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">                                                
                        <dx:ASPxLabel ID="lblpcMensaje" runat="server" Font-Bold="true" ForeColor="Blue" />
                        <hr />                       
                        <table width="100%" runat="server" id="tblTipoLiquidacion"  >
                            <tr>
                                <th colspan="2">
                                    <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Seleccione el Tipo de Liquidación de Saldo:"  />
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
                                            <dx:ListEditItem Text="Saldo Total" Value="1" />  
                                            <dx:ListEditItem Text="Saldo Parcial" Value="2" />
                                        </Items>
                                    </dx:ASPxRadioButtonList>                                                                     
                                </th>                              
                            </tr>
                            <tr id="trLIQUIDAR_PROYECCION" runat="server" visible="false">
                                <th style="padding-left:15px" colspan="2" >
                                     <dx:ASPxCheckBox ID="chkLIQUIDAR_PROYECCION" Text="Liquidar como proyección"  runat="server">
                                    </dx:ASPxCheckBox>
                                </th>                               
                            </tr>
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Cantidad a Liquidar(TC):"  />
                                </td>                                
                                <td>
                                    <dx:ASPxSpinEdit ID="speCantidadLiquidarTC" ClientInstanceName="speCantidadLiquidarTC" HorizontalAlign="Right" runat="server" AllowNull="false" DecimalPlaces="0" Width="90px" NumberType="Integer" >
                                        <SpinButtons ShowIncrementButtons="false" />  
                                    </dx:ASPxSpinEdit>
                                </td> 
                            </tr>
                       </table>
                       <table width="100%">
                            <tr>                                    
                                <td align="center">
                                    <dx:ASPxButton ID="btnLiquidar" runat="server" CausesValidation="false" AutoPostBack="true" Text="Liquidar Saldo">                                        
                                    </dx:ASPxButton>    
                                </td>
                                <td align="center">  
                                    <dx:ASPxButton ID="btnCancelar" runat="server" Text="Cancelar">
                                        <ClientSideEvents Click="function(s,e){pcLiquidarSaldo.Hide()}" /> 
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
<asp:ObjectDataSource ID="odsZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
