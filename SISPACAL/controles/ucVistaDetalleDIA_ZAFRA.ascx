<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleDIA_ZAFRA.ascx.vb" Inherits="controles_ucVistaDetalleDIA_ZAFRA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>--%>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<style type="text/css">
    .formato1
    {
        padding-right: 10px;
        margin-left: 80px;
    }
    .formato2
    {
        padding-right: 10px;
        margin-left: 80px;
        width: 170px;
    }
    div.centraTabla
    {
        font-size: small;     
        font-family: Tahoma;                   	
        text-align: center;
        padding-bottom: 15px; 
        padding-top: 10px;
        padding-left: 15px;
        padding-right: 15px 
    }

    div.centraTabla table {
        margin: 0 auto;
        text-align: left;
    }  
      .seccion
    {
        background-color: #003366;
        color: White;  
        font-weight: bold;
        border: 2px;      
        text-align: center;  
        height: 20px; 
    }
</style>
<div class="centraTabla">  
    <div class="ContenedorCamposOscuro"> 
         <asp:Label id="Label3" class="NormalRedBold" runat="server">Asegurese que ha cuadrado la información de Recibos de Caña antes de realizar este cierre. Si esta seguro de continuar seleccione la Opción GUARDAR de lo contrario seleccione la opción Salir</asp:Label>
    </div>
     <div class="ContenedorCampos"> 
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" border="0">
	<TR runat="server" id="trID_DIA_ZAFRA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_DIA_ZAFRA" runat="server">Id dia zafra:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_DIA_ZAFRA" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ZAFRA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ZAFRA" runat="server">Zafra:</asp:label></TD>
		<TD>
			<cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA" runat="server" CssClass="DDLClass" 
                Width="125px"></cc1:ddlZAFRA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDIAZAFRA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDIAZAFRA" runat="server">Dia de zafra:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDIAZAFRA" runat="server" 
                Width="120px"></asp:TextBox><asp:RequiredFieldValidator id="rfvDIAZAFRA" runat="server" Display="Dynamic" ControlToValidate="txtDIAZAFRA" ErrorMessage="Diazafra es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDIAZAFRA" runat="server" ControlToValidate="txtDIAZAFRA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^[+]?\d*$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>	
    <tr>
        <TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="Label2" runat="server">Fecha del dia zafra:</asp:Label></TD>
		<TD align="left">
			<dx:ASPxDateEdit ID="dteFECHA" runat="server" 
                                DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" 
                                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" Width="140px" >
                            </dx:ASPxDateEdit>
        </TD>
		<TD width="10"></TD>
    </tr>
    <TR runat="server" id="trHORA_CIERRE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="Label1" runat="server">Corte a la fecha y hora:</asp:Label></TD>
		<TD>			
            <dx:ASPxDateEdit ID="dteHORACIERRE" EditFormatString="dd/MM/yyyy HH:mm" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy HH:mm" runat="server" Width="140px">
                <TimeSectionProperties Visible="true" >
                        <TimeEditProperties EditFormatString="HH:mm" />
                </TimeSectionProperties>
            </dx:ASPxDateEdit>
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="dteHORACIERRE" ErrorMessage="Hora de cierre es Requerido"></asp:RequiredFieldValidator>                            
        </TD>
		<TD width="10"></TD>
	</TR>    
	<TR runat="server" id="trAZUCAR_PRODUCIDA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblAZUCAR_PRODUCIDA" runat="server">Azucar producida (QUINTALES):</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtAZUCAR_PRODUCIDA" 
                runat="server" Width="120px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorAZUCAR_PRODUCIDA" runat="server" ControlToValidate="txtAZUCAR_PRODUCIDA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAZUCAR_CALC1">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblAZUCAR_CALC1" runat="server">Total Azucar calculada:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtAZUCAR_CALC1" runat="server" 
                Width="120px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorAZUCAR_CALC1" runat="server" ControlToValidate="txtAZUCAR_CALC1"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEFICIENCIA_REAL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblEFICIENCIA_REAL" runat="server">Eficiencia real:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtEFICIENCIA_REAL" 
                runat="server" Width="120px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorEFICIENCIA_REAL" runat="server" ControlToValidate="txtEFICIENCIA_REAL"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_CIERRE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSUARIO_CIERRE" runat="server">Usuario cierre:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CIERRE" 
                runat="server" Width="120px" MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator id="rfvUSUARIO_CIERRE" runat="server" Display="Dynamic" ControlToValidate="txtUSUARIO_CIERRE" ErrorMessage="Usuario cierre es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_CIERRE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_CIERRE" runat="server">Fecha cierre:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_CIERRE" runat="server" Width="120px" 
                CssClass="TextoNormalCentrado"></asp:TextBox>
         <asp:Label CssClass="Normal" id="lblFECHA_CIERREFormato" runat="server" >(dd/mm/yyyy)</asp:Label>
         <asp:RegularExpressionValidator id="revFECHA_CIERRE" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
         ErrorMessage="FECHA_CIERRE tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtFECHA_CIERRE"
         Display="Dynamic"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator id="rfvFECHA_CIERRE" runat="server" Display="Dynamic" ControlToValidate="txtFECHA_CIERRE" ErrorMessage="Fecha cierre es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
</div>
</div>