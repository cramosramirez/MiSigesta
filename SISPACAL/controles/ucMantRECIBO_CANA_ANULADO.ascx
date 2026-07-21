<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantRECIBO_CANA_ANULADO.ascx.vb" Inherits="controles_ucMantRECIBO_CANA_ANULADO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaRECIBO_CANA_ANULADO" Src="~/controles/ucListaRECIBO_CANA_ANULADO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleRECIBO_CANA_ANULADO" Src="~/controles/ucVistaDetalleRECIBO_CANA_ANULADO.ascx" %>
<style type="text/css">  
    div.centraTabla
    {
        font-size: small;     
        font-family: Tahoma;                   	
        text-align: center;
        padding-bottom: 15px; 
        padding-top: 10px;
        padding-left: 15px;
        padding-right: 15px 
    }

    div.centraTabla table {
        margin: 0 auto;
        text-align: left;
    }    
</style>
<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<div class="centraTabla">  
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>	       
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Recibo cana anulado</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaRECIBO_CANA_ANULADO id="ucListaRECIBO_CANA_ANULADO1" runat="server" 
                VerUSUARIO_CREA="false" VerFECHA_CREA="false" VerUSUARIO_ACT="false" VerFECHA_ACT="false" 
                PermitirEditar="false" PermitirEliminar="false" />
                <uc1:ucVistaDetalleRECIBO_CANA_ANULADO ID="ucVistaDetalleRECIBO_CANA_ANULADO1" runat="server" Visible="false" 
                VerUSUARIO_CREA="false" VerFECHA_CREA="false" VerUSUARIO_ACT="false" VerFECHA_ACT="false" VerFECHA_ANULACION="false"  
                VerID_ENVIO="false" VerID_RECIBO_CANA_ANUL="false"   
                /></TD>
        </TR>
    </TBODY>
</TABLE>
</div>