<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCONTRATO_TRANS.ascx.vb" Inherits="controles_ucVistaDetalleCONTRATO_TRANS" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaCONTRATO_TRANS_VEHI" Src="~/controlesContrato/ucListaCONTRATO_TRANS_VEHI.ascx" %>

<center>
<dx:ASPxFormLayout ID="ucVistaDetalleCONTRATO_TRANSLayout" ClientInstanceName="ucVistaDetalleCONTRATO_TRANSLayout" runat="server">
    <Items>
        <dx:LayoutGroup ColCount="1" Caption="Contrato de transporte de caña" Name="lgVistaDetalleCONTRATO_TRANS" Width="800px"  GroupBoxDecoration="Box">
            <Items>
                <dx:LayoutItem ShowCaption="False">
                    <LayoutItemNestedControlCollection>
                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer17" runat="server">                            
                            <table>                                                                
                                <tr>
                                    <td><dx:ASPxLabel id="ASPxLabel1" runat="server" Text="Zafra:" /></td>
                                    <td>
                                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server"  DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        </dx:ASPxComboBox>
                                    </td>
                                    <td><dx:ASPxLabel id="ASPxLabel2" runat="server" Text="N° Contrato:" /></td>
                                    <td>
                                         <dx:ASPxTextBox ID="txtNO_CONTRATO" runat="server" Width="120px" >
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"/>  
                                         </dx:ASPxTextBox>
                                    </td>
                                    <td></td>
                                    <td></td>                                    
                                </tr>
                                <tr>
                                    <td><dx:ASPxLabel id="ASPxLabel3" runat="server" Text="Cód. Transportista:" /></td>
                                    <td>
                                        <dx:ASPxSpinEdit ID="speCODTRANSPORT" runat="server" AutoPostBack="true" Width="120px"  >
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"/>  
                                            <SpinButtons ShowIncrementButtons="false" />                                          
                                        </dx:ASPxSpinEdit>
                                    </td>
                                    <td><dx:ASPxLabel id="ASPxLabel4" runat="server" Text="Nombre:" /></td>
                                    <th colspan="3">
                                        <dx:ASPxTextBox ID="txtNOMBRE_TRANS" runat="server" Width="300px" >
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"/>  
                                        </dx:ASPxTextBox>
                                    </th>                                    
                                </tr>
                                <tr>
                                    <td><dx:ASPxLabel id="ASPxLabel5" runat="server" Text="DUI:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtDUI" runat="server" Width="120px" >                                            
                                            <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" Mask="99999999-9" />           
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"/>                                  
                                        </dx:ASPxTextBox>            
                                    </td>
                                    <td><dx:ASPxLabel id="ASPxLabel6" runat="server" Text="NIT:" /></td>
                                    <td>
                                        <dx:ASPxTextBox ID="txtNIT" runat="server" ClientInstanceName="txtNIT" Width="100%">                                            
                                            <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" Mask="9999-999999-999-9" />      
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"/>                                       
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td><dx:ASPxLabel id="ASPxLabel7" runat="server" Text="Fecha contrato:" /></td>
                                    <td>
                                        <dx:ASPxDateEdit ID="dteFECHA_CONTRA"  DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                            EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px">      
                                           <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"/>                                                                                    
                                        </dx:ASPxDateEdit>
                                    </td>
                                    <td><dx:ASPxLabel id="ASPxLabel8" runat="server" Text="Lugar de transporte:" /></td>
                                    <th colspan="3">
                                        <dx:ASPxTextBox ID="txtLUGAR_CORTE" runat="server" Width="100%" >
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"/>  
                                        </dx:ASPxTextBox>
                                    </th>  
                                </tr>
                                <tr>
                                    <td><dx:ASPxLabel id="ASPxLabel9" runat="server" Text="Período del:" /></td>
                                    <td>
                                        <dx:ASPxDateEdit ID="dteFECINI"  DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                            EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px">      
                                           <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"/>                                                                                    
                                        </dx:ASPxDateEdit>
                                    </td>
                                    <td><dx:ASPxLabel id="ASPxLabel10" runat="server" Text="al:" /></td>
                                    <td>
                                        <dx:ASPxDateEdit ID="dteFECFIN"  DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                            EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px">      
                                           <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"/>                                                                                    
                                        </dx:ASPxDateEdit>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>                                
                            </table> 
                            <table width="900px">
                                <tr>
                                    <td>
                                        <hr />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <dx:ASPxLabel ID="aspxLabel18" runat="server" Text="Vehículos contratados" Font-Bold="true" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <uc1:ucListaCONTRATO_TRANS_VEHI id="ucListaCONTRATO_TRANS_VEHI1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="false" PermitirEliminar="false"  runat="server"></uc1:ucListaCONTRATO_TRANS_VEHI>                                                                                        
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
</center>

<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>