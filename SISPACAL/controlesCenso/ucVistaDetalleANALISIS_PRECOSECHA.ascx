<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleANALISIS_PRECOSECHA.ascx.vb" Inherits="controlesCenso_ucVistaDetalleANALISIS_PRECOSECHA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register tagprefix="uc1" tagname="ucListaLOTES" Src="~/controlesContrato/ucListaLOTES.ascx" %>

<table width="100%" >
    <tr>
        <td align="center">
            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                <Items>
                    <dx:LayoutGroup Caption="Creando/Editando Orden de Análisis de Muestra de Caña" ColCount="3" >
                        <Items>
                            <dx:LayoutItem Caption="ID Analisis:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxTextBox ID="txtID_ANALISIS_PRE" runat="server" Width="120px">
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Zafra:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxComboBox ID="cbxZAFRA" runat="server" DataSourceID="odsZafra" ValueField="ID_ZAFRA" TextField="NOMBRE_ZAFRA" ValueType="System.Int32" Width="120px">
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:EmptyLayoutItem>
                            </dx:EmptyLayoutItem>
                            <dx:LayoutItem Caption="Fecha de Muestra:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxDateEdit ID="dteFECHA_MUESTRA"  runat="server" 
                                            DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="True" 
                                            EditFormatString="dd/MM/yyyy" Width="120px">
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Fecha de la muestra es obligatoria" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxDateEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="N° de Muestra:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="speNO_MUESTRA" runat="server" Width="120px" >
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="N° de Análisis:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="speNO_ANALISIS" runat="server" Width="120px" >
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="Cod. Proveedor según Contrato:">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxSpinEdit ID="speCODIPROVEE" runat="server" AutoPostBack="True" 
                                            Width="120px">
                                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                                <RequiredField ErrorText="Codigo de proveedor es obligatorio" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxSpinEdit>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>                
                            <dx:LayoutItem Caption="Nombre proveedor:" ColSpan="2">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxTextBox ID="txtNOMBRE_PROVEEDOR" runat="server" Width="100%">
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
</table>

<dx:ASPxLabel ID="lblDetalle" runat="server" Text="Seleccione el lote contratado del cual proviene la muestra" 
    ForeColor="#4881A2" Font-Bold="True" Font-Names="Arial" 
    Font-Size="Small" />
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />  
<uc1:ucListaLOTES id="ucListaLOTES1" MostrarCheckUnaSeleccion="true" NombreGridCliente="ucListaLOTES1" PermitirEditarInline="false" TipoEdicion="0" TamanoPagina="7" PermitirEliminar="false" runat="server" VerCUI="false" VerCODISOCIO="false" VerANIOZAFRA="false" PermitirEditar="false"></uc1:ucListaLOTES>
<asp:ObjectDataSource ID="odsZafra" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cZAFRA">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_ZAFRA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
