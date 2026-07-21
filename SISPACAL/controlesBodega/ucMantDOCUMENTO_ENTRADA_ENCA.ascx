<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantDOCUMENTO_ENTRADA_ENCA.ascx.vb" Inherits="controles_ucMantDOCUMENTO_ENTRADA_ENCA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaDOCUMENTO_ENTRADA_ENCA" Src="~/controlesBodega/ucListaDOCUMENTO_ENTRADA_ENCA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleDOCUMENTO_ENTRADA_ENCA" Src="~/controlesBodega/ucVistaDetalleDOCUMENTO_ENTRADA_ENCA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Ingreso de Productos Consignados a Bodega</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaDOCUMENTO_ENTRADA_ENCA id="ucListaDOCUMENTO_ENTRADA_ENCA1" VerVistaPreviaReporte="true" runat="server"></uc1:ucListaDOCUMENTO_ENTRADA_ENCA>
                <uc1:ucVistaDetalleDOCUMENTO_ENTRADA_ENCA ID="ucVistaDetalleDOCUMENTO_ENTRADA_ENCA1" runat="server" Visible="false" ></uc1:ucVistaDetalleDOCUMENTO_ENTRADA_ENCA></TD>
        </TR>
    </TBODY>
</TABLE>
