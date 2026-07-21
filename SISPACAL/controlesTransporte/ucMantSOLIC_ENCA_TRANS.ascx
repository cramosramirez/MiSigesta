<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSOLIC_ENCA_TRANS.ascx.vb" Inherits="controles_ucMantSOLIC_ENCA_TRANS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSOLIC_ENCA_TRANS" Src="~/controlesTransporte/ucListaSOLIC_ENCA_TRANS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLIC_ENCA_TRANS" Src="~/controlesTransporte/ucVistaDetalleSOLIC_ENCA_TRANS.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Solic enca trans</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaSOLIC_ENCA_TRANS id="ucListaSOLIC_ENCA_TRANS1" runat="server"></uc1:ucListaSOLIC_ENCA_TRANS>
                <uc1:ucVistaDetalleSOLIC_ENCA_TRANS ID="ucVistaDetalleSOLIC_ENCA_TRANS1" runat="server" Visible="false" ></uc1:ucVistaDetalleSOLIC_ENCA_TRANS></TD>
        </TR>
    </TBODY>
</TABLE>
