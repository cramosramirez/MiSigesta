<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCCF_ENCA_TRANS.ascx.vb" Inherits="controles_ucMantCCF_ENCA_TRANS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCCF_ENCA_TRANS" Src="~/controlesTransporte/ucListaCCF_ENCA_TRANS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCCF_ENCA_TRANS" Src="~/controlesTransporte/ucVistaDetalleCCF_ENCA_TRANS.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxCallbackPanel ID="cpMantCCF_ENCA_TRANS" ClientInstanceName="cpMantCCF_ENCA_TRANS" runat="server" ShowLoadingPanel="false" Width="100%" >
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
		                   <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Ccf enca trans</asp:Label></TD>
		               </TR>
		               <TR>
			               <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		               </TR>
	                   <TR>
                        <TD><uc1:ucListaCCF_ENCA_TRANS id="ucListaCCF_ENCA_TRANS1" runat="server"></uc1:ucListaCCF_ENCA_TRANS>
                            <uc1:ucVistaDetalleCCF_ENCA_TRANS ID="ucVistaDetalleCCF_ENCA_TRANS1" runat="server" Visible="false" ></uc1:ucVistaDetalleCCF_ENCA_TRANS></TD>
                    </TR>
                </TBODY>
            </TABLE>
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
