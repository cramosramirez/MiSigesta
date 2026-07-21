<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTIPO_PROVEEDOR.ascx.vb" Inherits="controles_ucMantTIPO_PROVEEDOR" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTIPO_PROVEEDOR" Src="~/controles/ucListaTIPO_PROVEEDOR.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTIPO_PROVEEDOR" Src="~/controles/ucVistaDetalleTIPO_PROVEEDOR.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Tipo proveedor</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTIPO_PROVEEDOR id="ucListaTIPO_PROVEEDOR1" runat="server"></uc1:ucListaTIPO_PROVEEDOR>
                <uc1:ucVistaDetalleTIPO_PROVEEDOR ID="ucVistaDetalleTIPO_PROVEEDOR1" runat="server" Visible="false" ></uc1:ucVistaDetalleTIPO_PROVEEDOR></TD>
        </TR>
    </TBODY>
</TABLE>
