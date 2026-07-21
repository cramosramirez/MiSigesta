<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucExportacionExcel.ascx.vb" Inherits="controlesCenso_ucExportacionExcel" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>



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

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<br />
<br />

<table border="0" width="100%">
    <tr>
        <td width="20%"  style="text-align:center">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/ssis-export-excel-file-task.png" />
        </td>
        <td>
            <table  border="0" width="80%" >
                <tr>
                    <td style="text-align:center">
                        <dx:ASPxLabel ID="Label4" runat="server" Font-Names="Arial" Font-Bold="true" Font-Size="Medium" Text="EXPORTACION A EXCEL" />
                    </td>
                </tr>
                <tr>                      
                    <td style="text-align:center">
                         <dx:ASPxButton ID="btnExportar" runat="server" Text="Exportar a Excel Esticaña comparativo de Zafras" Width="200px" Theme="SoftOrange" >                                                  
                             <ClientSideEvents Click="MostraProcesando" />
                         </dx:ASPxButton>
                    </td>
                </tr>                
                <tr>
                    <td><br /><hr /><br /></td>
                </tr> 
                <tr>
                    <td style="text-align:center">
                        <dx:ASPxLabel ID="ASPxLabel10" runat="server" Font-Names="Arial" Font-Bold="true" Font-Size="Medium" Text="SUBIR EXCEL AL SISTEMA" />
                    </td>
                </tr>
                <tr>
                    <td>      
                        <dx:ASPxLabel ID="ASPxLabel3" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Seleccione el archivo a subir al sistema y luego haga clic en "></dx:ASPxLabel>
                        <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Names="Arial" Font-Size="Medium" Font-Bold="true" Text="Subir información"></dx:ASPxLabel>

                    </td> 
                </tr>
                <tr>
                    <td>                        
                        <dx:ASPxUploadControl ID="uploadArchivo" ClientInstanceName="uploadArchivo" runat="server" UploadMode="Advanced" AutoStartUpload="False" Width="100%"
                            ShowProgressPanel="True" Theme="SoftOrange" ShowUploadButton="True" >
                            <UploadButton Text="Subir información">
                            </UploadButton>
                            <AdvancedModeSettings EnableDragAndDrop="False" EnableFileList="False" EnableMultiSelect="False" >
<FileListItemStyle CssClass="pending dxucFileListItem"></FileListItemStyle>
                            </AdvancedModeSettings>
                            <ValidationSettings AllowedFileExtensions=".xlsx" />
                            <BrowseButton Text="Seleccione archivo..." />                           
                            <ClientSideEvents                               
                                FileUploadComplete="ImportacionCompletada"
                                FileUploadStart="MostraProcesando" >
                            </ClientSideEvents>
                        </dx:ASPxUploadControl>
                    </td>
                </tr>                
            </table>            
        </td>
    </tr>
</table>

<dx:ASPxPopupControl ID="pcCosechaExcel" ClientInstanceName="pcCosechaExcel" runat="server"
        Modal="true" ShowOnPageLoad="false" AppearAfter="0" Height="100px"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Text=""
        Width="200px" CloseAction="CloseButton"
        PopupAction="None" ShowHeader="false" CloseAnimationType="Slide" Opacity="80">    
        <ContentStyle HorizontalAlign="Center">
        </ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server">                    
                <table width="100%">
                    <tr>
                        <td>
                        <dx:ASPxImage runat="server" ID="imgModalExpoEsti" ImageUrl="~/imagenes/pinon.gif" Height="197px" Width="236px" />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center">
                            <dx:ASPxLabel ID="ASPxLabel2" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Procesando información. Por favor espere..."></dx:ASPxLabel>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl>
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />
<dx:ASPxPopupControl ID="pcDescargarCosecha" ClientInstanceName="pcDescargarCosecha" runat="server"
            Modal="True" AppearAfter="0" HeaderText="Descarga de archivo" Height="100px"
            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter"
            Width="200px" AllowDragging="True" AllowResize="True" CloseAction="CloseButton"
            PopupAction="None">
            <ContentStyle HorizontalAlign="Center">
            </ContentStyle>
            <ContentCollection>
                <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                    <dx:ASPxLabel ID="aspxMensajeAlerta" runat="server" Text="La información se ha exportado con exito" >
                    </dx:ASPxLabel>
                    <br />
                    <br />
                    <dx:ASPxButton ID="btnDescargarCosecha" runat="server" Text="Descargar archivo Excel" CausesValidation="False"
                        UseSubmitBehavior="False" Theme="SoftOrange">
                        <ClientSideEvents Click="function(s, e) { pcDescargarCosecha.Hide();}" />
                    </dx:ASPxButton>
                </dx:PopupControlContentControl>
            </ContentCollection>
    </dx:ASPxPopupControl>
