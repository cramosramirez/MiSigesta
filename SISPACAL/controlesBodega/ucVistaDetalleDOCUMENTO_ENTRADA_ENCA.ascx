<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleDOCUMENTO_ENTRADA_ENCA.ascx.vb" Inherits="controles_ucVistaDetalleDOCUMENTO_ENTRADA_ENCA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaDOCUMENTO_ENTRADA_DETA" Src="~/controlesBodega/ucListaDOCUMENTO_ENTRADA_DETA.ascx" %>



<script type="text/javascript">
    function CalcularValorTotal(s, e) {
        var total = speCANTIDAD.GetValue() * inCostoUnitarioEntrada.GetValue();
        if (isNumber(total)) {
            inTotalProductoEntrada.SetValue(round(total, 2));
        }
        else
            inTotalProductoEntrada.SetValue(round(0, 0));
    }
    function isNumber(n) {
        return !isNaN(parseFloat(n)) && isFinite(n);
    }
    function round(value, exp) {
        if (typeof exp === 'undefined' || +exp === 0)
            return Math.round(value);

        value = +value;
        exp = +exp;

        if (isNaN(value) || !(typeof exp === 'number' && exp % 1 === 0))
            return NaN;

        // Shift
        value = value.toString().split('e');
        value = Math.round(+(value[0] + 'e' + (value[1] ? (+value[1] + exp) : exp)));

        // Shift back
        value = value.toString().split('e');
        return +(value[0] + 'e' + (value[1] ? (+value[1] - exp) : -exp));
    }
</script>


<dx:ASPxCallbackPanel ID="cpVistaDetalleDOCUMENTO_ENTRADA_ENCA" ClientInstanceName="cpVistaDetalleDOCUMENTO_ENTRADA_ENCA" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  


