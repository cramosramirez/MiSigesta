<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAnalisisFinanciero.ascx.vb" Inherits="controlesFinanciero_ucAnalisisFinanciero" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTRATO" Src="~/controlesContrato/ucListaCONTRATO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPRE_ANALISIS_DETA" Src="~/controlesFinanciero/ucListaPRE_ANALISIS_DETA.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBusquedaProveedor" Src="~/controlesContrato/ucBusquedaProveedor.ascx" %>

<script type="text/javascript">
    var postponedCallbackRequired = false;

    function CrearSolicAgricola() {
        window.open("../Madurante/wfMantSOLIC_AGRICOLA.aspx?op=1", "_blank", "")
    }
    function CrearSolicAnticipo() {
        window.open("../Madurante/wfMantSOLIC_ANTICIPO.aspx?op=1", "_blank", "")
    }
    function CrearSolicOPI() {
        window.open("../Financiero/wfMantSOLIC_OPI.aspx?op=1", "_blank", "")
    }
    function CrearSolicMembresia() {
        window.open("../Financiero/wfMantMEMBRE_GREMIAL.aspx?op=1", "_blank", "")
    }
</script>

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
    .auto-style1 {
        height: 23px;
    }
    .auto-style2 {
        width: 100px;
        height: 23px;
    }
</style>
<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<table width="100%" border="0">
    <tr>
	    <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Análisis Financiero</asp:Label></td>
    </tr>
</table>
<table id="trCriterios" runat="server" width="100%" border="0">   
   <tr>
     <td>
      <table>
        <tr>
            <td>
                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Cód. Proveedor:" />                
            </td>
            <td>
                <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true" AllowUserInput="true" Width="150px" HorizontalAlign="Right" SpinButtons-ShowIncrementButtons="false" >                                
                </dx:ASPxSpinEdit>   
            </td>
            <td>
                <dx:ASPxButton ID="btnBuscar" AutoPostBack="true" ToolTip="Buscar proveedor"  runat="server" Width="20px"   Text="">
                <Image IconID="find_find_16x16">
                </Image>
            </dx:ASPxButton>
            </td>
            <td style="padding-left:15px">
                <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Nombre Proveedor:" />                
            </td>
            <td>
                <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px"  />                            
            </td>                       
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Zafra:" />                
            </td>
            <td>
                <dx:ASPxComboBox ID="cbxZAFRA" runat="server" AutoPostBack="true" HorizontalAlign="Right" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="150px" />                                        
            </td>
           <td></td>  
           <td></td>     
           <td></td>     
        </tr>
      </table>
      </td>
   </tr>
    <tr>
        <td>
       <uc1:ucListaCONTRATO id="ucListaCONTRATO1" PermitirEliminar="false" PermitirEditar="false" PermitirRowHotTrack="false" PermitirFocoEnFilas="false" MostrarCheckVariaSeleccion="true" VerCODISOCIO="false" PermitirVistaPrevia="true" runat="server"></uc1:ucListaCONTRATO>
        </td>
    </tr>   
</table>

<table runat="server" id="trFinanciamiento" width="100%" >
    <tr>
        <td>
            <table>
                <tr>
                    <td><dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="Fecha elaboración:" /></td>
                    <td><dx:ASPxTextBox ID="txtFECHA" runat="server" Width="80px" ClientEnabled="false"  >
                             <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
                        </dx:ASPxTextBox>
                    </td>
                    <td></td>
                    <td></td>   
                    <td style="width:500px" ><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="COMENTARIOS/OBSERVACIONES" /></td>                 
                </tr>
                <tr>
                    <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Código productor:" /></td>
                    <td>
                        <dx:ASPxTextBox ID="txtCODIPROVEEDOR" runat="server" Width="80px" ClientEnabled="false">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />    
                        </dx:ASPxTextBox>
                    </td>
                    <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Nombre productor:" /></td>
                    <td>
                        <dx:ASPxTextBox ID="txtNOMBRE_PRODUCTOR" runat="server" Width="300px" ClientEnabled="false"  >
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />    
                        </dx:ASPxTextBox>
                    </td>
                    <td rowspan="3" >
                        <dx:ASPxMemo ID="txtOBSERVACIONES" runat="server" Width="100%" Height="100%" MaxLength="2000"   />  
                    </td> 
                </tr>
                <tr>
                    <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Zona(s):" /></td>
                    <th colspan="3" >
                        <dx:ASPxTextBox ID="txtZONAS" runat="server" ClientEnabled="false" Width="100%">
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />    
                        </dx:ASPxTextBox>
                    </th>
                </tr>
                <tr>
                    <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Número(s) Contrato(s):" /></td>
                    <th colspan="3" >
                        <dx:ASPxTextBox ID="txtCONTRATOS" runat="server" ClientEnabled="false" Width="100%" >
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />    
                        </dx:ASPxTextBox>
                    </th>
                </tr>                            
            </table>          
        </td>
    </tr> 
    <tr>
        <td>
            <uc1:ucListaPRE_ANALISIS_DETA id="ucListaPRE_ANALISIS_DETA1" PermitirEliminar="false" PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" PermitirEditar="true" runat="server"></uc1:ucListaPRE_ANALISIS_DETA>
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

<dx:ASPxPopupControl ID="pcBusquedaProveedor" runat="server" CloseAction="CloseButton" Modal="True" Width="300px" HeaderStyle-Font-Bold="true" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcBusquedaProveedor"
        HeaderText="Búsqueda por nombre de Proveedor" AllowDragging="True" PopupAnimationType="None">        
<HeaderStyle Font-Bold="True"></HeaderStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btnCancelar">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server">  
                            <uc1:ucBusquedaProveedor id="ucBusquedaProveedor1" runat="server" />
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
</dx:ASPxPopupControl>