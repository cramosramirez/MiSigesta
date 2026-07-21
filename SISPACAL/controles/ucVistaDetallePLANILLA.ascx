<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePLANILLA.ascx.vb" Inherits="controles_ucVistaDetallePLANILLA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_CATORCENA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_CATORCENA" runat="server">Catorcena zafra:</asp:label></TD>
		<TD>
			<cc1:ddlCATORCENA_ZAFRA id="ddlCATORCENA_ZAFRAID_CATORCENA" runat="server" AutoPostBack="True" CssClass="DDLClassDisabled" Enabled="False"></cc1:ddlCATORCENA_ZAFRA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIPROVEEDOR_TRANSPORTISTA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIPROVEEDOR_TRANSPORTISTA" runat="server">Codiproveedor transportista:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtCODIPROVEEDOR_TRANSPORTISTA" runat="server" Width="70px" MaxLength="10"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIPO_PLANILLA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_TIPO_PLANILLA" runat="server">Tipo planilla:</asp:label></TD>
		<TD>
			<cc1:ddlTIPO_PLANILLA id="ddlTIPO_PLANILLAID_TIPO_PLANILLA" runat="server" AutoPostBack="True" CssClass="DDLClassDisabled" Enabled="False"></cc1:ddlTIPO_PLANILLA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_ZAFRA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOMBRE_ZAFRA" runat="server">Nombre zafra:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_ZAFRA" runat="server" Width="100px" MaxLength="200"></asp:TextBox><asp:RequiredFieldValidator id="rfvNOMBRE_ZAFRA" runat="server" Display="Dynamic" ControlToValidate="txtNOMBRE_ZAFRA" ErrorMessage="Nombre zafra es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIPROVEE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIPROVEE" runat="server">Codiprovee:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtCODIPROVEE" runat="server" Width="100px" MaxLength="6"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODISOCIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODISOCIO" runat="server">Codisocio:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtCODISOCIO" runat="server" Width="100px" MaxLength="4"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCANT_RECIBOS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCANT_RECIBOS" runat="server">Cant recibos:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtCANT_RECIBOS" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvCANT_RECIBOS" runat="server" Display="Dynamic" ControlToValidate="txtCANT_RECIBOS" ErrorMessage="Cant recibos es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorCANT_RECIBOS" runat="server" ControlToValidate="txtCANT_RECIBOS"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^[+]?\d*$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTONEL_CANA_ENTREGADA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTONEL_CANA_ENTREGADA" runat="server">Tonel cana entregada:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtTONEL_CANA_ENTREGADA" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorTONEL_CANA_ENTREGADA" runat="server" ControlToValidate="txtTONEL_CANA_ENTREGADA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAZUCAR_CATORCENA_REAL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblAZUCAR_CATORCENA_REAL" runat="server">Azucar catorcena real:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtAZUCAR_CATORCENA_REAL" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorAZUCAR_CATORCENA_REAL" runat="server" ControlToValidate="txtAZUCAR_CATORCENA_REAL"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trVALOR">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblVALOR" runat="server">Valor:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtVALOR" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvVALOR" runat="server" Display="Dynamic" ControlToValidate="txtVALOR" ErrorMessage="Valor es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorVALOR" runat="server" ControlToValidate="txtVALOR"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trIVA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblIVA" runat="server">Iva:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtIVA" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvIVA" runat="server" Display="Dynamic" ControlToValidate="txtIVA" ErrorMessage="Iva es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorIVA" runat="server" ControlToValidate="txtIVA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trVALOR_BRUTO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblVALOR_BRUTO" runat="server">Valor bruto:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtVALOR_BRUTO" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvVALOR_BRUTO" runat="server" Display="Dynamic" ControlToValidate="txtVALOR_BRUTO" ErrorMessage="Valor bruto es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorVALOR_BRUTO" runat="server" ControlToValidate="txtVALOR_BRUTO"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trRENTA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblRENTA" runat="server">Renta:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtRENTA" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvRENTA" runat="server" Display="Dynamic" ControlToValidate="txtRENTA" ErrorMessage="Renta es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorRENTA" runat="server" ControlToValidate="txtRENTA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trRETENCION_IVA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblRETENCION_IVA" runat="server">Retencion iva:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtRETENCION_IVA" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvRETENCION_IVA" runat="server" Display="Dynamic" ControlToValidate="txtRETENCION_IVA" ErrorMessage="Retencion iva es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorRETENCION_IVA" runat="server" ControlToValidate="txtRETENCION_IVA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_FLETE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_FLETE" runat="server">Desc flete:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_FLETE" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_FLETE" runat="server" Display="Dynamic" ControlToValidate="txtDESC_FLETE" ErrorMessage="Desc flete es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_FLETE" runat="server" ControlToValidate="txtDESC_FLETE"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_CARGA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_CARGA" runat="server">Desc carga:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_CARGA" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_CARGA" runat="server" Display="Dynamic" ControlToValidate="txtDESC_CARGA" ErrorMessage="Desc carga es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_CARGA" runat="server" ControlToValidate="txtDESC_CARGA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_CARGA_CONTRA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_CARGA_CONTRA" runat="server">Desc carga contra:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_CARGA_CONTRA" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_CARGA_CONTRA" runat="server" Display="Dynamic" ControlToValidate="txtDESC_CARGA_CONTRA" ErrorMessage="Desc carga contra es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_CARGA_CONTRA" runat="server" ControlToValidate="txtDESC_CARGA_CONTRA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_BANCOS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_BANCOS" runat="server">Desc bancos:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_BANCOS" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_BANCOS" runat="server" Display="Dynamic" ControlToValidate="txtDESC_BANCOS" ErrorMessage="Desc bancos es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_BANCOS" runat="server" ControlToValidate="txtDESC_BANCOS"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_COMBUSTIBLE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_COMBUSTIBLE" runat="server">Desc combustible:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_COMBUSTIBLE" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_COMBUSTIBLE" runat="server" Display="Dynamic" ControlToValidate="txtDESC_COMBUSTIBLE" ErrorMessage="Desc combustible es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_COMBUSTIBLE" runat="server" ControlToValidate="txtDESC_COMBUSTIBLE"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_ANTICIPO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_ANTICIPO" runat="server">Desc anticipo:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_ANTICIPO" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_ANTICIPO" runat="server" Display="Dynamic" ControlToValidate="txtDESC_ANTICIPO" ErrorMessage="Desc anticipo es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_ANTICIPO" runat="server" ControlToValidate="txtDESC_ANTICIPO"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_INTERES">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_INTERES" runat="server">Desc interes:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_INTERES" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_INTERES" runat="server" Display="Dynamic" ControlToValidate="txtDESC_INTERES" ErrorMessage="Desc interes es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_INTERES" runat="server" ControlToValidate="txtDESC_INTERES"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_AGROQUIMICO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_AGROQUIMICO" runat="server">Desc agroquimico:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_AGROQUIMICO" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_AGROQUIMICO" runat="server" Display="Dynamic" ControlToValidate="txtDESC_AGROQUIMICO" ErrorMessage="Desc agroquimico es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_AGROQUIMICO" runat="server" ControlToValidate="txtDESC_AGROQUIMICO"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_SEGURO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_SEGURO" runat="server">Desc seguro:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_SEGURO" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_SEGURO" runat="server" Display="Dynamic" ControlToValidate="txtDESC_SEGURO" ErrorMessage="Desc seguro es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_SEGURO" runat="server" ControlToValidate="txtDESC_SEGURO"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_RESPUESTOS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_RESPUESTOS" runat="server">Desc respuestos:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_RESPUESTOS" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_RESPUESTOS" runat="server" Display="Dynamic" ControlToValidate="txtDESC_RESPUESTOS" ErrorMessage="Desc respuestos es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_RESPUESTOS" runat="server" ControlToValidate="txtDESC_RESPUESTOS"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESC_OTROS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_OTROS" runat="server">Desc otros:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_OTROS" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_OTROS" runat="server" Display="Dynamic" ControlToValidate="txtDESC_OTROS" ErrorMessage="Desc otros es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_OTROS" runat="server" ControlToValidate="txtDESC_OTROS"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPAGO_NETO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblPAGO_NETO" runat="server">Pago neto:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtPAGO_NETO" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvPAGO_NETO" runat="server" Display="Dynamic" ControlToValidate="txtPAGO_NETO" ErrorMessage="Pago neto es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorPAGO_NETO" runat="server" ControlToValidate="txtPAGO_NETO"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trES_CONTRIBUYENTE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblES_CONTRIBUYENTE" runat="server">Es contribuyente:</asp:label></TD>
		<TD>
			<asp:CheckBox id="cbxES_CONTRIBUYENTE" runat="server"></asp:CheckBox>
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
	<TR runat="server" id="trDESC_SERVICIO_ROZA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESC_SERVICIO_ROZA" runat="server">Desc servicio roza:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDESC_SERVICIO_ROZA" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDESC_SERVICIO_ROZA" runat="server" Display="Dynamic" ControlToValidate="txtDESC_SERVICIO_ROZA" ErrorMessage="Desc servicio roza es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDESC_SERVICIO_ROZA" runat="server" ControlToValidate="txtDESC_SERVICIO_ROZA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_PROVEE_TRANS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOMBRE_PROVEE_TRANS" runat="server">Nombre provee trans:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_PROVEE_TRANS" runat="server" Width="100px" MaxLength="120"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
