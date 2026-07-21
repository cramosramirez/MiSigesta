<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCCF_ENCA_CONSIGNADO.ascx.vb" Inherits="controlesFinanciero_ucVistaDetalleCCF_ENCA_CONSIGNADO" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaCCF_DETA" Src="~/controlesFinanciero/ucListaCCF_DETA.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaCCF_DETA_SALBODE" Src="~/controlesFinanciero/ucListaCCF_DETA_SALBODE.ascx" %>


<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="ucVistaDetalleCCF_ENCALayout" ClientInstanceName="ucVistaDetalleCCF_ENCALayout" runat="server" Width="1000px">
                <Items>
                    <dx:LayoutGroup ColCount="1" Name="lgMembresiaGremial" Caption="Información de Comprobante" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <center>
                                        <table>
                                            <tr id="trId" runat="server" visible="false">
                                                <td><dx:ASPxLabel id="ASPxLabel1" runat="server" Text="Id CCF:" /></td>
                                                <td><dx:ASPxTextBox id="txtID_CCF_ENCA" runat="server" Width="170px" /></td>
                                            </tr>                               
                                            <tr>
                                                <td><dx:ASPxLabel id="ASPxLabel21" runat="server" Text="Zafra:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="170px">
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td></td>
                                                <td>                                                    
                                                </td>
                                                <td></td>
                                                <td></td>
                                            </tr>       
                                            <tr>
                                                <td><dx:ASPxLabel id="ASPxLabel26" runat="server" Text="Proveedor/Casa Comercial:" /></td>
                                                <th colspan="3" >
                                                    <dx:ASPxComboBox ID="cbxPROVEEDOR_AGRICOLA" AutoPostBack="true" runat="server" ValueType="System.Int32" DataSourceID="odsProveedorAgricola" ValueField="ID_PROVEE" TextField="NOMBRE" Width="100%" >                                                    
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </th> 
                                                <td></td> 
                                            </tr>      
                                            <tr>
                                                <td><dx:ASPxLabel id="ASPxLabel4" runat="server" Text="Tipo Financiamiento:" /></td>
                                                <th colspan="3"  style="text-align:left" >
                                                    <dx:ASPxComboBox ID="cbxTIPO_FINANCIAMIENTO" AutoPostBack="true" runat="server" ValueField="ID_CUENTA_FINAN"   
                                                        TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinan"  
                                                        >
                                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
                                                             <RequiredField ErrorText="Seleccione el Concepto de Financiamiento" IsRequired="True" />
                                                    </ValidationSettings>
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>   
                                                </th>
                                                <td></td>
                                            </tr>  
                                            <tr>
                                                <td><dx:ASPxLabel id="ASPxLabel6" runat="server" Text="Código Productor:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="speCODIPROVEE" AutoPostBack="true" runat="server" Width="170px" NumberType="Integer">
			                                            <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			                                                <RequiredField ErrorText="Campo No orden es requerido" IsRequired="True" />
			                                            </ValidationSettings>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        <SpinButtons ShowIncrementButtons="false" /> 
			                                        </dx:ASPxSpinEdit>
                                                </td>
                                                <td><dx:ASPxLabel id="ASPxLabel7" runat="server" Text="Productor:" /></td>
                                                <th colspan="3" ><dx:ASPxTextBox id="txtNOMBRE_PROVEEDOR" runat="server" Width="100%" >
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                 </dx:ASPxTextBox>
                                                </th>
                                                <td>
                                                    <dx:ASPxButton ID="btnProductosPendientesFact" Theme="SoftOrange" CausesValidation="false" ToolTip="Ver productos consignados entregados y pendientes de facturar"  runat="server" Image-IconID="" Width="30px" >
                                                        <Image IconID="format_listbullets_16x16">
                                                        </Image>
                                                    </dx:ASPxButton>
                                                </td>
                                            </tr>                               
                                            <tr>
                                                <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Tipo Comprobante:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxTIPO_COMPROB" DataSourceID="odsTipoComprobante" runat="server" ValueField="ID_TIPO_COMPROB" TextField="NOMBRE_TIPO" ValueType="System.Int32" Width="170px" DropDownStyle="DropDownList">                                                               
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" ></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="N° Comprobante:" /></td>
                                                <td><dx:ASPxTextBox ID="txtNO_COMPROB" runat="server" Width="120px" MaxLength="10" HorizontalAlign="Right" >                                        
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                    </dx:ASPxTextBox>
                                                </td>  
                                                <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Fecha Comprobante:" /></td>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dteFECHA_COMPROB" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                        EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px"  >                                            
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxDateEdit> 
                                                </td>             
                                            </tr>          
                                            <tr>
                                                <td><dx:ASPxLabel id="ASPxLabel12" runat="server" Text="Condición de Compra:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxCONDICION_COMPRA" runat="server" ValueType="System.Int32" Width="170px" DropDownStyle="DropDownList" >
                                                        <Items>
                                                            <dx:ListEditItem Text="CREDITO" Value="1" />
                                                            <dx:ListEditItem Text="CONTADO" Value="2" />
                                                            <dx:ListEditItem Text="CONSIGNACION" Value="3" />
                                                        </Items>                                                        
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                        </table>
                                        </center>
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
                    <td width="280px"><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="Producto" /></td>
                    <td width="100px"><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Presentación" /></td>                    
                    <td width="100px" style="text-align:right"><dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="Cantidad" /></td>
                    <td width="100px" style="text-align:right"><dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="Precio Unitario" /></td>
                    <td width="120px" style="text-align:right"><dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="Valor" /></td>
                    <td width="20px"></td>
                </tr>
                <tr id="trPRODUCTO_AGRICOLA_DETA2" runat="server">                    
                    <td>
                        <dx:ASPxComboBox ID="cbxPRODUCTOdeta" AutoPostBack="true" runat="server" ValueType="System.Int32" ValueField="ID_PRODUCTO" DisplayFormatString="{0}"  TextField="NOMBRE_PRODUCTO" DropDownStyle="DropDown" Width="100%" >                                                    
                            <Columns>
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
                    <th colspan="6" >
                        <uc1:ucListaCCF_DETA id="ucListaCCF_DETA1" PermitirEditarNombreProducto="false" PermitirEditarPresentacion="false" PermitirEditarCantidad="false" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="false" PermitirEliminar="false"  runat="server"></uc1:ucListaCCF_DETA>                                    
                    </th>                                            
                </tr>
		        <tr>
                    <th colspan="6" align="right">                        
                        <table>
                            <tr>
                                <td></td>
                                <td></td>
                                <td><dx:ASPxLabel id="ASPxLabel13" runat="server" Text="SUB-TOTAL:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speSUB_TOTAL" runat="server" ClientInstanceName="speSUB_TOTALclient" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel id="ASPxLabel23" runat="server" Text="% Descuento:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speDESCTO_PORC" runat="server" AutoPostBack="true" DisplayFormatString="#,##0.00" Width="120px" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                                <td><dx:ASPxLabel id="ASPxLabel22" runat="server" Text="DESCUENTO:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speDESCTO_MONTO" runat="server" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td><dx:ASPxLabel id="ASPxLabel24" runat="server" Text="SUMAS:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speSUMAS" runat="server" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td><dx:ASPxLabel id="ASPxLabel16" runat="server" Text="IVA:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speIVA" runat="server" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td><dx:ASPxLabel id="ASPxLabel20" runat="server" Text="TOTAL:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speTOTAL" runat="server" ClientInstanceName="speTOTALclient" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                        </table>
                    </th>
                </tr>
        </table>   
        </td>
    </tr> 
