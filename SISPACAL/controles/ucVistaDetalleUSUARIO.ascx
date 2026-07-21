<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleUSUARIO.ascx.vb" Inherits="controles_ucVistaDetalleUSUARIO" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>

<table width="100%" >
    <tr>
        <td align="center">
                <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                    <Items>
                        <dx:LayoutGroup Caption="Creando/Editando Usuario" ColCount="2" >
                            <Items>
                                <dx:LayoutItem Caption="Usuario:">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                            <dx:ASPxTextBox ID="txtUSUARIO" MaxLength="100" runat="server" Width="250px">
                                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                    <RequiredField ErrorText="Usuario es obligatorio" IsRequired="True" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Nombre del usuario:">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                            <dx:ASPxTextBox ID="txtNOMBRE_USUARIO" runat="server" MaxLength="200" Width="250px">
                                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                    <RequiredField ErrorText="Nombre del usuario es obligatorio" IsRequired="True" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Email:">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                            <dx:ASPxTextBox ID="txtEMAIL" runat="server" MaxLength="100" Width="250px">
                                            </dx:ASPxTextBox>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Clave:">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                            <dx:ASPxTextBox ID="txtCLAVE" ClientInstanceName="txtCLAVE" Password="true" MaxLength="200" runat="server" Width="250px">
                                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                    <RequiredField ErrorText="La clave es obligatoria" IsRequired="True" />
                                                </ValidationSettings>
                                                <ClientSideEvents Init="function(s,e){if(hfUsuario.Get('Nuevo')==0)txtCLAVE.SetValue('121131313131')}" /> 
                                            </dx:ASPxTextBox>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Perfil asignado:">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                            <dx:ASPxComboBox ID="cbxPERFIL" DataSourceID="odsPerfil" ValueField="ID_PERFIL" ValueType="System.Int32" DropDownStyle="DropDownList" TextField="NOMBRE_PERFIL" runat="server" Width="250px">
                                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                    <RequiredField ErrorText="Debe seleccionar un perfil" IsRequired="True" />
                                                </ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Último acceso:">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                                            <dx:ASPxDateEdit ID="dteFECHA_ULT_ACCESO" runat="server" 
                                                DisplayFormatString="dd/MM/yyyy HH:mm" EditFormat="Custom" 
                                                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" Width="250px">                                                
                                            </dx:ASPxDateEdit>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>                
                                <dx:LayoutItem Caption="Activo:">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                            <dx:ASPxCheckBox ID="chkActivo" runat="server" CheckState="Unchecked">
                                            </dx:ASPxCheckBox>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem Caption="Bloqueado:">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer runat="server">
                                            <dx:ASPxCheckBox ID="chkBloqueado" runat="server" CheckState="Unchecked">
                                            </dx:ASPxCheckBox>
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
<dx:ASPxHiddenField runat="server" ClientInstanceName="hfUsuario" ID="hfUsuario" SyncWithServer="true" />
<asp:ObjectDataSource ID="odsPerfil" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cPERFIL">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_PERFIL" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>