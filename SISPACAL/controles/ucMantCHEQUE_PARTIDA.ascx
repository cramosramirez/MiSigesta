<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCHEQUE_PARTIDA.ascx.vb" Inherits="controles_ucMantCHEQUE_PARTIDA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCHEQUE_PARTIDA" Src="~/controles/ucListaCHEQUE_PARTIDA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCHEQUE_PARTIDA" Src="~/controles/ucVistaDetalleCHEQUE_PARTIDA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Cheque partida</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCHEQUE_PARTIDA id="ucListaCHEQUE_PARTIDA1" runat="server" VerUSUARIO_CREA="false" VerUSUARIO_ACT="false" VerFECHA_CREA="false" VerFECHA_ACT="false"></uc1:ucListaCHEQUE_PARTIDA>
                <uc1:ucVistaDetalleCHEQUE_PARTIDA ID="ucVistaDetalleCHEQUE_PARTIDA1" runat="server" Visible="false" VerUSUARIO_CREA="false" VerUSUARIO_ACT="false" VerFECHA_CREA="false" VerFECHA_ACT="false"></uc1:ucVistaDetalleCHEQUE_PARTIDA></TD>
        </TR>
    </TBODY>
</TABLE>
