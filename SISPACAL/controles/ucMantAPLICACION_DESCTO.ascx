<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantAPLICACION_DESCTO.ascx.vb" Inherits="controles_ucMantAPLICACION_DESCTO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaAPLICACION_DESCTO" Src="~/controles/ucListaAPLICACION_DESCTO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleAPLICACION_DESCTO" Src="~/controles/ucVistaDetalleAPLICACION_DESCTO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Aplicacion descto</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaAPLICACION_DESCTO id="ucListaAPLICACION_DESCTO1" runat="server"></uc1:ucListaAPLICACION_DESCTO>
                <uc1:ucVistaDetalleAPLICACION_DESCTO ID="ucVistaDetalleAPLICACION_DESCTO1" runat="server" Visible="false" ></uc1:ucVistaDetalleAPLICACION_DESCTO></TD>
        </TR>
    </TBODY>
</TABLE>
