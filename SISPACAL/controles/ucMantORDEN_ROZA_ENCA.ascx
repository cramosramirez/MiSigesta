<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantORDEN_ROZA_ENCA.ascx.vb" Inherits="controles_ucMantORDEN_ROZA_ENCA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaORDEN_ROZA_ENCA" Src="~/controles/ucListaORDEN_ROZA_ENCA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleORDEN_ROZA_ENCA" Src="~/controles/ucVistaDetalleORDEN_ROZA_ENCA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Orden roza enca</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaORDEN_ROZA_ENCA id="ucListaORDEN_ROZA_ENCA1" runat="server"></uc1:ucListaORDEN_ROZA_ENCA>
                <uc1:ucVistaDetalleORDEN_ROZA_ENCA ID="ucVistaDetalleORDEN_ROZA_ENCA1" runat="server" Visible="false" ></uc1:ucVistaDetalleORDEN_ROZA_ENCA></TD>
        </TR>
    </TBODY>
</TABLE>
