<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucPlanillaComplementoValorFinal.ascx.vb" Inherits="controles_ucPlanillaComplementoValorFinal" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>

<table cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
    <tr>
       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Generación de Planilla Pago Final a Cañeros</asp:Label></td>		
    </tr>
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                <Items>
                    <dx:LayoutGroup Caption="Información del Complemento al Valor Final de Pago" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem Caption="Zafra">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxComboBox ID="cbxZAFRA" AutoPostBack="true" runat="server" DataSourceID="odsZafra" 
                                            ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" 
                                            Width="170px">
                                    </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Complemento al Valor Final">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="speValorFinalPago" runat="server" DecimalPlaces="15" SpinButtons-ShowIncrementButtons="false"  HorizontalAlign="Right"
                                            DisplayFormatString="#0.000000000000000" AllowNull="true" Width="170px">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Name="FECHA_PAGO" Caption="Fecha pago:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="lytFECHA_PAGO" runat="server">
                                        <dx:ASPxDateEdit ID="dteFECHA_PAGO" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true" HorizontalAlign="Right"   
                                            EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="170px">                                
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:ASPxFormLayout>
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