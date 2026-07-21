<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLIC_ANTICIPO.ascx.vb" Inherits="controles_ucVistaDetalleSOLIC_ANTICIPO" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTRATO" Src="~/controlesContrato/ucListaCONTRATO.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaSOLIC_ANTICIPO_ZAFRA" Src="~/controlesMadurante/ucListaSOLIC_ANTICIPO_ZAFRA.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaSOLIC_ANTICIPO_LOTE" Src="~/controlesMadurante/ucListaSOLIC_ANTICIPO_LOTE.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaSOLIC_ANTICIPO_LIQFINAN" Src="~/controlesFinanciero/ucListaSOLIC_ANTICIPO_LIQFINAN.ascx" %>

<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="ucVistaDetalleSOLIC_ANTICIPOLayout" ClientInstanceName="ucVistaDetalleANTICIPOLayout" runat="server" Width="1000px">
                <Items>
                    <dx:LayoutGroup ColCount="1" Name="lgSolicitudAnticipo" Caption="Información de la Solicitud de Anticipo" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <table>
                                            <tr id="trID" runat="server" visible="false">
                                                <td><dx:ASPxLabel ID="aspxLabel3" runat="server" Text="Id ANTICIPO:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtID_ANTICIPO" runat="server" ClientInstanceName="txtID_OPI" Width="120px" BackColor="WhiteSmoke">                               
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel11" runat="server" Text="N° Anticipo:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtNUM_ANTICIPO" runat="server" ClientInstanceName="txtNUM_ANTICIPO" HorizontalAlign="Right" Width="120px" BackColor="WhiteSmoke">                               
                                                    </dx:ASPxTextBox>
                                                </td>
                                                <td><dx:ASPxLabel ID="aspxLabel1" runat="server" Text="Zafra:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server" AutoPostBack="true"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px">
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>  
                                                </td>                                                
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel14" runat="server" Text="Tipo de Financiamiento:" /></td>
                                                <th colspan="3" ><dx:ASPxComboBox ID="cbxTIPO_FINANCIAMIENTO" runat="server" ValueField="ID_CUENTA_FINAN" Font-Bold="true"   
                                                        TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinan"  
                                                        AutoPostBack="True">
                                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
                                                             <RequiredField ErrorText="Seleccione el Concepto de Financiamiento" IsRequired="True" />
                                                    </ValidationSettings>
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel2" runat="server" Text="Cod. Proveedor:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="txtCODIPROVEE" runat="server" ClientInstanceName="txtCODIPROVEE" HorizontalAlign="Right" AutoPostBack="true" Width="120px"  >                                                        
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                                <td><dx:ASPxLabel ID="aspxLabel5" runat="server" Text="Nombre del Productor:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" ClientInstanceName="txtNOMBRE_PROVEEDOR" Width="100%" BackColor="WhiteSmoke">                               
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>                                                
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel4" runat="server" Text="Fecha de Solicitud:" /></td>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dteFECHA_SOLIC" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true" HorizontalAlign="Right"   
                                                        EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px" ClientEnabled="false"  >                                            
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxDateEdit>  
                                                </td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel27" runat="server" Text="Concepto:" /></td>
                                                <th colspan="3">
                                                    <dx:ASPxMemo ID="txtCONCEPTO" ClientInstanceName="txtCONCEPTO" runat="server"  Width="100%" Height="70px" MaxLength="3000" >    
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" ErrorText="Concepto no valido" SetFocusOnError="True">
                                                                <RequiredField ErrorText="Concepto es obligatorio" IsRequired="True" />
                                                        </ValidationSettings>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxMemo>                                                   
                                                </th> 
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel18" runat="server" Text="Destino:" /></td>
                                                <th colspan="3">
                                                    <dx:ASPxTextBox ID="txtDESTINO" runat="server" ClientInstanceName="txtDESTINO" MaxLength="100" Width="100%" >                               
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>                                                  
                                                </th> 
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel7" runat="server" Text="Monto:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="speMONTO" HorizontalAlign="Right" runat="server" DecimalPlaces="2" Number="0" DisplayFormatString="#,###0.00"  SpinButtons-ShowIncrementButtons="false" Width="120px" >
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                                <td><dx:ASPxLabel ID="aspxLabel8" runat="server" Text="Datos del Cheque:" Font-Bold="true" /></td>
                                                <td style="text-align:left" >
                                                    <table width="100%">
                                                        <tr>
                                                            <td><dx:ASPxLabel ID="aspxLabel15" runat="server" Text="Número:" /></td>
                                                            <td>
                                                                <dx:ASPxTextBox ID="txtCHQ_NO" ClientInstanceName="txtCONCEPTO" runat="server" Width="200px" >                                                                                                           
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxTextBox>
                                                            </td>
                                                            <td><dx:ASPxLabel ID="aspxLabel16" runat="server" Text="Fecha:" /></td>
                                                            <td>
                                                                <dx:ASPxDateEdit ID="dteFECHA_CHEQUE" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                                    EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px" ClientEnabled="false"  >                                            
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxDateEdit>
                                                            </td>
                                                        </tr>
                                                    </table>                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel9" runat="server" Text="Tasa de Interés:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="spePORC_INTERES" HorizontalAlign="Right" runat="server" DisplayFormatString="#,###0.00" DecimalPlaces="2" SpinButtons-ShowIncrementButtons="false" Width="120px" >
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                    </dx:ASPxSpinEdit> 
                                                </td>
                                                <td><dx:ASPxLabel ID="aspxLabel10" runat="server" Text="%" /></td>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td><dx:ASPxLabel ID="aspxLabel25" runat="server" Text="Periodo de pago:" /></td>
                                                            <td><dx:ASPxLabel ID="aspxLabel23" runat="server" Text="Del" /></td>
                                                            <td>
                                                                <dx:ASPxDateEdit ID="dtePeriodoPagoDel" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                                    EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px" ClientEnabled="false"  >                                            
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxDateEdit>
                                                            </td>
                                                            <td><dx:ASPxLabel ID="aspxLabel24" runat="server" Text="al" /></td>
                                                            <td>
                                                                <dx:ASPxDateEdit ID="dtePeriodoPagoAl" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                                    EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px" ClientEnabled="false"  >                                            
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxDateEdit>
                                                            </td>
                                                        </tr>                                                        
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr id="trVENCIMIENTO_PLAZO" runat="server">
                                                <td><dx:ASPxLabel ID="aspxLabel17" runat="server" Text="Fecha Vencimiento:" /></td>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dteFECHA_VENCE" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                        EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px" ClientEnabled="false"  >                                            
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxDateEdit>
                                                </td>
                                                <td><dx:ASPxLabel ID="lblPLAZO_MESES" runat="server" Text="Plazo en Meses:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="spePLAZO_MESES" HorizontalAlign="Right" runat="server" NumberType="Integer" Width="120px" >
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                            </tr>

                                             <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel12" runat="server" Text="Aceptada:" /></td>
                                                <td>
                                                    <dx:ASPxCheckBox ID="chkAceptada" runat="server">                                                        
                                                    </dx:ASPxCheckBox>
                                                </td>
                                                <td>
                                                    <dx:ASPxLabel ID="aspxLabel22" runat="server" Text="Estado:" />
                                                </td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxESTADO" ClientInstanceName="cbxESTADO" DataSourceID="odsSolicEstado" ValueField="ID_SOLIC_ESTADO" TextField="NOMBRE_ESTADO" runat="server" ValueType="System.Int32" Width="120px">                                                                           
                                                        <DisabledStyle Font-Bold="True" BackColor="WhiteSmoke" ForeColor="Blue"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                             <tr id="trTituloContrato" runat="server" visible="false" >
                                                <th colspan="4" style="text-align:left"  >
                                                    <dx:ASPxLabel ID="aspxLabel13" runat="server" Text="Contratos a los que aplica el Préstamo" Font-Bold="true" />
                                                </th>                                                                                                
                                            </tr>
                                            <tr id="trlistaContrato" runat="server" visible="false" >
                                                <th colspan="4" style="text-align:left">
                                                    <uc1:ucListaCONTRATO id="ucListaCONTRATO1" PermitirEliminar="false" PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" PermitirEditar="false" PermitirRowHotTrack="false" PermitirFocoEnFilas="false" MostrarCheckVariaSeleccion="true" VerCODISOCIO="false" PermitirVistaPrevia="true" runat="server"></uc1:ucListaCONTRATO>
                                                </th>
                                            </tr>   
                                            <tr>
                                                <th colspan="4">
                                                    <hr>
                                                </th> 
                                            </tr>                                           
                                            <tr id="trLOTES_1" runat="server">
                                                <th colspan="4">
                                                        <dx:ASPxPageControl ID="ASPxPageControl1" Theme="Office2010Blue" ClientInstanceName="tabControl" runat="server" ActiveTabIndex="0" 
                                                            Width="100%" >    
                                                            <tabpages>
                                                                <dx:TabPage Text="Lotes a los que aplica el anticipo/mutuo" TabStyle-Font-Bold="true">
