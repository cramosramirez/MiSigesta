<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucExportacionTarifasCAT.ascx.vb" Inherits="controlesFinanciero_ucExportacionTarifasCAT" %>

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
                    <td>
                        <table>
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Names="Arial"  Font-Size="Medium" Text="Zafra:" />
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32"  DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" ValueField="ID_ZAFRA" AutoPostBack="true" TextField="NOMBRE_ZAFRA"  Width="150px" >               
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel3" runat="server" Font-Names="Arial"  Font-Size="Medium" Text="Pre-corte:" />
                                </td>
                                <td>
                                    <dx:ASPxSpinEdit runat="server" ID="spePRECORTE" NumberType="Integer" Width="150px" SpinButtons-ShowIncrementButtons="false" ></dx:ASPxSpinEdit>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:center">
                        <dx:ASPxLabel ID="Label4" runat="server" Font-Names="Arial" Font-Bold="true" Font-Size="Medium" Text="EXPORTACION A EXCEL" />
                    </td>
                </tr>
                <tr>                      
                    <td style="text-align:center">
                         <dx:ASPxButton ID="btnExportar" runat="server" Text="Exportar a Excel Aplicación de Tarifas de flete, carga y cosecha en Pre-corte" Width="200px" Theme="SoftOrange" >                                                  
                             <ClientSideEvents Click="MostraProcesando" />
                         </dx:ASPxButton>
                    </td>
                </tr>                
                <tr>
                    <td><br /><hr /><br /></td>
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

<asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>