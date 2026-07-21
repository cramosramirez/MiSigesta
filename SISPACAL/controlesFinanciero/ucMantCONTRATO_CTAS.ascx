<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCONTRATO_CTAS.ascx.vb" Inherits="controles_ucMantCONTRATO_CTAS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTRATO_CTAS" Src="~/controlesFinanciero/ucListaCONTRATO_CTAS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTRATO_CTAS" Src="~/controlesFinanciero/ucVistaDetalleCONTRATO_CTAS.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Contrato ctas</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCONTRATO_CTAS id="ucListaCONTRATO_CTAS1" runat="server"></uc1:ucListaCONTRATO_CTAS>
                <uc1:ucVistaDetalleCONTRATO_CTAS ID="ucVistaDetalleCONTRATO_CTAS1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTRATO_CTAS></TD>
        </TR>
    </TBODY>
</TABLE>
