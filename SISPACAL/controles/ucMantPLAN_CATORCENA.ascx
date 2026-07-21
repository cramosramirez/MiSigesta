<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPLAN_CATORCENA.ascx.vb" Inherits="controles_ucMantPLAN_CATORCENA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPLAN_CATORCENA" Src="~/controles/ucListaPLAN_CATORCENA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePLAN_CATORCENA" Src="~/controles/ucVistaDetallePLAN_CATORCENA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Plan Catorcenal</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPLAN_CATORCENA id="ucListaPLAN_CATORCENA1" runat="server" VerUSUARIO_CREA="false" VerFECHA_CREA="false" VerUSUARIO_ACT="false" VerFECHA_ACT="false" ></uc1:ucListaPLAN_CATORCENA>
                <uc1:ucVistaDetallePLAN_CATORCENA ID="ucVistaDetallePLAN_CATORCENA1" runat="server" Visible="false" VerUSUARIO_CREA="false" VerFECHA_CREA="false" VerUSUARIO_ACT="false" VerFECHA_ACT="false" ></uc1:ucVistaDetallePLAN_CATORCENA></TD>
        </TR>
    </TBODY>
</TABLE>
