<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleANALISIS.ascx.vb" Inherits="controles_ucVistaDetalleANALISIS" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<style type="text/css">
    .formato1
    {
        padding-right: 10px;
        margin-left: 80px;
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
        background-color: #000000;
        color: White;  
        font-weight: bold;
        border: 2px;      
        text-align: center;  
        height: 20px; 
    }
</style>
<div class="centraTabla">    
    <table cellspacing="0" cellpadding="0" border="0">
         <tr>
            <td><asp:Label CssClass="Normal" id="Label27" runat="server">ID:</asp:Label></td>
            <td class="formato1"><asp:TextBox CssClass="TextoDerecha" id="txtID_ANALISIS" 
                    runat="server" ReadOnly="True" Width="120px"></asp:Textbox>
                <asp:TextBox CssClass="TextoDerecha" id="txtID_ENVIO" 
                    runat="server" ReadOnly="True" Width="120px" Visible="False"></asp:Textbox></td>
            <td><asp:Label CssClass="Normal" id="lblID_ZAFRA" runat="server">ZAFRA:</asp:Label></td>
            <td class="formato1"><cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA" AutoPostBack="true" runat="server" CssClass="DDLClassNormal"  
                     Width="104px"></cc1:ddlZAFRA></td>
            <td><asp:Label  id="lblID_CATORCENA" CssClass="Normal" runat="server">CATORCENA:</asp:Label></td>
            <td class="formato1"><asp:TextBox CssClass="TextoDerecha" id="txtCATORCENA_ZAFRA" ReadOnly="True" runat="server" Width="100px" /></td>
            <td><asp:Label id="lblDIAZAFRA" CssClass="Normal" runat="server">DIA ZAFRA:</asp:Label></td>
            <td class="formato1"><asp:TextBox CssClass="TextoDerecha" id="txtDIAZAFRA" ReadOnly="True" runat="server" Width="100px"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="Label23" runat="server">N° TACO:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtNROBOLETA" AutoPostBack="true" 
                    runat="server" Width="120px" TabIndex="0"  /></td>
            <th colspan="7"></th>
        </tr>
        <tr>
            <th colspan="2"><div class="ContenedorCampos"><asp:Label CssClass="NormalBold" id="Label21" runat="server">LECTURA APARATOS</asp:Label></div></th>            
            <th colspan="2"><div class="ContenedorCampos"><asp:Label CssClass="NormalBold" id="Label24" runat="server">ANALISIS DE DEXTRANA</asp:Label></div></th>            
            <th colspan="5"><div class="ContenedorCampos"><asp:Label CssClass="NormalBold" id="Label25" runat="server">ANALISIS DE MATERIA EXTRAÑA</asp:Label></div></th>                  
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="Label1" runat="server">PESO BAGAZO:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtBAGAZO_BRUTO" AutoPostBack="true" runat="server" 
                    Width="70px" TabIndex="1" /></td>
            <td><asp:Label CssClass="Normal" id="Label5" runat="server">ABSORBANCIA:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtABSORVANCIA" runat="server" 
                    Width="70px" /></td>
            <td><asp:Label CssClass="Normal" id="Label3" runat="server">ANALISTA:</asp:Label></td>
            <th colspan="4"><asp:TextBox CssClass="TextoNormalIzquierdaMayus" id="txtANALISTA" 
                    runat="server" Width="100%" MaxLength="100" TabIndex="7" /></th>            
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="Label4" runat="server">PESO TORTA:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtBAGAZO_NETO" runat="server" AutoPostBack="true" 
                    Width="70px" TabIndex="2" /></td>
            <td><asp:Label CssClass="Normal" id="Label2" runat="server">DEXTRANA (PPM):</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtDEXTRANA" runat="server" 
                    Width="70px" /></td>
            <td><asp:Label CssClass="Normal" id="Label6" runat="server">PESO TOTAL MUESTRA:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtLBS_MUESTRA" runat="server" AutoPostBack="true"
                    Width="70px" TabIndex="8" /></td>
            <td style="text-align:center"><asp:Label CssClass="Normal" id="Label22" runat="server">%</asp:Label></td>
            <td><asp:Label CssClass="Normal" id="Label8" runat="server">ACIDEZ:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtACIDEZ" runat="server" AutoPostBack="true"
                    Width="70px" TabIndex="17" /></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td><asp:Label CssClass="Normal" id="Label9" runat="server">LBS. PUNTAS TIERNAS:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtLBS_PUNTAS_TIERNA" AutoPostBack="true"
                    runat="server" Width="70px" TabIndex="9" /></td>
            <td><asp:TextBox CssClass="NormalTextBoxDerecha" id="txtPORC_PUNTAS_TIERNA" runat="server" 
                    Width="70px" /></td>
            <td><asp:Label CssClass="Normal" id="Label12" runat="server">REDUCTORES:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtREDUCTORES" runat="server" AutoPostBack="true"
                    Width="70px" TabIndex="18" /></td>
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="Label10" runat="server">BRIX:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtBRIX" runat="server" AutoPostBack="true"
                    Width="70px" TabIndex="4" /></td>
            <td></td>
            <td></td>
            <td><asp:Label CssClass="Normal" id="Label11" runat="server">LBS. CAÑA SECA Y HUECA:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtLBS_CANA_SECA" runat="server" AutoPostBack="true"
                    Width="70px"  TabIndex="10"/></td>
            <td><asp:TextBox CssClass="NormalTextBoxDerecha" id="txtPORC_CANA_SECA" runat="server" 
                    Width="70px" /></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="Label13" runat="server">PH:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtPH" runat="server" AutoPostBack="true"
                    Width="70px" TabIndex="5" /></td>
            <td></td>
            <td></td>
            <td><asp:Label CssClass="Normal" id="Label14" runat="server">LBS. MAMONES NO MOLEDEROS:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtLBS_MAMONES" runat="server" AutoPostBack="true"
                    Width="70px"  TabIndex="11"/></td>
            <td><asp:TextBox CssClass="NormalTextBoxDerecha" id="txtPORC_MAMONES" runat="server" 
                    Width="70px" /></td>
            <td></td>
            <td></td>           
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td><asp:Label CssClass="Normal" id="Label16" runat="server">LBS. BAJERA:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtLBS_BAJERA" runat="server" AutoPostBack="true"
                    Width="70px" TabIndex="12" /></td>
            <td><asp:TextBox CssClass="NormalTextBoxDerecha" id="txtPORC_BAJERA" runat="server" 
                    Width="70px" /></td>
            <td></td>
            <td></td>           
        </tr>
         <tr>
            <td><asp:Label CssClass="Normal" id="Label36" runat="server">POL LECTURA:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtPOL_LECTURA" runat="server" AutoPostBack="true"
                    Width="70px" TabIndex="3" /></td>
            <td></td>
            <td></td>
            <td><asp:Label CssClass="Normal" id="Label15" runat="server">LBS. TIERRA Y RAICES:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtLBS_TIERRA_RAICES" AutoPostBack="true"
                    runat="server" Width="70px" TabIndex="13"/></td>
            <td><asp:TextBox CssClass="NormalTextBoxDerecha" id="txtPORC_TIERRA_RAICES" runat="server" 
                    Width="70px" /></td>
            <td></td>
            <td></td>           
        </tr>
         <tr>
            <td><asp:Label CssClass="Normal" id="Label7" runat="server">POL AJUSTADO:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtPOL" runat="server" AutoPostBack="true"
                    Width="70px" TabIndex="3" /></td>
            <td></td>
            <td></td>
            <td><asp:Label CssClass="Normal" id="Label17" runat="server">LBS. DE PIEDRA:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtLBS_PIEDRA" runat="server" AutoPostBack="true"
                    Width="70px" TabIndex="14" /></td>
            <td><asp:TextBox CssClass="NormalTextBoxDerecha" id="txtPORC_PIEDRA" runat="server" 
                    Width="70px" /></td>
            <td></td>
            <td></td>           
        </tr>
         <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td><asp:Label CssClass="Normal" id="Label18" runat="server">LBS. CAÑA LIMPIA:</asp:Label></td>
            <td><asp:TextBox CssClass="TextoNormalDerecha" id="txtLBS_CANA_LIMPIA" AutoPostBack="true"
                    runat="server" Width="70px" TabIndex="15" /></td>
            <td><asp:TextBox CssClass="NormalTextBoxDerecha" id="txtPORC_CANA_LIMPIA" runat="server" 
                    Width="70px" /></td>
            <td></td>
            <td></td>           
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td><asp:Label CssClass="Normal" id="Label19" runat="server">% MATERIA EXTRAÑA:</asp:Label></td>
            <th colspan="2"><asp:TextBox CssClass="NormalTextBoxDerecha" 
                    id="txtPORC_MATERIA_EXTRA" runat="server" Width="100%" /></th>            
            <td></td>
            <td></td>           
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td><asp:Label CssClass="Normal" id="Label20" runat="server">OBSERVACION:</asp:Label></td>
            <th colspan="4"><asp:TextBox CssClass="TextoNormalIzquierdaMayus" id="txtOBSERVACION" 
                    runat="server" Width="100%" Height="50px"  MaxLength="500" TextMode="MultiLine" TabIndex="16"/></th>                       
        </tr>
    </table>

    <table id="tblRESULTADO_FORMULAS"  cellspacing="0" cellpadding="0" border="0" width="100%" runat="server" visible="false">
        <tr>
            <th colspan="10"><div class="ContenedorCampos"><asp:Label CssClass="NormalBold" id="Label26" runat="server">RESULTADO FORMULAS</asp:Label></div></th> 
        </tr>
        <tr>
            <td><asp:Label CssClass="Normal" id="Label28" runat="server">Fibra caña:</asp:Label></td>
            <td><asp:Label CssClass="TextoNormalDerecha" id="lblFIBRA_CANA" runat="server" Width="100px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" /></td>
            <td><asp:Label CssClass="Normal" id="Label29" runat="server">Jugo Abs % caña:</asp:Label></td>
            <td><asp:Label CssClass="TextoNormalDerecha" id="lblJUGO_CANA" runat="server" Width="100px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" /></td>
            <td><asp:Label CssClass="Normal" id="Label30" runat="server">Pol caña:</asp:Label></td>
            <td><asp:Label CssClass="TextoNormalDerecha" id="lblPOL_CANA" runat="server" Width="100px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" /></td>
            <td><asp:Label CssClass="Normal" id="Label31" runat="server">Pureza jugo:</asp:Label></td>
            <td><asp:Label CssClass="TextoNormalDerecha" id="lblPUREZA_JUGO" runat="server" Width="100px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" /></td>
            <td><asp:Label CssClass="Normal" id="Label32" runat="server">Pureza azucar:</asp:Label></td>
            <td><asp:Label CssClass="TextoNormalDerecha" id="lblPUREZA_AZUCAR" runat="server" Width="100px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" /></td>            
        </tr>
        <tr>    
            <td><asp:Label CssClass="Normal" id="Label33" runat="server">SJM:</asp:Label></td>
            <td><asp:Label CssClass="TextoNormalDerecha" id="lblSJM" runat="server" Width="100px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" /></td>
            <td><asp:Label CssClass="Normal" id="Label34" runat="server">Humedad:</asp:Label></td>
            <td><asp:Label CssClass="TextoNormalDerecha" id="lblHUMEDAD" runat="server" Width="100px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" /></td>
            <td><asp:Label CssClass="Normal" id="Label35" runat="server">Azucar Reduct.:</asp:Label></td>
            <td><asp:Label CssClass="TextoNormalDerecha" id="lblAZUCAR_REDUCTORES" runat="server" Width="100px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" /></td>
            <td><asp:Label CssClass="Normal" id="lblEtiqRENDIA_CALC1" runat="server">Rend 100%:</asp:Label></td>
            <td><asp:Label CssClass="TextoNormalDerecha" id="lblRENDIA_CALC1" runat="server" Width="100px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" /></td>
            <td><asp:Label CssClass="Normal" id="lblEtiqRENDIA_CALC2" runat="server">Rend 85%:</asp:Label></td>
            <td><asp:Label CssClass="TextoNormalDerecha" id="lblRENDIA_CALC2" runat="server" Width="100px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" /></td>            
        </tr>
    </table>

    <table> 
        <tr>
            <td>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_LEE_BAGAZO_BRUTO" 
                runat="server" Width="100px" MaxLength="100" Visible="False"></asp:TextBox>
            <asp:TextBox id="txtFECHA_LEE_BAGAZO_BRUTO" runat="server" Width="80px" 
                CssClass="TextoNormalCentrado" Visible="False"></asp:TextBox>
            <asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_LEE_BAGAZO_TARA" 
                runat="server" Width="100px" MaxLength="100" Visible="False"></asp:TextBox>
            <asp:TextBox id="txtFECHA_LEE_BAGAZO_TARA" runat="server" Width="80px" 
                CssClass="TextoNormalCentrado" Visible="False"></asp:TextBox>
            <asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_LEE_POL" 
                runat="server" Width="100px" MaxLength="100" Visible="False"></asp:TextBox>
            <asp:TextBox id="txtFECHA_LEE_POL" runat="server" Width="80px" 
                CssClass="TextoNormalCentrado" Visible="False"></asp:TextBox>
            <asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_LEE_BRIX" 
                runat="server" Width="100px" MaxLength="100" Visible="False"></asp:TextBox>
            <asp:TextBox id="txtFECHA_LEE_BRIX" runat="server" Width="80px" 
                CssClass="TextoNormalCentrado" Visible="False"></asp:TextBox>
            <asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CREA" 
                runat="server" Width="100px" MaxLength="100" Visible="False"></asp:TextBox>
            <asp:TextBox id="txtFECHA_CREA" runat="server" Width="80px" 
                CssClass="TextoNormalCentrado" Visible="False"></asp:TextBox>
            </td>            
        </tr>      				
    </table> 
</div>


