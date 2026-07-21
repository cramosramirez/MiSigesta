<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCONTROL_ROZA.ascx.vb" Inherits="controles_ucVistaDetalleCONTROL_ROZA" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTROL_ROZA" Src="~/controlesProforma/ucListaCONTROL_ROZA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTROL_ROZA_SALDO" Src="~/controlesProforma/ucListaCONTROL_ROZA_SALDO.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxCallbackPanel ID="cpINVENTARIO_ROZA" ClientInstanceName="cpINVENTARIO_ROZA" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">   
                <table width="100%" >
    <tr>
        <td align="center" style="margin-left: 40px">
            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                <Items>
                    <dx:LayoutGroup Caption="Información de Roza del lote" ColCount="1" >
                        <Items>                                                  
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                                        <table>
                                            <tr runat="server" id="trId" visible="false">
                                                <td>
                                                    <dx:ASPxTextBox ID="txtID_CONTROL_ROZA" runat="server" Width="120px">
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr runat="server" id="trDiaZafra" visible="false">
                                                <td>
                                                    <dx:ASPxTextBox ID="txtDIAZAFRA" runat="server" Width="120px">
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="label1" Text="Zafra:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="100px" DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black">
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel11" Text="Tecnico de Zona:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtTECNICO_ZONA" runat="server" Width="100%" >
                                                      <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel12" Text="Codigo Provee:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtCODIPROVEE" runat="server" Width="100px" >
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel13" Text="Codigo socio:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtCODISOCIO" runat="server" Width="100px" HorizontalAlign="Right">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel14" Text="Cliente:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px" >
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel15" Text="Codigo Lote:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtCODILOTE" runat="server" Width="100px"  HorizontalAlign="Right">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel16" Text="Nombre Lote:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtNOMLOTE" runat="server" Width="250px">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel17" Text="Nombre Lote:" /></td>
                                                <td>
                                                    <dx:ASPxTextBox ID="txtVARIEDAD" runat="server" Width="300px" >
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                    </dx:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel24" Text="Porción:" /></td>
                                                <th colspan="5" >
                                                    <dx:ASPxComboBox ID="cbxSUBLOTES" runat="server" AutoPostBack="true"  ValueField="ID_SUBLOTES" DisplayFormatString="{0}  -  {1}" TextField="NOMBRE_PORCION" DataSourceID="odsSubLotes" ValueType="System.Int32" Width="100%" >
                                                        <Columns>                                                                            
                                                            <dx:ListBoxColumn FieldName="CODIGO" Caption="CODIGO" Width="100px" />
                                                            <dx:ListBoxColumn FieldName="NOMBRE_PORCION" Caption="PORCION" Width="350px" />                                                
                                                        </Columns>  
                                                    </dx:ASPxComboBox>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel23" Text="Quema Disponible:" /></td>
                                                <th colspan="3">
                                                    <dx:ASPxComboBox ID="cbxQuemaDisponible" Font-Bold="true" DropDownStyle="DropDownList" runat="server" ValueType="System.Int32" ValueField="ID_QUEMA_SALDO" TextField="USUARIO_CREA" Width="100%" >                                                                                                                                
                                                    </dx:ASPxComboBox>
                                                </th>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel18" Text="Forma de Cosecha:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxID_TIPO_CANA" DataSourceID="odsTipoCana" DropDownStyle="DropDownList" runat="server" AutoPostBack="true" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO" Width="250px" >
                                                     <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" 
                                                        ErrorDisplayMode="ImageWithTooltip" 
                                                        RequiredField-ErrorText="Tipo de Caña es obligatorio" >
                                                        <RequiredField IsRequired="True" ErrorText="Forma de Cosecha es obligatorio"></RequiredField>
                                                    </ValidationSettings>                                                    
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel19" Text="Fecha/Hora Roza:" /></td>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dteFECHA_HORA_ROZA" ClientInstanceName="dteFECHA_HORA_ROZA" runat="server" HorizontalAlign="Right" 
                                                        DisplayFormatString="dd/MM/yyyy hh:mm tt" EditFormat="Custom" UseMaskBehavior="True" 
                                                        EditFormatString="dd/MM/yyyy hh:mm tt" Width="250px">
                                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                        <TimeSectionProperties Visible="true">                                            
                                                            <TimeEditProperties EditFormatString="hh:mm tt"></TimeEditProperties>
                                                        </TimeSectionProperties>
                                                    </dx:ASPxDateEdit>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel20" Text="Roza ejecutada (TC):" /></td>
                                                <td>
                                                    <dx:ASPxSpinEdit ID="txtENTRADAS" runat="server" HorizontalAlign="Right"  Width="80px" Number="0" DisplayFormatString="{0:F2}">
                                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">                                                
                                                        <RequiredField IsRequired="True" ErrorText="Toneladas Rozadas es obligatoria"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:ASPxSpinEdit>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel21" Text="Tipo de Roza:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxID_TIPO_ROZA" DropDownStyle="DropDownList" AutoPostBack="true" runat="server" ValueType="System.Int32" ValueField="ID_TIPO" TextField="NOM_TIPO"  Width="250px">
                                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" >
                                                            <RequiredField IsRequired="True" ErrorText="Tipo de Roza es obligatorio"></RequiredField>
                                                        </ValidationSettings>                                                    
                                                    </dx:ASPxComboBox>
                                                </td>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel22" Text="Frente de Roza:" /></td>
                                                <th colspan="3" >
                                                    <dx:ASPxComboBox ID="cbxID_PROVEEDOR_ROZA" runat="server" Width="100%"
                                                        ValueField="ID_PROVEEDOR_ROZA" TextField="NOMBRE_PROVEEDOR_ROZA"   
                                                        ValueType="System.Int32" DropDownStyle="DropDownList" 
                                                        IncrementalFilteringMode="Contains" >                                                                                                                              
                                                    </dx:ASPxComboBox>
                                                </th>
                                                <td></td>
                                                <td>
                                                    <dx:ASPxCheckBox ID="chkES_PROYECCION" Text="Roza Proyectada" HorizontalAlign="Left" runat="server">
                                                    </dx:ASPxCheckBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel25" Text="Frente de Querqueo:" /></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxPROVEEDOR_QUERQUEO" DropDownStyle="DropDownList" runat="server" ValueType="System.Int32" ValueField="ID_PROVEE_QQ" DataSourceID="odsProveedorQuerqueo"  TextField="NOMBRES" TextFormatString="{0} {1} {2}" IncrementalFilteringMode="Contains" Width="100%" >                                                                                                                                
                                                        <Columns>
                                                            <dx:ListBoxColumn Caption="Codigo" FieldName="CODISIS" Width="80px" />
                                                            <dx:ListBoxColumn Caption="Apellidos" FieldName="NOMBRES" Width="200px" />
                                                            <dx:ListBoxColumn Caption="Nombres" FieldName="APELLIDOS" Width="150px" />                                                            
                                                        </Columns>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                            <%--<tr>
                                                <td><dx:ASPxLabel runat="server" ID="ASPxLabel24" Text="Con Querqueo:" /></td>
                                                <td>
                                                    <dx:ASPxCheckBox ID="chkQuerqueo" Text="" runat="server"></dx:ASPxCheckBox>
                                                </td>
                                            </tr>--%>
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
                <tr>
                    <td style="padding-left:20px">
                    <dx:ASPxLabel runat="server" ID="ASPxLabel5" Text="Esticaña:" Theme="Office2003Olive"  />
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
                     <dx:ASPxLabel runat="server" ID="ASPxLabel7" Text="Roza ejecutada:" Theme="Office2003Olive"  />
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
                    <dx:ASPxLabel runat="server" ID="ASPxLabel6" Text="Esticaña menos Roza Ejecutada:" Theme="Office2003Olive"  />
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
                <tr>
                    <td><dx:ASPxLabel ID="Label101" runat="server" Text="Saldo Caña Quemada:" Theme="Office2003Olive" /></td>
                    <td>
                        <dx:ASPxSpinEdit ID="txtSALDO_QUEMA" runat="server" Theme="Office2003Olive" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                            SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>
                    <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Quema Programada:" Theme="Office2003Olive" /></td>
                    <td>
                        <dx:ASPxSpinEdit ID="txtQUEMA_QUEMA_PROGRAMADA" runat="server" Theme="Office2003Olive" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                            SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>
                    <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Quema no Programada:" Theme="Office2003Olive" /></td>
                    <td>
                        <dx:ASPxSpinEdit ID="txtQUEMA_QUEMA_NOPROG" runat="server" Theme="Office2003Olive" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                            SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>
                    <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Caña Verde:" Theme="Office2003Olive" /></td>
                    <td>
                        <dx:ASPxSpinEdit ID="txtQUEMA_CANA_VERDE" runat="server" Theme="Office2003Olive" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                            SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:20px">
                    <dx:ASPxLabel runat="server" ID="ASPxLabel1" Text="Saldo Total Roza:" Theme="Office2003Olive"  />
                     </td>
                     <td>
                        <dx:ASPxSpinEdit ID="txtSALDO_ROZA" Theme="Office2003Olive" ClientInstanceName="gVistaDetalleCONTROL_ROZA_SALDO_ROZA" runat="server" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                                                        DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                                                        SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>    
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                     </td>   
                     <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Quema Programada:" Theme="Office2003Olive" /></td>
                    <td>
                        <dx:ASPxSpinEdit ID="txtSALDO_QUEMA_PROGRAMADA" runat="server" Theme="Office2003Olive" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                            SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>
                    <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Quema no Programada:" Theme="Office2003Olive" /></td>
                    <td>
                        <dx:ASPxSpinEdit ID="txtSALDO_QUEMA_NOPROG" runat="server" Theme="Office2003Olive" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                            SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>
                    <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Caña Verde:" Theme="Office2003Olive" /></td>
                    <td>
                        <dx:ASPxSpinEdit ID="txtCANA_VERDE" runat="server" Theme="Office2003Olive" Font-Bold="true" HorizontalAlign="Right"  Width="90px" 
                            DisabledStyle-BackColor="WhiteSmoke" DisabledStyle-ForeColor="Black"
                            SpinButtons-ShowIncrementButtons="false" Number="0" DisplayFormatString="#,##0.00">
