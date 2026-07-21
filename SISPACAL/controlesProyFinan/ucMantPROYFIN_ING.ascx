<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPROYFIN_ING.ascx.vb" Inherits="controles_ucMantPROYFIN_ING" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPROYFIN_ING" Src="~/controlesProyFinan/ucListaPROYFIN_ING.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePROYFIN_ING" Src="~/controlesProyFinan/ucVistaDetallePROYFIN_ING.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="left" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">PROYECCIÓN DE INGRESOS</asp:Label></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPROYFIN_ING id="ucListaPROYFIN_ING1" runat="server"></uc1:ucListaPROYFIN_ING>
                <uc1:ucVistaDetallePROYFIN_ING ID="ucVistaDetallePROYFIN_ING1" runat="server" Visible="false" ></uc1:ucVistaDetallePROYFIN_ING></TD>
        </TR>
    </TBODY>
</TABLE>
