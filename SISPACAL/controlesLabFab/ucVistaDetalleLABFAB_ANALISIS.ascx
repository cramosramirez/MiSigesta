<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleLABFAB_ANALISIS.ascx.vb" Inherits="controles_ucVistaDetalleLABFAB_ANALISIS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaLABFAB_VAR" Src="~/controlesLabFab/ucListaLABFAB_VAR.ascx" %>

<center>
<TABLE id="VistaDetalle" border="0">
    <TR runat="server" id="trID_ANALISIS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ANALISIS" runat="server" Text="Id analisis:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_ANALISIS" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
    <TR runat="server" id="trID_ETAPA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel1" runat="server" Text="Etapa:"></dx:ASPxLabel></TD>
		<TD>
		    <dx:ASPxComboBox ID="cbxLABFAB_ETAPA" AutoPostBack="true" DropDownStyle="DropDownList" runat="server" DataSourceID="odsLABFAB_ETAPA" ValueField="ID_ETAPA" TextField="NOMBRE_ETAPA" ValueType="System.Int32" Width="350px" >
                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" >
                    <RequiredField ErrorText="Etapa es requerido" IsRequired="true" /> 
                </ValidationSettings>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black">                   
                </DisabledStyle>
            </dx:ASPxComboBox>	
        </TD>
		<TD width="10"></TD>
	</TR>
    <TR runat="server" id="trID_MUESTRA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel2" runat="server" Text="Muestra:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox ID="cbxLABFAB_MUESTRA" DropDownStyle="DropDownList" runat="server" ValueField="ID_MUESTRA" TextField="NOMBRE_MUESTRA" ValueType="System.Int32" Width="350px" >
                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" >
                    <RequiredField ErrorText="Muestra es requerido" IsRequired="true" /> 
                </ValidationSettings>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black">                   
                </DisabledStyle>
            </dx:ASPxComboBox>	
        </TD>
		<TD width="10"></TD>
	</TR>	
	<TR runat="server" id="trNOMBRE_ANALISIS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_ANALISIS" runat="server" Text="Análisis:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox id="txtNOMBRE_ANALISIS" runat="server" Width="350px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Nombre analisis es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFORMULA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFORMULA" runat="server" Text="Fórmula:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox id="txtFORMULA" runat="server" Width="350px" MaxLength="200">			   
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOBSERVACIONES">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblOBSERVACIONES" runat="server" Text="Observaciones:"></dx:ASPxLabel></TD>
		<TD>
            <dx:ASPxMemo ID="txtOBSERVACIONES" runat="server" Height="50px" Width="500px" MaxLength="500">
            </dx:ASPxMemo>			
        </TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCANT_ANALISIS">    
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCANT_ANALISIS" runat="server" Text="Cant. Analisis x Día:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtCANT_ANALISIS" runat="server" Width="100px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Cant analisis es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
    <TR runat="server" id="trORDEN_EJEC">    
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel3" runat="server" Text="Orden de Ejecución:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtORDEN_EJEC" runat="server" Width="100px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Orden Ejecución es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_CREA" visible="false"  >
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSUARIO_CREA" runat="server" Text="Usuario crea:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CREA" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Usuario crea es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_CREA" visible="false" >
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_CREA" runat="server" Text="Fecha crea:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_CREA" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_ACT" visible="false" >
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSUARIO_ACT" runat="server" Text="Usuario act:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_ACT" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Usuario act es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_ACT" visible="false" >
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_ACT" runat="server" Text="Fecha act:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_ACT" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />  
<br />
<uc1:ucListaLABFAB_VAR id="ucListaLABFAB_VAR1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="false" runat="server"></uc1:ucListaLABFAB_VAR>                                    
</center>

<asp:ObjectDataSource ID="odsLABFAB_ETAPA" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cLABFAB_ETAPA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ID_ETAPA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>