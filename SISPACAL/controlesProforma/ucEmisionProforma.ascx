<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucEmisionProforma.ascx.vb" Inherits="controlesProforma_ucEmisionProforma" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPLAN_COSECHA" Src="~/controlesProforma/ucListaPLAN_COSECHA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucEnvioProforma" Src="~/controlesProforma/ucEnvioProforma.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>




  
<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Emisión de Proforma</asp:Label></td>
		   </tr>
		   <tr>
			   <td>   
               <dx:ASPxFormLayout ID="ucCriteriosRegistroInventarioQuemaRoza" runat="server" SettingsItemCaptions-Location="Left" 
                    Name="glCriterios">
                       <Items>
                           <dx:LayoutGroup Caption="Criterios de búsqueda" ColCount="4" 
                               GroupBoxDecoration="HeadingLine">
                               <Items>
                                   <dx:LayoutItem Caption="Zafra:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                               <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px" AutoPostBack="true" >
                                                </dx:ASPxComboBox>
                                           </dx:LayoutItemNestedControlContainer>   
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Zona:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                               <dx:ASPxComboBox ID="cbxZONA" ClientInstanceName="cbxZONA" runat="server" DataSourceID="odsZona" TextField="DESCRIP_ZONA" ValueField="ZONA" Width="120px" >                            
                                               </dx:ASPxComboBox>         
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>                                  
                                   <dx:LayoutItem Caption="Catorcena" Visible="false" >
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                                               <dx:ASPxComboBox ID="cbxCATORCENA" runat="server" ValueType="System.Int32" 
                                                   Width="120px" DropDownStyle="DropDown" AutoPostBack="true" />
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Semana" Visible="false">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                                <dx:ASPxComboBox ID="cbxSEMANA" runat="server" ValueType="System.String" 
                                                    Width="120px" DropDownStyle="DropDownList" />
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>     
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                               
                                   <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                               
                                                                 
                                   <dx:LayoutItem Caption="Cod. Provee:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                                <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AllowNull="true"
                                                    Width="120px">
                                                </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Cod. Socio:">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                               <dx:ASPxSpinEdit ID="speCODISOCIO" runat="server"  AllowNull="true"
                                                   Width="120px">
                                               </dx:ASPxSpinEdit>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>
                                   <dx:LayoutItem Caption="Nombre Proveedor:" ColSpan="2">
                                       <LayoutItemNestedControlCollection>
                                           <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                                               <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="300px">
                                               </dx:ASPxTextBox>
                                           </dx:LayoutItemNestedControlContainer>
                                       </LayoutItemNestedControlCollection>
                                   </dx:LayoutItem>                                     
                               </Items>
                           </dx:LayoutGroup>
                       </Items>

<SettingsItemCaptions Location="Left"></SettingsItemCaptions>
                   </dx:ASPxFormLayout>
                </td>
		   </tr>
	       <tr>
            <td><uc1:ucListaPLAN_COSECHA id="ucListaPLAN_COSECHA1" 
                        PermitirRowHotTrack="false" runat="server"
                        VerZONA="true" VerCATORCENA="false" VerSEMANA="false" VerMZ_COSECHA="false" VerTONEL_COSECHA="false" 
                        VerFECHA_INI_COSECHA="false" VerFECHA_FIN_COSECHA="false" 
                        VerTOTAL_SEMANA="false" VerSALDO_QUEMA="true" PermitirEditar="false" PermitirEliminar="false" 
                        PermitirEmitirProforma="true" 
                ></uc1:ucListaPLAN_COSECHA> 
                <uc1:ucEnvioProforma ID="ucEnvioProforma1" TIPO_OPERACION="EmisionProforma" runat="server" Visible="false" ></uc1:ucEnvioProforma>                          
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
<asp:ObjectDataSource ID="odsZona" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZONAS">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="ZONA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>