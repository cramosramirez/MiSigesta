<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosSolicitudesProductoConsignacion.ascx.vb" Inherits="controlesBodega_ucCriteriosSolicitudesProductoConsignacion" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBusquedaProveedor" Src="~/controlesContrato/ucBusquedaProveedor.ascx" %>

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
        <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="N° Solic. Retiro:" /></td>
        <td>
            <dx:ASPxSpinEdit ID="speNO_DOCUMENTO" runat="server" Width="120px" AllowNull="true" AllowUserInput="true" >      
                <SpinButtons ShowIncrementButtons="false" />                                  
            </dx:ASPxSpinEdit>  
        </td>
    </tr>
    <tr id="trPERIODO" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Periodo:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxPERIODO" AutoPostBack="true" runat="server" ValueType="System.Int32" Width="300px" DropDownStyle="DropDownList">                                                               
                <Items>
                    <dx:ListEditItem Text="A LA FECHA" Value="1" Selected="true" />  
                    <dx:ListEditItem Text="DEFINIR PERIODO" Value="2" />                      
                </Items>
            </dx:ASPxComboBox> 
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="De:" /></td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_INICIAL" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy" runat="server" Width="120px" ClientEnabled="false" >
            </dx:ASPxDateEdit>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="Hasta:" /></td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_FINAL" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy" runat="server" Width="120px"  ClientEnabled="false" >
            </dx:ASPxDateEdit>
        </td>
    </tr>    
     <tr id="trPROVEEDOR" runat="server">
        <td>
            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Cód. Proveedor:" />                
        </td>
        <td>
            <table>
                <tr>
                    <td><dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true" AllowUserInput="true" Width="118px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
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
        <th colspan="3">
            <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="100%"  />                            
        </th>              
    </tr>    
    <tr id="trPROVEEDOR_AGRICOLA" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Proveedor Agrícola:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxPROVEEDOR_AGRICOLA" runat="server" ValueType="System.Int32" DataSourceID="odsProveedorAgricola" ValueField="ID_PROVEE" TextField="NOMBRE" Width="300px" >                                                    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>        
    <tr id="trCUENTA_FINANCIAMIENTO" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Financiamiento:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxCUENTA_FINANCIAMIENTO" runat="server" ValueField="ID_CUENTA_FINAN" TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinan">  
            </dx:ASPxComboBox>
        </td>
    </tr>   
    <tr id="trESTADO" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Estado:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxESTADO" runat="server" ValueType="System.Int32" Width="100%">  
                <Items>
                    <dx:ListEditItem Text="" Value="-1" /> 
                    <dx:ListEditItem Text="PENDIENTE" Value="1" /> 
                    <dx:ListEditItem Text="FINALIZADO" Value="4" />
                </Items>
            </dx:ASPxComboBox>
        </td>
    </tr>   
</table>


 <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProveedorAgricola" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorCriterios" 
    TypeName="SISPACAL.BL.cPROVEEDOR_AGRICOLA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="-1" Name="ES_PROVEE_VUELO" Type="Int32" />
        <asp:Parameter DefaultValue="1" Name="ES_CASA_COMER" Type="Int32" />
        <asp:Parameter DefaultValue="-1" Name="ID_CUENTA_FINAN" Type="Int32"  />
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
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

