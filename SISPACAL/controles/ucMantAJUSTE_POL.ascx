<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantAJUSTE_POL.ascx.vb" Inherits="controles_ucMantAJUSTE_POL" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaAJUSTE_POL" Src="~/controles/ucListaAJUSTE_POL.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleAJUSTE_POL" Src="~/controles/ucVistaDetalleAJUSTE_POL.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Ajuste pol</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaAJUSTE_POL id="ucListaAJUSTE_POL1" runat="server"></uc1:ucListaAJUSTE_POL>
                <uc1:ucVistaDetalleAJUSTE_POL ID="ucVistaDetalleAJUSTE_POL1" runat="server" Visible="false" ></uc1:ucVistaDetalleAJUSTE_POL></TD>
        </TR>
    </TBODY>
</TABLE>
