<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPAGO_CTA_BANCO.ascx.vb" Inherits="controles_ucMantPAGO_CTA_BANCO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPAGO_CTA_BANCO" Src="~/controles/ucListaPAGO_CTA_BANCO.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<style type="text/css">
    .auto-style1 {
        height: 24px;
    }
</style>
<script type="text/javascript">
    function MostraProcesando(s, e) {
        pcCosechaExcel.Show();
    }
    function ImportacionCompletada(s, e) {
        pcCosechaExcel.Hide();
        if (e.isValid) {
            AsignarMensaje(e.callbackData);
        }
        else {            
            AsignarMensaje(e.errorText);
        }
    }    
</script>

<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Pago cta banco</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
          <tr>
              <td>
                     <dx:ASPxFormLayout ID="ucCriteriosPagoCuenta" runat="server" SettingsItemCaptions-Location="Left" Name="glPagoCuenta">
                       <Items>
                           <dx:LayoutGroup Caption="Criterios de búsqueda" ColCount="1" GroupBoxDecoration="HeadingLine">
                               <Items>
                                   <dx:LayoutItem ShowCaption="False" >
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                               <table>
                                                   <tr>
                                                       <td>
                                                           <dx:ASPxLabel ID="lblZafra1"  runat="server" Text="Zafra:" />  
                                                       </td>
                                                       <td>
                                                           <dx:ASPxComboBox ID="cbxZAFRA" runat="server" AutoPostBack="true" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="150px">
                                                            </dx:ASPxComboBox>
                                                       </td>
                                                       <td style="padding-left:15px" >
                                                            <dx:ASPxLabel ID="ASPxLabel1"  runat="server" Text="Catorcena:" />  
                                                       </td>
                                                       <td>
                                                           <dx:ASPxComboBox ID="cbxCATORCENA_ZAFRA" runat="server" ValueField="ID_CATORCENA" TextField="CATORCENA" ValueType="System.Int32" Width="120px">
                                                            </dx:ASPxComboBox>
                                                       </td>
                                                       <td style="padding-left:15px" >
                                                           <dx:ASPxLabel ID="ASPxLabel2"  runat="server" Text="Tipo planilla:" />  
                                                       </td>
                                                       <td>
                                                           <dx:ASPxComboBox ID="cbxTIPO_PLANILLA" runat="server" DataSourceID="odsTipoPlanilla" ValueField="ID_TIPO_PLANILLA" TextField="NOMBRE_TIPO_PLANILLA" ValueType="System.Int32" Width="300px">
                                                            </dx:ASPxComboBox>
                                                       </td>    
                                                       <td>
                                                           <dx:ASPxRadioButtonList ID="rblTIPO_CONTRIBUYENTE" runat="server" Border-BorderStyle="None" ValueType="System.Int32" RepeatDirection="Horizontal">
                                                               <Items>
                                                                   <dx:ListEditItem Text="Todos" Value="-1"  />
                                                                   <dx:ListEditItem Text="Contribuyente" Selected="true" Value="1"  />   
                                                                   <dx:ListEditItem Text="No Contribuyente" Value="0"  />
                                                               </Items>
                                                           </dx:ASPxRadioButtonList>
                                                       </td>                                                   
                                                   </tr>
                                                   <tr>
                                                       <td>
                                                           <dx:ASPxLabel ID="ASPxLabel3"  runat="server" Text="Mostrar por:" />  
                                                       </td>
                                                       <th colspan="2" >
                                                           <dx:ASPxComboBox ID="cbxMOSTRAR_POR" runat="server" ValueType="System.Int32" Width="100%">
                                                               <Items>
                                                                   <dx:ListEditItem Text="TODOS" Selected="true" Value="-1"  />  
                                                                   <dx:ListEditItem Text="PENDIENTE ENTREGA CCF" Value="0"  />  
                                                                   <dx:ListEditItem Text="PENDIENTE DE PAGO" Value="1"  />  
                                                                   <dx:ListEditItem Text="PAGADO" Value="2"  />
                                                               </Items>
                                                            </dx:ASPxComboBox>
                                                       </th>
                                                   </tr>
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
	       <TR>
            <TD><uc1:ucListaPAGO_CTA_BANCO id="ucListaPAGO_CTA_BANCO1" PermitirEditarInline="true" runat="server"></uc1:ucListaPAGO_CTA_BANCO></TD>
        </TR>
    </TBODY>
</TABLE>


<dx:ASPxPopupControl ID="pcGenerarArchivo" runat="server" CloseAction="CloseButton" Modal="True" Width="500px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcGenerarArchivo"
        HeaderText="Generación de archivo para pago a cuenta" AllowDragging="True" PopupAnimationType="None" Theme="Moderno">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">  
                            <table width="100%">
                                <tr>
                                    <th colspan="2" style="text-align:left" class="auto-style1">
                                        <dx:ASPxLabel runat="server" ID="lblBanco" Font-Bold="true" Text="Seleccione el banco" Theme="Glass" />   
                                    </th>
                                </tr>
                                <tr>                                    
                                    <th colspan="2" style="text-align:center">
                                        <dx:ASPxComboBox runat="server" ID="cbxBANCO" Font-Bold="true" Width="100%" ValueField="CODIBANCO" ValueType="System.Int32" TextField="NOMBRE_BANCO" >
                                        </dx:ASPxComboBox>                                         
                                    </th>
                                </tr>
                                <tr>
                                    <td style="padding-right:7px; text-align:right">
                                        <dx:ASPxButton ID="btnGenerar" AutoPostBack="false" runat="server" Text="Generar" Theme="iOS">     
                                            <ClientSideEvents Click="function(s, e){pcGenerarArchivo.Hide();e.processOnServer = true;}"  />                                   
                                        </dx:ASPxButton>    
                                    </td>
                                    <td style="padding-left:7px">  
                                        <dx:ASPxButton ID="btnCancelar" AutoPostBack="false"  runat="server" Text="Cancelar" Theme="iOS">
                                            <ClientSideEvents Click="function(s,e){pcGenerarArchivo.Hide()}" /> 
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


