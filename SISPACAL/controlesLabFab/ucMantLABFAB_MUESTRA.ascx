<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantLABFAB_MUESTRA.ascx.vb" Inherits="controles_ucMantLABFAB_MUESTRA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaLABFAB_MUESTRA" Src="~/controlesLabFab/ucListaLABFAB_MUESTRA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleLABFAB_MUESTRA" Src="~/controlesLabFab/ucVistaDetalleLABFAB_MUESTRA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Muestras</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaLABFAB_MUESTRA id="ucListaLABFAB_MUESTRA1" runat="server"></uc1:ucListaLABFAB_MUESTRA>
                <uc1:ucVistaDetalleLABFAB_MUESTRA ID="ucVistaDetalleLABFAB_MUESTRA1" runat="server" Visible="false" ></uc1:ucVistaDetalleLABFAB_MUESTRA></TD>
        </TR>
    </TBODY>
</TABLE>
