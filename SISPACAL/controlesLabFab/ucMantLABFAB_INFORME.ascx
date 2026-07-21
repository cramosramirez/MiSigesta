<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantLABFAB_INFORME.ascx.vb" Inherits="controles_ucMantLABFAB_INFORME" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaLABFAB_INFORME" Src="~/controlesLabFab/ucListaLABFAB_INFORME.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleLABFAB_INFORME" Src="~/controlesLabFab/ucVistaDetalleLABFAB_INFORME.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Labfab informe</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaLABFAB_INFORME id="ucListaLABFAB_INFORME1" runat="server"></uc1:ucListaLABFAB_INFORME>
                <uc1:ucVistaDetalleLABFAB_INFORME ID="ucVistaDetalleLABFAB_INFORME1" runat="server" Visible="false" ></uc1:ucVistaDetalleLABFAB_INFORME></TD>
        </TR>
    </TBODY>
</TABLE>
