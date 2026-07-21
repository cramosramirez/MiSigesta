<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantORDEN_COMBUSTIBLE_PROD.ascx.vb" Inherits="controles_ucMantORDEN_COMBUSTIBLE_PROD" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaORDEN_COMBUSTIBLE_PROD" Src="~/controles/ucListaORDEN_COMBUSTIBLE_PROD.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleORDEN_COMBUSTIBLE_PROD" Src="~/controles/ucVistaDetalleORDEN_COMBUSTIBLE_PROD.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Orden combustible prod</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaORDEN_COMBUSTIBLE_PROD id="ucListaORDEN_COMBUSTIBLE_PROD1" runat="server"></uc1:ucListaORDEN_COMBUSTIBLE_PROD>
                <uc1:ucVistaDetalleORDEN_COMBUSTIBLE_PROD ID="ucVistaDetalleORDEN_COMBUSTIBLE_PROD1" runat="server" Visible="false" ></uc1:ucVistaDetalleORDEN_COMBUSTIBLE_PROD></TD>
        </TR>
    </TBODY>
</TABLE>
