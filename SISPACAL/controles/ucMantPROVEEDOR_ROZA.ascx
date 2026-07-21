<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPROVEEDOR_ROZA.ascx.vb" Inherits="controles_ucMantPROVEEDOR_ROZA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPROVEEDOR_ROZA" Src="~/controles/ucListaPROVEEDOR_ROZA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePROVEEDOR_ROZA" Src="~/controles/ucVistaDetallePROVEEDOR_ROZA.ascx" %>
  
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>	      
         <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Proveedor roza</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPROVEEDOR_ROZA id="ucListaPROVEEDOR_ROZA1" runat="server"
            VerUSUARIO_CREA = "false" 
                 VerFECHA_CREA  = "false" 
                 VerUSUARIO_ACT = "false" 
                 VerFECHA_ACT = "false" 
                />    
                <uc1:ucVistaDetallePROVEEDOR_ROZA ID="ucVistaDetallePROVEEDOR_ROZA1" runat="server" Visible="false" 
                VerUSUARIO_CREA = "false" 
                 VerFECHA_CREA  = "false" 
                 VerUSUARIO_ACT = "false" 
                 VerFECHA_ACT = "false" 
                />    </TD>
        </TR>
    </TBODY>
</TABLE>
