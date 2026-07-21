<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCATORCENA_ZAFRA.ascx.vb" Inherits="controles_ucVistaDetalleCATORCENA_ZAFRA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>--%>

<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_CATORCENA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_CATORCENA" runat="server">Id catorcena:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_CATORCENA" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ZAFRA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ZAFRA" runat="server">Zafra:</asp:label></TD>
		<TD>
			<cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA" runat="server" CssClass="DDLClass"></cc1:ddlZAFRA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCATORCENA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCATORCENA" runat="server">Catorcena:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtCATORCENA" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvCATORCENA" runat="server" Display="Dynamic" ControlToValidate="txtCATORCENA" ErrorMessage="Catorcena es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorCATORCENA" runat="server" ControlToValidate="txtCATORCENA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^[+]?\d*$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
    <TR runat="server" id="trEFICIANCIA_REAL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblEFICIANCIA_REAL" runat="server">Eficiencia real:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtEFICIENCIA_REAL" runat="server" Width="100px"></asp:TextBox>		
            <asp:Label CssClass="Normal" id="Label2" runat="server">(Ej: 0.876912. La eficiencia real es opcional. Si se omite el sistema la calculara)</asp:label>	
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAZUCAR_PRODUCIDA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblAZUCAR_PRODUCIDA" runat="server">Azucar producida (KILOGRAMOS):</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtAZUCAR_PRODUCIDA" runat="server" Width="100px"></asp:TextBox>
			
</TD>
		<TD width="10"></TD>
	</TR>
     <tr id="trFECHA_PAGO" runat="server">
     <TD width="10"></TD>
        <td align="right"><asp:Label CssClass="Normal" id="Label1" runat="server">Fecha de Pago de Planilla:</asp:Label></td>
        <td><asp:TextBox ID="txtFECHA_PAGO" CssClass="TextoNormalIzquierdaMayus" runat="server" Width="100px"></asp:TextBox>             
                </td>
        <TD width="10"></TD>
    </tr>    
    
	<TR runat="server" id="trAZUCAR_CALC1">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblAZUCAR_CALC1" runat="server">Azucar calc1:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtAZUCAR_CALC1" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvAZUCAR_CALC1" runat="server" Display="Dynamic" ControlToValidate="txtAZUCAR_CALC1" ErrorMessage="Azucar calc1 es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorAZUCAR_CALC1" runat="server" ControlToValidate="txtAZUCAR_CALC1"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
    <TR runat="server" id="trDIAZAFRA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="Label3" runat="server">Dia zafra de cierre:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDIA_ZAFRA" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="txtDIA_ZAFRA" ErrorMessage="Dia zafra de cierre es requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	
	<TR runat="server" id="trFECHA_INICIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_INICIO" runat="server">Fecha inicio:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_INICIO" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
         <asp:Label CssClass="Normal" id="lblFECHA_INICIOFormato" runat="server" >(dd/mm/yyyy)</asp:Label>
         <asp:RegularExpressionValidator id="revFECHA_INICIO" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
         ErrorMessage="FECHA_INICIO tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtFECHA_INICIO"
         Display="Dynamic"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator id="rfvFECHA_INICIO" runat="server" Display="Dynamic" ControlToValidate="txtFECHA_INICIO" ErrorMessage="Fecha inicio es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_FIN">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_FIN" runat="server">Fecha fin:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_FIN" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
         <asp:Label CssClass="Normal" id="lblFECHA_FINFormato" runat="server" >(dd/mm/yyyy)</asp:Label>
         <asp:RegularExpressionValidator id="revFECHA_FIN" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
         ErrorMessage="FECHA_FIN tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtFECHA_FIN"
         Display="Dynamic"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator id="rfvFECHA_FIN" runat="server" Display="Dynamic" ControlToValidate="txtFECHA_FIN" ErrorMessage="Fecha fin es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_CIERRE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSUARIO_CIERRE" runat="server">Usuario cierre:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CIERRE" runat="server" Width="100px" MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator id="rfvUSUARIO_CIERRE" runat="server" Display="Dynamic" ControlToValidate="txtUSUARIO_CIERRE" ErrorMessage="Usuario cierre es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_CIERRE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_CIERRE" runat="server">Fecha cierre:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_CIERRE" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
         <asp:Label CssClass="Normal" id="lblFECHA_CIERREFormato" runat="server" >(dd/mm/yyyy)</asp:Label>
         <asp:RegularExpressionValidator id="revFECHA_CIERRE" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
         ErrorMessage="FECHA_CIERRE tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtFECHA_CIERRE"
         Display="Dynamic"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator id="rfvFECHA_CIERRE" runat="server" Display="Dynamic" ControlToValidate="txtFECHA_CIERRE" ErrorMessage="Fecha cierre es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
    <tr>
        <TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="Label4" Font-Bold="true" runat="server">Producción de azúcar basado en eficiencia del 85%:</asp:label></TD>
        <TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtAZUCAR_QQ_85REND" ReadOnly="true" runat="server" Width="200px"></asp:TextBox>	
            <asp:Label CssClass="Normal" id="Label5" Font-Bold="true" runat="server">QQ</asp:label></TD>	            
</TD>
    </tr>
</TABLE>
