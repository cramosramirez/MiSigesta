<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantLOTES_COSECHA.ascx.vb" Inherits="controles_ucMantLOTES_COSECHA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaLOTES_COSECHA" Src="~/controlesProforma/ucListaLOTES_COSECHA.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>




<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTROL_ROZA" Src="~/controlesProforma/ucVistaDetalleCONTROL_ROZA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTROL_QUEMA" Src="~/controlesProforma/ucVistaDetalleCONTROL_QUEMA.ascx" %>
 
<style type="text/css">
    .auto-style1 {
        margin-left: 40px;
    }
</style>
 
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	        <TR>
			    <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		    <TR>
		        <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">CONTROL DE ESTICAÑA</asp:Label></TD>
		    </TR>
		    <TR>
			    <TD>                    
                    <dx:ASPxFormLayout ID="ucCriteriosLotesCosecha" runat="server" SettingsItemCaptions-Location="Left" 
                        Name="glCriterios">
                            <Items>
                                <dx:LayoutGroup Caption="Criterios de búsqueda" ColCount="1" 
                                    GroupBoxDecoration="HeadingLine">
                                    <Items>
                                        <dx:LayoutItem ShowCaption="False" >
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                
                                                <table>
                                                    <tr>
                                                        <td><dx:ASPxLabel ID="Label1" runat="server" Text="Zafra:"></dx:ASPxLabel></td>
                                                        <td>
                                                            <dx:ASPxComboBox ID="cbxZAFRA" runat="server" HorizontalAlign="Right" DropDownStyle="DropDownList" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100px">
                                                             </dx:ASPxComboBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Zona:"></dx:ASPxLabel></td>
                                                        <td>
                                                            <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" HorizontalAlign="Right" runat="server" DataSourceID="odsZona" TextField="DESCRIP_ZONA" ValueField="ZONA" Width="100px" >                            
                                                            </dx:ASPxComboBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Cod. prod:"></dx:ASPxLabel></td>
                                                        <td>
                                                            <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" HorizontalAlign="Right" Width="100px">
                                                            </dx:ASPxSpinEdit>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Cod. socio:"></dx:ASPxLabel></td>
                                                        <td>
                                                            <dx:ASPxSpinEdit ID="speCODISOCIO" runat="server" HorizontalAlign="Right" Width="100px">
                                                            </dx:ASPxSpinEdit>
                                                        </td>
                                                        <td rowspan="4">
                                                            <table runat="server" id="trCOSECHA_TOTALES" visible="false">
                                                                <tr>
                                                                    <td><dx:ASPxLabel ID="ASPxLabel8" Font-Bold="true" runat="server" Text="CONCEPTO"></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="ASPxLabel9" Font-Bold="true" runat="server" Text="MZ"></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="ASPxLabel10" Font-Bold="true" runat="server" Text="TOTAL TC"></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="ASPxLabel11" Font-Bold="true" runat="server" Text="TC/MZ"></dx:ASPxLabel></td>
                                                                </tr>
                                                                <tr>
                                                                    <td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="CONTRATADO"></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="lblCONTRATADO_MZ" runat="server" Text="" Width="150px"></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="lblCONTRATADO_TC" runat="server" Text=""  Width="150px"></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="lblCONTRATADO_TC_MZ" runat="server" Text=""  Width="150px"></dx:ASPxLabel></td>
                                                                </tr>
                                                                <tr>
                                                                    <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="ESTICAÑA"></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="lblESTI_MZ" runat="server" Text=""></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="lblESTI_TC" runat="server" Text=""></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="lblESTI_TC_MZ" runat="server" Text=""></dx:ASPxLabel></td>
                                                                </tr>
                                                                <tr>
                                                                    <td><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="POR ENTREGAR"></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="lblENTREGAR_MZ" runat="server" Text=""></dx:ASPxLabel></td>
                                                                    <td class="auto-style1"><dx:ASPxLabel ID="lblENTREGAR_TC" runat="server" Text=""></dx:ASPxLabel></td>
                                                                    <td><dx:ASPxLabel ID="lblENTREGAR_TC_MZ" runat="server" Text=""></dx:ASPxLabel></td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Productor:"></dx:ASPxLabel></td>
                                                        <td colspan="7">
                                                            <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="100%">
                                                            </dx:ASPxTextBox>
                                                        </td>                                                        
                                                    </tr>
                                                    <tr>
                                                        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Nombre lote:"></dx:ASPxLabel></td>
                                                        <td colspan="7">
                                                            <dx:ASPxTextBox ID="txtNOMBLOTE" runat="server" Width="100%">
                                                            </dx:ASPxTextBox>
                                                        </td>                                                        
                                                    </tr>
                                                    <tr>
                                                        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="No. Contrato:"></dx:ASPxLabel></td>
                                                        <td>
                                                            <dx:ASPxSpinEdit ID="speNO_CONTRATO" runat="server" HorizontalAlign="Right" Width="100px">
                                                            </dx:ASPxSpinEdit>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Técnico:"></dx:ASPxLabel></td>
                                                        <th colspan="5">
                                                            <dx:ASPxComboBox ID="cbxAGRONOMO" ClientInstanceName="cbxAGRONOMO" Width="100%" DropDownStyle="DropDownList" runat="server" DataSourceID="odsAgronomo" 
                                                                ValueField="CODIAGRON" TextField="APELLIDO_AGRONOMO" ValueType="System.String" TextFormatString="{0} {1} {2}" IncrementalFilteringMode="Contains">
                                                                    <Columns>
                                                                    <dx:ListBoxColumn Caption="Codigo" FieldName="CODIAGRON" Width="80px" />
                                                                    <dx:ListBoxColumn Caption="Apellidos" FieldName="APELLIDO_AGRONOMO" Width="120px" />
                                                                    <dx:ListBoxColumn Caption="Nombres" FieldName="NOMBRE_AGRONOMO" Width="120px" />                                                            
                                                                    </Columns>
                                                            </dx:ASPxComboBox>
                                                        </th> 
                                                    </tr>                                                   
                                                </table>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                    </Items>
                                </dx:LayoutGroup>
                            </Items>