<table width="100%" >
    <tr>
    <td align="center">
    <dx:ASPxFormLayout ID="ucVistaDetalleDOCUMENTO_ENTRADA_ENCALayout" ClientInstanceName="ucVistaDetalleDOCUMENTO_ENTRADA_ENCALayout" runat="server">
        <Items>
            <dx:LayoutGroup ColCount="1" GroupBoxStyle-Caption-Font-Bold="true" GroupBoxStyle-Caption-ForeColor="DarkBlue" Name="lgDocumentoEntrada1" Caption="Información del Ingreso" GroupBoxDecoration="Box">
                <GroupBoxStyle>
                <Caption Font-Bold="True"></Caption>
                </GroupBoxStyle>
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                                                
                                <table width="100%" >
                                    <tr>
                                        <td> 
                                            <table border="0">
                                                <tr id="trIdDocentra" runat="server" visible="false"> 
                                                    <td><dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="Id Documento Entrada:" /></td>                                                       
                                                    <td>                           
                                                       <dx:ASPxTextBox ID="txtID_DOCENTRA_ENCA" runat="server" ClientVisible="false" ClientInstanceName="txtID_DOCENTRA_ENCA" Width="170px" BackColor="WhiteSmoke">                               
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxTextBox>                                                                                
                                                    </td>  
                                                        <td><dx:ASPxLabel ID="ASPxLabel100" runat="server" Text="N° Documento Entrada:" />                                                       
                                                       </td>    
                                                    <td>                           
                                                       <dx:ASPxTextBox ID="txtNO_DOCUMENTO" runat="server" ClientInstanceName="txtNO_DOCUMENTO" Width="170px" BackColor="WhiteSmoke">                               
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxTextBox>                        
                                                    </td>  
                                                    <td></td>
                                                    <td></td>
                                                </tr>  
                                                <tr>
                                                    <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Tipo Movimiento:" /></td>
                                                    <td>
                                                        <dx:ASPxComboBox AutoPostBack="true" runat="server" ValueType="System.Int32" DataSourceID="odsTIPO_MOVTO_ENTRADA" TextField="NOMBRE_TIPO_MOVTO" ValueField="ID_TIPO_MOVTO" Width="200px" ID="cbxTIPO_MOVTO">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxComboBox>
                                                    </td>
                                                    <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Zafra:" /></td>
                                                    <td>
                                                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="170px">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxComboBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Bodega:" /></td>
                                                    <td>
                                                         <dx:ASPxComboBox runat="server" ValueType="System.Int32" DataSourceID="odsBodega" TextField="NOMBRE_BODEGA" ValueField="ID_BODEGA" Width="200px" ID="cbxBODEGA">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxComboBox>
                                                    </td>
                                                    <td><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Fecha:" /></td>
                                                    <td>
                                                        <dx:ASPxDateEdit ID="dteFEC_DOCTO" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                            EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="170px"  >                                            
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxDateEdit>  
                                                    </td>
                                                    <td></td>
                                                    <td></td>
                                                </tr>       
                                                <tr id="trSalidaBodega" runat="server" visible="false">
                                                   <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="No. Salida Bodega:" /></td>
                                                    <td>
                                                        <dx:ASPxSpinEdit ID="speNO_DOCUMENTO_SALIDA" runat="server" AutoPostBack="true" Width="200px" NumberType="Integer" SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                            </dx:ASPxSpinEdit>
                                                    </td>
                                                </tr>                                                                                                                                                                                     
                                                <tr id="trInfoProveedor" runat="server">
                                                    <td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="Proveedor:" /></td> 
                                                        <th colspan="3">
                                                            <dx:ASPxComboBox runat="server" AutoPostBack="True" ValueType="System.Int32" DataSourceID="odsProveedorAgricola" TextField="NOMBRE" ValueField="ID_PROVEE" Width="100%" ID="cbxPROVEEDOR_AGRICOLA">
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxComboBox>     
                                                        </th>     
                                                    <td>                                                     
                                                        <dx:ASPxLabel runat="server" Text="Forma de Entrega:" ID="ASPxLabel18"></dx:ASPxLabel>
                                                    </td>
                                                    <td>
                                                            <dx:ASPxComboBox runat="server" SelectedIndex="0" ValueType="System.Int32" Width="150px" AutoPostBack="True" ID="cbxFORMA_ENTREGA">
                                                            <Items>
                                                            <dx:ListEditItem Text="TOTAL" Value="1"></dx:ListEditItem>
                                                            <dx:ListEditItem Text="PARCIAL" Value="2"></dx:ListEditItem>
                                                            </Items>
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxComboBox>  
                                                    </td>                                                   
                                                </tr>                                                
                                                 <tr  id="trInfoOrdenCompraA" runat="server">
                                                     <td><dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="N° Orden Compra:" /></td>
                                                     <td>
                                                     <dx:ASPxComboBox ID="cbxORDEN_COMPRA" AutoPostBack="true" runat="server" ValueField="ID_ORDEN" TextField="CODI_ORDEN" ValueType="System.Int32" Width="200px" DropDownStyle="DropDownList">                                                               
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" ></DisabledStyle>
                                                     </dx:ASPxComboBox>
                                                     </td>                                                                                          
                                                     <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Tipo Comprobante:" /></td>
                                                     <td>
                                                         <dx:ASPxComboBox ID="cbxTIPO_COMPROB" DataSourceID="odsTipoComprobante" runat="server" ValueField="ID_TIPO_COMPROB" TextField="NOMBRE_TIPO" ValueType="System.Int32" Width="170px" DropDownStyle="DropDownList">                                                               
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" ></DisabledStyle>
                                                         </dx:ASPxComboBox>
                                                     </td>
                                                     <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="N° Comprobante:" /></td>
                                                     <td><dx:ASPxTextBox ID="txtNO_COMPROB" runat="server" Width="150px" MaxLength="10"  >                                        
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                          </dx:ASPxTextBox>
                                                     </td>               
                                                </tr>  
                                                <tr  id="trInfoOrdenCompraB" runat="server">
                                                    <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Fecha Comprobante:" /></td>
                                                    <td>
                                                        <dx:ASPxDateEdit ID="dteFECHA_COMPROB" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                            EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="200px"  >                                            
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxDateEdit> 
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Observaciones:" /></td>
                                                    <th colspan="5">
                                                        <dx:ASPxMemo ID="txtOBSERVACIONES" runat="server" Width="100%" MaxLength="1000" Height="50px" >                                        
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                        </dx:ASPxMemo>
                                                    </th>
                                                </tr>
                                            </table>
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

