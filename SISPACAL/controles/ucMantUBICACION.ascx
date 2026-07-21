<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantUBICACION.ascx.vb" Inherits="controles_ucMantUBICACION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaUBICACION" Src="~/controles/ucListaUBICACION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleUBICACION" Src="~/controles/ucVistaDetalleUBICACION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Ubicacion</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaUBICACION id="ucListaUBICACION1" runat="server"></uc1:ucListaUBICACION>
                <uc1:ucVistaDetalleUBICACION ID="ucVistaDetalleUBICACION1" runat="server" Visible="false" ></uc1:ucVistaDetalleUBICACION></TD>
        </TR>
    </TBODY>
</TABLE>
