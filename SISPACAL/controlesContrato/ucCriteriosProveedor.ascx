<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosProveedor.ascx.vb" Inherits="controlesMaestro_ucCriteriosProveedor" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<script type="text/javascript">
    function SetearCamposTexto() {
        hfCriteriosProveedor.Set('CODIPROVEE', txtCODIPROVEE.GetValue());
        hfCriteriosProveedor.Set('CODISOCIO', txtCODISOCIO.GetValue());
        hfCriteriosProveedor.Set('NOMBRES', txtNOMBRES.GetValue());
        hfCriteriosProveedor.Set('APELLIDOS', txtAPELLIDOS.GetValue());
        hfCriteriosProveedor.Set('DUI', txtDUI.GetValue());
        hfCriteriosProveedor.Set('NIT', txtNIT.GetValue());
        hfCriteriosProveedor.Set('NRC', txtNRC.GetValue());
    }
</script>


<dx:ASPxFormLayout ID="ucCriteriosLotesLayout" ClientInstanceName="ucCriteriosLotesLayout" runat="server" EnableTheming="True" Width="600px"  >
    <Items>
        <dx:LayoutGroup ColCount="1" Caption="Criterios de búsqueda"  
            GroupBoxDecoration="HeadingLine" Name="glCriterios">
            <Items>
                <dx:LayoutItem ShowCaption="False" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                            <table width="100%" >
                                <tr>
                                    <td><dx:ASPxLabel ID="aspxLabel1" runat="server" Text="Cod. Provee:" /></td>
                                    <td>
                                        <dx:ASPxSpinEdit ID="txtCODIPROVEE" runat="server" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODIPROVEE" Width="100px"  >
                                            <ClientSideEvents ValueChanged="SetearCamposTexto" /> 
                                        </dx:ASPxSpinEdit>            
                                    </td>
                                    <td><dx:ASPxLabel ID="aspxLabel2" runat="server" Text="Cod. Socio:" /></td>
                                    <td>
                                        <dx:ASPxSpinEdit ID="txtCODISOCIO" runat="server" AllowNull="true" AllowUserInput="true" ClientInstanceName="txtCODISOCIO" Width="130px" >
                                            <ClientSideEvents ValueChanged="SetearCamposTexto" /> 
                                        </dx:ASPxSpinEdit> 
                                    </td>
                                    <td><dx:ASPxLabel ID="aspxLabel3" runat="server" Text="Apellidos:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtAPELLIDOS" ClientInstanceName="txtAPELLIDOS" runat="server" >
                                            <ClientSideEvents ValueChanged="SetearCamposTexto" />
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td><dx:ASPxLabel ID="aspxLabel4" runat="server" Text="Nombres:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtNOMBRES" ClientInstanceName="txtNOMBRES" runat="server">
                                            <ClientSideEvents ValueChanged="SetearCamposTexto" />
                                        </dx:ASPxTextBox>
                                    </td>       
                                </tr>
                                <tr>
                                    <td><dx:ASPxLabel ID="aspxLabel5" runat="server" Text="DUI:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtDUI" runat="server" ClientInstanceName="txtDUI" Width="100px"  >
                                            <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" Mask="99999999-9" />
                                            <ClientSideEvents ValueChanged="SetearCamposTexto" />
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td><dx:ASPxLabel ID="aspxLabel6" runat="server" Text="NIT:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtNIT" ClientInstanceName="txtNIT" runat="server" Width="130px" >
                                            <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" Mask="9999-999999-999-9" ErrorText="NIT no valido"  />
                                            <ClientSideEvents ValueChanged="SetearCamposTexto" />
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td><dx:ASPxLabel ID="aspxLabel7" runat="server" Text="NRC:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtNRC" ClientInstanceName="txtNRC" runat="server" >
                                        <ClientSideEvents ValueChanged="SetearCamposTexto" />
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td><dx:ASPxLabel ID="aspxLabel8" runat="server" Text="Zafra:" /></td>
                                    <td><dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100px" /></td>
                                </tr>
                            </table>
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
            </Items>           
        </dx:LayoutGroup>
    </Items>
    <SettingsItems ShowCaption="True" />
</dx:ASPxFormLayout>
<dx:ASPxHiddenField ID="hfCriteriosProveedor" ClientInstanceName="hfCriteriosProveedor" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>