<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantBITACORA_USUARIO.ascx.vb" Inherits="controles_ucMantBITACORA_USUARIO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaBITACORA_USUARIO" Src="~/controles/ucListaBITACORA_USUARIO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleBITACORA_USUARIO" Src="~/controles/ucVistaDetalleBITACORA_USUARIO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Bitacora usuario</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaBITACORA_USUARIO id="ucListaBITACORA_USUARIO1" runat="server"></uc1:ucListaBITACORA_USUARIO>
                <uc1:ucVistaDetalleBITACORA_USUARIO ID="ucVistaDetalleBITACORA_USUARIO1" runat="server" Visible="false" ></uc1:ucVistaDetalleBITACORA_USUARIO></TD>
        </TR>
    </TBODY>
</TABLE>
