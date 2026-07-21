<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantVARIEDAD.ascx.vb" Inherits="controles_ucMantVARIEDAD" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaVARIEDAD" Src="~/controles/ucListaVARIEDAD.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleVARIEDAD" Src="~/controles/ucVistaDetalleVARIEDAD.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Variedad</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaVARIEDAD id="ucListaVARIEDAD1" runat="server"></uc1:ucListaVARIEDAD>
                <uc1:ucVistaDetalleVARIEDAD ID="ucVistaDetalleVARIEDAD1" runat="server" Visible="false" ></uc1:ucVistaDetalleVARIEDAD></TD>
        </TR>
    </TBODY>
</TABLE>
