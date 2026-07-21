<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantOPCION.ascx.vb" Inherits="controles_ucMantOPCION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaOPCION" Src="~/controles/ucListaOPCION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleOPCION" Src="~/controles/ucVistaDetalleOPCION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Opciones del Sistema</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaOPCION id="ucListaOPCION1" runat="server"></uc1:ucListaOPCION></TD>
        </TR>
    </TBODY>
</TABLE>
