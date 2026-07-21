<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantLABFAB_ANALISIS.ascx.vb" Inherits="controles_ucMantLABFAB_ANALISIS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaLABFAB_ANALISIS" Src="~/controlesLabFab/ucListaLABFAB_ANALISIS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleLABFAB_ANALISIS" Src="~/controlesLabFab/ucVistaDetalleLABFAB_ANALISIS.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Analisis</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaLABFAB_ANALISIS id="ucListaLABFAB_ANALISIS1" TamanoPagina="15" runat="server"></uc1:ucListaLABFAB_ANALISIS>
                <uc1:ucVistaDetalleLABFAB_ANALISIS ID="ucVistaDetalleLABFAB_ANALISIS1" runat="server" Visible="false" ></uc1:ucVistaDetalleLABFAB_ANALISIS></TD>
        </TR>
    </TBODY>
</TABLE>
