<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosServiciosEsp.ascx.vb" Inherits="controlesFinanciero_ucCriteriosServiciosEsp" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBusquedaProveedor" Src="~/controlesContrato/ucBusquedaProveedor.ascx" %>

<table border="0" >
    <tr id="trZAFRA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="ZAFRA">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" 
            ValueField="ID_ZAFRA" AutoPostBack="true" TextField="NOMBRE_ZAFRA" Theme="Office2010Blue" Width="118px" >               
            </dx:ASPxComboBox>
        </td>   
        <td></td>     
    </tr>
     <tr id="trCATORCENA_ZAFRA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="CATORCENA:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxCATORCENA_ZAFRA" runat="server" ValueType="System.Int32"  
            ValueField="ID_CATORCENA" TextField="CATORCENA" Theme="Office2010Blue" Width="118px" DropDownStyle="DropDown" >               
            </dx:ASPxComboBox>
        </td>  
         <td>
             <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="(Digite el No. de corte si no aparece en la lista)">
             </dx:ASPxLabel>
         </td>      
    </tr>
     <tr id="trCODIPROVEE" runat="server" visible="false">     
            <td>
                <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Cód. Proveedor:" />                
            </td>
            <td>
                <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true" AllowUserInput="true" Width="170px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
                </dx:ASPxSpinEdit>   
            </td>
            <td>
                <dx:ASPxButton ID="btnBuscar" AutoPostBack="true" ToolTip="Buscar proveedor"  runat="server" Width="20px"   Text="">
                <Image IconID="find_find_16x16">
                </Image>
            </dx:ASPxButton>
            </td>
            <td style="padding-left:15px">
                <dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Nombre Proveedor:" />                
            </td>
            <td>
                <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px"  />                            
            </td>                       
        </tr>
     <tr id="trFECHA_HORA_CIERRE" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="FECHA/HORA CIERRE:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_HORA_CIERRE" DisplayFormatString="dd/MM/yyyy HH:mm" EditFormat="Custom" AllowNull="true" runat="server">                
            </dx:ASPxDateEdit>
        </td>  
         <td>
             <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="(Opcional)">
             </dx:ASPxLabel>
         </td>      
    </tr>
     <tr id="trSERVICIO_ESPECIAL" runat="server" visible="false" >        
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="TIPO DE SERVICIO:"/></td>
        <td><dx:ASPxComboBox ID="cbxSERVICIO_ESPECIAL" runat="server" Width="170px" >
            <Items>
                <dx:ListEditItem Text="QUERQUEO" Value="1"  />
                <dx:ListEditItem Text="BARRIDA" Value="2"  />
                <dx:ListEditItem Text="PLOMEO" Value="3"  />
            </Items>
            </dx:ASPxComboBox>   </td>   
        <td></td>            
    </tr>
    <tr id="trCONTRIBUYENTE" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="TIPO DE CONTRIBUYENTE:"/></td>
        <td><dx:ASPxComboBox ID="CBXcontribuyente" runat="server" Width="170px" >
            <Items>
                <dx:ListEditItem Text="NO CONTRIBUYENTE" Value="false"  />
                <dx:ListEditItem Text="CONTRIBUYENTE" Value="true"  />                
            </Items>
            </dx:ASPxComboBox></td>   
        <td></td>   
    </tr>
</table>

 <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
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