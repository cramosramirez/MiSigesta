<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantBASCULA.ascx.vb" Inherits="controles_ucMantBASCULA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaBASCULA" Src="~/controles/ucListaBASCULA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleBASCULA" Src="~/controles/ucVistaDetalleBASCULA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Bascula</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaBASCULA id="ucListaBASCULA1" runat="server"></uc1:ucListaBASCULA>
                <uc1:ucVistaDetalleBASCULA ID="ucVistaDetalleBASCULA1" runat="server" Visible="false" ></uc1:ucVistaDetalleBASCULA></TD>
        </TR>
    </TBODY>
</TABLE>
