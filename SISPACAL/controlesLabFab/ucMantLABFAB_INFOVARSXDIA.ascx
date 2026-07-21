<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantLABFAB_INFOVARSXDIA.ascx.vb" Inherits="controles_ucMantLABFAB_INFOVARSXDIA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaLABFAB_INFOVARSXDIA" Src="~/controlesLabFab/ucListaLABFAB_INFOVARSXDIA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleLABFAB_INFOVARSXDIA" Src="~/controlesLabFab/ucVistaDetalleLABFAB_INFOVARSXDIA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Labfab infovarsxdia</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaLABFAB_INFOVARSXDIA id="ucListaLABFAB_INFOVARSXDIA1" runat="server"></uc1:ucListaLABFAB_INFOVARSXDIA>
                <uc1:ucVistaDetalleLABFAB_INFOVARSXDIA ID="ucVistaDetalleLABFAB_INFOVARSXDIA1" runat="server" Visible="false" ></uc1:ucVistaDetalleLABFAB_INFOVARSXDIA></TD>
        </TR>
    </TBODY>
</TABLE>
