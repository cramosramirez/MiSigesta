<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDisponibilidadInventarioRozaPorc.ascx.vb" Inherits="controlesProforma_ucDisponibilidadInventarioRozaPorc" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<br />
<br />

<center>
<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
    <Items>
        <dx:LayoutGroup Caption="Margen de Disponibilidad de Inventario de Roza" 
            Width="500px">
            <Items>
                <dx:LayoutItem Caption="Ingrese el Porcentaje de Disponibilidad entre 1% y 100%">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <dx:ASPxSpinEdit ID="speDISPO_INVE_ROZA" runat="server" DecimalPlaces="2" 
                                HorizontalAlign="Right" Number="0" Width="160px">
                            </dx:ASPxSpinEdit>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                    <CaptionSettings VerticalAlign="Middle" />
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
    </Items>
</dx:ASPxFormLayout>
</center>
