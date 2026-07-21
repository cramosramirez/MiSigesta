<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSOLICITANTE.ascx.vb" Inherits="controles_ucMantSOLICITANTE" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSOLICITANTE" Src="~/controlesRequisicion/ucListaSOLICITANTE.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLICITANTE" Src="~/controlesRequisicion/ucVistaDetalleSOLICITANTE.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Solicitante</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaSOLICITANTE id="ucListaSOLICITANTE1" runat="server"></uc1:ucListaSOLICITANTE>
                <uc1:ucVistaDetalleSOLICITANTE ID="ucVistaDetalleSOLICITANTE1" runat="server" Visible="false" ></uc1:ucVistaDetalleSOLICITANTE></TD>
        </TR>
    </TBODY>
</TABLE>
