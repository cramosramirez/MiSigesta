<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPLAN_ENTREGA_CANA.ascx.vb" Inherits="controles_ucMantPLAN_ENTREGA_CANA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPLAN_ENTREGA_CANA" Src="~/controles/ucListaPLAN_ENTREGA_CANA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePLAN_ENTREGA_CANA" Src="~/controles/ucVistaDetallePLAN_ENTREGA_CANA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Plan entrega cana</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPLAN_ENTREGA_CANA id="ucListaPLAN_ENTREGA_CANA1" runat="server"></uc1:ucListaPLAN_ENTREGA_CANA>
                <uc1:ucVistaDetallePLAN_ENTREGA_CANA ID="ucVistaDetallePLAN_ENTREGA_CANA1" runat="server" Visible="false" ></uc1:ucVistaDetallePLAN_ENTREGA_CANA></TD>
        </TR>
    </TBODY>
</TABLE>
