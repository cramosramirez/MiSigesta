<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucTarifaRoza.ascx.vb" Inherits="controles_ucTarifaRoza" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaLOTES_COSECHA" Src="~/controlesProforma/ucListaLOTES_COSECHA.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<table cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
    <tr>
       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Aplicación de de Roza</asp:Label></td>		
    </tr>
</table>
<table>
    <tr>
        <td>
            <center>
            <dx:ASPxFormLayout ID="ucCriteriosTarifaRoza" Width="900px"  runat="server" SettingsItemCaptions-Location="Left" Name="glCriterios">
                       <Items>
                           <dx:LayoutGroup Caption="Criterios de búsqueda" ColCount="1" GroupBoxDecoration="HeadingLine">
                               <Items>
                                   <dx:LayoutItem ShowCaption="False">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <table>
                                                   <tr>
                                                       <td><dx:ASPxLabel ID="aspxlabel1" runat="server" Text="Zafra:"/></td>
                                                       <th colspan="2" >
                                                           <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px" >
                                                               <DisabledStyle ForeColor="Black" BackColor="WhiteSmoke" />   
                                                           </dx:ASPxComboBox>
                                                       </th>
                                                       <td><dx:ASPxLabel ID="aspxlabel2" runat="server" Text="Zona:"/></td>
                                                       <td>
                                                           <dx:ASPxComboBox ID="cbxZONA"  runat="server" DataSourceID="odsZona" TextField="DESCRIP_ZONA" ValueField="ZONA" Width="120px" >                            
                                                           </dx:ASPxComboBox> 
                                                       </td>
                                                   </tr>
                                                   <tr>
                                                       <td><dx:ASPxLabel ID="aspxlabel3" runat="server" Text="Código Productor/Socio:"/></td>
                                                       <th colspan="2" >
                                                           <table>
                                                               <tr>
                                                                   <td>
                                                                       <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" HorizontalAlign="Right" AllowNull="true" SpinButtons-ShowIncrementButtons="false" Width="60px">
                                                                        </dx:ASPxSpinEdit>
                                                                   </td>
                                                                   <td>
                                                                       <dx:ASPxSpinEdit ID="speCODISOCIO" runat="server"  HorizontalAlign="Right" AllowNull="true" SpinButtons-ShowIncrementButtons="false" Width="60px">
                                                                        </dx:ASPxSpinEdit>
                                                                   </td>
                                                               </tr>
                                                           </table>                                                           
                                                       </th>                                                    
                                                       <td><dx:ASPxLabel ID="aspxlabel4" runat="server" Text="Nombre Productor/Socio:"/></td>
                                                       <td>
                                                           <dx:ASPxTextBox ID="txtNOMBRE_PRODUCTOR" runat="server" Width="300px">
                                                            </dx:ASPxTextBox>
                                                       </td>
                                                   </tr>
                                                   <tr>
                                                       <th colspan="5"><HR /></th>
                                                   </tr>
                                                   <tr>
                                                       <th colspan="5" style="text-align:center" ><dx:ASPxLabel ID="aspxlabel6" runat="server" Text="INGRESE LA TARIFA DE ROZA A APLICAR" Font-Bold="true"/></th>
                                                   </tr>
                                                   <tr>
                                                       <td><dx:ASPxLabel ID="aspxlabel5" runat="server" Text="Tarifa (US$):" Font-Bold="true"/></td>
                                                       <td>
                                                           <dx:ASPxSpinEdit ID="speTARIFA_ROZA" runat="server" Font-Bold="true" HorizontalAlign="Right" AllowNull="true" NumberType="Float" SpinButtons-ShowIncrementButtons="false" Width="80px">
                                                           </dx:ASPxSpinEdit>
                                                       </td>
                                                       <th colspan="3"><dx:ASPxCheckBox ID="chkTodosLotes" AutoPostBack="true" TextAlign="Left" Font-Bold="true" Text="Seleccionar todos los lotes" runat="server"></dx:ASPxCheckBox></th>
                                                       <td></td>
                                                   </tr>
                                               </table>
                                           </dx:LayoutItemNestedControlContainer>   
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>                                  
                               </Items>
                           </dx:LayoutGroup>
                       </Items>
                        <SettingsItemCaptions Location="Left"></SettingsItemCaptions>
            </dx:ASPxFormLayout>
            </center>
        </td>
    </tr>
    <tr>
        <td>
            <uc1:ucListaLOTES_COSECHA id="ucListaLOTES_COSECHA1" MostrarCheckVariaSeleccion="true" PermitirEditar="false" PermitirEditarInline="false"  NombreGridCliente="ucListaLOTES_COSECHA1" PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" TamanoPagina="10" PermitirEliminar="false" runat="server"
               VerFECHA_ROZA="false" MostrarUnaPagina="true" VerREND_COSECHA="false" VerTARIFA_ROZA="true" VerTONEL_ENTREGADA="false" VerSALDO_ROZA="false" VerSALDO_QUEMA="false" VerFIN_LOTE="false" VerULTIMO_MADURANTE="false" VerULTIMA_FECHA_MADURANTE="false"  ></uc1:ucListaLOTES_COSECHA>
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
<asp:ObjectDataSource ID="odsZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>