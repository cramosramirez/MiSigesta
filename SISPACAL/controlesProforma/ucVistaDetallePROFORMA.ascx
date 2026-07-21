<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePROFORMA.ascx.vb" Inherits="controles_ucVistaDetallePROFORMA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_PROFORMA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PROFORMA" runat="server" Text="Id proforma:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_PROFORMA" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ZAFRA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ZAFRA" runat="server" Text="Zafra:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA" runat="server" CssClass="DDLClass"></cc1:ddlZAFRA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDIAZAFRA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDIAZAFRA" runat="server" Text="Diazafra:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtDIAZAFRA" runat="server" Height="21px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Diazafra es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOPROFORMA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOPROFORMA" runat="server" Text="Noproforma:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtNOPROFORMA" runat="server" Height="21px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Noproforma es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODICONTRATO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODICONTRATO" runat="server" Text="Codicontrato:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtCODICONTRATO" runat="server" Width="100px" MaxLength="13">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Codicontrato es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIPROVEEDOR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIPROVEEDOR" runat="server" Text="Codiproveedor:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtCODIPROVEEDOR" runat="server" Width="100px" MaxLength="10">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Codiproveedor es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trACCESLOTE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblACCESLOTE" runat="server" Text="Acceslote:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtACCESLOTE" runat="server" Width="100px" MaxLength="21">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Acceslote es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODTRANSPORT">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODTRANSPORT" runat="server" Text="Codtransport:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtCODTRANSPORT" runat="server" Height="21px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Codtransport es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRES_MOTORISTA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRES_MOTORISTA" runat="server" Text="Nombres motorista:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRES_MOTORISTA" runat="server" Width="100px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Nombres motorista es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIPO_CANA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_TIPO_CANA" runat="server" Text="Tipo cana:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlTIPO_CANA id="ddlTIPO_CANAID_TIPO_CANA" runat="server" CssClass="DDLClass"></cc1:ddlTIPO_CANA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_CARGADORA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_CARGADORA" runat="server" Text="Cargadora:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlCARGADORA id="ddlCARGADORAID_CARGADORA" runat="server" CssClass="DDLClass"></cc1:ddlCARGADORA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_SUPERVISOR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_SUPERVISOR" runat="server" Text="Supervisor:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlSUPERVISOR id="ddlSUPERVISORID_SUPERVISOR" runat="server" CssClass="DDLClass"></cc1:ddlSUPERVISOR></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_QUEMA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_QUEMA" runat="server" Text="Fecha quema:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_QUEMA" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_CORTA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_CORTA" runat="server" Text="Fecha corta:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_CORTA" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trQUEMAPROG">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblQUEMAPROG" runat="server" Text="Quemaprog:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxQUEMAPROG" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trQUEMANOPROG">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblQUEMANOPROG" runat="server" Text="Quemanoprog:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxQUEMANOPROG" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_CARGA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_CARGA" runat="server" Text="Fecha carga:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_CARGA" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_PATIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_PATIO" runat="server" Text="Fecha patio:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_PATIO" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PRODUCTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PRODUCTO" runat="server" Text="Producto:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlPRODUCTO id="ddlPRODUCTOID_PRODUCTO" runat="server" CssClass="DDLClass"></cc1:ddlPRODUCTO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFIN_LOTE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFIN_LOTE" runat="server" Text="Fin lote:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxFIN_LOTE" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_ENTRADA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_ENTRADA" runat="server" Text="Fecha entrada:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_ENTRADA" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPLACAVEHIC">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblPLACAVEHIC" runat="server" Text="Placavehic:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtPLACAVEHIC" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Placavehic es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIPOTRANS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_TIPOTRANS" runat="server" Text="Tipo transporte:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlTIPO_TRANSPORTE id="ddlTIPO_TRANSPORTEID_TIPOTRANS" runat="server" CssClass="DDLClass"></cc1:ddlTIPO_TRANSPORTE></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trSERVICIO_ROZA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblSERVICIO_ROZA" runat="server" Text="Servicio roza:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxSERVICIO_ROZA" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTRANSPORTE_PROPIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTRANSPORTE_PROPIO" runat="server" Text="Transporte propio:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox id="cbxTRANSPORTE_PROPIO" runat="server"></dx:ASPxCheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PROVEEDOR_ROZA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PROVEEDOR_ROZA" runat="server" Text="Proveedor roza:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlPROVEEDOR_ROZA id="ddlPROVEEDOR_ROZAID_PROVEEDOR_ROZA" runat="server" CssClass="DDLClass"></cc1:ddlPROVEEDOR_ROZA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_CARGADOR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_CARGADOR" runat="server" Text="Cargador:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlCARGADOR id="ddlCARGADORID_CARGADOR" runat="server" CssClass="DDLClass"></cc1:ddlCARGADOR></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIPO_TARIFA_CARGADORA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTIPO_TARIFA_CARGADORA" runat="server" Text="Tipo tarifa cargadora:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtTIPO_TARIFA_CARGADORA" runat="server" Height="21px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_MOTORISTA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_MOTORISTA" runat="server" Text="Id motorista:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtID_MOTORISTA" runat="server" Height="21px" Number="0" NumberType="Integer">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOBSERVACIONES">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblOBSERVACIONES" runat="server" Text="Observaciones:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtOBSERVACIONES" runat="server" Width="100px" MaxLength="600">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ENVIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ENVIO" runat="server" Text="Envio:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlENVIO id="ddlENVIOID_ENVIO" runat="server" CssClass="DDLClass"></cc1:ddlENVIO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trESTADO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblESTADO" runat="server" Text="Estado:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtESTADO" runat="server" Width="100px" MaxLength="5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Estado es requerido" IsRequired="True" />
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
