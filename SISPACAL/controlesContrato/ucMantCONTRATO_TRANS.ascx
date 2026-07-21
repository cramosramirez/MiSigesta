<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCONTRATO_TRANS.ascx.vb" Inherits="controles_ucMantCONTRATO_TRANS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTRATO_TRANS" Src="~/controlesContrato/ucListaCONTRATO_TRANS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTRATO_TRANS" Src="~/controlesContrato/ucVistaDetalleCONTRATO_TRANS.ascx" %>

<script type="text/javascript">
    var postponedCallbackRequired = false;

    function CrearTransportista() {
        window.open("../Catalogos/wfMantTRANSPORTISTA.aspx?op=1", "_blank", "")
    }       
</script>

<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Contrato Transportistas</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCONTRATO_TRANS id="ucListaCONTRATO_TRANS1" PermitirVistaPrevia="True" runat="server"></uc1:ucListaCONTRATO_TRANS>
                <uc1:ucVistaDetalleCONTRATO_TRANS ID="ucVistaDetalleCONTRATO_TRANS1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTRATO_TRANS></TD>
        </TR>
    </TBODY>
</TABLE>
