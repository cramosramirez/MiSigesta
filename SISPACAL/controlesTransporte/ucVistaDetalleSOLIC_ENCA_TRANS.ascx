<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLIC_ENCA_TRANS.ascx.vb" Inherits="controles_ucVistaDetalleSOLIC_ENCA_TRANS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaSOLIC_PROD_TRANS" Src="~/controlesTransporte/ucListaSOLIC_PROD_TRANS.ascx" %>


<dx:ASPxCallbackPanel ID="cpVistaDetalleSOLIC_PROD_TRANS" ClientInstanceName="cpVistaDetalleSOLIC_PROD_TRANS" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">  
<center>
<table width="1100px" >
    <tr>
        <td align="center">
        <dx:ASPxFormLayout ID="ucVistaDetalleSOLIC_ENCA_TRANSLayout" ClientInstanceName="ucVistaDetalleSOLIC_ENCA_TRANSLayout" runat="server" Width="900px">
                <Items>
                    <dx:LayoutGroup ColCount="1" Name="lgSolicitudTransA" Caption="Información de la Solicitud" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <table>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxlabel1" runat="server" Text="N° Solicitud:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtNUM_SOLIC_ZAFRA" runat="server" Width="150px" BackColor="WhiteSmoke">                               
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                                <td><dx:ASPxLabel ID="aspxlabel2" runat="server" Text="Zafra:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="150px">
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxlabel3" runat="server" Text="Concepto de Financiamiento:" /></td>
                                                <th colspan="3" >
                                                    <dx:ASPxComboBox ID="cbxTIPO_FINANCIAMIENTO" runat="server" ValueField="ID_CUENTA_FINAN" Font-Bold="true"   
                                                        TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinan"  
                                                        AutoPostBack="True">
                                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
                                                             <RequiredField ErrorText="Seleccione el Concepto de Financiamiento" IsRequired="True" />
                                                    </ValidationSettings>
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxlabel4" runat="server" Text="Código Transportista:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="txtCODTRANSPORT" runat="server" AutoPostBack="true" Width="150px"  >
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                            <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                                        </ValidationSettings>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxSpinEdit>
                                                </td>
                                                <td><dx:ASPxLabel ID="aspxlabel5" runat="server" Text="Nombre Transportista:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtNOMBRE_TRANSPORTISTA" runat="server" Width="300px" BackColor="WhiteSmoke">                               
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxlabel11" runat="server" Text="Actividad:" /></td>
                                                <th colspan="3" >
                                                    <dx:ASPxTextBox ID="txtACTIVIDAD" runat="server" Width="100%" BackColor="WhiteSmoke">                               
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxlabel7" runat="server" Text="Contrato:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxCONTRATO_TRANS" runat="server" ValueField="ID_CONTRA_TRANS" 
                                                        TextField="NO_CONTRATO" ValueType="System.String" Width="150px" 
                                                        AutoPostBack="True">
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxlabel8" runat="server" Text="Fecha Solicitud:" /></td>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dteFECHA_SOLIC" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                        EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="150px" ClientEnabled="false"  >                                            
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxDateEdit>
                                                </td>
                                                <td><dx:ASPxLabel ID="aspxlabel9" runat="server" Text="Estado:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxESTADO_SOLIC" DataSourceID="odsSolicEstado" ValueField="ID_ESTADO_SOLIC" TextField="DESCRIP_ESTADO_SOLIC" runat="server" ValueType="System.Int32" Width="150px">                                                                           
                                                        <DisabledStyle Font-Bold="True" BackColor="WhiteSmoke" ForeColor="Blue"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="aspxlabel10" runat="server" Text="Condición de Compra:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxCONDICION_COMPRA" runat="server" ValueType="System.Int32" Width="150px" DropDownStyle="DropDownList" >
                                                        <Items>
                                                            <dx:ListEditItem Text="CREDITO" Value="1" />
                                                            <dx:ListEditItem Text="CONTADO" Value="2" />                                                            
                                                        </Items>
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
                                                                 <RequiredField ErrorText="Seleccione la Condición de Compra" IsRequired="True" />
                                                        </ValidationSettings>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
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
    <tr>
        <td>            
            <table>
                <tr id="trPRODUCTO_AGRICOLA_DETA1" runat="server">
                    <td width="220px"><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="Proveedor" /></td>
                    <td width="380px"><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="Producto" /></td>
                    <td width="100px"><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="Presentación" /></td>                                
                    <td width="100px"><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Cantidad" /></td>
                    <td width="100px"><dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="Precio Unitario" /></td>
                    <td width="120px"><dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="Sub-Total" /></td>
                    <td></td>
                </tr>
                <tr id="trPRODUCTO_AGRICOLA_DETA2" runat="server">
                    <td>
                        <dx:ASPxComboBox ID="cbxPROVEEDOR_AGRICOLAdeta" AutoPostBack="true" runat="server" ValueType="System.Int32" ValueField="ID_PROVEE" TextField="NOMBRE" Width="100%" >                                                    
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxComboBox>
                    </td>
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
                    <th colspan="7">
                        <uc1:ucListaSOLIC_PROD_TRANS id="ucListaSOLIC_PROD_TRANS1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="true" PermitirEliminar="true"  runat="server"></uc1:ucListaSOLIC_PROD_TRANS>                                    
                    </th>
                </tr>
                <tr>
                    <th colspan="7" align="right">
                        <table>
                            <tr>                                
                                <td><dx:ASPxLabel id="ASPxLabel15" runat="server" Text="SUB-TOTAL:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speSUB_TOTAL" runat="server" ClientInstanceName="speSUB_TOTALclient" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                            </tr>                            
                            <tr>                                
                                <td><dx:ASPxLabel id="ASPxLabel24" runat="server" Text="SUMAS:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speSUMAS" runat="server" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr id="trCESC" runat="server">                                
                                <td><dx:ASPxLabel id="ASPxLabel6" runat="server" Text="CESC:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speCESC" runat="server" AutoPostBack="true" ClientEnabled="false" DisplayFormatString="#,##0.00###" Width="120px" HorizontalAlign="Right" >	
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                        </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>                                
                                <td><dx:ASPxLabel id="ASPxLabel19" runat="server" Text="IVA:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speIVA" runat="server" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
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
             </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>

<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />  

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsCuentaFinan" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaParaSolicTransporte" 
    TypeName="SISPACAL.BL.cCUENTA_FINAN">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="AgregarVacio" Type="Boolean" />        
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSolicEstado" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cESTADO_SOLIC">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="DESCRIP_ESTADO_SOLIC" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>