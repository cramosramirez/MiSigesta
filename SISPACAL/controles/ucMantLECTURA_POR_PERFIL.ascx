<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantLECTURA_POR_PERFIL.ascx.vb" Inherits="controles_ucMantLECTURA_POR_PERFIL" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaLECTURA_POR_PERFIL" Src="~/controles/ucListaLECTURA_POR_PERFIL.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleLECTURA_POR_PERFIL" Src="~/controles/ucVistaDetalleLECTURA_POR_PERFIL.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Lectura por perfil</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaLECTURA_POR_PERFIL id="ucListaLECTURA_POR_PERFIL1" runat="server"></uc1:ucListaLECTURA_POR_PERFIL>
                <uc1:ucVistaDetalleLECTURA_POR_PERFIL ID="ucVistaDetalleLECTURA_POR_PERFIL1" runat="server" Visible="false" 
                VerUSUARIO_CREA = "false" 
                 VerFECHA_CREA  = "false" 
                 VerUSUARIO_ACT = "false" 
                 VerFECHA_ACT = "false" /></TD>
        </TR>
    </TBODY>
</TABLE>
