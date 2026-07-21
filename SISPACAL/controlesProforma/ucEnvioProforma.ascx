<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucEnvioProforma.ascx.vb" Inherits="controlesProforma_ucEnvioProforma" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaLOTES" Src="~/controlesContrato/ucListaLOTES.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTROL_ROZA_SALDO" Src="~/controlesProforma/ucListaCONTROL_ROZA_SALDO.ascx" %>

<style type="text/css">  
       .tipoTransporte
            { 
                padding-left: 15px;  
            } 
        .tipoCana
            {                
                padding-left: 18px; 
            }
        .centro
            {                
                text-align: center;
            }   
 </style> 



<dx:ASPxCallbackPanel ID="cpINVENTARIO_ROZA" ClientInstanceName="cpINVENTARIO_ROZA" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent20" runat="server">   
<center>
<table cellpadding="0" cellspacing="1"> 
    <tr>
        <td><dx:ASPxLabel ID="Label101" runat="server" Text="Zafra:" /></td>        
        <td style="width:150px">
            <dx:ASPxComboBox ID="cbxZAFRA" HorizontalAlign="Right" Font-Bold="true" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100px" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>        
        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Catorcena:" /></td>        
        <td style="width:150px">
            <dx:ASPxTextBox ID="txtCATORCENA_ZAFRA" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxTextBox>
        </td>        
        <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Día Zafra:" /></td>        
        <td style="width:150px">
            <dx:ASPxTextBox ID="txtDIAZAFRA" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100%">
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxTextBox>
        </td>           
    </tr>
    <tr>  
        <td><dx:ASPxLabel ID="ASPxLabel28" runat="server" Text="Técnico Zona:" /></td>  
        <th colspan="5">
            <dx:ASPxTextBox ID="txtTECNICO_ZONA" runat="server" Width="100%" >
                <DisabledStyle BackColor="WhiteSmoke" Font-Bold="true" ForeColor="Black"></DisabledStyle>
            </dx:ASPxTextBox>
        </th>      
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="lblProforma" runat="server" Text="N° PROFORMA:" /></td>        
        <td>
            <dx:ASPxSpinEdit ID="txtNOPROFORMA" AutoPostBack="true" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>
        </td>        
        <td><dx:ASPxLabel ID="lblTaco" runat="server" Text="N° TACO:" /></td>        
        <td>
            <dx:ASPxSpinEdit ID="txtNROBOLETA" AutoPostBack="true" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>
        </td>        
        <td><dx:ASPxLabel ID="lblComprobante" runat="server" Text="N° COMPROBANTE:" /></td>        
        <td>
            <dx:ASPxSpinEdit ID="txtCOMPTENVIO" AutoPostBack="true" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>
        </td>   
        <td>
            <dx:ASPxTextBox ID="txtCODICONTRATO" runat="server" Width="100px" Visible="false" >                                        
            </dx:ASPxTextBox>
        </td>       
    </tr>    
