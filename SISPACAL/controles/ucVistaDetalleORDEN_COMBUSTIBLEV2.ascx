<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleORDEN_COMBUSTIBLEV2.ascx.vb" Inherits="controles_ucVistaDetalleORDEN_COMBUSTIBLEV2" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucListaORDEN_COMBUSTIBLE_PROD.ascx" tagname="ucListaORDEN_COMBUSTIBLE_PROD" tagprefix="uc1" %>


<table id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
        <td>
            <dx:ASPxFormLayout ID="ucVistaDetallePROVEEDORLayout" ClientInstanceName="ucVistaDetallePROVEEDORLayout" runat="server">
                <Items>
                    <dx:LayoutGroup ColCount="4" ShowCaption="False" Name="lgVistaDetallePROVEEDOR" GroupBoxDecoration="None" Width="800px"  >
                        <Items>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <table>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="label1" Text="Zafra:"></dx:ASPxLabel></td>
                                                <td><dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="170px">
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox></td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel1" Text="Correlativo:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtID_ORDEN_COMBUS" AutoPostBack="true" runat="server" Width="170px" BackColor="WhiteSmoke">                               
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>                                                                                               
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel2" Text="Tipo de Cliente:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxRadioButtonList ID="rbtlTIPO_PROVEEDOR" runat="server" AutoPostBack="true" Font-Bold="true" ValueType="System.Int32" RepeatDirection="Horizontal" ItemSpacing="10px">
                                                        <Items>
                                                            <dx:ListEditItem Value="5" Text="Motorista" Selected="true" /> 
                                                            <dx:ListEditItem Value="2" Text="Transportista" />                                                            
                                                        </Items>
                                                        <Border BorderStyle="None" />
                                                    </dx:ASPxRadioButtonList>
                                                </td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                            <tr>
                                                <th colspan="4" ><hr /></th> 
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel3" Text="Cód. Cliente:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtCODIGO_CLIENTE" AutoPostBack="true" HorizontalAlign="Right" runat="server" Width="170px" BackColor="WhiteSmoke">                               
                                                    <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel4" Text="Nombre:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtNOMBRE_CLIENTE" runat="server" Width="100%" BackColor="WhiteSmoke">                               
                                                    <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>                                            
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel5" Text="Placa:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxPLACAVEHIC" AutoPostBack="true" runat="server" Width="170px" 
                                                        HorizontalAlign="Right" ValueField="ID_TRANSPORTE" TextField="PLACA" 
                                                        ValueType="System.Int32" DropDownStyle="DropDown" 
                                                        IncrementalFilteringMode="Contains" >                                                                                                                                                    
                                                        <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>                                                        
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel6" Text="Sección:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxSECCION" DataSourceID="odsSECCION"  AutoPostBack="true" runat="server" Width="100%" 
                                                        ValueField="ID_SECCION" TextField="NOMBRE_SECCION" 
                                                        ValueType="System.Int32" DropDownStyle="DropDownList"
                                                        IncrementalFilteringMode="Contains" >                                                                                                                                                    
                                                        <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>                                                        
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel7" Text="NIT:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtNIT" runat="server" >
                                                     <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                                         Mask="9999-999999-999-9" ErrorText="NIT no valido"  />
                                                     <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="NIT no valido">                                    
                                                    </ValidationSettings>                                                    
                                                    <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>
                                                </dx:ASPxTextBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel8" Text="NRC:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtNRC" MaxLength="10" runat="server" Width="170px"  >
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="NRC obligatorio" >                                    
                                                        </ValidationSettings>
                                                        <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel9" Text="Motorista:"></dx:ASPxLabel></td>
                                                <th colspan="3">                                 
                                                     <dx:ASPxComboBox ID="cbxMOTORISTA" runat="server" AutoPostBack="true" DataSourceID="odsMotoristas" ValueField="ID_MOTORISTA" TextField="NOMBRE" MaxLength="120" ValueType="System.Int32" Width="100%" TextFormatString="{0} {1}"  DropDownStyle="DropDown" IncrementalFilteringMode="Contains" >                                                                                                        
                                                            <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>                                            
                                                                <Columns>                                                        
                                                                <dx:ListBoxColumn Caption="Nombres" FieldName="NOMBRES" Width="130px" />                                                            
                                                                <dx:ListBoxColumn Caption="Apellidos" FieldName="APELLIDOS" Width="140px" />                                                        
                                                                <dx:ListBoxColumn Caption="DUI" FieldName="DUI" Width="80px" />
                                                                <dx:ListBoxColumn Caption="Licencia" FieldName="LICENCIA" Width="140px" />   
                                                            </Columns>
                                                      </dx:ASPxComboBox>
                                                </th>     
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel10" Text="DUI:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtDUI" runat="server">
                                                        <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                                            Mask="99999999-9" />
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="DUI no valido">                                                                       
                                                        </ValidationSettings>
                                                        <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>         
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel11" Text="Licencia:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtLICENCIA" runat="server">      
                                                        <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>                                                                                                        
                                                    </dx:ASPxTextBox>  
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel12" Text="Observación:"></dx:ASPxLabel></td>
                                                <th colspan="3">
                                                    <dx:ASPxMemo ID="txtOBSERVACIONES" runat="server" Height="50px" Width="100%">
                                                    <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxMemo>
                                                </th> 
                                            </tr>                                                                                        
                                            <tr>
                                                <th colspan="4" ><hr /></th> 
                                            </tr>                                                                                        
                                            <tr id="trFACTURA1" runat="server" visible="false">
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel13" Text="CCF/Factura:"></dx:ASPxLabel></td>
                                                <td><dx:ASPxTextBox ID="txtNO_FACTURA_CCF" runat="server" Width="170px" BackColor="WhiteSmoke">                               
                                                    <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox></td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel14" Text="Fecha:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dteFECHA_DESPACHO" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                            EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="100%">
                                                        <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>
                                                     </dx:ASPxDateEdit>
                                                </td>                                                
                                            </tr>        
                                            <tr id="trFACTURA2" runat="server" visible="false">
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel15" Text="Total Factura:"></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="txtTOTAL_FACTURA" runat="server" ClientInstanceName="speSUB_TOTALclient" DisplayFormatString="#,##0.00" Width="170px" ClientEnabled="false" HorizontalAlign="Right" >	
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                        <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>		                                            
			                                        </dx:ASPxSpinEdit>                                                    
                                                 </td>                                                 
                                            </tr>                                    
                                            <tr>
                                                <th colspan="4">
                                                    <table>
                                                        <tr id="trNUEVO_PRODUCTO1" runat="server">
                                                            <td width="800px">
                                                                <dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Producto">
                                                                </dx:ASPxLabel>
                                                            </td>
                                                            <td width="300px">
                                                                <dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="Cantidad">
                                                                </dx:ASPxLabel>
                                                            </td>
                                                            <td width="200px">
                                                                <dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="Precio Unitario">
                                                                </dx:ASPxLabel>
                                                            </td>
                                                            <td width="300px">
                                                                <dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="Total">
                                                                </dx:ASPxLabel>
                                                            </td>
                                                            <td></td>
                                                        </tr>
                                                        <tr id="trNUEVO_PRODUCTO2" runat="server">
                                                            <td width="800px">
                                                                <dx:ASPxComboBox ID="cbxPRODUCTO" AutoPostBack="true" DataSourceID="odsProductoCombustible"  runat="server" ValueType="System.Int32" Width="100%"  ValueField="ID_PRODUCTO" DisplayFormatString="{0}"  TextField="NOMBRE_PRODUCTO" DropDownStyle="DropDownList" >                                                                                                                   
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxComboBox>
                                                            </td>
                                                            <td width="300px">
                                                                <dx:ASPxSpinEdit ID="speCANTIDAD" AutoPostBack="true" runat="server" DisplayFormatString="#,##0.00##" Width="100%"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                                                                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                                    </dx:ASPxSpinEdit>
                                                            </td>
                                                            <td width="200px">
                                                                <dx:ASPxSpinEdit ID="spePRECION_UNITARIO" AutoPostBack="true"  runat="server" DisplayFormatString="#,##0.00##" Width="100%"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                                                                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                                    </dx:ASPxSpinEdit>
                                                            </td>
                                                            <td width="300px">
                                                                <dx:ASPxSpinEdit ID="speTOTAL" runat="server" DisplayFormatString="#,##0.00##" Width="100%"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                                                                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                <DisabledStyle BackColor="Gainsboro" ForeColor="Black"></DisabledStyle>		                                            
			                                                    </dx:ASPxSpinEdit>
                                                            </td>
                                                            <td>
                                                                <dx:ASPxButton ID="btnAgregarProducto" CausesValidation="false" ToolTip="Agregar producto a la SOLICITUD" Width="20px" Theme="RedWine" runat="server" Text="+"></dx:ASPxButton>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <th colspan="5" >
                                                                <uc1:ucListaORDEN_COMBUSTIBLE_PROD ID="ucListaORDEN_COMBUSTIBLE_PROD1" runat="server" />
                                                            </th> 
                                                        </tr>
                                                         <tr id="trMOTIVO_ANULACION" runat="server" visible="false">
                                                            <td><dx:ASPxLabel runat="server" ID="ASPxLabel20" ForeColor="Red" Font-Bold="true" Text="Motivo de Anulación:"></dx:ASPxLabel></td>
                                                            <th colspan="3">
                                                                <dx:ASPxMemo ID="txtMOTIVO_ANULACION" runat="server" Height="50px" Width="100%">
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxMemo>
                                                            </th> 
                                                        </tr>        
                                                    </table>
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
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />
<dx:ASPxHiddenField runat="server"  ID="hfvistaEntradaEnca" SyncWithServer="true" />   

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsMotoristas" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaActivos" 
    TypeName="SISPACAL.BL.cMOTORISTA">      
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSeccion" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaParaOrdenCombustible" 
    TypeName="SISPACAL.BL.cSECCION">      
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProductoCombustible" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cPRODUCTO_COMBUSTIBLE">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_PRODUCTO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>