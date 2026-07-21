<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSOLIC_APLICA_LOTE.ascx.vb" Inherits="controlesMadurante_ucMantSOLIC_APLICA_LOTE" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSOLIC_APLICA_LOTE" Src="~/controlesMadurante/ucListaSOLIC_APLICA_LOTE.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBusquedaProveedor" Src="~/controlesContrato/ucBusquedaProveedor.ascx" %>


<table id="Table1" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
    <tr>
        <td align="center" class="EncabezadoSecciones"><asp:Label id="Label1" style="Z-INDEX: 101" runat="server">Aplicaciones de Productos Agrícolas</asp:Label></td>
    </tr>
    <tr>
        <td align="center">
           <dx:ASPxFormLayout ID="ucVistaDetalleSOLIC_APLICA_LOTELayout" ClientInstanceName="ucVistaDetalleSOLIC_APLICA_LOTELayout" runat="server" Width="800px">
                <Items>
                    <dx:LayoutGroup ColCount="3" Name="lgSolicitudAgricolaA" Caption="Criterios de búsqueda" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7"  runat="server">
                                        <table border="0" >
                                             <tr id="trZAFRA" runat="server">
                                                <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Zafra:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" 
                                                    ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA"  Width="118px" >               
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                            <tr id="trNUMS_SOLICITUDES" runat="server">
                                                <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="N° Solic. Agrícola:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="speNUM_SOLICITUD" runat="server" AllowNull="true" Width="118px" AllowUserInput="true" >      
                                                        <SpinButtons ShowIncrementButtons="false" />                                     
                                                    </dx:ASPxSpinEdit>   
                                                </td>
                                                <td><dx:ASPxLabel ID="aspxLabel5" runat="server" Text="Zona:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" runat="server" DataSourceID="odsZona" TextField="DESCRIP_ZONA" ValueField="ZONA" Width="118px"  >                            
                                                    </dx:ASPxComboBox>  
                                                </td>
                                            </tr>       
                                            <tr>
                                                <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Financiamiento:" /></td>
                                                <th colspan="3" >
                                                    <dx:ASPxComboBox ID="cbxCUENTA_FINANCIAMIENTO" runat="server" ValueField="ID_CUENTA_FINAN" TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinan">  
                                                    </dx:ASPxComboBox>
                                                </th>
                                            </tr>                                    
                                             <tr id="trPROVEEDOR" runat="server">
                                                <td>
                                                    <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Cód. Proveedor:" />                
                                                </td>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td><dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true" AllowUserInput="true" Width="118px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
                                                                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                </dx:ASPxSpinEdit>
                                                            </td>
                                                            <td>
                                                                <dx:ASPxButton ID="btnBuscar" AutoPostBack="true" ToolTip="Buscar proveedor"  runat="server" Width="20px"   Text="">
                                                                <Image IconID="find_find_16x16">
                                                                </Image>
                                                                </dx:ASPxButton>
                                                            </td>
                                                        </tr>
                                                    </table>                
                                                </td>   
                                                <td>
                                                    <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Nombre:" />                
                                                </td>
                                                <th>
                                                    <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px"  />                            
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
    <tr>
        <td align="center">
        <dx:ASPxFormLayout ID="ASPxFormLayout1" ClientInstanceName="ucVistaDetalleSOLIC_APLICA_LOTELayout" runat="server" Width="800px">
                <Items>
                    <dx:LayoutGroup ColCount="3" Name="lgSolicitudAgricolaA" Caption="Cambio de Fecha de aplicación" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1"  runat="server">
                                        <table>
                                            <tr>
                                                <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Aplicar esta fecha a los lotes marcados:" /></td>
                                                <td><dx:ASPxDateEdit ID="dteFECHA_APLICACION" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy" runat="server" Width="120px" ></dx:ASPxDateEdit></td>
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
    <tr>
        <td style="margin-left: 120px"><uc1:ucListaSOLIC_APLICA_LOTE id="ucListaSOLIC_APLICA_LOTE1" PermitirEditarInline="true"
                             PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" MostrarCheckVariaSeleccion="true" MostrarCheckTodos="true"  
                             PermitirEliminar="false"  
                             runat="server"></uc1:ucListaSOLIC_APLICA_LOTE>
        </td>
    </tr>
</table>


 <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsCuentaFinan" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorCriterios" 
    TypeName="SISPACAL.BL.cCUENTA_FINAN">  
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="AgregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="APLICA_SOLIC_AGRICOLA" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>

<dx:ASPxPopupControl ID="pcBusquedaProveedor" runat="server" CloseAction="CloseButton" Modal="True" Width="300px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcBusquedaProveedor"
        HeaderText="Búsqueda por nombre de Proveedor" AllowDragging="True" PopupAnimationType="None">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">  
                            <uc1:ucBusquedaProveedor id="ucBusquedaProveedor1" runat="server" />
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl>
