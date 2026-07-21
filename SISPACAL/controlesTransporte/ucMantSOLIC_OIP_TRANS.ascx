<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSOLIC_OIP_TRANS.ascx.vb" Inherits="controles_ucMantSOLIC_OIP_TRANS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSOLIC_OIP_TRANS" Src="~/controlesTransporte/ucListaSOLIC_OIP_TRANS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLIC_OIP_TRANS" Src="~/controlesTransporte/ucVistaDetalleSOLIC_OIP_TRANS.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Orden Irrevocable de Pago de Transportistas</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaSOLIC_OIP_TRANS id="ucListaSOLIC_OIP_TRANS1" runat="server"></uc1:ucListaSOLIC_OIP_TRANS>
                <uc1:ucVistaDetalleSOLIC_OIP_TRANS ID="ucVistaDetalleSOLIC_OIP_TRANS1" runat="server" Visible="false" ></uc1:ucVistaDetalleSOLIC_OIP_TRANS></TD>
        </TR>
    </TBODY>
</TABLE>
