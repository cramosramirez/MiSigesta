<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantMOTORISTA.ascx.vb" Inherits="controles_ucMantMOTORISTA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaMOTORISTA" Src="~/controles/ucListaMOTORISTA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleMOTORISTA" Src="~/controles/ucVistaDetalleMOTORISTA.ascx" %>


<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>	       
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Motorista</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaMOTORISTA id="ucListaMOTORISTA1" runat="server"
            VerUSUARIO_CREA = "false" 
                 VerFECHA_CREA  = "false" 
                 VerUSUARIO_ACT = "false" 
                 VerFECHA_ACT = "false" 
                />    
                <uc1:ucVistaDetalleMOTORISTA ID="ucVistaDetalleMOTORISTA1" runat="server" Visible="false"
                VerUSUARIO_CREA = "false" 
                 VerFECHA_CREA  = "false" 
                 VerUSUARIO_ACT = "false" 
                 VerFECHA_ACT = "false" 
                />    </TD>
        </TR>
    </TBODY>
</TABLE>
