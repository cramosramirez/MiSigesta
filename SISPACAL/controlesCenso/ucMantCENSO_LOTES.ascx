<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCENSO_LOTES.ascx.vb" Inherits="controles_ucMantCENSO_LOTES" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCENSO_LOTES" Src="~/controlesCenso/ucListaCENSO_LOTES.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>





<script type="text/javascript">   
    var postponedCallbackRequired = false;
    var ultCenso = null;

    function CambiandoZafra() {
        if (cbxCENSO.InCallback())
            ultCenso = cbxZAFRA.GetValue().toString();
        else
            cbxCENSO.PerformCallback(cbxZAFRA.GetValue().toString());
    }
    function OnEndCallbackZafra(s, e) {
        if (ultCenso) {
            cbxCENSO.PerformCallback(ultCenso);
            ultCenso = null;
        }
    } 
    function CargarLotes(s, e) {
        if (cpMantCENSO_LOTES.InCallback())
            postponedCallbackRequired = true;
        else {            
            ldpCargando.Show();            
            cpMantCENSO_LOTES.PerformCallback('CargarLotes;');
        }
    }   
    function OnEndCallback(s, e) {
        ldpCargando.Hide();
        if (postponedCallbackRequired) {
            cpMantCENSO_LOTES.PerformCallback();
            postponedCallbackRequired = false;
        }
    }   
    </script>
<style type="text/css">     
   .fto1
   {
       vertical-align:top
   }
   .fto2
   {
       padding-right: 8px
   }
 </style>

<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" HabilitarCallBacks="true" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>
    <tr>
        <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Censo por Lote</asp:Label></td>
    </tr>
    <tr><td><hr /></td></tr>
</table>      
<dx:ASPxCallbackPanel ID="cpMantCENSO_LOTES" ClientInstanceName="cpMantCENSO_LOTES" runat="server" ShowLoadingPanel="false" Width="100%" >
    <ClientSideEvents EndCallback="OnEndCallback"></ClientSideEvents>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">                  
            <table>
                <tr>    
                    <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Zafra:" /></td>
                    <td class="fto2">
                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server" ValueType="System.Int32" DataSourceID="odsZafras" ClientInstanceName="cbxZAFRA" 
                            ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" Width="118px" >   
<ClientSideEvents SelectedIndexChanged="CambiandoZafra"></ClientSideEvents>

                        <ValidationSettings RequiredField-IsRequired="true" ErrorDisplayMode="ImageWithTooltip" RequiredField-ErrorText="Seleccione la Zafra">
<RequiredField IsRequired="True" ErrorText="Seleccione la Zafra"></RequiredField>
                            </ValidationSettings>
                        <ClientSideEvents SelectedIndexChanged="CambiandoZafra" /> 
                        </dx:ASPxComboBox>
                    </td>
                    <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Zona:" /></td>
                    <td class="fto2"><dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA"  runat="server" ValueType="System.String" DataSourceID="odsZonas"
                            ValueField="ZONA" TextField="DESCRIP_ZONA" Width="118px" >  
                            <ValidationSettings RequiredField-IsRequired="true" ErrorDisplayMode="ImageWithTooltip" RequiredField-ErrorText="Seleccione la Zona">
<RequiredField IsRequired="True" ErrorText="Seleccione la Zona"></RequiredField>
                            </ValidationSettings>                  
                    </dx:ASPxComboBox></td>
                    <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Censo:" /></td>
                    <td><dx:ASPxComboBox ID="cbxCENSO" ClientInstanceName="cbxCENSO" runat="server" ValueType="System.Int32" DataSourceID="odsCenso"
                            ValueField="ID_CENSO" TextField="FECHA_CENSO" Width="118px" ShowLoadingPanel="true"  LoadingPanelText="Cargando..."  >  
<ClientSideEvents EndCallback="OnEndCallbackZafra"></ClientSideEvents>

                            <ValidationSettings RequiredField-IsRequired="true" ErrorDisplayMode="ImageWithTooltip" RequiredField-ErrorText="Seleccione el Censo">
<RequiredField IsRequired="True" ErrorText="Seleccione el Censo"></RequiredField>
                            </ValidationSettings>
                            <ClientSideEvents EndCallback="OnEndCallbackZafra"/>                  
                        </dx:ASPxComboBox></td>
                </tr>
            </table>
            <table width="100%">   		   
	                <tr>
                        <td><uc1:ucListaCENSO_LOTES id="ucListaCENSO_LOTES1" PermitirEditarInline="true" NombreGridCliente="ucListaCENSO_LOTES1" runat="server" TamanoPagina="10" PermitirEliminar="false" VerUSUARIO_CREA="False" VerFECHA_CREA="False" VerUSUARIO_ACT="False" VerFECHA_ACT="false"></uc1:ucListaCENSO_LOTES>                            
                        </td>
                    </tr>   
            </table>
            <dx:ASPxHiddenField ID="hf" ClientInstanceName="hf" SyncWithServer="true" runat="server" />
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" ClientInstanceName="ldpCargando" runat="server" Modal="True" 
    Text="Cargando..." Theme="Office2010Blue">
</dx:ASPxLoadingPanel>
 <asp:ObjectDataSource ID="odsZafras" runat="server" TypeName="SISPACAL.BL.cZAFRA" SelectMethod="ObtenerUltimasDosZafras" OldValuesParameterFormatString="original_{0}" >    
 </asp:ObjectDataSource>
 <asp:ObjectDataSource ID="odsZonas" runat="server" TypeName="SISPACAL.BL.cZONAS" SelectMethod="ObtenerLista" OldValuesParameterFormatString="original_{0}" >    
  <SelectParameters>
     <asp:Parameter Name="recuperarHijas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="asColumnaOrden" DefaultValue="DESCRIP_ZONA" Type="String" />
     <asp:Parameter Name="asTipoOrden" DefaultValue="ASC" Type="String" />
  </SelectParameters> 
  </asp:ObjectDataSource>
  <asp:ObjectDataSource ID="odsCenso" runat="server" TypeName="SISPACAL.BL.cCENSO" SelectMethod="ObtenerListaPorZAFRA" >    
  <SelectParameters>
     <asp:Parameter Name="ID_ZAFRA" Type="Int32" />
     <asp:Parameter Name="recuperarHijas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="recuperarForaneas" DefaultValue="false" Type="Boolean" />     
     <asp:Parameter Name="asColumnaOrden" DefaultValue="FECHA_CENSO" Type="String" />
     <asp:Parameter Name="asTipoOrden" DefaultValue="ASC" Type="String" />
  </SelectParameters> 
 </asp:ObjectDataSource>
