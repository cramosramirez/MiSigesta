<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCHEQUE_PLANILLA.ascx.vb" Inherits="controles_ucMantCHEQUE_PLANILLA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCHEQUE_PLANILLA" Src="~/controles/ucListaCHEQUE_PLANILLA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCHEQUE_PLANILLA" Src="~/controles/ucVistaDetalleCHEQUE_PLANILLA.ascx" %>

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
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Cheque planilla</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCHEQUE_PLANILLA id="ucListaCHEQUE_PLANILLA1" runat="server" VerUSUARIO_CREA="false" VerUSUARIO_ACT="false" VerFECHA_CREA="false" VerFECHA_ACT="false"></uc1:ucListaCHEQUE_PLANILLA>
                <uc1:ucVistaDetalleCHEQUE_PLANILLA ID="ucVistaDetalleCHEQUE_PLANILLA1" runat="server" Visible="false" VerUSUARIO_CREA="false" VerUSUARIO_ACT="false" VerFECHA_CREA="false" VerFECHA_ACT="false" ></uc1:ucVistaDetalleCHEQUE_PLANILLA></TD>
        </TR>
    </TBODY>
</TABLE>
</div>