</table>
</center>
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />
<dx:ASPxLabel ID="lblREFERENCIA_SALBODE" runat="server" Visible="false" />
<dx:ASPxLabel ID="lblREFERENCIA_SALBODE_SELECT" runat="server" Visible="false" />
<dx:ASPxHiddenField runat="server"  ID="hfvistaEntradaEnca" SyncWithServer="true" />   

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsProveedorAgricola" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorTIPO_PROVEEDOR" 
    TypeName="SISPACAL.BL.cPROVEEDOR_AGRICOLA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ES_PROVEE_VUELO" Type="Int32" />
        <asp:Parameter DefaultValue="1" Name="ES_CASA_COMER" Type="Int32" />
        <asp:Parameter DefaultValue="-1" Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCuentaFinan" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorCriterios" 
    TypeName="SISPACAL.BL.cCUENTA_FINAN">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="AgregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="APLICA_SOLIC_AGRICOLA" Type="Boolean" />
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


<dx:ASPxPopupControl ID="pcCCF_DETA_SALBODE" Theme="SoftOrange" runat="server" CloseAction="CloseButton" Modal="True" Width="800px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcCCF_DETA_SALBODE"
        HeaderText="Lista de Productos en Consignación entregados y pendientes de facturar" AllowDragging="True" PopupAnimationType="None">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">  
                            <table width="100%">
                                <tr>
                                    <td>
                                    <uc1:ucListaCCF_DETA_SALBODE id="ucListaCCF_DETA_SALBODE1" MostrarCheckVariaSeleccion="true" PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" runat="server" />
                                    </td> 
                                </tr>     
                                <tr>
                                    <td>
                                        <table cellpadding="5px">
                                            <tr>
                                                <td>                                        
                                                    <dx:ASPxButton ID="btnAceptarFact" Theme="SoftOrange" CausesValidation="false" AutoPostBack="true" runat="server" Text="Aceptar"></dx:ASPxButton>
                                                </td>
                                                <td>
                                                    <dx:ASPxButton ID="btnCancelarFact" Theme="SoftOrange" CausesValidation="false" runat="server" Text="Cancelar">
                                                        <ClientSideEvents Click="function(s,e){e.processOnServer=false;pcCCF_DETA_SALBODE.Hide();}" />
                                                    </dx:ASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>                       
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl>