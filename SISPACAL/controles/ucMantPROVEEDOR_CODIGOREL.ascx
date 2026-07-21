<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPROVEEDOR_CODIGOREL.ascx.vb" Inherits="controles_ucMantPROVEEDOR_CODIGOREL" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPROVEEDOR_CODIGOREL" Src="~/controles/ucListaPROVEEDOR_CODIGOREL.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePROVEEDOR_CODIGOREL" Src="~/controles/ucVistaDetallePROVEEDOR_CODIGOREL.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Proveedor codigorel</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPROVEEDOR_CODIGOREL id="ucListaPROVEEDOR_CODIGOREL1" runat="server"></uc1:ucListaPROVEEDOR_CODIGOREL>
                <uc1:ucVistaDetallePROVEEDOR_CODIGOREL ID="ucVistaDetallePROVEEDOR_CODIGOREL1" runat="server" Visible="false" ></uc1:ucVistaDetallePROVEEDOR_CODIGOREL></TD>
        </TR>
    </TBODY>
</TABLE>