<SettingsItemCaptions Location="Left"></SettingsItemCaptions>
                        </dx:ASPxFormLayout>
                </TD>
		    </TR>
	        <TR>
            <TD>
                <uc1:ucListaLOTES_COSECHA id="ucListaLOTES_COSECHA1" TamanoPagina="100" PermitirEditar="false" PermitirOrdenar="false" PermitirEditarInline2="true" PermitirVistaCerrarLote="true" VerZONA="true"  VerES_CONTRATADO="true"  VerID_LOTES_COSECHA="true" VerACCESLOTE="true" VerMZ_CONTRATO="true" VerTC_CONTRATO="true" VerSALDO_QUEMA="false" VerSALDO_ROZA="false" VerVARIEDAD="true" VerCICLO="true" VerFAB_CATORCENA="true" PermitirEliminar="false" runat="server"></uc1:ucListaLOTES_COSECHA>
                <uc1:ucVistaDetalleCONTROL_ROZA ID="ucVistaDetalleCONTROL_ROZA1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTROL_ROZA>
                <uc1:ucVistaDetalleCONTROL_QUEMA ID="ucVistaDetalleCONTROL_QUEMA1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTROL_QUEMA>
            </TD>
            </TR>
    </TBODY>
</TABLE>


<dx:ASPxPopupControl ID="pcEsticana" runat="server" CloseAction="CloseButton" Modal="True" Width="900px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcEsticana"
        HeaderText="Modificación de Esticaña" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">  
                        <dx:ASPxLabel ID="lblpcError" runat="server" Font-Bold="true" ForeColor="Red" /><br />                                              
                        <table width="100%">
                            <tr>
                                <td>
                                    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" SettingsItemCaptions-Location="Left" Name="glCriterios">
                                        <Items>
                                            <dx:LayoutGroup ShowCaption="False" ColCount="4" GroupBoxDecoration="Box">
                                                <Items>
                                                    <dx:LayoutItem Caption="Cod. Provee:">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                                                <dx:ASPxSpinEdit ID="speCODIPROVEEpop" runat="server" HorizontalAlign="Right" Width="100px">
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                   
                                                                </dx:ASPxSpinEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:LayoutItem Caption="Cod. Socio:">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                                                <dx:ASPxSpinEdit ID="speCODISOCIOpop" runat="server" HorizontalAlign="Right" 
                                                                    Width="180px">
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxSpinEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:LayoutItem Caption="Nombre Proveedor:" ColSpan="2">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                                                                <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDORpop" runat="server" Width="400px">                                                                    
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Cod. Lote:">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                                                <dx:ASPxTextBox ID="txtCODILOTEpop" HorizontalAlign="Right" runat="server" Width="100px">
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:LayoutItem Caption="Lote" ColSpan="3">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                                                <dx:ASPxTextBox ID="txtNOMBLOTEpop" runat="server" Width="100%">
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem  ShowCaption="false">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer17" runat="server">
                                                                <dx:ASPxCheckBox ID="chkFIN_LOTEpop" AutoPostBack="true" Text="Lote Cerrado" runat="server">
                                                                </dx:ASPxCheckBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:LayoutItem Caption="Fecha/Hora Cierre">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer18" runat="server">
                                                                <dx:ASPxDateEdit ID="dteFECHA_CIERRE" ClientInstanceName="dteFECHA_HORA_QUEMA" 
                                                                    runat="server" HorizontalAlign="Right" 
                                                                DisplayFormatString="dd/MM/yyyy hh:mm tt" EditFormat="Custom" UseMaskBehavior="True" 
                                                                EditFormatString="dd/MM/yyyy hh:mm tt" Width="180px">
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                <TimeSectionProperties Visible="true">
                                                                    <TimeEditProperties EditFormatString="hh:mm tt" />
                                                                </TimeSectionProperties>
                                                                </dx:ASPxDateEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:LayoutItem Caption="Horas de gracia de entrega">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer19" runat="server">
                                                                <dx:ASPxSpinEdit ID="speHORAS_GRACIA_ENTREGA" runat="server"  AllowNull="false"  HorizontalAlign="Right" Width="120px">
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxSpinEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>                                                    

                                                    <dx:LayoutItem ShowCaption="false" ColSpan="4">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                                                                <dx:ASPxTextBox ID="txtTitulopop" Enabled="false" runat="server" Text="PLAN DE COSECHA" HorizontalAlign="Center" BackColor="LightBlue" Width="100%">
                                                                    <DisabledStyle ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>                                                    
                                                    <dx:LayoutItem Caption="MZ">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                                                <dx:ASPxSpinEdit ID="speMZ_COSECHApop" AutoPostBack="true" DisplayFormatString="#0.00" runat="server" AllowNull="false"  HorizontalAlign="Right" Width="100px">
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>                                                                    
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxSpinEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:LayoutItem Caption="TC/MZ">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                                                                <dx:ASPxSpinEdit ID="speTC_MZ_COSECHApop" runat="server" AllowNull="false" 
                                                                    DisplayFormatString="#0.00" HorizontalAlign="Right" Width="180px">
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxSpinEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:LayoutItem Caption="TC">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                                                                <dx:ASPxSpinEdit ID="speTC_COSECHApop" AutoPostBack="true" runat="server" DisplayFormatString="#0.00" AllowNull="false" HorizontalAlign="Right" Width="120px">
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                 
                                                                </dx:ASPxSpinEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>

                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                                    <dx:LayoutItem Caption="TC Semilla">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">
                                                                <dx:ASPxSpinEdit ID="speTC_SEMILLApop" AutoPostBack="true" runat="server" DisplayFormatString="#0.00" AllowNull="false" HorizontalAlign="Right" Width="120px">
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxSpinEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>

                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                                    
                                                    <dx:LayoutItem Caption="TC Entregada">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                                                                <dx:ASPxSpinEdit ID="speTC_ENTREGADApop" AllowNull="false" runat="server" DisplayFormatString="#0.00" HorizontalAlign="Right" Width="120px">
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxSpinEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>

                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                                    <dx:LayoutItem Caption="TC Variacion">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer15" runat="server">
                                                                <dx:ASPxSpinEdit ID="speTC_VARIACIONpop" AllowNull="false" runat="server" DisplayFormatString="#0.00" HorizontalAlign="Right" Width="120px">
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxSpinEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>

                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                                    <dx:LayoutItem Caption="Saldo TC a Entregar">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer16" runat="server">
                                                                <dx:ASPxSpinEdit ID="speTC_ENTREGARpop" runat="server" AllowNull="false" DisplayFormatString="#0.00" HorizontalAlign="Right" Width="120px">
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxSpinEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                                 </Items>
                                            </dx:LayoutGroup>
                                        </Items> 
                                        <SettingsItemCaptions Location="Left"></SettingsItemCaptions>
                                    </dx:ASPxFormLayout>
                                </td>                                
                            </tr>
                             
                        </table>
                        <hr />
                        <table width="100%">                            
                            <tr>
                                <td style="padding-right:7px; text-align:right">
                                    <dx:ASPxButton ID="btnAceptar" runat="server" AutoPostBack="true" Text="Aceptar">                                        
                                    </dx:ASPxButton>    
                                </td>
                                <td style="padding-left:7px">  
                                    <dx:ASPxButton ID="btnCancelar" runat="server" Text="Cancelar">
                                        <ClientSideEvents Click="function(s,e){pcEsticana.Hide()}" /> 
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
<asp:ObjectDataSource ID="odsAgronomo" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorESTADO" 
    TypeName="SISPACAL.BL.cAGRONOMO">
    <SelectParameters>
        <asp:Parameter DefaultValue="1" Name="ESTADO_AGRONOMO" Type="Int32" />
        <asp:Parameter DefaultValue="false" Name="AgregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="true" Name="AgregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="APELLIDO_AGRONOMO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>