<dx:ASPxPopupControl ID="pcConfirmarNotasCargo" runat="server" CloseAction="CloseButton" Modal="True" Width="500px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcConfirmarNotasCargo"
        HeaderText="Generar Notas de Cargo" AllowDragging="True" PopupAnimationType="None" Theme="Moderno">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server">
                <dx:ASPxPanel ID="ASPxPanel1" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent2" runat="server">  
                            <table width="100%">
                                <tr>
                                    <th colspan="2" style="text-align:center" class="auto-style1">
                                        <dx:ASPxLabel runat="server" ID="lblConfirmacionNC" Font-Bold="true" Text="" Theme="Glass" />   
                                    </th>
                                </tr>
                                <tr>                                    
                                    <th colspan="2" style="text-align:center">
                                        <hr />                                      
                                    </th>
                                </tr>
                                <tr>
                                    <td style="padding-right:7px; text-align:right">
                                        <dx:ASPxButton ID="btnGenerarNC" AutoPostBack="false" runat="server" Text="Generar" Theme="iOS">     
                                            <ClientSideEvents Click="function(s, e){pcConfirmarNotasCargo.Hide();e.processOnServer = true;}"  />                                   
                                        </dx:ASPxButton>    
                                    </td>
                                    <td style="padding-left:7px">  
                                        <dx:ASPxButton ID="btnCancelarNC" AutoPostBack="false"  runat="server" Text="Cancelar" Theme="iOS">
                                            <ClientSideEvents Click="function(s,e){pcConfirmarNotasCargo.Hide()}" /> 
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


<dx:ASPxPopupControl ID="pcSubirNumAutoBanco" runat="server" CloseAction="CloseButton" Modal="True" Width="500px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcSubirNumAutoBanco"
        HeaderText="Cargar números de transferencias" AllowDragging="True" PopupAnimationType="None" Theme="Moderno">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl3" runat="server">
                <dx:ASPxPanel ID="ASPxPanel2" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent3" runat="server">  
                            <table width="100%">
                                <tr>
                                    <td style="text-align:center" class="auto-style1">
                                        <dx:ASPxLabel ID="ASPxLabel4" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Seleccione el archivo a subir al sistema y luego haga clic en "></dx:ASPxLabel>
                                        <dx:ASPxLabel ID="ASPxLabel5" runat="server" Font-Names="Arial" Font-Size="Medium" Font-Bold="true" Text="Subir información"></dx:ASPxLabel>
                                    </td>
                                </tr>
                                <tr>                                    
                                    <td style="text-align:center">
                                        <dx:ASPxUploadControl ID="uploadArchivo" ClientInstanceName="uploadArchivo" runat="server" UploadMode="Advanced" AutoStartUpload="False" Width="100%"
                                            ShowProgressPanel="True" Theme="SoftOrange" ShowUploadButton="True" >
                                            <UploadButton Text="Subir información">
                                            </UploadButton>
                                            <AdvancedModeSettings EnableDragAndDrop="False" EnableFileList="False" EnableMultiSelect="False" >
                <FileListItemStyle CssClass="pending dxucFileListItem"></FileListItemStyle>
                                            </AdvancedModeSettings>
                                            <ValidationSettings AllowedFileExtensions=".xlsx,.xls" />
                                            <BrowseButton Text="Seleccione archivo..." />                           
                                            <ClientSideEvents                               
                                                FileUploadComplete="ImportacionCompletada"
                                                FileUploadStart="MostraProcesando" >
                                            </ClientSideEvents>
                                        </dx:ASPxUploadControl>                                     
                                    </td>
                                </tr>                               
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl>


<dx:ASPxPopupControl ID="pcCosechaExcel" ClientInstanceName="pcCosechaExcel" runat="server"
        Modal="true" ShowOnPageLoad="false" AppearAfter="0" Height="100px"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Text=""
        Width="200px" CloseAction="CloseButton"
        PopupAction="None" ShowHeader="false" CloseAnimationType="Slide" Opacity="80">    
        <ContentStyle HorizontalAlign="Center">
        </ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl4" runat="server">                    
                <table width="100%">
                    <tr>
                        <td>
                        <dx:ASPxImage runat="server" ID="imgModalExpoEsti" ImageUrl="~/imagenes/pinon.gif" Height="146px" Width="160px" />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center">
                            <dx:ASPxLabel ID="ASPxLabel6" runat="server" Font-Names="Arial" Font-Size="Small" Text="Procesando información. Por favor espere..."></dx:ASPxLabel>
                        </td>
                    </tr>
                </table>
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

<asp:ObjectDataSource ID="odsTipoPlanilla" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPO_PLANILLA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_TIPO_PLANILLA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>