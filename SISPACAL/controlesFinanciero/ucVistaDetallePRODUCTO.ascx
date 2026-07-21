<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePRODUCTO.ascx.vb" Inherits="controlesFinanciero_ucVistaDetallePRODUCTO" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="ucVistaDetallePRODUCTOLayout" ClientInstanceName="ucVistaDetalleMEMBRE_GREMIALLayout" runat="server" Width="1000px">
                <Items>
                    <dx:LayoutGroup ColCount="1" Name="lgProducto" Caption="Información de Ingreso de Producto Agrícola" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <table width="100%" >
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="Label1" Text="Id. Producto:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox id="txtID_PRODUCTO" runat="server" Width="170px" MaxLength="100">	
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />    		                                           
			                                        </dx:ASPxTextBox>
                                                </td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel14" Text="Proveedor Agrícola:" /></td>
                                                <th colspan="3" >
                                                     <dx:ASPxComboBox ID="cbxPROVEEDOR_AGRICOLA" runat="server" ValueType="System.Int32" DataSourceID="odsProveedorAgricola" ValueField="ID_PROVEE" DisplayFormatString="{0} {1}" TextField="NOMBRE" Width="100%" >                                                    
                                                        <Columns>
                                                            <dx:ListBoxColumn FieldName="NOMBRE" Caption="Nombres" Width="120px" />  
                                                            <dx:ListBoxColumn FieldName="APELLIDOS" Caption="Apellidos" Width="120px" />                                                         
                                                        </Columns>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel1" Text="Nombre del Producto:" /></td>
                                                <th colspan="3" >
                                                    <dx:ASPxTextBox id="txtNOMBRE_PRODUCTO" runat="server" Width="100%" Font-Bold="true" MaxLength="100">	
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />    		                                           
			                                        </dx:ASPxTextBox>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel13" Text="Nombre Comercial:" /></td>
                                                <th colspan="3" >
                                                    <dx:ASPxTextBox id="txtNOMBRE_COMERCIAL" runat="server" Width="100%" Font-Bold="true" MaxLength="100">	
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />    		                                           
			                                        </dx:ASPxTextBox>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel2" Text="Categoría:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxCATEGORIA_PROD" runat="server" ValueType="System.Int32" DataSourceID="odsCATEGORIA_PROD" ValueField="ID_CATEGORIA" TextField="NOMBRE_CATEGORIA" Width="320px" >                                                    
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel3" Text="Unidad de Medida:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxUNIDAD_MEDIDA" runat="server" ValueType="System.Int32" DataSourceID="odsUNIDAD_MEDIDA" ValueField="ID_UNIDAD" TextField="NOMBRE_UNIDAD" Width="170px" >                                                    
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel4" Text="Precio Unitario:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="spePRECIO_UNITARIO" runat="server" Height="21px" DisplayFormatString="#,##0.00##"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                        </dx:ASPxSpinEdit>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel15" Text="Existencia:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="speEXISTENCIA" runat="server" Height="21px" NumberType="Float" SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                        </dx:ASPxSpinEdit>
                                                </td>
                                            </tr>                                                                                                                       
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel9" Text="Cuenta de Financiamiento:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxCUENTA_FINAN" runat="server" ValueType="System.Int32" DataSourceID="odsCUENTA_FINAN" ValueField="ID_CUENTA_FINAN" TextField="NOMBRE_CUENTA" Width="320px" >                                                    
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel10" Text="Presentación:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox id="txtPRESENTACION" runat="server" Width="170px" MaxLength="50">	
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />    		                                           
			                                        </dx:ASPxTextBox>
                                                </td>
                                            </tr>   
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel12" Text="% Subsidio:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="spePORC_SUBSIDIO" runat="server" Height="21px" DisplayFormatString="#,##0.00##"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                        </dx:ASPxSpinEdit>
                                                </td>
                                            </tr>   
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel11" Text="Producto en Consigna:" /></td>
                                                <td>
                                                    <dx:ASPxCheckBox ID="chkEN_CONSIGNA" runat="server" Text="" ></dx:ASPxCheckBox>
                                                </td>
                                            </tr>    
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel8" Text="Activo:" /></td>
                                                <td>
                                                    <dx:ASPxCheckBox ID="chkACTIVO" runat="server" Text="" ></dx:ASPxCheckBox>
                                                </td>
                                            </tr>               
                                             <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel16" Text="Aplica CESC:" /></td>
                                                <td>
                                                    <dx:ASPxCheckBox ID="chkAPLICA_CESC" runat="server" Text="" ></dx:ASPxCheckBox>
                                                </td>
                                            </tr>                          
                                            <tr>
                                                <th colspan="4"  style="text-align:left" ><dx:ASPxLabel runat="server" ID="ASPxLabel5" Text="Ventana de Cosecha (Aplica solo a madurantes):" Font-Bold="true" /></th>                                                
                                            </tr>
                                             <tr>
                                                <th colspan="4"  style="text-align:left" ><hr /></th>                                                
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel6" Text="N° de Semana inicial:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="speVENTSEMA_INI" runat="server" Height="21px" DisplayFormatString="#,##0" Width="170px" SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                        </dx:ASPxSpinEdit>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel7" Text="N° de Semana final:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="speVENTSEMA_FIN" runat="server" Height="21px" DisplayFormatString="#,##0" Width="170px"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                        </dx:ASPxSpinEdit>
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

<asp:ObjectDataSource ID="odsCATEGORIA_PROD" runat="server" SelectMethod="ObtenerLista"  TypeName="SISPACAL.BL.cCATEGORIA_PROD">  
    <SelectParameters>        
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_CATEGORIA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsCUENTA_FINAN" runat="server" SelectMethod="ObtenerLista"  TypeName="SISPACAL.BL.cCUENTA_FINAN">  
    <SelectParameters>        
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_CUENTA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsUNIDAD_MEDIDA" runat="server" SelectMethod="ObtenerLista"  TypeName="SISPACAL.BL.cUNIDAD_MEDIDA">  
    <SelectParameters>        
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_UNIDAD" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProveedorAgricola" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cPROVEEDOR_AGRICOLA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />      
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

