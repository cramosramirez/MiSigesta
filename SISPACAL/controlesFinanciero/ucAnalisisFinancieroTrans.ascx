<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAnalisisFinancieroTrans.ascx.vb" Inherits="controlesFinanciero_ucAnalisisFinancieroTrans" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPRE_ANALISIS_DETA_TRANS" Src="~/controlesTransporte/ucListaPRE_ANALISIS_DETA_TRANS.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBusquedaTransportista" Src="~/controlesContrato/ucBusquedaTransportista.ascx" %>

<style type="text/css">
    
    table#mitabla {
    border: 1px solid LightGray;
    border-collapse: collapse;
    }
    table#mitabla th 
    {
        border: 1px solid LightGray;
        border-collapse: collapse;
    }
    table#mitabla td
    {
        border: 1px solid LightGray;
        border-collapse: collapse;
    }
    
    table#mitabla2 {
        border: 0px     
    }
    table#mitabla2 th 
    {
        border: 0px;
    }
    table#mitabla2 td
    {
        border: 0px;
    }
    </style>
<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<table width="100%" border="0">
    <tr>
	    <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Análisis Financiero Transportista</asp:Label></td>
    </tr>
</table>
<table runat="server" id="trFinanciamiento" width="100%" >
    <tr>
        <td>
            <table>
                <tr>
                    <td><dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="Fecha elaboración:" /></td>
                    <td><dx:ASPxTextBox ID="txtFECHA" runat="server" Width="150px" ClientEnabled="false" HorizontalAlign="Right" >
                             <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
                        </dx:ASPxTextBox>
                    </td>
                    <td></td>
                    <td></td>   
                    <td></td>                                
                </tr>
                <tr>
                    <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Zafra:" /></td>
                    <td>
                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server" AutoPostBack="true" HorizontalAlign="Right" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="150px" />                                        
                    </td>
                    <td></td>
                    <td></td>   
                    <td></td>  
                </tr>
                <tr>
                    <td>
                        <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Cód. Transportista:" />                
                    </td>
                    <td>
                        <dx:ASPxSpinEdit ID="speCODTRANSPORT" runat="server" AutoPostBack="true" AllowNull="true" AllowUserInput="true" Width="150px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
                        </dx:ASPxSpinEdit>   
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnBuscar" AutoPostBack="true" ToolTip="Buscar transportista"  runat="server" Width="20px"   Text="">
                        <Image IconID="find_find_16x16">
                        </Image>
                    </dx:ASPxButton>
                    </td>
                    <td style="padding-left:15px">
                        <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Nombre Transportista:" />                
                    </td>
                    <td>
                        <dx:ASPxTextBox ID="txtNOMBRE_TRANSPORTISTA" runat="server" ClientEnabled="false" Width="300px">                            
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
                        </dx:ASPxTextBox>
                    </td>    
                </tr>                        
            </table>          
        </td>
    </tr> 
    <tr>
        <td>
            <uc1:ucListaPRE_ANALISIS_DETA_TRANS id="ucListaPRE_ANALISIS_DETA_TRANS1" PermitirEliminar="false" PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" PermitirEditar="true" runat="server"></uc1:ucListaPRE_ANALISIS_DETA_TRANS>
        </td>
    </tr>
</table>

<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<dx:ASPxPopupControl ID="pcBusquedaTransportista" runat="server" CloseAction="CloseButton" Modal="True" Width="300px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcBusquedaTransportista"
        HeaderText="Búsqueda por nombre de Transportista" AllowDragging="True" PopupAnimationType="None">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">  
                            <uc1:ucBusquedaTransportista id="ucBusquedaTransportista1" runat="server" />
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl>

