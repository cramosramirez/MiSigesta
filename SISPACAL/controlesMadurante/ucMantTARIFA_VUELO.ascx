<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTARIFA_VUELO.ascx.vb" Inherits="controles_ucMantTARIFA_VUELO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTARIFA_VUELO" Src="~/controlesMadurante/ucListaTARIFA_VUELO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTARIFA_VUELO" Src="~/controlesMadurante/ucVistaDetalleTARIFA_VUELO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Tarifa vuelo</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTARIFA_VUELO id="ucListaTARIFA_VUELO1" runat="server"></uc1:ucListaTARIFA_VUELO>
                <uc1:ucVistaDetalleTARIFA_VUELO ID="ucVistaDetalleTARIFA_VUELO1" runat="server" Visible="false" ></uc1:ucVistaDetalleTARIFA_VUELO></TD>
        </TR>
    </TBODY>
</TABLE>
