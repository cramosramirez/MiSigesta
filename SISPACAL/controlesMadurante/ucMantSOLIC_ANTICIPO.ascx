<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSOLIC_ANTICIPO.ascx.vb" Inherits="controles_ucMantSOLIC_ANTICIPO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSOLIC_ANTICIPO" Src="~/controlesMadurante/ucListaSOLIC_ANTICIPO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLIC_ANTICIPO" Src="~/controlesMadurante/ucVistaDetalleSOLIC_ANTICIPO.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<table id="Table1" cellspacing="0" cellpadding="0" width="100%" border="0">
	<tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
    <tr>
        <td align="center" class="EncabezadoSecciones"><asp:Label id="Label1" style="Z-INDEX: 101" runat="server">Mantenimiento de Solicitudes de Anticipo</asp:Label></td>
    </tr>
    <tr>
        <td>
            <dx:ASPxFormLayout ID="ucCriteriosSolicAnticipoLayout" ClientInstanceName="ucCriteriosSolicAnticipoLayout" runat="server" EnableTheming="True" Width="200px" >
            <Items>
                <dx:LayoutGroup ColCount="4" Caption="Criterios de búsqueda"  
                    GroupBoxDecoration="HeadingLine" SettingsItemCaptions-Location="Left" 
                    Name="glCriterios">
                    <Items>
                        <dx:LayoutItem Caption="Zafra:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32">
                                    </dx:ASPxComboBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="N° Solicitud:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">                           
                                    <dx:ASPxSpinEdit ID="txtNUM_SOLICITUD" runat="server" AllowNull="true" 
                                        AllowUserInput="true" ClientInstanceName="txtNUM_SOLICITUD" >                                        
                                    </dx:ASPxSpinEdit>     
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>        
                        <dx:LayoutItem Caption="Cod. Provee:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">                           
                                    <dx:ASPxSpinEdit ID="txtCODIPROVEE" runat="server" AllowNull="true" 
                                        AllowUserInput="true" ClientInstanceName="txtCODIPROVEE" >                                        
                                    </dx:ASPxSpinEdit>     
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>                        
                        <dx:LayoutItem Caption="Cod. Socio:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxSpinEdit ID="txtCODISOCIO" runat="server" 
                                        ClientInstanceName="txtCODISOCIO">                                        
                                    </dx:ASPxSpinEdit>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>
                        <dx:LayoutItem Caption="Nombre Proveedor:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" ClientInstanceName="txtNOMBRE_PROVEEDOR">                                        
                                    </dx:ASPxTextBox>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>                       
                        <dx:LayoutItem Caption="Fecha solicitud:">
                            <LayoutItemNestedControlCollection>
                                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                                    <dx:ASPxDateEdit ID="dteFECHA_SOLIC" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                        EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="170px">                                        
                                    </dx:ASPxDateEdit>
                                </dx:LayoutItemNestedControlContainer>
                            </LayoutItemNestedControlCollection>
                        </dx:LayoutItem>                       
                    </Items>
                    <SettingsItemCaptions HorizontalAlign="Left" Location="Left" 
                        VerticalAlign="Middle" />
                    <SettingsItems HorizontalAlign="Right" VerticalAlign="Middle" />
                </dx:LayoutGroup>
            </Items>
            <SettingsItems ShowCaption="True" />
        </dx:ASPxFormLayout>
        </td>
    </tr>
	<tr>
        <td>
        <uc1:ucListaSOLIC_ANTICIPO id="ucListaSOLIC_ANTICIPO1" PermitirVistaPrevia="True" PermitirAnalisisFinanciero="false" runat="server"></uc1:ucListaSOLIC_ANTICIPO>                
        </td>
    </tr>
    <tr>
        <td>
        <uc1:ucVistaDetalleSOLIC_ANTICIPO ID="ucVistaDetalleSOLIC_ANTICIPO1" runat="server" Visible="false" ></uc1:ucVistaDetalleSOLIC_ANTICIPO>
        </td>
    </tr>
</table>
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
