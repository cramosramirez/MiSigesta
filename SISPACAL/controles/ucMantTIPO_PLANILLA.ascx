<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTIPO_PLANILLA.ascx.vb" Inherits="controles_ucMantTIPO_PLANILLA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTIPO_PLANILLA" Src="~/controles/ucListaTIPO_PLANILLA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTIPO_PLANILLA" Src="~/controles/ucVistaDetalleTIPO_PLANILLA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Tipo planilla</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTIPO_PLANILLA id="ucListaTIPO_PLANILLA1" runat="server"></uc1:ucListaTIPO_PLANILLA>
                <uc1:ucVistaDetalleTIPO_PLANILLA ID="ucVistaDetalleTIPO_PLANILLA1" runat="server" Visible="false" ></uc1:ucVistaDetalleTIPO_PLANILLA></TD>
        </TR>
    </TBODY>
</TABLE>
