<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucLiquidacionSaldoQuemaRoza.ascx.vb" Inherits="controlesProforma_ucLiquidacionSaldoQuemaRoza" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
    <Items>
        <dx:LayoutGroup ShowCaption="False">
            <Items>
                <dx:LayoutItem ShowCaption="false" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                            <table width="300px">
                                <tr>
                                    <th style="text-align:justify" colspan="4">
                                        <dx:ASPxLabel ID="lblMensaje" runat="server" Text="" />
                                    </th>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td style="text-align:center">
                                        <dx:ASPxButton ID="btnAceptar" AutoPostBack="true" runat="server" Text="Aceptar">
                                        </dx:ASPxButton>
                                    </td>
                                    <td style="text-align:center">
                                        <dx:ASPxButton ID="btnCancelar" AutoPostBack="true" runat="server" Text="Cancelar">
                                        </dx:ASPxButton>
                                    </td>
                                    <td></td>
                                </tr>
                            </table>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>
        </dx:LayoutGroup>
    </Items>
</dx:ASPxFormLayout>

