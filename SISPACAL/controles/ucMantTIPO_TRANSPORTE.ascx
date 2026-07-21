<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTIPO_TRANSPORTE.ascx.vb" Inherits="controles_ucMantTIPO_TRANSPORTE" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTIPO_TRANSPORTE" Src="~/controles/ucListaTIPO_TRANSPORTE.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTIPO_TRANSPORTE" Src="~/controles/ucVistaDetalleTIPO_TRANSPORTE.ascx" %>
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
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Tipo transporte</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTIPO_TRANSPORTE id="ucListaTIPO_TRANSPORTE1" runat="server"></uc1:ucListaTIPO_TRANSPORTE>
                <uc1:ucVistaDetalleTIPO_TRANSPORTE ID="ucVistaDetalleTIPO_TRANSPORTE1" runat="server" Visible="false" 
                 VerUSUARIO_CREA = "false" 
                 VerFECHA_CREA  = "false" 
                 VerUSUARIO_ACT = "false" 
                 VerFECHA_ACT = "false" 
                /></TD>
        </TR>
    </TBODY>
</TABLE>
</div>