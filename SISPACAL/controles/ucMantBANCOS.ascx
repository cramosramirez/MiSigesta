<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantBANCOS.ascx.vb" Inherits="controles_ucMantBANCOS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaBANCOS" Src="~/controles/ucListaBANCOS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleBANCOS" Src="~/controles/ucVistaDetalleBANCOS.ascx" %>

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
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Bancos</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaBANCOS id="ucListaBANCOS1" runat="server" VerUSER_CREA="false" VerFECHA_CREA="false" VerUSER_ACT="false" VerFECHA_ACT="false" ></uc1:ucListaBANCOS>
                <uc1:ucVistaDetalleBANCOS ID="ucVistaDetalleBANCOS1" runat="server" Visible="false" VerUSER_CREA="false" VerFECHA_CREA="false" VerUSER_ACT="false" VerFECHA_ACT="false" ></uc1:ucVistaDetalleBANCOS></TD>
        </TR>
    </TBODY>
</TABLE>
</div>
