<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleLABFAB_INFOVAR.ascx.vb" Inherits="controles_ucVistaDetalleLABFAB_INFOVAR" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_INFOVAR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_INFOVAR" runat="server" Text="Id infovar:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_INFOVAR" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_INFO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_INFO" runat="server" Text="Labfab informe:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlLABFAB_INFORME id="ddlLABFAB_INFORMEID_INFO" runat="server" CssClass="DDLClass"></cc1:ddlLABFAB_INFORME></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIPOVAR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_TIPOVAR" runat="server" Text="Labfab tipovar:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlLABFAB_TIPOVAR id="ddlLABFAB_TIPOVARID_TIPOVAR" runat="server" CssClass="DDLClass"></cc1:ddlLABFAB_TIPOVAR></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_CATEG">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_CATEG" runat="server" Text="Labfab categoria:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlLABFAB_CATEGORIA id="ddlLABFAB_CATEGORIAID_CATEG" runat="server" CssClass="DDLClass"></cc1:ddlLABFAB_CATEGORIA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trORDEN">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblORDEN" runat="server" Text="Orden:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtORDEN" runat="server" Height="21px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Orden es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_INFOVAR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_INFOVAR" runat="server" Text="Nombre infovar:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_INFOVAR" runat="server" Width="100px" MaxLength="200">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Nombre infovar es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESCRIP_VAR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDESCRIP_VAR" runat="server" Text="Descrip var:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDESCRIP_VAR" runat="server" Width="100px" MaxLength="200">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Descrip var es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ANALISIS_REF">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ANALISIS_REF" runat="server" Text="Id analisis ref:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtID_ANALISIS_REF" runat="server" Height="21px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_INFOVAR_REF">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_INFOVAR_REF" runat="server" Text="Id infovar ref:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtID_INFOVAR_REF" runat="server" Height="21px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trSQLREPO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblSQLREPO" runat="server" Text="Sqlrepo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtSQLREPO" runat="server" Width="100px" MaxLength="3000">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
