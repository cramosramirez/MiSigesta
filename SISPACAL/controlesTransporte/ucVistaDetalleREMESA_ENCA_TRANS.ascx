<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleREMESA_ENCA_TRANS.ascx.vb" Inherits="controles_ucVistaDetalleREMESA_ENCA_TRANS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaREMESA_DETA_TRANS" Src="~/controlesTransporte/ucListaREMESA_DETA_TRANS.ascx" %>

<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="ucVistaDetalleREMESA_ENCA_TRANSLayout" ClientInstanceName="ucVistaDetalleREMESA_ENCA_TRANSLayout" runat="server" Width="100%">
                <Items>
                    <dx:LayoutGroup ColCount="1" Name="lgRemesaEnca" Caption="Información de la Remesa" GroupBoxDecoration="Box">
                        <Items>
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <center>
                                        <table>
                                            <tr id="trId" runat="server" visible="false">
                                                <td><dx:ASPxLabel id="ASPxLabel1" runat="server" Text="Id Remesa:" /></td>
                                                <td><dx:ASPxTextBox id="txtID_REMESA_ENCA" runat="server" Width="150px" />                                                   
                                                </td>                                               
                                                <td></td>
                                                <td></td>                                                                                                
                                            </tr>  
                                             <tr>
                                                <td><dx:ASPxLabel id="ASPxLabel6" runat="server" Text="Código Transportista:" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="speCODTRANSPORT" AutoPostBack="true" runat="server" Width="150px" NumberType="Integer">			                                            
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        <SpinButtons ShowIncrementButtons="false" /> 
			                                        </dx:ASPxSpinEdit>                                                    
                                                </td>
                                                <td><dx:ASPxLabel id="ASPxLabel7" runat="server" Text="Transportista:" /></td>
                                                <th colspan="2" ><dx:ASPxTextBox id="txtNOMBRE_TRANSPORTISTA" runat="server" Width="300px" >
                                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                                 </dx:ASPxTextBox>
                                                </th>
                                            </tr>   
                                            <tr>
                                                <td><dx:ASPxLabel id="ASPxLabel26" runat="server" Text="Banco:" /></td>
                                                <th colspan="4" >
                                                    <dx:ASPxComboBox ID="cbxBANCO" runat="server" ValueType="System.Int32" DataSourceID="odsBANCOS" ValueField="CODIBANCO" TextField="NOMBRE_BANCO" Width="100%" >                                                    
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </th>                                                 
                                            </tr>                                                                                                                                                   
                                            <tr>                                                
                                                <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="N° Remesa:" /></td>
                                                <td><dx:ASPxTextBox ID="txtNO_REMESA" runat="server" Width="150px" MaxLength="10" HorizontalAlign="Right" >                                        
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                    </dx:ASPxTextBox>
                                                </td>  
                                                <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Fecha Remesa:" /></td>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dteFECHA_REMESA" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                        EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="150px"  >                                            
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxDateEdit> 
                                                </td>   
                                                <td></td>          
                                            </tr> 
                                            <tr>
                                                <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Observación:" /></td>
                                                <th colspan="4" >
                                                    <dx:ASPxMemo ID="txtOBSERVACION" runat="server" Width="100%" Height="50px"  MaxLength="300" >                                        
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                    </dx:ASPxMemo>
                                                </th>
                                            </tr>                                               
                                        </table>
                                        </center>
                                        <center>
                                            <table>  
                                                <tr>
                                                    <td align="center">
                                                        <uc1:ucListaREMESA_DETA_TRANS id="ucListaREMESA_DETA_TRANS1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="false" PermitirEliminar="false"  runat="server"></uc1:ucListaREMESA_DETA_TRANS>                                    
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <table>
                                                            <tr>
                                                                <td></td>
                                                                <td></td>
                                                                <td><dx:ASPxLabel id="ASPxLabel13" runat="server" Text="ABONO A CREDITO:" /></td>
                                                                <td>
                                                                    <dx:ASPxSpinEdit ID="speABONO_CAPITAL" runat="server"  DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                                        </dx:ASPxSpinEdit>
                                                                </td>
                                                            </tr>                                                            
                                                            <tr>
                                                                <td></td>
                                                                <td></td>
                                                                <td><dx:ASPxLabel id="ASPxLabel24" runat="server" Text="INTERES:" /></td>
                                                                <td>
                                                                    <dx:ASPxSpinEdit ID="speABONO_INTERES" runat="server" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                                        </dx:ASPxSpinEdit>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td></td>
                                                                <td></td>
                                                                <td><dx:ASPxLabel id="ASPxLabel16" runat="server" Text="IVA INTERES:" /></td>
                                                                <td>
                                                                    <dx:ASPxSpinEdit ID="speABONO_INTERES_IVA" runat="server" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
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
                                                                    <dx:ASPxSpinEdit ID="speTOTAL" runat="server" DisplayFormatString="#,##0.00" Width="120px" ClientEnabled="false" HorizontalAlign="Right" >	
                                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>		                                            
			                                                        </dx:ASPxSpinEdit>
                                                                </td>
                                                            </tr>
                                                        </table>
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

<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />

<asp:ObjectDataSource ID="odsBANCOS" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cBANCOS">  
    <SelectParameters>                 
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_BANCO" Name="asColumnaOrden" Type="String" />        
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />   
    </SelectParameters>
</asp:ObjectDataSource>
