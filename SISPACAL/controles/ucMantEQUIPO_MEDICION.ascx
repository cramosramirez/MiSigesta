<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantEQUIPO_MEDICION.ascx.vb" Inherits="controles_ucMantEQUIPO_MEDICION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaEQUIPO_MEDICION" Src="~/controles/ucListaEQUIPO_MEDICION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleEQUIPO_MEDICION" Src="~/controles/ucVistaDetalleEQUIPO_MEDICION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Equipo medicion</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaEQUIPO_MEDICION id="ucListaEQUIPO_MEDICION1" runat="server" 
                 VerUSUARIO_CREA = "false" 
                 VerFECHA_CREA  = "false" 
                 VerUSUARIO_ACT = "false" 
                 VerFECHA_ACT = "false" 
                />
                <uc1:ucVistaDetalleEQUIPO_MEDICION ID="ucVistaDetalleEQUIPO_MEDICION1" runat="server" Visible="false" 
                 VerUSUARIO_CREA = "false" 
                 VerFECHA_CREA  = "false" 
                 VerUSUARIO_ACT = "false" 
                 VerFECHA_ACT = "false" 
                />    
             </TD>            
        </TR>
    </TBODY>
</TABLE>
