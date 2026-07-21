<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleREQENCA.ascx.vb" Inherits="controles_ucVistaDetalleREQENCA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaREQDETA" Src="~/controlesRequisicion/ucListaREQDETA.ascx" %>


<table width="100%" >
    <tr>
        <td align="center">
        <dx:ASPxCallbackPanel ID="cpVistaDetalleREQENCA" ClientInstanceName="cpVistaDetalleREQENCA" runat="server" ShowLoadingPanel="false" Width="100%" >    
        <SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
            <PanelCollection>
                <dx:PanelContent ID="PanelContent6" runat="server">  
                <table border="0">
                      <tr>
                <td align="center">
                    <dx:ASPxTextBox ID="txtID_REQENCA" runat="server" ClientVisible="false" ClientInstanceName="txtID_REQENCA" Width="120px" BackColor="WhiteSmoke">                               
                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                    </dx:ASPxTextBox>
                    <dx:ASPxFormLayout ID="ucVistaDetalleREQENCALayout" ClientInstanceName="ucVistaDetalleREQENCALayout" runat="server">
                        <Items>
                            <dx:LayoutGroup ColCount="3" GroupBoxStyle-Caption-Font-Bold="true" GroupBoxStyle-Caption-ForeColor="DarkBlue" Name="lgRequisicion" Caption="SOLICITUD PARA ELABORACIÓN DE REQUISICIONES" GroupBoxDecoration="Box">
                                <GroupBoxStyle>
                                <Caption Font-Bold="True"></Caption>
                                </GroupBoxStyle>
                                <Items>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                                <table>
                                                    <tr>
                                                        <td style="width:120px"><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="N° DE SOLICITUD:" /></td>
                                                        <th>
                                                            <dx:ASPxTextBox ID="txtCODI_REQ" runat="server" AutoPostBack="True" Font-Bold="true" ForeColor="Blue" Width="160px" ClientInstanceName="txtNO_REQ" >                                        
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>     
                                                        </th>
                                                        <td style="width:120px"><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="ESTADO ACTUAL:" /></td>
                                                        <td>
                                                            <dx:ASPxComboBox ID="cbxID_REQETAPA" runat="server" DataSourceID="odsReqEtapa" ValueField="ID_REQETAPA" TextField="NOM_REQETAPA" ValueType="System.Int32" Width="200px" DropDownStyle="DropDownList">                                                               
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxComboBox>                                                            
                                                        </td>
                                                    </tr>                                                    
                                                    <tr>
                                                        <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="PERIODO:" /></td>
                                                        <th>
                                                            <dx:ASPxComboBox ID="cbxID_PERIODOREQ" runat="server"  DataSourceID="odsPeriodoReq" ValueField="ID_PERIODOREQ" TextField="DESCRIP_PERIODO" ValueType="System.Int32" Width="300px">
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxComboBox>
                                                        </th>
                                                        <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="FECHA SOLICITUD:" /></td>
                                                        <td>
                                                            <dx:ASPxDateEdit ID="dteFECHA_EMISION" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="120px" ClientEnabled="false"  >                                            
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxDateEdit>  
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="AREA/DEPTO.:" /></td>
                                                        <th>
                                                            <dx:ASPxComboBox ID="cbxID_SECCION" runat="server"  DataSourceID="odsSeccion" ValueField="ID_SECCION" TextField="NOMBRE_SECCION" TextFormatString="{0} {1}" ValueType="System.Int32" Width="300px" DropDownStyle="DropDownList" >                                                            
                                                            <Columns>
                                                                <dx:ListBoxColumn Caption="Codigo"  FieldName="CODIGO" Width="50px" />  
                                                                <dx:ListBoxColumn Caption="Nombre"  FieldName="NOMBRE_SECCION" Width="300px" />  
                                                            </Columns>
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxComboBox>
                                                        </th>                                                        
                                                    </tr>
                                                    <tr>
                                                        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="SOLICITANTE:" /></td>
                                                        <th>
                                                            <dx:ASPxComboBox ID="cbxID_SOLICITANTE" runat="server" DataSourceID="odsSolicitante" ValueField="ID_SOLICITANTE" TextField="NOMBRE_SOLICITANTE" TextFormatString="{0} {1}"  ValueType="System.Int32" Width="300px" DropDownStyle="DropDownList">
                                                            <Columns>
                                                                <dx:ListBoxColumn Caption="Codigo"  FieldName="CODIGO" Width="50px" />  
                                                                <dx:ListBoxColumn Caption="Nombre"  FieldName="NOMBRE_SOLICITANTE" Width="300px" />  
                                                            </Columns>
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxComboBox>
                                                        </th>
                                                    </tr>
                                                    <tr>
                                                        <td><dx:ASPxLabel ID="ASPxLabel26" runat="server" Text="SECCION:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="txtSECCION" runat="server" Width="300px" >
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxTextBox> 
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel27" runat="server" Text="EQUIPO:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="txtEQUIPO" runat="server" Width="120px" >
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxTextBox> 
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td><dx:ASPxLabel ID="ASPxLabel28" runat="server" Text="PROPOSITO:" /></td>
                                                        <td>
                                                            <dx:ASPxComboBox ID="cbxPROPOSITO" runat="server" ValueType="System.Int32" Width="160px" DropDownStyle="DropDownList">
                                                            <Items>
                                                                <dx:ListEditItem Text="REPARACION" Value="1" />  
                                                                <dx:ListEditItem Text="INVERSION" Value="2" />
                                                                <dx:ListEditItem Text="PROVISION" Value="3" />
                                                            </Items>                                                            
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxComboBox> 
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel29" runat="server" Text="COMPRA:" /></td>
                                                        <td>
                                                            <dx:ASPxComboBox ID="cbxCOMPRA_LOCAL" runat="server" ValueType="System.Boolean" Width="120px" DropDownStyle="DropDownList">
                                                            <Items>
                                                                <dx:ListEditItem Text="LOCAL" Value="true" />  
                                                                <dx:ListEditItem Text="EXTERIOR" Value="false" />
                                                            </Items>                                                            
                                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxComboBox> 
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="FECHA MAXIMA SUMINISTRO:" /></td>
                                                        <td>
                                                             <dx:ASPxDateEdit ID="dteFECHA_MAX_SUMIN" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" AllowNull="true"   
                                                                EditFormatString="dd/MM/yyyy" UseMaskBehavior="True" runat="server" Width="160px" ClientEnabled="false"  >                                            
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxDateEdit> 
                                                        </td>
                                                    </tr>
                                                    <%--<tr>
                                                        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="USO:" /></td>
                                                        <th colspan="3">
                                                            <dx:ASPxMemo ID="txtUSO" runat="server"  Height="40px" Width="100%">
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxMemo>                                                            
                                                        </th>
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
                <td valign="top">
                    <dx:ASPxFormLayout ID="InfoEtapas" runat="server" >
                        <Items>
                            <dx:LayoutGroup ColCount="3" Height="180px" GroupBoxStyle-Caption-Font-Bold="true" GroupBoxStyle-Caption-ForeColor="DarkBlue" Name="lgInfoEtapas" Caption="Información de Etapas" GroupBoxDecoration="Box">
                                <GroupBoxStyle>
                                <Caption Font-Bold="True"></Caption>
                                </GroupBoxStyle>
                                <Items>
                                    <dx:LayoutItem ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                                <table border="0" cellpadding="0" cellspacing="1">
                                                    <tr id="trInfoAprob" runat="server" visible="false" >
                                                        <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="Aprobación:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoAprobacionFecha" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td></td>
                                                        <td></td>
                                                        <td></td>
                                                        <td></td>                                                       
                                                    </tr>
                                                    <tr id="trInfoEtapaRequisicion" runat="server" visible="false"> 
                                                        <th colspan="6" align="center"  style="border-bottom: 1px solid Black">
                                                            <dx:ASPxLabel ID="ASPxLabel49" runat="server" Text="REQUISICIÓN" Font-Size="XX-Small" Font-Bold="true"/>
                                                        </th>
                                                    </tr>
                                                    <tr id="trInfoReq" runat="server" visible="false" >    
                                                        <td><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="N° Requisición:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoRequiNo" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Fecha:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoRequiFecha" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td></td>
                                                        <td></td>
                                                    </tr>
                                                    <tr id="trInfoEtapaSolicitudCotizacion" runat="server" visible="false"> 
                                                        <th colspan="6" align="center"  style="border-bottom: 1px solid Black">
                                                            <dx:ASPxLabel ID="ASPxLabel50" runat="server" Text="COTIZACIÓN" Font-Size="XX-Small" Font-Bold="true"/>
                                                        </th>
                                                    </tr>
                                                    <tr id="trInfoCotizacion" runat="server" visible="false">    
                                                        <td><dx:ASPxLabel ID="ASPxLabel30" runat="server" Text="Fecha Cotización:" /></td>
                                                        <td>                                                            
                                                            <dx:ASPxTextBox ID="infoCotiFECHA_RECIBOREQ" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td style="width:80px"><dx:ASPxLabel ID="ASPxLabel31" runat="server" Text="Proveedores invitados:" /></td>
                                                        <th colspan="5">
                                                            <dx:ASPxMemo ID="infoCotiPROVEE_INVITADOS" runat="server"  Height="44px" Width="100%" ReadOnly="true" >
                                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                                            </dx:ASPxMemo>  
                                                        </th>                                              
                                                    </tr>
                                                    <tr id="trInfoEtapaOC" runat="server" visible="false"> 
                                                        <th colspan="6" align="center"  style="border-bottom: 1px solid Black">
                                                            <dx:ASPxLabel ID="ASPxLabel51" runat="server" Text="ORDEN DE COMPRA" Font-Size="XX-Small" Font-Bold="true"/>
                                                        </th>
                                                    </tr>
                                                    <tr id="trInfoOrden1" runat="server" visible="false">    
                                                        <td><dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="N° Orden Compra:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoOrdenNo" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="Fecha:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoOrdenFecha" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel19" runat="server" Text="Total:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoOrdenTotal" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                  
                                                            </dx:ASPxTextBox>
                                                        </td>                                                       
                                                    </tr>
                                                    <tr id="trInfoOrden2" runat="server" visible="false"> 
                                                        <td><dx:ASPxLabel ID="ASPxLabel40" runat="server" Text="Tipo Compra:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoOrdenTipo" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel36" runat="server" Text="Fecha Est.:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoOrdenFechaEstIngreso" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr id="trInfoOrden3" runat="server" visible="false">                                                        
                                                        <td><dx:ASPxLabel ID="ASPxLabel37" runat="server" Text="Proveedor Adju.:" /></td>
                                                        <th colspan="5" >
                                                            <dx:ASPxTextBox ID="infoOrdenProveeAdj" runat="server" Width="100%" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </th>
                                                    </tr>
                                                    <tr id="trInfoEtapaIngresoAlmacen" runat="server" visible="false"> 
                                                        <th colspan="6" align="center"  style="border-bottom: 1px solid Black">
                                                            <dx:ASPxLabel ID="ASPxLabel52" runat="server" Text="INGRESO ALMACEN" Font-Size="XX-Small" Font-Bold="true"/>
                                                        </th>
                                                    </tr>
                                                    <tr id="trInfoIngAlm1" runat="server" visible="false">    
                                                        <td><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="N° Ingreso Almacén:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoIngAlmNo" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel20" runat="server" Text="Fecha:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoIngAlmFecha" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel21" runat="server" Text="Total:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoIngAlmTotal" HorizontalAlign="Right" runat="server" Width="100px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>
                                                    <tr id="trInfoIngAlm2" runat="server" visible="false">    
                                                        <td><dx:ASPxLabel ID="ASPxLabel44" runat="server" Text="N° Docto.:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoIngAlmNoDocto" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel45" runat="server" Text="Tipo:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoIngAlmTipoDocto" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>                                                        
                                                    </tr>
                                                    <tr id="trEtapaInfoQuedan" runat="server" visible="false"> 
                                                        <th colspan="6" align="center"  style="border-bottom: 1px solid Black;">
                                                            <dx:ASPxLabel ID="ASPxLabel53" runat="server" Text="QUEDAN" Font-Size="XX-Small" Font-Bold="true"/>
                                                        </th>
                                                    </tr>
                                                    <tr id="trInfoQuedan" runat="server" visible="false">    
                                                        <td><dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="N° Quedan:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoQuedanNo" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel23" runat="server" Text="Fecha:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoQuedanFecha" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel24" runat="server" Text="Total:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoQuedanTotal" HorizontalAlign="Right" runat="server" Width="100px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td></td>
                                                    </tr>
                                                    <tr id="trEtapaInfoCheque" runat="server" visible="false"> 
                                                        <th colspan="6" align="center"  style="border-bottom: 1px solid Black">
                                                            <dx:ASPxLabel ID="ASPxLabel54" runat="server" Text="CHEQUE" Font-Size="XX-Small" Font-Bold="true"/>
                                                        </th>
                                                    </tr>
                                                     <tr id="trInfoCheque1" runat="server" visible="false">    
                                                        <td><dx:ASPxLabel ID="ASPxLabel32" runat="server" Text="N° Cheque:" /></td>
                                                        <td>
                                                            <dx:ASPxTextBox ID="infoChequeNo" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel33" runat="server" Text="Banco:" /></td>
                                                        <th colspan="3">
                                                            <dx:ASPxTextBox ID="infoChequeBanco" runat="server" Width="100%" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </th>                                                                   
                                                    </tr>
                                                    <tr id="trInfoCheque2" runat="server" visible="false">
                                                        <td><dx:ASPxLabel ID="ASPxLabel34" runat="server" Text="Fecha:" /></td>
                                                        <td>                                                            
                                                            <dx:ASPxTextBox ID="infoChequeFecha" HorizontalAlign="Right" runat="server" Width="80px" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td><dx:ASPxLabel ID="ASPxLabel35" runat="server" Text="Monto:" /></td>
                                                        <th colspan="4">                                                             
                                                            <dx:ASPxTextBox ID="infoChequeMonto" HorizontalAlign="Right" runat="server" Width="100%" ClientEnabled="false" >                                        
                                                                <DisabledStyle ForeColor="Black"></DisabledStyle>                                                                
                                                            </dx:ASPxTextBox> 
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
        </table>
        <dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />            
        <uc1:ucListaREQDETA id="ucListaREQDETA1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="true" runat="server"></uc1:ucListaREQDETA>                                    
                        
                <dx:ASPxPopupControl ID="pcProcesarSolicitud" runat="server" CloseAction="CloseButton" Modal="True" Width="200px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcProcesarSolicitud"
        HeaderText="Procesando Solicitud" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">  
                        <dx:ASPxLabel ID="lblpcError" runat="server" Font-Bold="true" ForeColor="Red" /><br />                                              
                        <table width="200px" >
                            <tr id="trOpcion" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel6" Text="APROBAR:" runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxRadioButtonList ID="rblAprobar" runat="server" Border-BorderStyle="None"   
                                        ValueType="System.Boolean" ItemSpacing="30px" RepeatDirection="Horizontal">
                                        <ValidationSettings RequiredField-IsRequired="true" ErrorText="Seleccione una opcion">
