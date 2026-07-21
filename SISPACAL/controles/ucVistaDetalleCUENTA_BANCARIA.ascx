<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCUENTA_BANCARIA.ascx.vb" Inherits="controles_ucVistaDetalleCUENTA_BANCARIA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_CUENTA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_CUENTA" runat="server">Id cuenta:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_CUENTA" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNO_CUENTA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNO_CUENTA" runat="server">No cuenta:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNO_CUENTA" runat="server" Width="100px" MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator id="rfvNO_CUENTA" runat="server" Display="Dynamic" ControlToValidate="txtNO_CUENTA" ErrorMessage="No cuenta es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIBANCO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIBANCO" runat="server">Bancos:</asp:label></TD>
		<TD>
			<cc1:ddlBANCOS id="ddlBANCOSCODIBANCO" runat="server" CssClass="DDLClass"></cc1:ddlBANCOS></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCUENTA_CONTABLE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCUENTA_CONTABLE" runat="server">Cuenta contable:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtCUENTA_CONTABLE" runat="server" Width="100px" MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator id="rfvCUENTA_CONTABLE" runat="server" Display="Dynamic" ControlToValidate="txtCUENTA_CONTABLE" ErrorMessage="Cuenta contable es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESCRIPCION_CUENTA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESCRIPCION_CUENTA" runat="server">Descripcion cuenta:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtDESCRIPCION_CUENTA" runat="server" Width="300px" MaxLength="200"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESCRIPCION_CUENTA" runat="server" Display="Dynamic" ControlToValidate="txtDESCRIPCION_CUENTA" ErrorMessage="Descripcion cuenta es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trACTIVO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblACTIVO" runat="server">Activo:</asp:label></TD>
		<TD>
			<asp:CheckBox id="cbxACTIVO" runat="server"></asp:CheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_CREA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSUARIO_CREA" runat="server">Usuario crea:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CREA" runat="server" Width="100px" MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator id="rfvUSUARIO_CREA" runat="server" Display="Dynamic" ControlToValidate="txtUSUARIO_CREA" ErrorMessage="Usuario crea es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_CREA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_CREA" runat="server">Fecha crea:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_CREA" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
         <asp:Label CssClass="Normal" id="lblFECHA_CREAFormato" runat="server" >(dd/mm/yyyy)</asp:Label>
         <asp:RegularExpressionValidator id="revFECHA_CREA" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
         ErrorMessage="FECHA_CREA tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtFECHA_CREA"
         Display="Dynamic"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator id="rfvFECHA_CREA" runat="server" Display="Dynamic" ControlToValidate="txtFECHA_CREA" ErrorMessage="Fecha crea es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_ACT">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSUARIO_ACT" runat="server">Usuario act:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_ACT" runat="server" Width="100px" MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator id="rfvUSUARIO_ACT" runat="server" Display="Dynamic" ControlToValidate="txtUSUARIO_ACT" ErrorMessage="Usuario act es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_ACT">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_ACT" runat="server">Fecha act:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_ACT" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
         <asp:Label CssClass="Normal" id="lblFECHA_ACTFormato" runat="server" >(dd/mm/yyyy)</asp:Label>
         <asp:RegularExpressionValidator id="revFECHA_ACT" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
         ErrorMessage="FECHA_ACT tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtFECHA_ACT"
         Display="Dynamic"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator id="rfvFECHA_ACT" runat="server" Display="Dynamic" ControlToValidate="txtFECHA_ACT" ErrorMessage="Fecha act es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
