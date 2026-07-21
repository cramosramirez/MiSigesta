<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantBASE_PROVEEDORES_MH.ascx.vb" Inherits="controles_ucMantBASE_PROVEEDORES_MH" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaBASE_PROVEEDORES_MH" Src="~/controles/ucListaBASE_PROVEEDORES_MH.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleBASE_PROVEEDORES_MH" Src="~/controles/ucVistaDetalleBASE_PROVEEDORES_MH.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">BASE FISCAL PARA M.H.</asp:Label>
                <br />
		       </TD>               
		   </TR>
	       <TR>
            <TD><uc1:ucListaBASE_PROVEEDORES_MH id="ucListaBASE_PROVEEDORES_MH1" runat="server"></uc1:ucListaBASE_PROVEEDORES_MH>
                <uc1:ucVistaDetalleBASE_PROVEEDORES_MH ID="ucVistaDetalleBASE_PROVEEDORES_MH1" runat="server" Visible="false" ></uc1:ucVistaDetalleBASE_PROVEEDORES_MH></TD>
        </TR>
    </TBODY>
</TABLE>
