<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosComparativo.ascx.vb" Inherits="controlesCenso_ucCriteriosComparativo" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBusquedaProveedor" Src="~/controlesContrato/ucBusquedaProveedor.ascx" %>

<table border="0" >
    <tr id="trID_ZAFRA" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Zafra Inicial:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxZAFRA1" runat="server" ValueType="System.Int32" DataSourceID="odsZafras1" ClientInstanceName="cbxZAFRA" 
            ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" Theme="Office2010Blue" Width="118px" >               
            </dx:ASPxComboBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Zafra Final:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxZAFRA2" runat="server" ValueType="System.Int32" DataSourceID="odsZafras2" ClientInstanceName="cbxZAFRA" 
            ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" Theme="Office2010Blue" Width="118px" >               
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trRENDIMIENTO" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Rendimiento:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxSpinEdit ID="speRENDIMIENTO" runat="server" AllowNull="true" NumberType="Float" AllowUserInput="true" Width="118px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
            </dx:ASPxSpinEdit>   
        </td>
    </tr>
    <tr id="trVIP" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="VIP:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxSpinEdit ID="speVIP" runat="server" AllowNull="true" NumberType="Float" AllowUserInput="true" Width="118px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
            </dx:ASPxSpinEdit>   
        </td>
    </tr>
    <tr>
            <td>
                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Cód. Proveedor:" />                
            </td>
            <td>
                <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true" AllowUserInput="true" Width="118px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
                </dx:ASPxSpinEdit>   
                <dx:ASPxLabel ID="lblCodiSocio" runat="server" ClientVisible="false" /> 
            </td>
            <td>
                <dx:ASPxButton ID="btnBuscar" AutoPostBack="true" ToolTip="Buscar proveedor"  runat="server" Width="20px"   Text="">
                <Image IconID="find_find_16x16">
                </Image>
            </dx:ASPxButton>
            </td>
            <td style="padding-left:15px">
                <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Nombre Proveedor:" />                
            </td>
            <td>
                <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px"  />                            
            </td>                       
        </tr>
    <tr id="trTIPO_REPORTE" runat="server">
        <td>
            <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Tipo de reporte:" />                
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxTIPO_REPORTE" runat="server" ValueType="System.Int32" ValueField="ID_ZAFRA" Theme="Office2010Blue" Width="118px" >     
                <Items>
                    <dx:ListEditItem Text="GENERAL" Value="1"  />
                    <dx:ListEditItem Text="POR PRODUCTOR" Value="2"  />                    
                    <dx:ListEditItem Text="POR LOTE" Value="3"  />
                </Items>          
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trZONA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Zona:">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" AutoPostBack="true" runat="server" ValueType="System.String" DataSourceID="odsZonas"
                ValueField="ZONA" TextField="DESCRIP_ZONA" Theme="Office2010Blue" Width="118px" >
             </dx:ASPxComboBox>
        </td>      
    </tr>    
</table>

 <asp:ObjectDataSource ID="odsZafras1" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>
 <asp:ObjectDataSource ID="odsZafras2" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>
 <asp:ObjectDataSource ID="odsZonas" runat="server" TypeName="SISPACAL.BL.cZONAS" SelectMethod="ObtenerLista" OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>
     <asp:Parameter Name="recuperarHijas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="asColumnaOrden" DefaultValue="DESCRIP_ZONA" Type="String" />
     <asp:Parameter Name="asTipoOrden" DefaultValue="ASC" Type="String" />
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