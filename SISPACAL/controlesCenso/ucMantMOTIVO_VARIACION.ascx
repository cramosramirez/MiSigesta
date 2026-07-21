<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantMOTIVO_VARIACION.ascx.vb" Inherits="controles_ucMantMOTIVO_VARIACION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaMOTIVO_VARIACION" Src="~/controlesCenso/ucListaMOTIVO_VARIACION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleMOTIVO_VARIACION" Src="~/controlesCenso/ucVistaDetalleMOTIVO_VARIACION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Motivos de Variación</asp:Label></TD>
		   </TR>
		   <tr><td><hr /></td></tr>
	       <TR>
            <TD><uc1:ucListaMOTIVO_VARIACION id="ucListaMOTIVO_VARIACION1" runat="server" VerUSUARIO_CREA="False" VerFECHA_CREA="False" VerUSUARIO_ACT="False" VerFECHA_ACT="false"></uc1:ucListaMOTIVO_VARIACION>
                <uc1:ucVistaDetalleMOTIVO_VARIACION ID="ucVistaDetalleMOTIVO_VARIACION1" runat="server" Visible="false" VerUSUARIO_CREA="False" VerFECHA_CREA="False" VerUSUARIO_ACT="False" VerFECHA_ACT="false" ></uc1:ucVistaDetalleMOTIVO_VARIACION></TD>
        </TR>
    </TBODY>
</TABLE>
