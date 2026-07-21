<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTIPO_DESCUENTO.ascx.vb" Inherits="controles_ucMantTIPO_DESCUENTO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTIPO_DESCUENTO" Src="~/controles/ucListaTIPO_DESCUENTO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTIPO_DESCUENTO" Src="~/controles/ucVistaDetalleTIPO_DESCUENTO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Tipo descuento</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTIPO_DESCUENTO id="ucListaTIPO_DESCUENTO1" runat="server"></uc1:ucListaTIPO_DESCUENTO>
                <uc1:ucVistaDetalleTIPO_DESCUENTO ID="ucVistaDetalleTIPO_DESCUENTO1" runat="server" Visible="false" ></uc1:ucVistaDetalleTIPO_DESCUENTO></TD>
        </TR>
    </TBODY>
</TABLE>
