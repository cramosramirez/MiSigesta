<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosBodega.ascx.vb" Inherits="controlesBodega_ucCriteriosBodega" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBusquedaProveedor" Src="~/controlesContrato/ucBusquedaProveedor.ascx" %>

<table border="0" >
     <tr id="trZAFRA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Zafra:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" 
            ValueField="ID_ZAFRA" AutoPostBack="true" TextField="NOMBRE_ZAFRA"  Width="118px" >               
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trCATORCENA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Catorcena:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxCATORCENA_ZAFRA" ValueType="System.Int32" ValueField="ID_CATORCENA" TextField="USUARIO_CIERRE" runat="server" Width="118px" >                                                    
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trTIPO_PLANILLA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Tipo planilla:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxTIPO_PLANILLA" AutoPostBack="true" ClientInstanceName="ucCriteriosBodega_cbxTIPO_PLANILLA" runat="server" ValueType="System.Int32" DataSourceID="odsTipoPlanilla" ValueField="ID_TIPO_PLANILLA" TextField="NOMBRE_TIPO_PLANILLA" Width="300px" >                                                    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trTIPO_PLANILLA_FRENTES" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel25" runat="server" Text="Tipo planilla:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxTIPO_PLANILLA_FRENTES" ClientInstanceName="ucCriteriosBodega_cbxTIPO_PLANILLA_FRENTES" runat="server" ValueType="System.Int32" DataSourceID="odsTipoPlanillaFrentes" ValueField="ID_TIPO_PLANILLA" TextField="NOMBRE_TIPO_PLANILLA" Width="300px" >                                                    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>
     <tr id="trPROVEEDOR" runat="server" visible="false">
        <td>
            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Cód. Productor:" />                
        </td>
        <td>
            <table>
                <tr>
                    <td><dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true" AllowUserInput="true" Width="118px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
                        </dx:ASPxSpinEdit>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnBuscar" AutoPostBack="true" ToolTip="Buscar proveedor"  runat="server" Width="20px"   Text="">
                        <Image IconID="find_find_16x16">
                        </Image>
                        </dx:ASPxButton>
                    </td>
                </tr>
            </table>                
        </td>   
        <th colspan="4" >
            <table>
                <tr>
                    <td style="padding-left:15px">
                        <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Nombre Productor:" />                
                    </td>
                    <td>
                        <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px"  />                            
                    </td>  
                </tr>
            </table>
        </th>                
    </tr>
    <tr id="trTRANSPORTISTA" runat="server" visible="false">
        <td>
            <dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="Cód. Transportista:" />                
        </td>
        <td>  
            <dx:ASPxSpinEdit ID="speCODTRANSPORT" runat="server" AllowNull="true" AutoPostBack="true" AllowUserInput="true" Width="118px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
            </dx:ASPxSpinEdit>           
        </td>   
        <th colspan="4" >
            <table>
                <tr>
                    <td style="padding-left:15px">
                        <dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Nombre Transportista:" />                
                    </td>
                    <td>
                        <dx:ASPxTextBox ID="txtNOMBRE_TRANSPORTISTA" runat="server" Width="300px"  />                            
                    </td>  
                </tr>
            </table>
        </th>                
    </tr>
    <tr id="trPROVEEDOR_AGRICOLA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Proveedor Agrícola:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxPROVEEDOR_AGRICOLA" AutoPostBack="true" runat="server" ValueType="System.Int32" DataSourceID="odsProveedorAgricola" ValueField="ID_PROVEE" TextField="NOMBRE" Width="300px" >                                                    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>    
    <tr id="trPROVEEDOR_AGRICOLA_CREDITO_TRANS" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="Proveedor Agrícola:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxPROVEEDOR_AGRICOLA_CREDITO_TRANS" AutoPostBack="true" runat="server" ValueType="System.Int32" DataSourceID="odsProveedorAgricolaTransporteCredito" ValueField="ID_PROVEE" TextField="NOMBRE" Width="300px" >                                                    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>    
    <tr id="trPROVEEDOR_AGRICOLA_BANCOS" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="Proveedor:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxPROVEEDOR_AGRICOLA_BANCOS" runat="server" ValueType="System.Int32" DataSourceID="odsProveedorAgricolaBancos" ValueField="ID_PROVEE" TextField="NOMBRE" Width="300px" >                                                    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>  
    <tr id="trPROVEEDOR_VUELO" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Proveedor Vuelo:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxPROVEEDOR_VUELO" AutoPostBack="true" runat="server" ValueType="System.Int32" DataSourceID="odsProveedorVuelo" ValueField="ID_PROVEE" TextField="NOMBRE" Width="300px" >                                                    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trBODEGA" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Bodega:" /></td>
        <td>
            <dx:ASPxComboBox runat="server" ValueType="System.Int32" DataSourceID="odsBodega" TextField="NOMBRE_BODEGA" ValueField="ID_BODEGA" Width="300px" ID="cbxBODEGA">
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trPRODUCTO" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Producto:" /></td>
        <td>           
            <dx:ASPxComboBox ID="cbxPRODUCTO" runat="server" ValueType="System.Int32" ValueField="ID_PRODUCTO" DisplayFormatString="{0} - {1}"  TextField="NOMBRE_PRODUCTO" DropDownStyle="DropDown" Width="300px" >                                                    
                <Columns>
                    <dx:ListBoxColumn FieldName="NOMBRE_PROVEEDOR" Caption="Proveedor" Width="120px" />
                    <dx:ListBoxColumn FieldName="NOMBRE_PRODUCTO" Caption="Producto" Width="140px" />  
                    <dx:ListBoxColumn FieldName="PRESENTACION" Caption="Presentacion" Width="60px" />                    
                </Columns>
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trCUENTA_FINANCIAMIENTO" runat="server" visible="false" >
        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Financiamiento:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxCUENTA_FINANCIAMIENTO" runat="server" ValueField="ID_CUENTA_FINAN" TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinan">  
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trCUENTA_FINANCIAMIENTO_TRANS" runat="server" visible="false" >
        <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Financiamiento:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxCUENTA_FINANCIAMIENTO_TRANS" runat="server" ValueField="ID_CUENTA_FINAN" TextField="NOMBRE_CUENTA" ValueType="System.Int32" Width="100%" DataSourceID="odsCuentaFinanTrans">  
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trTOTAL" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="Mostrar solo Total:" /></td>
        <td>
            <dx:ASPxCheckBox runat="server" ID="chkMostrarTotal" Text="" /> 
        </td>
    </tr>
    <tr id="trRESUMEN_POR_OPERADOR" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel23" runat="server" Text="Resumen por operador:" /></td>
        <td>
            <dx:ASPxCheckBox runat="server" ID="chkResumenPorOperador" Text="" /> 
        </td>
    </tr>
    <tr id="trPERIODO" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Periodo:" /></td>
        <td>
            <dx:ASPxComboBox ID="cbxPERIODO" AutoPostBack="true" runat="server" ValueType="System.Int32" Width="300px" DropDownStyle="DropDownList">                                                               
                <Items>
                    <dx:ListEditItem Text="A LA FECHA" Value="1" Selected="true" />  
                    <dx:ListEditItem Text="DEFINIR PERIODO" Value="2" />                      
                </Items>
            </dx:ASPxComboBox> 
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="De:" /></td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_INICIAL" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy" runat="server" Width="120px" ClientEnabled="false" >
            </dx:ASPxDateEdit>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="Hasta:" /></td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_FINAL" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy" runat="server" Width="120px"  ClientEnabled="false" >
            </dx:ASPxDateEdit>
        </td>
    </tr>
    <tr id="trFECHA" runat="server" visible="false"> 
        <td><dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="A la fecha:" /></td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA" EditFormatString="dd/MM/yyyy" UseMaskBehavior="true" DisplayFormatString="dd/MM/yyyy" runat="server" Width="120px" >
            </dx:ASPxDateEdit>
        </td>
    </tr>
    <tr id="trZONA" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel20" runat="server" Text="ZONA">
            </dx:ASPxLabel></td>
        <td><dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" runat="server" ValueType="System.String" DataSourceID="odsZonas"
                ValueField="ZONA" TextField="DESCRIP_ZONA" Theme="Office2010Blue" Width="118px" >
             </dx:ASPxComboBox>
        </td>       
    </tr>  
    <tr id="trES_DETALLE" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel21" runat="server" Text="Mostrar detalle:">
            </dx:ASPxLabel></td>
        <td><dx:ASPxCheckBox runat="server" ID="chkES_DETALLE" /> 
        </td>       
    </tr>    
    <tr id="trOCULTAR_PROVEE_SINSALDO" runat="server" visible="false">
        <td><dx:ASPxLabel ID="ASPxLabel24" runat="server" Text="Ocultar sin saldo:">
            </dx:ASPxLabel></td>
        <td><dx:ASPxCheckBox runat="server" ID="chkOCULTAR_PROVEE_SINSALDO" /> 
        </td>       
    </tr>
