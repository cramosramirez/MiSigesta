<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleORDEN_COMPRA_AGRI.ascx.vb" Inherits="controles_ucVistaDetalleORDEN_COMPRA_AGRI" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaORDEN_DETA_AGRI" Src="~/controlesFinanciero/ucListaORDEN_DETA_AGRI.ascx" %>

<dx:ASPxCallbackPanel ID="cpVistaDetalleORDEN_COMPRA_AGRI" ClientInstanceName="cpVistaDetalleORDEN_COMPRA_AGRI" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">  
<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="ucVistaDetalleORDEN_COMPRA_AGRILayout" ClientInstanceName="ucVistaDetalleORDEN_COMPRA_AGRILayout" runat="server" Width="1000px">
                <Items>
                    <dx:LayoutGroup ColCount="1" Name="lgMembresiaGremial" Caption="Información de Orden de Compra" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <center>
                                        <table>
                                            <tr id="trId" runat="server" visible="false">
                                                <td><dx:ASPxLabel id="ASPxLabel1" runat="server" Text="Id orden:" /></td>
                                                <td><dx:ASPxTextBox id="txtID_ORDEN" runat="server" Width="170px" /></td>
                                            </tr>                               
                                            <tr>
                                                <td><dx:ASPxLabel id="ASPxLabel21" runat="server" Text="Zafra:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px">
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td><dx:ASPxLabel id="ASPxLabel2" runat="server" Text="N° Orden:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtCODI_ORDEN" runat="server" Width="170px">	
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                                                                                 
			                                        </dx:ASPxTextBox>
                                                </td>
                                                <td><dx:ASPxLabel id="ASPxLabel4" runat="server" Text="Fecha Orden:" /></td>
                                                <td style="text-align:left" >
                                                    <dx:ASPxDateEdit ID="dteFECHA" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                        EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="170px" ClientEnabled="false"  >                                            
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxDateEdit>    
                                                </td>
                                            </tr>
                                            <tr> 
                                                <td><dx:ASPxLabel id="ASPxLabel5" runat="server" Text="Proveedor Producto:" /></td>     
                                                <th colspan="3" >
                                                    <dx:ASPxComboBox ID="cbxPROVEEDOR_AGRICOLA" AutoPostBack="true" runat="server" ValueType="System.Int32" DataSourceID="odsProveedorAgricola" ValueField="ID_PROVEE" TextField="NOMBRE" Width="100%" >                                                    
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </th>    
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
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel id="ASPxLabel9" runat="server" Text="NIT:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtNIT" runat="server" Width="170px">                                                       
                                                        <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" Mask="9999-999999-999-9" />                                                       
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                                 <td><dx:ASPxLabel id="ASPxLabel10" runat="server" Text="NRC:" /></td>
                                                <td style="text-align:left">
                                                    <dx:ASPxTextBox ID="txtNRC" runat="server" ClientInstanceName="txtNRC" Width="170px" >    
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                           
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel id="ASPxLabel11" runat="server" Text="Giro/Actividad:" /></td>
                                                <th colspan="3" >
                                                    <dx:ASPxTextBox ID="txtACTIVIDAD" ClientInstanceName="txtACTIVIDAD" runat="server" Width="100%" >                                        
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" ErrorText="Actividad no valido" SetFocusOnError="True">
                                                                <RequiredField ErrorText="Actividad es obligatorio" IsRequired="True" />
                                                        </ValidationSettings>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </th>
                                            </tr>
                                            <tr id="trSolicitudAgri" runat="server">                                                                                                                                       
                                                <td><dx:ASPxLabel id="ASPxLabel3" runat="server" Text="N° Solicitud:" /></td>
                                                <td style="text-align:left">
                                                    <dx:ASPxSpinEdit ID="speNUM_SOLICITUD" runat="server" Width="170px" NumberType="Integer">
			                                            <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			                                                <RequiredField ErrorText="Campo No orden es requerido" IsRequired="True" />
			                                            </ValidationSettings>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        <SpinButtons ShowIncrementButtons="false" /> 
			                                        </dx:ASPxSpinEdit>
                                                </td>                                                
                                                <td></td>
                                                <td></td>
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
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
                                                                 <RequiredField ErrorText="Seleccione la Condición de Compra" IsRequired="True" />
                                                        </ValidationSettings>
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
                        <uc1:ucListaORDEN_DETA_AGRI id="ucListaORDEN_DETA_AGRI1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="true" PermitirEliminar="true"  runat="server"></uc1:ucListaORDEN_DETA_AGRI>                                    
                    </th>                                            
                </tr>
		        <tr>
                    <th colspan="6" align="right">                        
                        <table>
                            <tr>
                                <td><dx:ASPxLabel id="ASPxLabel13" runat="server" Text="SUB-TOTAL:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speSUB_TOTAL" runat="server" ClientInstanceName="speSUB_TOTALclient" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel id="ASPxLabel16" runat="server" Text="IVA:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speIVA" runat="server" ClientInstanceName="speSUB_IVAclient" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
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
<dx:ASPxHiddenField runat="server"  ID="hfvistaEntradaEnca" SyncWithServer="true" />   
        
              </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>                      


<asp:ObjectDataSource ID="odsProveedorAgricola" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cPROVEEDOR_AGRICOLA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

