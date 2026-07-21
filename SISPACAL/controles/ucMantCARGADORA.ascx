<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCARGADORA.ascx.vb" Inherits="controles_ucMantCARGADORA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCARGADORA" Src="~/controles/ucListaCARGADORA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCARGADORA" Src="~/controles/ucVistaDetalleCARGADORA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Cargadora</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCARGADORA id="ucListaCARGADORA1" runat="server" VerID_CARGADORA="true" VerNOMBRE="true" VerES_PROPIA="true"></uc1:ucListaCARGADORA>
                <uc1:ucVistaDetalleCARGADORA ID="ucVistaDetalleCARGADORA1" runat="server" Visible="false" ></uc1:ucVistaDetalleCARGADORA></TD>
        </TR>
    </TBODY>
</TABLE>
