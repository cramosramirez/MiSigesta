<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucComprobanteEnvio.ascx.vb" Inherits="controles_ucComprobanteEnvio" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucEnvioProforma" Src="~/controlesProforma/ucEnvioProforma.ascx" %>

<table id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
     <tbody>
	        <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
            </tr>
            <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Comprobante de Envío</asp:Label></td>
		   </tr>
            <tr>
                <td>
                <uc1:ucEnvioProforma ID="ucEnvioProforma1" runat="server" Visible="true" ></uc1:ucEnvioProforma>                
                </td>
            </tr>
    </tbody>
</table>