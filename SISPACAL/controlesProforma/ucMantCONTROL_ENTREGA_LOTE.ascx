<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCONTROL_ENTREGA_LOTE.ascx.vb" Inherits="controles_ucMantCONTROL_ENTREGA_LOTE" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTROL_ENTREGA_LOTE" Src="~/controlesProforma/ucListaCONTROL_ENTREGA_LOTE.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTROL_ENTREGA_LOTE" Src="~/controlesProforma/ucVistaDetalleCONTROL_ENTREGA_LOTE.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Control entrega lote</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCONTROL_ENTREGA_LOTE id="ucListaCONTROL_ENTREGA_LOTE1" runat="server"></uc1:ucListaCONTROL_ENTREGA_LOTE>
                <uc1:ucVistaDetalleCONTROL_ENTREGA_LOTE ID="ucVistaDetalleCONTROL_ENTREGA_LOTE1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTROL_ENTREGA_LOTE></TD>
        </TR>
    </TBODY>
</TABLE>
