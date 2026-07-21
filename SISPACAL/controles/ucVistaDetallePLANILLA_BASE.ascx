<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePLANILLA_BASE.ascx.vb" Inherits="controles_ucVistaDetallePLANILLA_BASE" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_PLANILLA_BASE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblID_PLANILLA_BASE" runat="server" Text="Id planilla base:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_PLANILLA_BASE" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ZAFRA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblID_ZAFRA" runat="server" Text="Zafra:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA" runat="server" Width="170px"  ></cc1:ddlZAFRA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_CATORCENA" visible="false" >
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblID_CATORCENA" runat="server" Text="Id catorcena:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtID_CATORCENA" runat="server" Height="21px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Id catorcena es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIPO_PLANILLA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblID_TIPO_PLANILLA" runat="server" Text="Tipo planilla:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlTIPO_PLANILLA id="ddlTIPO_PLANILLAID_TIPO_PLANILLA" runat="server" Width="500px"  ></cc1:ddlTIPO_PLANILLA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_INICIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblFECHA_INICIO" runat="server" Text="Fecha inicio:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_INICIO" runat="server" EditFormat="Custom" DisplayFormatString="dd/MM/yyyy"   >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
                <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" />
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_FIN">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblFECHA_FIN" runat="server" Text="Fecha fin:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_FIN" runat="server" EditFormat="Custom" DisplayFormatString="dd/MM/yyyy" >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
                <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" />
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_PAGO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblFECHA_PAGO" runat="server" Text="Fecha de Pago:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_PAGO" runat="server" EEditFormat="Custom" DisplayFormatString="dd/MM/yyyy" >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
                <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" />
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<tr runat="server" id="trFECHA_COMPROB">
				<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="ASPxLabel1" runat="server" Text="Fecha de comprobantes fiscales:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_COMPROB" runat="server" EEditFormat="Custom" DisplayFormatString="dd/MM/yyyy" >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
                <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" />
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</tr>
	<TR runat="server" id="trNO_ANTICIPO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblNO_ANTICIPO" runat="server" Text="No anticipo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtNO_ANTICIPO" runat="server" Height="21px" Number="0" NumberType="Integer">			   
                <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" />
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNO_ANTICIPO_LETRAS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblNO_ANTICIPO_LETRAS" runat="server" Text="No anticipo letras:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNO_ANTICIPO_LETRAS" runat="server" Width="170px" MaxLength="255">			    
                <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" />
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trVALOR_UNIT_PAGO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblVALOR_UNIT_PAGO" runat="server" Text="Valor unit pago:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtVALOR_UNIT_PAGO" runat="server" Height="21px" Width="500px" Number="0">
			    <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" />
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>	
	<TR runat="server" id="trCONCEPTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="lblCONCEPTO" runat="server" Text="Concepto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtCONCEPTO" runat="server" Width="500px" MaxLength="255">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="tr1">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel  id="ASPxLabel2" runat="server" Text="Cuenta Contable para caña de azúcar en CHEQUES/Nota de cargo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtCTACONTA_PLANI_CANA" runat="server" Width="170px" MaxLength="30">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
