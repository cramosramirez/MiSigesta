<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPROFORMA.ascx.vb" Inherits="controles_ucMantPROFORMA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPROFORMA" Src="~/controlesProforma/ucListaPROFORMA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucEnvioProforma" Src="~/controlesProforma/ucEnvioProforma.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxCallbackPanel ID="cpMantProforma" ClientInstanceName="cpMantProforma" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">   
            <table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Emisión de Proforma</asp:Label></td>
		   </tr>
		   <tr>
			   <td>   
               <dx:ASPxFormLayout ID="ucCriteriosRegistroProforma" runat="server" SettingsItemCaptions-Location="Left" 
                    Name="glCriterios">
                       <Items>
                           <dx:LayoutGroup Caption="Criterios de búsqueda" ColCount="4" 
                               GroupBoxDecoration="HeadingLine">
                               <Items>
                                   <dx:LayoutItem Caption="Zafra:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                               <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px" AutoPostBack="true" >
                                                </dx:ASPxComboBox>
                                           </dx:LayoutItemNestedControlContainer>   
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>                                   
                                   <dx:LayoutItem Caption="Cod. Provee:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                                <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true"
                                                    Width="120px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Cod. Socio:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                               <dx:ASPxSpinEdit ID="speCODISOCIO" runat="server"  AllowNull="true"
                                                   Width="120px">
                                               </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                   <dx:LayoutItem Caption="Nombre Proveedor:" ColSpan="3">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                                               <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="100%">
                                               </dx:ASPxTextBox>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>                                     
                               </Items>
                           </dx:LayoutGroup>
                       </Items>

<SettingsItemCaptions Location="Left"></SettingsItemCaptions>
                   </dx:ASPxFormLayout>
                </td>
		   </tr>
	       <tr>
            <td><uc1:ucListaPROFORMA id="ucListaPROFORMA1" PermitirEliminar="false"  PermitirVistaPrevia="True" PermitirRowHotTrack="false" runat="server"></uc1:ucListaPROFORMA> 
                <uc1:ucEnvioProforma ID="ucEnvioProforma1" runat="server" Visible="false" ></uc1:ucEnvioProforma>                          
            </td>
        </tr>
</table>
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>