</table>
</center>
<table width="100%" >
    <tr id="trEsticana" runat="server" >
        <td align="center" >
        <table>
            <tr>
            <td style="padding-left:20px">
            <dx:ASPxLabel runat="server" ID="ASPxLabel14" Text="Esticaña:" Theme="Office2003Olive"  />
            </td>
            <td>
            <dx:ASPxSpinEdit ID="txtESTICANA" Theme="Office2003Olive" runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                                            SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>
            </td>
            <td>
            <dx:ASPxLabel runat="server" ID="ASPxLabel25" Text="Roza ejecutada:" Theme="Office2003Olive"  />
            </td>
            <td>
            <dx:ASPxSpinEdit ID="txtROZA_EJECUTADA" Theme="Office2003Olive" runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                                            SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>
            </td>
            <td>
        <dx:ASPxLabel runat="server" ID="ASPxLabel26" Text="Esticaña menos Roza Ejecutada:" Theme="Office2003Olive"  />
            </td>
            <td>
            <dx:ASPxSpinEdit ID="txtDIF_ESTICANA_ROZA" Theme="Office2003Olive" 
                    runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                                            SpinButtons-ShowIncrementButtons="false" 
                    Number="0" DisplayFormatString="#,##0.00">
                <SpinButtons ShowIncrementButtons="False"></SpinButtons>    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxSpinEdit>
            </td>
            </tr>
        </table>
        </td>
    </tr>
    <tr>
        <td align="center" style="padding-left:120px; padding-right:120px">
            <uc1:ucListaCONTROL_ROZA_SALDO id="ucListaCONTROL_ROZA_SALDO1" VerENTRADAS="false" VerSALIDAS="false" TamanoPagina="4" MostrarCheckUnaSeleccion="true" PermitirEditarInline="false" PermitirEliminar="false" PermitirEliminarInline="false" runat="server" PermitirEditar="false" />
        </td>        
    </tr>
    <tr id="trOBSERVA_ANUL1" runat="server" >
        <td style="padding-left:120px; padding-right:120px">
           <dx:ASPxLabel runat="server" ID="ASPxLabel27" Text="MOTIVO DE ANULACIÓN DE PROFORMA:" ForeColor="Red" Font-Bold="true"  />
        </td>
    </tr>
    <tr id="trOBSERVA_ANUL11" runat="server" >
        <td style="padding-left:120px; padding-right:120px">
            <dx:ASPxComboBox ID="cbxMOTIVO_ANULACION_PROFORMA" Font-Bold="true" DataSourceID="odsMotivoAnulacionProforma" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" AutoPostBack="true" runat="server" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO" Width="260px" >                                                                                           
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trOBSERVA_ANUL2" runat="server">
        <td align="center" style="padding-left:120px; padding-right:120px">
            <dx:ASPxMemo ID="txtOBSERVA_ANUL" MaxLength="300" runat="server" Width="100%"  Height="60px">
                 <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxMemo>
        </td>
    </tr>
    <tr>
        <td align="center">
            
                                            <table border="0" >
                                               <tr>
                                                    <td style="width:120px"></td>                                                    
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>
                                                    <td style="width:120px"></td>
                                                    <td></td>
                                                    <td></td>                                                    
                                                    <td style="width:100px"></td>                                                    
                                                    <td></td>                                                    
                                               </tr>
                                               <tr>
                                                    <td>
                                                        <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="CONTRATO"></dx:ASPxLabel>
                                                    </td>
                                                    <td>
                                                        <dx:ASPxSpinEdit ID="txtNOCONTRATO" AutoPostBack="true" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxSpinEdit>
                                                    </td>
                                                    <td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="CODIGO:"></dx:ASPxLabel></td>
                                                    <th colspan="7">
                                                            <table border="0px" width="100%">
                                                                <tr>                                                                    
                                                                    <td style="width:70px">
                                                                        <dx:ASPxTextBox ID="txtCODIPROVEE" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="70px">
                                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                        </dx:ASPxTextBox>
                                                                    </td>
                                                                    <td style="width:50px">
                                                                        <dx:ASPxTextBox ID="txtCODISOCIO" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="50px">
                                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                        </dx:ASPxTextBox>
                                                                    </td>
                                                                    <td style="width:50px">
                                                                        <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="PROVEEDOR:"></dx:ASPxLabel>
                                                                    </td>
                                                                    <td>
                                                                        <dx:ASPxTextBox ID="txtNOMPROVEEDOR" Font-Bold="true" runat="server" Width="100%">
                                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                        </dx:ASPxTextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                    </th>                                                  
                                               </tr>
                                               <tr>
                                                   <td><dx:ASPxLabel ID="ASPxLabel23" runat="server" Text="HACIENDA"></dx:ASPxLabel></td>
                                                   <th colspan="9">
                                                    <dx:ASPxTextBox ID="txtHACIENDA" Font-Bold="true" runat="server" Width="100%">
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                 </th>
                                               </tr>
                                               <tr>
                                                 <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="CODI. LOTE"></dx:ASPxLabel></td>
                                                 <td><dx:ASPxTextBox ID="txtCODILOTE" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                     </dx:ASPxTextBox>
                                                 </td>
                                                 <td><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="LOTE:"></dx:ASPxLabel></td>
                                                 <th colspan="7">
                                                    <dx:ASPxTextBox ID="txtNOMLOTE" Font-Bold="true" runat="server" Width="100%">
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                 </th>                                                 
                                               </tr>
                                               <tr>
                                                 <td><dx:ASPxLabel ID="ASPxLabel31" runat="server" Text="PORCION"></dx:ASPxLabel></td>                                                 
                                                 <th colspan="9">
                                                    <dx:ASPxTextBox ID="txtSUBLOTE" Font-Bold="true" runat="server" Width="100%">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                 </th>    
                                               </tr>
                                               <tr>
                                                    <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="FORMA COSECHA:"></dx:ASPxLabel></td>
                                                    <th colspan="3">
                                                        <dx:ASPxComboBox ID="cbxID_TIPO_CANA" Font-Bold="true" DataSourceID="odsTipoCana" DropDownStyle="DropDownList" AutoPostBack="true" runat="server" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO" Width="260px" >                                                                                           
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxComboBox>
                                                    </th> 
                                                    <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="TIPO QUEMA:"></dx:ASPxLabel></td>
                                                    <th colspan="3">
                                                        <dx:ASPxRadioButtonList ID="rblTIPO_QUEMA" runat="server" 
                                                            ValueType="System.Int32" RepeatDirection="Horizontal" Border-BorderStyle="None" >
                                                            <Items>
                                                                <dx:ListEditItem Text="Programada" Value="1" />
                                                                <dx:ListEditItem Text="No programada" Value="2" />                                                
                                                                <dx:ListEditItem Text="Caña Verde" Value="3" />                                                                 
                                                            </Items>

