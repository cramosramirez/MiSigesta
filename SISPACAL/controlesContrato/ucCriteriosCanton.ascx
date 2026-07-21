<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosCanton.ascx.vb" Inherits="controlesContrato_ucCriteriosCanton" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<dx:ASPxFormLayout ID="ucCriteriosCantonLayout" ClientInstanceName="ucCriteriosCantonLayout" runat="server" EnableTheming="True" Width="200px" >
    <Items>
        <dx:LayoutGroup ColCount="3" Caption="Criterios de búsqueda"  
            GroupBoxDecoration="HeadingLine" SettingsItemCaptions-Location="Left" Name="glCriterios">
            <Items>               
                <dx:LayoutItem Caption="Departamento:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                            <dx:ASPxComboBox ID="cbxDEPARTAMENTO" ClientInstanceName="cbxDEPARTAMENTO" runat="server" AutoPostBack="true" DataSourceID="odsDepartamento" TextField="NOMBRE_DEPTO" ValueField="CODI_DEPTO"  >                          
                            </dx:ASPxComboBox>                            
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Municipio:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                            <dx:ASPxComboBox ID="cbxMUNICIPIO"  AutoPostBack="true" ClientInstanceName="cbxMUNICIPIO" TextField="NOMBRE_MUNI" ValueField="CODI_MUNI" runat="server" DataSourceID="odsMunicipio">                            
                            </dx:ASPxComboBox>                            
                        </dx:LayoutItemNestedControlContainer>
                    </LayoutItemNestedControlCollection>
                </dx:LayoutItem>
                <dx:LayoutItem Caption="Cantón:">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                            <dx:ASPxComboBox ID="cbxCANTON" ShowLoadingPanel="true" LoadingPanelText="Cargando..." ClientInstanceName="cbxCANTON" TextField="NOMBRE_CANTON" ValueField="CODI_CANTON"  runat="server" DataSourceID="odsCanton">                                
                            </dx:ASPxComboBox>                            
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
<asp:ObjectDataSource ID="odsDepartamento" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cDEPARTAMENTO">
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="conPresencia" Type="Boolean" />
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