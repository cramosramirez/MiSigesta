<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleMEMBRE_GREMIAL.ascx.vb" Inherits="controles_ucVistaDetalleMEMBRE_GREMIAL" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="ucVistaDetalleMEMBRE_GREMIALLayout" ClientInstanceName="ucVistaDetalleMEMBRE_GREMIALLayout" runat="server" Width="70%">
                <Items>
                    <dx:LayoutGroup ColCount="3" Name="lgMembresiaGremial" Caption="Información de Ingreso de Membresia ASPROCAÑA/ASPROCARPA" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem Caption="N° Membresia">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <dx:ASPxTextBox ID="txtNUM_MEMBRE_GREMIAL" runat="server" ClientInstanceName="txtNUM_MEMBRE_GREMIAL" Width="170px" BackColor="WhiteSmoke">                               
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>  
                            <dx:LayoutItem Caption="Zafra:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2"  runat="server">
                                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxComboBox>          
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem Caption="Id MEMBRESIA" Visible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer24" runat="server">
                                        <dx:ASPxTextBox ID="txtID_MEMBRE_GREMIAL" runat="server" ClientInstanceName="txtID_MEMBRE_GREMIAL" Width="170px" BackColor="WhiteSmoke">                               
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                            <dx:LayoutItem Caption="Cod. Proveedor:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                        <dx:ASPxSpinEdit ID="txtCODIPROVEE" runat="server" ClientInstanceName="txtCODIPROVEE" AutoPostBack="true" Width="170px"  >
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Nombre del Productor:" ColSpan="2" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer17" runat="server">
                                        <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" ClientInstanceName="txtNOMBRE_PROVEEDOR" Width="280px" BackColor="WhiteSmoke">                               
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                                      
                            <dx:LayoutItem Caption="Fecha" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8"  runat="server">
                                        <dx:ASPxDateEdit ID="dteFECHA" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                            EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px" ClientEnabled="false"  >                                            
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxDateEdit>                                        
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                            
                            <dx:LayoutItem Caption="Gremial:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5"   runat="server">
                                        <dx:ASPxComboBox ID="cbxTIPO_FINANCIAMIENTO" runat="server" ValueField="ID_CUENTA_FINAN" Font-Bold="true"   
                                            TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinan"  
                                            AutoPostBack="True">
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
                                                    <RequiredField ErrorText="Seleccione la Gremial" IsRequired="True" />
                                        </ValidationSettings>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>      
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                                                    
                            <dx:LayoutItem Caption="Monto por Tonelada"> 
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                        <dx:ASPxSpinEdit ID="speMONTO_X_TC" HorizontalAlign="Right" runat="server" DisplayFormatString="#,##0.00"  
                                            DecimalPlaces="2" Number="0" SpinButtons-ShowIncrementButtons="false" 
                                            Width="170px" >
                                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxSpinEdit> 
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

<asp:ObjectDataSource ID="odsCuentaFinan" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaParaGremial" 
    TypeName="SISPACAL.BL.cCUENTA_FINAN">     
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

