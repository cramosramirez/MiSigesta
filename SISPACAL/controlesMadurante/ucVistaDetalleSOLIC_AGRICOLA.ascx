<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLIC_AGRICOLA.ascx.vb" Inherits="controles_ucVistaDetalleSOLIC_AGRICOLA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaSOLIC_AGRICOLA_LOTE" Src="~/controlesMadurante/ucListaSOLIC_AGRICOLA_LOTE.ascx" %>
<%@ Register tagprefix="uc1" tagname="ucListaSOLIC_AGRICOLA_PRODUCTO" Src="~/controlesMadurante/ucListaSOLIC_AGRICOLA_PRODUCTO.ascx" %>



<dx:ASPxCallbackPanel ID="cpVistaDetalleSOLIC_AGRICOLA" ClientInstanceName="cpVistaDetalleSOLIC_AGRICOLA" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">  
<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="ucVistaDetalleSOLIC_AGRICOLALayout" ClientInstanceName="ucVistaDetalleSOLIC_AGRICOLALayout" runat="server" Width="70%">
                <Items>
                    <dx:LayoutGroup ColCount="3" Name="lgSolicitudAgricolaA" Caption="Datos del Proveedor" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem Caption="N° Solicitud">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxTextBox ID="txtNUM_SOLICITUD" runat="server" ClientInstanceName="txtNUM_SOLICITUD" Width="170px" BackColor="WhiteSmoke">                               
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>  
                            <dx:LayoutItem Caption="Zafra:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2"  runat="server">
                                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem Caption="Id Solicitud" Visible="false">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <dx:ASPxTextBox ID="txtID_SOLICITUD" runat="server" ClientInstanceName="txtID_SOLICITUD" Width="170px" BackColor="WhiteSmoke">                               
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                            <dx:LayoutItem Caption="Concepto de Financiamiento" ColSpan="3">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                        <dx:ASPxComboBox ID="cbxTIPO_FINANCIAMIENTO" runat="server" ValueField="ID_CUENTA_FINAN" Font-Bold="true"   
                                            TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinan"  
                                            AutoPostBack="True">
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
                                                 <RequiredField ErrorText="Seleccione el Concepto de Financiamiento" IsRequired="True" />
                                        </ValidationSettings>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                            
                            <dx:LayoutItem Caption="Cod. Proveedor:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                        <dx:ASPxSpinEdit ID="txtCODIPROVEE" runat="server" ClientInstanceName="txtCODIPROVEE" AutoPostBack="true" Width="170px"  >
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Nombre del Productor:" ColSpan="2">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer17" runat="server">
                                        <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" ClientInstanceName="txtNOMBRE_PROVEEDOR" Width="100%" BackColor="WhiteSmoke">                               
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>           
                            <dx:LayoutItem Caption="Contrato:" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer   runat="server">
                                        <dx:ASPxComboBox ID="cbxContrato" runat="server" ValueField="CODICONTRATO" 
                                            TextField="NO_CONTRATO" ValueType="System.String" Width="170px" 
                                            AutoPostBack="True">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>  
                            <dx:LayoutItem Caption="Fecha Solicitud" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8"  runat="server">
                                        <dx:ASPxDateEdit ID="dteFECHA_SOLIC" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                            EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px" ClientEnabled="false"  >                                            
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxDateEdit>                                        
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem> 
                            <dx:LayoutItem Caption="NIT:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxTextBox ID="txtNIT" runat="server" ClientInstanceName="txtNIT" Width="170px">                                            
                                            <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" Mask="9999-999999-999-9" />
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" ErrorText="NIT no valido" SetFocusOnError="True">
                                                 <RequiredField ErrorText="NIT es obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem Caption="N° Registro Fiscal:" ColSpan="2">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer23" runat="server">
                                        <dx:ASPxTextBox ID="txtNRC" runat="server" ClientInstanceName="txtNRC" Width="120px" >    
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                           
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>            
                            <dx:LayoutItem Caption="Actividad">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer15" runat="server">
                                        <dx:ASPxTextBox ID="txtACTIVIDAD" ClientInstanceName="txtACTIVIDAD" runat="server" Width="100%" >                                        
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" ErrorText="Actividad no valido" SetFocusOnError="True">
                                                    <RequiredField ErrorText="Actividad es obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="ha Totales" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                                        <dx:ASPxSpinEdit ID="speMZ_TOTALES" runat="server" ClientInstanceName="speMZ_TOTALES" AutoPostBack="true" Width="120px"  >
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                            <SpinButtons ClientVisible="false"></SpinButtons>   
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                            <dx:LayoutItem Caption="Condición de Compra">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                                        <dx:ASPxComboBox ID="cbxCONDICION_COMPRA" AutoPostBack="true" runat="server" ValueType="System.Int32" Width="170px" DropDownStyle="DropDownList" >
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
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                            
                            
                            <dx:LayoutItem Caption="Estado" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer  runat="server">
                                        <dx:ASPxComboBox ID="cbxESTADO" ClientInstanceName="cbxESTADO" DataSourceID="odsSolicEstado" ValueField="ID_SOLIC_ESTADO" TextField="NOMBRE_ESTADO" runat="server" ValueType="System.Int32" Width="120px">                                                                           
                                            <DisabledStyle Font-Bold="True" BackColor="WhiteSmoke" ForeColor="Blue"></DisabledStyle>
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                          
                            <dx:LayoutItem Caption="Fecha Aplicación" Name="lyiFechaAplicacion">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7"  runat="server">
                                        <dx:ASPxDateEdit ID="dteFECHA_APLICACION" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                            EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="170px">                                            
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxDateEdit>                                        
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>   
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                            <dx:EmptyLayoutItem></dx:EmptyLayoutItem>

                            <dx:LayoutItem Caption="Factura a Nombre de:" Name="lyiFacturaNombre" >
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12"  runat="server">
                                        <dx:ASPxTextBox ID="txtCCF_NOMBRE" runat="server" Width="100%" MaxLength="100"  >                                                                                    
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
                                                <RequiredField ErrorText="Ingrese el nombre a facturar" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>                           
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>   
                            <dx:LayoutItem Caption="Lugar entrega:" Name="lyiLugarEntrega">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13"  runat="server">
                                        <dx:ASPxTextBox ID="txtLUGAR_ENTREGA" runat="server" Width="100%" MaxLength="200" >                                                                                    
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
                                                <RequiredField ErrorText="Ingrese el lugar de entrega" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>                                      
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem> 
                            <dx:LayoutItem Caption="Contacto:" Name="lyiContacto">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14"  runat="server">
                                        <dx:ASPxTextBox ID="txtCONTACTO" runat="server" Width="100%" MaxLength="100" >                                                                                    
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                           
                                        </dx:ASPxTextBox>                                   
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
<dx:ASPxLabel ID="lblREFERENCIA_LOTES" runat="server" Visible="false" />  
<dx:ASPxPageControl ID="ASPxPageControl1" ClientInstanceName="tabControl" runat="server" ActiveTabIndex="1" 
    Width="100%" >    
    <tabpages>
        <dx:TabPage Text="Lotes para aplicación de Producto">
            <contentcollection>
                <dx:ContentControl ID="ContentControl" runat="server">
                    <table width="100%">
                        <tr>
                            <td>
                                <dx:ASPxCheckBox ID="chkSelectTodosLotes" AutoPostBack="true" runat="server" Text="Marque para seleccionar todos los Lotes"  TextAlign="Right" ></dx:ASPxCheckBox>                                
                            </td>
                        </tr>
                        <tr>                            
                             <td>
                                <uc1:ucListaSOLIC_AGRICOLA_LOTE id="ucListaSOLIC_AGRICOLA_LOTE1" NombreGridCliente="ucListaSOLIC_AGRICOLA_LOTE1" PermitirFilaDeFiltro="true" PermitirFiltroEnEncabezado="false" TipoEdicion="0" TamanoPagina="10" PermitirEliminar="false" runat="server"></uc1:ucListaSOLIC_AGRICOLA_LOTE>
                            </td>
                        </tr>
                    </table>                    
                </dx:ContentControl>
            </contentcollection>
        </dx:TabPage>
        <dx:TabPage Text="Productos/Servicios">
            <contentcollection>
                <dx:ContentControl ID="ContentContro2" runat="server">
                        <table width="100%" >
                            <tr>
                                <td>
                                    <dx:ASPxFormLayout ID="fmlyProveedorVuelo"  runat="server" Width="100%">
                                        <Items>
                                            <dx:LayoutGroup ColCount="4" Name="lygProveedorVuelo" GroupBoxDecoration="None">
                                                <Items>
                                                    <dx:LayoutItem Caption="Empresa que realiza el vuelo">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                                                 <dx:ASPxComboBox ID="cbxPROVEEDOR_VUELO" AutoPostBack="true" DropDownStyle="DropDown" runat="server" ValueField="ID_PROVEE" TextField="NOMBRE" ValueType="System.Int32" Width="250px" >
                                                                 </dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    <dx:LayoutItem Caption="Piloto">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                                                <dx:ASPxTextBox ID="txtPILOTO" MaxLength="60" runat="server" ClientInstanceName="txtPILOTO" Width="200px">                               
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>   
                                                    <dx:LayoutItem Caption="Tipo">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                                                                <dx:ASPxComboBox ID="cbxMEDIO_APLICA" AutoPostBack="true" ClientInstanceName="cbxMEDIO_APLICA" runat="server" ValueType="System.String" Width="110px">                           
                                                                    <Items>
                                                                        <dx:ListEditItem Text="" Value="" />
                                                                        <dx:ListEditItem Text="AVION" Value="A" />
                                                                        <dx:ListEditItem Text="HELICOPTERO" Value="H" /> 
                                                                        <dx:ListEditItem Text="DRONE" Value="D" />
                                                                    </Items>                                                                          
                                                                </dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>   
                                                    <dx:LayoutItem Caption="Aeronave">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="txtDESCRIP_AERONAVE" runat="server" MaxLength="20" ClientInstanceName="txtDESCRIP_AERONAVE" Width="150px">                               
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>               
                                                </Items>
                                            </dx:LayoutGroup>                                            
                                        </Items>
                                    </dx:ASPxFormLayout>
                                    <table>
                                        <tr>
                                            <td>
                                                <table>
                                                    <tr id="trPRODUCTO_AGRICOLA_DETA1" runat="server">
                                                        <td width="220px"><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Proveedor" /></td>
                                                        <td width="380px"><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Producto" /></td>
                                                        <td width="100px"><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="Presentación" /></td>
                                                        <td width="100px"><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Dosis ha" /></td>
                                                        <td width="100px"><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Cantidad" /></td>
                                                        <td width="100px"><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Precio Unitario" /></td>
                                                        <td width="120px"><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="Sub-Total" /></td>
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
                                                            <dx:ASPxSpinEdit ID="speCANT_MZdeta" runat="server" DisplayFormatString="#,##0.00##" Width="100%"  SpinButtons-ShowIncrementButtons="false" HorizontalAlign="Right" >	
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
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <uc1:ucListaSOLIC_AGRICOLA_PRODUCTO id="ucListaSOLIC_AGRICOLA_PRODUCTO1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="true" PermitirEliminar="true"  runat="server"></uc1:ucListaSOLIC_AGRICOLA_PRODUCTO>                                    
                                            </td>                                            
                                        </tr>
                                    </table>                                                             
                                </td>
                            </tr>
                        </table>
                </dx:ContentControl>
            </contentcollection>
        </dx:TabPage>
    </tabpages>
