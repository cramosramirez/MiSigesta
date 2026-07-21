<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleDOCUMENTO_SALIDA_ENCA.ascx.vb" Inherits="controles_ucVistaDetalleDOCUMENTO_SALIDA_ENCA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaDOCUMENTO_SALIDA_DETA" Src="~/controlesBodega/ucListaDOCUMENTO_SALIDA_DETA.ascx" %>



<style type="text/css">
    .auto-style1 {
        height: 60px;
    }
</style>



<dx:ASPxCallbackPanel ID="cpVistaDetalleDOCUMENTO_SALIDA_ENCA" ClientInstanceName="cpVistaDetalleDOCUMENTO_SALIDA_ENCA" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent1" runat="server">  


<table width="100%" >
    <tr>
    <td align="center">
    <dx:ASPxFormLayout ID="ucVistaDetalleDOCUMENTO_SALIDA_ENCALayout" ClientInstanceName="ucVistaDetalleDOCUMENTO_SALIDA_ENCALayout" runat="server">
        <Items>
            <dx:LayoutGroup ColCount="1" GroupBoxStyle-Caption-Font-Bold="true" GroupBoxStyle-Caption-ForeColor="DarkBlue" Name="lgDocumentoSalida1" Caption="Información de Salida" GroupBoxDecoration="Box">
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
                                                    <td><dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="Id Documento Salida:" /></td>    
                                                    <td>                           
                                                       <dx:ASPxTextBox ID="txtID_DOCSAL_ENCA" runat="server" ClientVisible="false" ClientInstanceName="txtID_DOCSAL_ENCA" Width="120px" BackColor="WhiteSmoke">                               
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxTextBox>                        
                                                    </td>  
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>                                                    
                                                </tr>
                                                <tr> 
                                                    <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="N° Documento Salida:" /></td>
                                                    <td><dx:ASPxTextBox ID="txtNO_DOCUMENTO" runat="server" ClientInstanceName="txtNO_DOCUMENTO" Width="120px" BackColor="WhiteSmoke">                               
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxTextBox>     
                                                    </td>
                                                </tr>
                                                <tr> 
                                                    <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Tipo de Movimiento:" /></td>    
                                                    <th colspan="2">
                                                        <dx:ASPxComboBox runat="server" ValueType="System.Int32" DataSourceID="odsTIPO_MOVTO_ENTRADA" TextField="NOMBRE_TIPO_MOVTO" ValueField="ID_TIPO_MOVTO" Width="300px" AutoPostBack="True" ID="cbxID_TIPO_MOVTO">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxComboBox>
                                                    </th>  
                                                    <td>                                                                                                         
                                                        <dx:ASPxLabel runat="server" Text="Fecha:" ID="ASPxLabel11"></dx:ASPxLabel>
                                                    </td>  
                                                    <td>
                                                        <dx:ASPxDateEdit runat="server" UseMaskBehavior="True" EditFormat="Custom" EditFormatString="dd/MM/yyyy" Width="170px" DisplayFormatString="dd/MM/yyyy" ClientEnabled="False" ID="dteFECHA_DOCTO">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxDateEdit>  
                                                    </td>                                                                                                       
                                                </tr>  
                                                 <tr>
                                                    <td><dx:ASPxLabel ID="lblBodegaOrigen" runat="server" Text="Bodega:" /></td> 
                                                    <td>
                                                        <dx:ASPxComboBox ID="cbxBODEGA_ORIGEN" runat="server" AutoPostBack="true" DataSourceID="odsBodega" ValueField="ID_BODEGA" TextField="NOMBRE_BODEGA" ValueType="System.Int32" Width="300px" DropDownStyle="DropDownList">                                                               
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" ></DisabledStyle>
                                                        </dx:ASPxComboBox>
                                                    </td>
                                                    <td></td>                                                   
                                                    <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Zafra:" /></td>
                                                    <td>
                                                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="170px">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxComboBox>
                                                    </td>                                                  
                                                 </tr>     
                                                <tr>
                                                   <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="No. Solicitud de Retiro:" /></td>
                                                    <td>
                                                        <dx:ASPxComboBox ID="cbxSALBODE_ENCA" runat="server" AutoPostBack="true" ValueField="ID_SALBODE_ENCA" TextField="USUARIO_CREACION" ValueType="System.Int32" Width="300px" DropDownStyle="DropDownList">                                                               
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" ></DisabledStyle>
                                                        </dx:ASPxComboBox>
                                                    </td>
                                                </tr>                                                                                                                                                                           
                                                <tr>
                                                        <td class="auto-style1"><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Observaciones:" /></td>
                                                        <th colspan="4"  class="auto-style1">
                                                            <dx:ASPxMemo ID="txtOBSERVACIONES" runat="server" Width="100%" MaxLength="1000" Height="50px" >                                        
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxMemo>
                                                        </th>
                                                </tr>                                               
                                                <tr>
                                                        <td class="auto-style2"><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Entregado:" /></td>
                                                        <th colspan="4"  class="auto-style2">
                                                            <dx:ASPxTextBox ID="txtENTREGADO" runat="server" Width="100%" MaxLength="200"  >                                        
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </th>
                                                </tr>     
                                                 <tr>
                                                        <td class="auto-style2"><dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="Recibido:" /></td>
                                                        <th colspan="4"  class="auto-style2">
                                                            <dx:ASPxTextBox ID="txtRECIBIDO" runat="server" Width="100%" MaxLength="200"  >                                        
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
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
 <table>  
    <tr>
        <td align="center">
            <table>
                <tr id="trPRODUCTO_AGRICOLA_DETA1" runat="server">                    
                    <td width="180px"><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="Producto" /></td>
                    <td width="100px"><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Presentación" /></td>                    
                    <td width="50px"><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Existencia" /></td>  
                    <td width="50px" style="text-align:right"><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Cantidad" /></td>
                    <td width="50px" style="text-align:right"><dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="Precio Unitario" /></td>
                    <td width="50px" style="text-align:right"><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Valor" /></td>
                    <td width="20px"></td>
                </tr>
                <tr id="trPRODUCTO_AGRICOLA_DETA2" runat="server">                    
                    <td>
                        <dx:ASPxComboBox ID="cbxPRODUCTOdeta" AutoPostBack="true" runat="server" ValueType="System.Int32" ValueField="ID_PRODUCTO" DisplayFormatString="{0} - {1}"  TextField="NOMBRE_PRODUCTO" DropDownStyle="DropDown" Width="100%" >                                                    
                            <Columns>
                                <dx:ListBoxColumn FieldName="NOMBRE_PROVEEDOR" Caption="Proveedor" Width="100px" />
                                <dx:ListBoxColumn FieldName="NOMBRE_PRODUCTO" Caption="Producto" Width="140px" />  
                                <dx:ListBoxColumn FieldName="PRESENTACION" Caption="Presentacion" Width="60px" />
                                <dx:ListBoxColumn FieldName="PRECIO_UNITARIO" Caption="Precio U." Width="70px" />
                            </Columns>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxComboBox>
                    </td>
                    <td>
                        <dx:ASPxTextBox ID="txtPRESENTACIONdeta" runat="server" MaxLength="20" ClientInstanceName="txtDESCRIP_AERONAVE" Width="100%"> 
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                              
                        </dx:ASPxTextBox>
                    </td>
                    <td>
                        <dx:ASPxSpinEdit ID="speEXISTENCIA" AutoPostBack="true" runat="server" DisplayFormatString="#,##0.00##" Width="100%"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			            </dx:ASPxSpinEdit>
                    </td>                    
                    <td>
                        <dx:ASPxSpinEdit ID="speCANTIDADdeta" AutoPostBack="true" runat="server" DisplayFormatString="#,##0.00##" Width="100%"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			            </dx:ASPxSpinEdit>
                    </td>
                    <td>
                        <dx:ASPxSpinEdit ID="spePRECIO_UNITARIOdeta" AutoPostBack="true" runat="server" DisplayFormatString="#,##0.00##" Width="100%"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			            </dx:ASPxSpinEdit>
                    </td>
                    <td>
                        <dx:ASPxSpinEdit ID="speSUB_TOTALdeta" runat="server" DisplayFormatString="#,##0.00" Width="100%" ClientEnabled="false" SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			            </dx:ASPxSpinEdit>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnAgregarProducto" CausesValidation="false" ToolTip="Agregar producto a la SOLICITUD" Width="20px" Theme="RedWine" runat="server" Text="+"></dx:ASPxButton>
                    </td>                                                        
                </tr>
                <tr>
                    <th colspan="7" >
                        <uc1:ucListaDOCUMENTO_SALIDA_DETA id="ucListaDOCUMENTO_SALIDA_DETA1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="true" PermitirEliminar="true"  runat="server"></uc1:ucListaDOCUMENTO_SALIDA_DETA>                                    
                    </th>                                            
                </tr>		        
        </table>   
        </td>
    </tr> 
</table>
</center>
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />     
<dx:ASPxHiddenField runat="server"  ID="hfvistaSalidaEnca" SyncWithServer="true" />        

  </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>

<asp:ObjectDataSource ID="odsTIPO_MOVTO_ENTRADA" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorENTRADA_SALIDA" 
    TypeName="SISPACAL.BL.cTIPO_MOVTO">  
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="ES_ENTRADA" Type="Boolean" />        
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

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>






