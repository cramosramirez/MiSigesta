<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucIngresoInforme.ascx.vb" Inherits="controlesLabFab_ucIngresoInforme" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleLABFAB_INFOVARSXDIA" Src="~/controlesLabFab/ucVistaDetalleLABFAB_INFOVARSXDIA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Ingreso de Análisis de Muestra</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD>
            <uc1:ucVistaDetalleLABFAB_INFOVARSXDIA ID="ucVistaDetalleLABFAB_INFOVARSXDIA1" runat="server" ></uc1:ucVistaDetalleLABFAB_INFOVARSXDIA>
            </TD>
        </TR>
    </TBODY>
</TABLE>