</dx:ASPxPageControl>

<table width="100%" border="0">
    <tr>
        <td align="right" style="width:753px"></td>
        <td style="width:80px"></td>
        <td style="width:20px"></td>
        <td style="width:105px"></td>
        <td style="width:160px"></td>
        <td></td>
    </tr>
    <tr id="trTotalAgua" runat="server">
        <td align="right" style="width:753px">
            <dx:ASPxCheckBox ID="chkAplicaAGUA" AutoPostBack="true" TextAlign="Right" Text="AGUA:" runat="server" /> 
        </td>
        <td style="width:80px">
            <dx:ASPxSpinEdit ID="speAGUA_MZ" DisplayFormatString="#,##0.00" Enabled="false" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="80px" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>                                                
        </td>
        <td style="width:20px"><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="ha" /></td>
        <td style="width:105px">
            <dx:ASPxSpinEdit ID="speAGUA_PRECIO_UNIT" AutoPostBack="true" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="100%" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
            </dx:ASPxSpinEdit> 
        </td>
        <td style="width:160px">
            <dx:ASPxSpinEdit ID="speAGUA_TOTAL" DisplayFormatString="#,##0.00" Enabled="false" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="100%" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit> 
        </td>
        <td></td>
    </tr>
    <tr id="trTotalRiego" runat="server">  
        <td align="right"><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="SERVICIO DE RIEGO AEREO A:" /></td>  
        <td>
            <dx:ASPxSpinEdit ID="speRIEGO_MZ" DisplayFormatString="#,##0.00" AutoPostBack="true" ClientEnabled="false" ClientInstanceName="speRIEGO_MZ" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="80px" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="ha" /></td>
        <td>
            <dx:ASPxSpinEdit ID="speRIEGO_PRECIO_UNIT" AutoPostBack="true" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="100%" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
            </dx:ASPxSpinEdit> 
        </td>  
        <td>
            <dx:ASPxSpinEdit ID="speRIEGO_TOTAL" DisplayFormatString="#,##0.00" Enabled="false" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="100%" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit> 
        </td>   
        <td></td>                                  
    </tr> 
    <tr>  
        <td></td>  
        <td></td>
        <td></td>
        <td align="right"><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="SUBTOTAL" /></td> 
        <td align="right">
            <dx:ASPxSpinEdit ID="speSUB_TOTAL" DisplayFormatString="#,##0.00" ClientInstanceName="speSUB_TOTAL" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" Enabled="false" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="80px" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit></td>                                       
        <td></td>
    </tr>
    <tr>  
        <td></td>  
        <td></td>
        <td></td>
        <td align="right"><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="IVA" /></td> 
        <td align="right">
            <dx:ASPxSpinEdit ID="speIVA" DisplayFormatString="#,##0.00" ClientInstanceName="speIVA" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" Enabled="false" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="80px" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>
        </td>   
        <td></td>                                       
    </tr>
    <tr id="trFOVIAL_COTRANS" runat="server">  
        <td></td>  
        <td></td>
        <td></td>
        <td align="right"><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="FOVIAL + COTRANS" /></td> 
        <td align="right">
            <dx:ASPxSpinEdit ID="speFOVIAL_COTRANS" DisplayFormatString="#,##0.00" ClientInstanceName="speFOVIAL_COTRANS" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" Enabled="false" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="80px" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>
        </td>   
        <td></td>                                       
    </tr>
    <tr>  
        <td></td>  
        <td></td>
        <td></td>
        <td align="right"><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="TOTAL" Font-Bold="true" /></td>  
        <td align="right">
            <dx:ASPxSpinEdit ID="speTOTAL" DisplayFormatString="#,##0.00" ClientInstanceName="speTOTAL" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" Enabled="false" HorizontalAlign="Right" runat="server" Number="0" SpinButtons-ShowIncrementButtons="false" Width="80px" >
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>
        </td> 
        <td></td>                                      
    </tr>                                      
</table>
  </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>


<%--<asp:ObjectDataSource ID="odsProveedorAgricola" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorTIPO_PROVEEDOR" 
    TypeName="SISPACAL.BL.cPROVEEDOR_AGRICOLA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="ES_PROVEE_VUELO" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="ES_CASA_COMER" Type="Boolean" />
        <asp:Parameter DefaultValue="-1" Name="ID_CUENTA_FINAN" Type="Int32" />
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>--%>
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSolicEstado" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cSOLIC_AGRICOLA_ESTADO">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ESTADO" Name="asColumnaOrden" Type="String" />
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