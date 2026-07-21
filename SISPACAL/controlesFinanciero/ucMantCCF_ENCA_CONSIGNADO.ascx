<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCCF_ENCA_CONSIGNADO.ascx.vb" Inherits="controlesFinanciero_ucMantCCF_ENCA_CONSIGNADO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCCF_ENCA" Src="~/controlesFinanciero/ucListaCCF_ENCA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCCF_ENCA_CONSIGNADO" Src="~/controlesFinanciero/ucVistaDetalleCCF_ENCA_CONSIGNADO.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxCallbackPanel ID="cpMantCCF_ENCA" ClientInstanceName="cpMantCCF_ENCA" runat="server" ShowLoadingPanel="false" Width="100%" >
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>

    <ClientSideEvents EndCallback="OnEndCallback" ></ClientSideEvents>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">  
            <TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
                <TBODY>
	                   <TR>
			               <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
                    </TR>
		               <TR>
		                   <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Comprobantes de Crédito Fiscal / Facturas</asp:Label></TD>
		               </TR>
		               <TR>
			               <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		               </TR>
	                   <TR>
                        <TD><uc1:ucListaCCF_ENCA id="ucListaCCF_ENCA1" runat="server"></uc1:ucListaCCF_ENCA>
                            <uc1:ucVistaDetalleCCF_ENCA_CONSIGNADO ID="ucVistaDetalleCCF_ENCA_CONSIGNADO1" runat="server" Visible="false" ></uc1:ucVistaDetalleCCF_ENCA_CONSIGNADO></TD>
                    </TR>
                </TBODY>
            </TABLE>
    </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
