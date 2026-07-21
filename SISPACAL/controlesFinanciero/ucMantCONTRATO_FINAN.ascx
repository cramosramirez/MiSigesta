<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCONTRATO_FINAN.ascx.vb" Inherits="controles_ucMantCONTRATO_FINAN" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTRATO_FINAN" Src="~/controlesFinanciero/ucListaCONTRATO_FINAN.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTRATO_FINAN" Src="~/controlesFinanciero/ucVistaDetalleCONTRATO_FINAN.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Contrato finan</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCONTRATO_FINAN id="ucListaCONTRATO_FINAN1" runat="server"></uc1:ucListaCONTRATO_FINAN>
                <uc1:ucVistaDetalleCONTRATO_FINAN ID="ucVistaDetalleCONTRATO_FINAN1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTRATO_FINAN></TD>
        </TR>
    </TBODY>
</TABLE>
