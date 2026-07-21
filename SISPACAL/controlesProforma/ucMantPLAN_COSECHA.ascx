<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPLAN_COSECHA.ascx.vb" Inherits="controles_ucMantPLAN_COSECHA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPLAN_COSECHA" Src="~/controlesProforma/ucListaPLAN_COSECHA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePLAN_COSECHA" Src="~/controlesProforma/ucVistaDetallePLAN_COSECHA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTROL_ROZA" Src="~/controlesProforma/ucVistaDetalleCONTROL_ROZA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTROL_QUEMA" Src="~/controlesProforma/ucVistaDetalleCONTROL_QUEMA.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<dx:ASPxCallbackPanel ID="cpMantPLAN_COSECHA" ClientInstanceName="cpMantPLAN_COSECHA" runat="server" ShowLoadingPanel="false" Width="100%" >    
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">   
            <table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Plan de Cosecha Catorcenal</asp:Label></td>
		   </tr>
		   <tr>
			   <td>   
               <dx:ASPxFormLayout ID="ucCriteriosPlanPrecosechaLayout" runat="server" SettingsItemCaptions-Location="Left" 
                    Name="glCriterios">
                       <Items>
                           <dx:LayoutGroup Caption="Criterios de búsqueda" ColCount="5" 
                               GroupBoxDecoration="HeadingLine">
                               <Items>
                                   <dx:LayoutItem Caption="Zafra:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px" AutoPostBack="true" >
                                                </dx:ASPxComboBox>
                                           </dx:LayoutItemNestedControlContainer>   
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Zona:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" AutoPostBack="true" runat="server" DataSourceID="odsZona" TextField="DESCRIP_ZONA" ValueField="ZONA" Width="120px" >                            
                                               </dx:ASPxComboBox>         
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Sub Zona:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxComboBox ID="cbxSUB_ZONA" ClientInstanceName="cbxSUB_ZONA" TextField="DESCRIP_SUB_ZONA" ValueField="SUB_ZONA" runat="server" DataSourceID="odsSubZona" Width="120px">                                                            
                                                </dx:ASPxComboBox>     
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Periodo de Cosecha del">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxDateEdit ID="dteFechaDel" runat="server" Width="100px" HorizontalAlign="Right" AllowNull="true"
                                                DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                                EditFormatString="dd/MM/yyyy" >
                                               </dx:ASPxDateEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="al">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxDateEdit ID="dteFechaAl" runat="server" Width="100px" HorizontalAlign="Right" AllowNull="true" 
                                                    DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                                    EditFormatString="dd/MM/yyyy">
                                                </dx:ASPxDateEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>    
                                   <dx:LayoutItem Caption="Catorcena">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                               <dx:ASPxComboBox ID="cbxCATORCENA" runat="server" ValueType="System.Int32" 
                                                   Width="120px" DropDownStyle="DropDown" AutoPostBack="true" />
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Semana">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                                <dx:ASPxComboBox ID="cbxSEMANA" runat="server" ValueType="System.String" 
                                                    Width="120px" DropDownStyle="DropDownList" />
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>   
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                                                 
                                   <dx:LayoutItem Caption="Cod. Provee:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true"
                                                    Width="120px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Cod. Socio:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxSpinEdit ID="speCODISOCIO" runat="server"  AllowNull="true"
                                                   Width="120px">
                                               </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Nombre Proveedor:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="280px">
                                               </dx:ASPxTextBox>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>   
                                   <dx:LayoutItem Caption="Contrato">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                                <dx:ASPxSpinEdit ID="speNO_CONTRATO" runat="server" AllowNull="true"  Width="100px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>    
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                            
                                   <dx:LayoutItem Caption="Técnico:" ColSpan="2">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                                <dx:ASPxComboBox ID="cbxAGRONOMO" ClientInstanceName="cbxAGRONOMO" Width="100%" DropDownStyle="DropDownList" runat="server" DataSourceID="odsAgronomo" 
                                                    ValueField="CODIAGRON" TextField="APELLIDO_AGRONOMO" ValueType="System.String" TextFormatString="{0} {1} {2}" IncrementalFilteringMode="Contains">
                                                        <Columns>
                                                        <dx:ListBoxColumn Caption="Codigo" FieldName="CODIAGRON" Width="80px" />
                                                        <dx:ListBoxColumn Caption="Apellidos" FieldName="APELLIDO_AGRONOMO" Width="120px" />
                                                        <dx:ListBoxColumn Caption="Nombres" FieldName="NOMBRE_AGRONOMO" Width="120px" />                                                            
                                                        </Columns>
                                                </dx:ASPxComboBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem> 
                               </Items>
                           </dx:LayoutGroup>
                       </Items>

