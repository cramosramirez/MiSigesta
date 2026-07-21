<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleBASE_PROVEEDORES_MH.ascx.vb" Inherits="controles_ucVistaDetalleBASE_PROVEEDORES_MH" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<table width="1000px">
	<tr>
		<td width="120px"><dx:ASPxLabel id="ASPxLabel1" runat="server" Text="Tipo persona:" /></td>
		<td><dx:ASPxComboBox ID="cbxTIPO_PERSONA" AutoPostBack="true" runat="server" Font-Bold="true" DataSourceID="odsTipoPersona" TextField="DESCRIPCION" ValueField="ID_TIPO_PERSONA"  ValueType="System.Int32" >                                     
            </dx:ASPxComboBox>
		</td>
		<td width="120px"></td>
		<td></td>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel2" runat="server" Text="DUI:" /></td>
		<td><dx:ASPxTextBox ID="txtDUI" Font-Bold="true" runat="server">
                    <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                        Mask="99999999-9" /> 
				<DisabledStyle BackColor="WhiteSmoke" />
                </dx:ASPxTextBox>
		</td>
		<td><dx:ASPxLabel id="ASPxLabel3" runat="server" Text="NIT:" /></td>
		<td><dx:ASPxTextBox ID="txtNIT" Font-Bold="true" runat="server">
					<MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
						Mask="9999-999999-999-9" ErrorText="NIT no valido"  />	
					<DisabledStyle BackColor="WhiteSmoke" />
			</dx:ASPxTextBox>
		</td>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel4" runat="server" Text="Nombres:" /></td>
		<th colspan="3"><dx:ASPxTextBox ID="txtNOMBRES" Font-Bold="true" MaxLength="150" runat="server" Width="100%" > 
			<DisabledStyle BackColor="WhiteSmoke" />
            </dx:ASPxTextBox>
		</th>		
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel5" runat="server" Text="Apellidos:" /></td>
		<th colspan="3"><dx:ASPxTextBox ID="txtAPELLIDOS" Font-Bold="true" MaxLength="150" runat="server" Width="100%" >  
			<DisabledStyle BackColor="WhiteSmoke" />
            </dx:ASPxTextBox>
		</th>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel6" runat="server" Text="Dirección:" /></td>
		<th colspan="3"><dx:ASPxTextBox ID="txtDIRECCION" MaxLength="150" runat="server" Width="100%" >                            
            </dx:ASPxTextBox>
		</th>		
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel7" runat="server" Text="Departamento:" /></td>
		<td><dx:ASPxComboBox ID="cbxDEPARTAMENTO" AutoPostBack="true" runat="server" DataSourceID="odsDepartamento" TextField="NOMBRE_DEPTO" ValueField="CODI_DEPTO"  >                                     
            </dx:ASPxComboBox>
		</td>
		<td><dx:ASPxLabel id="ASPxLabel8" runat="server" Text="Municipio:" /></td>
		<td><dx:ASPxComboBox ID="cbxMUNICIPIO" ShowLoadingPanel="true" LoadingPanelText="Cargando..." TextField="NOMBRE_MUNI" ValueField="CODI_MUNI" runat="server" DataSourceID="odsMunicipio">                                       
            </dx:ASPxComboBox>
		</td>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel9" runat="server" Text="Telefono(s):" /></td>
		<th colspan="3">
			<dx:ASPxTextBox ID="txtTELEFONO" MaxLength="100" runat="server" Width="100%" >                            
            </dx:ASPxTextBox>
		</th>		
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel10" runat="server" Text="NRC:" /></td>
		<td><dx:ASPxTextBox ID="txtNRC" MaxLength="15" runat="server" >                            
            </dx:ASPxTextBox>
		</td>
		<td><dx:ASPxLabel id="ASPxLabel11" runat="server" Text="Correo:" /></td>
		<td><dx:ASPxTextBox ID="txtCORREO" MaxLength="200" runat="server" Width="100%" >                            
            </dx:ASPxTextBox>
		</td>
	</tr>
	<tr>
		<td><dx:ASPxLabel id="ASPxLabel12" runat="server" Text="Actividad primaria:" /></td>
		<th colspan="3">
			<dx:ASPxTextBox ID="txtACTIVIDAD" MaxLength="1000" runat="server" Width="100%" >                            
            </dx:ASPxTextBox>
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

