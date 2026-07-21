<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantUNIDAD_MEDIDA.ascx.vb" Inherits="controles_ucMantUNIDAD_MEDIDA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaUNIDAD_MEDIDA" Src="~/controlesInventario/ucListaUNIDAD_MEDIDA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleUNIDAD_MEDIDA" Src="~/controlesInventario/ucVistaDetalleUNIDAD_MEDIDA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Unidad medida</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaUNIDAD_MEDIDA id="ucListaUNIDAD_MEDIDA1" runat="server"></uc1:ucListaUNIDAD_MEDIDA>
                <uc1:ucVistaDetalleUNIDAD_MEDIDA ID="ucVistaDetalleUNIDAD_MEDIDA1" runat="server" Visible="false" ></uc1:ucVistaDetalleUNIDAD_MEDIDA></TD>
        </TR>
    </TBODY>
</TABLE>
