<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePROVEEDOR_AGRICOLA.ascx.vb" Inherits="controles_ucVistaDetallePROVEEDOR_AGRICOLA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<table width="1000px" style="margin-left:20px" >
	<tr>
		<td width="150px"><dx:ASPxLabel id="ASPxLabel1" runat="server" Text="Tipo persona:" Theme="Moderno" /></td>
		<td><dx:ASPxComboBox ID="cbxTIPO_PERSONA" AutoPostBack="true" runat="server" Font-Bold="true" DataSourceID="odsTipoPersona" TextField="DESCRIPCION" ValueField="ID_TIPO_PERSONA"  ValueType="System.Int32" >                                     
			<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
            </dx:ASPxComboBox>
		</td>
		<td width="120px"></td>
		<td></td>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel2" runat="server" Text="DUI:" Theme="Moderno" /></td>
		<td><dx:ASPxTextBox ID="txtDUI" Font-Bold="true" runat="server" AutoPostBack="true" >
                    <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                        Mask="99999999-9" /> 
				<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
                </dx:ASPxTextBox>
		</td>
		<td><dx:ASPxLabel id="ASPxLabel3" runat="server" Text="NIT:" Theme="Moderno" /></td>
		<td><dx:ASPxTextBox ID="txtNIT" Font-Bold="true" runat="server" AutoPostBack="true">
					<MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
						Mask="9999-999999-999-9" ErrorText="NIT no valido"  />	
					<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
			</dx:ASPxTextBox>
		</td>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel12" runat="server" Text="Identificador:" Theme="Moderno" /></td>
		<th colspan="3"><dx:ASPxTextBox ID="txtID_PROVEE" Font-Bold="true" MaxLength="10" runat="server" ClientEnabled="false" >    
			<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
            </dx:ASPxTextBox>
		</th>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel4" runat="server" Text="Nombres:" Theme="Moderno" /></td>
		<th colspan="3"><dx:ASPxTextBox ID="txtNOMBRES" Font-Bold="true" MaxLength="150" runat="server" Width="100%" > 
			<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
            </dx:ASPxTextBox>
		</th>		
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel5" runat="server" Text="Apellidos:" Theme="Moderno" /></td>
		<th colspan="3"><dx:ASPxTextBox ID="txtAPELLIDOS" Font-Bold="true" MaxLength="150" runat="server" Width="100%" >  
			<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
            </dx:ASPxTextBox>
		</th>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel6" runat="server" Text="Dirección:" Theme="Moderno" /></td>
		<th colspan="3"><dx:ASPxTextBox ID="txtDIRECCION" MaxLength="150" runat="server" Width="100%" > 
			<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
            </dx:ASPxTextBox>
		</th>		
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel7" runat="server" Text="Departamento:" Theme="Moderno" /></td>
		<td><dx:ASPxComboBox ID="cbxDEPARTAMENTO" AutoPostBack="true" runat="server" DataSourceID="odsDepartamento" TextField="NOMBRE_DEPTO" ValueField="CODI_DEPTO"  >                                     
			<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
            </dx:ASPxComboBox>
		</td>
		<td><dx:ASPxLabel id="ASPxLabel8" runat="server" Text="Municipio:" Theme="Moderno" /></td>
		<td><dx:ASPxComboBox ID="cbxMUNICIPIO" ShowLoadingPanel="true" LoadingPanelText="Cargando..." TextField="NOMBRE_MUNI" ValueField="CODI_MUNI" runat="server" DataSourceID="odsMunicipio">                                       
			<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
            </dx:ASPxComboBox>
		</td>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel9" runat="server" Text="Telefono(s):" Theme="Moderno" /></td>
		<th colspan="3">
			<dx:ASPxTextBox ID="txtTELEFONO" MaxLength="100" runat="server" Width="100%" >                            
            </dx:ASPxTextBox>
		</th>		
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel10" runat="server" Text="NRC:" Theme="Moderno" /></td>
		<td><dx:ASPxTextBox ID="txtNRC" MaxLength="20" runat="server" >                            
            </dx:ASPxTextBox>
		</td>
		<td><dx:ASPxLabel id="ASPxLabel11" runat="server" Text="Correo:" Theme="Moderno" /></td>
		<td><dx:ASPxTextBox ID="txtCORREO" MaxLength="200" runat="server" Width="100%" >                            
            </dx:ASPxTextBox>
		</td>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel14" runat="server" Text="Actividad primaria:" Theme="Moderno" /></td>
		<th colspan="3">
			<dx:ASPxTextBox ID="txtACTIVIDAD" MaxLength="1000" runat="server" Width="100%" >                            
            </dx:ASPxTextBox>
		</th>		
	</tr>	
	<tr>
		<th colspan="4"><br /></th>
	</tr>
	<tr>		
		<td><dx:ASPxCheckBox ID="chkES_CASA_COMERCIAL" runat="server" TextAlign="Right" Text="Es Casa comercial" Theme="Moderno"></dx:ASPxCheckBox></td>
		<th colspan="3"></th> 
	</tr>
	<tr>		
		<td><dx:ASPxCheckBox ID="chkES_PROVEEDOR_VUELO" runat="server" TextAlign="Right" Text="Es Proveedor de Vuelo" AutoPostBack="true" Theme="Moderno"  ></dx:ASPxCheckBox></td>
		<th colspan="3"></th> 
	</tr>
	<tr id="trTARIFAS_VUELO" runat="server">
		<th colspan="4" >
			<table style="margin-left: 20px" >
				<tr>
					<th colspan="2">
						<dx:ASPxLabel ID="lblTarifas" runat="server" Text="TARIFAS DE VUELO" Theme="Moderno" Font-Bold="true"></dx:ASPxLabel>
					</th> 
				</tr>
				<tr>
					<td style="text-align:left" width="100px" ><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="AVION" Theme="Moderno"></dx:ASPxLabel></td>
					<td>
            <dx:ASPxSpinEdit runat="server" Number="0" HorizontalAlign="Right" Width="80px" DisplayFormatString="#,##0.00"  ID="speTARIFA_AVION">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
</dx:ASPxSpinEdit>

                    </td>
				</tr>
				<tr>
					<td style="text-align:left"><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="DRON" Theme="Moderno"></dx:ASPxLabel></td>
					<td>
            <dx:ASPxSpinEdit runat="server" Number="0" HorizontalAlign="Right" Width="80px" DisplayFormatString="#,##0.00" ID="speTARIFA_DRON">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
</dx:ASPxSpinEdit>

                    </td>
				</tr>
				<tr>
					<td style="text-align:left"><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="HELICOPTERO" Theme="Moderno"></dx:ASPxLabel></td>
					<td>
            <dx:ASPxSpinEdit runat="server" Number="0" HorizontalAlign="Right" Width="80px" DisplayFormatString="#,##0.00" ID="speTARIFA_HELICOPTERO">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
</dx:ASPxSpinEdit>

                    </td>
				</tr>
			</table>
		</th>
	</tr>
</table>
<asp:ObjectDataSource ID="odsDepartamento" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cDEPARTAMENTO">
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsMunicipio" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cMUNICIPIO">
    <SelectParameters>      
        <asp:Parameter DefaultValue="" Name="CODI_DEPTO" Type="String" />
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsTipoPersona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPO_PERSONA">
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>