<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantDESCUENTOS_PLANILLA_OC.ascx.vb" Inherits="controles_ucMantDESCUENTOS_PLANILLA_OC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaDESCUENTOS_PLANILLA_OC" Src="~/controles/ucListaDESCUENTOS_PLANILLA_OC.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleDESCUENTOS_PLANILLA_OC" Src="~/controles/ucVistaDetalleDESCUENTOS_PLANILLA_OC.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Descuentos planilla oc</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaDESCUENTOS_PLANILLA_OC id="ucListaDESCUENTOS_PLANILLA_OC1" runat="server"></uc1:ucListaDESCUENTOS_PLANILLA_OC>
                <uc1:ucVistaDetalleDESCUENTOS_PLANILLA_OC ID="ucVistaDetalleDESCUENTOS_PLANILLA_OC1" runat="server" Visible="false" ></uc1:ucVistaDetalleDESCUENTOS_PLANILLA_OC></TD>
        </TR>
    </TBODY>
</TABLE>