<TabStyle Font-Bold="True"></TabStyle>
                                                                    <contentcollection>
                                                                        <dx:ContentControl ID="ContentControl" runat="server">
                                                                            <table width="100%">                        
                                                                                <tr>                            
                                                                                    <td>
                                                                                        <dx:ASPxCheckBox ID="chkSelectTodosLotes" AutoPostBack="true" runat="server" Text="Marque para seleccionar todos los Lotes"  TextAlign="Right" ></dx:ASPxCheckBox>
                                                                                    </td>
                                                                                </tr>
						                                                        <tr>
							                                                        <td>
								                                                        <uc1:ucListaSOLIC_ANTICIPO_LOTE id="ucListaSOLIC_ANTICIPO_LOTE1" NombreGridCliente="ucListaSOLIC_ANTICIPO_LOTE1" PermitirEditar="false" PermitirEditarInline="false"  PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" TipoEdicion="0" TamanoPagina="10" PermitirEliminar="false" runat="server"></uc1:ucListaSOLIC_ANTICIPO_LOTE>
							                                                        </td>
						                                                        </tr>
                                                                            </table>                    
                                                                        </dx:ContentControl>
                                                                    </contentcollection>
                                                                </dx:TabPage>
                                                                <dx:TabPage Text="Zafras a las que aplica el mutuo" TabStyle-Font-Bold="true" ClientEnabled="false" >
