<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPRODUCTO.ascx.vb" Inherits="controles_ucMantPRODUCTO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPRODUCTO" Src="~/controlesFinanciero/ucListaPRODUCTO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePRODUCTO" Src="~/controlesFinanciero/ucVistaDetallePRODUCTO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Productos Agrícolas</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPRODUCTO id="ucListaPRODUCTO1" runat="server"></uc1:ucListaPRODUCTO>
                <uc1:ucVistaDetallePRODUCTO ID="ucVistaDetallePRODUCTO1" runat="server" Visible="false" ></uc1:ucVistaDetallePRODUCTO></TD>
        </TR>
    </TBODY>
</TABLE>
