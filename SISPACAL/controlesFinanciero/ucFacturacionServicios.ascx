<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucFacturacionServicios.ascx.vb" Inherits="controlesFinanciero_ucFacturacionServicios" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTRATO_CTAS_PROVI" Src="~/controlesFinanciero/ucListaCONTRATO_CTAS_PROVI.ascx" %>

<table id="Table1" cellspacing="0" cellpadding="0" width="100%" border="0">
	<tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
    <tr>
        <td align="center" class="EncabezadoSecciones"><asp:Label id="Label1" style="Z-INDEX: 101" runat="server">Facturación de Productos/Servicios</asp:Label></td>
    </tr>
    <tr>
        <td>
            <dx:ASPxFormLayout ID="ucCriteriosFacturacionServiciosLayout" ClientInstanceName="ucCriteriosFacturacionServiciosLayout" runat="server" EnableTheming="True" Width="200px" >
            <Items>
                <dx:LayoutGroup ColCount="4" Caption="Criterios de búsqueda para Solicitudes Agrícolas pendientes de Facturar"  
                    GroupBoxDecoration="HeadingLine" SettingsItemCaptions-Location="Left" 
                    Name="glCriterios">
                    <Items>
                        <dx:LayoutItem Caption="Zafra">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100px" >
                                    </dx:ASPxComboBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="Tipo de Contribuyente">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">                           
                                    <dx:ASPxComboBox ID="cbxTIPO_CONTRIBUYENTE" ClientInstanceName="cbxTIPO_CONTRIBUYENTE" runat="server" ValueType="System.Int32" Width="200px">                           
                                        <Items>                                            
                                            <dx:ListEditItem Text="NO CONTRIBUYENTE" Value="0" />
                                            <dx:ListEditItem Text="CONTRIBUYENTE" Value="1" />                                            
                                        </Items>                                        
                                    </dx:ASPxComboBox>    
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>        
                        <dx:LayoutItem Caption="Cod. Provee">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer66" runat="server">                           
                                    <dx:ASPxSpinEdit ID="txtCODIPROVEE" runat="server" AllowNull="true" Width="120px"  
                                        AllowUserInput="true" ClientInstanceName="txtCODIPROVEE" >                                        
                                    </dx:ASPxSpinEdit>     
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>                                                
                        <dx:LayoutItem Caption="Nombre Proveedor">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                    <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" ClientInstanceName="txtNOMBRE_PROVEEDOR">                                        
                                    </dx:ASPxTextBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>       
                        <dx:LayoutItem Caption="Financiamiento" ColSpan="2">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                   <dx:ASPxComboBox ID="cbxTIPO_FINANCIAMIENTO" runat="server" ValueField="ID_CUENTA_FINAN" 
                                            TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinan" >                                       
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                    </dx:ASPxComboBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>                                                      
                    </Items>
                    <SettingsItemCaptions HorizontalAlign="Left" Location="Left" 
                        VerticalAlign="Middle" />
                    <SettingsItems VerticalAlign="Middle" />
                </dx:LayoutGroup>
            </Items>
            <SettingsItems ShowCaption="True" />
        </dx:ASPxFormLayout>
        </td>
    </tr>
	<tr>
        <td>
        <uc1:ucListaCONTRATO_CTAS_PROVI id="ucListaCONTRATO_CTAS_PROVI" 
        PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false"
        PermitirEditar="false" PermitirEliminar="false" TamanoPagina="5" MostrarCheckVariaSeleccion="true"
        PermitirSeleccionar="false" VerABONO="false" VerSALDO="false" VerCODIPROVEE="True"
        VerNOMBRE_PROVEEDOR="true" VerNO_CONTRATO="true" VerCONCEPTO="true"                 
        runat="server">
        </uc1:ucListaCONTRATO_CTAS_PROVI>  
        </td>
    </tr>
    <tr>
        <td>
        </td>
    </tr>
</table>

<dx:ASPxPopupControl ID="pcGenerarFactCCF" runat="server" CloseAction="CloseButton" Modal="True" Width="600px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcGenerarFactCCF"
        HeaderText="Generar Facturas/CCF" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">  
                        <dx:ASPxLabel ID="lblpcError" runat="server" Font-Bold="true" ForeColor="Red" /><br />                                              
                        <table width="100%">
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Ingrese N° Inicial de Factura o CCF:">
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speNO_DOCTO" HorizontalAlign="Right" runat="server" 
                                        DecimalPlaces="0" SpinButtons-ShowIncrementButtons="false" 
                                        Width="170px" >
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                    </dx:ASPxSpinEdit> 
                                </td>                               
                            </tr>                            
                        </table>
                        <hr />
                        <table width="100%">                            
                            <tr>
                                <td style="padding-right:7px; text-align:right">
                                    <dx:ASPxButton ID="btnGenerar" runat="server" AutoPostBack="true" Text="Generar">                                        
                                    </dx:ASPxButton>    
                                </td>
                                <td style="padding-left:7px">  
                                    <dx:ASPxButton ID="btnCancelar" runat="server" Text="Cancelar">
                                        <ClientSideEvents Click="function(s,e){pcGenerarFactCCF.Hide()}" /> 
                                    </dx:ASPxButton> 
                                </td>
                            </tr>                            
                        </table>
                        
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl>


<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCuentaFinan" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorCriterios" 
    TypeName="SISPACAL.BL.cCUENTA_FINAN">  
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="AgregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="APLICA_SOLIC_AGRICOLA" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>

