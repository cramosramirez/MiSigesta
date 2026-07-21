<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantORDEN_COMPRA_AGRI.ascx.vb" Inherits="controles_ucMantORDEN_COMPRA_AGRI" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaORDEN_COMPRA_AGRI" Src="~/controlesFinanciero/ucListaORDEN_COMPRA_AGRI.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleORDEN_COMPRA_AGRI" Src="~/controlesFinanciero/ucVistaDetalleORDEN_COMPRA_AGRI.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Orden de Compra Agrícola</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaORDEN_COMPRA_AGRI id="ucListaORDEN_COMPRA_AGRI1" runat="server"></uc1:ucListaORDEN_COMPRA_AGRI>
                <uc1:ucVistaDetalleORDEN_COMPRA_AGRI ID="ucVistaDetalleORDEN_COMPRA_AGRI1" runat="server" Visible="false" ></uc1:ucVistaDetalleORDEN_COMPRA_AGRI></TD>
        </TR>
    </TBODY>
</TABLE>
