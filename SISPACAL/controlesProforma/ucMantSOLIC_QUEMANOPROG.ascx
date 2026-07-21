<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSOLIC_QUEMANOPROG.ascx.vb" Inherits="controles_ucMantSOLIC_QUEMANOPROG" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSOLIC_QUEMANOPROG" Src="~/controlesProforma/ucListaSOLIC_QUEMANOPROG.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLIC_QUEMANOPROG" Src="~/controlesProforma/ucVistaDetalleSOLIC_QUEMANOPROG.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<table id="Table1" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tbody>
	       <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="Label1" style="Z-INDEX: 101" runat="server">Mantenimiento de Solicitudes de Quema no programada</asp:Label></td>
		   </tr>
		   <tr>
			   <td>
                   <dx:ASPxFormLayout ID="ucCriteriosManttoSolicitudQuemaNoProgLayout" runat="server" SettingsItemCaptions-Location="Left" 
                    Name="glCriterios">
                       <Items>
                           <dx:LayoutGroup Caption="Criterios de búsqueda" ColCount="3" 
                               GroupBoxDecoration="HeadingLine">
                               <Items>
                                   <dx:LayoutItem Caption="Zafra:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                               <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px">
                                                </dx:ASPxComboBox>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Zona:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                               <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" AutoPostBack="true" runat="server" DataSourceID="odsZona" TextField="DESCRIP_ZONA" ValueField="ZONA" Width="120px" >                            
                                               </dx:ASPxComboBox>         
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Nombre Lote:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                                                <dx:ASPxTextBox ID="txtNOMBLOTE" runat="server" Width="280px">
                                                </dx:ASPxTextBox>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>                                 
                                   <dx:LayoutItem Caption="Cod. Provee:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                               <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AutoPostBack="True" Width="120px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Cod. Socio:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                                                <dx:ASPxSpinEdit ID="speCODISOCIO" runat="server" AutoPostBack="True" Width="120px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Nombre Proveedor:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
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
            <td><uc1:ucListaSOLIC_QUEMANOPROG id="ucListaSOLIC_QUEMANOPROG1" runat="server"></uc1:ucListaSOLIC_QUEMANOPROG>
                <uc1:ucVistaDetalleSOLIC_QUEMANOPROG ID="ucVistaDetalleSOLIC_QUEMANOPROG1" runat="server" Visible="false" ></uc1:ucVistaDetalleSOLIC_QUEMANOPROG></td>
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

