<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLIC_OIP_TRANS.ascx.vb" Inherits="controles_ucVistaDetalleSOLIC_OIP_TRANS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<style type="text/css">
    .auto-style1 {
        height: 36px;
    }
</style>

<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="ucVistaDetalleSOLIC_OPILayout" ClientInstanceName="ucVistaDetalleOPILayout" runat="server" Width="1080px">
                <Items>
                    <dx:LayoutGroup ColCount="1" Name="lgSolicitudAnticipo" Caption="Información de Ingreso de OIP" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <table>
                                            <tr id="trID" runat="server" visible="false">
                                                <td><dx:ASPxLabel ID="aspxLabel3" runat="server" Text="Id OPI:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtID_OIP_TRANS" runat="server" ClientInstanceName="txtID_OIP_TRANS" Width="120px" BackColor="WhiteSmoke">                               
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel1" runat="server" Text="N° OIP:" /></td>
                                                <td><dx:ASPxTextBox ID="txtNUM_OIP_ZAFRA" runat="server"  HorizontalAlign="Right" Width="120px" BackColor="WhiteSmoke" >
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel2" runat="server" Text="Zafra:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" HorizontalAlign="Right" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px">
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>     
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dx:ASPxLabel ID="aspxLabel4" runat="server" Text="Cod. Proveedor:" />
                                                </td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="txtCODTRANSPORT" runat="server" ClientInstanceName="txtCODTRANSPORT" HorizontalAlign="Right" AutoPostBack="true" Width="120px"  >
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                            <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                                        </ValidationSettings>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                                <td>
                                                    <dx:ASPxLabel ID="aspxLabel5" runat="server" Text="Nombre del Transportista:" />
                                                </td>
                                                <th colspan="3">
                                                    <dx:ASPxTextBox ID="txtNOMBRE_TRANSPORTISTA" runat="server"  Width="300px" BackColor="WhiteSmoke">                               
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dx:ASPxLabel ID="aspxLabel8" runat="server" Text="Fecha de la OIP:" />
                                                </td>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dteFECHA" DisplayFormatString="dd/MM/yyyy" HorizontalAlign="Right" EditFormat="Custom" AllowNull="true"   
                                                        EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px" ClientEnabled="false"  >                                            
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxDateEdit>   
                                                </td>
                                                <td>
                                                    <dx:ASPxLabel ID="aspxLabel7" runat="server" Text="Banco:" />
                                                </td>
                                                <th colspan="3" >
                                                    <dx:ASPxComboBox ID="cbxCODIBANCO" runat="server"  DataSourceID="odsBancos" ValueField="CODIBANCO" TextField="NOMBRE_BANCO" ValueType="System.Int32" Width="100%">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>  
                                                </th>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">
                                                    <dx:ASPxLabel ID="aspxLabel9" runat="server" Text="Monto a descontar:" />
                                                </td>
                                                <td class="auto-style1">
                                                    <dx:ASPxSpinEdit ID="speMONTO" HorizontalAlign="Right" runat="server" DisplayFormatString="#,###0.00"  
                                                        DecimalPlaces="2" Number="0" SpinButtons-ShowIncrementButtons="false" 
                                                        Width="120px" >
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit> 
                                                </td>
                                                <td><dx:ASPxLabel ID="aspxLabel6" runat="server" Text="Cuota a descontar por teórica:" /></td>
                                                <td>
                                                     <dx:ASPxSpinEdit ID="speCUOTA_CORTE" HorizontalAlign="Right" runat="server" DisplayFormatString="#,###0.00"  
                                                        DecimalPlaces="2" Number="0" SpinButtons-ShowIncrementButtons="false" 
                                                        Width="120px" >
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit> 
                                                </td>                                               
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">
                                                    <dx:ASPxLabel ID="aspxLabel11" runat="server" Text="Porcentaje a Descontar:" />                                                    
                                                </td>
                                                <td class="auto-style1">
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <dx:ASPxSpinEdit ID="spePORC_DESCTO" HorizontalAlign="Right" runat="server" DecimalPlaces="2" Number="0" SpinButtons-ShowIncrementButtons="false" Width="120px" >
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxSpinEdit>
                                                            </td>
                                                            <td><dx:ASPxLabel ID="aspxLabel10" runat="server" Text="%" /></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td class="auto-style1">
                                                    <dx:ASPxLabel ID="aspxLabel14" runat="server" Text="Porcentaje a Descontar en Planilla:" />
                                                </td>
                                                <td class="auto-style1">
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <dx:ASPxSpinEdit ID="spePORC_DESCTO_PLA" HorizontalAlign="Right" runat="server" DecimalPlaces="2" Number="0" SpinButtons-ShowIncrementButtons="false" Width="120px" >
                                                                    <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxSpinEdit>
                                                            </td>
                                                            <td><dx:ASPxLabel ID="aspxLabel13" runat="server" Text="%" /></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>                                                                                      
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel12" runat="server" Text="Aceptada:" /></td>
                                                <td>
                                                    <dx:ASPxCheckBox ID="chkAceptada" runat="server">                                                        
                                                    </dx:ASPxCheckBox>
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

<asp:ObjectDataSource ID="odsBancos" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cBANCOS">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_BANCO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>