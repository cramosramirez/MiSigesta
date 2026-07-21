<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleDESCUENTOS_PLANILLA.ascx.vb" Inherits="controles_ucVistaDetalleDESCUENTOS_PLANILLA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucListaDESCUENTOS_PLANILLA" Src="~/controles/ucListaDESCUENTOS_PLANILLA.ascx" %>
<style type="text/css">
    .formato1
    {
        padding-right: 10px;
        margin-left: 80px;
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
    </style>   
<div class="centraTabla">  
     <table cellspacing="0" cellpadding="0" border="0">
        <tr>
            <td><asp:Label CssClass="Normal" id="lblID_DESCUENTO_PLANILLA" runat="server">ID:</asp:Label></td>
            <td class="formato1"> 
                    <asp:TextBox CssClass="TextoDerecha" id="txtID_DESCUENTO_PLANILLA" 
                    runat="server" ReadOnly="True" Width="120px"></asp:Textbox></td>
            <td><asp:Label CssClass="Normal" id="lblID_ZAFRA" runat="server">ZAFRA:</asp:Label></td>
            <td class="formato1">
                <asp:Label CssClass="TextoDerechaNegrita" id="lblZAFRA" Text="2013/2014" 
                    runat="server" Width="120px"  /></td>
             <td><asp:Label  id="lblCATORCENA" CssClass="Normal" runat="server">CATORCENA:</asp:Label></td>
            <td class="formato1">
                <asp:Label CssClass="TextoDerechaNegrita" id="lblNO_CATORCENA" Text="1" 
                    runat="server" Width="120px"  />                
                </td>
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="Label1" runat="server">PROVEEDOR:</asp:Label></td>
            <td class="formato1">
                <asp:Label CssClass="TextoIzquierdaNegrita" id="lblCODIPROVEEDOR_TRANSPORTISTA" Text="00023332" 
                    runat="server" Width="120px"  /></td>
            <th colspan="4" >
                <asp:Label CssClass="TextoIzquierdaNegrita" id="lblNOMBRE" Text="CHRISTIAM EDUARDO RAMOS RAMIREZ" 
                    runat="server" Width="100%"  />          
            </th>
        </tr>       
        <tr>
            <td><asp:Label CssClass="Normal" id="Label4" runat="server">TIPO DESCUENTO:</asp:Label></td>
            <td class="formato1"><cc1:ddlTIPO_DESCUENTO id="ddlTIPO_DESCUENTOID_TIPO_DESCTO" Width="127px" runat="server" CssClass="DDLClassNegrita"></cc1:ddlTIPO_DESCUENTO></td>
             <td><asp:Label CssClass="Normal" id="Label7" runat="server" Visible="False">APLICAR A:</asp:Label></td>
            <td class="formato1">
                <cc1:ddlAPLICACION_DESCTO id="ddlAPLICACION_DESCTOID_APLICACION_DESCTO" runat="server" 
                    CssClass="DDLClass" Width="127px" Visible="False"></cc1:ddlAPLICACION_DESCTO></td>
            <td><asp:Label CssClass="Normal" id="Label6" runat="server">MONTO A DESCONTAR:</asp:Label></td>
            <td class="formato1">
                <asp:TextBox id="txtMONTO_DESCUENTO" runat="server" CssClass="TextoNormalDerechaNegrita" Width="100%"></asp:TextBox></td>           
        </tr>
        <tr>        
            <th colspan="6" align="center">
                <br />
                <asp:Label CssClass="Normal" id="Label8" runat="server" 
                    Text="DESCUENTOS APLICADOS"  />
            </th>
        </tr>
        <tr>
            <th colspan="6" align="center">
                <uc1:ucListaDESCUENTOS_PLANILLA id="ucListaDESCUENTOS_PLANILLA1" runat="server"
                 VerUSUARIO_ACT="false" VerUSUARIO_CREA="false" VerFECHA_ACT="false" VerFECHA_CREA="false" PermitirEditar="true" PermitirEliminar="true"    
                 VerID_APLICACION_DESCTO="false" VerID_CATORCENA="false" VerCODIPROVEEDOR_TRANSPORTISTA="false">
                </uc1:ucListaDESCUENTOS_PLANILLA>
            </th>
        </tr>
     </table>
</div>
