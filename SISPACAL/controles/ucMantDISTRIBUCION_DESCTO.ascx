<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantDISTRIBUCION_DESCTO.ascx.vb" Inherits="controles_ucMantDISTRIBUCION_DESCTO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaDISTRIBUCION_DESCTO" Src="~/controles/ucListaDISTRIBUCION_DESCTO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleDISTRIBUCION_DESCTO" Src="~/controles/ucVistaDetalleDISTRIBUCION_DESCTO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Distribucion descto</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaDISTRIBUCION_DESCTO id="ucListaDISTRIBUCION_DESCTO1" runat="server"></uc1:ucListaDISTRIBUCION_DESCTO>
                <uc1:ucVistaDetalleDISTRIBUCION_DESCTO ID="ucVistaDetalleDISTRIBUCION_DESCTO1" runat="server" Visible="false" ></uc1:ucVistaDetalleDISTRIBUCION_DESCTO></TD>
        </TR>
    </TBODY>
</TABLE>
