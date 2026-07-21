<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCUENTA_FINAN.ascx.vb" Inherits="controles_ucVistaDetalleCUENTA_FINAN" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_CUENTA_FINAN">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_CUENTA_FINAN" runat="server" Text="Id cuenta finan:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_CUENTA_FINAN" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_CUENTA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_CUENTA" runat="server" Text="Codigo cuenta:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtCODIGO_CUENTA" runat="server" Width="100px" MaxLength="10">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Codigo cuenta es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_CUENTA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_CUENTA" runat="server" Text="Nombre cuenta:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_CUENTA" runat="server" Width="100px" MaxLength="150">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Nombre cuenta es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESCRIP_CUENTA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDESCRIP_CUENTA" runat="server" Text="Descrip cuenta:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDESCRIP_CUENTA" runat="server" Width="100px" MaxLength="200">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIPO_FTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTIPO_FTO" runat="server" Text="Tipo fto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtTIPO_FTO" runat="server" Height="21px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Tipo fto es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAPLICA_SOLIC_AGRICOLA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblAPLICA_SOLIC_AGRICOLA" runat="server" Text="Aplica solic agricola:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxAPLICA_SOLIC_AGRICOLA" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAPLICA_ANALIS_FTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblAPLICA_ANALIS_FTO" runat="server" Text="Aplica analis fto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxAPLICA_ANALIS_FTO" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAPLICA_FACTURACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblAPLICA_FACTURACION" runat="server" Text="Aplica facturacion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxAPLICA_FACTURACION" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAPLICA_INTERES">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblAPLICA_INTERES" runat="server" Text="Aplica interes:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxAPLICA_INTERES" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAPLICA_EMISION_CHEQ">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblAPLICA_EMISION_CHEQ" runat="server" Text="Aplica emision cheq:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxAPLICA_EMISION_CHEQ" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAPLICA_DESCTO_PLA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblAPLICA_DESCTO_PLA" runat="server" Text="Aplica descto pla:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxAPLICA_DESCTO_PLA" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPORC_SUBSIDIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblPORC_SUBSIDIO" runat="server" Text="Porc subsidio:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtPORC_SUBSIDIO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Porc subsidio es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trZAFRA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblZAFRA" runat="server" Text="Zafra:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtZAFRA" runat="server" Width="100px" MaxLength="9">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Zafra es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_CREA">
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
	<TR runat="server" id="trFECHA_CREA">
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
	<TR runat="server" id="trUSUARIO_ACT">
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
	<TR runat="server" id="trFECHA_ACT">
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
