<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantDATOS_LABORATORIO.ascx.vb" Inherits="controles_ucMantDATOS_LABORATORIO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaDATOS_LABORATORIO" Src="~/controles/ucListaDATOS_LABORATORIO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleDATOS_LABORATORIO" Src="~/controles/ucVistaDetalleDATOS_LABORATORIO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Datos laboratorio</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaDATOS_LABORATORIO id="ucListaDATOS_LABORATORIO1" runat="server"></uc1:ucListaDATOS_LABORATORIO>
                <uc1:ucVistaDetalleDATOS_LABORATORIO ID="ucVistaDetalleDATOS_LABORATORIO1" runat="server" Visible="false" ></uc1:ucVistaDetalleDATOS_LABORATORIO></TD>
        </TR>
    </TBODY>
</TABLE>
