<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantREQDETA.ascx.vb" Inherits="controles_ucMantREQDETA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaREQDETA" Src="~/controlesRequisicion/ucListaREQDETA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleREQDETA" Src="~/controlesRequisicion/ucVistaDetalleREQDETA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Reqdeta</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaREQDETA id="ucListaREQDETA1" runat="server"></uc1:ucListaREQDETA>
                <uc1:ucVistaDetalleREQDETA ID="ucVistaDetalleREQDETA1" runat="server" Visible="false" ></uc1:ucVistaDetalleREQDETA></TD>
        </TR>
    </TBODY>
</TABLE>
