<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantLABFAB_ANALISISXDIA.ascx.vb" Inherits="controles_ucMantLABFAB_ANALISISXDIA" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaLABFAB_ANALISISXDIA" Src="~/controlesLabFab/ucListaLABFAB_ANALISISXDIA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleLABFAB_ANALISISXDIA" Src="~/controlesLabFab/ucVistaDetalleLABFAB_ANALISISXDIA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Análisis por Día Zafra</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>          
	       <TR>
            <TD><uc1:ucListaLABFAB_ANALISISXDIA id="ucListaLABFAB_ANALISISXDIA1" runat="server" ></uc1:ucListaLABFAB_ANALISISXDIA>
                <uc1:ucVistaDetalleLABFAB_ANALISISXDIA ID="ucVistaDetalleLABFAB_ANALISISXDIA1" runat="server" Visible="false" ></uc1:ucVistaDetalleLABFAB_ANALISISXDIA></TD>
        </TR>
    </TBODY>
</TABLE>