<SpinButtons ShowIncrementButtons="False"></SpinButtons>

<DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>                  
                </tr>
            </table>
         </td>
    </tr>
    <tr>
         <td align="center" style="padding-left:30px; padding-right:30px">
            <uc1:ucListaCONTROL_ROZA_SALDO id="ucListaCONTROL_ROZA_SALDO1" TamanoPagina="4" MostrarCheckUnaSeleccion="true" PermitirEditarInline="false" PermitirEliminar="false" PermitirEliminarInline="false" runat="server" PermitirEditar="false" />
         </td>
    </tr>
    <tr>
        <td align="center" style="margin-left: 40px">
            <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server" Width="98%" >
                <Items>
                    <dx:LayoutGroup Caption="Movimientos del Inventario seleccionado" ColCount="1" >
                        <Items>                            
                            <dx:LayoutItem ShowCaption="False">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <uc1:ucListaCONTROL_ROZA id="ucListaCONTROL_ROZA1" TamanoPagina="20" PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" PermitirEditarInline="false" PermitirEliminar="true" runat="server" PermitirEditar="false"></uc1:ucListaCONTROL_ROZA>
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
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsTipoCana" runat="server" 
    TypeName="SISPACAL.BL.cTIPOS_GENERALES" SelectMethod="RecuperarPorTipo" 
    OldValuesParameterFormatString="original_{0}" >        
  <SelectParameters>          
     <asp:Parameter Name="agregarVacio" DefaultValue="false" Type="Boolean"  />
     <asp:Parameter Name="agregarTodos" DefaultValue="false" Type="Boolean" />  
     <asp:Parameter Name="ID_TIPO" DefaultValue="-1" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_TABLA" DefaultValue="15" Type="Int32" />     
     <asp:Parameter Name="ID_TIPO_PADRE" DefaultValue="-1"  Type="Int32" />     
  </SelectParameters> 
 </asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSubLotes" runat="server" 
    TypeName="SISPACAL.BL.cSUBLOTES" SelectMethod="ObtenerListaPorLOTES_COSECHA" 
    OldValuesParameterFormatString="original_{0}" >        
  <SelectParameters>  
     <asp:SessionParameter Name="ID_LOTES_COSECHA" SessionField="controlRoza_IdLotesCosecha" DefaultValue="-1" Type="Int32" />  
     <asp:Parameter DefaultValue="CODIGO" Name="asColumnaOrden" Type="String" />
     <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
  </SelectParameters> 
 </asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProveedorQuerqueo" runat="server" 
    TypeName="SISPACAL.BL.cPROVEEDOR_QUERQUEO" SelectMethod="ObtenerListaCombo" 
    OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>         
  </SelectParameters> 
 </asp:ObjectDataSource>
