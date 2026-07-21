<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosLotes.ascx.vb" Inherits="controlesMaestro_ucCriteriosLotes" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<dx:ASPxFormLayout ID="ucCriteriosLotesLayout" ClientInstanceName="ucCriteriosLotesLayout" runat="server" EnableTheming="True" Width="400px" >
    <Items>
        <dx:LayoutGroup ColCount="1" Caption="Criterios de búsqueda"  
            GroupBoxDecoration="HeadingLine" SettingsItemCaptions-Location="Left" Name="glCriterios">
            <Items>                            
                <dx:LayoutItem ShowCaption="False" >
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer runat="server">
                                <table width="100%" >
                                    <tr>
                                        <td><dx:ASPxLabel ID="aspxLabel10" runat="server" Text="Zafra contratada:" /></td>
                                        <td><dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100%" /></td>
                                        <td><dx:ASPxLabel ID="aspxLabel1" runat="server" Text="Zona:" /></td>
                                        <td>
                                            <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" AutoPostBack="true" runat="server" DataSourceID="odsZona" TextField="DESCRIP_ZONA" ValueField="ZONA"  >                            
                                            </dx:ASPxComboBox>  
                                        </td>
                                        <td><dx:ASPxLabel ID="aspxLabel2" runat="server" Text="Sub-Zona:" /></td>
                                        <td>
                                            <dx:ASPxComboBox ID="cbxSUB_ZONA" ClientInstanceName="cbxSUB_ZONA" TextField="DESCRIP_SUB_ZONA" Width="100%"  ValueField="SUB_ZONA" runat="server" DataSourceID="odsSubZona">                                                            
                                            </dx:ASPxComboBox>  
                                        </td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxLabel ID="aspxLabel3" runat="server" Text="Departamento:" /></td>
                                        <td>
                                            <dx:ASPxComboBox ID="cbxDEPARTAMENTO" ClientInstanceName="cbxDEPARTAMENTO" runat="server" AutoPostBack="true" DataSourceID="odsDepartamento" TextField="NOMBRE_DEPTO" ValueField="CODI_DEPTO"  >                          
                                            </dx:ASPxComboBox> 
                                        </td>
                                        <td><dx:ASPxLabel ID="aspxLabel4" runat="server" Text="Municipio:" /></td>
                                        <td>
                                            <dx:ASPxComboBox ID="cbxMUNICIPIO"  AutoPostBack="true" ClientInstanceName="cbxMUNICIPIO" TextField="NOMBRE_MUNI" ValueField="CODI_MUNI" runat="server" DataSourceID="odsMunicipio">                            
                                            </dx:ASPxComboBox> 
                                        </td>
                                        <td><dx:ASPxLabel ID="aspxLabel5" runat="server" Text="Canton:" /></td>
                                        <td>
                                            <dx:ASPxComboBox ID="cbxCANTON" ShowLoadingPanel="true" LoadingPanelText="Cargando..." ClientInstanceName="cbxCANTON" TextField="NOMBRE_CANTON" ValueField="CODI_CANTON" Width="100%" runat="server" DataSourceID="odsCanton">                                
                                            </dx:ASPxComboBox> 
                                        </td>       
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxLabel ID="aspxLabel6" runat="server" Text="Cod. Provee:" /></td>
                                        <td><dx:ASPxTextBox ID="txtCODIPROVEE" runat="server" ClientInstanceName="txtCODIPROVEE" >                                
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td><dx:ASPxLabel ID="aspxLabel7" runat="server" Text="Cod. Socio:" Width="80px" /></td>
                                        <td>
                                             <dx:ASPxTextBox ID="txtCODISOCIO" runat="server" ClientInstanceName="txtCODISOCIO" >                                
                                             </dx:ASPxTextBox>
                                        </td>
                                        <td><dx:ASPxLabel ID="aspxLabel8" runat="server" Width="120px"  Text="Nombre proveedor:" /></td>
                                        <td>
                                            <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="200px">
                                            </dx:ASPxTextBox>
                                        </td>
                                    </tr>
                                    <tr id="trContrato" runat="server" visible="false" >
                                        <td><dx:ASPxLabel ID="aspxLabel9" runat="server" Text="Contrato:" /></td>
                                        <td>
                                            <dx:ASPxSpinEdit ID="spnCONTRATO" runat="server" AllowNull="true" AllowUserInput="true" ClientInstanceName="spnCONTRATO" >                                
                                            </dx:ASPxSpinEdit>
                                        </td>
                                    </tr>
                                </table>                    
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>                
            </Items>
            <SettingsItemCaptions HorizontalAlign="Left" Location="Left" 
                VerticalAlign="Middle" />
            <SettingsItems HorizontalAlign="Left" VerticalAlign="Middle" />
        </dx:LayoutGroup>
    </Items>
    <SettingsItems ShowCaption="True" />
</dx:ASPxFormLayout>
<dx:ASPxHiddenField ID="hfCriteriosLotes" ClientInstanceName="hfCriteriosLotes" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>

<asp:ObjectDataSource ID="odsZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsDepartamento" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cDEPARTAMENTO">
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsSubZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cSUB_ZONAS">
    <SelectParameters>        
        <asp:Parameter DefaultValue="" Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsMunicipio" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cMUNICIPIO">
    <SelectParameters>      
        <asp:Parameter DefaultValue="" Name="CODI_DEPTO" Type="String" />
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCanton" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cCANTON">
    <SelectParameters>       
        <asp:Parameter Name="CODI_DEPTO" Type="String" DefaultValue="" />
        <asp:Parameter Name="CODI_MUNI" Type="String" DefaultValue="" />
        <asp:Parameter Name="agregarVacio" Type="Boolean" DefaultValue="True" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="conPresencia" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaTodas" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="[TODAS]" Name="elementoTodas" Type="String" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>