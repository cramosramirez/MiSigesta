<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLIC_OPI.ascx.vb" Inherits="controles_ucVistaDetalleSOLIC_OPI" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTRATO" Src="~/controlesContrato/ucListaCONTRATO.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaSOLIC_OIP_LOTE" Src="~/controlesFinanciero/ucListaSOLIC_OIP_LOTE.ascx" %>

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
                    <dx:LayoutGroup ColCount="1" Name="lgSolicitudAnticipo" Caption="Información de Ingreso de OPI" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <table>
                                            <tr id="trID" runat="server" visible="false">
                                                <td><dx:ASPxLabel ID="aspxLabel3" runat="server" Text="Id OPI:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtID_OPI" runat="server" ClientInstanceName="txtID_OPI" Width="120px" BackColor="WhiteSmoke">                               
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxLabel1" runat="server" Text="N° OIP:" /></td>
                                                <td><dx:ASPxTextBox ID="txtNUM_OPI_ZAFRA" runat="server" ClientInstanceName="txtNUM_OPI" HorizontalAlign="Right" Width="120px" BackColor="WhiteSmoke" >
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
                                                    <dx:ASPxSpinEdit ID="txtCODIPROVEE" runat="server" ClientInstanceName="txtCODIPROVEE" HorizontalAlign="Right" AutoPostBack="true" Width="120px"  >
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                            <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                                        </ValidationSettings>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                                <td>
                                                    <dx:ASPxLabel ID="aspxLabel5" runat="server" Text="Nombre del Productor:" />
                                                </td>
                                                <th colspan="3">
                                                    <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" ClientInstanceName="txtNOMBRE_PROVEEDOR" Width="100%" BackColor="WhiteSmoke">                               
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dx:ASPxLabel ID="aspxLabel8" runat="server" Text="Fecha de la OIP:" />
                                                </td>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dteFECHA_SOLIC" DisplayFormatString="dd/MM/yyyy" HorizontalAlign="Right" EditFormat="Custom" AllowNull="true"   
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
                                                    <dx:ASPxLabel ID="aspxLabel9" runat="server" Text="Monto otorgado:" />
                                                </td>
                                                <td class="auto-style1">
                                                    <dx:ASPxSpinEdit ID="speMONTO" HorizontalAlign="Right" runat="server" DisplayFormatString="#,###0.00"  
                                                        DecimalPlaces="2" Number="0" SpinButtons-ShowIncrementButtons="false" 
                                                        Width="120px" >
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit> 
                                                </td>
                                                <td class="auto-style1">
                                                    <dx:ASPxLabel ID="aspxLabel16" runat="server" Text="Monto de Interes:" />                                                    
                                                </td>
                                                <td class="auto-style1">
                                                    <dx:ASPxSpinEdit ID="speINTERES" HorizontalAlign="Right" runat="server" DisplayFormatString="#,###0.00"  
                                                        DecimalPlaces="2" Number="0" SpinButtons-ShowIncrementButtons="false" 
                                                        Width="120px" >
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>                                                 
                                                </td>
                                                <td class="auto-style1">
                                                    <dx:ASPxLabel ID="aspxLabel18" runat="server" Text="Monto de Iva-Interes:" />                                                    
                                                </td>
                                                <td class="auto-style1">
                                                    <dx:ASPxSpinEdit ID="speIVA_INTERES" HorizontalAlign="Right" runat="server" DisplayFormatString="#,###0.00"  
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
                                                                <dx:ASPxSpinEdit ID="spePORC_DESCTO" HorizontalAlign="Right" runat="server" DecimalPlaces="2" Number="0" SpinButtons-ShowIncrementButtons="false" Width="80px" >
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
                                                                <dx:ASPxSpinEdit ID="spePORC_DESCTO_PLA" HorizontalAlign="Right" runat="server" DecimalPlaces="2" Number="0" SpinButtons-ShowIncrementButtons="false" Width="80px" >
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
                                                <td><dx:ASPxLabel ID="aspxLabel15" runat="server" Text="Núm. orden OIP:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="speNUM_OPI_PROVEE_ZAFRA" HorizontalAlign="Right" runat="server" DecimalPlaces="0" SpinButtons-ShowIncrementButtons="false" Width="120px" >
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                                <td><dx:ASPxLabel ID="aspxLabel12" runat="server" Text="Aceptada:" /></td>
                                                <td>
                                                    <dx:ASPxCheckBox ID="chkAceptada" runat="server">                                                        
                                                    </dx:ASPxCheckBox>
                                                </td>
                                                <td class="auto-style1">
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <dx:ASPxLabel ID="aspxLabel22" runat="server" Text="Estado:" />
                                                            </td>
                                                            <td>
                                                                <dx:ASPxComboBox ID="cbxESTADO" ClientInstanceName="cbxESTADO" DataSourceID="odsSolicEstado" ValueField="ID_SOLIC_ESTADO" TextField="NOMBRE_ESTADO" runat="server" ValueType="System.Int32" Width="120px">                                                                           
                                                                    <DisabledStyle Font-Bold="True" BackColor="WhiteSmoke" ForeColor="Blue"></DisabledStyle>
                                                                </dx:ASPxComboBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                             <tr id="trTituloContrato" runat="server" visible="false">
                                                <th colspan="6" style="text-align:left"  >
                                                    <dx:ASPxLabel ID="aspxLabel6" runat="server" Text="Contratos a los que aplica la OIP" Font-Bold="true" />
                                                </th>                                                                                                
                                            </tr>
                                            <tr id="trlistaContrato" runat="server" visible="false">
                                                <th colspan="6" style="text-align:left">
                                                    <uc1:ucListaCONTRATO id="ucListaCONTRATO1" PermitirEliminar="false" PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" PermitirEditar="false" PermitirRowHotTrack="false" PermitirFocoEnFilas="false" MostrarCheckVariaSeleccion="true" VerCODISOCIO="false" PermitirVistaPrevia="true" runat="server"></uc1:ucListaCONTRATO>
                                                </th>
                                            </tr>
                                            <tr>
                                                <th colspan="6">
                                                    <hr>
                                                </th> 
                                            </tr>
                                            <tr id="trLOTES_1" runat="server">
                                                <th colspan="6" style="text-align:left"  >
                                                    <dx:ASPxLabel ID="aspxLabel26" runat="server" Text="LOTES A LOS QUE APLICA LA OIP" Font-Bold="true" />
                                                </th>                                                                                                                                              
                                            </tr>
                                             <tr>
                                                <th colspan="6">
                                                    <dx:ASPxCheckBox ID="chkSelectTodosLotes" AutoPostBack="true" runat="server" Text="Marque para seleccionar todos los Lotes"  TextAlign="Right" ></dx:ASPxCheckBox>                                
                                                </th>
                                            </tr>
                                            <tr>                            
                                                 <th colspan="6">
                                                    <uc1:ucListaSOLIC_OIP_LOTE id="ucListaSOLIC_OIP_LOTE1" NombreGridCliente="ucListaSOLIC_OIP_LOTE1" PermitirEditar="false" PermitirEditarInline="false"  PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" TipoEdicion="0" TamanoPagina="10" PermitirEliminar="false" runat="server"></uc1:ucListaSOLIC_OIP_LOTE>
                                                </th>
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


<dx:ASPxLabel ID="lblREFERENCIA_LOTES" runat="server" Visible="false" />  
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSolicEstado" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_ESTADO">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ESTADO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
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