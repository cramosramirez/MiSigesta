<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSUB_ZONAS.ascx.vb" Inherits="controles_ucMantSUB_ZONAS" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSUB_ZONAS" Src="~/controlesContrato/ucListaSUB_ZONAS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSUB_ZONAS" Src="~/controlesContrato/ucVistaDetalleSUB_ZONAS.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Sub zonas</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
		   <TR>
		       <TD><asp:Label id="lblZONA" style="Z-INDEX: 101" runat="server" CssClass="Normal">Zonas : </asp:Label><cc1:ddlZONAS id="ddlZONASZONA" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlZONAS></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="imgSeparador1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaSUB_ZONAS id="ucListaSUB_ZONAS1" runat="server"></uc1:ucListaSUB_ZONAS>
                <uc1:ucVistaDetalleSUB_ZONAS ID="ucVistaDetalleSUB_ZONAS1" runat="server" Visible="false" ></uc1:ucVistaDetalleSUB_ZONAS></TD>
        </TR>
    </TBODY>
</TABLE>
