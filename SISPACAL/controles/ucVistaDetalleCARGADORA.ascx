<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCARGADORA.ascx.vb" Inherits="controles_ucVistaDetalleCARGADORA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_CARGADORA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_CARGADORA" runat="server">Id cargadora:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_CARGADORA" runat="server" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOMBRE" runat="server">Nombre:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE" runat="server" 
                Width="300px" MaxLength="40"></asp:TextBox><asp:RequiredFieldValidator id="rfvNOMBRE" runat="server" Display="Dynamic" ControlToValidate="txtNOMBRE" ErrorMessage="Nombre es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_CREA" visible="false" >
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSUARIO_CREA" runat="server">Usuario crea:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CREA" runat="server" Width="100px" MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator id="rfvUSUARIO_CREA" runat="server" Display="Dynamic" ControlToValidate="txtUSUARIO_CREA" ErrorMessage="Usuario crea es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_CREA" visible="false" >
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
	<TR runat="server" id="trUSUARIO_ACT" visible="false" >
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSUARIO_ACT" runat="server">Usuario act:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_ACT" runat="server" Width="100px" MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator id="rfvUSUARIO_ACT" runat="server" Display="Dynamic" ControlToValidate="txtUSUARIO_ACT" ErrorMessage="Usuario act es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_ACT" visible="false" >
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
	<TR runat="server" id="trES_PROPIA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblES_PROPIA" runat="server">Es propia:</asp:label></TD>
		<TD>
			<asp:CheckBox id="cbxES_PROPIA" runat="server" AutoPostBack="true" ></asp:CheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PROVEEDOR_CARGA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_PROVEEDOR_CARGA" runat="server">Proveedor carga:</asp:label></TD>
		<TD>
			<cc1:ddlPROVEEDOR_CARGA id="ddlPROVEEDOR_CARGAID_PROVEEDOR_CARGA" AutoPostBack="true" 
                runat="server" CssClass="DDLClass" Width="300px"></cc1:ddlPROVEEDOR_CARGA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIPO_CARGADORA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_TIPO_CARGADORA" runat="server">Tipo cargadora:</asp:label></TD>
		<TD>
			<cc1:ddlTIPO_CARGADORA id="ddlTIPO_CARGADORAID_TIPO_CARGADORA" runat="server" AutoPostBack="True"  
                CssClass="DDLClass" Width="300px"></cc1:ddlTIPO_CARGADORA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTARIFA_SIN_TRIPULACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTARIFA_SIN_TRIPULACION" runat="server">Tarifa sin tripulacion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtTARIFA_SIN_TRIPULACION" runat="server" Width="100px"></asp:TextBox>			
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTARIFA_CON_TRIPULACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTARIFA_CON_TRIPULACION" runat="server">Tarifa con tripulacion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtTARIFA_CON_TRIPULACION" runat="server" Width="100px"></asp:TextBox>			
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTARIFA_NORMAL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTARIFA_NORMAL" runat="server">Tarifa a cobrar por cargadora/cosechadora:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtTARIFA_NORMAL" runat="server" Width="100px"></asp:TextBox>			
</TD>
		<TD width="10"></TD>
	</TR>
<TR runat="server" id="trTARIFA_PAGAR_CARGADORA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="Label4" runat="server">Tarifa a pagar a cargadora/cosechadora:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtTARIFA_PAGAR_CARGADORA" runat="server" Width="100px"></asp:TextBox>			
</TD>
		<TD width="10"></TD>
	</TR>
<TR runat="server" id="trID_TIPO_ALZA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="Label1" runat="server">Tipo de Alza:</asp:Label></TD>
		<TD>
			<cc1:ddlTIPOS_GENERALES id="ddlTIPOS_GENERALES1" 
                runat="server" CssClass="DDLClass" Width="300px"></cc1:ddlTIPOS_GENERALES>			
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPRECALIFI_AUTO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="Label2" runat="server">Precalificada para Autovolteo:</asp:label></TD>
		<TD>
			<asp:CheckBox id="chkPRECALIFI_AUTO" runat="server" ></asp:CheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trACTIVO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="Label3" runat="server">Activo:</asp:label></TD>
		<TD>
			<asp:CheckBox id="chkACTIVO" runat="server"></asp:CheckBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
