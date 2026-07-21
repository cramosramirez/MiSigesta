<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAsignacionTransporte.ascx.vb" Inherits="controlesProforma_ucAsignacionTransporte" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>

<style type="text/css">
    .auto-style1 {
        width: 400px;
    }
</style>

<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
		<td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
	<tr>
		<td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">ASIGNACIÓN DE TRANSPORTE</asp:Label></td>
	</tr>
	<tr id="trProformaExtraordinario" runat="server" visible="false" >
		<td align="center"><dx:ASPxLabel ID="ASPxLabel23" runat="server"  Text="PROFORMA EXTRAORDINARIO" Theme="Moderno" Font-Bold="True" Font-Size="Large" ForeColor="Red" /></td>
	</tr>
	<tr>
		<td style="padding-left:40px;" >
			<br />
			<table>
				<tr>
					<td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="ZAFRA:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="170px" AutoPostBack="true" Font-Bold="True" Theme="Moderno" ClientEnabled="false"  >
							<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxComboBox>
					</td>
					<td style="padding-left:20px"><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="ASIGNACION MANUAL:" Theme="Moderno" /></td>
					<td class="auto-style1" align="left">
						<dx:ASPxCheckBox runat="server" ID="chkASIG_MANUAL" AutoPostBack="true"  Theme="Moderno" />
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="CODIGO MOTORISTA *:" Theme="Moderno" ForeColor="Blue"  /></td>
					<td>
						<dx:ASPxSpinEdit ID="speID_MOTORISTA_VEHI" AutoPostBack="true" HorizontalAlign="Left" ForeColor="Blue" Font-Bold="true" runat="server" Width="170px" Theme="Moderno">
							<SpinButtons ShowIncrementButtons="False"></SpinButtons>
							<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
					</td>
					<td style="padding-left:20px"><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="NOMBRE MOTORISTA:" Theme="Moderno" /></td>
					<td class="auto-style1">
						<dx:ASPxTextBox ID="txtNOMBRE_MOTORISTA" Font-Bold="true" runat="server" Width="400px" Theme="Moderno">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
				</tr>		
				<tr>
					<td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="PLACA:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtPLACA" Font-Bold="true" runat="server" Width="170px" Theme="Moderno">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td style="padding-left:20px"><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="TIPO TRANSPORTE:" Theme="Moderno" /></td>
					<td class="auto-style1">
						<dx:ASPxTextBox ID="txtTIPO_TRANSPORTE" Font-Bold="true" runat="server" Width="400px" Theme="Moderno">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>	
					<td style="padding-left:20px"><dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="CONDICION:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtCONDICION_TRANSPORTE" Font-Bold="true" runat="server" Width="170px" Theme="Moderno">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="CODIGO TRANSPORTISTA:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtCODTRANSPORT" Font-Bold="true" runat="server" Width="170px" Theme="Moderno">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td style="padding-left:20px"><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="TRANSPORTISTA:" Theme="Moderno" /></td>
					<td class="auto-style1">
						<dx:ASPxTextBox ID="txtNOMBRE_TRANSPORTISTA" Font-Bold="true" runat="server" Width="400px" Theme="Moderno">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<th colspan="4" ><hr /></th>
	</tr>
</table>
<table id="tblDestino" visible="false" runat="server" cellspacing="0" cellpadding="0" width="100%" border="0">
	<tr>		
		<td align="center" class="EncabezadoSecciones">
			<br />
			<asp:Label id="Label1" style="Z-INDEX: 101" runat="server">DESTINO ASIGNADO</asp:Label>			
		</td>
	</tr>
	<tr>
		<td>
			<br />
			<table>
				<tr>
					<td><dx:ASPxLabel ID="ASPxLabel20" runat="server" Text="CONTRATO:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtNO_CONTRATO" Font-Bold="true" runat="server" Width="200px" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td><dx:ASPxLabel ID="ASPxLabel21" runat="server" Text="ZONA:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtZONA" Font-Bold="true" runat="server" Width="350px" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="COD. PRODUCTOR:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtCODIPROVEEDOR" Font-Bold="true" runat="server" Width="200px" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="PRODUCTOR:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtPRODUCTOR" Font-Bold="true" runat="server" Width="350px" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="COD. LOTE:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtCODILOTE" Font-Bold="true" runat="server" Width="200px" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="LOTE:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtLOTE" Font-Bold="true" runat="server" Width="350" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="TIPO CAÑA:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtTIPO_CANA" Font-Bold="true" runat="server" Width="200px" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="TIPO QUEMA:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtTIPO_QUEMA" Font-Bold="true" runat="server" Width="350px" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="FECHA QUEMA" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtFECHA_QUEMA" Font-Bold="true" runat="server" Width="200px" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td><dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="CARGADORA:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtCARGADORA" Font-Bold="true" runat="server" Width="350" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
				</tr>
				<tr>
					<td><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="TIPO ROZA:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtTIPO_ROZA" Font-Bold="true" runat="server" Width="200px" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td><dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="FECHA ROZA:" Theme="Moderno" /></td>
					<td>
						<dx:ASPxTextBox ID="txtFECHA_ROZA" Font-Bold="true" runat="server" Width="350px" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</td>
					<td><dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="FRENTE QUERQUEO:" Theme="Moderno" /></td>
					<th colspan="3" >
						<dx:ASPxTextBox ID="txtFRENTE_QUERQUEO" Font-Bold="true" runat="server" Width="100%" Theme="Moderno" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxTextBox>
					</th>
				</tr>
			</table>
		</td>
	</tr>