<RequiredField IsRequired="True"></RequiredField>
                                        </ValidationSettings> 
                                        <Items>
                                            <dx:ListEditItem Text="Sí" Value="true" /> 
                                            <dx:ListEditItem Text="No" Value="false" />
                                        </Items>

<Border BorderStyle="None"></Border>
                                    </dx:ASPxRadioButtonList>
                                </td>                                
                            </tr>
                            <tr id="trNumReferencia" align="left" runat="server" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="lblNumReferencia" Text="REFERENCIA:" Width="150px"  runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxTextBox ID="txtNumReferencia" runat="server" Width="120px" Font-Bold="true" HorizontalAlign="Right" >         
                                        <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" ErrorText="Ingrese Numero">
<RequiredField IsRequired="True"></RequiredField>
                                        </ValidationSettings>                                
                                    </dx:ASPxTextBox> 
                                </td>                                
                            </tr>
                            <tr id="trFechaReferencia" runat="server" align="left"  visible="false">
                                <td>
                                    <dx:ASPxLabel ID="lblFechaReferencia" Text="FECHA:" runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxDateEdit ID="dteFechaReferencia" AutoPostBack="false" runat="server" HorizontalAlign="Right"   
                                        DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                        EditFormatString="dd/MM/yyyy" Width="120px"  >
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                            <RequiredField ErrorText="Ingrese fecha del movimiento" IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxDateEdit>
                                </td>                                
                            </tr>  
                            <tr id="trProveedoresInvitados" runat="server" align="left"  visible="false">                               
                                <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="PROVEEDORES INVITADOS:" /></td>
                                <td><dx:ASPxMemo ID="txtPROVEE_INVITADOS" runat="server"  Height="60px" MaxLength="2000" Width="300px">
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                    </dx:ASPxMemo> </td>
                            </tr>                              
                            <tr id="trTotal_SIVA" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel11" Text="TOTAL SIN IVA:"  runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speTotalSinIva" runat="server" AutoPostBack="true" HorizontalAlign="Right" AllowUserInput="true" Width="120px" MinValue="0" DecimalPlaces="2" >                                                                                
                                        <SpinButtons ShowIncrementButtons="false"></SpinButtons>
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                            <RequiredField ErrorText="Ingrese un valor" IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxSpinEdit>    
                                </td>                                
                            </tr>  
                            <tr id="trTotal_IVA" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel12" Text="IVA:"  runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speTotalIva" runat="server" AutoPostBack="true" HorizontalAlign="Right" AllowUserInput="true" Width="120px" MinValue="0" DecimalPlaces="2"  >                                                                                
                                        <SpinButtons ShowIncrementButtons="false"></SpinButtons>
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                            <RequiredField ErrorText="Ingrese un valor" IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxSpinEdit>    
                                </td>                                
                            </tr>  
                            <tr id="trTotal_CIVA" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel10" Text="TOTAL:"  runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speTotal" runat="server" HorizontalAlign="Right" AllowUserInput="true" Width="120px" MinValue="0" ClientEnabled="false"   
                                        DecimalPlaces="2"  >                                                                                
                                        <SpinButtons ShowIncrementButtons="false"></SpinButtons>
                                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                            <RequiredField ErrorText="Ingrese un valor" IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxSpinEdit>    
                                </td>                                
                            </tr>     
                            <tr id="trTipoCompra" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel25" Text="TIPO COMPRA:" runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxRadioButtonList ID="rblTipoCompra" runat="server" Border-BorderStyle="None"   
                                        ValueType="System.Boolean" ItemSpacing="30px" RepeatDirection="Horizontal">
                                        <ValidationSettings RequiredField-IsRequired="true" ErrorText="Seleccione una opcion">
                                            <RequiredField IsRequired="True"></RequiredField>
                                        </ValidationSettings> 
                                        <Items>
                                            <dx:ListEditItem Text="Local" Value="true" /> 
                                            <dx:ListEditItem Text="Extranjera" Value="false" />
                                        </Items>

                                      <Border BorderStyle="None"></Border>
                                    </dx:ASPxRadioButtonList>
                                </td>                                
                            </tr>   
                            <tr id="trFechaEstIngreso" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel38" Text="FECHA ESTIMADA INGRESO:" runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxDateEdit ID="dteFechaEstimadaIngreso" AutoPostBack="false" runat="server" HorizontalAlign="Right"   
                                        DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                        EditFormatString="dd/MM/yyyy" Width="120px"  >
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                            <RequiredField ErrorText="Ingrese fecha del movimiento" IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxDateEdit>
                                </td>                                
                            </tr>                                   
                            <tr id="trProveedorAdjudicado" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel39" Text="PROVEEDOR ADJUDICADO:" runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxTextBox ID="txtProveedorAdjudicado" runat="server" Width="400px" >         
                                        <ValidationSettings RequiredField-IsRequired="true" ErrorText="Ingrese Proveedor Adjudicado">
                                        <RequiredField IsRequired="True"></RequiredField>
                                        </ValidationSettings>                                
                                    </dx:ASPxTextBox> 
                                </td>                                
                            </tr>     
                            <tr id="trDoctoCompra1" runat="server" align="left" visible="false">
                                <th colspan="2" align="center">
                                    <dx:ASPxLabel ID="ASPxLabel41" Text="Documento de Compra"  runat="server" Font-Bold="true"  >
                                    </dx:ASPxLabel>
                                </th>                                                         
                            </tr>    
                            <tr id="trDoctoCompra2" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel42" Text="N° DOCTO. COMPRA:" runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxTextBox ID="txtNoDoctoCompra" runat="server" Width="120px" >         
                                        <ValidationSettings RequiredField-IsRequired="true" ErrorDisplayMode="ImageWithTooltip" ErrorText="Ingrese No. de Documento de Compra">
                                        <RequiredField IsRequired="True"></RequiredField>
                                        </ValidationSettings>                                
                                    </dx:ASPxTextBox> 
                                </td>           
                            </tr> 
                            <tr id="trDoctoCompra3" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel43" Text="TIPO:" runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cbxTipoDoctoCompra" runat="server" ValueType="System.Int32" Width="120px" DropDownStyle="DropDownList">
                                    <Items>
                                        <dx:ListEditItem Text="CCF" Value="1" />  
                                        <dx:ListEditItem Text="POLIZA" Value="2" />                                        
                                    </Items>                                                            
                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" >
                                        <RequiredField IsRequired="true" ErrorText="Seleccione Tipo de Documento"  />  
                                    </ValidationSettings>
                                    </dx:ASPxComboBox>  
                                </td>           
                            </tr>
                            <tr id="trChequeBANCO" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel46" Text="BANCO:" runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxTextBox ID="txtBANCO_CHQ" runat="server" Width="300px" >         
                                        <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" ErrorDisplayMode="ImageWithTooltip" >
                                        <RequiredField ErrorText="Ingrese Nombre del Banco" IsRequired="True"></RequiredField>
                                        </ValidationSettings>                                
                                    </dx:ASPxTextBox> 
                                </td>           
                            </tr>
                            <tr id="trChequeFECHA" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel47" Text="FECHA:" runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxDateEdit ID="dteFECHA_CHQ" AutoPostBack="false" runat="server" HorizontalAlign="Right"   
                                        DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                        EditFormatString="dd/MM/yyyy" Width="120px"  >
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                            <RequiredField ErrorText="Ingrese fecha del Cheque" IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxDateEdit>
                                </td>           
                            </tr>
                            <tr id="trChequeMONTO" runat="server" align="left" visible="false">
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel48" Text="MONTO:" runat="server" >
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speMONTO_CHQ" runat="server" AutoPostBack="true" HorizontalAlign="Right" AllowUserInput="true" Width="120px" MinValue="0" DecimalPlaces="2" >                                                                                
                                        <SpinButtons ShowIncrementButtons="false"></SpinButtons>
                                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                            <RequiredField ErrorText="Ingrese monto del cheque" IsRequired="True" />
                                        </ValidationSettings>
                                    </dx:ASPxSpinEdit>
                                </td>           
                            </tr>
                        </table>
                        <hr />
                        <table width="100%">                            
                            <tr>
                                <td style="padding-right:7px; text-align:right">
                                    <dx:ASPxButton ID="btnAceptar" runat="server" AutoPostBack="true" Text="Aceptar">                                        
                                    </dx:ASPxButton>    
                                </td>
                                <td style="padding-left:7px">  
                                    <dx:ASPxButton ID="btnCancelar" runat="server" Text="Cancelar">
                                        <ClientSideEvents Click="function(s,e){pcProcesarSolicitud.Hide()}" /> 
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

                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxCallbackPanel>
        </td>
    </tr>
</table>

<asp:ObjectDataSource ID="odsPeriodoReq" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cPERIODOREQ">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="DESCRIP_PERIODO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsReqEtapa" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cREQETAPA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ID_REQETAPA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSolicitante" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cSOLICITANTE">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="CODIGO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSeccion" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cSECCION">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="CODIGO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