<SettingsItemCaptions Location="Left"></SettingsItemCaptions>
                   </dx:ASPxFormLayout>
                </td>
		   </tr>
	       <tr>
            <td><uc1:ucListaPLAN_COSECHA id="ucListaPLAN_COSECHA1" PermitirVistaControlQuema="true" PermitirVistaControlRoza="true" PermitirRowHotTrack="false" MostrarCheckVariaSeleccion="true" runat="server"></uc1:ucListaPLAN_COSECHA>
                <uc1:ucVistaDetallePLAN_COSECHA ID="ucVistaDetallePLAN_COSECHA1" runat="server" Visible="false" ></uc1:ucVistaDetallePLAN_COSECHA>
                <uc1:ucVistaDetalleCONTROL_ROZA ID="ucVistaDetalleCONTROL_ROZA1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTROL_ROZA>
                <uc1:ucVistaDetalleCONTROL_QUEMA ID="ucVistaDetalleCONTROL_QUEMA1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTROL_QUEMA>
            </td>
        </tr>
</table>
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxPopupControl ID="pcGenerarPropuesta" runat="server" CloseAction="CloseButton" Modal="True" Width="600px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcGenerarPropuesta"
        HeaderText="Generar Propuesta de Programación" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">  
                        <dx:ASPxLabel ID="lblpcError" runat="server" Font-Bold="true" ForeColor="Red" /><br />                                              
                        <table width="100%">
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Catorcena:">
                                    </dx:ASPxLabel>
                                </td>
                                <td><dx:ASPxComboBox ID="cbxCATORCENApopup" HorizontalAlign="Right" runat="server" DropDownStyle="DropDownList" AutoPostBack="true" Width="120px">
                                    </dx:ASPxComboBox>
                                </td>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Semana:">
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cbxSEMANApopup" runat="server" ValueType="System.String" 
                                        Width="120px" DropDownStyle="DropDownList" AutoPostBack="true" />
                                </td>
                            </tr>
                             <tr>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Periodo del:">
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxDateEdit ID="dteFECHA_INI_CATORCENA" AutoPostBack="false" runat="server" HorizontalAlign="Right"   
                                        DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                        EditFormatString="dd/MM/yyyy" Width="120px" ClientEnabled="false"  >
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                            <RequiredField ErrorText="Fecha inicio de catorcena es obligatoria" IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxDateEdit>
                                </td>
                                <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="al:">
                                    </dx:ASPxLabel></td>
                                <td>
                                <dx:ASPxDateEdit ID="dteFECHA_FIN_CATORCENA" AutoPostBack="false" runat="server" HorizontalAlign="Right"   
                                    DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                    EditFormatString="dd/MM/yyyy" Width="120px" ClientEnabled="false" >
                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField ErrorText="Fecha fin de catorcena es obligatoria" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxDateEdit>
                                </td>
                            </tr>
                        </table>
                        <hr />
                        <table width="100%">                            
                            <tr>
                                <td style="padding-right:7px; text-align:right">
                                    <dx:ASPxButton ID="btnGenerar" runat="server" AutoPostBack="true" Text="Generar">                                        
                                    </dx:ASPxButton>    
                                </td>
                                <td style="padding-left:7px">  
                                    <dx:ASPxButton ID="btnCancelar" runat="server" Text="Cancelar">
                                        <ClientSideEvents Click="function(s,e){pcGenerarPropuesta.Hide()}" /> 
                                    </dx:ASPxButton> 
                                </td>
                            </tr>                            
                        </table>
                        
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl>

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsSubZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cSUB_ZONAS">
    <SelectParameters>        
       <asp:Parameter DefaultValue="" Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
    </SelectParameters>    
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsAgronomo" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="RecuperarLista" 
    TypeName="SISPACAL.BL.cAGRONOMO">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="AgregarTodos" Type="Boolean" />
        <asp:Parameter DefaultValue="true" Name="AgregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="APELLIDO_AGRONOMO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>