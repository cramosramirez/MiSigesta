<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucPlanillaAnticipos.ascx.vb" Inherits="controles_ucPlanillaAnticipos" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<table cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
    <tr>
       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Generación de Orden de Roza</asp:Label></td>		
    </tr>
</table>
<table>
    <tr>
        <td><asp:Label CssClass="Normal" id="lblID_ZAFRA" runat="server">ZAFRA:</asp:Label></td>
        <td><cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA" runat="server" CssClass="DDLClassNormal" AutoPostBack="true"  
                     Width="120px"></cc1:ddlZAFRA></td>        
    </tr>
    <tr>
        <td><asp:Label CssClass="Normal" id="Label7" runat="server">CATORCENA:</asp:Label></td>
        <td>
            <cc1:ddlCATORCENA_ZAFRA ID="ddlCATORCENA_ZAFRA1" runat="server" Width="120px" CssClass="DDLClassNormal">
            </cc1:ddlCATORCENA_ZAFRA>
        </td>
    </tr>    
     <tr>
        <td><asp:Label CssClass="Normal" id="Label1" runat="server">N° ANTICIPO:</asp:Label></td>
        <td>
            <asp:TextBox CssClass="TextoDerecha" id="txtNO_ANTICIPO" runat="server" Width="120px" />
        </td>
    </tr>           
    <tr>
        <td><asp:Label CssClass="Normal" id="Label2" runat="server">CONCEPTO:</asp:Label></td>
        <td>
            <asp:TextBox CssClass="TextoIzquierda" id="txtCONCEPTO" runat="server" Width="600px" />
        </td>
    </tr> 
    <tr>
        <td><asp:Label CssClass="Normal" id="Label24" runat="server">VALOR ANTICIPO:</asp:Label></td>
        <td>
            <asp:TextBox CssClass="TextoDerecha" id="txtVALOR_ANTICIPO" runat="server" Width="120px" />
        </td>
    </tr>    
</table>