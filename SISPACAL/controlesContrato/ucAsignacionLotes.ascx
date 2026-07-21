<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAsignacionLotes.ascx.vb" Inherits="controlesContrato_ucAsignacionLotes" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>




<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosLotes" Src="~/controlesContrato/ucCriteriosLotes.ascx" %>

<%@ Register src="ucListaLOTES.ascx" tagname="ucListaLOTES" tagprefix="uc2" %>

<script type="text/javascript">
    var postponedCallbackRequired = false;

    function MostrarPopup(e) {
        if (e) {
            if (grid.GetSelectedRowCount() > 0) {
                cbxAGRONOMO.SetValue('');
                pcAsignarTecnico.Show();
            }   
            else 
                AsignarMensaje('Debe seleccionar algun lote')            
        }
        else
            pcAsignarTecnico.Hide()
    }
    function AsignarLotes(s, e) {
        cpAsignacionLotes.PerformCallback('');           
    }
    function OnEndCallback(s, e) {        
        if (s.cpResultado == 'OK') 
            AsignarMensaje('La asignacion de lotes se realizo con exito!')        
        else if (s.cpResultado != '')
            AsignarMensaje(s.cpResultado)                  
                   
        if (postponedCallbackRequired) {
            cpAsignacionLotes.PerformCallback();
            postponedCallbackRequired = false;
        }
    }   
</script>
<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr><td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td></tr>
    <tr><td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">Asignación de Lotes a Técnico Agrícola</asp:Label></td></tr>      
</table>
<dx:ASPxCallbackPanel ID="cpAsignacionLotes" ClientInstanceName="cpAsignacionLotes" runat="server" ShowLoadingPanel="false" Width="100%" >    
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>

    <ClientSideEvents EndCallback="OnEndCallback"></ClientSideEvents>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">  
                <table width="100%">
                    <tr>
                        <td>
                         <uc1:ucCriteriosLotes id="ucCriteriosLotes1" runat="server"></uc1:ucCriteriosLotes>   
                        </td>
                    </tr>
                    <tr>
                        <td>        
                            <uc2:ucListaLOTES ID="ucListaLOTES1" PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" VerCUI="false" VerAREA="false" VerTONEL_TC="false" VerTONELADAS="false" VerCODISOCIO="false" VerANIOZAFRA="false" VerNOMBRE_TECNICO_ASIGNADO="true" MostrarCheckTodos="true" MostrarCheckVariaSeleccion="true" TamanoPagina="10" PermitirEliminar="false" PermitirEditar="false" runat="server" />
                        </td>
                    </tr>
                </table>
                <dx:ASPxPopupControl ID="pcAsignarTecnico" runat="server" CloseAction="CloseButton" Modal="True" Width="400px"  
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcAsignarTecnico"
                    HeaderText="Asignar Técnico a Lotes" AllowDragging="True" PopupAnimationType="None" EnableViewState="True">        
                    <ContentCollection>
                        <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                            <dx:ASPxPanel ID="Panel1" runat="server">
                                <PanelCollection>
                                    <dx:PanelContent ID="PanelContent1" runat="server">
                                        <table>
                                            <tr>
                                                <td><dx:ASPxLabel ID="label1" runat="server" Text="Tecnico"  ></dx:ASPxLabel></td>
                                                <td><dx:ASPxComboBox ID="cbxAGRONOMO" ClientInstanceName="cbxAGRONOMO" Width="300px" DropDownStyle="DropDownList" runat="server" DataSourceID="odsAgronomo" 
                                                                     ValueField="CODIAGRON" TextField="APELLIDO_AGRONOMO" ValueType="System.String" TextFormatString="{0} {1} {2}" IncrementalFilteringMode="Contains">
                                                                         <Columns>
                                                                            <dx:ListBoxColumn Caption="Codigo" FieldName="CODIAGRON" Width="80px" />
                                                                            <dx:ListBoxColumn Caption="Apellidos" FieldName="APELLIDO_AGRONOMO" Width="120px" />
                                                                            <dx:ListBoxColumn Caption="Nombres" FieldName="NOMBRE_AGRONOMO" Width="120px" />                                                            
                                                                        </Columns>
                                                                    </dx:ASPxComboBox></td>
                                            </tr>
                                            <tr>
                                                <td><dx:ASPxLabel ID="lblZona" runat="server" Text="Zona"  ></dx:ASPxLabel></td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" Width="300px" DropDownStyle="DropDownList" runat="server" DataSourceID="odsZona" 
                                                        ValueField="ZONA" TextField="DESCRIP_ZONA" ValueType="System.String"  IncrementalFilteringMode="Contains">                                                                         
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                        </table>                                       
                                        <table>
                                            <tr>
                                                <td>
                                                    <dx:ASPxButton ID="btnAceptar" AutoPostBack="true" Text="Aceptar" runat="server" >                                                          
                                                    </dx:ASPxButton>
                                                </td>
                                                <td>
                                                    <dx:ASPxButton ID="btnCancelar" Text="Cancelar" runat="server" >    
                                                        <ClientSideEvents Click="function(s,e){MostrarPopup(false)}" />                                                           
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
<dx:ASPxLoadingPanel ID="ldpCargando" Text="Cargando" ClientInstanceName="ldpCargando" runat="server" Modal="True" />
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerZafraActiva" 
    TypeName="SISPACAL.BL.cZAFRA">      
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsAgronomo" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaParaContrato" 
    TypeName="SISPACAL.BL.cAGRONOMO">
    <SelectParameters>        
        <asp:Parameter DefaultValue="APELLIDO_AGRONOMO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
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