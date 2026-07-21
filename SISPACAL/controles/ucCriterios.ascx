<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriterios.ascx.vb" Inherits="controles_ucCriterios" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<%@ Register TagPrefix="uc1" TagName="ucBusquedaProveedor" Src="~/controlesContrato/ucBusquedaProveedor.ascx" %>

<table>
    <tr id="trID_ZAFRA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="lblID_ZAFRA" runat="server">ZAFRA:</asp:Label></td>
        <td><cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA" runat="server" CssClass="DDLClassNormal" AutoPostBack="true"   
                     Width="120px"></cc1:ddlZAFRA></td>
        <td></td>
    </tr>
    <tr id="trID_CATORCENA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label7" runat="server">CATORCENA:</asp:Label></td>
        <td>
            <cc1:ddlCATORCENA_ZAFRA ID="ddlCATORCENA_ZAFRA1" runat="server" Width="120px" CssClass="DDLClassNormal">
            </cc1:ddlCATORCENA_ZAFRA>
        </td>
    </tr>           
    <tr id="trCORTE_CATORCENA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label24" runat="server">CATORCENA:</asp:Label></td>
        <td>
            <cc1:ddlCATORCENA_ZAFRA ID="ddlCORTE_CATORCENA_ZAFRA" runat="server" Width="120px" CssClass="DDLClassNormal">
            </cc1:ddlCATORCENA_ZAFRA>
        </td>
    </tr>     
     <tr id="trID_PLAN_CATORCENA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label12" runat="server">CATORCENA:</asp:Label></td>
        <td>            
            <cc1:ddlPLAN_CATORCENA ID="ddlPLAN_CATORCENA1" runat="server" Width="120px" CssClass="DDLClassNormal" AutoPostBack="True" >
            </cc1:ddlPLAN_CATORCENA>
        </td>
    </tr>    
    <tr id="trID_PLAN_SEMANAL" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label14" runat="server">SEMANA:</asp:Label></td>
        <td>
            <cc1:ddlPLAN_SEMANAL ID="ddlPLAN_SEMANAL1" runat="server" CssClass="DDLClassNormal">
            </cc1:ddlPLAN_SEMANAL>
        </td>
    </tr>    
    <tr id="trZONA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label13" runat="server">ZONA:</asp:Label></td>
        <td>                     
            <cc1:ddlZONAS ID="ddlZONAS1" runat="server" Width="120px" CssClass="DDLClassNormal">
            </cc1:ddlZONAS>
        </td>
    </tr>        
    <tr id="trFECHA_CORTE" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label1" runat="server">FECHA CORTE:</asp:Label></td>
        <td><asp:TextBox ID="txtFECHA_CORTE" CssClass="TextoIzquierda" runat="server" Width="120px"></asp:TextBox>             
                <cc2:MaskedEditExtender ID="txtFECHA_CORTE_MaskedEditExtender" runat="server" 
                    AutoComplete="False" Mask="99/99/9999" 
                    MaskType="Date"  TargetControlID="txtFECHA_CORTE" 
                    ClearMaskOnLostFocus="True" ClearTextOnInvalid="True" 
                    UserDateFormat="DayMonthYear">
                </cc2:MaskedEditExtender></td>
        <td></td>
    </tr>  
    <tr id="trFECHA_ENTRADA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label8" runat="server">FECHA ENTRADA:</asp:Label></td>
        <td><asp:TextBox ID="txtFECHA_ENTRADA" CssClass="TextoIzquierda" runat="server" Width="120px"></asp:TextBox>             
                <cc2:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                    AutoComplete="False" Mask="99/99/9999" 
                    MaskType="Date"  TargetControlID="txtFECHA_ENTRADA" 
                    ClearMaskOnLostFocus="True" ClearTextOnInvalid="True" 
                    UserDateFormat="DayMonthYear">
                </cc2:MaskedEditExtender></td>
        <td></td>
    </tr>  
    
    <tr id="trDIA_ZAFRA_CORTE" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label25" runat="server">DIA ZAFRA:</asp:Label></td>
        <td>            
            <cc1:ddlDIA_ZAFRA ID="ddlDIA_ZAFRA_CORTE" runat="server" Width="120px" CssClass="DDLClassNormal" AutoPostBack="True" >
            </cc1:ddlDIA_ZAFRA>
        </td>
    </tr>   
    
    <tr id="trRANGO_DIAS_ZAFRA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label34" runat="server">DIA INICIAL:</asp:Label></td>
        <td>            
            <cc1:ddlDIA_ZAFRA ID="ddlDIA_ZAFRA_INI" runat="server" Width="120px" CssClass="DDLClassNormal" >
            </cc1:ddlDIA_ZAFRA>
        </td>
        <td><asp:Label CssClass="Normal" id="Label35" runat="server">DIA FINAL:</asp:Label></td>
        <td>            
            <cc1:ddlDIA_ZAFRA ID="ddlDIA_ZAFRA_FIN" runat="server" Width="120px" CssClass="DDLClassNormal" >
            </cc1:ddlDIA_ZAFRA>
        </td>
    </tr>     

    <tr id="trRANGO_DIAS_ZAFRA_DESCRIP" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label39" runat="server">DIA INICIAL:</asp:Label></td>
        <td>            
            <cc1:ddlDIA_ZAFRA ID="ddlDIA_ZAFRA_A" runat="server" Width="140px" CssClass="DDLClassNormal" >
            </cc1:ddlDIA_ZAFRA>
        </td>
        <td><asp:Label CssClass="Normal" id="Label40" runat="server">DIA FINAL:</asp:Label></td>
        <td>            
            <cc1:ddlDIA_ZAFRA ID="ddlDIA_ZAFRA_B" runat="server" Width="140px" CssClass="DDLClassNormal" >
            </cc1:ddlDIA_ZAFRA>
        </td>
    </tr>  
      
     <tr id="trTIPO_PROVEEDOR" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label26" runat="server">TIPO DE PROVEEEDOR:</asp:Label></td>
        <td>
            <cc1:ddlTIPO_PROVEEDOR ID="ddlTIPO_PROVEEDOR1" runat="server" CssClass="DDLClassNormal" Width="120px" >
            </cc1:ddlTIPO_PROVEEDOR>
        </td>
        <td></td>
    </tr>
    <tr id="trPROVEEDOR_ROZA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label41" runat="server">PROVEEDOR ROZA:</asp:Label></td>
        <td>
            <cc1:ddlPROVEEDOR_ROZA ID="ddlPROVEEDOR_ROZA1" runat="server" CssClass="DDLClassNormal" Width="300px" >
            </cc1:ddlPROVEEDOR_ROZA>
        </td>
        <td></td>
    </tr>
     <tr id="trFECHA_INICIAL" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label21" runat="server">FECHA INICIAL:</asp:Label></td>
        <td><asp:TextBox ID="txtFECHA_INICIAL" CssClass="TextoIzquierda" runat="server" Width="120px"></asp:TextBox>             
                <cc2:MaskedEditExtender ID="MaskedEditExtender4" runat="server" 
                    AutoComplete="False" Mask="99/99/9999" 
                    MaskType="Date" TargetControlID="txtFECHA_INICIAL" 
                    ClearMaskOnLostFocus="True" ClearTextOnInvalid="True">
                </cc2:MaskedEditExtender></td>
        <td></td>
    </tr>    
    <tr id="trFECHA_FINAL" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label22" runat="server">FECHA FINAL:</asp:Label></td>
        <td><asp:TextBox ID="txtFECHA_FINAL" CssClass="TextoIzquierda" runat="server" Width="120px"></asp:TextBox>             
                <cc2:MaskedEditExtender ID="MaskedEditExtender5" runat="server" 
                    AutoComplete="False" Mask="99/99/9999" 
                    MaskType="Date" TargetControlID="txtFECHA_FINAL" 
                    ClearMaskOnLostFocus="True" ClearTextOnInvalid="True">
                </cc2:MaskedEditExtender></td>
        <td></td>
    </tr>    
     <tr id="trCODIGO_CLIENTE" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label32" runat="server">COD. CLIENTE:</asp:Label></td>
        <td><asp:TextBox CssClass="TextoDerecha" id="txtCODIGO" runat="server" Width="120px" /></td>
        <td></td>
    </tr>
    <tr id="trPLACA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label33" runat="server">PLACA:</asp:Label></td>
        <td><asp:TextBox CssClass="TextoDerecha" id="txtPLACA" runat="server" Width="120px" /></td>
        <td></td>
    </tr>
     <tr id="trFECHAS_EMISION_FACTURACION" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label30" runat="server">PERIODO APLICA A:</asp:Label></td>
        <td>
            <asp:RadioButtonList ID="rbtnFechasEmisionFacturacion" runat="server" 
                RepeatDirection="Horizontal">
                <asp:ListItem Value="1" Text="Emisión" Selected="true" />
                <asp:ListItem Value="2" Text="Facturación" />
            </asp:RadioButtonList>           
        </td>
        <td>
            <asp:Label CssClass="Normal" id="Label31" runat="server">FORMATO:</asp:Label>
            <asp:DropDownList ID="ddlFormatoCombustible" CssClass="DDLClassNormal" runat="server" Width="180px"></asp:DropDownList>
        </td>
    </tr>    
    <tr id="trFECHA_PROGRAMACION_CORTE" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="lblFECHA_PROGRAMACION_CORTE" runat="server">FECHA/HORA CORTE DE CATORCENA:</asp:Label></td>
        <td><asp:TextBox ID="txtFECHA_PROGRAMACION_CORTE" CssClass="TextoIzquierda" runat="server" Width="120px"></asp:TextBox>             
                <cc2:MaskedEditExtender ID="MaskedEditExtender6" runat="server" 
                    AcceptAMPM="True" AutoComplete="False" Mask="99/99/9999 99:99" 
                    MaskType="DateTime" TargetControlID="txtFECHA_PROGRAMACION_CORTE" 
                    ClearMaskOnLostFocus="True" ClearTextOnInvalid="True">
                </cc2:MaskedEditExtender></td>
        <td></td>
    </tr>   
   
    <tr id="trPRODUCTO" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label27" runat="server">PRODUCTOS EN ORDEN:</asp:Label></td>
        <td>
          <cc1:ddlPRODUCTO_COMBUSTIBLE ID="ddlPRODUCTO_COMBUSTIBLE1" runat="server" CssClass="DDLClassNormal" Width="120px"></cc1:ddlPRODUCTO_COMBUSTIBLE>            
        </td>
        <td></td>
    </tr>
    <tr id="trMOSTRAR_FAC_CCF" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label28" runat="server">MOSTRAR SOLO FAC/CCF:</asp:Label></td>
        <td>
          <asp:CheckBox ID="chkMostrarFAC_CCF" runat="server" Checked="false" />
        </td>
        <td></td>
    </tr>   
    <tr id="trFECHA_ENTRADA_INICIAL" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label15" runat="server">FECHA/HORA INICIAL:</asp:Label></td>
        <td><asp:TextBox ID="txtFECHA_ENTRADA_INICIAL" CssClass="TextoIzquierda" runat="server" Width="120px"></asp:TextBox>             
                <cc2:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                    AcceptAMPM="True" AutoComplete="False" Mask="99/99/9999 99:99" 
                    MaskType="DateTime" TargetControlID="txtFECHA_ENTRADA_INICIAL" 
                    ClearMaskOnLostFocus="True" ClearTextOnInvalid="True">
                </cc2:MaskedEditExtender></td>
        <td></td>
    </tr>    
    <tr id="trFECHA_ENTRADA_FINAL" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label16" runat="server">FECHA/HORA FINAL:</asp:Label></td>
        <td><asp:TextBox ID="txtFECHA_ENTRADA_FINAL" CssClass="TextoIzquierda" runat="server" Width="120px"></asp:TextBox>             
                <cc2:MaskedEditExtender ID="MaskedEditExtender3" runat="server" 
                    AcceptAMPM="True" AutoComplete="False" Mask="99/99/9999 99:99" 
                    MaskType="DateTime" TargetControlID="txtFECHA_ENTRADA_FINAL" 
                    ClearMaskOnLostFocus="True" ClearTextOnInvalid="True">
                </cc2:MaskedEditExtender></td>
        <td></td>
    </tr>    
    <tr id="trNROBOLETA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label2" runat="server">N° TACO:</asp:Label></td>
        <td><asp:TextBox CssClass="TextoDerecha" id="txtNROBOLETA" runat="server" Width="120px" /></td>
        <td></td>
    </tr>
    <tr id="trCOMPTENVIO" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label3" runat="server">N° ENVIO:</asp:Label></td>
        <td><asp:TextBox CssClass="TextoDerecha" id="txtCOMPTENVIO" runat="server" Width="120px" /></td>
        <td></td>
    </tr>
    <tr id="trCODIPROVEEDOR" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label4" runat="server">CODIGO PROVEEDOR:</asp:Label></td>
        <td><asp:TextBox CssClass="TextoDerecha" id="txtCODIPROVEEDOR" runat="server" Width="120px" />
            <dx:ASPxButton ID="btnBuscar" AutoPostBack="true" runat="server" Width="20px"   Text="">
                <Image IconID="find_find_16x16">
                </Image>
            </dx:ASPxButton>
        </td>
        <td><asp:Label CssClass="Normal" id="lblCODISOCIO" runat="server" Visible="False"> SOCIO:</asp:Label>
            <asp:TextBox id="txtCODISOCIO" runat="server" CssClass="TextoDerecha" Width="60px" Visible="False" /></td>       
    </tr>    
    <tr id="trCODICOOPERATIVA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label18" runat="server">CODIGO COOPERATIVA:</asp:Label></td>
        <td><asp:TextBox CssClass="TextoDerecha" id="txtCODICOOPERATIVA" runat="server" Width="120px" /></td>
        <td><asp:TextBox id="TextBox2" runat="server" CssClass="NormalTextBox"  
                    Width="250px" ReadOnly="True" Visible="False" /></td>
    </tr>    
    <tr id="trCODTRANSPORT" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label5" runat="server">CODIGO TRANSPORTISTA:</asp:Label></td>
        <td><asp:TextBox CssClass="TextoDerecha" id="txtCODTRANSPORT" runat="server" Width="120px" /></td>
        <td><asp:TextBox id="txtNOMBRE_TRANSPORTISTA" runat="server" CssClass="NormalTextBox"  
                    Width="250px" ReadOnly="True" Visible="False" /></td>
    </tr>
    <tr id="trCODIAGRON" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label6" runat="server">CODIGO AGRONOMO:</asp:Label></td>
        <td><asp:TextBox CssClass="TextoDerecha" id="txtCODIAGRON" runat="server" Width="120px" /></td>
        <td><asp:TextBox id="txtNOMBRE_AGRONOMO" runat="server" CssClass="NormalTextBox"  
                    Width="250px" ReadOnly="True" Visible="False" /></td>
    </tr>    
    <tr id="trID_TIPO_PLANILLA" runat="server" visible="false">        
        <td><asp:Label CssClass="Normal" id="Label9" runat="server">TIPO PLANILLA:</asp:Label></td>
        <td>
            <cc1:ddlTIPO_PLANILLA ID="ddlTIPO_PLANILLA1" runat="server" 
                CssClass="DDLClassNormal" Width="350px" AutoPostBack="true" >
            </cc1:ddlTIPO_PLANILLA></td>
        <td>
            <asp:RadioButtonList ID="rdbContribuyente" runat="server" CssClass="Normal"
                RepeatDirection="Horizontal">
                <asp:ListItem Value="True" Selected="True">Contribuyente</asp:ListItem>                
                <asp:ListItem Value="False">No contribuyente</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr id="trTIPO_PAGO" runat="server" visible="false">        
        <td><asp:Label CssClass="Normal" id="Label36" runat="server">TIPO PAGO:</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlTIPO_PAGO" runat="server" CssClass="DDLClassNormal" Width="350px" >  
                <asp:ListItem Text="[TODOS]" Value="-1" Selected="true"   />                 
                <asp:ListItem Text="PAGO CON CHEQUE" Value="0" />            
                <asp:ListItem Text="PAGO A CUENTA" Value="1" />      
            </asp:DropDownList>
        </td>        
    </tr>
    <tr id="trRANGO_COMPENSACION" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label23" runat="server">RANGO COMPENSACION:</asp:Label></td>
        <td>
            <cc1:ddlRANGO_COMPENSACION ID="ddlRANGO_COMPENSACION1" CssClass="DDLClassNormal" Width="350px" runat="server">
            </cc1:ddlRANGO_COMPENSACION> 
        </td>        
    </tr>
     <tr id="trTIPO_DOCUMENTO" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label20" runat="server">TIPO COMPROBANTE:</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlTipoDocumento"  CssClass="DDLClassNormal" runat="server" Width="280px">
            </asp:DropDownList>    
        </td>
    </tr>       
    <tr id="trNO_DOCUMENTO_RET_FAC_CCF" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label19" runat="server">N° DOCUMENTO INICIAL:</asp:Label></td>
        <td><asp:TextBox CssClass="TextoDerecha" id="txtNO_DOCUMENTO_INICIAL" runat="server" Width="120px" /></td>
        <td></td>
    </tr>   
    <tr id="trCODIPROVEEDOR_TRANSPORTISTA" runat="server" visible="false" >        
        <td><asp:Label CssClass="Normal" id="Label10" runat="server">CODIGO PROVEE/TRANSP:</asp:Label></td>
        <td><asp:TextBox CssClass="NormalUPPER" id="txtCODIPROVEEDOR_TRANSPORTISTA" runat="server" Width="120px" /></td>
        <td>&nbsp;</td>        
    </tr>
    <tr id="trNOMBRE_PROVEEDOR_TRANSPORTISTA" runat="server" visible="false" >        
        <td><asp:Label CssClass="Normal" id="Label11" runat="server">NOMBRE PROVEE/TRANSP:</asp:Label></td>
        <td><asp:TextBox CssClass="NormalUPPER" id="txtNOMBRE_PROVEEDOR_TRANSPORTISTA" runat="server" Width="200px" /></td>
        <td>&nbsp;</td>        
    </tr>  
    <tr id="trTIPO_TARIFA_CARGADORA" runat="server" visible="false" >        
        <td><asp:Label CssClass="Normal" id="Label29" runat="server">TIPO TARIFA:</asp:Label></td>
        <td><asp:DropDownList ID="ddlTipoTarifaCargadora" CssClass="DDLClassNormal" runat="server" Width="160px"></asp:DropDownList></td>
        <td>&nbsp;</td>        
    </tr>
    <tr id="trGRUPO_DESCUENTO" runat="server" visible="false" >        
        <td><asp:Label CssClass="Normal" id="Label37" runat="server">TIPO DESCUENTO:</asp:Label></td>
        <td><dx:ASPxComboBox ID="cbxGRUPO_DESCUENTOS" runat="server" DataSourceID="odsGrupoDescuentos" ValueField="ID_GRUPO_DESC" TextField="NOMBRE_GRUPO_DESC" Width="350px" ></dx:ASPxComboBox>   </td>
        <td>&nbsp;</td>        
    </tr>    
    <tr id="trES_ANTICIPO" runat="server" visible="false">
        <th colspan="3" align="left">
            <asp:RadioButtonList ID="rblTipoPlanilla" CssClass="Normal" runat="server" 
                RepeatDirection="Horizontal">
                <asp:ListItem Selected="True" Value="0">Planilla normal</asp:ListItem>
                <asp:ListItem Value="1">Anticipo</asp:ListItem>
                <asp:ListItem Value="2">Complemento Valor Final</asp:ListItem>
                <asp:ListItem Value="3">Incentivo</asp:ListItem>
            </asp:RadioButtonList>                     
        </th>      
    </tr>   
    <tr id="trORDENAMIENTO" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="lblOrdenamiento" runat="server">ORDEN POR:</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlCamposOrdenamiento" runat="server" CssClass="DDLClassNormal" runat="server" Width="120px">
            </asp:DropDownList>
        </td>
        <td><asp:DropDownList ID="ddlTipoOrden" runat="server" CssClass="DDLClassNormal" runat="server" Width="90px">
            </asp:DropDownList>
         </td>
    </tr>    
    <tr id="trCLASIFICACION" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="lblClasificacion" runat="server">CLASIFICAR POR:</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlClasificacion" runat="server" CssClass="DDLClassNormal" runat="server" Width="120px">
            </asp:DropDownList>
        </td>
        <td></td>
    </tr>    
     <tr id="trDETALLE_PAGINA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label17" runat="server">Detalle por página:</asp:Label></td>
        <td>
            <asp:CheckBox ID="chkDetallePagina" runat="server" Checked="false" />
        </td>
    </tr>   
    <tr id="trDETALLE_LA_CABANA" runat="server" visible="false">
        <td><asp:Label CssClass="Normal" id="Label38" runat="server">Detalle solo la Ing. La Cabaña:</asp:Label></td>
        <td>
            <asp:CheckBox ID="chkDetalleLaCabana" runat="server" Checked="false" />
        </td>
    </tr>
</table>

<asp:ObjectDataSource ID="odsGrupoDescuentos" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cGRUPO_DESCUENTOS">  
    <SelectParameters>        
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />   
        <asp:Parameter DefaultValue="NOMBRE_GRUPO_DESC" Name="asColumnaOrden" Type="String" />        
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />   
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


