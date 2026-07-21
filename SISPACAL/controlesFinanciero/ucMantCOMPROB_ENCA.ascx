<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCOMPROB_ENCA.ascx.vb" Inherits="controles_ucMantCOMPROB_ENCA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCOMPROB_ENCA" Src="~/controlesFinanciero/ucListaCOMPROB_ENCA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCREFISCAL_PROVEEDOR" Src="~/controlesFinanciero/ucVistaDetalleCREFISCAL_PROVEEDOR.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	         <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
             </tr>
		     <tr>                
		       <td align="center" class="EncabezadoSecciones"><br /><asp:Label id="lblTitulo" runat="server">COMPROBANTES DE RETENCION EMITIDOS POR PLANILLA - ASOCIACION DE CREDITO FISCAL DEL PROVEEDOR</asp:Label></td>
		     </tr>
             <tr>
                 <td>
                      <dx:ASPxFormLayout ID="ucCriteriosComprobEnca" runat="server" SettingsItemCaptions-Location="Left" Name="glPagoCuenta">
                       <Items>
                           <dx:LayoutGroup Caption="Criterios de busqueda" ColCount="1" GroupBoxDecoration="HeadingLine">
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
	         <tr>
                <td>
                <uc1:ucListaCOMPROB_ENCA id="ucListaCOMPROB_ENCA1" runat="server"></uc1:ucListaCOMPROB_ENCA>
                <uc1:ucVistaDetalleCREFISCAL_PROVEEDOR ID="ucVistaDetalleCREFISCAL_PROVEEDOR1" runat="server" Visible="false" ></uc1:ucVistaDetalleCREFISCAL_PROVEEDOR>
                </td>
            </tr>
    </TBODY>
</TABLE>

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