<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCANTON.ascx.vb" Inherits="controles_ucMantCANTON" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCANTON" Src="~/controlesContrato/ucListaCANTON.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosCanton" Src="~/controlesContrato/ucCriteriosCanton.ascx" %>

<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">    
	        <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
            </tr>
		    <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Asignación de Sub Zona a Cantón</asp:Label></td>
		    </tr>
		    <tr>
			   <td><uc1:ucCriteriosCanton id="ucCriteriosCanton1" runat="server"></uc1:ucCriteriosCanton></td>
		    </tr>
	        <tr>
                <td><uc1:ucListaCANTON id="ucListaCANTON1" PermitirEditarInline="true" PermitirEliminar="false" runat="server"></uc1:ucListaCANTON></td>
            </tr>    
</table>
