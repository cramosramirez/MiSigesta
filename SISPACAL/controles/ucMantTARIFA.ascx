<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTARIFA.ascx.vb" Inherits="controles_ucMantTARIFA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTARIFA" Src="~/controles/ucListaTARIFA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTARIFA" Src="~/controles/ucVistaDetalleTARIFA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Tarifa</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTARIFA id="ucListaTARIFA1" runat="server"></uc1:ucListaTARIFA>
                <uc1:ucVistaDetalleTARIFA ID="ucVistaDetalleTARIFA1" runat="server" Visible="false" ></uc1:ucVistaDetalleTARIFA></TD>
        </TR>
    </TBODY>
</TABLE>