<Border BorderStyle="None"></Border>

                                                            <DisabledStyle ForeColor="Black" />                                                             
                                                        </dx:ASPxRadioButtonList>
                                                    </th>
                                                    <td><dx:ASPxLabel ID="lblDisponible" runat="server" Text="Dispo.(t):" /></td>
                                                    <td>
                                                        <dx:ASPxSpinEdit ID="txtDISPONIBLE" runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="130px" 
                                                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black" 
                                                            SpinButtons-ShowIncrementButtons="false" Number="0" ClientEnabled="false"  >
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxSpinEdit>
                                                    </td>                                                    
                                               </tr>
                                               <tr>
                                                  <td><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="TIPO ROZA:"></dx:ASPxLabel></td>
                                                  <th colspan="3">
                                                        <dx:ASPxComboBox ID="cbxID_TIPO_ROZA" Font-Bold="true" DropDownStyle="DropDownList" AutoPostBack="true" runat="server" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO"  Width="100%">                                                                                               
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxComboBox>
                                                  </th>
                                                  <td><dx:ASPxCheckBox ID="chkVerTodosProveedoresRoza" AutoPostBack="true" TextAlign="Left" Text="FRENTE ROZA:(Ver todos)" runat="server"><DisabledStyle ForeColor="Black" /></dx:ASPxCheckBox></td>
                                                  <th colspan="5">                                                       
                                                        <dx:ASPxComboBox ID="cbxID_PROVEEDOR_ROZA" runat="server" Width="100%" Font-Bold="true" 
                                                        ValueField="ID_PROVEEDOR_ROZA" TextField="NOMBRE_PROVEEDOR_ROZA"   
                                                        ValueType="System.Int32" DropDownStyle="DropDownList" 
                                                        IncrementalFilteringMode="Contains" >  
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                                                                            
                                                        </dx:ASPxComboBox>                                    
                                                  </th>
                                               </tr>
                                               <tr>
                                                 <td><dx:ASPxLabel ID="lblTIPO_CARGA" runat="server" Text="TIPO CARGA:"></dx:ASPxLabel></td>
                                                 <th colspan="4">
                                                    <dx:ASPxComboBox ID="cbxID_TIPO_ALZA" Font-Bold="true" AutoPostBack="true" runat="server" Width="100%" DropDownStyle="DropDownList" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO">                                                                                                               
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
                                                    </dx:ASPxComboBox>
                                                 </th>
                                                 <td></td>
                                                 <td></td>
                                                 <td></td>
                                                 <td></td>
                                                 <td></td>
                                               </tr>
                                               <tr>
                                                  <td><dx:ASPxLabel ID="lblCARGADORA" runat="server" Text="CARGADORA:"></dx:ASPxLabel></td>
                                                  <th colspan="4">
                                                        <dx:ASPxComboBox ID="cbxCARGADORA" Font-Bold="true" AutoPostBack="true" runat="server" Width="100%" DropDownStyle="DropDownList" ValueType="System.Int32" ValueField="ID_CARGADORA" TextField="NOMBRE" TextFormatString="{0} - {1}">
                                                            <Columns>                                                        
                                                                <dx:ListBoxColumn Caption="Codigo" FieldName="ID_CARGADORA" Width="100px" />                                                            
                                                                <dx:ListBoxColumn Caption="Nombre" FieldName="NOMBRE" Width="300px" />                                                        
                                                            </Columns>  
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                        </dx:ASPxComboBox>
                                                  </th>
                                                  <td><dx:ASPxLabel ID="lblOPERADOR" runat="server" Text="OPERADOR:"></dx:ASPxLabel></td>
                                                  <th colspan="4">
                                                        <dx:ASPxComboBox ID="cbxCARGADOR" runat="server"  Font-Bold="true" 
                                                            ValueField="ID_CARGADOR" TextField="NOMBRE_CARGADOR" Width="100%"    
                                                            ValueType="System.Int32" DropDownStyle="DropDownList" TextFormatString="{0} - {1}"
                                                            IncrementalFilteringMode="Contains" >   
                                                             <Columns>                                                        
                                                                <dx:ListBoxColumn Caption="Codigo" FieldName="ID_CARGADOR" Width="100px" />                                                            
                                                                <dx:ListBoxColumn Caption="Nombre" FieldName="NOMBRE_CARGADOR" Width="300px" />                                                        
                                                            </Columns>   
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                                                                           
                                                        </dx:ASPxComboBox>  
                                                  </th>
                                               </tr>
                                               <tr>
                                                   <td><dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="COD. MOTORISTA:"></dx:ASPxLabel></td>
                                                   <td>
                                                        <dx:ASPxSpinEdit ID="speID_MOTORISTA_VEHI" AutoPostBack="true" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
                                                       <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                       <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                       </dx:ASPxSpinEdit>
                                                    </td>
                                               </tr>
                                               <tr>
                                                    <td><dx:ASPxLabel ID="ASPxLabel20" runat="server" Text="COD. TRANSPORTE:"></dx:ASPxLabel></td>
                                                    <td>
                                                        <dx:ASPxSpinEdit ID="txtCODTRANSPORT" AutoPostBack="true" HorizontalAlign="Right" Font-Bold="true" runat="server" Width="100px">
                                                       <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                       <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                       </dx:ASPxSpinEdit>
                                                    </td>
                                                    <td><dx:ASPxLabel ID="ASPxLabel21" runat="server" Text="TRANSPORTISTA:"></dx:ASPxLabel></td>
                                                    <th colspan="5">
                                                        <dx:ASPxTextBox ID="txtNOMBRE_TRANSPORTISTA" Font-Bold="true" runat="server" Width="100%">
                                                         <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxTextBox>
                                                    </th>
                                                    <th colspan="2">
                                                        <dx:ASPxRadioButtonList ID="rblTRANS_PROPIEDAD" runat="server" 
                                                            ValueType="System.Int32" ItemSpacing="10px" RepeatDirection="Horizontal" Border-BorderStyle="None" >
                                                            <Items>
                                                                <dx:ListEditItem Text="Productor" Value="1" />
                                                                <dx:ListEditItem Text="Particular" Value="2" />                                                                                                                
                                                            </Items>                                                                                                                                 

