<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAnalisisLaboratorioCalidad.ascx.vb" Inherits="controles_ucAnalisisLaboratorioCalidad" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleANALISIS" Src="~/controles/ucVistaDetalleANALISIS.ascx" %>

<table id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
     <tbody>
	        <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
            </tr>
            <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Laboratorio de Pago Calidad</asp:Label></td>
		   </tr>
            <tr>
                <td>
                <uc1:ucVistaDetalleANALISIS ID="ucVistaDetalleANALISIS1" runat="server" Visible="true" ></uc1:ucVistaDetalleANALISIS>
                </td>
            </tr>
    </tbody>
</table>