</table>
<table id="tblAsignacionManual" visible="false" runat="server" cellspacing="0" cellpadding="0" width="100%" border="0">
	<tr>		
		<td align="center" class="EncabezadoSecciones">
			<br />
			<asp:Label id="Label2" style="Z-INDEX: 101" runat="server">SELECCIONE LOTE A ASIGNAR</asp:Label>					
		</td>
	</tr>
	<tr>
		<td>
			<br />
			<dx:ASPxGridView ID="gridLotesDisponibles" runat="server" Theme="Metropolis" AutoGenerateColumns="False" Width="100%" Font-Names="Arial" KeyFieldName="ID_CC_TIPOTRANS">
				<SettingsPager>				
				<Summary AllPagesText="Pags: {0} - {1} ({2} registros)" Text="Pag. {0} de {1} ({2} registros)" />								
				<PageSizeItemSettings Visible="true" Items="10, 20, 50" />
				</SettingsPager>
				<SettingsSearchPanel Visible="true" />
				<SettingsBehavior AllowSelectSingleRowOnly="true" />								
				<Columns>
					<dx:GridViewCommandColumn ShowSelectCheckbox="True" Caption=" " Name="CheckSeleccionar" Width="10px" VisibleIndex="0">                                  
					</dx:GridViewCommandColumn>
					<dx:GridViewDataTextColumn FieldName="ID_CC_TIPOTRANS" VisibleIndex="1" Caption="Id zafra" Visible="false" />
					<dx:GridViewDataTextColumn FieldName="DIA" VisibleIndex="1" Caption="Día" Width="30px" CellStyle-HorizontalAlign="Center"  />
					<dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="1" Caption="Fecha" Width="30px" CellStyle-HorizontalAlign="Center">
						<PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="ZONA" VisibleIndex="1" Caption="Zona" Width="30px" CellStyle-HorizontalAlign="Center"  />
					<dx:GridViewDataTextColumn FieldName="CARGADORA" VisibleIndex="1" Caption="Cargadora / Cosechadora" Width="180px" />
					<dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="1" Caption="Cod.Prod" Width="80px"  />
					<dx:GridViewDataTextColumn FieldName="PRODUCTOR" VisibleIndex="1" Caption="Productor" />
					<dx:GridViewDataTextColumn FieldName="CODILOTE" VisibleIndex="1" Caption="CodLote" Width="40px"  />
					<dx:GridViewDataTextColumn FieldName="LOTE" VisibleIndex="1" Caption="Lote" />
					<dx:GridViewDataTextColumn FieldName="ORDEN" VisibleIndex="1" Caption="Orden" Width="30px" CellStyle-HorizontalAlign="Center"  />
					<dx:GridViewDataTextColumn FieldName="TIPO_TRANSPORTE" VisibleIndex="1" Caption="Tipo transporte" />
					<dx:GridViewDataTextColumn FieldName="UNIDADES_SOLI" VisibleIndex="1" Caption="Uni. Solicitadas" Width="100px" CellStyle-HorizontalAlign="Center"  />
					<dx:GridViewDataTextColumn FieldName="UNIDADES_ENV" VisibleIndex="1" Caption="Uni. Asignadas" Width="100px" CellStyle-HorizontalAlign="Center"  />
					<dx:GridViewDataTextColumn FieldName="FEC_ULT_ASIGNACION" VisibleIndex="1" Caption="Ultima Asignación" Width="130px" CellStyle-HorizontalAlign="Center" >
						<PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm" />
					</dx:GridViewDataTextColumn>					
				</Columns>
			</dx:ASPxGridView>
		</td>
	</tr>
</table>
<dx:ASPxHiddenField runat="server" ID="hdID_ASIGNACION"  />  
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>	

<asp:ObjectDataSource ID="odsSP_CC_ASIGNAR_LOTE_TRANS" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="SP_CC_ASIGNAR_LOTE_TRANS" 
    TypeName="SISPACAL.BL.cPROFORMA">  
    <SelectParameters>        
        <asp:Parameter DefaultValue="" Name="OPCION" Type="String" />
        <asp:Parameter DefaultValue="0" Name="ID_ZAFRA" Type="Int32" />
		<asp:Parameter DefaultValue="0" Name="ID_MOTORISTA_VEHI" Type="Int32" />
		<asp:Parameter DefaultValue="0" Name="ID_ASIGNACION" Type="Int32" />
		<asp:Parameter DefaultValue="" Name="USUARIO" Type="String" />
		<asp:Parameter DefaultValue="0" Name="ID_PROFORMA" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>