<Border BorderStyle="None"></Border>
                                                        </dx:ASPxRadioButtonList>                                                        
                                                    </th>                                                    
                                               </tr>
                                               <tr>
                                                    <td><dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="PLACA:"></dx:ASPxLabel></td>
                                                    <td>
                                                        <dx:ASPxComboBox ID="cbxPLACAVEHIC" AutoPostBack="true" runat="server" Width="100px" ClientInstanceName="cbxPLACAVEHIC"
                                                            HorizontalAlign="Right" ValueField="ID_TRANSPORTE" TextField="PLACA" 
                                                            ValueType="System.Int32" DropDownStyle="DropDownList" Font-Bold="true"
                                                            IncrementalFilteringMode="Contains" >                                                                                                                                                    
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            <ClientSideEvents ValueChanged="function(s,e){hfucEnvioProforma.Set('PLACAVEHIC',cbxPLACAVEHIC.GetText())}" />
                                                        </dx:ASPxComboBox>
                                                    </td>
                                                    <td><dx:ASPxCheckBox ID="chkVerTodosMotoristas" AutoPostBack="true" TextAlign="Left" Text="MOTORISTA: (Ver todos)" runat="server" ><DisabledStyle ForeColor="Black" /></dx:ASPxCheckBox></td>
                                                    <th colspan="5">                                                      
                                                        <dx:ASPxComboBox ID="cbxMOTORISTA" ClientInstanceName="cbxMOTORISTA" runat="server" EnableCallbackMode="true" Font-Bold="true" ValueField="ID_MOTORISTA" TextField="NOMBRE" MaxLength="120" ValueType="System.Int32" Width="100%" TextFormatString="{0} {1}"  DropDownStyle="DropDown" IncrementalFilteringMode="Contains" >                                                                                                        
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                            
                                                                <Columns>                                                        
                                                                <dx:ListBoxColumn Caption="Nombres" FieldName="NOMBRES" Width="130px" />                                                            
                                                                <dx:ListBoxColumn Caption="Apellidos" FieldName="APELLIDOS" Width="140px" />                                                        
                                                                <dx:ListBoxColumn Caption="DUI" FieldName="DUI" Width="80px" />
                                                                <dx:ListBoxColumn Caption="Licencia" FieldName="LICENCIA" Width="140px" />   
                                                            </Columns>
                                                            <ClientSideEvents ValueChanged="function(s,e){hfucEnvioProforma.Set('ID_MOTORISTA',cbxMOTORISTA.GetValue())}" />
                                                        </dx:ASPxComboBox>
                                                    </th>
                                                    <td><dx:ASPxLabel ID="ASPxLabel24" runat="server" Text="TIPO TRANS.:"></dx:ASPxLabel></td>
                                                    <td>
                                                         <dx:ASPxComboBox ID="cbxTIPO_TRANS" DataSourceID="odsTipoTransporte" ClientInstanceName="cbxTIPO_TRANS" runat="server" Font-Bold="true" Width="130px" DropDownStyle="DropDownList" ValueType="System.Int32" ValueField="ID_TIPOTRANS" ClientEnabled="false" TextField="NOMBRE">                                           
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
                                                            <ClientSideEvents ValueChanged="function(s,e){hfucEnvioProforma.Set('ID_TIPOVEHIC',cbxTIPO_TRANS.GetValue())}" />
                                                         </dx:ASPxComboBox>
                                                    </td>
                                               </tr>
                                               <tr>
                                                  <th colspan="10">
                                                        <table width="100%" cellspacing="0" cellpadding="2" style="border-top: 1px solid #8BA8BC">
                                                            <tr>                                          
                                                                <td align="center">
                                                                    <table cellspacing="0" cellpadding="2" style="border: 1px solid #8BA8BC; padding:4px">                                                                                                                            
                                                                        <tr>
                                                                            <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="QUEMA" /></td>
                                                                            <td style="padding-right:3px"><dx:ASPxDateEdit ID="dteFECHA_QUEMA" ClientInstanceName="dteFECHA_QUEMA" Font-Bold="true" runat="server" HorizontalAlign="Right" 
                                                                                DisplayFormatString="dd/MM/yyyy hh:mm tt" EditFormat="Custom" UseMaskBehavior="True" AllowNull="true" AllowUserInput="TRUE" 
                                                                                EditFormatString="dd/MM/yyyy hh:mm tt" Width="190px">
                                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                                </dx:ASPxDateEdit>
                                                                            </td>
                                                                            <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="CORTE" /></td>
                                                                            <td style="padding-right:3px"><dx:ASPxDateEdit ID="dteFECHA_CORTE" Font-Bold="true" runat="server" HorizontalAlign="Right" 
                                                                                DisplayFormatString="dd/MM/yyyy hh:mm tt" EditFormat="Custom" UseMaskBehavior="True" 
                                                                                EditFormatString="dd/MM/yyyy hh:mm tt" Width="190px">                                                                
                                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                                </dx:ASPxDateEdit>
                                                                             </td>
                                                                             <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="CARGADO" /></td>
                                                                            <td style="padding-right:3px"><dx:ASPxDateEdit ID="dteFECHA_CARGA" Font-Bold="true" runat="server" HorizontalAlign="Right" 
                                                                                DisplayFormatString="dd/MM/yyyy hh:mm tt" EditFormat="Custom" UseMaskBehavior="True" 
                                                                                EditFormatString="dd/MM/yyyy hh:mm tt" Width="190px">
                                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                                </dx:ASPxDateEdit>
                                                                             </td>
                                                                             <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="INGRESO JIBOA" /></td>
                                                                            <td style="padding-right:3px"><dx:ASPxDateEdit ID="dteFECHA_PATIO" Font-Bold="true" runat="server" HorizontalAlign="Right" 
                                                                                DisplayFormatString="dd/MM/yyyy hh:mm tt" EditFormat="Custom" UseMaskBehavior="True" 
                                                                                EditFormatString="dd/MM/yyyy hh:mm tt" Width="190px">
                                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                                </dx:ASPxDateEdit></td>
                                                                        </tr>                                                                       
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                            </table>                                                        
                                                  </th>
                                               </tr>   
                                               <tr id="trFCAT" runat="server" aling="left" visible="false">
                                                   <td></td>
                                                   <th colspan="5" aling="left" >
                                                       <table>
                                                           <tr>
                                                               <td><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="CODIGO DE MOCHADOR:" /></td>
                                                               <td>
                                                                   <dx:ASPxTextBox ID="txtCODIGO_MOCHADOR" AutoPostBack="true"  Font-Bold="true" runat="server" Width="80px">
                                                                     <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                    </dx:ASPxTextBox>
                                                               </td>
                                                               <td>
                                                                   <dx:ASPxTextBox ID="txtNOMBRE_MOCHADOR" Font-Bold="true" runat="server" Width="250px">
                                                                     <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                    </dx:ASPxTextBox>
                                                               </td>
                                                               <td><dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="CODIGO DE CHEQUERO:" /></td>
                                                               <td>
                                                                   <dx:ASPxTextBox ID="txtCODIGO_CHEQUERO" AutoPostBack="true" Font-Bold="true" runat="server" Width="80px">
                                                                     <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                    </dx:ASPxTextBox>
                                                               </td>
                                                               <td>
                                                                   <dx:ASPxTextBox ID="txtNOMBRE_CHEQUERO" Font-Bold="true" runat="server" Width="250px">
                                                                     <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                    </dx:ASPxTextBox>
                                                               </td>
                                                           </tr>
                                                       </table>
                                                   </th>
                                               </tr>
                                               <tr id="trOPERADORES_TRACTOR" runat="server" aling="left">
                                                   <th colspan="3" aling="left" >
                                                       <table>
                                                           <tr>
                                                               <td><dx:ASPxCheckBox ID="chkAUTOVOLTEO" Text="ES SERVICIO AUTOVOLTEO" AutoPostBack="true" runat="server"></dx:ASPxCheckBox></td>
                                                               <td><dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="OPERADORES DE TRACTOR:" /></td>
                                                               <td>
                                                                   <dx:ASPxComboBox ID="cbxOPERADOR_TRACTOR1" runat="server"   DataSourceID="odsOperadorTractor1" 
                                                                        ValueField="ID_CARGADOR" TextField="NOMBRE_CARGADOR" Width="250px"    
                                                                        ValueType="System.Int32" DropDownStyle="DropDownList" TextFormatString="{0} - {1}"
                                                                        IncrementalFilteringMode="Contains" >   
                                                                         <Columns>                                                        
                                                                            <dx:ListBoxColumn Caption="Codigo" FieldName="ID_CARGADOR" Width="100px" />                                                            
                                                                            <dx:ListBoxColumn Caption="Nombre" FieldName="NOMBRE_CARGADOR" Width="300px" />                                                        
                                                                        </Columns>   
                                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                                                                           
                                                                    </dx:ASPxComboBox>  
                                                               </td>
                                                               <td>
                                                                   <dx:ASPxComboBox ID="cbxOPERADOR_TRACTOR2" runat="server"  DataSourceID="odsOperadorTractor2"  
                                                                        ValueField="ID_CARGADOR" TextField="NOMBRE_CARGADOR" Width="250px"    
                                                                        ValueType="System.Int32" DropDownStyle="DropDownList" TextFormatString="{0} - {1}"
                                                                        IncrementalFilteringMode="Contains" >   
                                                                         <Columns>                                                        
                                                                            <dx:ListBoxColumn Caption="Codigo" FieldName="ID_CARGADOR" Width="100px" />                                                            
                                                                            <dx:ListBoxColumn Caption="Nombre" FieldName="NOMBRE_CARGADOR" Width="300px" />                                                        
                                                                        </Columns>   
                                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                                                                           
                                                                    </dx:ASPxComboBox>  
                                                               </td>                                                               
                                                           </tr>
                                                       </table>
                                                   </th>
                                               </tr>
                                               <tr id="trQUERQUEO_BARRIDA" runat="server">                                                  
                                                   <td>
                                                       <dx:ASPxCheckBox ID="chkQuerqueo" Text="QUERQUEO"  runat="server"></dx:ASPxCheckBox>
                                                   </td>                                                   
                                                   <td>
                                                       <dx:ASPxCheckBox ID="chkBarrido" Text="BARRIDO"  runat="server"></dx:ASPxCheckBox>
                                                   </td>
                                                   <th colspan="8">
                                                       <table width="100%">
                                                           <tr>
                                                               <td><dx:ASPxLabel ID="ASPxLabel29" runat="server" Text="COD. MONITOR:" /></td>
                                                               <td>
                                                                   <dx:ASPxTextBox ID="txtCOD_MONITOR" Font-Bold="true" runat="server" Width="100px">
                                                                     <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                    </dx:ASPxTextBox>
                                                               </td>
                                                               <td><dx:ASPxLabel ID="ASPxLabel30" runat="server" Text="FRENTE QUERQUEO:" /></td>
                                                               <td>
                                                                   <dx:ASPxComboBox ID="cbxPROVEEDOR_QUERQUEO" DropDownStyle="DropDownList" runat="server" ValueType="System.Int32" ValueField="ID_PROVEE_QQ" TextField="NOMBRES" TextFormatString="{0} {1} {2}" DataSourceID="odsProveedorQuerqueo" IncrementalFilteringMode="Contains" Width="100%" >                                                                                                                                
                                                                    <Columns>
                                                                        <dx:ListBoxColumn Caption="Codigo" FieldName="CODISIS" Width="80px" />
                                                                        <dx:ListBoxColumn Caption="Apellidos" FieldName="NOMBRES" Width="150px" />
                                                                        <dx:ListBoxColumn Caption="Nombres" FieldName="APELLIDOS" Width="150px" />                                                            
                                                                    </Columns>
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                </dx:ASPxComboBox>
                                                               </td>
                                                           </tr>
                                                       </table>
                                                   </th>
                                               </tr>                                          
                                               <tr>
                                                   <td></td>
                                                   <th colspan="4" style="text-align:left">
                                                        <dx:ASPxComboBox ID="cbxSUPERVISOR" runat="server" DataSourceID="odsSupervisor" Font-Bold="true" Width="100%"
                                                            ValueField="ID_SUPERVISOR" TextField="NOMBRE_SUPERVISOR" 
                                                            ValueType="System.Int32" DropDownStyle="DropDownList" 
                                                            IncrementalFilteringMode="Contains" > 
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        </dx:ASPxComboBox>                                                       
                                                   </th>
                                               </tr>
                                                <tr>
                                                    <td></td>
                                                    <td></td>
                                                    <td>
                                                       <dx:ASPxCheckBox ID="chkPrimerEnvioTurno" Text="PRIMER ENVIO DEL TURNO"  runat="server"></dx:ASPxCheckBox>
                                                   </td>
                                                   <td>
                                                       <dx:ASPxCheckBox ID="chkUltimoEnvioTurno" Text="ULTIMO ENVIO DEL TURNO"  runat="server"></dx:ASPxCheckBox>
                                                   </td>
                                                </tr>
                                            </table>
                                    
        </td>
    </tr>   
