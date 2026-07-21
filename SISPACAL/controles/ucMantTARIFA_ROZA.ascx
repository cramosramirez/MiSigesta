<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTARIFA_ROZA.ascx.vb" Inherits="controles_ucMantTARIFA_ROZA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTARIFA_ROZA" Src="~/controles/ucListaTARIFA_ROZA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTARIFA_ROZA" Src="~/controles/ucVistaDetalleTARIFA_ROZA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Tarifa roza</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTARIFA_ROZA id="ucListaTARIFA_ROZA1" runat="server"></uc1:ucListaTARIFA_ROZA>
                <uc1:ucVistaDetalleTARIFA_ROZA ID="ucVistaDetalleTARIFA_ROZA1" runat="server" Visible="false" ></uc1:ucVistaDetalleTARIFA_ROZA></TD>
        </TR>
    </TBODY>
</TABLE>
