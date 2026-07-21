<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucBascula.ascx.vb" Inherits="controles_ucBascula" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleBASCULA" Src="~/controles/ucVistaDetalleBASCULA.ascx" %>

<table id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
     <tbody>
	        <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
            </tr>
            <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Bascula</asp:Label></td>
		   </tr>
            <tr>
                <td>
                <uc1:ucVistaDetalleBASCULA ID="ucVistaDetalleBASCULA1" runat="server" Visible="true" 
                    VerUSUARIO_LEE_BRUTO="false"
                    VerUSUARIO_LEE_TARA="false" 
                     VerFECHA_LEE_BRUTO="false" 
                      VerFECHA_LEE_TARA="false"   ></uc1:ucVistaDetalleBASCULA>
                </td>
            </tr>
    </tbody>
</table>