<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantZAFRA.ascx.vb" Inherits="controles_ucMantZAFRA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaZAFRA" Src="~/controles/ucListaZAFRA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleZAFRA" Src="~/controles/ucVistaDetalleZAFRA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">ZAFRA</asp:Label></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaZAFRA id="ucListaZAFRA1" runat="server"></uc1:ucListaZAFRA>
                <uc1:ucVistaDetalleZAFRA ID="ucVistaDetalleZAFRA1" runat="server" Visible="false" ></uc1:ucVistaDetalleZAFRA></TD>
        </TR>
    </TBODY>
</TABLE>
