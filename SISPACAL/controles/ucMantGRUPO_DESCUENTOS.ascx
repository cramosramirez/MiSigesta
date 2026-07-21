<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantGRUPO_DESCUENTOS.ascx.vb" Inherits="controles_ucMantGRUPO_DESCUENTOS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaGRUPO_DESCUENTOS" Src="~/controles/ucListaGRUPO_DESCUENTOS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleGRUPO_DESCUENTOS" Src="~/controles/ucVistaDetalleGRUPO_DESCUENTOS.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Grupo descuentos</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaGRUPO_DESCUENTOS id="ucListaGRUPO_DESCUENTOS1" runat="server"></uc1:ucListaGRUPO_DESCUENTOS>
                <uc1:ucVistaDetalleGRUPO_DESCUENTOS ID="ucVistaDetalleGRUPO_DESCUENTOS1" runat="server" Visible="false" ></uc1:ucVistaDetalleGRUPO_DESCUENTOS></TD>
        </TR>
    </TBODY>
</TABLE>