<TabStyle Font-Bold="True"></TabStyle>
                                                                    <contentcollection>
                                                                        <dx:ContentControl ID="ContentContro2" runat="server">
                                                                            <table width="100%" >
                                                                                <tr>
							                                                        <td>
								                                                        <table>
									                                                        <tr>
										                                                        <td width="200px"><dx:ASPxLabel ID="aspxLabel19" runat="server" Text="Zafra" /></td>
										                                                        <td width="200px"><dx:ASPxLabel ID="aspxLabel20" runat="server" Text="Fecha Ultimo Movto" /></td>
										                                                        <td width="200px"><dx:ASPxLabel ID="aspxLabel21" runat="server" Text="Cuota" /></td>
										                                                        <td width="20px"></td>
									                                                        </tr>
									                                                        <tr>
										                                                        <td>
											                                                        <dx:ASPxComboBox ID="cbxZAFRAdeta" runat="server"  DataSourceID="odsZafradeta" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100%">
											                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
											                                                        </dx:ASPxComboBox>  
										                                                        </td>
										                                                        <td>
											                                                        <dx:ASPxDateEdit ID="dteFECHA_ULTMOV" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
												                                                        EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="100%" >                                            
												                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
											                                                        </dx:ASPxDateEdit>
										                                                        </td>
										                                                        <td>
											                                                        <dx:ASPxSpinEdit ID="speCUOTA" HorizontalAlign="Right" runat="server" DecimalPlaces="2" Number="0" DisplayFormatString="#,###0.00"  SpinButtons-ShowIncrementButtons="false" Width="100%" >
												                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
												                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
											                                                        </dx:ASPxSpinEdit>
										                                                        </td>
										                                                        <td><dx:ASPxButton ID="btnAgregarZafra" CausesValidation="false" ToolTip="Agregar zafra" Width="20px" Theme="RedWine" runat="server" Text="+"></dx:ASPxButton></td>
									                                                        </tr>
									                                                        <tr>
										                                                        <th colspan="4" >
											                                                        <uc1:ucListaSOLIC_ANTICIPO_ZAFRA id="ucListaSOLIC_ANTICIPO_ZAFRA1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="true" PermitirEliminar="true"  runat="server"></uc1:ucListaSOLIC_ANTICIPO_ZAFRA>                                                                                       
										                                                        </th>
									                                                        </tr>
								                                                        </table>        
							                                                        </td>
                                                                                </tr>
                                                                            </table>
                                                                        </dx:ContentControl>
                                                                    </contentcollection>
                                                                </dx:TabPage>
		                                                         <dx:TabPage Text="Liquidación de financiamientos" TabStyle-Font-Bold="true" ClientEnabled="false" >
                                                                    <TabStyle Font-Bold="True"></TabStyle>
                                                                    <contentcollection>
                                                                        <dx:ContentControl ID="ContentControl1" runat="server">
                                                                            <table width="100%">
                                                                                <tr>
                                                                                    <td style="text-align:right; padding-right:20px">
                                                                                        <dx:ASPxLabel ID="aspxLabel6" runat="server" Text="TOTAL LIQUIDACIÓN [Abono + Abo. Interes + Abo. Interes IVA]:" Font-Bold="true" />
                                                                                    </td>
                                                                                    <td style="text-align:right; padding-right:27px">
                                                                                        <dx:ASPxLabel ID="lblTotalLiquidar" runat="server" Text="0.00" Font-Bold="true" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <th colspan="2" >
                                                                                    <uc1:ucListaSOLIC_ANTICIPO_LIQFINAN id="ucListaSOLIC_ANTICIPO_LIQFINAN1" NombreGridCliente="ucListaSOLIC_ANTICIPO_LIQFINAN1" PermitirEditar="false" PermitirEditarInline2="true"  PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" TamanoPagina="10" PermitirEliminar="false" PermitirEliminarInline="false"  runat="server"></uc1:ucListaSOLIC_ANTICIPO_LIQFINAN>
                                                                                    </th>
                                                                                </tr>
                                                                            </table>
				                                                        </dx:ContentControl>
                                                                    </contentcollection>
                                                                </dx:TabPage>
                                                            </tabpages>
                                                        </dx:ASPxPageControl>
                                                </th>                                                                                                                                              
                                            </tr>
                                                        
                                        </table>
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

<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />
<dx:ASPxLabel ID="lblREFERENCIA_LOTES" runat="server" Visible="false" />  
<dx:ASPxLabel ID="lblREFERENCIA_LIQFINAN" runat="server" Visible="false" />  

<asp:ObjectDataSource ID="odsCuentaFinan" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaParaSolicAnticipo" 
    TypeName="SISPACAL.BL.cCUENTA_FINAN">     
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsZafradeta" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSolicEstado" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_ESTADO">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ESTADO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