</table>

 <asp:ObjectDataSource ID="odsZonas" runat="server" TypeName="SISPACAL.BL.cZONAS" SelectMethod="ObtenerLista" OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>
     <asp:Parameter Name="recuperarHijas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="asColumnaOrden" DefaultValue="DESCRIP_ZONA" Type="String" />
     <asp:Parameter Name="asTipoOrden" DefaultValue="ASC" Type="String" />
  </SelectParameters> 
  </asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsBodega" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cBODEGA">  
    <SelectParameters>        
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />   
        <asp:Parameter DefaultValue="ID_BODEGA" Name="asColumnaOrden" Type="String" />        
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />   
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTipoPlanilla" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPO_PLANILLA">  
    <SelectParameters>        
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />   
        <asp:Parameter DefaultValue="ID_TIPO_PLANILLA" Name="asColumnaOrden" Type="String" />        
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />   
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTipoPlanillaFrentes" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaFrentes" 
    TypeName="SISPACAL.BL.cTIPO_PLANILLA">  
    <SelectParameters>                  
        <asp:Parameter DefaultValue="ID_TIPO_PLANILLA" Name="asColumnaOrden" Type="String" />        
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />   
    </SelectParameters>
</asp:ObjectDataSource>

 <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProveedorAgricola" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorTIPO_PROVEEDOR" 
    TypeName="SISPACAL.BL.cPROVEEDOR_AGRICOLA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ES_PROVEE_VUELO" Type="Int32" />
        <asp:Parameter DefaultValue="1" Name="ES_CASA_COMER" Type="Int32" />
        <asp:Parameter DefaultValue="-1" Name="ID_CUENTA_FINAN" Type="Int32"  />
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProveedorAgricolaBancos" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPROVEEDOR_BANCOS" 
    TypeName="SISPACAL.BL.cPROVEEDOR_AGRICOLA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ES_PROVEE_VUELO" Type="Int32" />
        <asp:Parameter DefaultValue="1" Name="ES_CASA_COMER" Type="Int32" />
        <asp:Parameter DefaultValue="-1" Name="ID_CUENTA_FINAN" Type="Int32"  />
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProveedorAgricolaTransporteCredito" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaParaTransporteCreditoEncaTrans" 
    TypeName="SISPACAL.BL.cPROVEEDOR_AGRICOLA">  
    <SelectParameters>        
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProveedorVuelo" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorTIPO_PROVEEDOR" 
    TypeName="SISPACAL.BL.cPROVEEDOR_AGRICOLA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="1" Name="ES_PROVEE_VUELO" Type="Int32" />
        <asp:Parameter DefaultValue="-1" Name="ES_CASA_COMER" Type="Int32" />
        <asp:Parameter DefaultValue="-1" Name="ID_CUENTA_FINAN" Type="Int32"  />
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsCuentaFinan" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorCriterios" 
    TypeName="SISPACAL.BL.cCUENTA_FINAN">  
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="AgregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="APLICA_SOLIC_AGRICOLA" Type="Boolean" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsCuentaFinanTrans" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaParaSolicTransporte" 
    TypeName="SISPACAL.BL.cCUENTA_FINAN">  
    <SelectParameters>
        <asp:Parameter DefaultValue="True" Name="AgregarVacio" Type="Boolean" />        
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

