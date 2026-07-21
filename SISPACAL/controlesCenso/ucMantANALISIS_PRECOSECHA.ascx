<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantANALISIS_PRECOSECHA.ascx.vb" Inherits="controles_ucMantANALISIS_PRECOSECHA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaANALISIS_PRECOSECHA" Src="~/controlesCenso/ucListaANALISIS_PRECOSECHA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleANALISIS_PRECOSECHA" Src="~/controlesCenso/ucVistaDetalleANALISIS_PRECOSECHA.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tbody>
	       <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Ordenes de Análisis de Pre-Cosecha</asp:Label></td>
		   </tr>
		   <tr>
			   <td>
                   <dx:ASPxFormLayout ID="ucCriteriosAnalisisPrecosechaLayout" runat="server" SettingsItemCaptions-Location="Left" 
                    Name="glCriterios">
                       <Items>
                           <dx:LayoutGroup Caption="Criterios de búsqueda" ColCount="3" 
                               GroupBoxDecoration="HeadingLine">
                               <Items>
                                   <dx:LayoutItem Caption="Zafra:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px">
                                                </dx:ASPxComboBox>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Zona:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" AutoPostBack="true" runat="server" DataSourceID="odsZona" TextField="DESCRIP_ZONA" ValueField="ZONA" Width="120px" >                            
                                               </dx:ASPxComboBox>         
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Sub Zona:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxComboBox ID="cbxSUB_ZONA" ClientInstanceName="cbxSUB_ZONA" TextField="DESCRIP_SUB_ZONA" ValueField="SUB_ZONA" runat="server" DataSourceID="odsSubZona" Width="120px">                                                            
                                                </dx:ASPxComboBox>     
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Cod. Provee:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                               <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AutoPostBack="True" Width="120px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Cod. Socio:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxSpinEdit ID="speCODISOCIO" runat="server" AutoPostBack="True" Width="120px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Nombre Proveedor:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="280px">
                                                </dx:ASPxTextBox>
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
            <td><uc1:ucListaANALISIS_PRECOSECHA id="ucListaANALISIS_PRECOSECHA1" PermitirVistaPrevia="true" runat="server"></uc1:ucListaANALISIS_PRECOSECHA>
                <uc1:ucVistaDetalleANALISIS_PRECOSECHA ID="ucVistaDetalleANALISIS_PRECOSECHA1" runat="server" Visible="false" ></uc1:ucVistaDetalleANALISIS_PRECOSECHA></td>
        </tr>
    </tbody>
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
<asp:ObjectDataSource ID="odsZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsSubZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="Recuperar" 
    TypeName="SISPACAL.BL.cSUB_ZONAS">
    <SelectParameters>        
       <asp:Parameter DefaultValue="" Name="ZONA" Type="String" />
        <asp:Parameter DefaultValue="True" Name="agregarVacio" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="agregarTodos" Type="Boolean" />
    </SelectParameters>    
</asp:ObjectDataSource>