</table>

<dx:ASPxHiddenField ID="hfucEnvioProforma" ClientInstanceName="hfucEnvioProforma" SyncWithServer="true" runat="server"></dx:ASPxHiddenField>
 </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLabel runat="server" ID="lblID_SUBLOTES" ClientVisible="false" />

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTipoTransporte" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPO_TRANSPORTE">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsFrenteRoza" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cPROVEEDOR_ROZA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR_ROZA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSupervisor" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cSUPERVISOR">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_SUPERVISOR" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsOperadorTractor1" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorTRACTOR" 
    TypeName="SISPACAL.BL.cCARGADOR">      
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsOperadorTractor2" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorTRACTOR" 
    TypeName="SISPACAL.BL.cCARGADOR">      
</asp:ObjectDataSource>


<asp:ObjectDataSource ID="odsTipoCana" runat="server" 
    TypeName="SISPACAL.BL.cTIPOS_GENERALES" SelectMethod="RecuperarPorTipo" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>    
     <asp:Parameter Name="agregarVacio" DefaultValue="False" Type="Boolean"  />
     <asp:Parameter Name="agregarTodos" DefaultValue="False" Type="Boolean" />  
     <asp:Parameter Name="ID_TIPO" DefaultValue="-1" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_TABLA" DefaultValue="15" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_PADRE" DefaultValue="-1" Type="Int32" />     
  </SelectParameters> 
 </asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsMotivoAnulacionProforma" runat="server" 
    TypeName="SISPACAL.BL.cTIPOS_GENERALES" SelectMethod="RecuperarPorTipo" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>    
     <asp:Parameter Name="agregarVacio" DefaultValue="False" Type="Boolean"  />
     <asp:Parameter Name="agregarTodos" DefaultValue="False" Type="Boolean" />  
     <asp:Parameter Name="ID_TIPO" DefaultValue="-1" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_TABLA" DefaultValue="48" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_PADRE" DefaultValue="-1" Type="Int32" />     
  </SelectParameters> 
 </asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProveedorQuerqueo" runat="server" 
    TypeName="SISPACAL.BL.cPROVEEDOR_QUERQUEO" SelectMethod="ObtenerListaCombo" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>         
  </SelectParameters> 
 </asp:ObjectDataSource>