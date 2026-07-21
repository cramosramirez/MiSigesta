<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTIPO_CARGADORA.ascx.vb" Inherits="controles_ucMantTIPO_CARGADORA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTIPO_CARGADORA" Src="~/controles/ucListaTIPO_CARGADORA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTIPO_CARGADORA" Src="~/controles/ucVistaDetalleTIPO_CARGADORA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Tipo cargadora</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTIPO_CARGADORA id="ucListaTIPO_CARGADORA1" runat="server"></uc1:ucListaTIPO_CARGADORA>
                <uc1:ucVistaDetalleTIPO_CARGADORA ID="ucVistaDetalleTIPO_CARGADORA1" runat="server" Visible="false" ></uc1:ucVistaDetalleTIPO_CARGADORA></TD>
        </TR>
    </TBODY>
</TABLE>
