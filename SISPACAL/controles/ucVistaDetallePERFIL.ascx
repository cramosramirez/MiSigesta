<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePERFIL.ascx.vb" Inherits="controles_ucVistaDetallePERFIL" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<table width="100%" >
    <tr>
        <td align="center">
                <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                    <Items>
                        <dx:LayoutGroup Caption="Creando/Editando Perfil" ColCount="1" >
                            <Items>
                                <dx:LayoutItem Caption="Id Perfil:">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                            <dx:ASPxTextBox ID="txtID_PERFIL" runat="server" Width="250px">                                               
                                            </dx:ASPxTextBox>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Nombre de Perfil:">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                            <dx:ASPxTextBox ID="txtNOMBRE_PERFIL" runat="server" MaxLength="100" Width="250px">
                                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                    <RequiredField ErrorText="Nombre de perfil es obligatorio" IsRequired="True" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
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

