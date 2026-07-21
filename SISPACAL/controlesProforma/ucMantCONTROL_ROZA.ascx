<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCONTROL_ROZA.ascx.vb" Inherits="controles_ucMantCONTROL_ROZA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTROL_ROZA" Src="~/controlesProforma/ucListaCONTROL_ROZA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTROL_ROZA" Src="~/controlesProforma/ucVistaDetalleCONTROL_ROZA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Control roza</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCONTROL_ROZA id="ucListaCONTROL_ROZA1" PermitirEliminar="true" runat="server"></uc1:ucListaCONTROL_ROZA>
                <uc1:ucVistaDetalleCONTROL_ROZA ID="ucVistaDetalleCONTROL_ROZA1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTROL_ROZA></TD>
        </TR>
    </TBODY>
</TABLE>
