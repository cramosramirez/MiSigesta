<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleORDEN_COMBUSTIBLE.ascx.vb" Inherits="controles_ucVistaDetalleORDEN_COMBUSTIBLE" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<script type = "text/javascript">
     function MostrarOrdenCombustible(valor) {
         window.open("../PlanCosecha/wfReportePlanCosechaModal.aspx?n=6&idcombus=" + valor, "_blank", "")
     }

</script>
<style type="text/css">
    .formato1
    {
        padding-right: 10px;
        margin-left: 80px;
    }
    .formato2
    {
        padding-right: 10px;
        margin-left: 80px;
        width: 170px;
    }
    div.centraTabla
    {
        font-size: small;     
        font-family: Tahoma;                   	
        text-align: center;
        padding-bottom: 15px; 
        padding-top: 10px;
        padding-left: 15px;
        padding-right: 15px 
    }

    div.centraTabla table {
        margin: 0 auto;
        text-align: left;
    }  
      .seccion
    {
        background-color: #003366;
        color: White;  
        font-weight: bold;
        border: 2px;      
        text-align: center;  
        height: 20px; 
    }
</style>
     <div class="ContenedorCampos"> 
         <table cellspacing="0" cellpadding="0" border="0">
            <tr>
                <td><asp:Label CssClass="Normal" id="lblID_ENVIO" runat="server">CORRELATIVO:</asp:Label></td>
                <td class="formato1">
                    <asp:TextBox CssClass="TextoDerecha" id="txtID_ORDEN_COMBUS" 
                        runat="server" Width="120px" AutoPostBack="True"></asp:Textbox></td>
                <td style="width:100px"><asp:Label CssClass="Normal" id="lblID_ZAFRA" runat="server">ZAFRA:</asp:Label></td>
                <td class="formato1"><cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA" runat="server" CssClass="DDLClassNormal"  
                         Width="104px"></cc1:ddlZAFRA></td>                
                <td></td>                      
                <td></td>
            </tr>
            <tr>
                <td><asp:Label CssClass="Normal" id="Label11" runat="server">PROVEEDOR COMBUSTIBLE:</asp:Label></td>
                <th colspan="3" class="formato1">
                    <cc1:ddlPROVEEDOR_COMBUSTIBLE ID="ddlPROVEEDOR_COMBUSTIBLE1" runat="server" CssClass="DDLClass" Width="100%" >
                    </cc1:ddlPROVEEDOR_COMBUSTIBLE>
                </th>
                <td></td>
                <td class="formato1"></td>               
            </tr>
            <tr>
                <td><asp:Label CssClass="Normal" id="Label7" runat="server">TIPO DE CLIENTE:</asp:Label></td>
                <td>
                    <cc1:ddlTIPO_PROVEEDOR ID="ddlTIPO_PROVEEDOR1" runat="server" CssClass="DDLClass" Width="124px" AutoPostBack="true" />                    
                </td>
                <td></td>
                <th colspan="3"></th>
            </tr>
            <tr>        
                <td><asp:Label CssClass="Normal" id="Label2" runat="server">FACTURAR A:</asp:Label></td>
                <td><asp:TextBox CssClass="TextoNormalDerecha"  
                        id="txtCODIGO" runat="server" AutoPostBack="true" Width="120px" ></asp:TextBox>
                    <cc2:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" 
                         runat="server" TargetControlID="txtCODIGO" 
                         WatermarkText="Codigo" WatermarkCssClass="watermarked">
                     </cc2:TextBoxWatermarkExtender>
                    <asp:TextBox CssClass="TextoNormalDerecha"  
                        id="txtSOCIO" runat="server" AutoPostBack="true" Width="40px" Visible="false"></asp:TextBox>
                    <cc2:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" 
                         runat="server" TargetControlID="txtSOCIO" 
                         WatermarkText="Socio" WatermarkCssClass="watermarked">
                     </cc2:TextBoxWatermarkExtender>
                </td>
                <th colspan="2" class="formato1">
                    <asp:TextBox id="txtNOMBRE_CLIENTE" runat="server" CssClass="NormalTextBox" 
                        Width="100%" ReadOnly="True"></asp:TextBox></th>
                <td><asp:Label CssClass="Normal" id="Label4" runat="server">PLACA:</asp:Label></td>
                <td class="formato1">
                     <asp:TextBox id="txtPLACA_VEHIC" runat="server" CssClass="TextoNormalIzquierdaMayus" AutoPostBack="true"  
                        Width="100%" ></asp:TextBox>  
                    <cc2:DropDownExtender ID="txtPLACA_VEHIC_DropDownExtender"  
                        runat="server" DynamicServicePath="" Enabled="True" DropDownControlID="panelPLACAS"    
                        TargetControlID="txtPLACA_VEHIC">
                    </cc2:DropDownExtender>                
                    <asp:Panel ID="panelPLACAS" runat="server" Width="130px" >
                        <asp:ListBox ID="lstTRANSPORTE" runat="server" CssClass="DDLClass" 
                            DataTextField="PLACA" DataValueField="PLACA"   
                            AutoPostBack="true" Width="130px"></asp:ListBox>                    
                    </asp:Panel>                                           
                </td>                           
            </tr>   
            <tr>
                <td><asp:Label CssClass="Normal" id="Label8" runat="server">SECCION:</asp:Label></td>
                <th colspan="5" >
                    <cc1:ddlSECCION ID="ddlSECCION1" runat="server" CssClass="DDLClass" Width="100%" />                    
                </th>               
            </tr>  
            <tr>
                <td><asp:Label CssClass="Normal" id="LabelNIT" runat="server">NIT:</asp:Label></td>
                <td class="formato1"><asp:TextBox id="txtNIT" runat="server" CssClass="TextoNormalIzquierdaMayus" 
                        Width="120px"></asp:TextBox> 
                    <cc2:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" Mask="9999-999999-999-9"
                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                        TargetControlID="txtLICENCIA">
                    </cc2:MaskedEditExtender>
                </td>
                <td><asp:Label CssClass="Normal" id="LabelNrc" runat="server">NRC:</asp:Label></td>
                <td><asp:TextBox id="txtNRC" runat="server" CssClass="TextoNormalIzquierdaMayus" Width="120px"></asp:TextBox> </td>
                <td></td>
                <td></td>
            </tr>       
            <tr>            
                <td>
			        <asp:Label CssClass="Normal" id="lblMOTORISTA" runat="server">MOTORISTA:</asp:Label>
                </td>               
                <th colspan="3" class="formato1" >                                 
                     <dx:ASPxComboBox ID="cbxMOTORISTA" runat="server" AutoPostBack="true" DataSourceID="odsMotoristas"  BackColor="#d9ebfd"  ValueField="ID_MOTORISTA" TextField="NOMBRE" MaxLength="120" ValueType="System.Int32" Width="100%" TextFormatString="{0} {1}"  DropDownStyle="DropDown" IncrementalFilteringMode="Contains" >                                                                                                        
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                            
                                <Columns>                                                        
                                <dx:ListBoxColumn Caption="Nombres" FieldName="NOMBRES" Width="130px" />                                                            
                                <dx:ListBoxColumn Caption="Apellidos" FieldName="APELLIDOS" Width="140px" />                                                        
                                <dx:ListBoxColumn Caption="DUI" FieldName="DUI" Width="80px" />
                                <dx:ListBoxColumn Caption="Licencia" FieldName="LICENCIA" Width="140px" />   
                            </Columns>
                      </dx:ASPxComboBox>
                </th>                        
                <td><asp:Label CssClass="Normal" id="lblDUI" runat="server">DUI:</asp:Label></td>
                <td class="formato1">
                    <asp:TextBox id="txtDUI" runat="server" CssClass="TextoNormalIzquierdaMayus" 
                        Width="100%"></asp:TextBox> 
                    <cc2:MaskedEditExtender ID="txtDUI_MaskedEditExtender" runat="server" 
                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True"                         
                        Mask="99999999-9" TargetControlID="txtDUI">
                    </cc2:MaskedEditExtender>
                </td>            
            </tr>             
            <tr>
                <td><asp:Label CssClass="Normal" id="Label1" runat="server">LICENCIA:</asp:Label></td>
                <td class="formato1"><asp:TextBox id="txtLICENCIA" runat="server" CssClass="TextoNormalIzquierdaMayus" 
                        Width="120px"></asp:TextBox> 
                    <cc2:MaskedEditExtender ID="txtLICENCIA_MaskedEditExtender" runat="server" 
                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" Mask="9999-999999-999-9"
                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                        TargetControlID="txtLICENCIA">
                    </cc2:MaskedEditExtender>
                </td>
                <th colspan="4"></th>                
            </tr>
            <tr>
                <td><asp:Label CssClass="Normal" id="Label9" runat="server">OBSERVACION:</asp:Label></td>
                <th colspan="5" >                    
                    <asp:TextBox ID="txtOBSERVACION" TextMode="MultiLine" CssClass="DDLClass" Width="100%" Height="50px" runat="server"></asp:TextBox>                    
                </th> 
            </tr>       
         </table> 
     </div>
     <div id="divFactura" runat="server" visible="false">    
        <div class="ContenedorCampos"> 
            <table cellspacing="0" cellpadding="0" border="0">
                <tr>
                    <td><asp:Label CssClass="Normal" id="Label5" runat="server">CCF/FACTURA EMITIDA:</asp:Label></td>
                    <td class="formato1"><asp:TextBox id="txtNO_FACTURA_CCF" runat="server" CssClass="TextoNormalIzquierdaMayus" 
                            Width="100px"></asp:TextBox>                     
                    </td>
                    <td><asp:Label CssClass="Normal" id="Label10" runat="server">FECHA DESPACHO:</asp:Label></td>
                    <td><asp:TextBox ID="txtFECHA_DESPACHO" CssClass="TextoNormalIzquierdaMayus" runat="server" Width="100px"></asp:TextBox>             
                    <cc2:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                        AutoComplete="False" Mask="99/99/9999" 
                        MaskType="Date"  TargetControlID="txtFECHA_DESPACHO" 
                        ClearMaskOnLostFocus="True" ClearTextOnInvalid="True" 
                        UserDateFormat="DayMonthYear">
                    </cc2:MaskedEditExtender></td>
                    <td><asp:Label CssClass="Normal" id="Label6" runat="server">TOTAL FACTURA:</asp:Label></td>
                    <td class="formato1"><asp:TextBox ID="txtTOTAL" CssClass="TextoNormalIzquierdaMayus" runat="server" Width="100px" /></td> 
                </tr>
            </table>
        </div>
    </div>
    <div id="div1">        
        <div class="ContenedorCampos">
              <table>
                 <tr>
                    <td style="text-align:center"><asp:Label CssClass="Normal" id="Label12" runat="server">PRODUCTO</asp:Label></td>
                    <td style="text-align:center"><asp:Label CssClass="Normal" id="Label13" runat="server">CANTIDAD</asp:Label></td>
                    <td style="text-align:center"><asp:Label CssClass="Normal" id="Label14" runat="server">PRECIO UNITARIO</asp:Label></td>
                    <td style="text-align:center"><asp:Label CssClass="Normal" id="Label15" runat="server">TOTAL</asp:Label></td>
                    <td style="text-align:center"></td>
                 </tr>
                 <tr>
                    <td> 
                    <asp:HiddenField ID="hdfID_ORDEN_COMBUSTIBLE_PROD" runat="server" Value="" />
                    <asp:TextBox id="txtID_PRODUCTO" runat="server" CssClass="TextoNormalIzquierdaMayus" AutoPostBack="true"  
                                Width="280px" ></asp:TextBox>  
                            <cc2:DropDownExtender ID="DropDownExtender1" 
                                runat="server" DynamicServicePath="" Enabled="True" DropDownControlID="panelPRODUCTOS"    
                                TargetControlID="txtID_PRODUCTO">
                            </cc2:DropDownExtender>                
                            <asp:Panel ID="panelPRODUCTOS" runat="server" Width="280px" Height="150px" >
                                <asp:ListBox ID="lstPRODUCTOS" runat="server" CssClass="DDLClass" 
                                        DataTextField="NOMBRE_PRODUCTO" DataValueField="NOMBRE_PRODUCTO" Height="150px"   
                                        AutoPostBack="true" Width="280px"></asp:ListBox>                    
                            </asp:Panel>   
                    </td>
                    <td><asp:TextBox id="txtCANTIDAD" runat="server" CssClass="TextoNormalDerecha" AutoPostBack="true"  
                                Width="100px" ></asp:TextBox>  
                    </td>
                    <td><asp:TextBox id="txtPRECIO_UNITARIO" runat="server" CssClass="TextoNormalDerecha" AutoPostBack="true" 
                                Width="100px" ></asp:TextBox>
                    </td>
                    <td> <asp:Label ID="lblTOTAL" CssClass="TextoNormalDerecha" runat="server" 
                            Text="0.00" BackColor="White" Width="100px"  BorderStyle="Inset"></asp:Label>
                    </td>   
                    <td><asp:Button ID="btnAgregar" runat="server" Text="Agregar" /></td>                 
                </tr>
            </table>
        </div>        
    </div>
    <div>
        <div class="ContenedorCampos">
            <asp:Panel ID="Panel1" runat="server"  Height="110px" 
                ScrollBars="Auto" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px">                    
                <asp:GridView ID="grdDetalle" runat="server" AutoGenerateColumns="False"
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
                    CellPadding="4" EnableModelValidation="True" Font-Names="Arial" Font-Size="11px"
                    DataKeyNames="ID_ORDEN_COMBUSTIBLE_PROD">
                    <Columns>                                                                                                                                                                         
                        <asp:BoundField DataField="ID_PRODUCTO" Visible="false" HeaderText="" ReadOnly="True" /> 
                        <asp:BoundField DataField="PRODUCTO" HeaderText="Producto" 
                            HeaderStyle-Width="300px" ReadOnly="True" >
                        <HeaderStyle Width="300px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="CANTIDAD" ItemStyle-HorizontalAlign="Right" 
                            HeaderStyle-Width="100px" HeaderText="Cantidad" ReadOnly="True" >
                        <HeaderStyle Width="100px" />
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="PRECIO_VENTA" ItemStyle-HorizontalAlign="Right" 
                            HeaderStyle-Width="100px" HeaderText="Precio Unitario" ReadOnly="True" >
                        <HeaderStyle Width="100px" />
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TOTAL" ItemStyle-HorizontalAlign="Right" 
                            HeaderText="Total" HeaderStyle-Width="100px" ReadOnly="True" >                  
                        <HeaderStyle Width="100px" />
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:TemplateField>
                          <ItemTemplate>           
                            <asp:ImageButton ID="imgbEditar" runat="server"  
                              CommandName="Editar" ImageUrl="~/imagenes/pencil.png"
                              CommandArgument='<%# Eval("ID_ORDEN_COMBUSTIBLE_PROD") %>' />
                          </ItemTemplate> 
                        </asp:TemplateField>                      
                        <asp:TemplateField>
                          <ItemTemplate>           
                            <asp:ImageButton ID="imgbEliminar" runat="server"  
                              CommandName="Eliminar" ImageUrl="~/imagenes/eliminar.png"
                              CommandArgument='<%# Eval("ID_ORDEN_COMBUSTIBLE_PROD") %>' />
                          </ItemTemplate> 
                        </asp:TemplateField>                        
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                </asp:GridView>
            </asp:Panel>                 
        </div>
    </div>
    <div id="divAnulacion" runat="server" visible="false">        
        <div class="ContenedorCampos"> 
            <table cellspacing="0" cellpadding="0" border="0">
                <tr>
                    <td><asp:Label CssClass="Normal" id="Label3" runat="server">MOTIVO ANULACIÓN:</asp:Label></td>     
                </tr>
                <tr>
                    <td class="formato1"><asp:TextBox CssClass="TextoNormalIzquierdaMayus" id="txtMOTIVO_ANULACION" 
                        runat="server" Width="349px" MaxLength="1000" Height="59px" 
                        TextMode="MultiLine"></asp:TextBox>                     
                    </td>
                </tr>
            </table>
        </div>
    </div>
<asp:ObjectDataSource ID="odsMotoristas" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaActivos" 
    TypeName="SISPACAL.BL.cMOTORISTA">      
</asp:ObjectDataSource>

