<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAjusteInventarioQuemaRoza.ascx.vb" Inherits="controlesProforma_ucAjusteInventarioQuemaRoza" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
    <Items>
        <dx:LayoutGroup Caption="Información de Ajuste">
            <Items>
                <dx:LayoutItem ShowCaption="False" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">                            
                            <table>
                                <tr>
                                    <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Descripción:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="ASPxFormLayout1_E1" runat="server" Width="400px">
                                        </dx:ASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Tipo de movimiento:" /></td>
                                    <td>
                                        <dx:ASPxRadioButtonList ID="rblTipoMovimiento" ItemSpacing="20px" runat="server" RepeatDirection="Horizontal" >
                                            <Items>
                                                <dx:ListEditItem Text="Entrada" Value="1" Selected="true" />
                                                <dx:ListEditItem Text="Salida" Value="2" />
                                            </Items>                                            
                                        </dx:ASPxRadioButtonList>
                                    </td>
                                </tr>                                
                                <tr>
                                    <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Valor en TC:" /></td>
                                    <td>
                                        <dx:ASPxSpinEdit ID="speTC" HorizontalAlign="Right" Width="120px" runat="server" Number="0">
                                        </dx:ASPxSpinEdit>
                                    </td>
                                </tr>
                            </table>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>                
            </Items>
        </dx:LayoutGroup>
    </Items>
</dx:ASPxFormLayout>

