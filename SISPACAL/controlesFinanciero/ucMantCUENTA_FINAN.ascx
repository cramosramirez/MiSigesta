<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCUENTA_FINAN.ascx.vb" Inherits="controles_ucMantCUENTA_FINAN" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCUENTA_FINAN" Src="~/controlesFinanciero/ucListaCUENTA_FINAN.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCUENTA_FINAN" Src="~/controlesFinanciero/ucVistaDetalleCUENTA_FINAN.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Conceptos de Financiamiento</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCUENTA_FINAN id="ucListaCUENTA_FINAN1" TamanoPagina="15" runat="server"></uc1:ucListaCUENTA_FINAN>
                <uc1:ucVistaDetalleCUENTA_FINAN ID="ucVistaDetalleCUENTA_FINAN1" runat="server" Visible="false" ></uc1:ucVistaDetalleCUENTA_FINAN></TD>
        </TR>
    </TBODY>
</TABLE>