<center>
<table runat="server" id="tblPRODUCTOS" width="1100px"  >                                                    
    <tr id="trProductoParteB" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel300" runat="server" Text="Cantidad:" /></td>     
        <td>                     
                <dx:ASPxSpinEdit ID="speCANTIDAD_PRODUCTO" ClientSideEvents-ValueChanged="CalcularValorTotalEntrada" ClientInstanceName="inCantidadEntrada" NumberType="Float" DecimalPlaces="2"  runat="server" HorizontalAlign="Right" Width="50px">                        
                <SpinButtons ShowIncrementButtons="false"></SpinButtons>    
                    <ClientSideEvents ValueChanged="CalcularValorTotalEntrada"></ClientSideEvents>
                </dx:ASPxSpinEdit>              
        </td>      
        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Producto de Bodega:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxPRODUCTO" ClientInstanceName="incbxPRODUCTO" AutoPostBack="true"  runat="server" DisplayFormatString="{0} - {1}" ValueField="ID_PRODUCTO" TextField="NOMBRE_PRODUCTO" ValueType="System.Int32" Width="300px" DropDownStyle="DropDownList">                                                               
                <Columns>                                                                            
                    <dx:ListBoxColumn FieldName="NOMBRE_PROVEEDOR" Caption="Proveedor" Width="100px" />
                    <dx:ListBoxColumn FieldName="NOMBRE_PRODUCTO" Caption="Descripción" Width="250px" />
                    <dx:ListBoxColumn FieldName="PRESENTACION" Caption="Presentación" Width="100px" />
                </Columns>                                                    
            </dx:ASPxComboBox>           
        </td>         
        <td><dx:ASPxLabel ID="ASPxLabel26" runat="server" Text="Presentacion:" /></td>
        <td>                     
                <dx:ASPxTextBox ID="txtPRESENTACION" runat="server" Width="100px" MaxLength="30" >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxTextBox> 
        </td>  
        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Fecha Vto.:" /></td> 
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_VTO" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px" >                                            
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxDateEdit>  
        </td>                 
        <td>
            <dx:ASPxButton ID="btnAgregarProducto" ToolTip="Agregar" AutoPostBack="true" Width="100px" Theme="RedWine" runat="server" Text="Agregar"></dx:ASPxButton>                                                
        </td>
    </tr>      
<tr>
    <th colspan="11" >     
    <uc1:ucListaDOCUMENTO_ENTRADA_DETA id="ucListaDOCUMENTO_ENTRADA_DETA1" VerPRECIO_UNITARIO="true" VerTOTAL="true" VerUNIDAD_MEDIDA = "True" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEliminarInline="false" runat="server"></uc1:ucListaDOCUMENTO_ENTRADA_DETA>                                                               
    </th>               
</tr>
</table>
</center> 

<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />
<dx:ASPxHiddenField runat="server"  ID="hfvistaEntradaEnca" SyncWithServer="true" />   


  </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>


<asp:ObjectDataSource ID="odsTIPO_MOVTO_ENTRADA" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorENTRADA_SALIDA" 
    TypeName="SISPACAL.BL.cTIPO_MOVTO">  
    <SelectParameters>
        <asp:Parameter DefaultValue="true" Name="ES_ENTRADA" Type="Boolean" />        
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

<asp:ObjectDataSource ID="odsBodega" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cBODEGA">  
    <SelectParameters>        
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />   
        <asp:Parameter DefaultValue="ID_BODEGA" Name="asColumnaOrden" Type="String" />        
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />   
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTipoComprobante" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaVerRegistro" 
    TypeName="SISPACAL.BL.cTIPO_COMPROB">  
    <SelectParameters>                 
        <asp:Parameter DefaultValue="NOMBRE_TIPO" Name="asColumnaOrden" Type="String" />        
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />   
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
