<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePROYFIN_ING.ascx.vb" Inherits="controles_ucVistaDetallePROYFIN_ING" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPROYFIN_ING_LOTE" Src="~/controlesProyFinan/ucListaPROYFIN_ING_LOTE.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucBusquedaProveedor" Src="~/controlesContrato/ucBusquedaProveedor.ascx" %>

<table id="trCriterios" runat="server" width="100%" border="0">   
   <tr>
     <td>
         <dx:ASPxLabel ID="ASPxLabel4" ForeColor="Blue" runat="server" Text="(Seleccione la zafra, luego ingrese el código de proveedor, a continuación se mostrarán los lotes contratados de la zafra inicial. Cargue la producción marcando los lotes deseados y selecione la opción 'Mostrar producción de lotes seleccionados')" />  
      <table>
        <tr>
            <th colspan="5">
                  
             </th>
        </tr>
        <tr>
             
            <td>
                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Zafra inicial de proyección:" />                
            </td>
            <td>
                <dx:ASPxComboBox ID="cbxZAFRA" runat="server" AutoPostBack="true" HorizontalAlign="Right" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="150px" />                                        
            </td>
           <td></td>  
           <td></td>     
           <td></td>     
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Cód. Proveedor:" />                
            </td>
            <td>
                <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AutoPostBack="true" AllowNull="true" AllowUserInput="true" Width="150px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
                </dx:ASPxSpinEdit>   
            </td>
            <td>
                <dx:ASPxButton ID="btnBuscar" AutoPostBack="true" ToolTip="Buscar proveedor"  runat="server" Width="20px"   Text="">
                <Image IconID="find_find_16x16">
                </Image>
            </dx:ASPxButton>
            </td>
            <td style="padding-left:15px">
                <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Nombre Proveedor:" />                
            </td>
            <td>
                <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px" ClientEnabled="false" >                            
                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />  
                </dx:ASPxTextBox>
            </td>                       
        </tr>
      </table>
      </td>
   </tr>
    <tr>
        <td>
       <uc1:ucListaPROYFIN_ING_LOTE id="ucListaPROYFIN_ING_LOTE1" TamanoPagina="20"  PermitirEliminar="false" PermitirEditar="false"  PermitirEditarInline2="true" PermitirRowHotTrack="true" PermitirFocoEnFilas="true" MostrarCheckVariaSeleccion="true"  runat="server"></uc1:ucListaPROYFIN_ING_LOTE>
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