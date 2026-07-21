<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPERFIL.ascx.vb" Inherits="controles_ucMantPERFIL" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPERFIL" Src="~/controles/ucListaPERFIL.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePERFIL" Src="~/controles/ucVistaDetallePERFIL.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Perfil</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPERFIL id="ucListaPERFIL1" runat="server"></uc1:ucListaPERFIL>
                <uc1:ucVistaDetallePERFIL ID="ucVistaDetallePERFIL1" runat="server" Visible="false" ></uc1:ucVistaDetallePERFIL></TD>
        </TR>
    </TBODY>
</TABLE>
