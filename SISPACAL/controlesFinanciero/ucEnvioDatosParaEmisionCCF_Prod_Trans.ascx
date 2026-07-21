<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucEnvioDatosParaEmisionCCF_Prod_Trans.ascx.vb" Inherits="controlesFinanciero_ucEnvioDatosParaEmisionCCF_Prod_Trans" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosBodega" Src="~/controlesBodega/ucCriteriosBodega.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<table id="Table1" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td> <p></p> </td>
    </tr>
    <tr>
        <td align="center" class="EncabezadoSecciones"><asp:Label id="Label1" style="Z-INDEX: 101" runat="server">Envio de Formato para CCF y Liquidación catorcenal</asp:Label></td>
    </tr>
    <tr>
        <td><uc1:ucCriteriosBodega id="ucCriteriosBodega1" runat="server"></uc1:ucCriteriosBodega></td>
    </tr>
    <tr>
        <td>
            <p></p>
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="myCallback1" OnCallback="ASPxCallback1_Callback">
                <ClientSideEvents 
                    CallbackComplete="function(s, e) {
                        myButton.SetEnabled(true);
                        myTimer.SetEnabled(false);
                        myLabel.SetText('Proceso completado');
                }" />
            </dx:ASPxCallback>
            

            <dx:ASPxCallback ID="ASPxCallback2" runat="server" ClientInstanceName="myCallback2" OnCallback="ASPxCallback2_Callback">
                <ClientSideEvents 
                    CallbackComplete="function(s, e) {
                        var labelText = myLabel.GetText();
                        if(labelText != 'Proceso completado'){
                        myLabel.SetText('Avance del proceso: ' + e.result + ' ');
                    }
                    }" />
            </dx:ASPxCallback>
        
            <dx:ASPxTimer ID="ASPxTimer1" runat="server" ClientInstanceName="myTimer" Enabled="False" Interval="1000">
                <ClientSideEvents 
                    Tick="function(s, e) {
                        myCallback2.PerformCallback();
                    }" />
            </dx:ASPxTimer>
        

            
        </td>
    </tr>    
</table>
<table width="800x" border="0">
            <tr>
                <td width="200px">
                   <dx:ASPxButton ID="ASPxButton1" runat="server" AutoPostBack="False" Text="Iniciar proceso" ClientInstanceName="myButton" Theme="iOS">
                    <ClientSideEvents 
                        Click="function(s, e) {
                            if(ucCriteriosBodega_cbxTIPO_PLANILLA.GetText()==''){
                                alert('Seleccione el tipo de planilla');                                
                            }
                            else{
                                s.SetEnabled(false);
                                myCallback1.PerformCallback();
                                myLabel.SetText('Avance del proceso: 0% ');
                                myLabel.SetClientVisible(true);
                                myTimer.SetEnabled(true);
                            }                            
                        }" />
                    </dx:ASPxButton>
                </td>
                <td>
                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" ClientInstanceName="myLabel" ClientVisible="False" Theme="iOS">
                    </dx:ASPxLabel>
                </td>
            </tr>            
</table>