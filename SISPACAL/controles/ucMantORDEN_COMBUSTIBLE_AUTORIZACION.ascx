<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantORDEN_COMBUSTIBLE_AUTORIZACION.ascx.vb" Inherits="controles_ucMantORDEN_COMBUSTIBLE_AUTORIZACION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaORDEN_COMBUSTIBLE_AUTORIZACION" Src="~/controles/ucListaORDEN_COMBUSTIBLE_AUTORIZACION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleORDEN_COMBUSTIBLE_AUTORIZACION" Src="~/controles/ucVistaDetalleORDEN_COMBUSTIBLE_AUTORIZACION.ascx" %>

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
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Orden combustible autorizacion</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaORDEN_COMBUSTIBLE_AUTORIZACION id="ucListaORDEN_COMBUSTIBLE_AUTORIZACION1" runat="server" PermitirEditar="False" VerUSUARIO_CREA="false" VerUSUARIO_ACT="false" VerFECHA_CREA="false" VerFECHA_ACT="false" ></uc1:ucListaORDEN_COMBUSTIBLE_AUTORIZACION>
                <uc1:ucVistaDetalleORDEN_COMBUSTIBLE_AUTORIZACION ID="ucVistaDetalleORDEN_COMBUSTIBLE_AUTORIZACION1" runat="server" Visible="false" ></uc1:ucVistaDetalleORDEN_COMBUSTIBLE_AUTORIZACION></TD>
        </TR>
    </TBODY>
</TABLE>
</div>
